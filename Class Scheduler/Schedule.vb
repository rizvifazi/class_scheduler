Public Class Schedule
    Dim lec As String = "None"
    Dim sbj As String = "None"
    Dim rm As String = "None"
    Dim col As Color = Color.White
    Dim cr As Integer = 0
    Dim i As Integer = 0

    Dim templec As String
    Dim tempsub As String
    Dim temprm As String
    Dim tempcol As Color

    'Dim BtnArray1(4) As Bunifu.Framework.UI.BunifuFlatButton


    'Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    For j = 1 To 100
    '        Dim btns() As Bunifu.Framework.UI.BunifuFlatButton = Bunifu.Find("b" & i, True)
    '        Dim bts As Bunifu.Framework.UI.BunifuFlatButton
    '        If btns IsNot Nothing Then
    '            bts = btns(0)
    '            bts.Text = i - 1
    '            AddHandler btns(i).Click, AddressOf ClickHandler
    '        End If
    '    Next
    'BtnArray1(0) = b1
    'BtnArray1(1) = b2
    'BtnArray1(2) = b3
    'BtnArray1(3) = b4
    'For i As Integer = 0 To BtnArray1.Length - 1
    '    'BtnArray1(i) = New Bunifu.Framework.UI.BunifuFlatButton()
    '    AddHandler BtnArray1(i).Click, AddressOf ClickHandler
    'Next
    'End Sub

    'Public Sub ClickHandler(ByVal sender As Object, ByVal e As System.EventArgs)

    '    'MsgBox("I am button #" & CType(sender, Button).Text)
    '    'BtnArray1(i).Text = CStr(i)
    '    CType(sender, Bunifu.Framework.UI.BunifuFlatButton).Normalcolor = col
    '    CType(sender, Bunifu.Framework.UI.BunifuFlatButton).OnHovercolor = col
    '    CType(sender, Bunifu.Framework.UI.BunifuFlatButton).BackColor = col
    '   CType(sender, Bunifu.Framework.UI.BunifuFlatButton).Activecolor = col




    '  MsgBox("Slot Has been Assigned Successfully!!", MsgBoxStyle.Information)
    ' End Sub

    'Private NRow As Integer = 8
    'Private NCol As Integer = 6
    'Private BtnArray((NRow + 1) * (NCol + 1) - 1) As Bunifu.Framework.UI.BunifuFlatButton
    'Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    TableLayoutPanel1.Size = New Size(650, 446)
    '    For i As Integer = 0 To BtnArray.Length - 1
    '        BtnArray(i) = New Bunifu.Framework.UI.BunifuFlatButton()
    '        BtnArray(i).BackColor = Color.LightGray
    '        BtnArray(i).BorderRadius = 7
    '        BtnArray(i).Activecolor = Color.Gainsboro
    '        BtnArray(i).Normalcolor = Color.LightGray
    '        BtnArray(i).OnHovercolor = Color.Azure
    '        BtnArray(i).OnHoverTextColor = Color.Azure
    '        BtnArray(i).BackgroundImage = Nothing
    '        BtnArray(i).Iconimage = Nothing
    '        BtnArray(i).Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
    '        BtnArray(i).Text = ""
    '        TableLayoutPanel1.Controls.Add(BtnArray(i), i Mod (NCol + 1), i \ (NCol + 1))

    '        AddHandler BtnArray(i).Click, AddressOf ClickHandler
    '    Next
    'End Sub
    'Public Sub ClickHandler(ByVal sender As Object, ByVal e As System.EventArgs)

    '    ' MsgBox("I am button #" & CType(sender, Button).Text)
    '    'BtnArray(i).Text = CStr(i)
    '    CType(sender, Bunifu.Framework.UI.BunifuFlatButton).Normalcolor = col
    '    CType(sender, Bunifu.Framework.UI.BunifuFlatButton).OnHovercolor = col
    '    CType(sender, Bunifu.Framework.UI.BunifuFlatButton).BackColor = col
    '    CType(sender, Bunifu.Framework.UI.BunifuFlatButton).Activecolor = col




    '    MsgBox("Slot Has been Assigned Successfully!!", MsgBoxStyle.Information)
    'End Sub

    'Dim lblsub() As Label = {lblsub1, lblsub2, lblsub3, lblsub4, lblsub5}
    'Dim lbllec() As Label = {lbllec1, lbllec2, lbllec3, lbllec4, lbllec5}
    'Dim lblrm() As Label = {lblrm1, lblrm2, lblrm3, lblrm4, lblrm5}
    'Dim bttn() As Bunifu.Framework.UI.BunifuFlatButton = {BunifuFlatButton1, BunifuFlatButton2, BunifuFlatButton3}
    'Dim btn(4) As Button


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub myHandler(ByVal sender As Object, ByVal e As System.EventArgs)
        MessageBox.Show("Handler added successfully!")

    End Sub
    Private Sub Schedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClassscheduleDataSet.tblroom' table. You can move, or remove it, as needed.
        Me.TblroomTableAdapter.Fill(Me.ClassscheduleDataSet.tblroom)
        'TODO: This line of code loads data into the 'ClassscheduleDataSet.tblinstructor' table. You can move, or remove it, as needed.
        Me.TblinstructorTableAdapter.Fill(Me.ClassscheduleDataSet.tblinstructor)
        'TODO: This line of code loads data into the 'ClassscheduleDataSet.tblsubject' table. You can move, or remove it, as needed.
        Me.TblsubjectTableAdapter.Fill(Me.ClassscheduleDataSet.tblsubject)

        'btn(0) = Button1
        'btn(1) = Button2
        'btn(2) = Button3
        'btn(3) = Button4
        'btn(4) = Button5
        'GenerateButtons(10)
        ' Declare a new button variable (hence the keyword 'New')


        'Dim intLoop As Integer


        'For intLoop = 0 To 4

        '    Dim newbutton As New Button 'put it in the loop so you create a new button each time
        '    newbutton.Text = "New Button"
        '    newbutton.Top = 30 + (0 * intLoop)
        '    newbutton.Left = 50 + (80 * intLoop)
        '    newbutton.Name = "box" & intLoop.ToString
        '    tab2.Controls.Add(newbutton)
        '    AddHandler newbutton.Click, AddressOf myHandler
        'Next
    End Sub



    Private Sub lblColor_Click(sender As Object, e As EventArgs) Handles lblColor.Click
        ColorDialog1.ShowDialog()
        lblColor.BackColor = ColorDialog1.Color
    End Sub

    Private Sub comboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboYear.SelectedIndexChanged
        If comboYear.SelectedItem = 1 Then
            metroTab.SelectTab(tab1)
        ElseIf comboYear.SelectedItem = 2 Then
            metroTab.SelectTab(tab2)
        ElseIf comboYear.SelectedItem = 3 Then
            metroTab.SelectTab(tab3)
        ElseIf comboYear.SelectedItem = 4 Then
            metroTab.SelectTab(tab4)
        End If

        If comboSem.SelectedIndex = -1 Then
        Else
            TblsubjectTableAdapter.SubjectFilterQuery(ClassscheduleDataSet.tblsubject, comboYear.Text, comboSem.Text)

        End If
    End Sub

    Private Sub btnAss_Click(sender As Object, e As EventArgs) Handles btnAss.Click
        If Val(hallCap.Text) < Val(txtQn.Text) Then
            MsgBox("Lecturer Hall is not enough for the Subject", MsgBoxStyle.Exclamation)
        Else
            sbj = comboSub.Text
            lec = comboLec.Text
            rm = comboHall.Text
            col = lblColor.BackColor

        End If
    End Sub

    Public Function clck()
        For i As Integer = 0 To 2

        Next
        Return clck()
    End Function

    'Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
    '    'Dim i As Integer
    '    lblsub1.Text = sbj
    '    lbllec1.Text = lec
    '    lblrm1.Text = rm
    '    BunifuFlatButton1.Normalcolor = col
    '    lblsub1.BackColor = col
    '    lbllec1.BackColor = col
    '    lblrm1.BackColor = col

    '    'For i = 0 To 4 Step 1
    '    '    lblsub(i).Text = sbj
    '    '    lbllec(i).Text = lec
    '    '    lblrm(i).Text = rm
    '    '    btn(i).BackColor = col
    '    '    lblsub(i).BackColor = col
    '    '    lbllec(i).BackColor = col
    '    '    lblrm(i).BackColor = col
    '    'Next
    'End Sub

    'Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs)

    '    lblsub2.Text = sbj
    '    lbllec2.Text = lec
    '    lblrm2.Text = rm
    '    BunifuFlatButton2.Normalcolor = col
    '    lblsub2.BackColor = col
    '    lbllec2.BackColor = col
    '    lblrm2.BackColor = col

    'End Sub



    'Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs)

    '    lblsub3.Text = sbj
    '    lbllec3.Text = lec
    '    lblrm3.Text = rm
    '    BunifuFlatButton3.Normalcolor = col
    '    lblsub3.BackColor = col
    '    lbllec3.BackColor = col
    '    lblrm3.BackColor = col
    'End Sub

    'Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs)

    '    lblsub4.Text = sbj
    '    lbllec4.Text = lec
    '    lblrm4.Text = rm
    '    BunifuFlatButton4.Normalcolor = col
    '    lblsub4.BackColor = col
    '    lbllec4.BackColor = col
    '    lblrm4.BackColor = col
    'End Sub

    'Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs)

    '    lblsub5.Text = sbj
    '    lbllec5.Text = lec
    '    lblrm5.Text = rm
    '    BunifuFlatButton5.Normalcolor = col
    '    lblsub5.BackColor = col
    '    lbllec5.BackColor = col
    '    lblrm5.BackColor = col
    'End Sub

    Private Sub comboSem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboSem.SelectedIndexChanged
        TblsubjectTableAdapter.SubjectFilterQuery(ClassscheduleDataSet.tblsubject, comboYear.Text, comboSem.Text)
    End Sub

    'Private Sub BunifuFlatButton20_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton20.Click
    '    tempsub = lblsubj1.Text
    '    templec = lbllect1.Text
    '    temprm = lblrom1.Text
    '    tempcol = BunifuFlatButton20.Normalcolor

    '    lblsubj1.Text = sbj
    '    lbllect1.Text = lec
    '    lblrom1.Text = rm
    '    BunifuFlatButton20.Normalcolor = col
    '    lblsubj1.BackColor = col
    '    lbllect1.BackColor = col
    '    lblrom1.BackColor = col

    '    If lbllect1.Text = lbllec1.Text Then
    '        MsgBox("Lecturer is Busy in this time, Please select another slot", MsgBoxStyle.Exclamation)
    '        lblsubj1.Text = tempsub
    '        lbllect1.Text = templec
    '        lblrom1.Text = temprm
    '        BunifuFlatButton20.Normalcolor = tempcol
    '        lblsubj1.BackColor = tempcol
    '        lbllect1.BackColor = tempcol
    '        lblrom1.BackColor = tempcol
    '    ElseIf lblrom1.Text = lblrm1.Text Then
    '        MsgBox("Lecturer Hall is Busy in this time, Please select another slot", MsgBoxStyle.Exclamation)
    '        lblsubj1.Text = tempsub
    '        lbllect1.Text = templec
    '        lblrom1.Text = temprm
    '        BunifuFlatButton20.Normalcolor = tempcol
    '        lblsubj1.BackColor = tempcol
    '        lbllect1.BackColor = tempcol
    '        lblrom1.BackColor = tempcol
    '    Else
    '        MsgBox("The slot has been Assigned Successfully!!")
    '    End If

    'End Sub

    'Private Sub BunifuFlatButton19_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton19.Click
    '    tempsub = lblsubj2.Text
    '    templec = lbllect2.Text
    '    temprm = lblrom2.Text
    '    tempcol = BunifuFlatButton19.Normalcolor

    '    lblsubj2.Text = sbj
    '    lbllect2.Text = lec
    '    lblrom2.Text = rm
    '    BunifuFlatButton19.Normalcolor = col
    '    lblsubj2.BackColor = col
    '    lbllect2.BackColor = col
    '    lblrom2.BackColor = col

    '    If lbllect2.Text = lbllec1.Text Then
    '        MsgBox("Lecturer is Busy in this time, Please select another slot", MsgBoxStyle.Exclamation)
    '        lblsubj2.Text = tempsub
    '        lbllect2.Text = templec
    '        lblrom2.Text = temprm
    '        BunifuFlatButton19.Normalcolor = tempcol
    '        lblsubj2.BackColor = tempcol
    '        lbllect2.BackColor = tempcol
    '        lblrom2.BackColor = tempcol
    '    ElseIf lblrom2.Text = lblrm2.Text Then
    '        MsgBox("Lecturer Hall is Busy in this time, Please select another slot", MsgBoxStyle.Exclamation)
    '        lblsubj2.Text = tempsub
    '        lbllect2.Text = templec
    '        lblrom2.Text = temprm
    '        BunifuFlatButton19.Normalcolor = tempcol
    '        lblsubj2.BackColor = tempcol
    '        lbllect2.BackColor = tempcol
    '        lblrom2.BackColor = tempcol
    '    Else
    '        MsgBox("The slot has been Assigned Successfully!!")
    '    End If

    'End Sub

    'Private Sub GenerateButtons(ByVal totaldays As Integer)
    '    tab2.Controls.Clear()
    '    For i As Integer = 1 To totaldays
    '        ' Dim bttn As New Bunifu.Framework.UI.BunifuFlatButton

    '        Dim bttn As New FlowLayoutPanel

    '        bttn.Name = "bttn" & i
    '        bttn.Size = New Size(102, 43)
    '        bttn.BackColor = Color.Aqua
    '        '  tab1.Controls.Add(bttn)
    '        tab2.Controls.Add(bttn)

    '    Next
    'End Sub

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    '    ' Declare a new button variable (hence the keyword 'New')
    '    Dim intLoop As Integer


    '    For intLoop = 0 To 10

    '        Dim newbutton As New Button 'put it in the loop so you create a new button each time
    '        newbutton.Text = "New Button"
    '        newbutton.Top = 10 + (5 * intLoop)
    '        newbutton.Left = 25 + (1 * intLoop)
    '        newbutton.Name = "box" & intLoop.ToString
    '        tab1.Controls.Add(newbutton)
    '    Next
    'End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        tempsub = s1.Text
        templec = l1.Text
        temprm = h1.Text
        tempcol = b1.Normalcolor

        s1.Text = sbj
        l1.Text = lec
        h1.Text = rm
        b1.Normalcolor = col
        b1.OnHovercolor = col
        b1.BackColor = col
        b1.Activecolor = col

        s1.BackColor = col
        l1.BackColor = col
        h1.BackColor = col

        If l1.Text = lc1.Text Or l1.Text = le1.Text Or l1.Text = lt1.Text Then
            MsgBox("Lecturer is Busy in this time, Please select another slot", MsgBoxStyle.Exclamation)
            s1.Text = tempsub
            l1.Text = templec
            h1.Text = temprm
            b1.Normalcolor = tempcol
            b1.OnHovercolor = tempcol
            b1.BackColor = tempcol
            b1.Activecolor = tempcol
            s1.BackColor = tempcol
            l1.BackColor = tempcol
            h1.BackColor = tempcol
        ElseIf h1.Text = lh1.Text Or h1.Text = hl1.Text Or h1.Text = ha1.Text Then
            MsgBox("Lecturer Hall is Busy in this time, Please select another slot", MsgBoxStyle.Exclamation)
            s1.Text = tempsub
            l1.Text = templec
            h1.Text = temprm
            b1.Normalcolor = tempcol
            s1.BackColor = tempcol
            l1.BackColor = tempcol
            h1.BackColor = tempcol
        Else
            MsgBox("The slot has been Assigned Successfully!!")
        End If
    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        tempsub = s2.Text
        templec = l2.Text
        temprm = h2.Text
        tempcol = b2.Normalcolor

        s2.Text = sbj
        l2.Text = lec
        h2.Text = rm
        b2.Normalcolor = col
        b2.OnHovercolor = col
        b2.BackColor = col
        b2.Activecolor = col

        s2.BackColor = col
        l2.BackColor = col
        h2.BackColor = col

        If l2.Text = lc2.Text Or l2.Text = le2.Text Or l2.Text = lt2.Text Then
            MsgBox("Lecturer is Busy in this time, Please select another slot", MsgBoxStyle.Exclamation)
            s2.Text = tempsub
            l2.Text = templec
            h2.Text = temprm
            b2.Normalcolor = tempcol
            b2.OnHovercolor = tempcol
            b2.BackColor = tempcol
            b2.Activecolor = tempcol
            s2.BackColor = tempcol
            l2.BackColor = tempcol
            h2.BackColor = tempcol
        ElseIf h2.Text = lh4.Text Or h2.Text = hl2.Text Or h2.Text = ha2.Text Then
            MsgBox("Lecturer Hall is Busy in this time, Please select another slot", MsgBoxStyle.Exclamation)
            s2.Text = tempsub
            l2.Text = templec
            h2.Text = temprm
            b2.Normalcolor = tempcol
            s2.BackColor = tempcol
            l2.BackColor = tempcol
            h2.BackColor = tempcol
        Else
            MsgBox("The slot has been Assigned Successfully!!")
        End If
    End Sub


    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        tempsub = s3.Text
        templec = l3.Text
        temprm = h3.Text
        tempcol = b3.Normalcolor

        s3.Text = sbj
        l3.Text = lec
        h3.Text = rm
        b3.Normalcolor = col
        b3.OnHovercolor = col
        b3.BackColor = col
        b3.Activecolor = col

        s3.BackColor = col
        l3.BackColor = col
        h3.BackColor = col

        If l3.Text = lc4.Text Or l3.Text = le3.Text Or l3.Text = lt3.Text Then
            MsgBox("Lecturer is Busy in this time, Please select another slot", MsgBoxStyle.Exclamation)
            s3.Text = tempsub
            l3.Text = templec
            h3.Text = temprm
            b3.Normalcolor = tempcol
            b3.OnHovercolor = tempcol
            b3.BackColor = tempcol
            b3.Activecolor = tempcol
            s3.BackColor = tempcol
            l3.BackColor = tempcol
            h3.BackColor = tempcol
        ElseIf h3.Text = lh4.Text Or h3.Text = hl3.Text Or h3.Text = ha3.Text Then
            MsgBox("Lecturer Hall is Busy in this time, Please select another slot", MsgBoxStyle.Exclamation)
            s3.Text = tempsub
            l3.Text = templec
            h3.Text = temprm
            b3.Normalcolor = tempcol
            s3.BackColor = tempcol
            l3.BackColor = tempcol
            h3.BackColor = tempcol
        Else
            MsgBox("The slot has been Assigned Successfully!!")
        End If
    End Sub



    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        tempsub = s4.Text
        templec = l4.Text
        temprm = h4.Text
        tempcol = b4.Normalcolor

        s4.Text = sbj
        l4.Text = lec
        h4.Text = rm
        b4.Normalcolor = col
        b4.OnHovercolor = col
        b4.BackColor = col
        b4.Activecolor = col

        s4.BackColor = col
        l4.BackColor = col
        h4.BackColor = col

        If l4.Text = lc4.Text Or l4.Text = le4.Text Or l4.Text = lt4.Text Then
            MsgBox("Lecturer is Busy in this time, Please select another slot", MsgBoxStyle.Exclamation)
            s4.Text = tempsub
            l4.Text = templec
            h4.Text = temprm
            b4.Normalcolor = tempcol
            b4.OnHovercolor = tempcol
            b4.BackColor = tempcol
            b4.Activecolor = tempcol
            s4.BackColor = tempcol
            l4.BackColor = tempcol
            h4.BackColor = tempcol
        ElseIf h4.Text = lh4.Text Or h4.Text = hl4.Text Or h4.Text = ha4.Text Then
            MsgBox("Lecturer Hall is Busy in this time, Please select another slot", MsgBoxStyle.Exclamation)
            s4.Text = tempsub
            l4.Text = templec
            h4.Text = temprm
            b4.Normalcolor = tempcol
            s4.BackColor = tempcol
            l4.BackColor = tempcol
            h4.BackColor = tempcol
        Else
            MsgBox("The slot has been Assigned Successfully!!")
        End If
    End Sub

    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        tempsub = sb1.Text
        templec = lc1.Text
        temprm = lh1.Text
        tempcol = bt1.Normalcolor

        sb1.Text = sbj
        lc1.Text = lec
        lh1.Text = rm
        bt1.Normalcolor = col
        bt1.OnHovercolor = col
        bt1.BackColor = col
        bt1.Activecolor = col

        sb1.BackColor = col
        lc1.BackColor = col
        lh1.BackColor = col

        If lc1.Text = l1.Text Or lc1.Text = le1.Text Or lc1.Text = lt1.Text Then
            MsgBox("Lecturer is Busy in this time, Please select another slot", MsgBoxStyle.Exclamation)
            sb1.Text = tempsub
            lc1.Text = templec
            lh1.Text = temprm
            bt1.Normalcolor = tempcol
            bt1.OnHovercolor = tempcol
            bt1.BackColor = tempcol
            bt1.Activecolor = tempcol
            sb1.BackColor = tempcol
            lc1.BackColor = tempcol
            lh1.BackColor = tempcol
        ElseIf lh1.Text = h1.Text Or lh1.Text = hl1.Text Or lh1.Text = ha1.Text Then
            MsgBox("Lecturer Hall is Busy in this time, Please select another slot", MsgBoxStyle.Exclamation)
            sb1.Text = tempsub
            lc1.Text = templec
            lh1.Text = temprm
            bt1.Normalcolor = tempcol
            sb1.BackColor = tempcol
            lc1.BackColor = tempcol
            lh1.BackColor = tempcol
        Else
            MsgBox("The slot has been Assigned Successfully!!")
        End If
    End Sub

    Private Sub comboHall_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboHall.SelectedIndexChanged



        'TblroomTableAdapter.HallCap(ClassscheduleDataSet.tblroom, comboHall.Text)
    End Sub

    Private Sub bt2_Click(sender As Object, e As EventArgs) Handles bt2.Click
        tempsub = sb2.Text
        templec = lc2.Text
        temprm = lh2.Text
        tempcol = bt2.Normalcolor

        sb2.Text = sbj
        lc2.Text = lec
        lh2.Text = rm
        bt2.Normalcolor = col
        bt2.OnHovercolor = col
        bt2.BackColor = col
        bt2.Activecolor = col

        sb2.BackColor = col
        lc2.BackColor = col
        lh2.BackColor = col

        If lc2.Text = l2.Text Or lc2.Text = le2.Text Or lc2.Text = lt2.Text Then
            MsgBox("Lecturer is Busy in this time, Please select another slot", MsgBoxStyle.Exclamation)
            sb2.Text = tempsub
            lc2.Text = templec
            lh2.Text = temprm
            bt2.Normalcolor = tempcol
            bt2.OnHovercolor = tempcol
            bt2.BackColor = tempcol
            bt2.Activecolor = tempcol
            sb2.BackColor = tempcol
            lc2.BackColor = tempcol
            lh2.BackColor = tempcol
        ElseIf lh2.Text = h2.Text Or lh2.Text = hl2.Text Or lh2.Text = ha2.Text Then
            MsgBox("Lecturer Hall is Busy in this time, Please select another slot", MsgBoxStyle.Exclamation)
            sb2.Text = tempsub
            lc2.Text = templec
            lh2.Text = temprm
            bt2.Normalcolor = tempcol
            sb2.BackColor = tempcol
            lc2.BackColor = tempcol
            lh2.BackColor = tempcol
        Else
            MsgBox("The slot has been Assigned Successfully!!")
        End If
    End Sub

    Private Sub bt3_Click(sender As Object, e As EventArgs) Handles bt3.Click
        tempsub = sb3.Text
        templec = lc3.Text
        temprm = lh3.Text
        tempcol = bt3.Normalcolor

        sb3.Text = sbj
        lc3.Text = lec
        lh3.Text = rm
        bt3.Normalcolor = col
        bt3.OnHovercolor = col
        bt3.BackColor = col
        bt3.Activecolor = col

        sb3.BackColor = col
        lc3.BackColor = col
        lh3.BackColor = col

        If lc3.Text = l3.Text Or lc3.Text = le3.Text Or lc3.Text = lt3.Text Then
            MsgBox("Lecturer is Busy in this time, Please select another slot", MsgBoxStyle.Exclamation)
            sb3.Text = tempsub
            lc3.Text = templec
            lh3.Text = temprm
            bt3.Normalcolor = tempcol
            bt3.OnHovercolor = tempcol
            bt3.BackColor = tempcol
            bt3.Activecolor = tempcol
            sb3.BackColor = tempcol
            lc3.BackColor = tempcol
            lh3.BackColor = tempcol
        ElseIf lh3.Text = h3.Text Or lh3.Text = hl3.Text Or lh3.Text = ha3.Text Then
            MsgBox("Lecturer Hall is Busy in this time, Please select another slot", MsgBoxStyle.Exclamation)
            sb3.Text = tempsub
            lc3.Text = templec
            lh3.Text = temprm
            bt3.Normalcolor = tempcol
            sb3.BackColor = tempcol
            lc3.BackColor = tempcol
            lh3.BackColor = tempcol
        Else
            MsgBox("The slot has been Assigned Successfully!!")
        End If
    End Sub


    Private Sub bt4_Click(sender As Object, e As EventArgs) Handles bt4.Click
        tempsub = sb4.Text
        templec = lc4.Text
        temprm = lh4.Text
        tempcol = bt4.Normalcolor

        sb4.Text = sbj
        lc4.Text = lec
        lh4.Text = rm
        bt4.Normalcolor = col
        bt4.OnHovercolor = col
        bt4.BackColor = col
        bt4.Activecolor = col

        sb4.BackColor = col
        lc4.BackColor = col
        lh4.BackColor = col

        If lc4.Text = l4.Text Or lc4.Text = le4.Text Or lc4.Text = lt4.Text Then
            MsgBox("Lecturer is Busy in this time, Please select another slot", MsgBoxStyle.Exclamation)
            sb4.Text = tempsub
            lc4.Text = templec
            lh4.Text = temprm
            bt4.Normalcolor = tempcol
            bt4.OnHovercolor = tempcol
            bt4.BackColor = tempcol
            bt4.Activecolor = tempcol
            sb4.BackColor = tempcol
            lc4.BackColor = tempcol
            lh4.BackColor = tempcol
        ElseIf lh4.Text = h4.Text Or lh4.Text = hl4.Text Or lh4.Text = ha4.Text Then
            MsgBox("Lecturer Hall is Busy in this time, Please select another slot", MsgBoxStyle.Exclamation)
            sb4.Text = tempsub
            lc4.Text = templec
            lh4.Text = temprm
            bt4.Normalcolor = tempcol
            sb4.BackColor = tempcol
            lc4.BackColor = tempcol
            lh4.BackColor = tempcol
        Else
            MsgBox("The slot has been Assigned Successfully!!")
        End If
    End Sub

    Private Sub btnPrnt_Click(sender As Object, e As EventArgs) Handles btnPrnt.Click
        Scheduler.ShowDialog()
    End Sub
End Class