<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblClientName = New System.Windows.Forms.Label()
        Me.lblFeet = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.txtCableFeet = New System.Windows.Forms.TextBox()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblClientName
        '
        Me.lblClientName.AutoSize = True
        Me.lblClientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientName.ForeColor = System.Drawing.Color.White
        Me.lblClientName.Location = New System.Drawing.Point(165, 158)
        Me.lblClientName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(249, 29)
        Me.lblClientName.TabIndex = 0
        Me.lblClientName.Text = "Your Company Name:"
        '
        'lblFeet
        '
        Me.lblFeet.AutoSize = True
        Me.lblFeet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeet.ForeColor = System.Drawing.Color.White
        Me.lblFeet.Location = New System.Drawing.Point(90, 306)
        Me.lblFeet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFeet.Name = "lblFeet"
        Me.lblFeet.Size = New System.Drawing.Size(324, 29)
        Me.lblFeet.TabIndex = 1
        Me.lblFeet.Text = "How many feed do you need:"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.White
        Me.lblResult.Location = New System.Drawing.Point(32, 418)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(682, 30)
        Me.lblResult.TabIndex = 2
        '
        'txtCompanyName
        '
        Me.txtCompanyName.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.txtCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompanyName.Location = New System.Drawing.Point(423, 162)
        Me.txtCompanyName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(223, 35)
        Me.txtCompanyName.TabIndex = 3
        '
        'txtCableFeet
        '
        Me.txtCableFeet.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.txtCableFeet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCableFeet.Location = New System.Drawing.Point(420, 306)
        Me.txtCableFeet.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCableFeet.Name = "txtCableFeet"
        Me.txtCableFeet.Size = New System.Drawing.Size(223, 35)
        Me.txtCableFeet.TabIndex = 4
        '
        'btnAnswer
        '
        Me.btnAnswer.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer.Location = New System.Drawing.Point(314, 512)
        Me.btnAnswer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(138, 65)
        Me.btnAnswer.TabIndex = 5
        Me.btnAnswer.Text = "&ANSWER"
        Me.btnAnswer.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(822, 622)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.txtCableFeet)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblFeet)
        Me.Controls.Add(Me.lblClientName)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Communications Corp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblClientName As Label
    Friend WithEvents lblFeet As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents txtCableFeet As TextBox
    Friend WithEvents btnAnswer As Button
End Class
