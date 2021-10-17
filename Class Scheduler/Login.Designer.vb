<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.pnlName = New System.Windows.Forms.Panel()
        Me.txtUsername = New MetroFramework.Controls.MetroTextBox()
        Me.picName = New System.Windows.Forms.PictureBox()
        Me.pnlPass = New System.Windows.Forms.Panel()
        Me.txtPass = New MetroFramework.Controls.MetroTextBox()
        Me.picPass = New System.Windows.Forms.PictureBox()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.checkRem = New System.Windows.Forms.CheckBox()
        Me.lblfgps = New System.Windows.Forms.Label()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.TbluserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClassscheduleDataSet = New Class_Scheduler.classscheduleDataSet()
        Me.TbluserTableAdapter = New Class_Scheduler.classscheduleDataSetTableAdapters.tbluserTableAdapter()
        Me.TableAdapterManager = New Class_Scheduler.classscheduleDataSetTableAdapters.TableAdapterManager()
        Me.pnlName.SuspendLayout()
        CType(Me.picName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPass.SuspendLayout()
        CType(Me.picPass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.TbluserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassscheduleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlName
        '
        Me.pnlName.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pnlName.Controls.Add(Me.txtUsername)
        Me.pnlName.Controls.Add(Me.picName)
        Me.pnlName.Location = New System.Drawing.Point(56, 63)
        Me.pnlName.Name = "pnlName"
        Me.pnlName.Size = New System.Drawing.Size(308, 40)
        Me.pnlName.TabIndex = 0
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        '
        '
        '
        Me.txtUsername.CustomButton.Image = Nothing
        Me.txtUsername.CustomButton.Location = New System.Drawing.Point(230, 2)
        Me.txtUsername.CustomButton.Name = ""
        Me.txtUsername.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUsername.CustomButton.TabIndex = 1
        Me.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUsername.CustomButton.UseSelectable = True
        Me.txtUsername.CustomButton.Visible = False
        Me.txtUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtUsername.Lines = New String(-1) {}
        Me.txtUsername.Location = New System.Drawing.Point(40, 0)
        Me.txtUsername.MaxLength = 32767
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PromptText = "username"
        Me.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.SelectionLength = 0
        Me.txtUsername.SelectionStart = 0
        Me.txtUsername.ShortcutsEnabled = True
        Me.txtUsername.Size = New System.Drawing.Size(268, 40)
        Me.txtUsername.TabIndex = 101
        Me.txtUsername.UseSelectable = True
        Me.txtUsername.WaterMark = "username"
        Me.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUsername.WaterMarkFont = New System.Drawing.Font("Source Sans Pro", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'picName
        '
        Me.picName.BackgroundImage = Global.Class_Scheduler.My.Resources.Resources.user1
        Me.picName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picName.Location = New System.Drawing.Point(0, 0)
        Me.picName.Name = "picName"
        Me.picName.Size = New System.Drawing.Size(43, 40)
        Me.picName.TabIndex = 1
        Me.picName.TabStop = False
        '
        'pnlPass
        '
        Me.pnlPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pnlPass.Controls.Add(Me.txtPass)
        Me.pnlPass.Controls.Add(Me.picPass)
        Me.pnlPass.Location = New System.Drawing.Point(54, 143)
        Me.pnlPass.Name = "pnlPass"
        Me.pnlPass.Size = New System.Drawing.Size(310, 40)
        Me.pnlPass.TabIndex = 1
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        '
        '
        '
        Me.txtPass.CustomButton.Image = Nothing
        Me.txtPass.CustomButton.Location = New System.Drawing.Point(230, 2)
        Me.txtPass.CustomButton.Name = ""
        Me.txtPass.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPass.CustomButton.TabIndex = 1
        Me.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPass.CustomButton.UseSelectable = True
        Me.txtPass.CustomButton.Visible = False
        Me.txtPass.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPass.Lines = New String(-1) {}
        Me.txtPass.Location = New System.Drawing.Point(42, 0)
        Me.txtPass.MaxLength = 32767
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPass.PromptText = "password"
        Me.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPass.SelectedText = ""
        Me.txtPass.SelectionLength = 0
        Me.txtPass.SelectionStart = 0
        Me.txtPass.ShortcutsEnabled = True
        Me.txtPass.Size = New System.Drawing.Size(268, 40)
        Me.txtPass.TabIndex = 102
        Me.txtPass.UseSelectable = True
        Me.txtPass.UseSystemPasswordChar = True
        Me.txtPass.WaterMark = "password"
        Me.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPass.WaterMarkFont = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'picPass
        '
        Me.picPass.BackgroundImage = Global.Class_Scheduler.My.Resources.Resources.password
        Me.picPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picPass.Location = New System.Drawing.Point(0, -1)
        Me.picPass.Name = "picPass"
        Me.picPass.Size = New System.Drawing.Size(45, 42)
        Me.picPass.TabIndex = 1
        Me.picPass.TabStop = False
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnl.Controls.Add(Me.lblLogin)
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(410, 35)
        Me.pnl.TabIndex = 2
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Source Sans Pro SemiBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblLogin.Location = New System.Drawing.Point(149, 3)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(121, 27)
        Me.lblLogin.TabIndex = 0
        Me.lblLogin.Text = "USER LOGIN"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogin.Location = New System.Drawing.Point(125, 236)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(179, 38)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(125, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 38)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'checkRem
        '
        Me.checkRem.AutoSize = True
        Me.checkRem.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkRem.Location = New System.Drawing.Point(54, 201)
        Me.checkRem.Name = "checkRem"
        Me.checkRem.Size = New System.Drawing.Size(100, 19)
        Me.checkRem.TabIndex = 5
        Me.checkRem.Text = "Remember Me"
        Me.checkRem.UseVisualStyleBackColor = True
        '
        'lblfgps
        '
        Me.lblfgps.AutoSize = True
        Me.lblfgps.Font = New System.Drawing.Font("Source Sans Pro Black", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfgps.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblfgps.Location = New System.Drawing.Point(231, 201)
        Me.lblfgps.Name = "lblfgps"
        Me.lblfgps.Size = New System.Drawing.Size(111, 17)
        Me.lblfgps.TabIndex = 6
        Me.lblfgps.Text = "Forget Password?"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.pnl
        Me.BunifuDragControl1.Vertical = True
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
        'TbluserTableAdapter
        '
        Me.TbluserTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.open_subjectsTableAdapter = Nothing
        Me.TableAdapterManager.schoolyrTableAdapter = Nothing
        Me.TableAdapterManager.tblcourseTableAdapter = Nothing
        Me.TableAdapterManager.tblinstructorTableAdapter = Nothing
        Me.TableAdapterManager.tblresultsTableAdapter = Nothing
        Me.TableAdapterManager.tblroomTableAdapter = Nothing
        Me.TableAdapterManager.tblscheduleTableAdapter = Nothing
        Me.TableAdapterManager.tblsubjectTableAdapter = Nothing
        Me.TableAdapterManager.tbluserTableAdapter = Me.TbluserTableAdapter
        Me.TableAdapterManager.UpdateOrder = Class_Scheduler.classscheduleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(408, 366)
        Me.Controls.Add(Me.lblfgps)
        Me.Controls.Add(Me.checkRem)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.pnlPass)
        Me.Controls.Add(Me.pnlName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.pnlName.ResumeLayout(False)
        CType(Me.picName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPass.ResumeLayout(False)
        CType(Me.picPass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        CType(Me.TbluserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassscheduleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlName As System.Windows.Forms.Panel
    Friend WithEvents picName As System.Windows.Forms.PictureBox
    Friend WithEvents picPass As System.Windows.Forms.PictureBox
    Friend WithEvents pnlPass As System.Windows.Forms.Panel
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents checkRem As System.Windows.Forms.CheckBox
    Friend WithEvents lblfgps As System.Windows.Forms.Label
    Friend WithEvents txtUsername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents ClassscheduleDataSet As Class_Scheduler.classscheduleDataSet
    Friend WithEvents TbluserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbluserTableAdapter As Class_Scheduler.classscheduleDataSetTableAdapters.tbluserTableAdapter
    Friend WithEvents TableAdapterManager As Class_Scheduler.classscheduleDataSetTableAdapters.TableAdapterManager
End Class
