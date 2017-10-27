Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ook = New OoookMaker
        Dim oForm = New FormTest1
        oForm.Msg = ook.Ooooks
        oForm.ShowDialog()
        oForm.Dispose()
    End Sub
End Class
