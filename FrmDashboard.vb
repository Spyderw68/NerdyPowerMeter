Imports System.Xml

Public Class FrmDashboard

#Region "Global Variables"

    Const strIntTimeRemaining As String = "INT 0: 00:00"
    Const strWOTimeRemaining As String = "WO: 00:00:00"
    Dim lsRideLog As New List(Of PowerMeterData)
    Dim blTracking As Boolean = False
    Dim btPWMWriteValue As Byte = 0
    Dim astWorkoutIntervals(0 To 5, 0 To 40) As String
    Dim dblWorkoutTime As Double
    Dim lNextSerialCheck As Long
    Const btNumberReadings As Byte = 5
    Dim btReadingCount As Byte = 0
    Dim btReadingNumber As Byte
    Dim sngVoltAvgAry() As Single = {0.0, 0.0, 0.0, 0.0, 0.0}
    Dim sngCurrentAvgAry() As Single = {0.0, 0.0, 0.0, 0.0, 0.0}
    Dim sngPowerAvgAry() As Single = {0.0, 0.0, 0.0, 0.0, 0.0}
    Dim sngVoltAvgTotal As Single = 0
    Dim sngCurrentAvgTotal As Single = 0
    Dim sngPowerAvgTotal As Single = 0
    Dim sngVoltAvg As Single = 0
    Dim sngCurrentAvg As Single = 0
    Dim sngPowerAvg As Single = 0
    Dim sngSpeed As Single = 0
    Dim btHR As Byte = 0
    Dim btCadence As Byte = 0
    Dim dblCalorieTotal As Double
    Dim dblDistance As Double
    Dim strSerialLost As String = "Arduino Not Found"
    Dim strSerialOpen As String = "Arduino Connected"
    Dim TCXWriter As XmlTextWriter = Nothing
    Dim sngCalPerKJ As Single = 1
    Dim sngPowerTrainEff As Single = 0.5 'Need to measure

    'https://condor.depaul.edu/sjost/it236/documents/colorNames.htm
    Dim clrSerialLostColor As Color = System.Drawing.Color.Red
    Dim clrSerialOpenColor As Color = System.Drawing.Color.Green
    Dim clrBGOverVoltage As Color = System.Drawing.Color.Crimson
    Dim clrBGRunning As Color = System.Drawing.Color.SeaGreen
    Dim clrBGStopped As Color = System.Drawing.Color.Gray
    Dim clrBGPaused As Color = System.Drawing.Color.SteelBlue

#End Region

    Public Class PowerMeterData
        Public CurrentDate As Date
        Public CurrentTime As Date
        Public Speed As Single
        Public Cadence As Integer
        Public HR As Integer
        Public Voltage As Single
        Public Current As Single
        Public Power As Single
        Public Energy As Double
    End Class

#Region "Form Events"
    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set form properties
        Me.CenterToParent()

        btnPause.Enabled = False
        btnPause.Visible = False

        btnDone.Enabled = False
        btnDone.Visible = False

        'Set workouts listbox

        astWorkoutIntervals = CSVRead(My.Resources.CyclingWorkouts)

        For btIntIdx As Byte = 1 To UBound(astWorkoutIntervals, 1)
            cbWorkouts.Items.Add(astWorkoutIntervals(btIntIdx, 0))
        Next btIntIdx
        cbWorkouts.SelectedIndex = 0

        lblDurationValue.Text = 4
        SetWorkoutTimer()
        SetIntervalTimer()

        SerialReadTimer.Start()
        SerialWriteTimer.Start()

        'Wait 5 SerialReadTimer intervals before auto checking serial port
        lNextSerialCheck = 5

        'Select default baud rate
        cbBaudRate.SelectedItem = "9600"

        'Do not display point values on chart
        chtVoltage.Series(0).IsValueShownAsLabel = False
        chtCurrent.Series(0).IsValueShownAsLabel = False
        chtPower.Series(0).IsValueShownAsLabel = False
        chtEnergy.Series(0).IsValueShownAsLabel = False

        'Hide X axis for all charts
        chtVoltage.ChartAreas(0).AxisX.Enabled = DataVisualization.Charting.AxisEnabled.False
        chtCurrent.ChartAreas(0).AxisX.Enabled = DataVisualization.Charting.AxisEnabled.False
        chtPower.ChartAreas(0).AxisX.Enabled = DataVisualization.Charting.AxisEnabled.False
        chtEnergy.ChartAreas(0).AxisX.Enabled = DataVisualization.Charting.AxisEnabled.False

        chtVoltage.ChartAreas(0).AxisY.Maximum = 5
        chtCurrent.ChartAreas(0).AxisY.Maximum = 1
        chtPower.ChartAreas(0).AxisY.Maximum = 5
        chtEnergy.ChartAreas(0).AxisY.Maximum = 5

    End Sub

    Private Sub frmDashboard_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        SerialReadTimer.Stop()
        SerialWriteTimer.Stop()
        WorkoutTimer.Stop()
        ArduinoSerial.Close()
    End Sub

