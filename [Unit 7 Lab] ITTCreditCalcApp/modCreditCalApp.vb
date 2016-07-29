Module modCreditCalApp

    Public Sub NSAClear()

        frmNSACredits.txtName.Text = ""
        frmNSACredits.txtCreditsTaken.Text = ""
        frmNSACredits.txtCreditsRemaining.Text = ""
        frmNSACredits.txtResults.Text = ""

    End Sub

    Public Sub NSAResult()

        Dim stuName As String
        Dim credTaken As String
        Dim credReaining As String

        stuName = frmNSACredits.txtName.Text
        credTaken = frmNSACredits.txtCreditsTaken.Text
        credReaining = frmNSACredits.txtCreditsRemaining.Text

        credReaining = 90 - credTaken

        frmNSACredits.txtCreditsRemaining.Text = credReaining

        frmNSACredits.txtResults.Visible = True
        frmNSACredits.txtResults.Text = stuName & ", based on a 90 credit total completion rate and " & credTaken & " already taken, you have only " & credReaining & " credits remaining."

    End Sub

    ' frmRegistration










End Module
