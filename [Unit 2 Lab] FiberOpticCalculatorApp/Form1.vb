' Johnathan Winters
' Unit 2 Labs - Input, Processing, and Output
' (Reserved just in case you want to have title on seperate line)

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCompanyName.Text = ""
        txtFeet.Text = ""
        txtFiberCost.Text = ""
        txtResult.Text = ""
    End Sub

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        'Declare all variables
        Dim companyName As String
        Dim fiberCost As String
        Dim feetAmount As Integer
        Dim result As String

        'Assign all variables
        companyName = txtCompanyName.Text
        fiberCost = txtFiberCost.Text
        feetAmount = txtFeet.Text
        result = txtResult.Text

        'Do the math
        result = feetAmount * fiberCost

        'Output/Display Results
        txtResult.Text = "For the company " & companyName & ", the total cost is $" & result & ""

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'When CLEAR button is clicked all text fields are cleared
        txtCompanyName.Text = ""
        txtFeet.Text = ""
        txtFiberCost.Text = ""
        txtResult.Text = ""

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Window is closed when EXIT button is clicked
        Close()

    End Sub
End Class