#End Region

#Region "Button Click Events"

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Call StartWO()
    End Sub

    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Call EndWorkout()
    End Sub

    Private Sub BtnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        Call PauseWO()
    End Sub

    Private Sub btnDurationDec_Click(sender As Object, e As MouseEventArgs) Handles btnDurationDec.MouseDown
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                If lblDurationValue.Text > 5 Then lblDurationValue.Text = lblDurationValue.Text - 1
            Case Windows.Forms.MouseButtons.Right
                If lblDurationValue.Text > 15 Then
                    lblDurationValue.Text = lblDurationValue.Text - 10
                Else
                    If lblDurationValue.Text > 5 Then lblDurationValue.Text = lblDurationValue.Text - 1
                End If
        End Select

    End Sub

    Private Sub btnDurationInc_Click(sender As Object, e As MouseEventArgs) Handles btnDurationInc.MouseDown
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                If lblDurationValue.Text < 600 Then lblDurationValue.Text = lblDurationValue.Text + 1
            Case Windows.Forms.MouseButtons.Right
                If lblDurationValue.Text < 591 Then
                    lblDurationValue.Text = lblDurationValue.Text + 10
                Else
                    lblDurationValue.Text = lblDurationValue.Text + 1
                End If
        End Select
    End Sub

    Private Sub lblDurationValue_DoubleClick(sender As Object, e As EventArgs) Handles lblDurationValue.DoubleClick
        If MsgBox("Reset to 30 Minutes?", vbYesNo) = vbYes Then
            lblDurationValue.Text = 30
        End If
    End Sub

#End Region

