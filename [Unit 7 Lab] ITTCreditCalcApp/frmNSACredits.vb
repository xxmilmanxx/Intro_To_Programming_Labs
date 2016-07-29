' Johnathan Winters
' Lab 3 Lab
' 7/7/2016


Public Class frmNSACredits
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NSAClear()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        NSAClear()

        txtResults.Visible = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

    End Sub

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click

        NSAResult()

    End Sub
End Class
