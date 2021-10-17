<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Room
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.room_capacity = New System.Windows.Forms.TextBox()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.room_no = New System.Windows.Forms.TextBox()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.lblRegistration = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dataRoom = New System.Windows.Forms.DataGridView()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNxt = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.RoomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapacityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblroomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClassscheduleDataSet = New Class_Scheduler.classscheduleDataSet()
        Me.TblroomTableAdapter = New Class_Scheduler.classscheduleDataSetTableAdapters.tblroomTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.dataRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblroomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassscheduleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Capacity :"
        '
        'room_capacity
        '
        Me.room_capacity.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.room_capacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.room_capacity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblroomBindingSource, "Capacity", True))
        Me.room_capacity.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.room_capacity.Location = New System.Drawing.Point(33, 172)
        Me.room_capacity.Name = "room_capacity"
        Me.room_capacity.Size = New System.Drawing.Size(244, 28)
        Me.room_capacity.TabIndex = 14
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoom.Location = New System.Drawing.Point(29, 64)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(78, 20)
        Me.lblRoom.TabIndex = 13
        Me.lblRoom.Text = "Room No :"
        '
        'room_no
        '
        Me.room_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.room_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.room_no.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblroomBindingSource, "Room", True))
        Me.room_no.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.room_no.Location = New System.Drawing.Point(33, 87)
        Me.room_no.Name = "room_no"
        Me.room_no.Size = New System.Drawing.Size(244, 28)
        Me.room_no.TabIndex = 11
        '
        'btn_new
        '
        Me.btn_new.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btn_new.FlatAppearance.BorderSize = 0
        Me.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_new.Location = New System.Drawing.Point(33, 284)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(109, 38)
        Me.btn_new.TabIndex = 12
        Me.btn_new.Text = "NEW"
        Me.btn_new.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.lblRegistration)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(771, 35)
        Me.Panel1.TabIndex = 10
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = Global.Class_Scheduler.My.Resources.Resources.CloseWindow
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.Location = New System.Drawing.Point(738, 3)
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
        Me.lblRegistration.Location = New System.Drawing.Point(333, 3)
        Me.lblRegistration.Name = "lblRegistration"
        Me.lblRegistration.Size = New System.Drawing.Size(79, 31)
        Me.lblRegistration.TabIndex = 0
        Me.lblRegistration.Text = "ROOM"
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_add.Location = New System.Drawing.Point(168, 284)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(109, 38)
        Me.btn_add.TabIndex = 16
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
        Me.btn_update.Location = New System.Drawing.Point(33, 348)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(109, 38)
        Me.btn_update.TabIndex = 17
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
        Me.btnDelete.Location = New System.Drawing.Point(168, 349)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(109, 38)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'dataRoom
        '
        Me.dataRoom.AutoGenerateColumns = False
        Me.dataRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataRoom.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoomDataGridViewTextBoxColumn, Me.CapacityDataGridViewTextBoxColumn})
        Me.dataRoom.DataSource = Me.TblroomBindingSource
        Me.dataRoom.Location = New System.Drawing.Point(309, 115)
        Me.dataRoom.Name = "dataRoom"
        Me.dataRoom.Size = New System.Drawing.Size(452, 286)
        Me.dataRoom.TabIndex = 19
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.Teal
        Me.btnPrev.FlatAppearance.BorderSize = 0
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrev.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPrev.Location = New System.Drawing.Point(309, 71)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(62, 38)
        Me.btnPrev.TabIndex = 20
        Me.btnPrev.Text = "Prev"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'btnNxt
        '
        Me.btnNxt.BackColor = System.Drawing.Color.Teal
        Me.btnNxt.FlatAppearance.BorderSize = 0
        Me.btnNxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNxt.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNxt.Location = New System.Drawing.Point(377, 71)
        Me.btnNxt.Name = "btnNxt"
        Me.btnNxt.Size = New System.Drawing.Size(62, 38)
        Me.btnNxt.TabIndex = 21
        Me.btnNxt.Text = "Next"
        Me.btnNxt.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(445, 78)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(248, 28)
        Me.txtSearch.TabIndex = 22
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Teal
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPrint.Location = New System.Drawing.Point(699, 71)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(62, 38)
        Me.btnPrint.TabIndex = 24
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'RoomDataGridViewTextBoxColumn
        '
        Me.RoomDataGridViewTextBoxColumn.DataPropertyName = "Room"
        Me.RoomDataGridViewTextBoxColumn.HeaderText = "Room"
        Me.RoomDataGridViewTextBoxColumn.Name = "RoomDataGridViewTextBoxColumn"
        '
        'CapacityDataGridViewTextBoxColumn
        '
        Me.CapacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity"
        Me.CapacityDataGridViewTextBoxColumn.HeaderText = "Capacity"
        Me.CapacityDataGridViewTextBoxColumn.Name = "CapacityDataGridViewTextBoxColumn"
        '
        'TblroomBindingSource
        '
        Me.TblroomBindingSource.DataMember = "tblroom"
        Me.TblroomBindingSource.DataSource = Me.ClassscheduleDataSet
        '
        'ClassscheduleDataSet
        '
        Me.ClassscheduleDataSet.DataSetName = "classscheduleDataSet"
        Me.ClassscheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblroomTableAdapter
        '
        Me.TblroomTableAdapter.ClearBeforeFill = True
        '
        'Room
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 424)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnNxt)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.dataRoom)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.room_capacity)
        Me.Controls.Add(Me.lblRoom)
        Me.Controls.Add(Me.room_no)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Room"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dataRoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblroomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassscheduleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents room_capacity As System.Windows.Forms.TextBox
    Friend WithEvents lblRoom As System.Windows.Forms.Label
    Friend WithEvents room_no As System.Windows.Forms.TextBox
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblRegistration As System.Windows.Forms.Label
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents dataRoom As System.Windows.Forms.DataGridView
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnNxt As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents ClassscheduleDataSet As Class_Scheduler.classscheduleDataSet
    Friend WithEvents TblroomBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblroomTableAdapter As Class_Scheduler.classscheduleDataSetTableAdapters.tblroomTableAdapter
    Friend WithEvents RoomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CapacityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