#Region "Timer Tick Events"
    Private Sub SerialWriteTimer_Tick(sender As Object, e As EventArgs) Handles SerialWriteTimer.Tick

        If ArduinoSerial.IsOpen = False Then Exit Sub

        Dim dblIntDuration As Double = (lblDurationValue.Text * 60) / UBound(astWorkoutIntervals, 2) 'Seconds
        Dim iIntIdx As Integer = Math.Floor(Math.Truncate(dblWorkoutTime) / dblIntDuration) + 1
        If iIntIdx > UBound(astWorkoutIntervals, 2) Then iIntIdx = UBound(astWorkoutIntervals, 2)

        Dim btWOIdx As Byte = cbWorkouts.SelectedIndex
        Dim sngWorkoutLevel As Single = CSng(astWorkoutIntervals(btWOIdx + 1, iIntIdx))

        If sngWorkoutLevel > 10 Or sngWorkoutLevel < 1 Then sngWorkoutLevel = 1
        If blTracking = False Then sngWorkoutLevel = 1

        btPWMWriteValue = Normalize(sngWorkoutLevel, 0, 10, 0, 255)
        If cbPWMOverride.Text <> "" Then
            btPWMWriteValue = CByte(cbPWMOverride.Text)
        End If

        Try
            'Send byte data by first putting it into a buffer and then sending the specific byte of data
            'If only Serial.Write is used, value is converted to ASCII and any value larger than 127 will send as 63 [?]
            Dim PWMBytes As Byte() = {btPWMWriteValue, 0}
            ArduinoSerial.Write(PWMBytes, 0, 1)

            lblPWMWriteValue.Text = btPWMWriteValue
            lblWriteBufferValue.Text = ArduinoSerial.BytesToWrite & " / " & ArduinoSerial.WriteBufferSize
        Catch ex As Exception
        End Try

    End Sub

    Private Sub WorkoutTimer_Tick(sender As Object, e As EventArgs) Handles WorkoutTimer.Tick
        Dim lWorkoutDuration As Double = lblDurationValue.Text * 60

        If blTracking = True Then
            If dblWorkoutTime < lWorkoutDuration Then
                dblWorkoutTime = dblWorkoutTime + (WorkoutTimer.Interval / 1000)
                SetWorkoutTimer()
                SetIntervalTimer()

            Else
                EndWorkout(True)
            End If
        End If

    End Sub

    Private Sub SerialReadTimer_Tick(sender As Object, e As EventArgs) Handles SerialReadTimer.Tick
        Dim sRawSerialRead As String
        Dim sSerialReadArray As String()

        If ArduinoSerial.IsOpen = False Then
            If lNextSerialCheck = 0 Then
                Call ScanPort()
                If cbPort.Items.Count > 0 Then Call ConnectAll()

                'Wait 10 timer intervals before checking again
                lNextSerialCheck = 10
            Else
                lNextSerialCheck -= 1
            End If

            'If serial port was not connected, wait until next time to try again
            Exit Sub
        End If

        Try

            sRawSerialRead = ArduinoSerial.ReadLine
            If sRawSerialRead <> "" Then
                lblReadBufferValue.Text = ArduinoSerial.BytesToRead & " / " & ArduinoSerial.ReadBufferSize

                sSerialReadArray = Split(sRawSerialRead, ",")

                'Collect all data

                If btReadingCount < btNumberReadings Then
                    btReadingCount += 1
                End If

                'Find running average for voltage value
                sngVoltAvgTotal -= sngVoltAvgAry(btReadingNumber)
                sngVoltAvgAry(btReadingNumber) = sSerialReadArray(0)
                sngVoltAvgTotal += sngVoltAvgAry(btReadingNumber)
                sngVoltAvg = sngVoltAvgTotal / btReadingCount

                'Find running average for current value
                sngCurrentAvgTotal -= sngCurrentAvgAry(btReadingNumber)
                sngCurrentAvgAry(btReadingNumber) = sSerialReadArray(1)
                sngCurrentAvgTotal += sngCurrentAvgAry(btReadingNumber)
                sngCurrentAvg = sngCurrentAvgTotal / btReadingCount

                'Find running average for power value
                sngPowerAvgTotal -= sngPowerAvgAry(btReadingNumber)
                sngPowerAvgAry(btReadingNumber) = sSerialReadArray(2)
                sngPowerAvgTotal += sngPowerAvgAry(btReadingNumber)
                sngPowerAvg = sngPowerAvgTotal / btReadingCount

                'Set next reading, or reset to 0
                If btReadingNumber < btNumberReadings - 1 Then
                    btReadingNumber += 1
                Else
                    btReadingNumber = 0
                End If

                'Convert 'milli' values to full units and round to 1 decimal place
                sngVoltAvg = Math.Round(sngVoltAvg / 1000, 1)
                sngCurrentAvg = Math.Round(sngCurrentAvg / 1000, 1)
                sngPowerAvg = Math.Round(sngPowerAvg / 1000, 0) / sngPowerTrainEff

                Dim bytePWMFeedback As Integer = sSerialReadArray(3)

                'Copy values to indicators on dashboard

                lblVoltageValue.Text = Format(sngVoltAvg, "00.0")
                lblCurrentValue.Text = Format(sngCurrentAvg, "00.0")
                lblPowerValue.Text = Format(sngPowerAvg, "000")

                lblPWMReadValue.Text = bytePWMFeedback

                If blTracking = True Then

                    'Find total energy in watt-seconds, display text value
                    dblCalorieTotal += sngPowerAvg * SerialReadTimer.Interval / 1000.0

                    'Convert watt-milliseconds to calories (watt-second = Joule @ 25% metabolic efficiency)
                    lblCalorieValue.Text = Format(Math.Round(dblCalorieTotal / 1000, 1), "0000")

                    'Update chart and increase y-axis maximum if needed
                    chtVoltage.Series(0).Points.AddY(sngVoltAvg)
                    If sngVoltAvg > chtVoltage.ChartAreas(0).AxisY.Maximum Then chtVoltage.ChartAreas(0).AxisY.Maximum = Math.Ceiling(sngVoltAvg / 5) * 5 + 5

                    chtCurrent.Series(0).Points.AddY(sngCurrentAvg)
                    If sngCurrentAvg > chtCurrent.ChartAreas(0).AxisY.Maximum Then chtCurrent.ChartAreas(0).AxisY.Maximum = Math.Ceiling(sngCurrentAvg / 0.1) * 0.1 + 0.1

                    chtPower.Series(0).Points.AddY(sngPowerAvg)
                    If sngPowerAvg > chtPower.ChartAreas(0).AxisY.Maximum Then chtPower.ChartAreas(0).AxisY.Maximum = Math.Ceiling(sngPowerAvg / 5) * 5 + 5

                    chtEnergy.Series(0).Points.AddY(lblCalorieValue.Text)
                    If lblCalorieValue.Text > chtEnergy.ChartAreas(0).AxisY.Maximum Then chtEnergy.ChartAreas(0).AxisY.Maximum = Math.Ceiling(Convert.ToDouble(lblCalorieValue.Text) / 5) * 5 + 5

                    'Voltage Chart
                    If chtVoltage.Series(0).Points.Count >= 300 Then
                        chtVoltage.Series(0).Points.RemoveAt(0)
                    End If

                    'Current Chart
                    If chtCurrent.Series(0).Points.Count >= 300 Then
                        chtCurrent.Series(0).Points.RemoveAt(0)
                    End If

                    'Power Chart
                    If chtPower.Series(0).Points.Count >= 300 Then
                        chtPower.Series(0).Points.RemoveAt(0)
                    End If

                    'Energy Chart
                    If chtEnergy.Series(0).Points.Count >= 300 Then
                        chtEnergy.Series(0).Points.RemoveAt(0)
                    End If

                    lblLogSizeValue.Text = lsRideLog.Count

                End If

            End If
        Catch ex As Exception
            If Not ArduinoSerial.IsOpen Then
                lblWarning.Text = strSerialLost
                lblWarning.ForeColor = clrSerialLostColor
            End If

        End Try

        Select Case sngVoltAvg
            Case Is > 30
                Me.BackColor = clrBGOverVoltage
                Me.chtIntervals.BackColor = clrBGOverVoltage
                Me.chtIntervals.ChartAreas(1).BackColor = clrBGOverVoltage
            Case Is < 0.1
                If blTracking = True Then
                    Call PauseWO()
                    Me.BackColor = clrBGPaused
                    Me.chtIntervals.BackColor = clrBGPaused
                    Me.chtIntervals.ChartAreas(0).BackColor = clrBGPaused
                End If
            Case Else
                If btnDone.Visible = True Then Call StartWO()

                If blTracking = True Then
                    Me.BackColor = clrBGRunning
                    Me.chtIntervals.BackColor = clrBGRunning
                    Me.chtIntervals.ChartAreas(0).BackColor = clrBGRunning
                Else
                    Me.BackColor = clrBGStopped
                    Me.chtIntervals.BackColor = clrBGStopped
                    Me.chtIntervals.ChartAreas(0).BackColor = clrBGStopped
                End If

        End Select

    End Sub

    Private Sub TCXTimer_Tick(sender As Object, e As EventArgs) Handles TCXTimer.Tick
        Dim TCXTime As String

        'Assemble TCX Data
        With DateTime.Now
            TCXTime = .Year & "-" & .Month & "-" & .Day & "-" & "T" & .Hour & ":" & .Minute & ":" & .Second & "Z"
        End With

        Dim TCXSpeed As String = sngSpeed
        Dim TCXDist As String = dblDistance * 1609.344 'Distance - convert from miles to meters
        Dim TCXVoltage As String = sngVoltAvg
        Dim TCXCurrent As String = sngCurrentAvg
        Dim TCXCalories As String = lblCalorieValue.Text
        Dim TCXHR As String = btHR
        Dim TCXCadence As String = btCadence
        CreateTCXNode(TCXTime, TCXSpeed, TCXDist, TCXVoltage, TCXCurrent, TCXCalories, TCXHR, TCXCadence, TCXWriter)
    End Sub

