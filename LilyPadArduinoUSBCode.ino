//Data Glove code by Rainer Doller

//vibe motor port association
const int vibeThumb = 3;     // Green - motor connected to pin 3
const int vibeIndex = 9;     // Orange - motor connected to PWM pin 9
const int vibeMiddle = 10;     // Yellow - motor connected to PWM pin 10
const int vibeRing = 11;     // Blue - motor connected to PWM pin 11
const int vibeLittle = A5;     // Grey - motor connected to PWM pin A5
const int vibePalm = 2;     // White - motor connected to pin 2

//settings to control vibrations
int selectedMotor = 0;
bool motorCombo[6] = {0, 0, 0, 0, 0, 0}; //vector represents the palm, thumb, index, middle, ring and little vibe motor
int onTime = 100;
int offTime = 30;
bool runPulse = false;
bool runPulseOffset = false;
bool runPulseT = false;
bool runPulseI = false;
bool runPulseM = false;
bool runPulseR = false;
double runPulseLength = 0;
float dynOn = 0; //dynamic pulse on time
float dynOff = 0; //dynamic pulse off time
float dynOnT = 0; //dynamic pulse on time - Thumb
float dynOffT = 0; //dynamic pulse off time - Thumb
float dynOnI = 0; //dynamic pulse on time - Index
float dynOffI = 0; //dynamic pulse off time - Index
float dynOnM = 0; //dynamic pulse on time - Middle
float dynOffM = 0; //dynamic pulse off time - Middle
float dynOnR = 0; //dynamic pulse on time - Ring
float dynOffR = 0; //dynamic pulse off time - Ring

//time control
double runTime = 0;  //General vibe
double startTime = 0; //General vibe
double currentTime = 0; //General vibe
double runTimeOffset = 0;  //General vibe Offset
double startTimeOffset = 0; //General vibe Offset
double currentTimeOffset = 0; //General vibe Offset
double runTimeT = 0;  //General vibe - Thumb
double startTimeT = 0; //General vibe - Thumb
double currentTimeT = 0; //General vibe - Thumb
double runTimeI = 0;  //General vibe - Index
double startTimeI = 0; //General vibe - Index
double currentTimeI = 0; //General vibe - Index
double runTimeM = 0;  //General vibe - Middle
double startTimeM = 0; //General vibe - Middle
double currentTimeM = 0; //General vibe - Middle
double runTimeR = 0;  //General vibe - Ring
double startTimeR = 0; //General vibe - Ring
double currentTimeR = 0; //General vibe - Ring

//vibration intensity levels for PWM
int intensity = 255;
int ThumbIntensity = 255;
int IndexIntensity = 255;
int MiddleIntensity = 255;
int RingIntensity = 255;
const int HighVibe = 255;
const int LowVibe = 111;
int AltVibe = 255;


//Flags
bool specialCmd = false;
bool Running = false;
bool Pause = false;
bool Start = false;
bool Pulse = false;
bool Stop = false;
bool trigger = false;
bool RunModePulse = false;
bool testMode = false; //Pulse vibe at alternating intensities 230 / 140 Hz
bool dynamicPulsing = false;
bool offsetPulse = false; //Offset the pulsing on every second location to help distinguise the pulsing.

//Visual feedback on Lilypad
const int ledPin =  LED_BUILTIN;     // LED pin

//Useful variables
int convCombo = 0;
int incomingByte = 0; //for incoming serial data
int incomingNum = 0; //for an incoming serial number
int limit = 0; //used to limit the number of digits read into incomingNum

void setup() {
  Serial.begin(9600); //setup serial monitor with baudrate

  pinMode(ledPin, OUTPUT); //visual feedback
  pinMode(vibeThumb, OUTPUT);
  pinMode(vibeIndex, OUTPUT);
  pinMode(vibeMiddle, OUTPUT);
  pinMode(vibeRing, OUTPUT);
  pinMode(vibeLittle, OUTPUT);
  pinMode(vibePalm, OUTPUT);

  startTime = millis();
  startTimeOffset = millis();
  startTimeT = millis();
  startTimeI = millis();
  startTimeM = millis();
  startTimeR = millis();
}

