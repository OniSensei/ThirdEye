<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TheFace
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TheFace))
        Me.FormSkin1 = New ThirdEye.FormSkin()
        Me.statusTxt = New ThirdEye.FlatStatusBar()
        Me.FlatTabControl1 = New ThirdEye.FlatTabControl()
        Me.searchTab = New System.Windows.Forms.TabPage()
        Me.resultsBox2 = New ThirdEye.FlatGroupBox()
        Me.resultPb2 = New System.Windows.Forms.PictureBox()
        Me.resultCity2 = New ThirdEye.FlatLabel()
        Me.resultGender2 = New ThirdEye.FlatLabel()
        Me.resultAge2 = New ThirdEye.FlatLabel()
        Me.resultName2 = New ThirdEye.FlatLabel()
        Me.ViewDetailsBtn2 = New ThirdEye.FlatButton()
        Me.resultsBox1 = New ThirdEye.FlatGroupBox()
        Me.resultPb1 = New System.Windows.Forms.PictureBox()
        Me.resultCity1 = New ThirdEye.FlatLabel()
        Me.resultGender1 = New ThirdEye.FlatLabel()
        Me.resultAge1 = New ThirdEye.FlatLabel()
        Me.resultName1 = New ThirdEye.FlatLabel()
        Me.viewDetailsBtn1 = New ThirdEye.FlatButton()
        Me.resultsBox0 = New ThirdEye.FlatGroupBox()
        Me.resultPb0 = New System.Windows.Forms.PictureBox()
        Me.resultCity0 = New ThirdEye.FlatLabel()
        Me.resultGender0 = New ThirdEye.FlatLabel()
        Me.resultAge0 = New ThirdEye.FlatLabel()
        Me.resultName0 = New ThirdEye.FlatLabel()
        Me.viewDetailsBtn0 = New ThirdEye.FlatButton()
        Me.searchNameBtn = New ThirdEye.FlatButton()
        Me.FlatLabel3 = New ThirdEye.FlatLabel()
        Me.stateTxt = New ThirdEye.FlatComboBox()
        Me.Label3 = New ThirdEye.FlatLabel()
        Me.fnTxt = New ThirdEye.FlatTextBox()
        Me.cityTxt = New ThirdEye.FlatTextBox()
        Me.FlatLabel1 = New ThirdEye.FlatLabel()
        Me.FlatLabel2 = New ThirdEye.FlatLabel()
        Me.lnTxt = New ThirdEye.FlatTextBox()
        Me.phoneTab = New System.Windows.Forms.TabPage()
        Me.phoneAddress1 = New ThirdEye.FlatLabel()
        Me.geoLocate2 = New System.Windows.Forms.WebBrowser()
        Me.phoneSearchBtn = New ThirdEye.FlatButton()
        Me.phoneSearchTxt = New ThirdEye.FlatTextBox()
        Me.phoneResultBox1 = New ThirdEye.FlatGroupBox()
        Me.phonesAlt = New ThirdEye.FlatLabel()
        Me.altPhonesCB = New ThirdEye.FlatComboBox()
        Me.phoneComm = New ThirdEye.FlatLabel()
        Me.phoneCarrier = New ThirdEye.FlatLabel()
        Me.phoneLineType = New ThirdEye.FlatLabel()
        Me.phonePb1 = New System.Windows.Forms.PictureBox()
        Me.phoneCity1 = New ThirdEye.FlatLabel()
        Me.phoneGender1 = New ThirdEye.FlatLabel()
        Me.phoneAge1 = New ThirdEye.FlatLabel()
        Me.phoneName1 = New ThirdEye.FlatLabel()
        Me.FlatLabel15 = New ThirdEye.FlatLabel()
        Me.detailsTab = New System.Windows.Forms.TabPage()
        Me.detailsAddressTxt = New ThirdEye.FlatLabel()
        Me.detailsBox1 = New ThirdEye.FlatGroupBox()
        Me.phonesComboBox = New ThirdEye.FlatListBox()
        Me.detailsPhonesTxt = New ThirdEye.FlatLabel()
        Me.detailsNameTxt = New ThirdEye.FlatLabel()
        Me.geoLocate = New System.Windows.Forms.WebBrowser()
        Me.settingsTab = New System.Windows.Forms.TabPage()
        Me.saveSettingsBtn = New ThirdEye.FlatButton()
        Me.FlatLabel6 = New ThirdEye.FlatLabel()
        Me.reversePhoneTxt = New ThirdEye.FlatTextBox()
        Me.FlatLabel5 = New ThirdEye.FlatLabel()
        Me.FlatLabel4 = New ThirdEye.FlatLabel()
        Me.findPersonTxt = New ThirdEye.FlatTextBox()
        Me.FlatMini1 = New ThirdEye.FlatMini()
        Me.FlatClose1 = New ThirdEye.FlatClose()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FormSkin1.SuspendLayout()
        Me.FlatTabControl1.SuspendLayout()
        Me.searchTab.SuspendLayout()
        Me.resultsBox2.SuspendLayout()
        CType(Me.resultPb2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.resultsBox1.SuspendLayout()
        CType(Me.resultPb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.resultsBox0.SuspendLayout()
        CType(Me.resultPb0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.phoneTab.SuspendLayout()
        Me.phoneResultBox1.SuspendLayout()
        CType(Me.phonePb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.detailsTab.SuspendLayout()
        Me.detailsBox1.SuspendLayout()
        Me.settingsTab.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.statusTxt)
        Me.FormSkin1.Controls.Add(Me.FlatTabControl1)
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.PictureBox1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(800, 600)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "ThirdEye"
        '
        'statusTxt
        '
        Me.statusTxt.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.statusTxt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.statusTxt.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.statusTxt.ForeColor = System.Drawing.Color.White
        Me.statusTxt.Location = New System.Drawing.Point(0, 577)
        Me.statusTxt.Name = "statusTxt"
        Me.statusTxt.RectColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.statusTxt.ShowTimeDate = False
        Me.statusTxt.Size = New System.Drawing.Size(800, 23)
        Me.statusTxt.TabIndex = 4
        Me.statusTxt.Text = "..."
        Me.statusTxt.TextColor = System.Drawing.Color.White
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FlatTabControl1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl1.Controls.Add(Me.searchTab)
        Me.FlatTabControl1.Controls.Add(Me.phoneTab)
        Me.FlatTabControl1.Controls.Add(Me.detailsTab)
        Me.FlatTabControl1.Controls.Add(Me.settingsTab)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(0, 49)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(800, 539)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 3
        '
        'searchTab
        '
        Me.searchTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.searchTab.Controls.Add(Me.resultsBox2)
        Me.searchTab.Controls.Add(Me.resultsBox1)
        Me.searchTab.Controls.Add(Me.resultsBox0)
        Me.searchTab.Controls.Add(Me.searchNameBtn)
        Me.searchTab.Controls.Add(Me.FlatLabel3)
        Me.searchTab.Controls.Add(Me.stateTxt)
        Me.searchTab.Controls.Add(Me.Label3)
        Me.searchTab.Controls.Add(Me.fnTxt)
        Me.searchTab.Controls.Add(Me.cityTxt)
        Me.searchTab.Controls.Add(Me.FlatLabel1)
        Me.searchTab.Controls.Add(Me.FlatLabel2)
        Me.searchTab.Controls.Add(Me.lnTxt)
        Me.searchTab.Location = New System.Drawing.Point(4, 44)
        Me.searchTab.Name = "searchTab"
        Me.searchTab.Padding = New System.Windows.Forms.Padding(3)
        Me.searchTab.Size = New System.Drawing.Size(792, 491)
        Me.searchTab.TabIndex = 0
        Me.searchTab.Text = "Name Search"
        '
        'resultsBox2
        '
        Me.resultsBox2.BackColor = System.Drawing.Color.Transparent
        Me.resultsBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.resultsBox2.Controls.Add(Me.resultPb2)
        Me.resultsBox2.Controls.Add(Me.resultCity2)
        Me.resultsBox2.Controls.Add(Me.resultGender2)
        Me.resultsBox2.Controls.Add(Me.resultAge2)
        Me.resultsBox2.Controls.Add(Me.resultName2)
        Me.resultsBox2.Controls.Add(Me.ViewDetailsBtn2)
        Me.resultsBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.resultsBox2.Location = New System.Drawing.Point(8, 336)
        Me.resultsBox2.Name = "resultsBox2"
        Me.resultsBox2.ShowText = True
        Me.resultsBox2.Size = New System.Drawing.Size(774, 135)
        Me.resultsBox2.TabIndex = 15
        Me.resultsBox2.Visible = False
        '
        'resultPb2
        '
        Me.resultPb2.BackgroundImage = Global.ThirdEye.My.Resources.Resources.if_user_group_285648
        Me.resultPb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.resultPb2.Location = New System.Drawing.Point(13, 17)
        Me.resultPb2.Name = "resultPb2"
        Me.resultPb2.Size = New System.Drawing.Size(100, 100)
        Me.resultPb2.TabIndex = 14
        Me.resultPb2.TabStop = False
        Me.resultPb2.Visible = False
        '
        'resultCity2
        '
        Me.resultCity2.AutoSize = True
        Me.resultCity2.BackColor = System.Drawing.Color.Transparent
        Me.resultCity2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultCity2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.resultCity2.Location = New System.Drawing.Point(174, 74)
        Me.resultCity2.Name = "resultCity2"
        Me.resultCity2.Size = New System.Drawing.Size(45, 19)
        Me.resultCity2.TabIndex = 13
        Me.resultCity2.Text = "City:"
        Me.resultCity2.Visible = False
        '
        'resultGender2
        '
        Me.resultGender2.AutoSize = True
        Me.resultGender2.BackColor = System.Drawing.Color.Transparent
        Me.resultGender2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultGender2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.resultGender2.Location = New System.Drawing.Point(148, 55)
        Me.resultGender2.Name = "resultGender2"
        Me.resultGender2.Size = New System.Drawing.Size(71, 19)
        Me.resultGender2.TabIndex = 12
        Me.resultGender2.Text = "Gender:"
        Me.resultGender2.Visible = False
        '
        'resultAge2
        '
        Me.resultAge2.AutoSize = True
        Me.resultAge2.BackColor = System.Drawing.Color.Transparent
        Me.resultAge2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultAge2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.resultAge2.Location = New System.Drawing.Point(120, 36)
        Me.resultAge2.Name = "resultAge2"
        Me.resultAge2.Size = New System.Drawing.Size(99, 19)
        Me.resultAge2.TabIndex = 11
        Me.resultAge2.Text = "Age Range:"
        Me.resultAge2.Visible = False
        '
        'resultName2
        '
        Me.resultName2.AutoSize = True
        Me.resultName2.BackColor = System.Drawing.Color.Transparent
        Me.resultName2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultName2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.resultName2.Location = New System.Drawing.Point(160, 17)
        Me.resultName2.Name = "resultName2"
        Me.resultName2.Size = New System.Drawing.Size(59, 19)
        Me.resultName2.TabIndex = 10
        Me.resultName2.Text = "Name:"
        Me.resultName2.Visible = False
        '
        'ViewDetailsBtn2
        '
        Me.ViewDetailsBtn2.BackColor = System.Drawing.Color.Transparent
        Me.ViewDetailsBtn2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ViewDetailsBtn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ViewDetailsBtn2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ViewDetailsBtn2.Location = New System.Drawing.Point(648, 85)
        Me.ViewDetailsBtn2.Name = "ViewDetailsBtn2"
        Me.ViewDetailsBtn2.Rounded = False
        Me.ViewDetailsBtn2.Size = New System.Drawing.Size(102, 32)
        Me.ViewDetailsBtn2.TabIndex = 9
        Me.ViewDetailsBtn2.Text = "View Details"
        Me.ViewDetailsBtn2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ViewDetailsBtn2.Visible = False
        '
        'resultsBox1
        '
        Me.resultsBox1.BackColor = System.Drawing.Color.Transparent
        Me.resultsBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.resultsBox1.Controls.Add(Me.resultPb1)
        Me.resultsBox1.Controls.Add(Me.resultCity1)
        Me.resultsBox1.Controls.Add(Me.resultGender1)
        Me.resultsBox1.Controls.Add(Me.resultAge1)
        Me.resultsBox1.Controls.Add(Me.resultName1)
        Me.resultsBox1.Controls.Add(Me.viewDetailsBtn1)
        Me.resultsBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.resultsBox1.Location = New System.Drawing.Point(9, 197)
        Me.resultsBox1.Name = "resultsBox1"
        Me.resultsBox1.ShowText = True
        Me.resultsBox1.Size = New System.Drawing.Size(774, 135)
        Me.resultsBox1.TabIndex = 15
        Me.resultsBox1.Visible = False
        '
        'resultPb1
        '
        Me.resultPb1.BackgroundImage = Global.ThirdEye.My.Resources.Resources.if_user_group_285648
        Me.resultPb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.resultPb1.Location = New System.Drawing.Point(13, 17)
        Me.resultPb1.Name = "resultPb1"
        Me.resultPb1.Size = New System.Drawing.Size(100, 100)
        Me.resultPb1.TabIndex = 14
        Me.resultPb1.TabStop = False
        Me.resultPb1.Visible = False
        '
        'resultCity1
        '
        Me.resultCity1.AutoSize = True
        Me.resultCity1.BackColor = System.Drawing.Color.Transparent
        Me.resultCity1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultCity1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.resultCity1.Location = New System.Drawing.Point(173, 74)
        Me.resultCity1.Name = "resultCity1"
        Me.resultCity1.Size = New System.Drawing.Size(45, 19)
        Me.resultCity1.TabIndex = 13
        Me.resultCity1.Text = "City:"
        Me.resultCity1.Visible = False
        '
        'resultGender1
        '
        Me.resultGender1.AutoSize = True
        Me.resultGender1.BackColor = System.Drawing.Color.Transparent
        Me.resultGender1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultGender1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.resultGender1.Location = New System.Drawing.Point(147, 55)
        Me.resultGender1.Name = "resultGender1"
        Me.resultGender1.Size = New System.Drawing.Size(71, 19)
        Me.resultGender1.TabIndex = 12
        Me.resultGender1.Text = "Gender:"
        Me.resultGender1.Visible = False
        '
        'resultAge1
        '
        Me.resultAge1.AutoSize = True
        Me.resultAge1.BackColor = System.Drawing.Color.Transparent
        Me.resultAge1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultAge1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.resultAge1.Location = New System.Drawing.Point(119, 36)
        Me.resultAge1.Name = "resultAge1"
        Me.resultAge1.Size = New System.Drawing.Size(99, 19)
        Me.resultAge1.TabIndex = 11
        Me.resultAge1.Text = "Age Range:"
        Me.resultAge1.Visible = False
        '
        'resultName1
        '
        Me.resultName1.AutoSize = True
        Me.resultName1.BackColor = System.Drawing.Color.Transparent
        Me.resultName1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultName1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.resultName1.Location = New System.Drawing.Point(159, 17)
        Me.resultName1.Name = "resultName1"
        Me.resultName1.Size = New System.Drawing.Size(59, 19)
        Me.resultName1.TabIndex = 10
        Me.resultName1.Text = "Name:"
        Me.resultName1.Visible = False
        '
        'viewDetailsBtn1
        '
        Me.viewDetailsBtn1.BackColor = System.Drawing.Color.Transparent
        Me.viewDetailsBtn1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.viewDetailsBtn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.viewDetailsBtn1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.viewDetailsBtn1.Location = New System.Drawing.Point(648, 85)
        Me.viewDetailsBtn1.Name = "viewDetailsBtn1"
        Me.viewDetailsBtn1.Rounded = False
        Me.viewDetailsBtn1.Size = New System.Drawing.Size(102, 32)
        Me.viewDetailsBtn1.TabIndex = 9
        Me.viewDetailsBtn1.Text = "View Details"
        Me.viewDetailsBtn1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.viewDetailsBtn1.Visible = False
        '
        'resultsBox0
        '
        Me.resultsBox0.BackColor = System.Drawing.Color.Transparent
        Me.resultsBox0.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.resultsBox0.Controls.Add(Me.resultPb0)
        Me.resultsBox0.Controls.Add(Me.resultCity0)
        Me.resultsBox0.Controls.Add(Me.resultGender0)
        Me.resultsBox0.Controls.Add(Me.resultAge0)
        Me.resultsBox0.Controls.Add(Me.resultName0)
        Me.resultsBox0.Controls.Add(Me.viewDetailsBtn0)
        Me.resultsBox0.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.resultsBox0.Location = New System.Drawing.Point(10, 56)
        Me.resultsBox0.Name = "resultsBox0"
        Me.resultsBox0.ShowText = True
        Me.resultsBox0.Size = New System.Drawing.Size(774, 135)
        Me.resultsBox0.TabIndex = 8
        Me.resultsBox0.Visible = False
        '
        'resultPb0
        '
        Me.resultPb0.BackgroundImage = Global.ThirdEye.My.Resources.Resources.if_user_group_285648
        Me.resultPb0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.resultPb0.Location = New System.Drawing.Point(13, 17)
        Me.resultPb0.Name = "resultPb0"
        Me.resultPb0.Size = New System.Drawing.Size(100, 100)
        Me.resultPb0.TabIndex = 14
        Me.resultPb0.TabStop = False
        Me.resultPb0.Visible = False
        '
        'resultCity0
        '
        Me.resultCity0.AutoSize = True
        Me.resultCity0.BackColor = System.Drawing.Color.Transparent
        Me.resultCity0.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultCity0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.resultCity0.Location = New System.Drawing.Point(172, 74)
        Me.resultCity0.Name = "resultCity0"
        Me.resultCity0.Size = New System.Drawing.Size(45, 19)
        Me.resultCity0.TabIndex = 13
        Me.resultCity0.Text = "City:"
        Me.resultCity0.Visible = False
        '
        'resultGender0
        '
        Me.resultGender0.AutoSize = True
        Me.resultGender0.BackColor = System.Drawing.Color.Transparent
        Me.resultGender0.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultGender0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.resultGender0.Location = New System.Drawing.Point(146, 55)
        Me.resultGender0.Name = "resultGender0"
        Me.resultGender0.Size = New System.Drawing.Size(71, 19)
        Me.resultGender0.TabIndex = 12
        Me.resultGender0.Text = "Gender:"
        Me.resultGender0.Visible = False
        '
        'resultAge0
        '
        Me.resultAge0.AutoSize = True
        Me.resultAge0.BackColor = System.Drawing.Color.Transparent
        Me.resultAge0.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultAge0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.resultAge0.Location = New System.Drawing.Point(118, 36)
        Me.resultAge0.Name = "resultAge0"
        Me.resultAge0.Size = New System.Drawing.Size(99, 19)
        Me.resultAge0.TabIndex = 11
        Me.resultAge0.Text = "Age Range:"
        Me.resultAge0.Visible = False
        '
        'resultName0
        '
        Me.resultName0.AutoSize = True
        Me.resultName0.BackColor = System.Drawing.Color.Transparent
        Me.resultName0.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultName0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.resultName0.Location = New System.Drawing.Point(158, 17)
        Me.resultName0.Name = "resultName0"
        Me.resultName0.Size = New System.Drawing.Size(59, 19)
        Me.resultName0.TabIndex = 10
        Me.resultName0.Text = "Name:"
        Me.resultName0.Visible = False
        '
        'viewDetailsBtn0
        '
        Me.viewDetailsBtn0.BackColor = System.Drawing.Color.Transparent
        Me.viewDetailsBtn0.BaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.viewDetailsBtn0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.viewDetailsBtn0.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.viewDetailsBtn0.Location = New System.Drawing.Point(648, 85)
        Me.viewDetailsBtn0.Name = "viewDetailsBtn0"
        Me.viewDetailsBtn0.Rounded = False
        Me.viewDetailsBtn0.Size = New System.Drawing.Size(102, 32)
        Me.viewDetailsBtn0.TabIndex = 9
        Me.viewDetailsBtn0.Text = "View Details"
        Me.viewDetailsBtn0.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.viewDetailsBtn0.Visible = False
        '
        'searchNameBtn
        '
        Me.searchNameBtn.BackColor = System.Drawing.Color.Transparent
        Me.searchNameBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.searchNameBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.searchNameBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.searchNameBtn.Location = New System.Drawing.Point(701, 18)
        Me.searchNameBtn.Name = "searchNameBtn"
        Me.searchNameBtn.Rounded = False
        Me.searchNameBtn.Size = New System.Drawing.Size(83, 32)
        Me.searchNameBtn.TabIndex = 7
        Me.searchNameBtn.Text = "Search"
        Me.searchNameBtn.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.FlatLabel3.Location = New System.Drawing.Point(611, 5)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(33, 13)
        Me.FlatLabel3.TabIndex = 6
        Me.FlatLabel3.Text = "State"
        '
        'stateTxt
        '
        Me.stateTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.stateTxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.stateTxt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.stateTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.stateTxt.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.stateTxt.ForeColor = System.Drawing.Color.White
        Me.stateTxt.FormattingEnabled = True
        Me.stateTxt.HoverColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.stateTxt.ItemHeight = 18
        Me.stateTxt.Items.AddRange(New Object() {"AK", "AL", "AR", "AZ", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME", "MI", "MN", "MO", "MS", "MT", "NC", "ND", "NE", "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VA", "VT", "WA", "WI", "WV", "WY"})
        Me.stateTxt.Location = New System.Drawing.Point(614, 26)
        Me.stateTxt.Name = "stateTxt"
        Me.stateTxt.Size = New System.Drawing.Size(81, 24)
        Me.stateTxt.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(425, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "City Name"
        '
        'fnTxt
        '
        Me.fnTxt.BackColor = System.Drawing.Color.Transparent
        Me.fnTxt.Location = New System.Drawing.Point(8, 21)
        Me.fnTxt.MaxLength = 32767
        Me.fnTxt.Multiline = False
        Me.fnTxt.Name = "fnTxt"
        Me.fnTxt.ReadOnly = False
        Me.fnTxt.Size = New System.Drawing.Size(180, 29)
        Me.fnTxt.TabIndex = 0
        Me.fnTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.fnTxt.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.fnTxt.UseSystemPasswordChar = False
        '
        'cityTxt
        '
        Me.cityTxt.BackColor = System.Drawing.Color.Transparent
        Me.cityTxt.Location = New System.Drawing.Point(428, 21)
        Me.cityTxt.MaxLength = 32767
        Me.cityTxt.Multiline = False
        Me.cityTxt.Name = "cityTxt"
        Me.cityTxt.ReadOnly = False
        Me.cityTxt.Size = New System.Drawing.Size(180, 29)
        Me.cityTxt.TabIndex = 4
        Me.cityTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.cityTxt.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cityTxt.UseSystemPasswordChar = False
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.FlatLabel1.Location = New System.Drawing.Point(6, 5)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(61, 13)
        Me.FlatLabel1.TabIndex = 0
        Me.FlatLabel1.Text = "First Name"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.FlatLabel2.Location = New System.Drawing.Point(191, 5)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(59, 13)
        Me.FlatLabel2.TabIndex = 1
        Me.FlatLabel2.Text = "Last Name"
        '
        'lnTxt
        '
        Me.lnTxt.BackColor = System.Drawing.Color.Transparent
        Me.lnTxt.Location = New System.Drawing.Point(194, 21)
        Me.lnTxt.MaxLength = 32767
        Me.lnTxt.Multiline = False
        Me.lnTxt.Name = "lnTxt"
        Me.lnTxt.ReadOnly = False
        Me.lnTxt.Size = New System.Drawing.Size(191, 29)
        Me.lnTxt.TabIndex = 2
        Me.lnTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.lnTxt.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lnTxt.UseSystemPasswordChar = False
        '
        'phoneTab
        '
        Me.phoneTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.phoneTab.Controls.Add(Me.phoneAddress1)
        Me.phoneTab.Controls.Add(Me.geoLocate2)
        Me.phoneTab.Controls.Add(Me.phoneSearchBtn)
        Me.phoneTab.Controls.Add(Me.phoneSearchTxt)
        Me.phoneTab.Controls.Add(Me.phoneResultBox1)
        Me.phoneTab.Controls.Add(Me.FlatLabel15)
        Me.phoneTab.Location = New System.Drawing.Point(4, 44)
        Me.phoneTab.Name = "phoneTab"
        Me.phoneTab.Size = New System.Drawing.Size(792, 491)
        Me.phoneTab.TabIndex = 2
        Me.phoneTab.Text = "Phone Search"
        '
        'phoneAddress1
        '
        Me.phoneAddress1.AutoSize = True
        Me.phoneAddress1.BackColor = System.Drawing.Color.Transparent
        Me.phoneAddress1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.phoneAddress1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.phoneAddress1.Location = New System.Drawing.Point(8, 201)
        Me.phoneAddress1.Name = "phoneAddress1"
        Me.phoneAddress1.Size = New System.Drawing.Size(90, 13)
        Me.phoneAddress1.TabIndex = 21
        Me.phoneAddress1.Text = "Current Address"
        '
        'geoLocate2
        '
        Me.geoLocate2.Location = New System.Drawing.Point(9, 217)
        Me.geoLocate2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.geoLocate2.Name = "geoLocate2"
        Me.geoLocate2.ScriptErrorsSuppressed = True
        Me.geoLocate2.ScrollBarsEnabled = False
        Me.geoLocate2.Size = New System.Drawing.Size(776, 261)
        Me.geoLocate2.TabIndex = 20
        '
        'phoneSearchBtn
        '
        Me.phoneSearchBtn.BackColor = System.Drawing.Color.Transparent
        Me.phoneSearchBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.phoneSearchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.phoneSearchBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.phoneSearchBtn.Location = New System.Drawing.Point(702, 28)
        Me.phoneSearchBtn.Name = "phoneSearchBtn"
        Me.phoneSearchBtn.Rounded = False
        Me.phoneSearchBtn.Size = New System.Drawing.Size(83, 29)
        Me.phoneSearchBtn.TabIndex = 18
        Me.phoneSearchBtn.Text = "Search"
        Me.phoneSearchBtn.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'phoneSearchTxt
        '
        Me.phoneSearchTxt.BackColor = System.Drawing.Color.Transparent
        Me.phoneSearchTxt.Location = New System.Drawing.Point(9, 28)
        Me.phoneSearchTxt.MaxLength = 32767
        Me.phoneSearchTxt.Multiline = False
        Me.phoneSearchTxt.Name = "phoneSearchTxt"
        Me.phoneSearchTxt.ReadOnly = False
        Me.phoneSearchTxt.Size = New System.Drawing.Size(687, 29)
        Me.phoneSearchTxt.TabIndex = 16
        Me.phoneSearchTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.phoneSearchTxt.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.phoneSearchTxt.UseSystemPasswordChar = False
        '
        'phoneResultBox1
        '
        Me.phoneResultBox1.BackColor = System.Drawing.Color.Transparent
        Me.phoneResultBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.phoneResultBox1.Controls.Add(Me.phonesAlt)
        Me.phoneResultBox1.Controls.Add(Me.altPhonesCB)
        Me.phoneResultBox1.Controls.Add(Me.phoneComm)
        Me.phoneResultBox1.Controls.Add(Me.phoneCarrier)
        Me.phoneResultBox1.Controls.Add(Me.phoneLineType)
        Me.phoneResultBox1.Controls.Add(Me.phonePb1)
        Me.phoneResultBox1.Controls.Add(Me.phoneCity1)
        Me.phoneResultBox1.Controls.Add(Me.phoneGender1)
        Me.phoneResultBox1.Controls.Add(Me.phoneAge1)
        Me.phoneResultBox1.Controls.Add(Me.phoneName1)
        Me.phoneResultBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.phoneResultBox1.Location = New System.Drawing.Point(11, 63)
        Me.phoneResultBox1.Name = "phoneResultBox1"
        Me.phoneResultBox1.ShowText = True
        Me.phoneResultBox1.Size = New System.Drawing.Size(774, 135)
        Me.phoneResultBox1.TabIndex = 19
        '
        'phonesAlt
        '
        Me.phonesAlt.AutoSize = True
        Me.phonesAlt.BackColor = System.Drawing.Color.Transparent
        Me.phonesAlt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phonesAlt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.phonesAlt.Location = New System.Drawing.Point(459, 97)
        Me.phonesAlt.Name = "phonesAlt"
        Me.phonesAlt.Size = New System.Drawing.Size(98, 19)
        Me.phonesAlt.TabIndex = 19
        Me.phonesAlt.Text = "Alt Phones:"
        '
        'altPhonesCB
        '
        Me.altPhonesCB.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.altPhonesCB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.altPhonesCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.altPhonesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.altPhonesCB.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.altPhonesCB.ForeColor = System.Drawing.Color.White
        Me.altPhonesCB.FormattingEnabled = True
        Me.altPhonesCB.HoverColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.altPhonesCB.ItemHeight = 18
        Me.altPhonesCB.Location = New System.Drawing.Point(563, 92)
        Me.altPhonesCB.Name = "altPhonesCB"
        Me.altPhonesCB.Size = New System.Drawing.Size(191, 24)
        Me.altPhonesCB.TabIndex = 18
        '
        'phoneComm
        '
        Me.phoneComm.AutoSize = True
        Me.phoneComm.BackColor = System.Drawing.Color.Transparent
        Me.phoneComm.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneComm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.phoneComm.Location = New System.Drawing.Point(441, 55)
        Me.phoneComm.Name = "phoneComm"
        Me.phoneComm.Size = New System.Drawing.Size(116, 19)
        Me.phoneComm.TabIndex = 17
        Me.phoneComm.Text = "Commercial?:"
        '
        'phoneCarrier
        '
        Me.phoneCarrier.AutoSize = True
        Me.phoneCarrier.BackColor = System.Drawing.Color.Transparent
        Me.phoneCarrier.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneCarrier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.phoneCarrier.Location = New System.Drawing.Point(490, 36)
        Me.phoneCarrier.Name = "phoneCarrier"
        Me.phoneCarrier.Size = New System.Drawing.Size(67, 19)
        Me.phoneCarrier.TabIndex = 16
        Me.phoneCarrier.Text = "Carrier:"
        '
        'phoneLineType
        '
        Me.phoneLineType.AutoSize = True
        Me.phoneLineType.BackColor = System.Drawing.Color.Transparent
        Me.phoneLineType.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneLineType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.phoneLineType.Location = New System.Drawing.Point(505, 17)
        Me.phoneLineType.Name = "phoneLineType"
        Me.phoneLineType.Size = New System.Drawing.Size(52, 19)
        Me.phoneLineType.TabIndex = 15
        Me.phoneLineType.Text = "Type:"
        '
        'phonePb1
        '
        Me.phonePb1.BackgroundImage = Global.ThirdEye.My.Resources.Resources.if_user_group_285648
        Me.phonePb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.phonePb1.Location = New System.Drawing.Point(13, 17)
        Me.phonePb1.Name = "phonePb1"
        Me.phonePb1.Size = New System.Drawing.Size(100, 100)
        Me.phonePb1.TabIndex = 14
        Me.phonePb1.TabStop = False
        '
        'phoneCity1
        '
        Me.phoneCity1.AutoSize = True
        Me.phoneCity1.BackColor = System.Drawing.Color.Transparent
        Me.phoneCity1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneCity1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.phoneCity1.Location = New System.Drawing.Point(172, 74)
        Me.phoneCity1.Name = "phoneCity1"
        Me.phoneCity1.Size = New System.Drawing.Size(45, 19)
        Me.phoneCity1.TabIndex = 13
        Me.phoneCity1.Text = "City:"
        '
        'phoneGender1
        '
        Me.phoneGender1.AutoSize = True
        Me.phoneGender1.BackColor = System.Drawing.Color.Transparent
        Me.phoneGender1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneGender1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.phoneGender1.Location = New System.Drawing.Point(146, 55)
        Me.phoneGender1.Name = "phoneGender1"
        Me.phoneGender1.Size = New System.Drawing.Size(71, 19)
        Me.phoneGender1.TabIndex = 12
        Me.phoneGender1.Text = "Gender:"
        '
        'phoneAge1
        '
        Me.phoneAge1.AutoSize = True
        Me.phoneAge1.BackColor = System.Drawing.Color.Transparent
        Me.phoneAge1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneAge1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.phoneAge1.Location = New System.Drawing.Point(118, 36)
        Me.phoneAge1.Name = "phoneAge1"
        Me.phoneAge1.Size = New System.Drawing.Size(99, 19)
        Me.phoneAge1.TabIndex = 11
        Me.phoneAge1.Text = "Age Range:"
        '
        'phoneName1
        '
        Me.phoneName1.AutoSize = True
        Me.phoneName1.BackColor = System.Drawing.Color.Transparent
        Me.phoneName1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneName1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.phoneName1.Location = New System.Drawing.Point(158, 17)
        Me.phoneName1.Name = "phoneName1"
        Me.phoneName1.Size = New System.Drawing.Size(59, 19)
        Me.phoneName1.TabIndex = 10
        Me.phoneName1.Text = "Name:"
        '
        'FlatLabel15
        '
        Me.FlatLabel15.AutoSize = True
        Me.FlatLabel15.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel15.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.FlatLabel15.Location = New System.Drawing.Point(7, 12)
        Me.FlatLabel15.Name = "FlatLabel15"
        Me.FlatLabel15.Size = New System.Drawing.Size(171, 13)
        Me.FlatLabel15.TabIndex = 17
        Me.FlatLabel15.Text = "Phone Number (###-###-####)"
        '
        'detailsTab
        '
        Me.detailsTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.detailsTab.Controls.Add(Me.detailsAddressTxt)
        Me.detailsTab.Controls.Add(Me.detailsBox1)
        Me.detailsTab.Controls.Add(Me.geoLocate)
        Me.detailsTab.Location = New System.Drawing.Point(4, 44)
        Me.detailsTab.Name = "detailsTab"
        Me.detailsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.detailsTab.Size = New System.Drawing.Size(792, 491)
        Me.detailsTab.TabIndex = 1
        Me.detailsTab.Text = "Details"
        '
        'detailsAddressTxt
        '
        Me.detailsAddressTxt.AutoSize = True
        Me.detailsAddressTxt.BackColor = System.Drawing.Color.Transparent
        Me.detailsAddressTxt.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.detailsAddressTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.detailsAddressTxt.Location = New System.Drawing.Point(8, 91)
        Me.detailsAddressTxt.Name = "detailsAddressTxt"
        Me.detailsAddressTxt.Size = New System.Drawing.Size(90, 13)
        Me.detailsAddressTxt.TabIndex = 2
        Me.detailsAddressTxt.Text = "Current Address"
        '
        'detailsBox1
        '
        Me.detailsBox1.BackColor = System.Drawing.Color.Transparent
        Me.detailsBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.detailsBox1.Controls.Add(Me.phonesComboBox)
        Me.detailsBox1.Controls.Add(Me.detailsPhonesTxt)
        Me.detailsBox1.Controls.Add(Me.detailsNameTxt)
        Me.detailsBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.detailsBox1.Location = New System.Drawing.Point(9, 6)
        Me.detailsBox1.Name = "detailsBox1"
        Me.detailsBox1.ShowText = True
        Me.detailsBox1.Size = New System.Drawing.Size(495, 82)
        Me.detailsBox1.TabIndex = 1
        '
        'phonesComboBox
        '
        Me.phonesComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.phonesComboBox.items = New String() {""}
        Me.phonesComboBox.Location = New System.Drawing.Point(241, 19)
        Me.phonesComboBox.Name = "phonesComboBox"
        Me.phonesComboBox.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.phonesComboBox.Size = New System.Drawing.Size(231, 43)
        Me.phonesComboBox.TabIndex = 2
        Me.phonesComboBox.Text = "FlatListBox1"
        Me.phonesComboBox.Visible = False
        '
        'detailsPhonesTxt
        '
        Me.detailsPhonesTxt.AutoSize = True
        Me.detailsPhonesTxt.BackColor = System.Drawing.Color.Transparent
        Me.detailsPhonesTxt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailsPhonesTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.detailsPhonesTxt.Location = New System.Drawing.Point(20, 43)
        Me.detailsPhonesTxt.Name = "detailsPhonesTxt"
        Me.detailsPhonesTxt.Size = New System.Drawing.Size(131, 19)
        Me.detailsPhonesTxt.TabIndex = 1
        Me.detailsPhonesTxt.Text = "Phone numbers"
        '
        'detailsNameTxt
        '
        Me.detailsNameTxt.AutoSize = True
        Me.detailsNameTxt.BackColor = System.Drawing.Color.Transparent
        Me.detailsNameTxt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailsNameTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.detailsNameTxt.Location = New System.Drawing.Point(20, 19)
        Me.detailsNameTxt.Name = "detailsNameTxt"
        Me.detailsNameTxt.Size = New System.Drawing.Size(53, 19)
        Me.detailsNameTxt.TabIndex = 0
        Me.detailsNameTxt.Text = "Name"
        '
        'geoLocate
        '
        Me.geoLocate.Location = New System.Drawing.Point(8, 107)
        Me.geoLocate.MinimumSize = New System.Drawing.Size(20, 20)
        Me.geoLocate.Name = "geoLocate"
        Me.geoLocate.ScriptErrorsSuppressed = True
        Me.geoLocate.ScrollBarsEnabled = False
        Me.geoLocate.Size = New System.Drawing.Size(776, 371)
        Me.geoLocate.TabIndex = 0
        '
        'settingsTab
        '
        Me.settingsTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.settingsTab.Controls.Add(Me.saveSettingsBtn)
        Me.settingsTab.Controls.Add(Me.FlatLabel6)
        Me.settingsTab.Controls.Add(Me.reversePhoneTxt)
        Me.settingsTab.Controls.Add(Me.FlatLabel5)
        Me.settingsTab.Controls.Add(Me.FlatLabel4)
        Me.settingsTab.Controls.Add(Me.findPersonTxt)
        Me.settingsTab.Location = New System.Drawing.Point(4, 44)
        Me.settingsTab.Name = "settingsTab"
        Me.settingsTab.Size = New System.Drawing.Size(792, 491)
        Me.settingsTab.TabIndex = 3
        Me.settingsTab.Text = "Settings"
        '
        'saveSettingsBtn
        '
        Me.saveSettingsBtn.BackColor = System.Drawing.Color.Transparent
        Me.saveSettingsBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.saveSettingsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.saveSettingsBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.saveSettingsBtn.Location = New System.Drawing.Point(678, 51)
        Me.saveSettingsBtn.Name = "saveSettingsBtn"
        Me.saveSettingsBtn.Rounded = False
        Me.saveSettingsBtn.Size = New System.Drawing.Size(106, 32)
        Me.saveSettingsBtn.TabIndex = 7
        Me.saveSettingsBtn.Text = "Save"
        Me.saveSettingsBtn.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel6
        '
        Me.FlatLabel6.AutoSize = True
        Me.FlatLabel6.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel6.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.FlatLabel6.Location = New System.Drawing.Point(329, 54)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New System.Drawing.Size(85, 13)
        Me.FlatLabel6.TabIndex = 6
        Me.FlatLabel6.Text = "Reverse Phone:"
        '
        'reversePhoneTxt
        '
        Me.reversePhoneTxt.BackColor = System.Drawing.Color.Transparent
        Me.reversePhoneTxt.Location = New System.Drawing.Point(420, 54)
        Me.reversePhoneTxt.MaxLength = 32767
        Me.reversePhoneTxt.Multiline = False
        Me.reversePhoneTxt.Name = "reversePhoneTxt"
        Me.reversePhoneTxt.ReadOnly = False
        Me.reversePhoneTxt.Size = New System.Drawing.Size(238, 29)
        Me.reversePhoneTxt.TabIndex = 5
        Me.reversePhoneTxt.Text = "80c07727a56f4586b22a88a5f8dd79b0"
        Me.reversePhoneTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.reversePhoneTxt.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.reversePhoneTxt.UseSystemPasswordChar = False
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.FlatLabel5.Location = New System.Drawing.Point(8, 54)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(71, 13)
        Me.FlatLabel5.TabIndex = 4
        Me.FlatLabel5.Text = "Find Person:"
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.FlatLabel4.Location = New System.Drawing.Point(8, 16)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(48, 13)
        Me.FlatLabel4.TabIndex = 3
        Me.FlatLabel4.Text = "API Keys"
        '
        'findPersonTxt
        '
        Me.findPersonTxt.BackColor = System.Drawing.Color.Transparent
        Me.findPersonTxt.Location = New System.Drawing.Point(85, 54)
        Me.findPersonTxt.MaxLength = 32767
        Me.findPersonTxt.Multiline = False
        Me.findPersonTxt.Name = "findPersonTxt"
        Me.findPersonTxt.ReadOnly = False
        Me.findPersonTxt.Size = New System.Drawing.Size(238, 29)
        Me.findPersonTxt.TabIndex = 0
        Me.findPersonTxt.Text = "2929a96301e14cbca4892c200e0b455f"
        Me.findPersonTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.findPersonTxt.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.findPersonTxt.UseSystemPasswordChar = False
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(746, 12)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 2
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(770, 12)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 1
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.ThirdEye.My.Resources.Resources._1014894_200
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(27, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TheFace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TheFace"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ThirdEye"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FlatTabControl1.ResumeLayout(False)
        Me.searchTab.ResumeLayout(False)
        Me.searchTab.PerformLayout()
        Me.resultsBox2.ResumeLayout(False)
        Me.resultsBox2.PerformLayout()
        CType(Me.resultPb2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.resultsBox1.ResumeLayout(False)
        Me.resultsBox1.PerformLayout()
        CType(Me.resultPb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.resultsBox0.ResumeLayout(False)
        Me.resultsBox0.PerformLayout()
        CType(Me.resultPb0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.phoneTab.ResumeLayout(False)
        Me.phoneTab.PerformLayout()
        Me.phoneResultBox1.ResumeLayout(False)
        Me.phoneResultBox1.PerformLayout()
        CType(Me.phonePb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.detailsTab.ResumeLayout(False)
        Me.detailsTab.PerformLayout()
        Me.detailsBox1.ResumeLayout(False)
        Me.detailsBox1.PerformLayout()
        Me.settingsTab.ResumeLayout(False)
        Me.settingsTab.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlatTabControl1 As FlatTabControl
    Friend WithEvents searchTab As TabPage
    Friend WithEvents fnTxt As FlatTextBox
    Friend WithEvents detailsTab As TabPage
    Friend WithEvents FlatMini1 As FlatMini
    Friend WithEvents FlatClose1 As FlatClose
    Friend WithEvents searchNameBtn As FlatButton
    Friend WithEvents FlatLabel3 As FlatLabel
    Friend WithEvents stateTxt As FlatComboBox
    Friend WithEvents Label3 As FlatLabel
    Friend WithEvents cityTxt As FlatTextBox
    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents lnTxt As FlatTextBox
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents resultsBox0 As FlatGroupBox
    Friend WithEvents viewDetailsBtn0 As FlatButton
    Friend WithEvents resultsBox2 As FlatGroupBox
    Friend WithEvents resultPb2 As PictureBox
    Friend WithEvents resultCity2 As FlatLabel
    Friend WithEvents resultGender2 As FlatLabel
    Friend WithEvents resultAge2 As FlatLabel
    Friend WithEvents resultName2 As FlatLabel
    Friend WithEvents ViewDetailsBtn2 As FlatButton
    Friend WithEvents resultsBox1 As FlatGroupBox
    Friend WithEvents resultPb1 As PictureBox
    Friend WithEvents resultCity1 As FlatLabel
    Friend WithEvents resultGender1 As FlatLabel
    Friend WithEvents resultAge1 As FlatLabel
    Friend WithEvents resultName1 As FlatLabel
    Friend WithEvents viewDetailsBtn1 As FlatButton
    Friend WithEvents resultPb0 As PictureBox
    Friend WithEvents resultCity0 As FlatLabel
    Friend WithEvents resultGender0 As FlatLabel
    Friend WithEvents resultAge0 As FlatLabel
    Friend WithEvents resultName0 As FlatLabel
    Friend WithEvents detailsBox1 As FlatGroupBox
    Friend WithEvents geoLocate As WebBrowser
    Friend WithEvents detailsAddressTxt As FlatLabel
    Friend WithEvents detailsNameTxt As FlatLabel
    Friend WithEvents detailsPhonesTxt As FlatLabel
    Friend WithEvents phonesComboBox As FlatListBox
    Friend WithEvents phoneTab As TabPage
    Friend WithEvents statusTxt As FlatStatusBar
    Friend WithEvents phoneSearchBtn As FlatButton
    Friend WithEvents phoneSearchTxt As FlatTextBox
    Friend WithEvents phoneResultBox1 As FlatGroupBox
    Friend WithEvents phonePb1 As PictureBox
    Friend WithEvents phoneCity1 As FlatLabel
    Friend WithEvents phoneGender1 As FlatLabel
    Friend WithEvents phoneAge1 As FlatLabel
    Friend WithEvents phoneName1 As FlatLabel
    Friend WithEvents FlatLabel15 As FlatLabel
    Friend WithEvents phoneAddress1 As FlatLabel
    Friend WithEvents geoLocate2 As WebBrowser
    Friend WithEvents phonesAlt As FlatLabel
    Friend WithEvents altPhonesCB As FlatComboBox
    Friend WithEvents phoneComm As FlatLabel
    Friend WithEvents phoneCarrier As FlatLabel
    Friend WithEvents phoneLineType As FlatLabel
    Friend WithEvents settingsTab As TabPage
    Friend WithEvents FlatLabel6 As FlatLabel
    Friend WithEvents reversePhoneTxt As FlatTextBox
    Friend WithEvents FlatLabel5 As FlatLabel
    Friend WithEvents FlatLabel4 As FlatLabel
    Friend WithEvents findPersonTxt As FlatTextBox
    Friend WithEvents saveSettingsBtn As FlatButton
End Class
