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

    Public Sub RegClear()

        frmRegistration.txtRegName.Text = ""
        frmRegistration.DTPRegBirthday.ResetText()

        frmRegistration.rdoRegAge1729.Checked = False
        frmRegistration.rdoRegAge3049.Checked = False
        frmRegistration.rdoRegAge5069.Checked = False
        frmRegistration.rdoRegAge7099.Checked = False

        frmRegistration.cmboRegStatus.SelectedIndex = -1

        frmRegistration.chkbxRegReading.Checked = False
        frmRegistration.chkbxRegComp.Checked = False
        frmRegistration.chkbxRegBusiness.Checked = False
        frmRegistration.chkbxRegNSA.Checked = False
        frmRegistration.chkbxRegElectronics.Checked = False
        frmRegistration.chkbxRegDesign.Checked = False
        frmRegistration.chkbxRegAll.Checked = False

    End Sub

    Public Sub CheckAll()

        If frmRegistration.chkbxRegAll.Checked = True Then

            frmRegistration.chkbxRegReading.Checked = True
            frmRegistration.chkbxRegComp.Checked = True
            frmRegistration.chkbxRegBusiness.Checked = True
            frmRegistration.chkbxRegNSA.Checked = True
            frmRegistration.chkbxRegElectronics.Checked = True
            frmRegistration.chkbxRegDesign.Checked = True

        End If
    End Sub

    Public Sub CheckAge()


        If frmRegistration.rdoRegAge1729.Checked = True Then
            MessageBox.Show("Your age is between 17 and 29!", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf frmRegistration.rdoRegAge3049.Checked = True Then
            MessageBox.Show("Your age is between 30 and 24!", "BOO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf frmRegistration.rdoRegAge5069.Checked = True Then
            MessageBox.Show("Your age is between 50 and 69!", "AA-RON", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        ElseIf frmRegistration.rdoRegAge7099.Checked = True Then
            MessageBox.Show("Your age is between 70 and 99! You are what I call an Oldie but Goodie!!", "R U KIDDING", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If

    End Sub










End Module
