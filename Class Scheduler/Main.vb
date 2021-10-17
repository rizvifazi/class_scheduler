

Public Class Main
    Dim n As Integer = 130


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picInstructor.Click
        Instructor.Show()
        Instructor.btn_add.Visible = False
        Instructor.btn_new.Visible = False
        Instructor.btn_update.Visible = False
        Instructor.btnBrowse.Visible = False
        Instructor.btnClear.Visible = False
        Instructor.btnDelete.Visible = False
        Instructor.txt_name.Enabled = False
        Instructor.txtAdd.Enabled = False
        Instructor.txtContact.Enabled = False
        Instructor.txtDep.Enabled = False
        Instructor.txtGrade.Enabled = False
        Instructor.txtLast.Enabled = False
        Instructor.comboGender.Enabled = False
        Instructor.btnPre.Location = New Point(85, 318)
        Instructor.btnNext.Location = New Point(160, 318)
        Instructor.txtSearch.Location = New Point(240, 322)
        Instructor.btnPrint.Location = New Point(500, 318)
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles picInstructor.MouseHover
        picInstructor.Width = 140
        picInstructor.Height = 140
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        btnHome.BackColor = pnlOnHome.BackColor
        btnSettings.BackColor = pnlLeftSide.BackColor
        btnUsers.BackColor = pnlLeftSide.BackColor
        btnAbout.BackColor = pnlLeftSide.BackColor
        btnStudents.BackColor = pnlLeftSide.BackColor

        pnlHome.Visible = True
        pnlSettings.Visible = False
        pnlAbout.Visible = False
        pnlUsers.Visible = False
        pnlStudents.Visible = False

    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        btnHome.BackColor = pnlLeftSide.BackColor
        btnSettings.BackColor = pnlOnSettings.BackColor
        btnUsers.BackColor = pnlLeftSide.BackColor
        btnAbout.BackColor = pnlLeftSide.BackColor
        btnStudents.BackColor = pnlLeftSide.BackColor

        pnlHome.Visible = False
        pnlSettings.Visible = True
        pnlAbout.Visible = False
        pnlUsers.Visible = False
        pnlStudents.Visible = False
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        btnHome.BackColor = pnlLeftSide.BackColor
        btnSettings.BackColor = pnlLeftSide.BackColor
        btnUsers.BackColor = pnlOnUser.BackColor
        btnAbout.BackColor = pnlLeftSide.BackColor
        btnStudents.BackColor = pnlLeftSide.BackColor

        pnlHome.Visible = False
        pnlSettings.Visible = False
        pnlAbout.Visible = False
        pnlUsers.Visible = True
        pnlStudents.Visible = False

    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        btnHome.BackColor = pnlLeftSide.BackColor
        btnSettings.BackColor = pnlLeftSide.BackColor
        btnUsers.BackColor = pnlLeftSide.BackColor
        btnAbout.BackColor = pnlOnAbout.BackColor
        btnStudents.BackColor = pnlLeftSide.BackColor

        pnlHome.Visible = False
        pnlSettings.Visible = False
        pnlAbout.Visible = True
        pnlUsers.Visible = False
        pnlStudents.Visible = False

    End Sub

    Private Sub picInstructor_MouseLeave(sender As Object, e As EventArgs) Handles picInstructor.MouseLeave
        picInstructor.Width = n
        picInstructor.Height = n
    End Sub

    Private Sub picCourse_Click(sender As Object, e As EventArgs) Handles picCourse.Click
        Course.Show()
        Course.btn_add.Visible = False
        Course.btn_new.Visible = False
        Course.btn_update.Visible = False
        Course.btnDelete.Visible = False
        Course.txtCourse.Enabled = False
        Course.txtDesc.Enabled = False
    End Sub

    Private Sub picCourse_MouseHover(sender As Object, e As EventArgs) Handles picCourse.MouseHover
        picCourse.Width = 140
        picCourse.Height = 140
    End Sub

    Private Sub picCourse_MouseLeave(sender As Object, e As EventArgs) Handles picCourse.MouseLeave
        picCourse.Width = n
        picCourse.Height = n
    End Sub


    Private Sub picRoom_MouseHover(sender As Object, e As EventArgs) Handles picRoom.MouseHover
        picRoom.Width = 140
        picRoom.Height = 140
    End Sub

    Private Sub picRoom_MouseLeave(sender As Object, e As EventArgs) Handles picRoom.MouseLeave
        picRoom.Width = n
        picRoom.Height = n
    End Sub

    Private Sub picSubject_Click(sender As Object, e As EventArgs) Handles picSubject.Click
        Subject.Show()
        Subject.btn_add.Visible = False
        Subject.btn_new.Visible = False
        Subject.btn_update.Visible = False
        Subject.btn_delete.Visible = False

    End Sub

    Private Sub picSubject_MouseHover(sender As Object, e As EventArgs) Handles picSubject.MouseHover
        picSubject.Width = 140
        picSubject.Height = 140
    End Sub

    Private Sub picSubject_MouseLeave(sender As Object, e As EventArgs) Handles picSubject.MouseLeave
        picSubject.Width = n
        picSubject.Height = n
    End Sub

    Private Sub picSchedule_Click(sender As Object, e As EventArgs) Handles picSchedule.Click
        Schedule.Show()
    End Sub

    Private Sub picSchedule_MouseHover(sender As Object, e As EventArgs) Handles picSchedule.MouseHover
        picSchedule.Width = 140
        picSchedule.Height = 140
    End Sub

    Private Sub picSchedule_MouseLeave(sender As Object, e As EventArgs) Handles picSchedule.MouseLeave
        picSchedule.Width = n
        picSchedule.Height = n
    End Sub

    Private Sub picPrint_Click(sender As Object, e As EventArgs) Handles picPrint.Click
        Results.Show()
        Results.btnGrade.Visible = False
        Results.btnCalc.Visible = False
        Results.btn_new.Visible = False
        Results.btn_add.Visible = False
        Results.btn_update.Visible = False
        Results.btn_delete.Visible = False

    End Sub

    Private Sub picPrint_MouseHover(sender As Object, e As EventArgs) Handles picPrint.MouseHover
        picPrint.Width = 140
        picPrint.Height = 140
    End Sub

    Private Sub picPrint_MouseLeave(sender As Object, e As EventArgs) Handles picPrint.MouseLeave
        picPrint.Width = n
        picPrint.Height = n
    End Sub

  
    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblSclyr.Click
        schoolyr.Show()
    End Sub

 
    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        btnHome.BackColor = pnlLeftSide.BackColor
        btnSettings.BackColor = pnlLeftSide.BackColor
        btnUsers.BackColor = pnlLeftSide.BackColor
        btnAbout.BackColor = pnlLeftSide.BackColor
        btnStudents.BackColor = pnlOnSettings.BackColor

        pnlHome.Visible = False
        pnlSettings.Visible = False
        pnlAbout.Visible = False
        pnlUsers.Visible = False
        pnlStudents.Visible = True
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Select Case MsgBox("Do you really want to Exit ?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                End
            Case MsgBoxResult.No

        End Select

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub MetroButton1_Click_1(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub picRoom_Click(sender As Object, e As EventArgs) Handles picRoom.Click
        Room.Show()
        Room.btn_add.Visible = False
        Room.btn_new.Visible = False
        Room.btn_update.Visible = False
        Room.btnDelete.Visible = False
        Room.room_capacity.Enabled = False
        Room.room_no.Enabled = False
    End Sub

    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles lblSclyr.MouseHover
        lblSclyr.ForeColor = Color.DarkBlue
    End Sub

    Private Sub lblSclyr_MouseLeave(sender As Object, e As EventArgs) Handles lblSclyr.MouseLeave
        lblSclyr.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub lblIns_Click(sender As Object, e As EventArgs) Handles lblIns.Click
        Instructor.Show()
    End Sub

    Private Sub lblIns_MouseHover(sender As Object, e As EventArgs) Handles lblIns.MouseHover
        lblIns.ForeColor = Color.DarkBlue
    End Sub

    Private Sub lblIns_MouseLeave(sender As Object, e As EventArgs) Handles lblIns.MouseLeave
        lblIns.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub lblCrs_Click(sender As Object, e As EventArgs) Handles lblCrs.Click
        Course.Show()
    End Sub

    Private Sub lblCrs_MouseHover(sender As Object, e As EventArgs) Handles lblCrs.MouseHover
        lblCrs.ForeColor = Color.DarkBlue
    End Sub

    Private Sub lblCrs_MouseLeave(sender As Object, e As EventArgs) Handles lblCrs.MouseLeave
        lblCrs.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub lblRm_Click(sender As Object, e As EventArgs) Handles lblRm.Click
       
        Room.Show()

    End Sub

    Private Sub lblRm_MouseHover(sender As Object, e As EventArgs) Handles lblRm.MouseHover
        lblRm.ForeColor = Color.DarkBlue
    End Sub

   
    Private Sub lblRm_MouseLeave(sender As Object, e As EventArgs) Handles lblRm.MouseLeave
        lblRm.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub lblSbjt_Click(sender As Object, e As EventArgs) Handles lblSbjt.Click
        Subject.Show()
    End Sub

    Private Sub lblSbjt_MouseHover(sender As Object, e As EventArgs) Handles lblSbjt.MouseHover
        lblSbjt.ForeColor = Color.DarkBlue
    End Sub

    Private Sub lblSbjt_MouseLeave(sender As Object, e As EventArgs) Handles lblSbjt.MouseLeave
        lblSbjt.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub lblOsbjt_Click(sender As Object, e As EventArgs) Handles lblOsbjt.Click
        Open_Subjects.Show()
    End Sub

    Private Sub lblOsbjt_MouseHover(sender As Object, e As EventArgs) Handles lblOsbjt.MouseHover
        lblOsbjt.ForeColor = Color.DarkBlue
    End Sub

    Private Sub lblOsbjt_MouseLeave(sender As Object, e As EventArgs) Handles lblOsbjt.MouseLeave
        lblOsbjt.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub lblScd_Click(sender As Object, e As EventArgs) Handles lblScd.Click
        Schedule.Show()
    End Sub

    Private Sub lblScd_MouseHover(sender As Object, e As EventArgs) Handles lblScd.MouseHover
        lblScd.ForeColor = Color.DarkBlue
    End Sub

    Private Sub lblScd_MouseLeave(sender As Object, e As EventArgs) Handles lblScd.MouseLeave
        lblScd.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub lblUsr_Click(sender As Object, e As EventArgs) Handles lblUsr.Click
        Users.Show()
    End Sub

    Private Sub lblUsr_MouseHover(sender As Object, e As EventArgs) Handles lblUsr.MouseHover
        lblUsr.ForeColor = Color.DarkBlue
    End Sub

    Private Sub lblUsr_MouseLeave(sender As Object, e As EventArgs) Handles lblUsr.MouseLeave
        lblUsr.ForeColor = Color.DodgerBlue
    End Sub

    

    
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClassscheduleDataSet.tblsubject' table. You can move, or remove it, as needed.
        Me.TblsubjectTableAdapter.Fill(Me.ClassscheduleDataSet.tblsubject)
        'TODO: This line of code loads data into the 'ClassscheduleDataSet.schoolyr' table. You can move, or remove it, as needed.
        Me.SchoolyrTableAdapter.Fill(Me.ClassscheduleDataSet.schoolyr)
        'TODO: This line of code loads data into the 'ClassscheduleDataSet.tbluser' table. You can move, or remove it, as needed.
        Me.TbluserTableAdapter.Fill(Me.ClassscheduleDataSet.tbluser)
        dataUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        TbluserBindingSource.MovePrevious()
    End Sub

    Private Sub btnNxt_Click(sender As Object, e As EventArgs) Handles btnNxt.Click
        TbluserBindingSource.MoveNext()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        TbluserTableAdapter.searchUser(ClassscheduleDataSet.tbluser, txtSearch.Text + "%", txtSearch.Text + "%")
    End Sub

    Private Sub pnlHome_Paint(sender As Object, e As PaintEventArgs) Handles pnlHome.Paint
        txt_confirm_pass.Enabled = False
        txt_name.Enabled = False
        txt_pass.Enabled = False
        txt_question.Enabled = False
        txt_username.Enabled = False
    End Sub

    Private Sub lblstudent_Click(sender As Object, e As EventArgs) Handles lblStu.Click
        Results.Show()
    End Sub

    Private Sub lblstudent_MouseHover(sender As Object, e As EventArgs) Handles lblStu.MouseHover
        lblStu.ForeColor = Color.DarkBlue
    End Sub

    Private Sub lblStu_MouseLeave(sender As Object, e As EventArgs) Handles lblStu.MouseLeave
        lblStu.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub comboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboYear.SelectedIndexChanged
        If comboSem.SelectedIndex = -1 Then
        Else
            TblsubjectTableAdapter.SubjectFilterQuery(ClassscheduleDataSet.tblsubject, comboYear.Text, comboSem.Text)
        End If
    End Sub

    Private Sub comboSem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboSem.SelectedIndexChanged
        TblsubjectTableAdapter.SubjectFilterQuery(ClassscheduleDataSet.tblsubject, comboYear.Text, comboSem.Text)
    End Sub

    
    Private Sub btnPrintResults_Click(sender As Object, e As EventArgs) Handles btnPrintResults.Click
        If comboExam.SelectedIndex = -1 Then
            MsgBox("Please Select The Examination!!", MsgBoxStyle.Exclamation)
        Else
            Dim fCr As New ResultPrint()
            fCr.Show()
        End If

    End Sub
End Class