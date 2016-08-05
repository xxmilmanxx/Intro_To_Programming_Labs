Public Class frmRegistration

    Private Sub frmRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RegClear()

    End Sub

    Private Sub btnRegExit_Click(sender As Object, e As EventArgs) Handles btnRegExit.Click

        Close()

    End Sub

    Private Sub btnRegClear_Click(sender As Object, e As EventArgs) Handles btnRegClear.Click

        RegClear()

    End Sub

    Private Sub chkbxRegAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxRegAll.CheckedChanged

        CheckAll()

    End Sub

    Private Sub gpbxAge_Enter(sender As Object, e As EventArgs) Handles gpbxAge.Enter

        CheckAge()

    End Sub

End Class