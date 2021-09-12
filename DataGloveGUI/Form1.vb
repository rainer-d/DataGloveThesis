Imports System.IO
Imports System.IO.Ports 'To Access the SerialPort Object
Imports System.Threading

Public Class Form1
    Shared SerialConnection As Boolean
    Shared spPort As SerialPort
    Shared Run As Boolean
    Shared Stopped As Boolean
    Shared RunSeq As Boolean
    Shared Pulse As Boolean
    Shared PalmSelected As Boolean
    Shared ThumbSelected As Boolean
    Shared IndexSelected As Boolean
    Shared MiddleSelected As Boolean
    Shared RingSelected As Boolean
    Shared LittleSelected As Boolean
    Shared MotorCombo As Byte = 63
    Shared EArg As EventArgs

    Private Sub ScanPortsBtn_Click(sender As Object, e As EventArgs) Handles ScanPortsBtn.Click
        Dim myPort As Array
        Dim i As Integer
        myPort = SerialPort.GetPortNames()
        CmbSerialPorts.Items.Clear()
        CmbSerialPorts.Items.AddRange(myPort)
        i = CmbSerialPorts.Items.Count
        i = i - i
        Try
            CmbSerialPorts.SelectedIndex = i
            SerialConnectBtn.Enabled = True

            CmbBaudRate.Items.Clear()
            CmbBaudRate.Items.Add(2400)
            CmbBaudRate.Items.Add(4800)
            CmbBaudRate.Items.Add(9600)
            CmbBaudRate.Items.Add(19200)
            CmbBaudRate.Items.Add(38400)
            CmbBaudRate.Items.Add(57600)
            CmbBaudRate.Text = 9600
        Catch ex As Exception
            MsgBox("No active COM port detected", MsgBoxStyle.Critical, "COM PORT ERROR:")
            CmbSerialPorts.Text = ""
            CmbSerialPorts.Items.Clear()
            Return
        End Try
        CmbSerialPorts.DroppedDown = True
        ConnectionPanel.Focus()
    End Sub

    Private Sub CmbBaudRate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBaudRate.SelectedIndexChanged
        ConnectionPanel.Focus()
    End Sub

    Private Sub SerialConnectBtn_Click(sender As Object, e As EventArgs) Handles SerialConnectBtn.Click
        ConnectionPanel.Focus()
        spPort = New SerialPort()
        Try
            spPort.BaudRate = CmbBaudRate.SelectedItem
            spPort.PortName = CmbSerialPorts.SelectedItem
            spPort.Open()
            spPort.ReadTimeout = 10000
            ConStatus.Visible = False
            'TimerSerial.Start()

            'LabelStatus.Text = "Status : Connected"
            SerialConnectBtn.SendToBack()
            SerialDisconnectBtn.BringToFront()
            ConnectionStatusBox.BackColor = Color.Green
            SerialConnection = True
        Catch ex As Exception
            MsgBox("Please check the Glove cable, COM port and/or Baud Rate and try again.", MsgBoxStyle.Critical, "CONNECTION FAILED:")
        End Try
    End Sub

    Private Sub CmbSerialPorts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSerialPorts.SelectedIndexChanged
        ConnectionPanel.Focus()
    End Sub

    Private Sub SerialDisconnectBtn_Click(sender As Object, e As EventArgs) Handles SerialDisconnectBtn.Click
        ConnectionPanel.Focus()
        'TimerSerial.Stop()
        'LabelStatus.Text = "Status : Disconnect"
        'PictureBoxConnectionStatus.Visible = True
        SerialDisconnection()

    End Sub

    Private Sub ConnectionStatusBox_Click(sender As Object, e As EventArgs) Handles ConnectionStatusBox.Click
        ConnectionPanel.Focus()
    End Sub

    Private Sub ConnectionStatus_Click(sender As Object, e As EventArgs) Handles ConnectionStatus.Click
        ConnectionPanel.Focus()
    End Sub

    Private Sub RunButton_Click(sender As Object, e As EventArgs) Handles RunButton.Click
        'Console.WriteLine("{0}", "a")

        If SerialConnection = True And Run = False Then
            Run = True
            Stopped = False
            RunSeq = False
            Pulse = False
            RunButton.BackColor = Color.LightGreen
            PulseButton.BackColor = Color.LightGray
            StopButton.BackColor = Color.LightGray

            spPort.WriteLine("sr")

            RunButton.BackColor = Color.Green

        End If
    End Sub

    Private Sub PulseButton_Click(sender As Object, e As EventArgs) Handles PulseButton.Click
        If SerialConnection = True Then
            Run = False
            Stopped = False
            RunSeq = False
            Pulse = True
            StopButton.BackColor = Color.LightGray
            PulseButton.BackColor = Color.LightBlue
            RunButton.BackColor = Color.LightGray

            'If PalmVibe_Active.Checked = True Then
            '    PalmVibe_Active_CheckedChanged(False, EArg)
            'End If
            'If ThumbVibe_Active.Checked = True Then
            '    ThumbVibe_Active_CheckedChanged(False, EArg)
            'End If
            'If IndexVibe_Active.Checked = True Then
            '    IndexVibe_Active_CheckedChanged(False, EArg)
            'End If
            'If MiddleVibe_Active.Checked = True Then
            '    MiddleVibe_Active_CheckedChanged(False, EArg)
            'End If
            'If RingVibe_Active.Checked = True Then
            '    RingVibe_Active_CheckedChanged(False, EArg)
            'End If
            'If LittleVibe_Active.Checked = True Then
            '    LittleVibe_Active_CheckedChanged(False, EArg)
            'End If

            spPort.WriteLine("sp")

            PulseButton.BackColor = Color.Gray
        End If
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        If SerialConnection = True Then
            Run = False
            Stopped = True
            RunSeq = False
            Pulse = False

            StopButton.BackColor = Color.Orange
            PulseButton.BackColor = Color.LightGray
            RunButton.BackColor = Color.LightGray

            spPort.WriteLine("ss")

            StopButton.BackColor = Color.Red
        End If

    End Sub

    Private Sub SerialComsBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SerialComsBox.SelectedIndexChanged

    End Sub

    Function SerialDisconnection() As String
        spPort.WriteLine("ss")
        SerialDisconnectBtn.SendToBack()
        SerialConnectBtn.BringToFront()
        ConnectionStatusBox.BackColor = Color.Red
        RunButton.BackColor = Color.LightGray
        StopButton.BackColor = Color.LightGray
        Run = False
        Stopped = True
        RunSeq = False
        Pulse = False
        SerialConnection = False
        ConStatus.Visible = True
        spPort.Close()
        Return "Disconnected"
    End Function

    Private Sub SelectAll_Click(sender As Object, e As EventArgs) Handles SelectAll.Click
        PalmVibe_Active.Checked = True
        ThumbVibe_Active.Checked = True
        IndexVibe_Active.Checked = True
        MiddleVibe_Active.Checked = True
        RingVibe_Active.Checked = True
        LittleVibe_Active.Checked = True
    End Sub

    Private Sub ClearAll_Click(sender As Object, e As EventArgs) Handles ClearAll.Click
        PalmVibe_Active.Checked = False
        ThumbVibe_Active.Checked = False
        IndexVibe_Active.Checked = False
        MiddleVibe_Active.Checked = False
        RingVibe_Active.Checked = False
        LittleVibe_Active.Checked = False
    End Sub

    Private Sub PalmVibe_Active_CheckedChanged(sender As Object, e As EventArgs) Handles PalmVibe_Active.CheckedChanged
        If SerialConnection Then
            If Pulse Then
                If PalmVibe_Active.Checked = True Then
                    spPort.WriteLine("p1")
                End If
            End If
            MotorComboControl()
        End If

    End Sub

    Private Sub ThumbVibe_Active_CheckedChanged(sender As Object, e As EventArgs) Handles ThumbVibe_Active.CheckedChanged
        If SerialConnection Then
            If Pulse Then
                If ThumbVibe_Active.Checked = True Then
                    spPort.WriteLine("t1")
                End If
            End If
            MotorComboControl()
        End If

    End Sub

    Private Sub IndexVibe_Active_CheckedChanged(sender As Object, e As EventArgs) Handles IndexVibe_Active.CheckedChanged
        If SerialConnection Then
            If Pulse Then
                If IndexVibe_Active.Checked = True Then
                    spPort.WriteLine("i1")
                End If
            End If
            MotorComboControl()
        End If

    End Sub

    Private Sub MiddleVibe_Active_CheckedChanged(sender As Object, e As EventArgs) Handles MiddleVibe_Active.CheckedChanged
        If SerialConnection Then
            If Pulse Then
                If MiddleVibe_Active.Checked = True Then
                    spPort.WriteLine("m1")
                End If
            End If
            MotorComboControl()
        End If

    End Sub

    Private Sub RingVibe_Active_CheckedChanged(sender As Object, e As EventArgs) Handles RingVibe_Active.CheckedChanged
        If SerialConnection Then
            If Pulse Then
                If RingVibe_Active.Checked = True Then
                    spPort.WriteLine("r1")
                End If
            End If
            MotorComboControl()
        End If

    End Sub

    Private Sub LittleVibe_Active_CheckedChanged(sender As Object, e As EventArgs) Handles LittleVibe_Active.CheckedChanged
        If SerialConnection Then
            If Pulse Then
                If LittleVibe_Active.Checked = True Then
                    spPort.WriteLine("l1")
                End If
            End If
            MotorComboControl()
        End If

    End Sub

    Function MotorComboControl() As String
        If SerialConnection Then
            If PalmVibe_Active.Checked = True Then
                If PalmSelected = False Then
                    MotorCombo += 1
                    PalmSelected = True
                    PalmVibe.ForeColor = Color.Yellow
                End If
            ElseIf PalmVibe_Active.Checked = False Then
                If PalmSelected = True Then
                    MotorCombo -= 1
                    PalmSelected = False
                    PalmVibe.ForeColor = Color.Black
                End If
            End If

            If ThumbVibe_Active.Checked = True Then
                If ThumbSelected = False Then
                    MotorCombo += 2
                    ThumbSelected = True
                    ThumbVibe.ForeColor = Color.Yellow
                End If
            ElseIf ThumbVibe_Active.Checked = False Then
                If ThumbSelected = True Then
                    MotorCombo -= 2
                    ThumbSelected = False
                    ThumbVibe.ForeColor = Color.Black
                End If
            End If

            If IndexVibe_Active.Checked = True Then
                If IndexSelected = False Then
                    MotorCombo += 4
                    IndexSelected = True
                    IndexVibe.ForeColor = Color.Yellow
                End If
            ElseIf IndexVibe_Active.Checked = False Then
                If IndexSelected = True Then
                    MotorCombo -= 4
                    IndexSelected = False
                    IndexVibe.ForeColor = Color.Black
                End If
            End If

            If MiddleVibe_Active.Checked = True Then
                If MiddleSelected = False Then
                    MotorCombo += 8
                    MiddleSelected = True
                    MiddleVibe.ForeColor = Color.Yellow
                End If
            ElseIf MiddleVibe_Active.Checked = False Then
                If MiddleSelected = True Then
                    MotorCombo -= 8
                    MiddleSelected = False
                    MiddleVibe.ForeColor = Color.Black
                End If
            End If

            If RingVibe_Active.Checked = True Then
                If RingSelected = False Then
                    MotorCombo += 16
                    RingSelected = True
                    RingVibe.ForeColor = Color.Yellow
                End If
            ElseIf RingVibe_Active.Checked = False Then
                If RingSelected = True Then
                    MotorCombo -= 16
                    RingSelected = False
                    RingVibe.ForeColor = Color.Black
                End If
            End If

            If LittleVibe_Active.Checked = True Then
                If LittleSelected = False Then
                    MotorCombo += 32
                    LittleSelected = True
                    LittleVibe.ForeColor = Color.Yellow
                End If
            ElseIf LittleVibe_Active.Checked = False Then
                If LittleSelected = True Then
                    MotorCombo -= 32
                    LittleSelected = False
                    LittleVibe.ForeColor = Color.Black
                End If
            End If

            SerialComsBoxUpdate()
        End If
        Return "MotorComboUpdated"
    End Function

    Function SerialComsBoxUpdate() As String
        spPort.WriteLine("c" & Convert.ToChar(MotorCombo))
        SerialComsBox.SelectedIndex = SerialComsBox.Items.Count - 1
        Return "Updated"
    End Function

    Function StopControl() As String
        'add stop interupt
        Return "Stopped"
    End Function

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub SerialSend_Click(sender As Object, e As EventArgs) Handles SerialSend.Click
        If SerialConnection Then
            spPort.WriteLine(SerialInput.Text)


        End If
    End Sub

    'Serial Port Receiving Code Starts Here ….
    Private Sub SerialPort_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs)
        'TextBox1.Text = ""
        Try

            Do
                Dim Incoming As String = spPort.ReadByte
                If Incoming Is Nothing Then
                    Exit Try
                Else
                    SerialComsBox.Items.Add(Incoming.ToString) ' & vbCrLf)
                End If
            Loop
        Catch ex As TimeoutException
            SerialComsBox.Items.Add("Error: Serial Port read timed out.")
        Finally
            If spPort IsNot Nothing Then
                'SerialDisconnection()
                SerialComsBox.Items.Add("disconnect")
            End If
        End Try

    End Sub
    'Serial Port Receiving Code Ends Here ….

    Private Sub PWM_Thumb_Scroll(sender As Object, e As EventArgs) Handles PWM_Thumb.Scroll
        If SerialConnection Then
            spPort.WriteLine("<" & PWM_Thumb.Value & ">" & "vt")
            ThumbPWM.Text = PWM_Thumb.Value.ToString
        End If
    End Sub

    Private Sub PWM_Index_Scroll(sender As Object, e As EventArgs) Handles PWM_Index.Scroll
        If SerialConnection Then
            spPort.WriteLine("<" & PWM_Index.Value & ">" & "vi")
            IndexPWM.Text = PWM_Index.Value.ToString
        End If
    End Sub

    Private Sub PWM_Middle_Scroll(sender As Object, e As EventArgs) Handles PWM_Middle.Scroll
        If SerialConnection Then
            spPort.WriteLine("<" & PWM_Middle.Value & ">" & "vm")
            MiddlePWM.Text = PWM_Middle.Value.ToString
        End If
    End Sub

    Private Sub PWM_Ring_Scroll(sender As Object, e As EventArgs) Handles PWM_Ring.Scroll
        If SerialConnection Then
            spPort.WriteLine("<" & PWM_Ring.Value & ">" & "vr")
            RingPWM.Text = PWM_Ring.Value.ToString
        End If
    End Sub

    Private Sub ThumbPWM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ThumbPWM.SelectedIndexChanged
        If SerialConnection Then
            spPort.WriteLine("<" & ThumbPWM.SelectedItem & ">" & "vt")
            PWM_Thumb.Value = ThumbPWM.SelectedItem
        End If
    End Sub

    Private Sub IndexPWM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IndexPWM.SelectedIndexChanged
        If SerialConnection Then
            spPort.WriteLine("<" & IndexPWM.SelectedItem & ">" & "vi")
            PWM_Index.Value = IndexPWM.SelectedItem
        End If
    End Sub

    Private Sub MiddlePWM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MiddlePWM.SelectedIndexChanged
        If SerialConnection Then
            spPort.WriteLine("<" & MiddlePWM.SelectedItem & ">" & "vm")
            PWM_Middle.Value = MiddlePWM.SelectedItem
        End If
    End Sub

    Private Sub RingPWM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RingPWM.SelectedIndexChanged
        If SerialConnection Then
            spPort.WriteLine("<" & RingPWM.SelectedItem & ">" & "vr")
            PWM_Ring.Value = RingPWM.SelectedItem
        End If
    End Sub

    Private Sub ThumbPWM_KeyDown(sender As Object, e As KeyEventArgs) Handles ThumbPWM.KeyDown
        If SerialConnection And e.KeyCode = 13 Then
            If Convert.ToInt32(ThumbPWM.Text) > 255 Then
                ThumbPWM.Text = 255
            ElseIf Convert.ToInt32(ThumbPWM.Text) < 0 Then
                ThumbPWM.Text = 0
            End If
            spPort.WriteLine("<" & ThumbPWM.Text & ">" & "vt")
            PWM_Thumb.Value = Convert.ToInt32(ThumbPWM.Text)
            e.SuppressKeyPress = True 'Stop ding sound
            ThumbPWM.Focus()
        End If
    End Sub

    Private Sub IndexPWM_KeyDown(sender As Object, e As KeyEventArgs) Handles IndexPWM.KeyDown
        If SerialConnection And e.KeyCode = 13 Then
            If Convert.ToInt32(IndexPWM.Text) > 255 Then
                IndexPWM.Text = 255
            ElseIf Convert.ToInt32(IndexPWM.Text) < 0 Then
                IndexPWM.Text = 0
            End If
            spPort.WriteLine("<" & IndexPWM.Text & ">" & "vi")
            PWM_Index.Value = Convert.ToInt32(IndexPWM.Text)
            e.SuppressKeyPress = True 'Stop ding sound
            IndexPWM.Focus()
        End If
    End Sub

    Private Sub MiddlePWM_KeyDown(sender As Object, e As KeyEventArgs) Handles MiddlePWM.KeyDown
        If SerialConnection And e.KeyCode = 13 Then
            If Convert.ToInt32(MiddlePWM.Text) > 255 Then
                MiddlePWM.Text = 255
            ElseIf Convert.ToInt32(MiddlePWM.Text) < 0 Then
                MiddlePWM.Text = 0
            End If
            spPort.WriteLine("<" & MiddlePWM.Text & ">" & "vm")
            PWM_Middle.Value = Convert.ToInt32(MiddlePWM.Text)
            e.SuppressKeyPress = True 'Stop ding sound
            MiddlePWM.Focus()
        End If
    End Sub

    Private Sub RingPWM_KeyDown(sender As Object, e As KeyEventArgs) Handles RingPWM.KeyDown
        If SerialConnection And e.KeyCode = 13 Then
            If Convert.ToInt32(RingPWM.Text) > 255 Then
                RingPWM.Text = 255
            ElseIf Convert.ToInt32(RingPWM.Text) < 0 Then
                RingPWM.Text = 0
            End If
            spPort.WriteLine("<" & RingPWM.Text & ">" & "vr")
            PWM_Ring.Value = Convert.ToInt32(RingPWM.Text)
            e.SuppressKeyPress = True 'Stop ding sound
            RingPWM.Focus()
        End If
    End Sub

    Private Sub ThumbPWM_DropDown(sender As Object, e As EventArgs) Handles ThumbPWM.DropDown
        ThumbPWM.Items.Clear()
        ThumbPWM.Items.Add(255)
        ThumbPWM.Items.Add(191)
        ThumbPWM.Items.Add(143)
        ThumbPWM.Items.Add(111)
        ThumbPWM.Items.Add(0)

    End Sub

    Private Sub IndexPWM_DropDown(sender As Object, e As EventArgs) Handles IndexPWM.DropDown
        IndexPWM.Items.Clear()
        IndexPWM.Items.Add(255)
        IndexPWM.Items.Add(191)
        IndexPWM.Items.Add(143)
        IndexPWM.Items.Add(111)
        IndexPWM.Items.Add(0)
    End Sub

    Private Sub MiddlePWM_DropDown(sender As Object, e As EventArgs) Handles MiddlePWM.DropDown
        MiddlePWM.Items.Clear()
        MiddlePWM.Items.Add(255)
        MiddlePWM.Items.Add(191)
        MiddlePWM.Items.Add(143)
        MiddlePWM.Items.Add(111)
        MiddlePWM.Items.Add(0)
    End Sub

    Private Sub RingPWM_DropDown(sender As Object, e As EventArgs) Handles RingPWM.DropDown
        RingPWM.Items.Clear()
        RingPWM.Items.Add(255)
        RingPWM.Items.Add(191)
        RingPWM.Items.Add(143)
        RingPWM.Items.Add(111)
        RingPWM.Items.Add(0)
    End Sub

    Private Sub SerialInput_KeyDown(sender As Object, e As KeyEventArgs) Handles SerialInput.KeyDown
        If SerialConnection And e.KeyCode = 13 Then
            SerialSend_Click(False, EArg)
            'e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub PWMButton_Click(sender As Object, e As EventArgs) Handles PWMthumbBtn.Click
        If SerialConnection And Not Stopped Then
            spPort.WriteLine("t0")
        End If
    End Sub

    Private Sub PWMindexBtn_Click(sender As Object, e As EventArgs) Handles PWMindexBtn.Click
        If SerialConnection And Not Stopped Then
            spPort.WriteLine("i0")
        End If
    End Sub

    Private Sub PWMmiddleBtn_Click(sender As Object, e As EventArgs) Handles PWMmiddleBtn.Click
        If SerialConnection And Not Stopped Then
            spPort.WriteLine("m0")
        End If
    End Sub

    Private Sub PWMringBtn_Click(sender As Object, e As EventArgs) Handles PWMringBtn.Click
        If SerialConnection And Not Stopped Then
            spPort.WriteLine("r0")
        End If
    End Sub

    Private Sub PalmVibe_Click(sender As Object, e As EventArgs) Handles PalmVibe.Click
        If SerialConnection Then
            If PalmVibe_Active.Checked Then
                PalmVibe_Active.Checked = False
            ElseIf Not PalmVibe_Active.Checked Then
                PalmVibe_Active.Checked = True
            End If
        End If
    End Sub

    Private Sub ThumbVibe_Click(sender As Object, e As EventArgs) Handles ThumbVibe.Click
        If SerialConnection Then
            If ThumbVibe_Active.Checked Then
                ThumbVibe_Active.Checked = False
            ElseIf Not ThumbVibe_Active.Checked Then
                ThumbVibe_Active.Checked = True
            End If
        End If
    End Sub

    Private Sub IndexVibe_Click(sender As Object, e As EventArgs) Handles IndexVibe.Click
        If SerialConnection Then
            If IndexVibe_Active.Checked Then
                IndexVibe_Active.Checked = False
            ElseIf Not IndexVibe_Active.Checked Then
                IndexVibe_Active.Checked = True
            End If
        End If
    End Sub

    Private Sub MiddleVibe_Click(sender As Object, e As EventArgs) Handles MiddleVibe.Click
        If SerialConnection Then
            If MiddleVibe_Active.Checked Then
                MiddleVibe_Active.Checked = False
            ElseIf Not MiddleVibe_Active.Checked Then
                MiddleVibe_Active.Checked = True
            End If
        End If
    End Sub

    Private Sub RingVibe_Click(sender As Object, e As EventArgs) Handles RingVibe.Click
        If SerialConnection Then
            If RingVibe_Active.Checked Then
                RingVibe_Active.Checked = False
            ElseIf Not RingVibe_Active.Checked Then
                RingVibe_Active.Checked = True
            End If
        End If
    End Sub

    Private Sub LittleVibe_Click(sender As Object, e As EventArgs) Handles LittleVibe.Click
        If SerialConnection Then
            If LittleVibe_Active.Checked Then
                LittleVibe_Active.Checked = False
            ElseIf Not LittleVibe_Active.Checked Then
                LittleVibe_Active.Checked = True
            End If
        End If
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        If SerialConnection = True Then
            Run = False
            Stopped = True
            RunSeq = False
            Pulse = False

            StopButton.BackColor = Color.LightGray
            PulseButton.BackColor = Color.LightGray
            RunButton.BackColor = Color.LightGray

            spPort.WriteLine("<" & 255 & ">" & "vt" & "vi" & "vm" & "vr") 'set all pwm to 255
            PWM_Thumb.Value = 255
            PWM_Index.Value = 255
            PWM_Middle.Value = 255
            PWM_Ring.Value = 255
            ThumbPWM.Text = 255
            IndexPWM.Text = 255
            MiddlePWM.Text = 255
            RingPWM.Text = 255

            PalmVibe_Active.Checked = False
            ThumbVibe_Active.Checked = False
            IndexVibe_Active.Checked = False
            MiddleVibe_Active.Checked = False
            RingVibe_Active.Checked = False
            LittleVibe_Active.Checked = False

            RunPulse.Checked = False
            spPort.WriteLine("so") 'clear the rub pulse flag

            spPort.WriteLine("sz") 'reset variable values command

            spPort.WriteLine("ss") 'stop command
        End If
    End Sub

    Private Sub OnTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OnTime.SelectedIndexChanged
        If SerialConnection Then
            spPort.WriteLine("<" & OnTime.SelectedItem & ">" & "sn")
        End If
    End Sub

    Private Sub OffTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OffTime.SelectedIndexChanged
        If SerialConnection Then
            spPort.WriteLine("<" & OffTime.SelectedItem & ">" & "sf")
        End If
    End Sub

    Private Sub OnTime_KeyDown(sender As Object, e As KeyEventArgs) Handles OnTime.KeyDown
        If SerialConnection And e.KeyCode = 13 Then
            spPort.WriteLine("<" & OnTime.Text & ">" & "sn")
            e.SuppressKeyPress = True 'Stop ding sound
            OnTime.Focus()
        End If
    End Sub

    Private Sub OffTime_KeyDown(sender As Object, e As KeyEventArgs) Handles OffTime.KeyDown
        If SerialConnection And e.KeyCode = 13 Then
            spPort.WriteLine("<" & OffTime.Text & ">" & "sf")
            e.SuppressKeyPress = True 'Stop ding sound
            OffTime.Focus()
        End If
    End Sub

    Private Sub OnTime_SelectedDropDown(sender As Object, e As EventArgs) Handles OnTime.DropDown
        OnTime.Items.Clear()
        OnTime.Items.Add(0)
        OnTime.Items.Add(50)
        OnTime.Items.Add(100)
        OnTime.Items.Add(300)
        OnTime.Items.Add(500)
        OnTime.Items.Add(1000)
        OnTime.Items.Add(2000)
        OnTime.Items.Add(3000)
        OnTime.Items.Add(5000)
        OnTime.Items.Add(10000)
    End Sub

    Private Sub OffTime_SelectedDropDown(sender As Object, e As EventArgs) Handles OffTime.DropDown
        OffTime.Items.Clear()
        OffTime.Items.Add(0)
        OffTime.Items.Add(20)
        OffTime.Items.Add(30)
        OffTime.Items.Add(50)
        OffTime.Items.Add(100)
        OffTime.Items.Add(300)
        OffTime.Items.Add(500)
        OffTime.Items.Add(1000)
        OffTime.Items.Add(2000)
    End Sub

    Private Sub RandomSelectNum_DropDown(sender As Object, e As EventArgs) Handles RandomSelectNum.DropDown
        RandomSelectNum.Items.Clear()
        RandomSelectNum.Items.Add(1)
        RandomSelectNum.Items.Add(2)
        RandomSelectNum.Items.Add(3)
        RandomSelectNum.Items.Add(4)
        RandomSelectNum.Items.Add(5)
    End Sub

    Private Sub RandomSelectNum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RandomSelectNum.KeyPress
        e.Handled = True
    End Sub

    Private Sub RandomSelectNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RandomSelectNum.SelectedIndexChanged

    End Sub

    Private Sub RunPulse_CheckedChanged(sender As Object, e As EventArgs) Handles RunPulse.CheckedChanged
        If SerialConnection Then
            If RunPulse.Checked Then ''start run pulse
                DynamicPulse.Checked = False
                AltTest.Checked = False
                spPort.WriteLine("sx")
            ElseIf Not RunPulse.Checked Then ''stop run pulse
                spPort.WriteLine("so")
            End If
        End If
    End Sub

    Private Sub AltTest_CheckedChanged(sender As Object, e As EventArgs) Handles AltTest.CheckedChanged
        If SerialConnection Then
            If AltTest.Checked Then
                RunPulse.Checked = False
                DynamicPulse.Checked = False
                spPort.WriteLine("sA")
            ElseIf Not AltTest.Checked Then
                spPort.WriteLine("sN")
                ''switch run etc off and turn buttons grey? Disable when not in run mode?
            End If
        End If
    End Sub

    Private Sub DynamicPulse_CheckedChanged(sender As Object, e As EventArgs) Handles DynamicPulse.CheckedChanged
        If SerialConnection Then
            If DynamicPulse.Checked Then
                RunPulse.Checked = False
                AltTest.Checked = False
                spPort.WriteLine("sD")
            ElseIf Not DynamicPulse.Checked Then
                spPort.WriteLine("sS")
                ''switch run etc off and turn buttons grey
            End If
        End If
    End Sub

    Private Sub RunPulseOffset_CheckedChanged(sender As Object, e As EventArgs) Handles RunPulseOffset.CheckedChanged
        If SerialConnection Then
            If RunPulseOffset.Checked Then ''start run pulse with offset
                spPort.WriteLine("sO")
            ElseIf Not RunPulseOffset.Checked Then ''stop run pulse with offset
                spPort.WriteLine("sP")
            End If
        End If
    End Sub
End Class
