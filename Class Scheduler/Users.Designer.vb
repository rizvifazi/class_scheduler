<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Me.components = New System.ComponentModel.Container()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.TbluserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClassscheduleDataSet = New Class_Scheduler.classscheduleDataSet()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_confirm_pass = New System.Windows.Forms.TextBox()
        Me.txt_question = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dataUser = New System.Windows.Forms.DataGridView()
        Me.NamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsertypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuestionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlUsers = New System.Windows.Forms.Panel()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.lblRegistration = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TbluserTableAdapter = New Class_Scheduler.classscheduleDataSetTableAdapters.tbluserTableAdapter()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        CType(Me.TbluserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassscheduleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUsers.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbluserBindingSource, "nam", True))
        Me.txt_name.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(149, 35)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(203, 28)
        Me.txt_name.TabIndex = 1
        '
        'TbluserBindingSource
        '
        Me.TbluserBindingSource.DataMember = "tbluser"
        Me.TbluserBindingSource.DataSource = Me.ClassscheduleDataSet
        '
        'ClassscheduleDataSet
        '
        Me.ClassscheduleDataSet.DataSetName = "classscheduleDataSet"
        Me.ClassscheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(19, 34)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(55, 20)
        Me.Label23.TabIndex = 20
        Me.Label23.Text = "Name :"
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_username.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbluserBindingSource, "password", True))
        Me.txt_username.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(149, 109)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_username.Size = New System.Drawing.Size(203, 28)
        Me.txt_username.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(19, 71)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(85, 20)
        Me.Label22.TabIndex = 22
        Me.Label22.Text = "Username :"
        '
        'txt_pass
        '
        Me.txt_pass.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pass.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbluserBindingSource, "answer", True))
        Me.txt_pass.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.Location = New System.Drawing.Point(149, 184)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_pass.Size = New System.Drawing.Size(203, 28)
        Me.txt_pass.TabIndex = 5
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(19, 105)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(81, 20)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "Password :"
        '
        'txt_confirm_pass
        '
        Me.txt_confirm_pass.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txt_confirm_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_confirm_pass.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbluserBindingSource, "username", True))
        Me.txt_confirm_pass.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confirm_pass.Location = New System.Drawing.Point(149, 71)
        Me.txt_confirm_pass.Name = "txt_confirm_pass"
        Me.txt_confirm_pass.Size = New System.Drawing.Size(203, 28)
        Me.txt_confirm_pass.TabIndex = 2
        '
        'txt_question
        '
        Me.txt_question.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txt_question.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_question.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbluserBindingSource, "question", True))
        Me.txt_question.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_question.Location = New System.Drawing.Point(149, 145)
        Me.txt_question.Name = "txt_question"
        Me.txt_question.Size = New System.Drawing.Size(203, 28)
        Me.txt_question.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(19, 148)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(124, 20)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "Secret Question :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(19, 186)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 20)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Answer :"
        '
        'btn_new
        '
        Me.btn_new.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btn_new.FlatAppearance.BorderSize = 0
        Me.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_new.Location = New System.Drawing.Point(58, 249)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(109, 38)
        Me.btn_new.TabIndex = 31
        Me.btn_new.Text = "NEW"
        Me.btn_new.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_add.Location = New System.Drawing.Point(193, 249)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(109, 38)
        Me.btn_add.TabIndex = 32
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btn_update.FlatAppearance.BorderSize = 0
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_update.Location = New System.Drawing.Point(58, 313)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(109, 38)
        Me.btn_update.TabIndex = 33
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDelete.Location = New System.Drawing.Point(193, 314)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(109, 38)
        Me.btnDelete.TabIndex = 34
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'dataUser
        '
        Me.dataUser.AutoGenerateColumns = False
        Me.dataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NamDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.UsertypeDataGridViewTextBoxColumn, Me.QuestionDataGridViewTextBoxColumn})
        Me.dataUser.DataSource = Me.TbluserBindingSource
        Me.dataUser.Location = New System.Drawing.Point(369, 18)
        Me.dataUser.Name = "dataUser"
        Me.dataUser.Size = New System.Drawing.Size(361, 344)
        Me.dataUser.TabIndex = 35
        '
        'NamDataGridViewTextBoxColumn
        '
        Me.NamDataGridViewTextBoxColumn.DataPropertyName = "nam"
        Me.NamDataGridViewTextBoxColumn.HeaderText = "nam"
        Me.NamDataGridViewTextBoxColumn.Name = "NamDataGridViewTextBoxColumn"
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'UsertypeDataGridViewTextBoxColumn
        '
        Me.UsertypeDataGridViewTextBoxColumn.DataPropertyName = "user_type"
        Me.UsertypeDataGridViewTextBoxColumn.HeaderText = "user_type"
        Me.UsertypeDataGridViewTextBoxColumn.Name = "UsertypeDataGridViewTextBoxColumn"
        '
        'QuestionDataGridViewTextBoxColumn
        '
        Me.QuestionDataGridViewTextBoxColumn.DataPropertyName = "question"
        Me.QuestionDataGridViewTextBoxColumn.HeaderText = "question"
        Me.QuestionDataGridViewTextBoxColumn.Name = "QuestionDataGridViewTextBoxColumn"
        '
        'pnlUsers
        '
        Me.pnlUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pnlUsers.Controls.Add(Me.dataUser)
        Me.pnlUsers.Controls.Add(Me.btnDelete)
        Me.pnlUsers.Controls.Add(Me.btn_update)
        Me.pnlUsers.Controls.Add(Me.btn_add)
        Me.pnlUsers.Controls.Add(Me.btn_new)
        Me.pnlUsers.Controls.Add(Me.Label18)
        Me.pnlUsers.Controls.Add(Me.Label19)
        Me.pnlUsers.Controls.Add(Me.txt_question)
        Me.pnlUsers.Controls.Add(Me.txt_confirm_pass)
        Me.pnlUsers.Controls.Add(Me.Label21)
        Me.pnlUsers.Controls.Add(Me.txt_pass)
        Me.pnlUsers.Controls.Add(Me.Label22)
        Me.pnlUsers.Controls.Add(Me.txt_username)
        Me.pnlUsers.Controls.Add(Me.Label23)
        Me.pnlUsers.Controls.Add(Me.txt_name)
        Me.pnlUsers.Location = New System.Drawing.Point(2, 34)
        Me.pnlUsers.Name = "pnlUsers"
        Me.pnlUsers.Size = New System.Drawing.Size(739, 376)
        Me.pnlUsers.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = Global.Class_Scheduler.My.Resources.Resources.CloseWindow
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.Location = New System.Drawing.Point(706, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 5
        Me.btnClose.UseSelectable = True
        '
        'lblRegistration
        '
        Me.lblRegistration.AutoSize = True
        Me.lblRegistration.Font = New System.Drawing.Font("Source Sans Pro", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistration.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblRegistration.Location = New System.Drawing.Point(314, 1)
        Me.lblRegistration.Name = "lblRegistration"
        Me.lblRegistration.Size = New System.Drawing.Size(84, 31)
        Me.lblRegistration.TabIndex = 0
        Me.lblRegistration.Text = "USERS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.lblRegistration)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(739, 35)
        Me.Panel1.TabIndex = 36
        '
        'TbluserTableAdapter
        '
        Me.TbluserTableAdapter.ClearBeforeFill = True
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 412)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlUsers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Users"
        CType(Me.TbluserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassscheduleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUsers.ResumeLayout(False)
        Me.pnlUsers.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_confirm_pass As System.Windows.Forms.TextBox
    Friend WithEvents txt_question As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents dataUser As System.Windows.Forms.DataGridView
    Friend WithEvents pnlUsers As System.Windows.Forms.Panel
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents lblRegistration As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ClassscheduleDataSet As Class_Scheduler.classscheduleDataSet
    Friend WithEvents TbluserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbluserTableAdapter As Class_Scheduler.classscheduleDataSetTableAdapters.tbluserTableAdapter
    Friend WithEvents NamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsertypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuestionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
