<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistration
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
        Me.lblRegInfo = New System.Windows.Forms.Label()
        Me.lblRegName = New System.Windows.Forms.Label()
        Me.lblRegBirthday = New System.Windows.Forms.Label()
        Me.lblRegAge = New System.Windows.Forms.Label()
        Me.lblRegStatus = New System.Windows.Forms.Label()
        Me.lblRegTutor = New System.Windows.Forms.Label()
        Me.txtRegName = New System.Windows.Forms.TextBox()
        Me.DTPRegBirthday = New System.Windows.Forms.DateTimePicker()
        Me.cmboRegStatus = New System.Windows.Forms.ComboBox()
        Me.chkbxRegReading = New System.Windows.Forms.CheckBox()
        Me.chkbxRegAll = New System.Windows.Forms.CheckBox()
        Me.chkbxDesign = New System.Windows.Forms.CheckBox()
        Me.chkbxRegBusiness = New System.Windows.Forms.CheckBox()
        Me.chkbxRegComp = New System.Windows.Forms.CheckBox()
        Me.chkbxRegNSA = New System.Windows.Forms.CheckBox()
        Me.chkbxRegElectronics = New System.Windows.Forms.CheckBox()
        Me.rdoRegAge1729 = New System.Windows.Forms.RadioButton()
        Me.rdoRegAge3049 = New System.Windows.Forms.RadioButton()
        Me.rdoRegAge5069 = New System.Windows.Forms.RadioButton()
        Me.rdoRegAge7099 = New System.Windows.Forms.RadioButton()
        Me.btnRegSave = New System.Windows.Forms.Button()
        Me.btnRegClear = New System.Windows.Forms.Button()
        Me.btnRegExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRegInfo
        '
        Me.lblRegInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRegInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegInfo.Location = New System.Drawing.Point(150, 9)
        Me.lblRegInfo.Name = "lblRegInfo"
        Me.lblRegInfo.Size = New System.Drawing.Size(215, 54)
        Me.lblRegInfo.TabIndex = 0
        Me.lblRegInfo.Text = "Welcome to ITT Registration." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tell me a little about yourself..."
        '
        'lblRegName
        '
        Me.lblRegName.AutoSize = True
        Me.lblRegName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegName.Location = New System.Drawing.Point(81, 110)
        Me.lblRegName.Name = "lblRegName"
        Me.lblRegName.Size = New System.Drawing.Size(51, 17)
        Me.lblRegName.TabIndex = 1
        Me.lblRegName.Text = "NAME:"
        '
        'lblRegBirthday
        '
        Me.lblRegBirthday.AutoSize = True
        Me.lblRegBirthday.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegBirthday.Location = New System.Drawing.Point(90, 153)
        Me.lblRegBirthday.Name = "lblRegBirthday"
        Me.lblRegBirthday.Size = New System.Drawing.Size(42, 17)
        Me.lblRegBirthday.TabIndex = 2
        Me.lblRegBirthday.Text = "DOB:"
        '
        'lblRegAge
        '
        Me.lblRegAge.AutoSize = True
        Me.lblRegAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegAge.Location = New System.Drawing.Point(91, 199)
        Me.lblRegAge.Name = "lblRegAge"
        Me.lblRegAge.Size = New System.Drawing.Size(41, 17)
        Me.lblRegAge.TabIndex = 3
        Me.lblRegAge.Text = "AGE:"
        '
        'lblRegStatus
        '
        Me.lblRegStatus.AutoSize = True
        Me.lblRegStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegStatus.Location = New System.Drawing.Point(65, 260)
        Me.lblRegStatus.Name = "lblRegStatus"
        Me.lblRegStatus.Size = New System.Drawing.Size(67, 17)
        Me.lblRegStatus.TabIndex = 4
        Me.lblRegStatus.Text = "STATUS:"
        '
        'lblRegTutor
        '
        Me.lblRegTutor.AutoSize = True
        Me.lblRegTutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegTutor.Location = New System.Drawing.Point(14, 331)
        Me.lblRegTutor.Name = "lblRegTutor"
        Me.lblRegTutor.Size = New System.Drawing.Size(118, 17)
        Me.lblRegTutor.TabIndex = 5
        Me.lblRegTutor.Text = "TUTORING FOR:"
        '
        'txtRegName
        '
        Me.txtRegName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegName.Location = New System.Drawing.Point(138, 107)
        Me.txtRegName.Name = "txtRegName"
        Me.txtRegName.Size = New System.Drawing.Size(164, 23)
        Me.txtRegName.TabIndex = 6
        '
        'DTPRegBirthday
        '
        Me.DTPRegBirthday.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPRegBirthday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPRegBirthday.Location = New System.Drawing.Point(138, 153)
        Me.DTPRegBirthday.Name = "DTPRegBirthday"
        Me.DTPRegBirthday.Size = New System.Drawing.Size(164, 23)
        Me.DTPRegBirthday.TabIndex = 7
        '
        'cmboRegStatus
        '
        Me.cmboRegStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboRegStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboRegStatus.FormattingEnabled = True
        Me.cmboRegStatus.Items.AddRange(New Object() {"Single", "Partnered", "Married", "It's Complicated"})
        Me.cmboRegStatus.Location = New System.Drawing.Point(138, 260)
        Me.cmboRegStatus.Name = "cmboRegStatus"
        Me.cmboRegStatus.Size = New System.Drawing.Size(121, 24)
        Me.cmboRegStatus.TabIndex = 8
        '
        'chkbxRegReading
        '
        Me.chkbxRegReading.AutoSize = True
        Me.chkbxRegReading.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbxRegReading.Location = New System.Drawing.Point(138, 331)
        Me.chkbxRegReading.Name = "chkbxRegReading"
        Me.chkbxRegReading.Size = New System.Drawing.Size(80, 21)
        Me.chkbxRegReading.TabIndex = 9
        Me.chkbxRegReading.Text = "Reading"
        Me.chkbxRegReading.UseVisualStyleBackColor = True
        '
        'chkbxRegAll
        '
        Me.chkbxRegAll.AutoSize = True
        Me.chkbxRegAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbxRegAll.Location = New System.Drawing.Point(224, 385)
        Me.chkbxRegAll.Name = "chkbxRegAll"
        Me.chkbxRegAll.Size = New System.Drawing.Size(52, 21)
        Me.chkbxRegAll.TabIndex = 10
        Me.chkbxRegAll.Text = "ALL"
        Me.chkbxRegAll.UseVisualStyleBackColor = True
        '
        'chkbxDesign
        '
        Me.chkbxDesign.AutoSize = True
        Me.chkbxDesign.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbxDesign.Location = New System.Drawing.Point(334, 358)
        Me.chkbxDesign.Name = "chkbxDesign"
        Me.chkbxDesign.Size = New System.Drawing.Size(138, 21)
        Me.chkbxDesign.TabIndex = 11
        Me.chkbxDesign.Text = "Drafting && Design"
        Me.chkbxDesign.UseVisualStyleBackColor = True
        '
        'chkbxRegBusiness
        '
        Me.chkbxRegBusiness.AutoSize = True
        Me.chkbxRegBusiness.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbxRegBusiness.Location = New System.Drawing.Point(334, 330)
        Me.chkbxRegBusiness.Name = "chkbxRegBusiness"
        Me.chkbxRegBusiness.Size = New System.Drawing.Size(84, 21)
        Me.chkbxRegBusiness.TabIndex = 12
        Me.chkbxRegBusiness.Text = "Business"
        Me.chkbxRegBusiness.UseVisualStyleBackColor = True
        '
        'chkbxRegComp
        '
        Me.chkbxRegComp.AutoSize = True
        Me.chkbxRegComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbxRegComp.Location = New System.Drawing.Point(224, 331)
        Me.chkbxRegComp.Name = "chkbxRegComp"
        Me.chkbxRegComp.Size = New System.Drawing.Size(104, 21)
        Me.chkbxRegComp.TabIndex = 13
        Me.chkbxRegComp.Text = "Composition"
        Me.chkbxRegComp.UseVisualStyleBackColor = True
        '
        'chkbxRegNSA
        '
        Me.chkbxRegNSA.AutoSize = True
        Me.chkbxRegNSA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbxRegNSA.Location = New System.Drawing.Point(138, 358)
        Me.chkbxRegNSA.Name = "chkbxRegNSA"
        Me.chkbxRegNSA.Size = New System.Drawing.Size(55, 21)
        Me.chkbxRegNSA.TabIndex = 14
        Me.chkbxRegNSA.Text = "NSA"
        Me.chkbxRegNSA.UseVisualStyleBackColor = True
        '
        'chkbxRegElectronics
        '
        Me.chkbxRegElectronics.AutoSize = True
        Me.chkbxRegElectronics.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbxRegElectronics.Location = New System.Drawing.Point(224, 358)
        Me.chkbxRegElectronics.Name = "chkbxRegElectronics"
        Me.chkbxRegElectronics.Size = New System.Drawing.Size(96, 21)
        Me.chkbxRegElectronics.TabIndex = 15
        Me.chkbxRegElectronics.Text = "Electronics"
        Me.chkbxRegElectronics.UseVisualStyleBackColor = True
        '
        'rdoRegAge1729
        '
        Me.rdoRegAge1729.AutoSize = True
        Me.rdoRegAge1729.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoRegAge1729.Location = New System.Drawing.Point(138, 199)
        Me.rdoRegAge1729.Name = "rdoRegAge1729"
        Me.rdoRegAge1729.Size = New System.Drawing.Size(71, 21)
        Me.rdoRegAge1729.TabIndex = 16
        Me.rdoRegAge1729.TabStop = True
        Me.rdoRegAge1729.Text = "17 - 29"
        Me.rdoRegAge1729.UseVisualStyleBackColor = True
        '
        'rdoRegAge3049
        '
        Me.rdoRegAge3049.AutoSize = True
        Me.rdoRegAge3049.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoRegAge3049.Location = New System.Drawing.Point(138, 226)
        Me.rdoRegAge3049.Name = "rdoRegAge3049"
        Me.rdoRegAge3049.Size = New System.Drawing.Size(71, 21)
        Me.rdoRegAge3049.TabIndex = 17
        Me.rdoRegAge3049.TabStop = True
        Me.rdoRegAge3049.Text = "30 - 49"
        Me.rdoRegAge3049.UseVisualStyleBackColor = True
        '
        'rdoRegAge5069
        '
        Me.rdoRegAge5069.AutoSize = True
        Me.rdoRegAge5069.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoRegAge5069.Location = New System.Drawing.Point(256, 199)
        Me.rdoRegAge5069.Name = "rdoRegAge5069"
        Me.rdoRegAge5069.Size = New System.Drawing.Size(71, 21)
        Me.rdoRegAge5069.TabIndex = 18
        Me.rdoRegAge5069.TabStop = True
        Me.rdoRegAge5069.Text = "50 - 69"
        Me.rdoRegAge5069.UseVisualStyleBackColor = True
        '
        'rdoRegAge7099
        '
        Me.rdoRegAge7099.AutoSize = True
        Me.rdoRegAge7099.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoRegAge7099.Location = New System.Drawing.Point(256, 226)
        Me.rdoRegAge7099.Name = "rdoRegAge7099"
        Me.rdoRegAge7099.Size = New System.Drawing.Size(71, 21)
        Me.rdoRegAge7099.TabIndex = 19
        Me.rdoRegAge7099.TabStop = True
        Me.rdoRegAge7099.Text = "70 - 99"
        Me.rdoRegAge7099.UseVisualStyleBackColor = True
        '
        'btnRegSave
        '
        Me.btnRegSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegSave.Location = New System.Drawing.Point(409, 90)
        Me.btnRegSave.Name = "btnRegSave"
        Me.btnRegSave.Size = New System.Drawing.Size(80, 37)
        Me.btnRegSave.TabIndex = 20
        Me.btnRegSave.Text = "SAVE"
        Me.btnRegSave.UseVisualStyleBackColor = True
        '
        'btnRegClear
        '
        Me.btnRegClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegClear.Location = New System.Drawing.Point(409, 153)
        Me.btnRegClear.Name = "btnRegClear"
        Me.btnRegClear.Size = New System.Drawing.Size(80, 37)
        Me.btnRegClear.TabIndex = 21
        Me.btnRegClear.Text = "CLEAR"
        Me.btnRegClear.UseVisualStyleBackColor = True
        '
        'btnRegExit
        '
        Me.btnRegExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegExit.Location = New System.Drawing.Point(409, 218)
        Me.btnRegExit.Name = "btnRegExit"
        Me.btnRegExit.Size = New System.Drawing.Size(80, 37)
        Me.btnRegExit.TabIndex = 22
        Me.btnRegExit.Text = "EXIT"
        Me.btnRegExit.UseVisualStyleBackColor = True
        '
        'frmRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 418)
        Me.Controls.Add(Me.btnRegExit)
        Me.Controls.Add(Me.btnRegClear)
        Me.Controls.Add(Me.btnRegSave)
        Me.Controls.Add(Me.rdoRegAge7099)
        Me.Controls.Add(Me.rdoRegAge5069)
        Me.Controls.Add(Me.rdoRegAge3049)
        Me.Controls.Add(Me.rdoRegAge1729)
        Me.Controls.Add(Me.chkbxRegElectronics)
        Me.Controls.Add(Me.chkbxRegNSA)
        Me.Controls.Add(Me.chkbxRegComp)
        Me.Controls.Add(Me.chkbxRegBusiness)
        Me.Controls.Add(Me.chkbxDesign)
        Me.Controls.Add(Me.chkbxRegAll)
        Me.Controls.Add(Me.chkbxRegReading)
        Me.Controls.Add(Me.cmboRegStatus)
        Me.Controls.Add(Me.DTPRegBirthday)
        Me.Controls.Add(Me.txtRegName)
        Me.Controls.Add(Me.lblRegTutor)
        Me.Controls.Add(Me.lblRegStatus)
        Me.Controls.Add(Me.lblRegAge)
        Me.Controls.Add(Me.lblRegBirthday)
        Me.Controls.Add(Me.lblRegName)
        Me.Controls.Add(Me.lblRegInfo)
        Me.Name = "frmRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRegistration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRegInfo As Label
    Friend WithEvents lblRegName As Label
    Friend WithEvents lblRegBirthday As Label
    Friend WithEvents lblRegAge As Label
    Friend WithEvents lblRegStatus As Label
    Friend WithEvents lblRegTutor As Label
    Friend WithEvents txtRegName As TextBox
    Friend WithEvents DTPRegBirthday As DateTimePicker
    Friend WithEvents cmboRegStatus As ComboBox
    Friend WithEvents chkbxRegReading As CheckBox
    Friend WithEvents chkbxRegAll As CheckBox
    Friend WithEvents chkbxDesign As CheckBox
    Friend WithEvents chkbxRegBusiness As CheckBox
    Friend WithEvents chkbxRegComp As CheckBox
    Friend WithEvents chkbxRegNSA As CheckBox
    Friend WithEvents chkbxRegElectronics As CheckBox
    Friend WithEvents rdoRegAge1729 As RadioButton
    Friend WithEvents rdoRegAge3049 As RadioButton
    Friend WithEvents rdoRegAge5069 As RadioButton
    Friend WithEvents rdoRegAge7099 As RadioButton
    Friend WithEvents btnRegSave As Button
    Friend WithEvents btnRegClear As Button
    Friend WithEvents btnRegExit As Button
End Class