//Function that reads incoming numbers that start with < and end with >
void processInputNumber()
  {
    byte n = 0;
    incomingNum = 0;
    limit = 0;

    while (n != '>') {  //'>' is the endOfNumberDelimiter
      n = Serial.read ();
      limit += 1;

      switch (n){
        case '0' ... '9':
          incomingNum *= 10;
          incomingNum += n - '0';   
      }
      
      if (limit > 5) { //Stop reading the number if longer than 5 digits
        n = '>';      //endOfNumberDelimiter
        if (incomingNum <= 0) {
          incomingNum = 0;
        }
      }
    }
  }

void loop() {
  currentTime = millis();
  currentTimeOffset = currentTime;
  currentTimeT = currentTime;
  currentTimeI = currentTime;
  currentTimeM = currentTime;
  currentTimeR = currentTime;
  
  if (specialCmd > 0) {
    specialCmd = false;
    incomingByte = 10;
  }
  
  //Send data only when receiving data:
  if (Serial.available() > 0) {
    // read the incoming byte:
    incomingByte = Serial.read();
    //char c = Serial.read();    
    
    // print received:
    Serial.print("I received: ");
    Serial.println(incomingByte, DEC);

    //Process incoming numbers
    if (incomingByte == 60) { //startOfNumberDelimiter "<" to trigger number read. needs ">" at the end
      processInputNumber();      
      //specialCmd = true;
      incomingByte = Serial.read(); //read the next byte to determine what the number is for
    }

    //Check if serial input is a special command
    if (incomingByte == 115) {//Type s to trigger settings
      Serial.println("New settings:");

      byte c = Serial.read ();
      switch (c)
      {
        case '0' ... '9':
          onTime = (c-'0')*1000;
          Serial.print("On time: ");
          Serial.println(onTime);
          break;

        case 'r': //Set Running mode
          Running = true; 
          Pulse = false;
          Stop = false;
          testMode = false;
          break;

        case 'p': //Set Pulse mode
          Running = false;
          Pulse = true;
          Stop = false;
          Pause = true;
          testMode = false;
          trigger = true;
          break;

        case 's': //Stop Running mode
          Running = false; 
          Pulse = false;
          Stop = true;
          testMode = false;
          break;

        case 'x': //Start Running mode with pulses
          RunModePulse = true;
          break;

        case 'o': //Stop Running mode with pulses
          RunModePulse = false;
          break;

        case 'D': //Start dynamic pulsing
          dynamicPulsing = true;         
          break;

        case 'S': //Stop dynamic pulsing
          dynamicPulsing = false;
          break;

        case 'A': //Start alternative pulse intensity test mode
          testMode = true;         
          break;

        case 'N': //Stop alternative pulse intensity test mode
          testMode = false;
          break;  

        case 'O': //Start alternative pulse intensity test mode
          offsetPulse = true;         
          break;

        case 'P': //Stop alternative pulse intensity test mode
          offsetPulse = false;
          break;

        case 'n': //Set OnTime
          onTime = incomingNum;
          Serial.print("onTime: ");
          Serial.println(onTime);
          break;

        case 'f': //Set OffTime
          offTime = incomingNum;
          Serial.print("offTime: ");
          Serial.println(offTime);
          break;

        case 'z': //Reset button on GUI
          Running = false; 
          Pulse = false;
          Stop = false;
          testMode = false;
          break;

        case 'a':
          intensity = 111; //Set to 140Hz
          Serial.print("New intensity: ");
          Serial.println(intensity);
          break;

        case 'b':
          intensity = 143; //Set to 170Hz
          Serial.print("New intensity: ");
          Serial.println(intensity);
          break;

        case 'c':
          intensity = 191; //Set to 200Hz
          Serial.print("New intensity: ");
          Serial.println(intensity);
          break;

        case 'd':
          intensity = 255; //Set to 230Hz
          Serial.print("New intensity: ");
          Serial.println(intensity);
          break;
    } // end of switch
      
      specialCmd = true;
    }
    else if (incomingByte == 118) {//Type v to trigger vibration intensity settings
      byte i = Serial.read (); //vibe

        switch (i) //set intensity level
      {
        case 't':
          ThumbIntensity = incomingNum; //Set thumb intensity
          break;

        case 'i':
          IndexIntensity = incomingNum; //Set index intensity
          break;

        case 'm':
          MiddleIntensity = incomingNum; //Set middle intensity
          break;

        case 'r':
          RingIntensity = incomingNum; //Set ring intensity
          break;

        default:
          Serial.print("No new intensity selected: ");
          Serial.println(intensity);
      } // end of switch        
            
      specialCmd = true;
    }
    else if ((incomingByte == 112 || 116 || 105 || 109 || 114 ||  108) && (Pulse == true)){ //Only in pulse mode
      if (incomingByte == 112) {//Type p to select palm vibe
        selectedMotor = vibePalm;
        Serial.println("Active motor: Palm");
        specialCmd = true;
      }
      else if (incomingByte == 116) { //Type t to select thumb vibe
        selectedMotor = vibeThumb;
        Serial.println("Active motor: Thumb");
        specialCmd = true;
      }
      else if (incomingByte == 105){ //Type i to select index vibe
        selectedMotor = vibeIndex;
        Serial.println("Active motor: Index");
        specialCmd = true;
      }
      else if (incomingByte == 109) { //Type m to select middle vibe
        selectedMotor = vibeMiddle;
        Serial.println("Active motor: Middle");
        specialCmd = true;
      }
      else if (incomingByte == 114) { //Type r to select ring vibe
        selectedMotor = vibeRing;
        Serial.println("Active motor: Ring");
        specialCmd = true;
      }
      else if (incomingByte == 108) { //Type l to select little vibe
        selectedMotor = vibeLittle;
        Serial.println("Active motor: Little");
        specialCmd = true;
      }      
    }
    else if (incomingByte == 48) {//Type 0 to trigger pwm cycle
      Serial.println("Running: PWM fade cycle");
      specialCmd = true;
    }
    else if (incomingByte == 49) {//Type 1 to pulse 1 vibe
      Serial.println("Running: Pulse active motor");
      specialCmd = true;
    }
    else if (incomingByte == 97) {//Type a to pulse all vibes
      Serial.println("Running: Pulse all motors");
      specialCmd = true;
    }        
    else if (incomingByte == 99) {//Type c to select the vibe combination to run
      Serial.println("New motor combo:");

      byte m = Serial.read ();
      convCombo = m-'?'; //shift the ascii binary offset back to zero

      //Set each vibe according the the binary value of the input
      for (int i=0;i<6;i++) //only need the first 6 bits
      {
        motorCombo[i] = bitRead(convCombo,i);        
      }
      specialCmd = true;
    }
  }

  //Running Mode:
  if (Running == true && Pulse == false && Stop == false) {//Type sr to set Running mode

    //Set first interval and offset interval to pulse vibes during run mode (in an alternating pattern)
    if (RunModePulse == true && dynamicPulsing == false) {
      runTime = currentTime - startTime;
      runTimeOffset = currentTimeOffset - startTimeOffset;

      if (offsetPulse == true && runPulse == false && runPulseOffset == false && runTime >= ((onTime/2)+10)) { //force offset between the two pulse sets
        startTimeOffset = currentTimeOffset+10;
        runTimeOffset = 0;
        runPulseI = true;
        runPulseR = true;
        runPulseOffset = true;
      }
      
      if (runPulse == false && runTime >= onTime) { //run vibes on first set then stop after on Time elapsed
        startTime = currentTime;
        //runTime = 0;
        runPulse = true;
        runPulseT = true;
        runPulseM = true;
        if (offsetPulse == false) {
          runPulseI = true;
          runPulseR = true;
        }
      }
      else if (runPulse == true && runTime >= offTime) { //stop vibes on first set then start after off Time elapsed
        startTime = currentTime;
        //runTime = 0;
        runPulse = false;
        runPulseT = false;
        runPulseM = false;
        if (offsetPulse == false) {
          runPulseI = false;
          runPulseR = false;
        }
      }
      //Offset run pulse
      if (offsetPulse == true && runPulseOffset == false && runTimeOffset >= onTime) { //run vibes on offset set then stop after on Time elapsed
        startTimeOffset = currentTimeOffset;
        //runTimeOffset = 0;
        runPulseI = true;
        runPulseR = true;
        runPulseOffset = true;
      }
      else if (offsetPulse == true && runPulseOffset == true && runTimeOffset >= offTime) { //stop vibes on offset set then start after off Time elapsed
        startTimeOffset = currentTimeOffset;
        //runTimeOffset = 0;
        runPulseI = false;
        runPulseR = false;
        runPulseOffset = false;
      }
    }
    else if (RunModePulse == false && dynamicPulsing == false) {
      runPulse = false;
      runPulseT = false;
      runPulseI = false;
      runPulseM = false;
      runPulseR = false;
    }

    //Set Dynamic pulse mode    
    if (dynamicPulsing == true) {
      dynOn = 500; //max on time
      dynOff = 100; //max off time
      dynOnT = (2-float(ThumbIntensity)/111)*dynOn;
      dynOffT = (2-float(ThumbIntensity)/111)*dynOff;
      dynOnI = (2-float(IndexIntensity)/111)*dynOn;
      dynOffI = (2-float(IndexIntensity)/111)*dynOff;
      dynOnM = (2-float(MiddleIntensity)/111)*dynOn;
      dynOffM = (2-float(MiddleIntensity)/111)*dynOff;
      dynOnR = (2-float(RingIntensity)/111)*dynOn;
      dynOffR = (2-float(RingIntensity)/111)*dynOff;
      
      runTime = currentTime - startTime;
      runTimeT = currentTimeT - startTimeT;
      runTimeI = currentTimeI - startTimeI;
      runTimeM = currentTimeM - startTimeM;
      runTimeR = currentTimeR - startTimeR;
      
      /*if (runPulse == false && runTime >= dynOn) { //General
        startTime = currentTime;
        runTime = 0;
        runPulse = true;
      }
      else if (runPulse == true && runTime >= dynOff) {
        startTime = currentTime;
        runTime = 0;
        runPulse = false;
      }  */    
      if (runPulseT == false && runTimeT >= dynOnT && ThumbIntensity < 210) { //Thumb
        startTimeT = currentTimeT;
        runTimeT = 0;
        runPulseT = true;
      }
      else if (runPulseT == true && runTimeT >= dynOffT) {
        startTimeT = currentTimeT;
        runTimeT = 0;
        runPulseT = false;
      }
      if (runPulseI == false && runTimeI >= dynOnI && IndexIntensity < 210) { //Index
        startTimeI = currentTimeI;
        runTimeI = 0;
        runPulseI = true;
      }
      else if (runPulseI == true && runTimeI >= dynOffI) {
        startTimeI = currentTimeI;
        runTimeI = 0;
        runPulseI = false;
      }
      if (runPulseM == false && runTimeM >= dynOnM && MiddleIntensity < 210) { //Middle
        startTimeM = currentTimeM;
        runTimeM = 0;
        runPulseM = true;
      }
      else if (runPulseM == true && runTimeM >= dynOffM) {
        startTimeM = currentTimeM;
        runTimeM = 0;
        runPulseM = false;
      }
      if (runPulseR == false && runTimeR >= dynOnR && RingIntensity < 210) { //Ring
        startTimeR = currentTimeR;
        runTimeR = 0;
        runPulseR = true;
      }
      else if (runPulseR == true && runTimeR >= dynOffR) {
        startTimeR = currentTimeR;
        runTimeR = 0;
        runPulseR = false;
      }
    }
    else if (RunModePulse == false && dynamicPulsing == false) {
      runPulse = false;
      runPulseT = false;
      runPulseI = false;
      runPulseM = false;
      runPulseR = false;
    }
    
    digitalWrite(ledPin, HIGH);  // turn the LED on
    
    if (motorCombo[0] && runPulse == false){
        digitalWrite(vibePalm, HIGH);  //run palm vibe
    }
    else {
      digitalWrite(vibePalm, LOW);
    }
    if (motorCombo[1] && runPulseT == false){
      analogWrite(vibeThumb, ThumbIntensity);  //run thumb vibe
    }
    else {
      analogWrite(vibeThumb, 0);
    }
    if (motorCombo[2] && runPulseI == false){
      analogWrite(vibeIndex, IndexIntensity);  //run index vibe
    }
    else {
      analogWrite(vibeIndex, 0);
    }
    if (motorCombo[3] && runPulseM == false){
      analogWrite(vibeMiddle, MiddleIntensity);  //run middle vibe
    }
    else {
      analogWrite(vibeMiddle, 0);
    }
    if (motorCombo[4] && runPulseR == false){
      analogWrite(vibeRing, RingIntensity);  //run ring vibe
    }
    else {
      analogWrite(vibeRing, 0);
    }
    if (motorCombo[5] && runPulse == false){
      digitalWrite(vibeLittle, HIGH);  //run little vibe
    }
    else {
      digitalWrite(vibeLittle, LOW);
    }
  }

      //Pulse Mode:
  if (Pulse == true && Running == false && Stop == false && trigger == true) {//Type sp to set Pulse mode
    
    digitalWrite(ledPin, HIGH);  // turn the LED on
    if (motorCombo[0]){
        digitalWrite(vibePalm, HIGH);  //turn motor
    }
    else {
      digitalWrite(vibePalm, LOW);
    }
    if (motorCombo[1]){
      analogWrite(vibeThumb, ThumbIntensity);  //turn motor
    }
    else {
      analogWrite(vibeThumb, 0);
    }
    if (motorCombo[2]){
      analogWrite(vibeIndex, IndexIntensity);  //run index vibe
    }
    else {
      analogWrite(vibeIndex, 0);
    }
    if (motorCombo[3]){
      analogWrite(vibeMiddle, MiddleIntensity);  //turn motor
    }
    else {
      analogWrite(vibeMiddle, 0);
    }
    if (motorCombo[4]){
      analogWrite(vibeRing, RingIntensity);  //turn motor
    }
    else {
      analogWrite(vibeRing, 0);
    }
    if (motorCombo[5]){
      digitalWrite(vibeLittle, HIGH);  //turn motor
    }
    else {
      digitalWrite(vibeLittle, LOW);
    }

    delay(onTime);
 
    digitalWrite(ledPin, LOW);  // turn the LED off

    digitalWrite(vibePalm, LOW);
    analogWrite(vibeThumb, 0);
    analogWrite(vibeIndex, 0);
    analogWrite(vibeMiddle, 0);
    analogWrite(vibeRing, 0);    
    digitalWrite(vibeLittle, LOW);
    
    delay(offTime);
  }

  //Pulse all motors
  if (incomingByte == 97 && Stop == false) //Type a to pulse all vibes
  {
  Serial.println("Turn LilyPad Vibe Motors And LED ON");
  digitalWrite(ledPin, HIGH);  // turn the LED on
  analogWrite(vibeThumb, ThumbIntensity);  //turn motor
  analogWrite(vibeIndex, IndexIntensity);  //turn motor
  analogWrite(vibeMiddle, MiddleIntensity);  //turn motor
  analogWrite(vibeRing, RingIntensity);  //turn motor
  digitalWrite(vibeLittle, HIGH);  //turn motor
  digitalWrite(vibePalm, HIGH);  //turn motor
  delay(onTime);

  Serial.println("Turn LilyPad Vibe Motors And LED OFF");
  digitalWrite(ledPin, LOW);  // turn the LED off
  analogWrite(vibeThumb, 0);   //turn motor off
  analogWrite(vibeIndex, 0);   //turn motor off
  analogWrite(vibeMiddle, 0);  //turn motor
  analogWrite(vibeRing, 0);  //turn motor
  digitalWrite(vibeLittle, LOW);  //turn motor
  digitalWrite(vibePalm, LOW);  //turn motor
  delay(offTime);
  }

  //Type 1 to pulse selected vibe
  if (incomingByte == 49 && selectedMotor > 0 && Running == false && Pulse == true && Stop == false) 
  {
    //Turn LilyPad Vibe Motor And LED ON
    digitalWrite(ledPin, HIGH);  // turn the LED on
    if (selectedMotor == vibePalm || vibeLittle) {
      digitalWrite(selectedMotor, HIGH);
    } else {
      analogWrite(selectedMotor, intensity);  //turn selected vibe on
    }    
    delay(100);//onTime);
  
    Serial.println("Turn LilyPad Vibe Motor And LED OFF");
    digitalWrite(ledPin, LOW);  // turn the LED off
    if (selectedMotor == vibePalm || vibeLittle) {
      digitalWrite(selectedMotor, LOW);
    } else {
      analogWrite(selectedMotor, 0);   //turn vibe off
    }    
    delay(100);//offTime);
  }  

  //Type 0 to trigger PWM cycle
  if (incomingByte == 48 && selectedMotor > 0 && Pulse == true && Stop == false) 
  {
  digitalWrite(ledPin, HIGH);  // turn the LED on
  //Check Intensity of Motor (turns on at about 130
  // fade in from min to max in increments of 5 points:
  for (int fadeValue = 0 ; fadeValue <= 255; fadeValue += 5) {
    // sets the value (range from 0 to 255):
    analogWrite(selectedMotor, fadeValue);
    Serial.print("UP: LilyPad Vibe Motor Intensity = ");
    Serial.println(fadeValue);

    // wait for 100 milliseconds to see motor
    delay(100);
  }
  delay(onTime);//-100); //minus the delay in the for loop
  // fade out from max to min in increments of 5 points:
  for (int fadeValue = 255 ; fadeValue >= 0; fadeValue -= 5) {
    // sets the value (range from 0 to 255):
    analogWrite(selectedMotor, fadeValue);
    Serial.print("DOWN: LilyPad Vibe Motor Intensity = ");
    Serial.println(fadeValue);

    digitalWrite(ledPin, LOW);  // turn the LED off
    // wait for 100 milliseconds to see motor
    delay(100);
  }
  delay(offTime);//-100);
  }

  //Type sA to trigger test mode
  if (testMode == true && Running == true && Pulse == false && Stop == false) 
  {
  digitalWrite(ledPin, HIGH);  // turn the LED on

  if (motorCombo[0]){
        digitalWrite(vibePalm, HIGH);  //turn motor
    }
    else {
      digitalWrite(vibePalm, LOW);
    }
    if (motorCombo[1]){
      analogWrite(vibeThumb, AltVibe);  //turn motor
    }
    else {
      analogWrite(vibeThumb, 0);
    }
    if (motorCombo[2]){
      analogWrite(vibeIndex, AltVibe);  //run index vibe
    }
    else {
      analogWrite(vibeIndex, 0);
    }
    if (motorCombo[3]){
      analogWrite(vibeMiddle, AltVibe);  //turn motor
    }
    else {
      analogWrite(vibeMiddle, 0);
    }
    if (motorCombo[4]){
      analogWrite(vibeRing, AltVibe);  //turn motor
    }
    else {
      analogWrite(vibeRing, 0);
    }
    if (motorCombo[5]){
      digitalWrite(vibeLittle, HIGH);  //turn motor
    }
    else {
      digitalWrite(vibeLittle, LOW);
    }
  
    delay(onTime);
 
    digitalWrite(ledPin, LOW);  // turn the LED off

    digitalWrite(vibePalm, LOW);
    analogWrite(vibeThumb, 0);
    analogWrite(vibeIndex, 0);
    analogWrite(vibeMiddle, 0);
    analogWrite(vibeRing, 0);    
    digitalWrite(vibeLittle, LOW);
    
    delay(offTime);
    
    if (AltVibe == HighVibe){
      AltVibe = LowVibe;
    } else {
      AltVibe = HighVibe;
    }
  }

  //Stop mode
  if ((Stop == true) || (Pause == true)) {
      digitalWrite(ledPin, LOW);  // turn the LED off
      analogWrite(vibeThumb, 0);   //turn motor off
      analogWrite(vibeIndex, 0);   //turn motor off
      analogWrite(vibeMiddle, 0);  //turn motor
      analogWrite(vibeRing, 0);  //turn motor
      digitalWrite(vibeLittle, LOW);  //turn motor
      digitalWrite(vibePalm, LOW);  //turn motor
      Pause = false;
    }
  
  //currentTime = millis();
  //runTime = currentTime-startTime;
  //Serial.print("cycleTime: ");
  //Serial.println(runTime);
  trigger = false;
}
