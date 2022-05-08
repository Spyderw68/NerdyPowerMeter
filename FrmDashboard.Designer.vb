<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea7 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend7 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea8 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend8 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea9 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend9 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea10 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend10 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lblSpeedHeader = New System.Windows.Forms.Label()
        Me.lblSpeedValue = New System.Windows.Forms.Label()
        Me.lblCadenceHeader = New System.Windows.Forms.Label()
        Me.lblCadenceValue = New System.Windows.Forms.Label()
        Me.lblVoltageHeader = New System.Windows.Forms.Label()
        Me.lblVoltageValue = New System.Windows.Forms.Label()
        Me.lblCurrentHeader = New System.Windows.Forms.Label()
        Me.lblCurrentValue = New System.Windows.Forms.Label()
        Me.lblPowerHeader = New System.Windows.Forms.Label()
        Me.lblPowerValue = New System.Windows.Forms.Label()
        Me.lblHRHeading = New System.Windows.Forms.Label()
        Me.lblHRValue = New System.Windows.Forms.Label()
        Me.cbPort = New System.Windows.Forms.ComboBox()
        Me.cbBaudRate = New System.Windows.Forms.ComboBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblBaud = New System.Windows.Forms.Label()
        Me.SerialReadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ArduinoSerial = New System.IO.Ports.SerialPort(Me.components)
        Me.chtPower = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.lblReadBufferHeader = New System.Windows.Forms.Label()
        Me.lblReadBufferValue = New System.Windows.Forms.Label()
        Me.lblLogSizeHeader = New System.Windows.Forms.Label()
        Me.lblLogSizeValue = New System.Windows.Forms.Label()
        Me.chtVoltage = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SerialWriteTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblPWMWriteHeader = New System.Windows.Forms.Label()
        Me.lblPWMWriteValue = New System.Windows.Forms.Label()
        Me.lblWriteBufferHeader = New System.Windows.Forms.Label()
        Me.lblWriteBufferValue = New System.Windows.Forms.Label()
        Me.lblPWMReadHeader = New System.Windows.Forms.Label()
        Me.lblPWMReadValue = New System.Windows.Forms.Label()
        Me.lblWorkoutsHeader = New System.Windows.Forms.Label()
        Me.cbWorkouts = New System.Windows.Forms.ComboBox()
        Me.WorkoutTimer = New System.Windows.Forms.Timer(Me.components)
        Me.chtIntervals = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblDurationHeader = New System.Windows.Forms.Label()
        Me.lblDurationValue = New System.Windows.Forms.Label()
        Me.lblDurationUnitHeader = New System.Windows.Forms.Label()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.lblWOTimeRemaining = New System.Windows.Forms.Label()
        Me.chtCurrent = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblIntTimeRemaining = New System.Windows.Forms.Label()
        Me.btnDurationDec = New System.Windows.Forms.Label()
        Me.btnDurationInc = New System.Windows.Forms.Label()
        Me.cbPWMOverride = New System.Windows.Forms.ComboBox()
        Me.lblCalorieHeader = New System.Windows.Forms.Label()
        Me.lblCalorieValue = New System.Windows.Forms.Label()
        Me.chtEnergy = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TCXTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.chtPower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtVoltage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtIntervals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtEnergy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSpeedHeader
        '
        Me.lblSpeedHeader.AutoSize = True
        Me.lblSpeedHeader.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblSpeedHeader.Font = New System.Drawing.Font("Segoe UI", 32.0!)
        Me.lblSpeedHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSpeedHeader.Location = New System.Drawing.Point(12, 52)
        Me.lblSpeedHeader.Name = "lblSpeedHeader"
        Me.lblSpeedHeader.Size = New System.Drawing.Size(128, 59)
        Me.lblSpeedHeader.TabIndex = 0
        Me.lblSpeedHeader.Text = "MPH:"
        Me.lblSpeedHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSpeedValue
        '
        Me.lblSpeedValue.AutoSize = True
        Me.lblSpeedValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSpeedValue.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.lblSpeedValue.ForeColor = System.Drawing.Color.Red
        Me.lblSpeedValue.Location = New System.Drawing.Point(189, 68)
        Me.lblSpeedValue.Name = "lblSpeedValue"
        Me.lblSpeedValue.Size = New System.Drawing.Size(73, 56)
        Me.lblSpeedValue.TabIndex = 1
        Me.lblSpeedValue.Text = "---"
        Me.lblSpeedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCadenceHeader
        '
        Me.lblCadenceHeader.AutoSize = True
        Me.lblCadenceHeader.Font = New System.Drawing.Font("Segoe UI", 32.0!)
        Me.lblCadenceHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCadenceHeader.Location = New System.Drawing.Point(274, 52)
        Me.lblCadenceHeader.Name = "lblCadenceHeader"
        Me.lblCadenceHeader.Size = New System.Drawing.Size(123, 59)
        Me.lblCadenceHeader.TabIndex = 2
        Me.lblCadenceHeader.Text = "RPM:"
        Me.lblCadenceHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCadenceValue
        '
        Me.lblCadenceValue.AutoSize = True
        Me.lblCadenceValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCadenceValue.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.lblCadenceValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCadenceValue.Location = New System.Drawing.Point(451, 68)
        Me.lblCadenceValue.Name = "lblCadenceValue"
        Me.lblCadenceValue.Size = New System.Drawing.Size(73, 56)
        Me.lblCadenceValue.TabIndex = 3
        Me.lblCadenceValue.Text = "---"
        Me.lblCadenceValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVoltageHeader
        '
        Me.lblVoltageHeader.AutoSize = True
        Me.lblVoltageHeader.Font = New System.Drawing.Font("Segoe UI", 32.0!)
        Me.lblVoltageHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblVoltageHeader.Location = New System.Drawing.Point(12, 269)
        Me.lblVoltageHeader.Name = "lblVoltageHeader"
        Me.lblVoltageHeader.Size = New System.Drawing.Size(126, 59)
        Me.lblVoltageHeader.TabIndex = 4
        Me.lblVoltageHeader.Text = "Volts:"
        Me.lblVoltageHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVoltageValue
        '
        Me.lblVoltageValue.AutoSize = True
        Me.lblVoltageValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVoltageValue.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.lblVoltageValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblVoltageValue.Location = New System.Drawing.Point(162, 272)
        Me.lblVoltageValue.Name = "lblVoltageValue"
        Me.lblVoltageValue.Size = New System.Drawing.Size(100, 56)
        Me.lblVoltageValue.TabIndex = 5
        Me.lblVoltageValue.Text = "00.0"
        Me.lblVoltageValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCurrentHeader
        '
        Me.lblCurrentHeader.AutoSize = True
        Me.lblCurrentHeader.Font = New System.Drawing.Font("Segoe UI", 32.0!)
        Me.lblCurrentHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCurrentHeader.Location = New System.Drawing.Point(274, 269)
        Me.lblCurrentHeader.Name = "lblCurrentHeader"
        Me.lblCurrentHeader.Size = New System.Drawing.Size(142, 59)
        Me.lblCurrentHeader.TabIndex = 6
        Me.lblCurrentHeader.Text = "Amps:"
        Me.lblCurrentHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentValue
        '
        Me.lblCurrentValue.AutoSize = True
        Me.lblCurrentValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurrentValue.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.lblCurrentValue.ForeColor = System.Drawing.Color.Yellow
        Me.lblCurrentValue.Location = New System.Drawing.Point(424, 272)
        Me.lblCurrentValue.Name = "lblCurrentValue"
        Me.lblCurrentValue.Size = New System.Drawing.Size(100, 56)
        Me.lblCurrentValue.TabIndex = 7
        Me.lblCurrentValue.Text = "00.0"
        Me.lblCurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPowerHeader
        '
        Me.lblPowerHeader.AutoSize = True
        Me.lblPowerHeader.Font = New System.Drawing.Font("Segoe UI", 32.0!)
        Me.lblPowerHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblPowerHeader.Location = New System.Drawing.Point(535, 269)
        Me.lblPowerHeader.Name = "lblPowerHeader"
        Me.lblPowerHeader.Size = New System.Drawing.Size(142, 59)
        Me.lblPowerHeader.TabIndex = 8
        Me.lblPowerHeader.Text = "Watts:"
        Me.lblPowerHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPowerValue
        '
        Me.lblPowerValue.AutoSize = True
        Me.lblPowerValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPowerValue.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.lblPowerValue.ForeColor = System.Drawing.Color.Lime
        Me.lblPowerValue.Location = New System.Drawing.Point(694, 272)
        Me.lblPowerValue.Name = "lblPowerValue"
        Me.lblPowerValue.Size = New System.Drawing.Size(91, 56)
        Me.lblPowerValue.TabIndex = 9
        Me.lblPowerValue.Text = "000"
        Me.lblPowerValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHRHeading
        '
        Me.lblHRHeading.AutoSize = True
        Me.lblHRHeading.Font = New System.Drawing.Font("Segoe UI", 32.0!)
        Me.lblHRHeading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblHRHeading.Location = New System.Drawing.Point(535, 52)
        Me.lblHRHeading.Name = "lblHRHeading"
        Me.lblHRHeading.Size = New System.Drawing.Size(91, 59)
        Me.lblHRHeading.TabIndex = 2
        Me.lblHRHeading.Text = "HR:"
        Me.lblHRHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHRValue
        '
        Me.lblHRValue.AutoSize = True
        Me.lblHRValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHRValue.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.lblHRValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblHRValue.Location = New System.Drawing.Point(712, 68)
        Me.lblHRValue.Name = "lblHRValue"
        Me.lblHRValue.Size = New System.Drawing.Size(73, 56)
        Me.lblHRValue.TabIndex = 3
        Me.lblHRValue.Text = "---"
        Me.lblHRValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbPort
        '
        Me.cbPort.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.cbPort.FormattingEnabled = True
        Me.cbPort.Location = New System.Drawing.Point(1026, 800)
        Me.cbPort.Name = "cbPort"
        Me.cbPort.Size = New System.Drawing.Size(103, 33)
        Me.cbPort.TabIndex = 12
        '
        'cbBaudRate
        '
        Me.cbBaudRate.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.cbBaudRate.FormattingEnabled = True
        Me.cbBaudRate.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "19200", "38400", "47600", "115200"})
        Me.cbBaudRate.Location = New System.Drawing.Point(1132, 800)
        Me.cbBaudRate.Name = "cbBaudRate"
        Me.cbBaudRate.Size = New System.Drawing.Size(103, 33)
        Me.cbBaudRate.TabIndex = 13
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.lblPort.Location = New System.Drawing.Point(1054, 772)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(46, 25)
        Me.lblPort.TabIndex = 14
        Me.lblPort.Text = "Port"
        '
        'lblBaud
        '
        Me.lblBaud.AutoSize = True
        Me.lblBaud.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.lblBaud.Location = New System.Drawing.Point(1135, 772)
        Me.lblBaud.Name = "lblBaud"
        Me.lblBaud.Size = New System.Drawing.Size(97, 25)
        Me.lblBaud.TabIndex = 14
        Me.lblBaud.Text = "Baud Rate"
        '
        'SerialReadTimer
        '
        Me.SerialReadTimer.Interval = 50
        '
        'ArduinoSerial
        '
        Me.ArduinoSerial.PortName = "COM4"
        Me.ArduinoSerial.ReadTimeout = 10
        '
        'chtPower
        '
        Me.chtPower.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ChartArea6.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea6.AxisX.MajorGrid.Enabled = False
        ChartArea6.AxisX.Minimum = 0R
        ChartArea6.AxisY.MajorGrid.Enabled = False
        ChartArea6.AxisY.Minimum = 0R
        ChartArea6.AxisY2.Maximum = 15.0R
        ChartArea6.AxisY2.Minimum = 0R
        ChartArea6.AxisY2.Title = "Current (A)"
        ChartArea6.Name = "PChartArea"
        Me.chtPower.ChartAreas.Add(ChartArea6)
        Legend6.Enabled = False
        Legend6.Name = "Legend1"
        Me.chtPower.Legends.Add(Legend6)
        Me.chtPower.Location = New System.Drawing.Point(535, 336)
        Me.chtPower.Name = "chtPower"
        Series6.ChartArea = "PChartArea"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series6.Legend = "Legend1"
        Series6.Name = "Power"
        Me.chtPower.Series.Add(Series6)
        Me.chtPower.Size = New System.Drawing.Size(250, 100)
        Me.chtPower.TabIndex = 15
        Me.chtPower.Text = "Chart1"
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnStart.Location = New System.Drawing.Point(1006, 883)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(120, 50)
        Me.btnStart.TabIndex = 16
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnPause.Location = New System.Drawing.Point(1132, 883)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(120, 50)
        Me.btnPause.TabIndex = 17
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnDone.Location = New System.Drawing.Point(1132, 884)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(120, 50)
        Me.btnDone.TabIndex = 18
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'lblReadBufferHeader
        '
        Me.lblReadBufferHeader.AutoSize = True
        Me.lblReadBufferHeader.Location = New System.Drawing.Point(1003, 561)
        Me.lblReadBufferHeader.Name = "lblReadBufferHeader"
        Me.lblReadBufferHeader.Size = New System.Drawing.Size(64, 13)
        Me.lblReadBufferHeader.TabIndex = 19
        Me.lblReadBufferHeader.Text = "Read Buffer"
        '
        'lblReadBufferValue
        '
        Me.lblReadBufferValue.AutoSize = True
        Me.lblReadBufferValue.Location = New System.Drawing.Point(1003, 583)
        Me.lblReadBufferValue.Name = "lblReadBufferValue"
        Me.lblReadBufferValue.Size = New System.Drawing.Size(60, 13)
        Me.lblReadBufferValue.TabIndex = 20
        Me.lblReadBufferValue.Text = "0000/4096"
        '
        'lblLogSizeHeader
        '
        Me.lblLogSizeHeader.AutoSize = True
        Me.lblLogSizeHeader.Location = New System.Drawing.Point(1003, 693)
        Me.lblLogSizeHeader.Name = "lblLogSizeHeader"
        Me.lblLogSizeHeader.Size = New System.Drawing.Size(48, 13)
        Me.lblLogSizeHeader.TabIndex = 19
        Me.lblLogSizeHeader.Text = "Log Size"
        '
        'lblLogSizeValue
        '
        Me.lblLogSizeValue.AutoSize = True
        Me.lblLogSizeValue.Location = New System.Drawing.Point(1003, 715)
        Me.lblLogSizeValue.Name = "lblLogSizeValue"
        Me.lblLogSizeValue.Size = New System.Drawing.Size(25, 13)
        Me.lblLogSizeValue.TabIndex = 20
        Me.lblLogSizeValue.Text = "000"
        '
        'chtVoltage
        '
        Me.chtVoltage.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ChartArea7.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea7.AxisX.LabelStyle.Enabled = False
        ChartArea7.AxisX.MajorGrid.Enabled = False
        ChartArea7.AxisX.Minimum = 0R
        ChartArea7.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea7.AxisY.MajorGrid.Enabled = False
        ChartArea7.AxisY.Minimum = 0R
        ChartArea7.AxisY2.Maximum = 15.0R
        ChartArea7.AxisY2.Minimum = 0R
        ChartArea7.AxisY2.Title = "Current (A)"
        ChartArea7.Name = "VoltageChartArea"
        Me.chtVoltage.ChartAreas.Add(ChartArea7)
        Legend7.Enabled = False
        Legend7.Name = "Legend1"
        Me.chtVoltage.Legends.Add(Legend7)
        Me.chtVoltage.Location = New System.Drawing.Point(12, 336)
        Me.chtVoltage.Name = "chtVoltage"
        Series7.ChartArea = "VoltageChartArea"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series7.Legend = "Legend1"
        Series7.Name = "Voltage"
        Me.chtVoltage.Series.Add(Series7)
        Me.chtVoltage.Size = New System.Drawing.Size(250, 100)
        Me.chtVoltage.TabIndex = 21
        Me.chtVoltage.Text = "Voltage"
        '
        'SerialWriteTimer
        '
        Me.SerialWriteTimer.Interval = 250
        '
        'lblPWMWriteHeader
        '
        Me.lblPWMWriteHeader.AutoSize = True
        Me.lblPWMWriteHeader.Location = New System.Drawing.Point(1003, 622)
        Me.lblPWMWriteHeader.Name = "lblPWMWriteHeader"
        Me.lblPWMWriteHeader.Size = New System.Drawing.Size(92, 13)
        Me.lblPWMWriteHeader.TabIndex = 19
        Me.lblPWMWriteHeader.Text = "PWM Write Value"
        '
        'lblPWMWriteValue
        '
        Me.lblPWMWriteValue.AutoSize = True
        Me.lblPWMWriteValue.Location = New System.Drawing.Point(1003, 644)
        Me.lblPWMWriteValue.Name = "lblPWMWriteValue"
        Me.lblPWMWriteValue.Size = New System.Drawing.Size(25, 13)
        Me.lblPWMWriteValue.TabIndex = 20
        Me.lblPWMWriteValue.Text = "000"
        '
        'lblWriteBufferHeader
        '
        Me.lblWriteBufferHeader.AutoSize = True
        Me.lblWriteBufferHeader.Location = New System.Drawing.Point(1129, 561)
        Me.lblWriteBufferHeader.Name = "lblWriteBufferHeader"
        Me.lblWriteBufferHeader.Size = New System.Drawing.Size(60, 13)
        Me.lblWriteBufferHeader.TabIndex = 19
        Me.lblWriteBufferHeader.Text = "WriteBuffer"
        '
        'lblWriteBufferValue
        '
        Me.lblWriteBufferValue.AutoSize = True
        Me.lblWriteBufferValue.Location = New System.Drawing.Point(1129, 583)
        Me.lblWriteBufferValue.Name = "lblWriteBufferValue"
        Me.lblWriteBufferValue.Size = New System.Drawing.Size(60, 13)
        Me.lblWriteBufferValue.TabIndex = 20
        Me.lblWriteBufferValue.Text = "0000/2048"
        '
        'lblPWMReadHeader
        '
        Me.lblPWMReadHeader.AutoSize = True
        Me.lblPWMReadHeader.Location = New System.Drawing.Point(1129, 622)
        Me.lblPWMReadHeader.Name = "lblPWMReadHeader"
        Me.lblPWMReadHeader.Size = New System.Drawing.Size(93, 13)
        Me.lblPWMReadHeader.TabIndex = 19
        Me.lblPWMReadHeader.Text = "PWM Read Value"
        '
        'lblPWMReadValue
        '
        Me.lblPWMReadValue.AutoSize = True
        Me.lblPWMReadValue.Location = New System.Drawing.Point(1129, 644)
        Me.lblPWMReadValue.Name = "lblPWMReadValue"
        Me.lblPWMReadValue.Size = New System.Drawing.Size(25, 13)
        Me.lblPWMReadValue.TabIndex = 20
        Me.lblPWMReadValue.Text = "000"
        '
        'lblWorkoutsHeader
        '
        Me.lblWorkoutsHeader.AutoSize = True
        Me.lblWorkoutsHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkoutsHeader.Location = New System.Drawing.Point(886, 72)
        Me.lblWorkoutsHeader.Name = "lblWorkoutsHeader"
        Me.lblWorkoutsHeader.Size = New System.Drawing.Size(128, 24)
        Me.lblWorkoutsHeader.TabIndex = 19
        Me.lblWorkoutsHeader.Text = "Workout Type"
        '
        'cbWorkouts
        '
        Me.cbWorkouts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWorkouts.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbWorkouts.FormattingEnabled = True
        Me.cbWorkouts.Location = New System.Drawing.Point(1059, 68)
        Me.cbWorkouts.Name = "cbWorkouts"
        Me.cbWorkouts.Size = New System.Drawing.Size(176, 32)
        Me.cbWorkouts.TabIndex = 23
        '
        'WorkoutTimer
        '
        '
        'chtIntervals
        '
        Me.chtIntervals.BackColor = System.Drawing.Color.Gray
        ChartArea8.AxisX.IsLabelAutoFit = False
        ChartArea8.AxisX.IsMarginVisible = False
        ChartArea8.AxisX.LabelStyle.Enabled = False
        ChartArea8.AxisX.LineColor = System.Drawing.Color.Transparent
        ChartArea8.AxisX.MajorGrid.Enabled = False
        ChartArea8.AxisX.MajorTickMark.Enabled = False
        ChartArea8.AxisY.IsLabelAutoFit = False
        ChartArea8.AxisY.LabelStyle.Enabled = False
        ChartArea8.AxisY.LineColor = System.Drawing.Color.Transparent
        ChartArea8.AxisY.MajorGrid.Enabled = False
        ChartArea8.AxisY.MajorTickMark.Enabled = False
        ChartArea8.AxisY.Maximum = 10.0R
        ChartArea8.AxisY.Minimum = 0R
        ChartArea8.BackColor = System.Drawing.Color.Gray
        ChartArea8.Name = "ChartArea1"
        Me.chtIntervals.ChartAreas.Add(ChartArea8)
        Legend8.Enabled = False
        Legend8.Name = "Legend1"
        Me.chtIntervals.Legends.Add(Legend8)
        Me.chtIntervals.Location = New System.Drawing.Point(887, 117)
        Me.chtIntervals.Name = "chtIntervals"
        Series8.BorderColor = System.Drawing.Color.Black
        Series8.ChartArea = "ChartArea1"
        Series8.Color = System.Drawing.Color.Red
        Series8.Legend = "Legend1"
        Series8.Name = "Intervals"
        Series8.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Me.chtIntervals.Series.Add(Series8)
        Me.chtIntervals.Size = New System.Drawing.Size(348, 80)
        Me.chtIntervals.TabIndex = 24
        Me.chtIntervals.Text = "Workout Intervals"
        '
        'lblDurationHeader
        '
        Me.lblDurationHeader.AutoSize = True
        Me.lblDurationHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDurationHeader.Location = New System.Drawing.Point(934, 34)
        Me.lblDurationHeader.Name = "lblDurationHeader"
        Me.lblDurationHeader.Size = New System.Drawing.Size(80, 24)
        Me.lblDurationHeader.TabIndex = 19
        Me.lblDurationHeader.Text = "Duration"
        '
        'lblDurationValue
        '
        Me.lblDurationValue.AutoSize = True
        Me.lblDurationValue.BackColor = System.Drawing.Color.White
        Me.lblDurationValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDurationValue.Location = New System.Drawing.Point(1060, 34)
        Me.lblDurationValue.Name = "lblDurationValue"
        Me.lblDurationValue.Size = New System.Drawing.Size(30, 24)
        Me.lblDurationValue.TabIndex = 19
        Me.lblDurationValue.Text = "30"
        '
        'lblDurationUnitHeader
        '
        Me.lblDurationUnitHeader.AutoSize = True
        Me.lblDurationUnitHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDurationUnitHeader.Location = New System.Drawing.Point(1096, 34)
        Me.lblDurationUnitHeader.Name = "lblDurationUnitHeader"
        Me.lblDurationUnitHeader.Size = New System.Drawing.Size(41, 24)
        Me.lblDurationUnitHeader.TabIndex = 19
        Me.lblDurationUnitHeader.Text = "Min"
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarning.ForeColor = System.Drawing.Color.Red
        Me.lblWarning.Location = New System.Drawing.Point(1030, 745)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(205, 24)
        Me.lblWarning.TabIndex = 26
        Me.lblWarning.Text = "COM Port Not Found"
        '
        'lblWOTimeRemaining
        '
        Me.lblWOTimeRemaining.AutoSize = True
        Me.lblWOTimeRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWOTimeRemaining.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblWOTimeRemaining.Location = New System.Drawing.Point(9, 488)
        Me.lblWOTimeRemaining.Name = "lblWOTimeRemaining"
        Me.lblWOTimeRemaining.Size = New System.Drawing.Size(429, 73)
        Me.lblWOTimeRemaining.TabIndex = 27
        Me.lblWOTimeRemaining.Text = "WO: 00:00:00"
        Me.lblWOTimeRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chtCurrent
        '
        Me.chtCurrent.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ChartArea9.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea9.AxisX.MajorGrid.Enabled = False
        ChartArea9.AxisY.MajorGrid.Enabled = False
        ChartArea9.AxisY.Minimum = 0R
        ChartArea9.AxisY2.MajorGrid.Enabled = False
        ChartArea9.AxisY2.Maximum = 15.0R
        ChartArea9.AxisY2.Minimum = 0R
        ChartArea9.AxisY2.Title = "Current (A)"
        ChartArea9.Name = "CurrentChartArea"
        Me.chtCurrent.ChartAreas.Add(ChartArea9)
        Legend9.Enabled = False
        Legend9.Name = "Legend1"
        Me.chtCurrent.Legends.Add(Legend9)
        Me.chtCurrent.Location = New System.Drawing.Point(274, 336)
        Me.chtCurrent.Name = "chtCurrent"
        Series9.ChartArea = "CurrentChartArea"
        Series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series9.Legend = "Legend1"
        Series9.Name = "Current"
        Me.chtCurrent.Series.Add(Series9)
        Me.chtCurrent.Size = New System.Drawing.Size(250, 100)
        Me.chtCurrent.TabIndex = 21
        Me.chtCurrent.Text = "Chart2"
        '
        'lblIntTimeRemaining
        '
        Me.lblIntTimeRemaining.AutoSize = True
        Me.lblIntTimeRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntTimeRemaining.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblIntTimeRemaining.Location = New System.Drawing.Point(9, 561)
        Me.lblIntTimeRemaining.Name = "lblIntTimeRemaining"
        Me.lblIntTimeRemaining.Size = New System.Drawing.Size(385, 73)
        Me.lblIntTimeRemaining.TabIndex = 27
        Me.lblIntTimeRemaining.Text = "INT 0: 00:00"
        Me.lblIntTimeRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDurationDec
        '
        Me.btnDurationDec.AutoSize = True
        Me.btnDurationDec.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDurationDec.Location = New System.Drawing.Point(1166, 24)
        Me.btnDurationDec.Name = "btnDurationDec"
        Me.btnDurationDec.Size = New System.Drawing.Size(27, 37)
        Me.btnDurationDec.TabIndex = 28
        Me.btnDurationDec.Text = "-"
        '
        'btnDurationInc
        '
        Me.btnDurationInc.AutoSize = True
        Me.btnDurationInc.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDurationInc.Location = New System.Drawing.Point(1199, 24)
        Me.btnDurationInc.Name = "btnDurationInc"
        Me.btnDurationInc.Size = New System.Drawing.Size(36, 37)
        Me.btnDurationInc.TabIndex = 28
        Me.btnDurationInc.Text = "+"
        '
        'cbPWMOverride
        '
        Me.cbPWMOverride.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPWMOverride.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPWMOverride.FormattingEnabled = True
        Me.cbPWMOverride.Items.AddRange(New Object() {"", "0", "2", "4", "8", "16", "32", "64", "128", "255"})
        Me.cbPWMOverride.Location = New System.Drawing.Point(1079, 693)
        Me.cbPWMOverride.Name = "cbPWMOverride"
        Me.cbPWMOverride.Size = New System.Drawing.Size(176, 32)
        Me.cbPWMOverride.TabIndex = 23
        '
        'lblCalorieHeader
        '
        Me.lblCalorieHeader.AutoSize = True
        Me.lblCalorieHeader.Font = New System.Drawing.Font("Segoe UI", 32.0!)
        Me.lblCalorieHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCalorieHeader.Location = New System.Drawing.Point(796, 268)
        Me.lblCalorieHeader.Name = "lblCalorieHeader"
        Me.lblCalorieHeader.Size = New System.Drawing.Size(183, 59)
        Me.lblCalorieHeader.TabIndex = 8
        Me.lblCalorieHeader.Text = "Calories:"
        Me.lblCalorieHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCalorieValue
        '
        Me.lblCalorieValue.AutoSize = True
        Me.lblCalorieValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCalorieValue.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.lblCalorieValue.ForeColor = System.Drawing.Color.Lime
        Me.lblCalorieValue.Location = New System.Drawing.Point(977, 273)
        Me.lblCalorieValue.Name = "lblCalorieValue"
        Me.lblCalorieValue.Size = New System.Drawing.Size(113, 56)
        Me.lblCalorieValue.TabIndex = 9
        Me.lblCalorieValue.Text = "0000"
        Me.lblCalorieValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chtEnergy
        '
        Me.chtEnergy.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ChartArea10.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea10.AxisX.MajorGrid.Enabled = False
        ChartArea10.AxisX.Minimum = 0R
        ChartArea10.AxisY.MajorGrid.Enabled = False
        ChartArea10.AxisY.Minimum = 0R
        ChartArea10.AxisY2.Maximum = 15.0R
        ChartArea10.AxisY2.Minimum = 0R
        ChartArea10.AxisY2.Title = "Current (A)"
        ChartArea10.Name = "EChartArea"
        Me.chtEnergy.ChartAreas.Add(ChartArea10)
        Legend10.Enabled = False
        Legend10.Name = "Legend1"
        Me.chtEnergy.Legends.Add(Legend10)
        Me.chtEnergy.Location = New System.Drawing.Point(796, 335)
        Me.chtEnergy.Name = "chtEnergy"
        Series10.ChartArea = "EChartArea"
        Series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series10.Legend = "Legend1"
        Series10.Name = "Energy"
        Me.chtEnergy.Series.Add(Series10)
        Me.chtEnergy.Size = New System.Drawing.Size(294, 100)
        Me.chtEnergy.TabIndex = 15
        Me.chtEnergy.Text = "Chart1"
        '
        'TCXTimer
        '
        Me.TCXTimer.Interval = 5000
        '
        'FrmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1264, 945)
        Me.Controls.Add(Me.btnDurationInc)
        Me.Controls.Add(Me.btnDurationDec)
        Me.Controls.Add(Me.lblIntTimeRemaining)
        Me.Controls.Add(Me.lblWOTimeRemaining)
        Me.Controls.Add(Me.lblWarning)
        Me.Controls.Add(Me.chtIntervals)
        Me.Controls.Add(Me.cbPWMOverride)
        Me.Controls.Add(Me.cbWorkouts)
        Me.Controls.Add(Me.chtCurrent)
        Me.Controls.Add(Me.chtVoltage)
        Me.Controls.Add(Me.lblLogSizeValue)
        Me.Controls.Add(Me.lblLogSizeHeader)
        Me.Controls.Add(Me.lblPWMReadValue)
        Me.Controls.Add(Me.lblPWMWriteValue)
        Me.Controls.Add(Me.lblPWMReadHeader)
        Me.Controls.Add(Me.lblPWMWriteHeader)
        Me.Controls.Add(Me.lblWriteBufferValue)
        Me.Controls.Add(Me.lblReadBufferValue)
        Me.Controls.Add(Me.lblWriteBufferHeader)
        Me.Controls.Add(Me.lblDurationValue)
        Me.Controls.Add(Me.lblDurationUnitHeader)
        Me.Controls.Add(Me.lblDurationHeader)
        Me.Controls.Add(Me.lblWorkoutsHeader)
        Me.Controls.Add(Me.lblReadBufferHeader)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.chtEnergy)
        Me.Controls.Add(Me.chtPower)
        Me.Controls.Add(Me.lblBaud)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.cbBaudRate)
        Me.Controls.Add(Me.cbPort)
        Me.Controls.Add(Me.lblCalorieValue)
        Me.Controls.Add(Me.lblPowerValue)
        Me.Controls.Add(Me.lblCalorieHeader)
        Me.Controls.Add(Me.lblPowerHeader)
        Me.Controls.Add(Me.lblCurrentValue)
        Me.Controls.Add(Me.lblCurrentHeader)
        Me.Controls.Add(Me.lblVoltageValue)
        Me.Controls.Add(Me.lblVoltageHeader)
        Me.Controls.Add(Me.lblHRValue)
        Me.Controls.Add(Me.lblCadenceValue)
        Me.Controls.Add(Me.lblHRHeading)
        Me.Controls.Add(Me.lblCadenceHeader)
        Me.Controls.Add(Me.lblSpeedValue)
        Me.Controls.Add(Me.lblSpeedHeader)
        Me.Controls.Add(Me.btnDone)
        Me.Name = "FrmDashboard"
        Me.Text = "NerdyPowerMeter"
        CType(Me.chtPower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtVoltage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtIntervals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtEnergy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSpeedHeader As Label
    Friend WithEvents lblSpeedValue As Label
    Friend WithEvents lblCadenceHeader As Label
    Friend WithEvents lblCadenceValue As Label
    Friend WithEvents lblVoltageHeader As Label
    Friend WithEvents lblVoltageValue As Label
    Friend WithEvents lblCurrentHeader As Label
    Friend WithEvents lblCurrentValue As Label
    Friend WithEvents lblPowerHeader As Label
    Friend WithEvents lblPowerValue As Label
    Friend WithEvents lblHRHeading As Label
    Friend WithEvents lblHRValue As Label
    Friend WithEvents cbPort As ComboBox
    Friend WithEvents cbBaudRate As ComboBox
    Friend WithEvents lblPort As Label
    Friend WithEvents lblBaud As Label
    Friend WithEvents SerialReadTimer As Timer
    Friend WithEvents ArduinoSerial As IO.Ports.SerialPort
    Friend WithEvents chtPower As DataVisualization.Charting.Chart
    Friend WithEvents btnStart As Button
    Friend WithEvents btnPause As Button
    Friend WithEvents btnDone As Button
    Friend WithEvents lblReadBufferHeader As Label
    Friend WithEvents lblReadBufferValue As Label
    Friend WithEvents lblLogSizeHeader As Label
    Friend WithEvents lblLogSizeValue As Label
    Friend WithEvents chtVoltage As DataVisualization.Charting.Chart
    Friend WithEvents SerialWriteTimer As Timer
    Friend WithEvents lblPWMWriteHeader As Label
    Friend WithEvents lblPWMWriteValue As Label
    Friend WithEvents lblWriteBufferHeader As Label
    Friend WithEvents lblWriteBufferValue As Label
    Friend WithEvents lblPWMReadHeader As Label
    Friend WithEvents lblPWMReadValue As Label
    Friend WithEvents lblWorkoutsHeader As Label
    Friend WithEvents cbWorkouts As ComboBox
    Friend WithEvents WorkoutTimer As Timer
    Friend WithEvents chtIntervals As DataVisualization.Charting.Chart
    Friend WithEvents lblDurationHeader As Label
    Friend WithEvents lblDurationValue As Label
    Friend WithEvents lblDurationUnitHeader As Label
    Friend WithEvents lblWarning As Label
    Friend WithEvents lblWOTimeRemaining As Label
    Friend WithEvents chtCurrent As DataVisualization.Charting.Chart
    Friend WithEvents lblIntTimeRemaining As Label
    Friend WithEvents btnDurationDec As Label
    Friend WithEvents btnDurationInc As Label
    Friend WithEvents cbPWMOverride As ComboBox
    Friend WithEvents lblCalorieHeader As Label
    Friend WithEvents lblCalorieValue As Label
    Friend WithEvents chtEnergy As DataVisualization.Charting.Chart
    Friend WithEvents TCXTimer As Timer
End Class
