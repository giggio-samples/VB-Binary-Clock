Public Class Light
    Inherits UserControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        Base2Factor = Base2Factor.One
        TimeFactor = TimeFactor.SecondsOnes
        rect = New Rectangle(0, 0, Width - 1, Height - 1)

    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        '
        'Light
        '
        Me.Name = "Light"
    End Sub

#End Region



    Private isLit As Boolean
    Private rect As Rectangle
    Public Property Base2Factor() As Base2Factor
    Public Property TimeFactor() As TimeFactor

    Private Sub Light_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Resize
        Height = Width
        rect.X = 0
        rect.Y = 0
        rect.Width = Width
        rect.Height = Height
        Invalidate(rect)
        PaintLight()
    End Sub

    Private Sub PaintLight()
        Using g As Graphics = CreateGraphics()
            Using brush As Brush = If(isLit, New SolidBrush(Color.Red), New SolidBrush(Color.Black))
                g.FillEllipse(brush, rect)
            End Using
        End Using
    End Sub


    Public Sub UpdateTime(ByVal time As Date)
        Dim timePiece As Integer

        Select Case TimeFactor
            Case TimeFactor.HoursOnes
                timePiece = time.Hour Mod 10
            Case TimeFactor.HoursTens
                timePiece = time.Hour \ 10
            Case TimeFactor.MinutesOnes
                timePiece = time.Minute Mod 10
            Case TimeFactor.MinutesTens
                timePiece = time.Minute \ 10
            Case TimeFactor.SecondsOnes
                timePiece = time.Second Mod 10
            Case TimeFactor.SecondsTens
                timePiece = time.Second \ 10
        End Select

        If (timePiece And Base2Factor) = 0 Then
            isLit = False
        Else
            isLit = True
        End If

        PaintLight()
    End Sub
End Class