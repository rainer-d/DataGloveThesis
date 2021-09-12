<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PWM_Index = New System.Windows.Forms.TrackBar()
        Me.CmbSerialPorts = New System.Windows.Forms.ComboBox()
        Me.CmbBaudRate = New System.Windows.Forms.ComboBox()
        Me.ConnectionPanel = New System.Windows.Forms.Panel()
        Me.ConnectionStatusBox = New System.Windows.Forms.PictureBox()
        Me.ConnectionStatus = New System.Windows.Forms.Label()
        Me.ScanPortsBtn = New System.Windows.Forms.Button()
        Me.SerialConnectBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SerialDisconnectBtn = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.RunButton = New System.Windows.Forms.Button()
        Me.ThumbVibe_Active = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SqnOpenBtn = New System.Windows.Forms.Button()
        Me.SqnSaveBtn = New System.Windows.Forms.Button()
        Me.SqnStoreBtn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Seq10 = New System.Windows.Forms.CheckBox()
        Me.Seq9 = New System.Windows.Forms.CheckBox()
        Me.Seq8 = New System.Windows.Forms.CheckBox()
        Me.Seq7 = New System.Windows.Forms.CheckBox()
        Me.Seq6 = New System.Windows.Forms.CheckBox()
        Me.Seq5 = New System.Windows.Forms.CheckBox()
        Me.Seq4 = New System.Windows.Forms.CheckBox()
        Me.Seq3 = New System.Windows.Forms.CheckBox()
        Me.Seq2 = New System.Windows.Forms.CheckBox()
        Me.Seq1 = New System.Windows.Forms.CheckBox()
        Me.RunSeqButton = New System.Windows.Forms.Button()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SerialSend = New System.Windows.Forms.Button()
        Me.SerialInput = New System.Windows.Forms.TextBox()
        Me.SerialComsBox = New System.Windows.Forms.ListBox()
        Me.ClearAll = New System.Windows.Forms.Button()
        Me.SelectAll = New System.Windows.Forms.Button()
        Me.PalmVibe_Active = New System.Windows.Forms.CheckBox()
        Me.IndexVibe_Active = New System.Windows.Forms.CheckBox()
        Me.MiddleVibe_Active = New System.Windows.Forms.CheckBox()
        Me.LittleVibe_Active = New System.Windows.Forms.CheckBox()
        Me.RingVibe_Active = New System.Windows.Forms.CheckBox()
        Me.ConStatus = New System.Windows.Forms.Label()
        Me.OnLabel = New System.Windows.Forms.Label()
        Me.OFFms = New System.Windows.Forms.Label()
        Me.OffLabel = New System.Windows.Forms.Label()
        Me.PulseDurationPanel = New System.Windows.Forms.Panel()
        Me.OnTime = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OffTime = New System.Windows.Forms.ComboBox()
        Me.PulsePanelLable = New System.Windows.Forms.Label()
        Me.PWM_Thumb = New System.Windows.Forms.TrackBar()
        Me.PWM_Middle = New System.Windows.Forms.TrackBar()
        Me.PWM_Ring = New System.Windows.Forms.TrackBar()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ThumbVibe = New System.Windows.Forms.Label()
        Me.IndexVibe = New System.Windows.Forms.Label()
        Me.MiddleVibe = New System.Windows.Forms.Label()
        Me.RingVibe = New System.Windows.Forms.Label()
        Me.LittleVibe = New System.Windows.Forms.Label()
        Me.PalmVibe = New System.Windows.Forms.Label()
        Me.ThumbPWM = New System.Windows.Forms.ComboBox()
        Me.IndexPWM = New System.Windows.Forms.ComboBox()
        Me.MiddlePWM = New System.Windows.Forms.ComboBox()
        Me.RingPWM = New System.Windows.Forms.ComboBox()
        Me.PulseButton = New System.Windows.Forms.Button()
        Me.PWMthumbBtn = New System.Windows.Forms.Button()
        Me.PWMindexBtn = New System.Windows.Forms.Button()
        Me.PWMmiddleBtn = New System.Windows.Forms.Button()
        Me.PWMringBtn = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.RandomSelect = New System.Windows.Forms.Button()
        Me.RandomSelectNum = New System.Windows.Forms.ComboBox()
        Me.RunPulse = New System.Windows.Forms.CheckBox()
        Me.PWM_info = New System.Windows.Forms.TableLayoutPanel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.AltTest = New System.Windows.Forms.CheckBox()
        Me.DynamicPulse = New System.Windows.Forms.CheckBox()
        Me.RunPulseOffset = New System.Windows.Forms.CheckBox()
        CType(Me.PWM_Index, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConnectionPanel.SuspendLayout()
        CType(Me.ConnectionStatusBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PulseDurationPanel.SuspendLayout()
        CType(Me.PWM_Thumb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PWM_Middle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PWM_Ring, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PWM_info.SuspendLayout()
        Me.SuspendLayout()
        '
        'PWM_Index
        '
        Me.PWM_Index.AllowDrop = True
        Me.PWM_Index.LargeChange = 51
        Me.PWM_Index.Location = New System.Drawing.Point(244, 195)
        Me.PWM_Index.Maximum = 255
        Me.PWM_Index.Name = "PWM_Index"
        Me.PWM_Index.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.PWM_Index.Size = New System.Drawing.Size(69, 123)
        Me.PWM_Index.SmallChange = 5
        Me.PWM_Index.TabIndex = 1
        Me.PWM_Index.TickFrequency = 60
        Me.PWM_Index.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.PWM_Index.Value = 255
        '
        'CmbSerialPorts
        '
        Me.CmbSerialPorts.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.CmbSerialPorts.FormattingEnabled = True
        Me.CmbSerialPorts.Location = New System.Drawing.Point(137, 35)
        Me.CmbSerialPorts.Name = "CmbSerialPorts"
        Me.CmbSerialPorts.Size = New System.Drawing.Size(137, 33)
        Me.CmbSerialPorts.TabIndex = 2
        '
        'CmbBaudRate
        '
        Me.CmbBaudRate.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.CmbBaudRate.FormattingEnabled = True
        Me.CmbBaudRate.Location = New System.Drawing.Point(137, 74)
        Me.CmbBaudRate.Name = "CmbBaudRate"
        Me.CmbBaudRate.Size = New System.Drawing.Size(137, 33)
        Me.CmbBaudRate.TabIndex = 3
        '
        'ConnectionPanel
        '
        Me.ConnectionPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ConnectionPanel.Controls.Add(Me.ConnectionStatusBox)
        Me.ConnectionPanel.Controls.Add(Me.ConnectionStatus)
        Me.ConnectionPanel.Controls.Add(Me.ScanPortsBtn)
        Me.ConnectionPanel.Controls.Add(Me.SerialConnectBtn)
        Me.ConnectionPanel.Controls.Add(Me.Label3)
        Me.ConnectionPanel.Controls.Add(Me.Label1)
        Me.ConnectionPanel.Controls.Add(Me.CmbBaudRate)
        Me.ConnectionPanel.Controls.Add(Me.CmbSerialPorts)
        Me.ConnectionPanel.Controls.Add(Me.SerialDisconnectBtn)
        Me.ConnectionPanel.Location = New System.Drawing.Point(645, 29)
        Me.ConnectionPanel.Name = "ConnectionPanel"
        Me.ConnectionPanel.Size = New System.Drawing.Size(459, 118)
        Me.ConnectionPanel.TabIndex = 4
        '
        'ConnectionStatusBox
        '
        Me.ConnectionStatusBox.BackColor = System.Drawing.Color.Red
        Me.ConnectionStatusBox.Location = New System.Drawing.Point(370, 35)
        Me.ConnectionStatusBox.Name = "ConnectionStatusBox"
        Me.ConnectionStatusBox.Size = New System.Drawing.Size(33, 33)
        Me.ConnectionStatusBox.TabIndex = 13
        Me.ConnectionStatusBox.TabStop = False
        '
        'ConnectionStatus
        '
        Me.ConnectionStatus.AutoSize = True
        Me.ConnectionStatus.Location = New System.Drawing.Point(296, 39)
        Me.ConnectionStatus.Name = "ConnectionStatus"
        Me.ConnectionStatus.Size = New System.Drawing.Size(64, 25)
        Me.ConnectionStatus.TabIndex = 12
        Me.ConnectionStatus.Text = "Status:"
        '
        'ScanPortsBtn
        '
        Me.ScanPortsBtn.BackColor = System.Drawing.Color.Gainsboro
        Me.ScanPortsBtn.Location = New System.Drawing.Point(29, 33)
        Me.ScanPortsBtn.Name = "ScanPortsBtn"
        Me.ScanPortsBtn.Size = New System.Drawing.Size(96, 38)
        Me.ScanPortsBtn.TabIndex = 11
        Me.ScanPortsBtn.Text = "Scan Port"
        Me.ScanPortsBtn.UseVisualStyleBackColor = False
        '
        'SerialConnectBtn
        '
        Me.SerialConnectBtn.Location = New System.Drawing.Point(290, 75)
        Me.SerialConnectBtn.Name = "SerialConnectBtn"
        Me.SerialConnectBtn.Size = New System.Drawing.Size(134, 32)
        Me.SerialConnectBtn.TabIndex = 9
        Me.SerialConnectBtn.Text = "CONNECT"
        Me.SerialConnectBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Baud Rate:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CONNECTION:"
        '
        'SerialDisconnectBtn
        '
        Me.SerialDisconnectBtn.Location = New System.Drawing.Point(290, 75)
        Me.SerialDisconnectBtn.Name = "SerialDisconnectBtn"
        Me.SerialDisconnectBtn.Size = New System.Drawing.Size(134, 32)
        Me.SerialDisconnectBtn.TabIndex = 10
        Me.SerialDisconnectBtn.Text = "DISCONNECT"
        Me.SerialDisconnectBtn.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.StopButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StopButton.Location = New System.Drawing.Point(97, 746)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(91, 34)
        Me.StopButton.TabIndex = 8
        Me.StopButton.Text = "STOP"
        Me.StopButton.UseVisualStyleBackColor = False
        '
        'RunButton
        '
        Me.RunButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RunButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RunButton.Location = New System.Drawing.Point(97, 666)
        Me.RunButton.Name = "RunButton"
        Me.RunButton.Size = New System.Drawing.Size(91, 34)
        Me.RunButton.TabIndex = 5
        Me.RunButton.Text = "RUN"
        Me.RunButton.UseVisualStyleBackColor = False
        '
        'ThumbVibe_Active
        '
        Me.ThumbVibe_Active.AutoSize = True
        Me.ThumbVibe_Active.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ThumbVibe_Active.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ThumbVibe_Active.Location = New System.Drawing.Point(10, 401)
        Me.ThumbVibe_Active.Name = "ThumbVibe_Active"
        Me.ThumbVibe_Active.Size = New System.Drawing.Size(96, 25)
        Me.ThumbVibe_Active.TabIndex = 16
        Me.ThumbVibe_Active.Text = "Activate"
        Me.ThumbVibe_Active.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "SEQUENCE BUILDER:"
        '
        'SqnOpenBtn
        '
        Me.SqnOpenBtn.Location = New System.Drawing.Point(1, 309)
        Me.SqnOpenBtn.Name = "SqnOpenBtn"
        Me.SqnOpenBtn.Size = New System.Drawing.Size(69, 34)
        Me.SqnOpenBtn.TabIndex = 11
        Me.SqnOpenBtn.Text = "OPEN"
        Me.SqnOpenBtn.UseVisualStyleBackColor = True
        '
        'SqnSaveBtn
        '
        Me.SqnSaveBtn.Location = New System.Drawing.Point(71, 309)
        Me.SqnSaveBtn.Name = "SqnSaveBtn"
        Me.SqnSaveBtn.Size = New System.Drawing.Size(63, 34)
        Me.SqnSaveBtn.TabIndex = 12
        Me.SqnSaveBtn.Text = "SAVE"
        Me.SqnSaveBtn.UseVisualStyleBackColor = True
        '
        'SqnStoreBtn
        '
        Me.SqnStoreBtn.Location = New System.Drawing.Point(135, 309)
        Me.SqnStoreBtn.Name = "SqnStoreBtn"
        Me.SqnStoreBtn.Size = New System.Drawing.Size(131, 34)
        Me.SqnStoreBtn.TabIndex = 13
        Me.SqnStoreBtn.Text = "STORE STEP"
        Me.SqnStoreBtn.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel3.Controls.Add(Me.Seq10)
        Me.Panel3.Controls.Add(Me.Seq9)
        Me.Panel3.Controls.Add(Me.Seq8)
        Me.Panel3.Controls.Add(Me.Seq7)
        Me.Panel3.Controls.Add(Me.Seq6)
        Me.Panel3.Controls.Add(Me.Seq5)
        Me.Panel3.Controls.Add(Me.Seq4)
        Me.Panel3.Controls.Add(Me.Seq3)
        Me.Panel3.Controls.Add(Me.Seq2)
        Me.Panel3.Controls.Add(Me.Seq1)
        Me.Panel3.Controls.Add(Me.RunSeqButton)
        Me.Panel3.Controls.Add(Me.TextBox9)
        Me.Panel3.Controls.Add(Me.TextBox8)
        Me.Panel3.Controls.Add(Me.TextBox7)
        Me.Panel3.Controls.Add(Me.TextBox6)
        Me.Panel3.Controls.Add(Me.TextBox5)
        Me.Panel3.Controls.Add(Me.TextBox4)
        Me.Panel3.Controls.Add(Me.TextBox3)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.SqnStoreBtn)
        Me.Panel3.Controls.Add(Me.SqnSaveBtn)
        Me.Panel3.Controls.Add(Me.SqnOpenBtn)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(645, 414)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(459, 355)
        Me.Panel3.TabIndex = 10
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AllowDrop = True
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 9
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(51, 32)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(405, 214)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'Seq10
        '
        Me.Seq10.AutoSize = True
        Me.Seq10.BackColor = System.Drawing.Color.Transparent
        Me.Seq10.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Seq10.Location = New System.Drawing.Point(5, 222)
        Me.Seq10.Name = "Seq10"
        Me.Seq10.Size = New System.Drawing.Size(51, 25)
        Me.Seq10.TabIndex = 55
        Me.Seq10.Text = "10"
        Me.Seq10.UseVisualStyleBackColor = False
        '
        'Seq9
        '
        Me.Seq9.AutoSize = True
        Me.Seq9.BackColor = System.Drawing.Color.Transparent
        Me.Seq9.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Seq9.Location = New System.Drawing.Point(5, 201)
        Me.Seq9.Name = "Seq9"
        Me.Seq9.Size = New System.Drawing.Size(45, 25)
        Me.Seq9.TabIndex = 54
        Me.Seq9.Text = "9"
        Me.Seq9.UseVisualStyleBackColor = False
        '
        'Seq8
        '
        Me.Seq8.AutoSize = True
        Me.Seq8.BackColor = System.Drawing.Color.Transparent
        Me.Seq8.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Seq8.Location = New System.Drawing.Point(5, 180)
        Me.Seq8.Name = "Seq8"
        Me.Seq8.Size = New System.Drawing.Size(45, 25)
        Me.Seq8.TabIndex = 53
        Me.Seq8.Text = "8"
        Me.Seq8.UseVisualStyleBackColor = False
        '
        'Seq7
        '
        Me.Seq7.AutoSize = True
        Me.Seq7.BackColor = System.Drawing.Color.Transparent
        Me.Seq7.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Seq7.Location = New System.Drawing.Point(5, 159)
        Me.Seq7.Name = "Seq7"
        Me.Seq7.Size = New System.Drawing.Size(45, 25)
        Me.Seq7.TabIndex = 52
        Me.Seq7.Text = "7"
        Me.Seq7.UseVisualStyleBackColor = False
        '
        'Seq6
        '
        Me.Seq6.AutoSize = True
        Me.Seq6.BackColor = System.Drawing.Color.Transparent
        Me.Seq6.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Seq6.Location = New System.Drawing.Point(5, 138)
        Me.Seq6.Name = "Seq6"
        Me.Seq6.Size = New System.Drawing.Size(45, 25)
        Me.Seq6.TabIndex = 51
        Me.Seq6.Text = "6"
        Me.Seq6.UseVisualStyleBackColor = False
        '
        'Seq5
        '
        Me.Seq5.AutoSize = True
        Me.Seq5.BackColor = System.Drawing.Color.Transparent
        Me.Seq5.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Seq5.Location = New System.Drawing.Point(5, 117)
        Me.Seq5.Name = "Seq5"
        Me.Seq5.Size = New System.Drawing.Size(45, 25)
        Me.Seq5.TabIndex = 50
        Me.Seq5.Text = "5"
        Me.Seq5.UseVisualStyleBackColor = False
        '
        'Seq4
        '
        Me.Seq4.AutoSize = True
        Me.Seq4.BackColor = System.Drawing.Color.Transparent
        Me.Seq4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Seq4.Location = New System.Drawing.Point(5, 96)
        Me.Seq4.Name = "Seq4"
        Me.Seq4.Size = New System.Drawing.Size(45, 25)
        Me.Seq4.TabIndex = 49
        Me.Seq4.Text = "4"
        Me.Seq4.UseVisualStyleBackColor = False
        '
        'Seq3
        '
        Me.Seq3.AutoSize = True
        Me.Seq3.BackColor = System.Drawing.Color.Transparent
        Me.Seq3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Seq3.Location = New System.Drawing.Point(5, 75)
        Me.Seq3.Name = "Seq3"
        Me.Seq3.Size = New System.Drawing.Size(45, 25)
        Me.Seq3.TabIndex = 48
        Me.Seq3.Text = "3"
        Me.Seq3.UseVisualStyleBackColor = False
        '
        'Seq2
        '
        Me.Seq2.AutoSize = True
        Me.Seq2.BackColor = System.Drawing.Color.Transparent
        Me.Seq2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Seq2.Location = New System.Drawing.Point(5, 54)
        Me.Seq2.Name = "Seq2"
        Me.Seq2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Seq2.Size = New System.Drawing.Size(45, 25)
        Me.Seq2.TabIndex = 47
        Me.Seq2.Text = "2"
        Me.Seq2.UseVisualStyleBackColor = False
        '
        'Seq1
        '
        Me.Seq1.AutoSize = True
        Me.Seq1.BackColor = System.Drawing.Color.Transparent
        Me.Seq1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Seq1.Location = New System.Drawing.Point(5, 33)
        Me.Seq1.Name = "Seq1"
        Me.Seq1.Size = New System.Drawing.Size(42, 25)
        Me.Seq1.TabIndex = 46
        Me.Seq1.Text = "1"
        Me.Seq1.UseVisualStyleBackColor = False
        '
        'RunSeqButton
        '
        Me.RunSeqButton.Location = New System.Drawing.Point(270, 309)
        Me.RunSeqButton.Name = "RunSeqButton"
        Me.RunSeqButton.Size = New System.Drawing.Size(107, 34)
        Me.RunSeqButton.TabIndex = 24
        Me.RunSeqButton.Text = "RUN SEQ."
        Me.RunSeqButton.UseVisualStyleBackColor = True
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(308, 272)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(36, 31)
        Me.TextBox9.TabIndex = 23
        Me.TextBox9.Text = "*"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(266, 272)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(36, 31)
        Me.TextBox8.TabIndex = 22
        Me.TextBox8.Text = "*"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(224, 272)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(36, 31)
        Me.TextBox7.TabIndex = 21
        Me.TextBox7.Text = "*"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(191, 272)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(36, 31)
        Me.TextBox6.TabIndex = 20
        Me.TextBox6.Text = "*"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(154, 272)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(36, 31)
        Me.TextBox5.TabIndex = 19
        Me.TextBox5.Text = "*"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(116, 272)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(36, 31)
        Me.TextBox4.TabIndex = 18
        Me.TextBox4.Text = "*"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(78, 272)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(36, 31)
        Me.TextBox3.TabIndex = 17
        Me.TextBox3.Text = "*"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(36, 272)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(36, 31)
        Me.TextBox2.TabIndex = 16
        Me.TextBox2.Text = "*"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(0, 272)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(36, 31)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "SERIAL COMs:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.SerialSend)
        Me.Panel2.Controls.Add(Me.SerialInput)
        Me.Panel2.Controls.Add(Me.SerialComsBox)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(645, 146)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(459, 269)
        Me.Panel2.TabIndex = 9
        '
        'SerialSend
        '
        Me.SerialSend.Location = New System.Drawing.Point(387, 232)
        Me.SerialSend.Name = "SerialSend"
        Me.SerialSend.Size = New System.Drawing.Size(68, 32)
        Me.SerialSend.TabIndex = 14
        Me.SerialSend.Text = "SEND"
        Me.SerialSend.UseVisualStyleBackColor = True
        '
        'SerialInput
        '
        Me.SerialInput.AllowDrop = True
        Me.SerialInput.Location = New System.Drawing.Point(8, 233)
        Me.SerialInput.Name = "SerialInput"
        Me.SerialInput.PlaceholderText = "Typed Input..."
        Me.SerialInput.Size = New System.Drawing.Size(380, 31)
        Me.SerialInput.TabIndex = 2
        '
        'SerialComsBox
        '
        Me.SerialComsBox.FormattingEnabled = True
        Me.SerialComsBox.ItemHeight = 25
        Me.SerialComsBox.Location = New System.Drawing.Point(8, 28)
        Me.SerialComsBox.Name = "SerialComsBox"
        Me.SerialComsBox.Size = New System.Drawing.Size(446, 204)
        Me.SerialComsBox.TabIndex = 1
        '
        'ClearAll
        '
        Me.ClearAll.Location = New System.Drawing.Point(4, 706)
        Me.ClearAll.Name = "ClearAll"
        Me.ClearAll.Size = New System.Drawing.Size(91, 34)
        Me.ClearAll.TabIndex = 18
        Me.ClearAll.Text = "Clear All"
        Me.ClearAll.UseVisualStyleBackColor = True
        '
        'SelectAll
        '
        Me.SelectAll.Location = New System.Drawing.Point(4, 666)
        Me.SelectAll.Name = "SelectAll"
        Me.SelectAll.Size = New System.Drawing.Size(91, 34)
        Me.SelectAll.TabIndex = 17
        Me.SelectAll.Text = "Select All"
        Me.SelectAll.UseVisualStyleBackColor = True
        '
        'PalmVibe_Active
        '
        Me.PalmVibe_Active.AutoSize = True
        Me.PalmVibe_Active.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PalmVibe_Active.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PalmVibe_Active.Location = New System.Drawing.Point(388, 632)
        Me.PalmVibe_Active.Name = "PalmVibe_Active"
        Me.PalmVibe_Active.Size = New System.Drawing.Size(96, 25)
        Me.PalmVibe_Active.TabIndex = 19
        Me.PalmVibe_Active.Text = "Activate"
        Me.PalmVibe_Active.UseVisualStyleBackColor = False
        '
        'IndexVibe_Active
        '
        Me.IndexVibe_Active.AutoSize = True
        Me.IndexVibe_Active.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.IndexVibe_Active.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IndexVibe_Active.Location = New System.Drawing.Point(221, 46)
        Me.IndexVibe_Active.Name = "IndexVibe_Active"
        Me.IndexVibe_Active.Size = New System.Drawing.Size(96, 25)
        Me.IndexVibe_Active.TabIndex = 20
        Me.IndexVibe_Active.Text = "Activate"
        Me.IndexVibe_Active.UseVisualStyleBackColor = False
        '
        'MiddleVibe_Active
        '
        Me.MiddleVibe_Active.AutoSize = True
        Me.MiddleVibe_Active.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MiddleVibe_Active.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MiddleVibe_Active.Location = New System.Drawing.Point(341, 12)
        Me.MiddleVibe_Active.Name = "MiddleVibe_Active"
        Me.MiddleVibe_Active.Size = New System.Drawing.Size(96, 25)
        Me.MiddleVibe_Active.TabIndex = 21
        Me.MiddleVibe_Active.Text = "Activate"
        Me.MiddleVibe_Active.UseVisualStyleBackColor = False
        '
        'LittleVibe_Active
        '
        Me.LittleVibe_Active.AutoSize = True
        Me.LittleVibe_Active.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LittleVibe_Active.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LittleVibe_Active.Location = New System.Drawing.Point(544, 154)
        Me.LittleVibe_Active.Name = "LittleVibe_Active"
        Me.LittleVibe_Active.Size = New System.Drawing.Size(96, 25)
        Me.LittleVibe_Active.TabIndex = 22
        Me.LittleVibe_Active.Text = "Activate"
        Me.LittleVibe_Active.UseVisualStyleBackColor = False
        '
        'RingVibe_Active
        '
        Me.RingVibe_Active.AutoSize = True
        Me.RingVibe_Active.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RingVibe_Active.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RingVibe_Active.Location = New System.Drawing.Point(456, 49)
        Me.RingVibe_Active.Name = "RingVibe_Active"
        Me.RingVibe_Active.Size = New System.Drawing.Size(96, 25)
        Me.RingVibe_Active.TabIndex = 23
        Me.RingVibe_Active.Text = "Activate"
        Me.RingVibe_Active.UseVisualStyleBackColor = False
        '
        'ConStatus
        '
        Me.ConStatus.AutoSize = True
        Me.ConStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ConStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ConStatus.ForeColor = System.Drawing.Color.Red
        Me.ConStatus.Location = New System.Drawing.Point(271, 466)
        Me.ConStatus.Name = "ConStatus"
        Me.ConStatus.Size = New System.Drawing.Size(333, 34)
        Me.ConStatus.TabIndex = 14
        Me.ConStatus.Text = "~GLOVE NOT CONNECTED~"
        '
        'OnLabel
        '
        Me.OnLabel.AutoSize = True
        Me.OnLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.OnLabel.Location = New System.Drawing.Point(3, 34)
        Me.OnLabel.Name = "OnLabel"
        Me.OnLabel.Size = New System.Drawing.Size(83, 25)
        Me.OnLabel.TabIndex = 14
        Me.OnLabel.Text = "ON time:"
        '
        'OFFms
        '
        Me.OFFms.AutoSize = True
        Me.OFFms.BackColor = System.Drawing.Color.Transparent
        Me.OFFms.Location = New System.Drawing.Point(167, 69)
        Me.OFFms.Name = "OFFms"
        Me.OFFms.Size = New System.Drawing.Size(36, 25)
        Me.OFFms.TabIndex = 27
        Me.OFFms.Text = "ms"
        '
        'OffLabel
        '
        Me.OffLabel.AutoSize = True
        Me.OffLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.OffLabel.Location = New System.Drawing.Point(2, 69)
        Me.OffLabel.Name = "OffLabel"
        Me.OffLabel.Size = New System.Drawing.Size(88, 25)
        Me.OffLabel.TabIndex = 25
        Me.OffLabel.Text = "OFF time:"
        '
        'PulseDurationPanel
        '
        Me.PulseDurationPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PulseDurationPanel.Controls.Add(Me.OnTime)
        Me.PulseDurationPanel.Controls.Add(Me.Label2)
        Me.PulseDurationPanel.Controls.Add(Me.OffTime)
        Me.PulseDurationPanel.Controls.Add(Me.PulsePanelLable)
        Me.PulseDurationPanel.Controls.Add(Me.OnLabel)
        Me.PulseDurationPanel.Controls.Add(Me.OffLabel)
        Me.PulseDurationPanel.Controls.Add(Me.OFFms)
        Me.PulseDurationPanel.Location = New System.Drawing.Point(2, 3)
        Me.PulseDurationPanel.Name = "PulseDurationPanel"
        Me.PulseDurationPanel.Size = New System.Drawing.Size(200, 104)
        Me.PulseDurationPanel.TabIndex = 28
        '
        'OnTime
        '
        Me.OnTime.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.OnTime.FormattingEnabled = True
        Me.OnTime.Location = New System.Drawing.Point(88, 31)
        Me.OnTime.Name = "OnTime"
        Me.OnTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OnTime.Size = New System.Drawing.Size(83, 33)
        Me.OnTime.TabIndex = 42
        Me.OnTime.Text = "100"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(167, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 25)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "ms"
        '
        'OffTime
        '
        Me.OffTime.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.OffTime.FormattingEnabled = True
        Me.OffTime.Location = New System.Drawing.Point(88, 67)
        Me.OffTime.Name = "OffTime"
        Me.OffTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.OffTime.Size = New System.Drawing.Size(83, 33)
        Me.OffTime.TabIndex = 43
        Me.OffTime.Text = "30"
        '
        'PulsePanelLable
        '
        Me.PulsePanelLable.AutoSize = True
        Me.PulsePanelLable.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PulsePanelLable.Location = New System.Drawing.Point(3, 6)
        Me.PulsePanelLable.Name = "PulsePanelLable"
        Me.PulsePanelLable.Size = New System.Drawing.Size(131, 25)
        Me.PulsePanelLable.TabIndex = 32
        Me.PulsePanelLable.Text = "Pulse Duration:"
        '
        'PWM_Thumb
        '
        Me.PWM_Thumb.AllowDrop = True
        Me.PWM_Thumb.LargeChange = 51
        Me.PWM_Thumb.Location = New System.Drawing.Point(117, 494)
        Me.PWM_Thumb.Maximum = 255
        Me.PWM_Thumb.Name = "PWM_Thumb"
        Me.PWM_Thumb.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.PWM_Thumb.Size = New System.Drawing.Size(69, 123)
        Me.PWM_Thumb.SmallChange = 5
        Me.PWM_Thumb.TabIndex = 1
        Me.PWM_Thumb.TickFrequency = 60
        Me.PWM_Thumb.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.PWM_Thumb.Value = 255
        '
        'PWM_Middle
        '
        Me.PWM_Middle.AllowDrop = True
        Me.PWM_Middle.LargeChange = 51
        Me.PWM_Middle.Location = New System.Drawing.Point(355, 160)
        Me.PWM_Middle.Maximum = 255
        Me.PWM_Middle.Name = "PWM_Middle"
        Me.PWM_Middle.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.PWM_Middle.Size = New System.Drawing.Size(69, 123)
        Me.PWM_Middle.SmallChange = 5
        Me.PWM_Middle.TabIndex = 30
        Me.PWM_Middle.TickFrequency = 60
        Me.PWM_Middle.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.PWM_Middle.Value = 255
        '
        'PWM_Ring
        '
        Me.PWM_Ring.AllowDrop = True
        Me.PWM_Ring.LargeChange = 51
        Me.PWM_Ring.Location = New System.Drawing.Point(462, 196)
        Me.PWM_Ring.Maximum = 255
        Me.PWM_Ring.Name = "PWM_Ring"
        Me.PWM_Ring.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.PWM_Ring.Size = New System.Drawing.Size(69, 123)
        Me.PWM_Ring.SmallChange = 5
        Me.PWM_Ring.TabIndex = 31
        Me.PWM_Ring.TickFrequency = 60
        Me.PWM_Ring.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.PWM_Ring.Value = 255
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ThumbVibe
        '
        Me.ThumbVibe.AutoSize = True
        Me.ThumbVibe.BackColor = System.Drawing.Color.Transparent
        Me.ThumbVibe.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ThumbVibe.Location = New System.Drawing.Point(-10, 388)
        Me.ThumbVibe.Name = "ThumbVibe"
        Me.ThumbVibe.Size = New System.Drawing.Size(146, 191)
        Me.ThumbVibe.TabIndex = 32
        Me.ThumbVibe.Text = "*"
        '
        'IndexVibe
        '
        Me.IndexVibe.AutoSize = True
        Me.IndexVibe.BackColor = System.Drawing.Color.Transparent
        Me.IndexVibe.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IndexVibe.Location = New System.Drawing.Point(205, 30)
        Me.IndexVibe.Name = "IndexVibe"
        Me.IndexVibe.Size = New System.Drawing.Size(146, 191)
        Me.IndexVibe.TabIndex = 33
        Me.IndexVibe.Text = "*"
        '
        'MiddleVibe
        '
        Me.MiddleVibe.AutoSize = True
        Me.MiddleVibe.BackColor = System.Drawing.Color.Transparent
        Me.MiddleVibe.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MiddleVibe.Location = New System.Drawing.Point(325, -4)
        Me.MiddleVibe.Name = "MiddleVibe"
        Me.MiddleVibe.Size = New System.Drawing.Size(146, 191)
        Me.MiddleVibe.TabIndex = 34
        Me.MiddleVibe.Text = "*"
        '
        'RingVibe
        '
        Me.RingVibe.AutoSize = True
        Me.RingVibe.BackColor = System.Drawing.Color.Transparent
        Me.RingVibe.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RingVibe.Location = New System.Drawing.Point(437, 33)
        Me.RingVibe.Name = "RingVibe"
        Me.RingVibe.Size = New System.Drawing.Size(146, 191)
        Me.RingVibe.TabIndex = 35
        Me.RingVibe.Text = "*"
        '
        'LittleVibe
        '
        Me.LittleVibe.AutoSize = True
        Me.LittleVibe.BackColor = System.Drawing.Color.Transparent
        Me.LittleVibe.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LittleVibe.Location = New System.Drawing.Point(537, 142)
        Me.LittleVibe.Name = "LittleVibe"
        Me.LittleVibe.Size = New System.Drawing.Size(146, 191)
        Me.LittleVibe.TabIndex = 36
        Me.LittleVibe.Text = "*"
        '
        'PalmVibe
        '
        Me.PalmVibe.AutoSize = True
        Me.PalmVibe.BackColor = System.Drawing.Color.Transparent
        Me.PalmVibe.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PalmVibe.Location = New System.Drawing.Point(370, 615)
        Me.PalmVibe.Name = "PalmVibe"
        Me.PalmVibe.Size = New System.Drawing.Size(146, 191)
        Me.PalmVibe.TabIndex = 37
        Me.PalmVibe.Text = "*"
        '
        'ThumbPWM
        '
        Me.ThumbPWM.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ThumbPWM.DisplayMember = "100"
        Me.ThumbPWM.FormattingEnabled = True
        Me.ThumbPWM.Location = New System.Drawing.Point(25, 497)
        Me.ThumbPWM.Name = "ThumbPWM"
        Me.ThumbPWM.Size = New System.Drawing.Size(67, 33)
        Me.ThumbPWM.TabIndex = 42
        Me.ThumbPWM.Text = "255"
        '
        'IndexPWM
        '
        Me.IndexPWM.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.IndexPWM.FormattingEnabled = True
        Me.IndexPWM.Location = New System.Drawing.Point(238, 142)
        Me.IndexPWM.Name = "IndexPWM"
        Me.IndexPWM.Size = New System.Drawing.Size(67, 33)
        Me.IndexPWM.TabIndex = 43
        Me.IndexPWM.Text = "255"
        '
        'MiddlePWM
        '
        Me.MiddlePWM.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MiddlePWM.FormattingEnabled = True
        Me.MiddlePWM.Location = New System.Drawing.Point(355, 105)
        Me.MiddlePWM.Name = "MiddlePWM"
        Me.MiddlePWM.Size = New System.Drawing.Size(67, 33)
        Me.MiddlePWM.TabIndex = 44
        Me.MiddlePWM.Text = "255"
        '
        'RingPWM
        '
        Me.RingPWM.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RingPWM.FormattingEnabled = True
        Me.RingPWM.Location = New System.Drawing.Point(468, 140)
        Me.RingPWM.Name = "RingPWM"
        Me.RingPWM.Size = New System.Drawing.Size(67, 33)
        Me.RingPWM.TabIndex = 45
        Me.RingPWM.Text = "255"
        '
        'PulseButton
        '
        Me.PulseButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PulseButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PulseButton.Location = New System.Drawing.Point(97, 706)
        Me.PulseButton.Name = "PulseButton"
        Me.PulseButton.Size = New System.Drawing.Size(91, 34)
        Me.PulseButton.TabIndex = 46
        Me.PulseButton.Text = "PULSE"
        Me.PulseButton.UseVisualStyleBackColor = False
        '
        'PWMthumbBtn
        '
        Me.PWMthumbBtn.BackColor = System.Drawing.SystemColors.Info
        Me.PWMthumbBtn.Location = New System.Drawing.Point(193, 579)
        Me.PWMthumbBtn.Name = "PWMthumbBtn"
        Me.PWMthumbBtn.Size = New System.Drawing.Size(63, 58)
        Me.PWMthumbBtn.TabIndex = 47
        Me.PWMthumbBtn.Text = "PWM cycle"
        Me.PWMthumbBtn.UseVisualStyleBackColor = False
        '
        'PWMindexBtn
        '
        Me.PWMindexBtn.BackColor = System.Drawing.SystemColors.Info
        Me.PWMindexBtn.Location = New System.Drawing.Point(269, 324)
        Me.PWMindexBtn.Name = "PWMindexBtn"
        Me.PWMindexBtn.Size = New System.Drawing.Size(63, 58)
        Me.PWMindexBtn.TabIndex = 48
        Me.PWMindexBtn.Text = "PWM cycle"
        Me.PWMindexBtn.UseVisualStyleBackColor = False
        '
        'PWMmiddleBtn
        '
        Me.PWMmiddleBtn.BackColor = System.Drawing.SystemColors.Info
        Me.PWMmiddleBtn.Location = New System.Drawing.Point(366, 289)
        Me.PWMmiddleBtn.Name = "PWMmiddleBtn"
        Me.PWMmiddleBtn.Size = New System.Drawing.Size(63, 58)
        Me.PWMmiddleBtn.TabIndex = 49
        Me.PWMmiddleBtn.Text = "PWM cycle"
        Me.PWMmiddleBtn.UseVisualStyleBackColor = False
        '
        'PWMringBtn
        '
        Me.PWMringBtn.BackColor = System.Drawing.SystemColors.Info
        Me.PWMringBtn.Location = New System.Drawing.Point(456, 325)
        Me.PWMringBtn.Name = "PWMringBtn"
        Me.PWMringBtn.Size = New System.Drawing.Size(63, 58)
        Me.PWMringBtn.TabIndex = 50
        Me.PWMringBtn.Text = "PWM cycle"
        Me.PWMringBtn.UseVisualStyleBackColor = False
        '
        'ResetBtn
        '
        Me.ResetBtn.Location = New System.Drawing.Point(4, 746)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(91, 34)
        Me.ResetBtn.TabIndex = 51
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = True
        '
        'RandomSelect
        '
        Me.RandomSelect.Enabled = False
        Me.RandomSelect.Location = New System.Drawing.Point(4, 626)
        Me.RandomSelect.Name = "RandomSelect"
        Me.RandomSelect.Size = New System.Drawing.Size(91, 34)
        Me.RandomSelect.TabIndex = 52
        Me.RandomSelect.Text = "Random"
        Me.RandomSelect.UseVisualStyleBackColor = True
        '
        'RandomSelectNum
        '
        Me.RandomSelectNum.Enabled = False
        Me.RandomSelectNum.Location = New System.Drawing.Point(97, 627)
        Me.RandomSelectNum.Name = "RandomSelectNum"
        Me.RandomSelectNum.Size = New System.Drawing.Size(45, 33)
        Me.RandomSelectNum.TabIndex = 53
        Me.RandomSelectNum.Text = "1"
        '
        'RunPulse
        '
        Me.RunPulse.AutoSize = True
        Me.RunPulse.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RunPulse.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RunPulse.Location = New System.Drawing.Point(2, 345)
        Me.RunPulse.Name = "RunPulse"
        Me.RunPulse.Size = New System.Drawing.Size(120, 25)
        Me.RunPulse.TabIndex = 54
        Me.RunPulse.Text = "Run Pulsing"
        Me.RunPulse.UseVisualStyleBackColor = False
        '
        'PWM_info
        '
        Me.PWM_info.AllowDrop = True
        Me.PWM_info.BackColor = System.Drawing.Color.White
        Me.PWM_info.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.PWM_info.ColumnCount = 2
        Me.PWM_info.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.PWM_info.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.PWM_info.Controls.Add(Me.Label15, 1, 4)
        Me.PWM_info.Controls.Add(Me.Label14, 0, 4)
        Me.PWM_info.Controls.Add(Me.Label13, 1, 3)
        Me.PWM_info.Controls.Add(Me.Label12, 0, 3)
        Me.PWM_info.Controls.Add(Me.Label11, 1, 2)
        Me.PWM_info.Controls.Add(Me.Label10, 0, 2)
        Me.PWM_info.Controls.Add(Me.Label9, 1, 1)
        Me.PWM_info.Controls.Add(Me.Label8, 0, 1)
        Me.PWM_info.Controls.Add(Me.Label7, 1, 0)
        Me.PWM_info.Controls.Add(Me.Label5, 0, 0)
        Me.PWM_info.Location = New System.Drawing.Point(2, 138)
        Me.PWM_info.Name = "PWM_info"
        Me.PWM_info.RowCount = 5
        Me.PWM_info.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.PWM_info.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.PWM_info.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.PWM_info.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.PWM_info.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.PWM_info.Size = New System.Drawing.Size(174, 136)
        Me.PWM_info.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(90, 109)
        Me.Label15.Name = "Label15"
        Me.Label15.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Label15.Size = New System.Drawing.Size(62, 25)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = " 140"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 109)
        Me.Label14.Name = "Label14"
        Me.Label14.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Label14.Size = New System.Drawing.Size(57, 25)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "111"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(90, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Label13.Size = New System.Drawing.Size(62, 25)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = " 170"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Label12.Size = New System.Drawing.Size(57, 25)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "143"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(90, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Label11.Size = New System.Drawing.Size(62, 25)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = " 200"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Label10.Size = New System.Drawing.Size(57, 25)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "191"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(90, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Label9.Size = New System.Drawing.Size(62, 25)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = " 230"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Label8.Size = New System.Drawing.Size(57, 25)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "255"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(90, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 25)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "  ~ Hz"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = " Setting"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 114)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(172, 25)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "3.3V PWM mapping"
        '
        'AltTest
        '
        Me.AltTest.AutoSize = True
        Me.AltTest.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.AltTest.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AltTest.Location = New System.Drawing.Point(3, 281)
        Me.AltTest.Name = "AltTest"
        Me.AltTest.Size = New System.Drawing.Size(193, 25)
        Me.AltTest.TabIndex = 56
        Me.AltTest.Text = "Alternating pulse test"
        Me.AltTest.UseVisualStyleBackColor = False
        '
        'DynamicPulse
        '
        Me.DynamicPulse.AutoSize = True
        Me.DynamicPulse.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DynamicPulse.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DynamicPulse.Location = New System.Drawing.Point(2, 313)
        Me.DynamicPulse.Name = "DynamicPulse"
        Me.DynamicPulse.Size = New System.Drawing.Size(154, 25)
        Me.DynamicPulse.TabIndex = 57
        Me.DynamicPulse.Text = "Dynamic Pulsing"
        Me.DynamicPulse.UseVisualStyleBackColor = False
        '
        'RunPulseOffset
        '
        Me.RunPulseOffset.AutoSize = True
        Me.RunPulseOffset.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RunPulseOffset.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RunPulseOffset.Location = New System.Drawing.Point(125, 345)
        Me.RunPulseOffset.Name = "RunPulseOffset"
        Me.RunPulseOffset.Size = New System.Drawing.Size(123, 25)
        Me.RunPulseOffset.TabIndex = 58
        Me.RunPulseOffset.Text = "offset pulse"
        Me.RunPulseOffset.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1104, 798)
        Me.Controls.Add(Me.RunPulseOffset)
        Me.Controls.Add(Me.DynamicPulse)
        Me.Controls.Add(Me.AltTest)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.PWM_info)
        Me.Controls.Add(Me.RunPulse)
        Me.Controls.Add(Me.RandomSelectNum)
        Me.Controls.Add(Me.RandomSelect)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.PWMringBtn)
        Me.Controls.Add(Me.PWMmiddleBtn)
        Me.Controls.Add(Me.PWMindexBtn)
        Me.Controls.Add(Me.PWMthumbBtn)
        Me.Controls.Add(Me.PulseButton)
        Me.Controls.Add(Me.RingPWM)
        Me.Controls.Add(Me.MiddlePWM)
        Me.Controls.Add(Me.IndexPWM)
        Me.Controls.Add(Me.ThumbPWM)
        Me.Controls.Add(Me.ConnectionPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PWM_Middle)
        Me.Controls.Add(Me.PWM_Index)
        Me.Controls.Add(Me.ThumbVibe_Active)
        Me.Controls.Add(Me.PWM_Thumb)
        Me.Controls.Add(Me.PWM_Ring)
        Me.Controls.Add(Me.ConStatus)
        Me.Controls.Add(Me.RingVibe_Active)
        Me.Controls.Add(Me.LittleVibe_Active)
        Me.Controls.Add(Me.PalmVibe_Active)
        Me.Controls.Add(Me.IndexVibe_Active)
        Me.Controls.Add(Me.LittleVibe)
        Me.Controls.Add(Me.MiddleVibe_Active)
        Me.Controls.Add(Me.IndexVibe)
        Me.Controls.Add(Me.ThumbVibe)
        Me.Controls.Add(Me.ClearAll)
        Me.Controls.Add(Me.SelectAll)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.RunButton)
        Me.Controls.Add(Me.PulseDurationPanel)
        Me.Controls.Add(Me.PalmVibe)
        Me.Controls.Add(Me.MiddleVibe)
        Me.Controls.Add(Me.RingVibe)
        Me.Controls.Add(Me.StopButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "DataGloveGUI ~ LilyPad USB by Rainer Doller"
        CType(Me.PWM_Index, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConnectionPanel.ResumeLayout(False)
        Me.ConnectionPanel.PerformLayout()
        CType(Me.ConnectionStatusBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PulseDurationPanel.ResumeLayout(False)
        Me.PulseDurationPanel.PerformLayout()
        CType(Me.PWM_Thumb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PWM_Middle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PWM_Ring, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PWM_info.ResumeLayout(False)
        Me.PWM_info.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PWM_Index As TrackBar
    Friend WithEvents CmbSerialPorts As ComboBox
    Friend WithEvents CmbBaudRate As ComboBox
    Friend WithEvents ConnectionPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents RunButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents StopButton As Button
    Friend WithEvents SerialDisconnectBtn As Button
    Friend WithEvents SerialConnectBtn As Button
    Friend WithEvents ThumbVibe_Active As CheckBox
    Friend WithEvents ScanPortsBtn As Button
    Friend WithEvents ConnectionStatus As Label
    Friend WithEvents ConnectionStatusBox As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SqnOpenBtn As Button
    Friend WithEvents SqnSaveBtn As Button
    Friend WithEvents SqnStoreBtn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SerialComsBox As ListBox
    Friend WithEvents ClearAll As Button
    Friend WithEvents SelectAll As Button
    Friend WithEvents PalmVibe_Active As CheckBox
    Friend WithEvents IndexVibe_Active As CheckBox
    Friend WithEvents MiddleVibe_Active As CheckBox
    Friend WithEvents LittleVibe_Active As CheckBox
    Friend WithEvents RingVibe_Active As CheckBox
    Friend WithEvents ConStatus As Label
    Friend WithEvents SerialSend As Button
    Friend WithEvents SerialInput As TextBox
    Friend WithEvents OnLabel As Label
    Friend WithEvents OFFms As Label
    Friend WithEvents OffLabel As Label
    Friend WithEvents PulseDurationPanel As Panel
    Friend WithEvents PulsePanelLable As Label
    Friend WithEvents PWM_Thumb As TrackBar
    Friend WithEvents PWM_Middle As TrackBar
    Friend WithEvents PWM_Ring As TrackBar
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ThumbVibe As Label
    Friend WithEvents IndexVibe As Label
    Friend WithEvents MiddleVibe As Label
    Friend WithEvents RingVibe As Label
    Friend WithEvents LittleVibe As Label
    Friend WithEvents PalmVibe As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents RunSeqButton As Button
    Friend WithEvents OnTime As ComboBox
    Friend WithEvents OffTime As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ThumbPWM As ComboBox
    Friend WithEvents IndexPWM As ComboBox
    Friend WithEvents MiddlePWM As ComboBox
    Friend WithEvents RingPWM As ComboBox
    Friend WithEvents Seq10 As CheckBox
    Friend WithEvents Seq9 As CheckBox
    Friend WithEvents Seq8 As CheckBox
    Friend WithEvents Seq7 As CheckBox
    Friend WithEvents Seq6 As CheckBox
    Friend WithEvents Seq5 As CheckBox
    Friend WithEvents Seq4 As CheckBox
    Friend WithEvents Seq3 As CheckBox
    Friend WithEvents Seq2 As CheckBox
    Friend WithEvents Seq1 As CheckBox
    Friend WithEvents PulseButton As Button
    Friend WithEvents PWMthumbBtn As Button
    Friend WithEvents PWMindexBtn As Button
    Friend WithEvents PWMmiddleBtn As Button
    Friend WithEvents PWMringBtn As Button
    Friend WithEvents ResetBtn As Button
    Friend WithEvents RandomSelect As Button
    Friend WithEvents RandomSelectNum As ComboBox
    Friend WithEvents RunPulse As CheckBox
    Friend WithEvents PWM_info As TableLayoutPanel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents AltTest As CheckBox
    Friend WithEvents DynamicPulse As CheckBox
    Friend WithEvents RunPulseOffset As CheckBox
End Class
