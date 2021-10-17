<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subject
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
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.lblRegistration = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtSubjectcode = New System.Windows.Forms.TextBox()
        Me.TblsubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClassscheduleDataSet = New Class_Scheduler.classscheduleDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.comboSem = New MetroFramework.Controls.MetroComboBox()
        Me.comboYear = New MetroFramework.Controls.MetroComboBox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.txtDes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.checkCredit = New System.Windows.Forms.CheckBox()
        Me.comboCredit = New MetroFramework.Controls.MetroComboBox()
        Me.comboLab = New MetroFramework.Controls.MetroComboBox()
        Me.subjectData = New System.Windows.Forms.DataGridView()
        Me.SubjectcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemesterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuntityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabCreditsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NonCreditDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TblsubjectTableAdapter = New Class_Scheduler.classscheduleDataSetTableAdapters.tblsubjectTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.TblsubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassscheduleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.subjectData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_delete.Location = New System.Drawing.Point(198, 418)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(62, 32)
        Me.btn_delete.TabIndex = 64
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_new
        '
        Me.btn_new.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btn_new.FlatAppearance.BorderSize = 0
        Me.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_new.Location = New System.Drawing.Point(3, 418)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(58, 32)
        Me.btn_new.TabIndex = 61
        Me.btn_new.Text = "NEW"
        Me.btn_new.UseVisualStyleBackColor = False
        '
        'lblRegistration
        '
        Me.lblRegistration.AutoSize = True
        Me.lblRegistration.Font = New System.Drawing.Font("Source Sans Pro", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistration.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblRegistration.Location = New System.Drawing.Point(395, 0)
        Me.lblRegistration.Name = "lblRegistration"
        Me.lblRegistration.Size = New System.Drawing.Size(110, 31)
        Me.lblRegistration.TabIndex = 0
        Me.lblRegistration.Text = "SUBJECT"
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btn_update.FlatAppearance.BorderSize = 0
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_update.Location = New System.Drawing.Point(121, 418)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(71, 32)
        Me.btn_update.TabIndex = 63
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_add.Location = New System.Drawing.Point(67, 418)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(48, 32)
        Me.btn_add.TabIndex = 9
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Teal
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPrint.Location = New System.Drawing.Point(809, 60)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(103, 38)
        Me.btnPrint.TabIndex = 60
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(495, 67)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(206, 28)
        Me.txtSearch.TabIndex = 58
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Teal
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNext.Location = New System.Drawing.Point(401, 60)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(90, 38)
        Me.btnNext.TabIndex = 57
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.Teal
        Me.btnPrev.FlatAppearance.BorderSize = 0
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrev.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPrev.Location = New System.Drawing.Point(279, 60)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(116, 38)
        Me.btnPrev.TabIndex = 56
        Me.btnPrev.Text = "Prev"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Description :"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(22, 44)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(84, 20)
        Me.lblName.TabIndex = 48
        Me.lblName.Text = "Subject ID :"
        '
        'txtSubjectcode
        '
        Me.txtSubjectcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtSubjectcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubjectcode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblsubjectBindingSource, "Subject_code", True))
        Me.txtSubjectcode.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubjectcode.Location = New System.Drawing.Point(19, 67)
        Me.txtSubjectcode.Name = "txtSubjectcode"
        Me.txtSubjectcode.Size = New System.Drawing.Size(244, 28)
        Me.txtSubjectcode.TabIndex = 1
        '
        'TblsubjectBindingSource
        '
        Me.TblsubjectBindingSource.DataMember = "tblsubject"
        Me.TblsubjectBindingSource.DataSource = Me.ClassscheduleDataSet
        '
        'ClassscheduleDataSet
        '
        Me.ClassscheduleDataSet.DataSetName = "classscheduleDataSet"
        Me.ClassscheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.lblRegistration)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(924, 35)
        Me.Panel1.TabIndex = 46
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = Global.Class_Scheduler.My.Resources.Resources.CloseWindow
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.Location = New System.Drawing.Point(891, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 5
        Me.btnClose.UseSelectable = True
        '
        'comboSem
        '
        Me.comboSem.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.TblsubjectBindingSource, "Semester", True))
        Me.comboSem.FormattingEnabled = True
        Me.comboSem.ItemHeight = 23
        Me.comboSem.Items.AddRange(New Object() {"1", "2"})
        Me.comboSem.Location = New System.Drawing.Point(114, 321)
        Me.comboSem.Name = "comboSem"
        Me.comboSem.PromptText = "Select Semester"
        Me.comboSem.Size = New System.Drawing.Size(136, 29)
        Me.comboSem.TabIndex = 7
        Me.comboSem.UseSelectable = True
        '
        'comboYear
        '
        Me.comboYear.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.TblsubjectBindingSource, "Year", True))
        Me.comboYear.FormattingEnabled = True
        Me.comboYear.ItemHeight = 23
        Me.comboYear.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.comboYear.Location = New System.Drawing.Point(114, 275)
        Me.comboYear.Name = "comboYear"
        Me.comboYear.PromptText = "Select Year"
        Me.comboYear.Size = New System.Drawing.Size(136, 29)
        Me.comboYear.TabIndex = 6
        Me.comboYear.UseSelectable = True
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'txtDes
        '
        Me.txtDes.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtDes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblsubjectBindingSource, "Description", True))
        Me.txtDes.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDes.Location = New System.Drawing.Point(19, 122)
        Me.txtDes.Multiline = True
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(244, 45)
        Me.txtDes.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 369)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Quantity :"
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblsubjectBindingSource, "Quntity", True))
        Me.txtQuantity.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(114, 367)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(96, 28)
        Me.txtQuantity.TabIndex = 8
        '
        'checkCredit
        '
        Me.checkCredit.AutoSize = True
        Me.checkCredit.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.TblsubjectBindingSource, "Non-Credit", True))
        Me.checkCredit.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkCredit.Location = New System.Drawing.Point(78, 238)
        Me.checkCredit.Name = "checkCredit"
        Me.checkCredit.Size = New System.Drawing.Size(102, 24)
        Me.checkCredit.TabIndex = 5
        Me.checkCredit.Text = "Non-Credit"
        Me.checkCredit.UseVisualStyleBackColor = True
        '
        'comboCredit
        '
        Me.comboCredit.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.TblsubjectBindingSource, "Credits", True))
        Me.comboCredit.FormattingEnabled = True
        Me.comboCredit.ItemHeight = 23
        Me.comboCredit.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.comboCredit.Location = New System.Drawing.Point(19, 205)
        Me.comboCredit.Name = "comboCredit"
        Me.comboCredit.PromptText = "Credits"
        Me.comboCredit.Size = New System.Drawing.Size(87, 29)
        Me.comboCredit.TabIndex = 3
        Me.comboCredit.UseSelectable = True
        '
        'comboLab
        '
        Me.comboLab.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.TblsubjectBindingSource, "Lab Credits", True))
        Me.comboLab.FormattingEnabled = True
        Me.comboLab.ItemHeight = 23
        Me.comboLab.Items.AddRange(New Object() {"0", "1", "2"})
        Me.comboLab.Location = New System.Drawing.Point(121, 205)
        Me.comboLab.Name = "comboLab"
        Me.comboLab.PromptText = "Select Lab Credits"
        Me.comboLab.Size = New System.Drawing.Size(142, 29)
        Me.comboLab.TabIndex = 4
        Me.comboLab.UseSelectable = True
        '
        'subjectData
        '
        Me.subjectData.AutoGenerateColumns = False
        Me.subjectData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.subjectData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.subjectData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SubjectcodeDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn, Me.SemesterDataGridViewTextBoxColumn, Me.QuntityDataGridViewTextBoxColumn, Me.CreditsDataGridViewTextBoxColumn, Me.LabCreditsDataGridViewTextBoxColumn, Me.NonCreditDataGridViewCheckBoxColumn})
        Me.subjectData.DataSource = Me.TblsubjectBindingSource
        Me.subjectData.Location = New System.Drawing.Point(274, 113)
        Me.subjectData.Name = "subjectData"
        Me.subjectData.Size = New System.Drawing.Size(638, 337)
        Me.subjectData.TabIndex = 55
        '
        'SubjectcodeDataGridViewTextBoxColumn
        '
        Me.SubjectcodeDataGridViewTextBoxColumn.DataPropertyName = "Subject_code"
        Me.SubjectcodeDataGridViewTextBoxColumn.HeaderText = "Subject_code"
        Me.SubjectcodeDataGridViewTextBoxColumn.Name = "SubjectcodeDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "Year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "Year"
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        '
        'SemesterDataGridViewTextBoxColumn
        '
        Me.SemesterDataGridViewTextBoxColumn.DataPropertyName = "Semester"
        Me.SemesterDataGridViewTextBoxColumn.HeaderText = "Semester"
        Me.SemesterDataGridViewTextBoxColumn.Name = "SemesterDataGridViewTextBoxColumn"
        '
        'QuntityDataGridViewTextBoxColumn
        '
        Me.QuntityDataGridViewTextBoxColumn.DataPropertyName = "Quntity"
        Me.QuntityDataGridViewTextBoxColumn.HeaderText = "Quntity"
        Me.QuntityDataGridViewTextBoxColumn.Name = "QuntityDataGridViewTextBoxColumn"
        '
        'CreditsDataGridViewTextBoxColumn
        '
        Me.CreditsDataGridViewTextBoxColumn.DataPropertyName = "Credits"
        Me.CreditsDataGridViewTextBoxColumn.HeaderText = "Credits"
        Me.CreditsDataGridViewTextBoxColumn.Name = "CreditsDataGridViewTextBoxColumn"
        '
        'LabCreditsDataGridViewTextBoxColumn
        '
        Me.LabCreditsDataGridViewTextBoxColumn.DataPropertyName = "Lab Credits"
        Me.LabCreditsDataGridViewTextBoxColumn.HeaderText = "Lab Credits"
        Me.LabCreditsDataGridViewTextBoxColumn.Name = "LabCreditsDataGridViewTextBoxColumn"
        '
        'NonCreditDataGridViewCheckBoxColumn
        '
        Me.NonCreditDataGridViewCheckBoxColumn.DataPropertyName = "Non-Credit"
        Me.NonCreditDataGridViewCheckBoxColumn.HeaderText = "Non-Credit"
        Me.NonCreditDataGridViewCheckBoxColumn.Name = "NonCreditDataGridViewCheckBoxColumn"
        '
        'TblsubjectTableAdapter
        '
        Me.TblsubjectTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 326)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Semester :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 20)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Year :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Credits :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(127, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Lab Credits :"
        '
        'Subject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 458)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboLab)
        Me.Controls.Add(Me.comboCredit)
        Me.Controls.Add(Me.checkCredit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtDes)
        Me.Controls.Add(Me.comboYear)
        Me.Controls.Add(Me.comboSem)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.subjectData)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtSubjectcode)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Subject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subject"
        CType(Me.TblsubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassscheduleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.subjectData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents lblRegistration As System.Windows.Forms.Label
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtSubjectcode As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents comboSem As MetroFramework.Controls.MetroComboBox
    Friend WithEvents comboYear As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents txtDes As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents checkCredit As System.Windows.Forms.CheckBox
    Friend WithEvents comboCredit As MetroFramework.Controls.MetroComboBox
    Friend WithEvents comboLab As MetroFramework.Controls.MetroComboBox
    Friend WithEvents subjectData As System.Windows.Forms.DataGridView
    Friend WithEvents ClassscheduleDataSet As Class_Scheduler.classscheduleDataSet
    Friend WithEvents TblsubjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblsubjectTableAdapter As Class_Scheduler.classscheduleDataSetTableAdapters.tblsubjectTableAdapter
    Friend WithEvents SubjectcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SemesterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuntityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabCreditsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NonCreditDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
