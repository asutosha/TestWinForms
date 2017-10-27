Public Class FormTest1

    Public Msg As String = "meh"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FormTest1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelMsg.Text = Msg
    End Sub

End Class
