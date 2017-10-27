Module ModuleStuff
    Class OoookMaker
        Public Ooooks As String = Nothing

        Public Sub New()
            Dim sb As New System.Text.StringBuilder
            sb.Append("first line ffffffffffffffffffffffffff line end")
            sb.Append(vbNewLine)
            For i = 0 To 20
                sb.Append("ooook")
                sb.Append(vbNewLine)
            Next
            sb.Append("last  line end")
            sb.Append(vbNewLine)
            Ooooks = sb.ToString
        End Sub
    End Class
End Module