#End Region

#Region "Selection Change Events"

    Private Sub cbWorkouts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbWorkouts.SelectedIndexChanged
        chtIntervals.Series.Clear()

        For iIntIdx As Integer = 1 To UBound(astWorkoutIntervals, 2)
            If cbWorkouts.SelectedItem = "Random" Then astWorkoutIntervals(cbWorkouts.SelectedIndex + 1, iIntIdx) =
                CStr(CInt(Math.Floor((8 - 2 + 1) * Rnd())) + 2)
            chtIntervals.Series.Add("Interval " & iIntIdx)
            chtIntervals.Series("Interval " & iIntIdx).Points.AddY(astWorkoutIntervals(cbWorkouts.SelectedIndex + 1, iIntIdx))
        Next iIntIdx
    End Sub

#End Region

#Region "Methods (No Return Value)"
    Sub SetWorkoutTimer()
        'lWorkoutTime is global 

        Dim lWorkoutSeconds As Double = lblDurationValue.Text * 60
        Dim lSecondsRemaining As Double = (lWorkoutSeconds - dblWorkoutTime)
        Dim iSpan As TimeSpan = TimeSpan.FromSeconds(lSecondsRemaining)

        Dim sHoursRemaining As String = iSpan.Hours.ToString.PadLeft(2, "0"c)
        Dim sMinutesRemaining As String = iSpan.Minutes.ToString.PadLeft(2, "0"c)
        Dim sSecondsRemaining As String = iSpan.Seconds.ToString.PadLeft(2, "0"c)

        lblWOTimeRemaining.Text = "WO: " & sHoursRemaining & ":" & sMinutesRemaining & ":" & sSecondsRemaining

    End Sub

    Sub SetIntervalTimer()
        'Dim dblWorkoutSeconds As Double = lblDurationValue.Text * 60

        Dim dblIntDuration As Double = (lblDurationValue.Text * 60) / UBound(astWorkoutIntervals, 2) 'Seconds
        Dim iIntIdx As Integer = Math.Floor(Math.Truncate(dblWorkoutTime) / dblIntDuration) + 1
        If iIntIdx > UBound(astWorkoutIntervals, 2) Then iIntIdx = UBound(astWorkoutIntervals, 2)

        Dim dblSecondsRemaining As Double = (iIntIdx * dblIntDuration) - dblWorkoutTime
        Dim tsSpan As TimeSpan = TimeSpan.FromSeconds(dblSecondsRemaining)

        Dim sMinutesRemaining As String = tsSpan.Minutes.ToString.PadLeft(2, "0"c)
        Dim sSecondsRemaining As String = tsSpan.Seconds.ToString.PadLeft(2, "0"c)
        'Dim sMillisRemaining As String = iSpan.Milliseconds.ToString.PadLeft(2, "0"c)

        lblIntTimeRemaining.Text = "Int " & iIntIdx & ": " & sMinutesRemaining & ":" & sSecondsRemaining '& "." & sMillisRemaining / 100
        MarkIntervalBar(iIntIdx)

    End Sub

    Sub MarkIntervalBar(iIntIdx As Integer)
        For i = 1 To chtIntervals.Series.Count
            If i = iIntIdx And blTracking = True Then
                chtIntervals.Series("Interval " & i).BackHatchStyle = DataVisualization.Charting.ChartHatchStyle.SolidDiamond
            Else
                chtIntervals.ApplyPaletteColors()
            End If

        Next i
    End Sub

    Sub EndWorkout(Optional bTimesUp As Boolean = False)
        Dim bUserResponse As Byte

        If bTimesUp = False Then bUserResponse = MsgBox("End Workout?", vbYesNo)

        If bTimesUp = True Or bUserResponse = vbYes Then
            blTracking = False
            WorkoutTimer.Stop()
            TCXTimer.Stop()
            dblWorkoutTime = 0

            'Hide Pause and Done buttons
            btnPause.Visible = False
            btnPause.Enabled = False
            btnDone.Visible = False
            btnDone.Enabled = False

            'Show Start Button
            btnStart.Visible = True
            btnStart.Enabled = True

            'Enable WO Timer Adjust Buttons
            btnDurationDec.Enabled = True
            btnDurationInc.Enabled = True

            SetWorkoutTimer()
            lblIntTimeRemaining.Text = strIntTimeRemaining

            'Enable WO type combobox
            cbWorkouts.Enabled = True

            'Close TCX file
            TCXWriter.WriteEndElement()
            TCXWriter.WriteEndElement()
            TCXWriter.WriteEndElement()
            TCXWriter.WriteEndElement()
            TCXWriter.WriteEndDocument()
            TCXWriter.Close()

        End If

    End Sub

    Sub ConnectAll()

        Try
            If cbPort.SelectedItem <> "" Then
                ArduinoSerial.BaudRate = cbBaudRate.SelectedItem
                ArduinoSerial.PortName = cbPort.SelectedItem
                ArduinoSerial.DataBits = 8
                ArduinoSerial.StopBits = 1
                ArduinoSerial.Parity = 0
                ArduinoSerial.ReadTimeout = 1
                ArduinoSerial.Open()
                ArduinoSerial.DiscardInBuffer()

                If ArduinoSerial.IsOpen Then
                    lblWarning.Text = strSerialOpen
                    lblWarning.ForeColor = clrSerialOpenColor
                End If
            End If
        Catch ex As Exception
            lblWarning.Text = strSerialLost
            lblWarning.ForeColor = clrSerialLostColor
        End Try

    End Sub

    Sub ScanPort()
        cbPort.Items.Clear()
        Dim aryMyPort As Array = IO.Ports.SerialPort.GetPortNames()
        cbPort.Items.AddRange(aryMyPort)
        Dim iIdx As Integer = cbPort.Items.Count

        iIdx = iIdx - iIdx

        Try
            cbPort.SelectedIndex = iIdx
        Catch ex As Exception
            lblWarning.Text = strSerialLost
            lblWarning.ForeColor = clrSerialLostColor

            cbPort.Text = ""
            cbPort.Items.Clear()
            Exit Sub
        End Try

    End Sub

    Sub PauseWO()
        blTracking = False

        btnDone.Enabled = True
        btnDone.BringToFront()
        btnPause.Enabled = False
        btnPause.SendToBack()
        btnStart.Enabled = True
    End Sub

    Sub StartWO()
        WorkoutTimer.Start()
        blTracking = True

        btnStart.Enabled = False

        btnPause.Enabled = True
        btnPause.Visible = True
        btnPause.BringToFront()

        btnDone.Enabled = False
        btnDone.Visible = True
        btnDone.SendToBack()

        If dblWorkoutTime = 0.0 Then
            TCXTimer.Start()
            chtVoltage.Series(0).Points.Clear()
            chtCurrent.Series(0).Points.Clear()
            chtPower.Series(0).Points.Clear()
            For i = 0 To chtIntervals.Series.Count - 1
                chtIntervals.Series(i).BackHatchStyle = DataVisualization.Charting.ChartHatchStyle.None
            Next

            Dim sTCXFilename As String
            Dim sTCXFilePath As String = "C:\Users\ryanj\Documents\NerdyPowerMeter Logs\"
            sTCXFilename = "NerdyTrainer_" & DateTime.Now.Year & DateTime.Now.Month & DateTime.Now.Day & DateTime.Now.Hour & DateTime.Now.Minute & DateTime.Now.Second & ".TCX"

            TCXWriter = New XmlTextWriter(sTCXFilePath & sTCXFilename, System.Text.Encoding.UTF8)

            'Write Starting Elements
            TCXWriter.WriteStartDocument(False)
            TCXWriter.Formatting = Formatting.Indented
            TCXWriter.Indentation = 2

            'Write "Folders" Element
            TCXWriter.WriteStartElement("TrainingCenterDatabase")
            TCXWriter.WriteAttributeString("xmlns", "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2")
            TCXWriter.WriteAttributeString("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance")
            TCXWriter.WriteAttributeString("xsi:schemaLocation", "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2 http://www.garmin.com/xmlschemas/TrainingCenterDatabasev2.xsd")
            TCXWriter.WriteStartElement("Folders")
            TCXWriter.WriteStartElement("Courses")
            TCXWriter.WriteStartElement("CourseFolder")
            TCXWriter.WriteAttributeString("Name", "Courses")
            TCXWriter.WriteStartElement("CourseNameRef")
            TCXWriter.WriteStartElement("Id") : TCXWriter.WriteString("Nerdy Trainer") : TCXWriter.WriteEndElement()
            TCXWriter.WriteEndElement()
            TCXWriter.WriteEndElement()
            TCXWriter.WriteEndElement()
            TCXWriter.WriteEndElement()

            'Write "Courses" Element
            TCXWriter.WriteStartElement("Courses")
            TCXWriter.WriteStartElement("Course")
            TCXWriter.WriteStartElement("Name") : TCXWriter.WriteString("Nerdy Trainer") : TCXWriter.WriteEndElement()
            TCXWriter.WriteStartElement("Track")

        End If

        'Disable WO time adjustment buttons
        btnDurationDec.Enabled = False
        btnDurationInc.Enabled = False

        'Disable WO type combobox
        cbWorkouts.Enabled = False
    End Sub

    Sub CreateTCXNode(ByVal Time As String, ByVal Speed As String, ByVal Distance As String, ByVal Voltage As String, ByVal Current As String, ByVal Calories As String,
                      ByVal HR As String, ByVal Cadence As String, ByVal Writer As XmlTextWriter)

        Writer.WriteStartElement("Trackpoint")
        Writer.WriteStartElement("Time") : Writer.WriteString(Time) : Writer.WriteEndElement()
        Writer.WriteStartElement("Speed") : Writer.WriteString(Speed) : Writer.WriteEndElement()
        Writer.WriteStartElement("DistanceMeters") : Writer.WriteString(Distance) : Writer.WriteEndElement()
        Writer.WriteStartElement("Voltage") : Writer.WriteString(Voltage) : Writer.WriteEndElement()
        Writer.WriteStartElement("Current") : Writer.WriteString(Current) : Writer.WriteEndElement()
        Writer.WriteStartElement("Calories") : Writer.WriteString(Calories) : Writer.WriteEndElement()
        Writer.WriteStartElement("HR") : Writer.WriteString(HR) : Writer.WriteEndElement()
        Writer.WriteStartElement("Cadence") : Writer.WriteString(Cadence) : Writer.WriteEndElement()
        Writer.WriteEndElement()
    End Sub

