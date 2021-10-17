<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgot_password
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_answer = New System.Windows.Forms.TextBox()
        Me.TbluserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClassscheduleDataSet = New Class_Scheduler.classscheduleDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_question = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.lblRegistration = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.TbluserTableAdapter = New Class_Scheduler.classscheduleDataSetTableAdapters.tbluserTableAdapter()
        Me.TableAdapterManager1 = New Class_Scheduler.classscheduleDataSetTableAdapters.TableAdapterManager()
        CType(Me.TbluserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassscheduleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Answer :"
        '
        'txt_answer
        '
        Me.txt_answer.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txt_answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_answer.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_answer.Location = New System.Drawing.Point(176, 205)
        Me.txt_answer.Name = "txt_answer"
        Me.txt_answer.Size = New System.Drawing.Size(237, 28)
        Me.txt_answer.TabIndex = 24
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Secret Question :"
        '
        'txt_question
        '
        Me.txt_question.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txt_question.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_question.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_question.Location = New System.Drawing.Point(176, 149)
        Me.txt_question.Name = "txt_question"
        Me.txt_question.Size = New System.Drawing.Size(237, 28)
        Me.txt_question.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Username :"
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_username.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(176, 94)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(237, 28)
        Me.txt_username.TabIndex = 20
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRegister.Location = New System.Drawing.Point(134, 271)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(179, 38)
        Me.btnRegister.TabIndex = 19
        Me.btnRegister.Text = "CHECK"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'lblRegistration
        '
        Me.lblRegistration.AutoSize = True
        Me.lblRegistration.Font = New System.Drawing.Font("Source Sans Pro", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistration.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblRegistration.Location = New System.Drawing.Point(101, 3)
        Me.lblRegistration.Name = "lblRegistration"
        Me.lblRegistration.Size = New System.Drawing.Size(236, 31)
        Me.lblRegistration.TabIndex = 0
        Me.lblRegistration.Text = "FORGOT PASSWORD?"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.lblRegistration)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(459, 35)
        Me.Panel1.TabIndex = 18
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = Global.Class_Scheduler.My.Resources.Resources.CloseWindow
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.Location = New System.Drawing.Point(424, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 4
        Me.btnClose.UseSelectable = True
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'TbluserTableAdapter
        '
        Me.TbluserTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.open_subjectsTableAdapter = Nothing
        Me.TableAdapterManager1.schoolyrTableAdapter = Nothing
        Me.TableAdapterManager1.tblcourseTableAdapter = Nothing
        Me.TableAdapterManager1.tblinstructorTableAdapter = Nothing
        Me.TableAdapterManager1.tblresultsTableAdapter = Nothing
        Me.TableAdapterManager1.tblroomTableAdapter = Nothing
        Me.TableAdapterManager1.tblscheduleTableAdapter = Nothing
        Me.TableAdapterManager1.tblsubjectTableAdapter = Nothing
        Me.TableAdapterManager1.tbluserTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Class_Scheduler.classscheduleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'forgot_password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 345)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_answer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_question)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "forgot_password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "forgot_password"
        CType(Me.TbluserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassscheduleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_answer As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_question As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents lblRegistration As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents TbluserTableAdapter As Class_Scheduler.classscheduleDataSetTableAdapters.tbluserTableAdapter
    Friend WithEvents TableAdapterManager1 As Class_Scheduler.classscheduleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClassscheduleDataSet As Class_Scheduler.classscheduleDataSet
    Friend WithEvents TbluserBindingSource As System.Windows.Forms.BindingSource
End Class
