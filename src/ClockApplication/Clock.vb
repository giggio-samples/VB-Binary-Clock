Public Class Clock
    Inherits Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        InitializeComponent()
    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.

    Friend WithEvents clockTimer As System.Windows.Forms.Timer
    Friend WithEvents Light1 As ClockApplication.Light
    Friend WithEvents Light2 As ClockApplication.Light
    Friend WithEvents Light3 As ClockApplication.Light
    Friend WithEvents Light4 As ClockApplication.Light
    Friend WithEvents Light5 As ClockApplication.Light
    Friend WithEvents Light6 As ClockApplication.Light
    Friend WithEvents Light7 As ClockApplication.Light
    Friend WithEvents Light8 As ClockApplication.Light
    Friend WithEvents Light9 As ClockApplication.Light
    Friend WithEvents Light10 As ClockApplication.Light
    Friend WithEvents Light11 As ClockApplication.Light
    Friend WithEvents Light12 As ClockApplication.Light
    Friend WithEvents Light13 As ClockApplication.Light
    Friend WithEvents Light14 As ClockApplication.Light
    Friend WithEvents Light15 As ClockApplication.Light
    Friend WithEvents Light16 As ClockApplication.Light
    Friend WithEvents Light17 As ClockApplication.Light
    Friend WithEvents Light18 As ClockApplication.Light
    Friend WithEvents Light19 As ClockApplication.Light
    Friend WithEvents Light20 As ClockApplication.Light

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.clockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Light20 = New ClockApplication.Light()
        Me.Light19 = New ClockApplication.Light()
        Me.Light18 = New ClockApplication.Light()
        Me.Light17 = New ClockApplication.Light()
        Me.Light16 = New ClockApplication.Light()
        Me.Light15 = New ClockApplication.Light()
        Me.Light14 = New ClockApplication.Light()
        Me.Light13 = New ClockApplication.Light()
        Me.Light12 = New ClockApplication.Light()
        Me.Light11 = New ClockApplication.Light()
        Me.Light10 = New ClockApplication.Light()
        Me.Light9 = New ClockApplication.Light()
        Me.Light8 = New ClockApplication.Light()
        Me.Light7 = New ClockApplication.Light()
        Me.Light6 = New ClockApplication.Light()
        Me.Light5 = New ClockApplication.Light()
        Me.Light4 = New ClockApplication.Light()
        Me.Light3 = New ClockApplication.Light()
        Me.Light2 = New ClockApplication.Light()
        Me.Light1 = New ClockApplication.Light()
        Me.SuspendLayout()
        '
        'clockTimer
        '
        Me.clockTimer.Enabled = True
        Me.clockTimer.Interval = 200
        '
        'Light20
        '
        Me.Light20.Base2Factor = ClockApplication.Base2Factor.Two
        Me.Light20.Location = New System.Drawing.Point(8, 56)
        Me.Light20.Name = "Light20"
        Me.Light20.Size = New System.Drawing.Size(16, 16)
        Me.Light20.TabIndex = 19
        Me.Light20.TimeFactor = ClockApplication.TimeFactor.HoursTens
        '
        'Light19
        '
        Me.Light19.Base2Factor = ClockApplication.Base2Factor.One
        Me.Light19.Location = New System.Drawing.Point(8, 80)
        Me.Light19.Name = "Light19"
        Me.Light19.Size = New System.Drawing.Size(16, 16)
        Me.Light19.TabIndex = 18
        Me.Light19.TimeFactor = ClockApplication.TimeFactor.HoursTens
        '
        'Light18
        '
        Me.Light18.Base2Factor = ClockApplication.Base2Factor.Eight
        Me.Light18.Location = New System.Drawing.Point(32, 8)
        Me.Light18.Name = "Light18"
        Me.Light18.Size = New System.Drawing.Size(16, 16)
        Me.Light18.TabIndex = 17
        Me.Light18.TimeFactor = ClockApplication.TimeFactor.HoursOnes
        '
        'Light17
        '
        Me.Light17.Base2Factor = ClockApplication.Base2Factor.Four
        Me.Light17.Location = New System.Drawing.Point(32, 32)
        Me.Light17.Name = "Light17"
        Me.Light17.Size = New System.Drawing.Size(16, 16)
        Me.Light17.TabIndex = 16
        Me.Light17.TimeFactor = ClockApplication.TimeFactor.HoursOnes
        '
        'Light16
        '
        Me.Light16.Base2Factor = ClockApplication.Base2Factor.Two
        Me.Light16.Location = New System.Drawing.Point(32, 56)
        Me.Light16.Name = "Light16"
        Me.Light16.Size = New System.Drawing.Size(16, 16)
        Me.Light16.TabIndex = 15
        Me.Light16.TimeFactor = ClockApplication.TimeFactor.HoursOnes
        '
        'Light15
        '
        Me.Light15.Base2Factor = ClockApplication.Base2Factor.One
        Me.Light15.Location = New System.Drawing.Point(32, 80)
        Me.Light15.Name = "Light15"
        Me.Light15.Size = New System.Drawing.Size(16, 16)
        Me.Light15.TabIndex = 14
        Me.Light15.TimeFactor = ClockApplication.TimeFactor.HoursOnes
        '
        'Light14
        '
        Me.Light14.Base2Factor = ClockApplication.Base2Factor.Four
        Me.Light14.Location = New System.Drawing.Point(56, 32)
        Me.Light14.Name = "Light14"
        Me.Light14.Size = New System.Drawing.Size(16, 16)
        Me.Light14.TabIndex = 13
        Me.Light14.TimeFactor = ClockApplication.TimeFactor.MinutesTens
        '
        'Light13
        '
        Me.Light13.Base2Factor = ClockApplication.Base2Factor.Two
        Me.Light13.Location = New System.Drawing.Point(56, 56)
        Me.Light13.Name = "Light13"
        Me.Light13.Size = New System.Drawing.Size(16, 16)
        Me.Light13.TabIndex = 12
        Me.Light13.TimeFactor = ClockApplication.TimeFactor.MinutesTens
        '
        'Light12
        '
        Me.Light12.Base2Factor = ClockApplication.Base2Factor.One
        Me.Light12.Location = New System.Drawing.Point(56, 80)
        Me.Light12.Name = "Light12"
        Me.Light12.Size = New System.Drawing.Size(16, 16)
        Me.Light12.TabIndex = 11
        Me.Light12.TimeFactor = ClockApplication.TimeFactor.MinutesTens
        '
        'Light11
        '
        Me.Light11.Base2Factor = ClockApplication.Base2Factor.Eight
        Me.Light11.Location = New System.Drawing.Point(80, 8)
        Me.Light11.Name = "Light11"
        Me.Light11.Size = New System.Drawing.Size(16, 16)
        Me.Light11.TabIndex = 10
        Me.Light11.TimeFactor = ClockApplication.TimeFactor.MinutesOnes
        '
        'Light10
        '
        Me.Light10.Base2Factor = ClockApplication.Base2Factor.Four
        Me.Light10.Location = New System.Drawing.Point(80, 32)
        Me.Light10.Name = "Light10"
        Me.Light10.Size = New System.Drawing.Size(16, 16)
        Me.Light10.TabIndex = 9
        Me.Light10.TimeFactor = ClockApplication.TimeFactor.MinutesOnes
        '
        'Light9
        '
        Me.Light9.Base2Factor = ClockApplication.Base2Factor.Two
        Me.Light9.Location = New System.Drawing.Point(80, 56)
        Me.Light9.Name = "Light9"
        Me.Light9.Size = New System.Drawing.Size(16, 16)
        Me.Light9.TabIndex = 8
        Me.Light9.TimeFactor = ClockApplication.TimeFactor.MinutesOnes
        '
        'Light8
        '
        Me.Light8.Base2Factor = ClockApplication.Base2Factor.One
        Me.Light8.Location = New System.Drawing.Point(80, 80)
        Me.Light8.Name = "Light8"
        Me.Light8.Size = New System.Drawing.Size(16, 16)
        Me.Light8.TabIndex = 7
        Me.Light8.TimeFactor = ClockApplication.TimeFactor.MinutesOnes
        '
        'Light7
        '
        Me.Light7.Base2Factor = ClockApplication.Base2Factor.Four
        Me.Light7.Location = New System.Drawing.Point(104, 32)
        Me.Light7.Name = "Light7"
        Me.Light7.Size = New System.Drawing.Size(16, 16)
        Me.Light7.TabIndex = 6
        Me.Light7.TimeFactor = ClockApplication.TimeFactor.SecondsTens
        '
        'Light6
        '
        Me.Light6.Base2Factor = ClockApplication.Base2Factor.Two
        Me.Light6.Location = New System.Drawing.Point(104, 56)
        Me.Light6.Name = "Light6"
        Me.Light6.Size = New System.Drawing.Size(16, 16)
        Me.Light6.TabIndex = 5
        Me.Light6.TimeFactor = ClockApplication.TimeFactor.SecondsTens
        '
        'Light5
        '
        Me.Light5.Base2Factor = ClockApplication.Base2Factor.One
        Me.Light5.Location = New System.Drawing.Point(104, 80)
        Me.Light5.Name = "Light5"
        Me.Light5.Size = New System.Drawing.Size(16, 16)
        Me.Light5.TabIndex = 4
        Me.Light5.TimeFactor = ClockApplication.TimeFactor.SecondsTens
        '
        'Light4
        '
        Me.Light4.Base2Factor = ClockApplication.Base2Factor.Eight
        Me.Light4.Location = New System.Drawing.Point(128, 8)
        Me.Light4.Name = "Light4"
        Me.Light4.Size = New System.Drawing.Size(16, 16)
        Me.Light4.TabIndex = 3
        Me.Light4.TimeFactor = ClockApplication.TimeFactor.SecondsOnes
        '
        'Light3
        '
        Me.Light3.Base2Factor = ClockApplication.Base2Factor.Four
        Me.Light3.Location = New System.Drawing.Point(128, 32)
        Me.Light3.Name = "Light3"
        Me.Light3.Size = New System.Drawing.Size(16, 16)
        Me.Light3.TabIndex = 2
        Me.Light3.TimeFactor = ClockApplication.TimeFactor.SecondsOnes
        '
        'Light2
        '
        Me.Light2.Base2Factor = ClockApplication.Base2Factor.Two
        Me.Light2.Location = New System.Drawing.Point(128, 56)
        Me.Light2.Name = "Light2"
        Me.Light2.Size = New System.Drawing.Size(16, 16)
        Me.Light2.TabIndex = 1
        Me.Light2.TimeFactor = ClockApplication.TimeFactor.SecondsOnes
        '
        'Light1
        '
        Me.Light1.Base2Factor = ClockApplication.Base2Factor.One
        Me.Light1.Location = New System.Drawing.Point(128, 80)
        Me.Light1.Name = "Light1"
        Me.Light1.Size = New System.Drawing.Size(16, 16)
        Me.Light1.TabIndex = 0
        Me.Light1.TimeFactor = ClockApplication.TimeFactor.SecondsOnes
        '
        'Clock
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(162, 112)
        Me.ControlBox = False
        Me.Controls.Add(Me.Light20)
        Me.Controls.Add(Me.Light19)
        Me.Controls.Add(Me.Light18)
        Me.Controls.Add(Me.Light17)
        Me.Controls.Add(Me.Light16)
        Me.Controls.Add(Me.Light15)
        Me.Controls.Add(Me.Light14)
        Me.Controls.Add(Me.Light13)
        Me.Controls.Add(Me.Light12)
        Me.Controls.Add(Me.Light11)
        Me.Controls.Add(Me.Light10)
        Me.Controls.Add(Me.Light9)
        Me.Controls.Add(Me.Light8)
        Me.Controls.Add(Me.Light7)
        Me.Controls.Add(Me.Light6)
        Me.Controls.Add(Me.Light5)
        Me.Controls.Add(Me.Light4)
        Me.Controls.Add(Me.Light3)
        Me.Controls.Add(Me.Light2)
        Me.Controls.Add(Me.Light1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Clock"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Binary Clock"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private currentTime As DateTime
    Private lastSecond As Integer

    Private Sub Tick(ByVal sender As Object, ByVal e As EventArgs) Handles clockTimer.Tick

        Dim ctl As Control
        Dim time As Light

        If DateTime.Now.Second <> lastSecond Then
            currentTime = DateTime.Now
            lastSecond = currentTime.Second

            For Each ctl In Controls
                If TypeOf ctl Is Light Then
                    time = ctl
                    time.UpdateTime(currentTime)
                End If
            Next
        End If
    End Sub

    Private Sub Clicked(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Click
        Dim iResponse As Integer
        iResponse = MessageBox.Show("Do you want to close the clock?", "Close Clock?", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question)

        If iResponse = vbYes Then
            End
        End If
    End Sub
End Class
