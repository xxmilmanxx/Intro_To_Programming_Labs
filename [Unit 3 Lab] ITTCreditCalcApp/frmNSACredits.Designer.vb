<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNSACredits
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCreditsTaken = New System.Windows.Forms.Label()
        Me.lblCreditsRemsining = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCreditsTaken = New System.Windows.Forms.TextBox()
        Me.txtCreditsRemaining = New System.Windows.Forms.TextBox()
        Me.btnResult = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(26, 9)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(358, 20)
        Me.lblInfo.TabIndex = 0
        Me.lblInfo.Text = "This calculator is based on a 90 credit completion."
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(39, 51)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(134, 17)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "What is your name?"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCreditsTaken
        '
        Me.lblCreditsTaken.AutoSize = True
        Me.lblCreditsTaken.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditsTaken.Location = New System.Drawing.Point(39, 125)
        Me.lblCreditsTaken.Name = "lblCreditsTaken"
        Me.lblCreditsTaken.Size = New System.Drawing.Size(228, 17)
        Me.lblCreditsTaken.TabIndex = 2
        Me.lblCreditsTaken.Text = "How many credits have you taken?"
        Me.lblCreditsTaken.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCreditsRemsining
        '
        Me.lblCreditsRemsining.AutoSize = True
        Me.lblCreditsRemsining.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditsRemsining.Location = New System.Drawing.Point(39, 203)
        Me.lblCreditsRemsining.Name = "lblCreditsRemsining"
        Me.lblCreditsRemsining.Size = New System.Drawing.Size(123, 17)
        Me.lblCreditsRemsining.TabIndex = 3
        Me.lblCreditsRemsining.Text = "Credits Remaining"
        Me.lblCreditsRemsining.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(79, 82)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(181, 23)
        Me.txtName.TabIndex = 4
        '
        'txtCreditsTaken
        '
        Me.txtCreditsTaken.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditsTaken.Location = New System.Drawing.Point(79, 159)
        Me.txtCreditsTaken.Name = "txtCreditsTaken"
        Me.txtCreditsTaken.Size = New System.Drawing.Size(181, 23)
        Me.txtCreditsTaken.TabIndex = 5
        '
        'txtCreditsRemaining
        '
        Me.txtCreditsRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditsRemaining.Location = New System.Drawing.Point(79, 235)
        Me.txtCreditsRemaining.Name = "txtCreditsRemaining"
        Me.txtCreditsRemaining.ReadOnly = True
        Me.txtCreditsRemaining.Size = New System.Drawing.Size(181, 23)
        Me.txtCreditsRemaining.TabIndex = 6
        '
        'btnResult
        '
        Me.btnResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResult.Location = New System.Drawing.Point(29, 354)
        Me.btnResult.Name = "btnResult"
        Me.btnResult.Size = New System.Drawing.Size(85, 40)
        Me.btnResult.TabIndex = 7
        Me.btnResult.Text = "RESULT"
        Me.btnResult.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(261, 355)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 40)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(142, 355)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 40)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtResults
        '
        Me.txtResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResults.Location = New System.Drawing.Point(29, 267)
        Me.txtResults.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.ReadOnly = True
        Me.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtResults.Size = New System.Drawing.Size(319, 77)
        Me.txtResults.TabIndex = 10
        Me.txtResults.TabStop = False
        Me.txtResults.Visible = False
        '
        'frmNSACredits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 403)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnResult)
        Me.Controls.Add(Me.txtCreditsRemaining)
        Me.Controls.Add(Me.txtCreditsTaken)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblCreditsRemsining)
        Me.Controls.Add(Me.lblCreditsTaken)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblInfo)
        Me.MaximumSize = New System.Drawing.Size(553, 453)
        Me.Name = "frmNSACredits"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ITT East Credit Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInfo As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblCreditsTaken As Label
    Friend WithEvents lblCreditsRemsining As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCreditsTaken As TextBox
    Friend WithEvents txtCreditsRemaining As TextBox
    Friend WithEvents btnResult As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtResults As TextBox
End Class
