Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim initialGrades As Integer = CInt(inpGrades.Text)

        convertResult.Text = Module1.GradeConvert(initialGrades)

    End Sub

End Class