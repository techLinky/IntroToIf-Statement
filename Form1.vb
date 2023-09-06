Public Class Form1
    Private Sub btnGreeting_Click(sender As Object, e As EventArgs) Handles btnGreeting.Click
        Dim NameofCountry As String

        NameofCountry = txtCountry.Text

        If NameofCountry = "South Africa" Then
            MsgBox("Molo")
        Else
            MsgBox("Hello")
        End If
    End Sub

    Private Sub txtCountry_TextChanged(sender As Object, e As EventArgs) Handles txtCountry.TextChanged

    End Sub
End Class
