' Johnathan Winters
' Lab 3 Lab
' 7/7/2016


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtName.Text = ""
        txtCreditsTaken.Text = ""
        txtCreditsRemaining.Text = ""
        txtResults.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtName.Text = ""
        txtCreditsTaken.Text = ""
        txtCreditsRemaining.Text = ""
        txtResults.Text = ""
        txtResults.Visible = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

    End Sub

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click

        Dim stuName As String
        Dim credTaken As String
        Dim credReaining As String

        stuName = txtName.Text
        credTaken = txtCreditsTaken.Text
        credReaining = txtCreditsRemaining.Text

        credReaining = 90 - credTaken

        txtCreditsRemaining.Text = credReaining

        txtResults.Visible = True
        txtResults.Text = stuName & ", based on a 90 credit total completion rate and " & credTaken & " already taken, you have only " & credReaining & " credits remaining."
    End Sub
End Class
