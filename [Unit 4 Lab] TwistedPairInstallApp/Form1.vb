' John Winters
' Lab 4 Modules
' 7/7/2016

Public Class Form1

    Dim costPerFeet As Double = 0.21
    Dim taxCost As Double = 0.06
    Dim cableFeet As String
    Dim clientName As String
    Dim finalBill As Double = 0
    Dim subTotal As Double = 0
    Dim taxSubTotal As Double = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub inputData(ByRef clientName As String, ByRef cableFeet As String)

        clientName = txtCompanyName.Text
        cableFeet = txtCableFeet.Text

    End Sub

    Public Sub calcCost(ByVal cableFeet As String, ByRef subTotal As Double, ByRef taxCost As Double, ByRef finalBill As Double)

        subTotal = cableFeet * costPerFeet
        taxSubTotal = subTotal * taxCost
        finalBill = subTotal + taxSubTotal

    End Sub

    Public Sub fBill(ByVal clientName As String, ByVal finalBill As Double)

        lblResult.Text = clientName & ", your final bill is: $" & finalBill

    End Sub

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click

        inputData(clientName, cableFeet)
        calcCost(cableFeet, subTotal, taxCost, finalBill)
        fBill(clientName, finalBill)

    End Sub
End Class
