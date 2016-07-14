<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnResult = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblCompanyNae = New System.Windows.Forms.Label()
        Me.lblFiberCost = New System.Windows.Forms.Label()
        Me.lblFeet = New System.Windows.Forms.Label()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.txtFiberCost = New System.Windows.Forms.TextBox()
        Me.txtFeet = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnResult
        '
        Me.btnResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResult.Location = New System.Drawing.Point(24, 322)
        Me.btnResult.Name = "btnResult"
        Me.btnResult.Size = New System.Drawing.Size(82, 45)
        Me.btnResult.TabIndex = 0
        Me.btnResult.Text = "RESULT"
        Me.btnResult.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(186, 322)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 45)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(357, 322)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 45)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(67, 39)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(337, 24)
        Me.lblWelcome.TabIndex = 3
        Me.lblWelcome.Text = "Welcome to my Fiber Optic Calculator!!"
        '
        'lblCompanyNae
        '
        Me.lblCompanyNae.AutoSize = True
        Me.lblCompanyNae.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyNae.Location = New System.Drawing.Point(17, 106)
        Me.lblCompanyNae.Name = "lblCompanyNae"
        Me.lblCompanyNae.Size = New System.Drawing.Size(215, 16)
        Me.lblCompanyNae.TabIndex = 4
        Me.lblCompanyNae.Text = "What is the name of your company:"
        Me.lblCompanyNae.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFiberCost
        '
        Me.lblFiberCost.AutoSize = True
        Me.lblFiberCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiberCost.Location = New System.Drawing.Point(16, 148)
        Me.lblFiberCost.Name = "lblFiberCost"
        Me.lblFiberCost.Size = New System.Drawing.Size(216, 16)
        Me.lblFiberCost.TabIndex = 5
        Me.lblFiberCost.Text = "What is the cost of fiber these days:"
        Me.lblFiberCost.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFeet
        '
        Me.lblFeet.AutoSize = True
        Me.lblFeet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeet.Location = New System.Drawing.Point(55, 195)
        Me.lblFeet.Name = "lblFeet"
        Me.lblFeet.Size = New System.Drawing.Size(177, 16)
        Me.lblFeet.TabIndex = 6
        Me.lblFeet.Text = "How many feet do you need:"
        Me.lblFeet.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompanyName.Location = New System.Drawing.Point(238, 103)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(201, 22)
        Me.txtCompanyName.TabIndex = 7
        '
        'txtFiberCost
        '
        Me.txtFiberCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiberCost.Location = New System.Drawing.Point(238, 148)
        Me.txtFiberCost.Name = "txtFiberCost"
        Me.txtFiberCost.Size = New System.Drawing.Size(201, 22)
        Me.txtFiberCost.TabIndex = 8
        '
        'txtFeet
        '
        Me.txtFeet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeet.Location = New System.Drawing.Point(238, 195)
        Me.txtFeet.Name = "txtFeet"
        Me.txtFeet.Size = New System.Drawing.Size(201, 22)
        Me.txtFeet.TabIndex = 9
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(20, 266)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(419, 22)
        Me.txtResult.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 396)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtFeet)
        Me.Controls.Add(Me.txtFiberCost)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.lblFeet)
        Me.Controls.Add(Me.lblFiberCost)
        Me.Controls.Add(Me.lblCompanyNae)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnResult)
        Me.MaximumSize = New System.Drawing.Size(555, 459)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fiber Optic Cost"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnResult As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblCompanyNae As Label
    Friend WithEvents lblFiberCost As Label
    Friend WithEvents lblFeet As Label
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents txtFiberCost As TextBox
    Friend WithEvents txtFeet As TextBox
    Friend WithEvents txtResult As TextBox
End Class
