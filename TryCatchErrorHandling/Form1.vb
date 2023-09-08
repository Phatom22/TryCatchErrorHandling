Public Class Form1
    Private Sub btnNum_Click(sender As Object, e As EventArgs) Handles btnNum.Click
        Dim value As String
        value = txtNum.Text

        Try
            Dim num As Double
            num = CDbl(value)

            MsgBox("you entered a value : " & num)
        Catch
            MsgBox("Error: " & value & " Is not a number")
        End Try
    End Sub
End Class