#End Region

#Region "Methods (Return Value)"
    Function PWMOverride(sngVoltage As Single) As Single
        If sngVoltage > 30 Then
            PWMOverride = Normalize(sngVoltage, 30.0, 34.0, 0.0, 255.0)
        Else PWMOverride = 0
        End If
    End Function

    Function Normalize(ValueIn As Single, RMin As Single, RMax As Single, TMin As Single, TMax As Single) As Single
        Normalize = (ValueIn - RMin) / (RMax - RMin) * (TMax - TMin) + TMin
    End Function

    Function CSVRead(strInputString As String) As String(,)
        Dim astOutputArray(0 To 6, 0 To 40) As String

        Using MyReader As New IO.StringReader(strInputString)
            Using TextParser As New Microsoft.VisualBasic.FileIO.TextFieldParser(MyReader)
                TextParser.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
                TextParser.Delimiters = New String() {","}
                Dim currentRow As String()

                Dim ColumnIdx As Integer

                While Not TextParser.EndOfData
                    Try
                        currentRow = TextParser.ReadFields()

                        For i As Integer = 0 To currentRow.Length - 1
                            astOutputArray(ColumnIdx, i) = currentRow(i)
                        Next

                        ColumnIdx = ColumnIdx + 1

                    Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                        MsgBox("Line " & ex.Message & " is invalid.  Skipping")
                    End Try
                End While
            End Using
        End Using

        CSVRead = astOutputArray
    End Function

#End Region

End Class