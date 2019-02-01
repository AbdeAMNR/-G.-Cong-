<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CongeForm
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CongeForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.checkAnnuler = New System.Windows.Forms.CheckBox()
        Me.cmdAppliquer = New MetroFramework.Controls.MetroButton()
        Me.cmdAjouter = New MetroFramework.Controls.MetroButton()
        Me.cbxTypeConge = New MetroFramework.Controls.MetroComboBox()
        Me.DateReprise = New MetroFramework.Controls.MetroDateTime()
        Me.DateDebut = New MetroFramework.Controls.MetroDateTime()
        Me.txtDuree = New MetroFramework.Controls.MetroTextBox()
        Me.txtMatriculeC = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lblMatricule = New MetroFramework.Controls.MetroLabel()
        Me.GroupBoxConge = New System.Windows.Forms.GroupBox()
        Me.pnlSwitchC = New MetroFramework.Controls.MetroPanel()
        Me.btnConge = New MetroFramework.Controls.MetroButton()
        Me.btnPerso = New MetroFramework.Controls.MetroButton()
        Me.lnkBack = New MetroFramework.Controls.MetroLink()
        Me.btnSwitch = New MetroFramework.Controls.MetroLink()
        Me.myUXStyle = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.GridConge = New MetroFramework.Controls.MetroGrid()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtCongeNum = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBoxConge.SuspendLayout()
        Me.pnlSwitchC.SuspendLayout()
        CType(Me.myUXStyle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridConge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'checkAnnuler
        '
        Me.checkAnnuler.AutoSize = True
        Me.checkAnnuler.Location = New System.Drawing.Point(45, 356)
        Me.checkAnnuler.Name = "checkAnnuler"
        Me.checkAnnuler.Size = New System.Drawing.Size(110, 17)
        Me.checkAnnuler.TabIndex = 7
        Me.checkAnnuler.Text = "Annuler un congé"
        Me.checkAnnuler.UseVisualStyleBackColor = True
        '
        'cmdAppliquer
        '
        Me.cmdAppliquer.BackColor = System.Drawing.Color.Turquoise
        Me.cmdAppliquer.Location = New System.Drawing.Point(139, 378)
        Me.cmdAppliquer.Name = "cmdAppliquer"
        Me.cmdAppliquer.Size = New System.Drawing.Size(157, 31)
        Me.cmdAppliquer.Style = MetroFramework.MetroColorStyle.Blue
        Me.cmdAppliquer.TabIndex = 9
        Me.cmdAppliquer.Text = "Appliquer"
        Me.cmdAppliquer.UseCustomBackColor = True
        Me.cmdAppliquer.UseSelectable = True
        '
        'cmdAjouter
        '
        Me.cmdAjouter.BackColor = System.Drawing.Color.Transparent
        Me.cmdAjouter.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.cmdAjouter.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.cmdAjouter.Location = New System.Drawing.Point(45, 295)
        Me.cmdAjouter.Name = "cmdAjouter"
        Me.cmdAjouter.Size = New System.Drawing.Size(251, 40)
        Me.cmdAjouter.Style = MetroFramework.MetroColorStyle.Blue
        Me.cmdAjouter.TabIndex = 6
        Me.cmdAjouter.Text = "Ajouter"
        Me.cmdAjouter.UseCustomBackColor = True
        Me.cmdAjouter.UseSelectable = True
        '
        'cbxTypeConge
        '
        Me.cbxTypeConge.FormattingEnabled = True
        Me.cbxTypeConge.ItemHeight = 23
        Me.cbxTypeConge.Items.AddRange(New Object() {"Congé administratif", "Congé annuel", "Congé maladie"})
        Me.cbxTypeConge.Location = New System.Drawing.Point(45, 247)
        Me.cbxTypeConge.Name = "cbxTypeConge"
        Me.cbxTypeConge.Size = New System.Drawing.Size(251, 29)
        Me.cbxTypeConge.TabIndex = 5
        Me.cbxTypeConge.UseSelectable = True
        '
        'DateReprise
        '
        Me.DateReprise.Location = New System.Drawing.Point(45, 181)
        Me.DateReprise.MinimumSize = New System.Drawing.Size(0, 29)
        Me.DateReprise.Name = "DateReprise"
        Me.DateReprise.Size = New System.Drawing.Size(251, 29)
        Me.DateReprise.TabIndex = 7
        '
        'DateDebut
        '
        Me.DateDebut.Location = New System.Drawing.Point(45, 116)
        Me.DateDebut.MinimumSize = New System.Drawing.Size(0, 29)
        Me.DateDebut.Name = "DateDebut"
        Me.DateDebut.Size = New System.Drawing.Size(251, 29)
        Me.DateDebut.TabIndex = 2
        '
        'txtDuree
        '
        '
        '
        '
        Me.txtDuree.CustomButton.Image = Nothing
        Me.txtDuree.CustomButton.Location = New System.Drawing.Point(63, 2)
        Me.txtDuree.CustomButton.Name = ""
        Me.txtDuree.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtDuree.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDuree.CustomButton.TabIndex = 1
        Me.txtDuree.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDuree.CustomButton.UseSelectable = True
        Me.txtDuree.CustomButton.Visible = False
        Me.txtDuree.Lines = New String(-1) {}
        Me.txtDuree.Location = New System.Drawing.Point(205, 50)
        Me.txtDuree.MaxLength = 3
        Me.txtDuree.Name = "txtDuree"
        Me.txtDuree.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDuree.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDuree.SelectedText = ""
        Me.txtDuree.SelectionLength = 0
        Me.txtDuree.SelectionStart = 0
        Me.txtDuree.ShortcutsEnabled = True
        Me.txtDuree.Size = New System.Drawing.Size(91, 30)
        Me.txtDuree.TabIndex = 4
        Me.txtDuree.UseSelectable = True
        Me.txtDuree.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDuree.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtMatriculeC
        '
        '
        '
        '
        Me.txtMatriculeC.CustomButton.Image = Nothing
        Me.txtMatriculeC.CustomButton.Location = New System.Drawing.Point(126, 2)
        Me.txtMatriculeC.CustomButton.Name = ""
        Me.txtMatriculeC.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtMatriculeC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMatriculeC.CustomButton.TabIndex = 1
        Me.txtMatriculeC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMatriculeC.CustomButton.UseSelectable = True
        Me.txtMatriculeC.CustomButton.Visible = False
        Me.txtMatriculeC.Lines = New String(-1) {}
        Me.txtMatriculeC.Location = New System.Drawing.Point(45, 50)
        Me.txtMatriculeC.MaxLength = 8
        Me.txtMatriculeC.Name = "txtMatriculeC"
        Me.txtMatriculeC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMatriculeC.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMatriculeC.SelectedText = ""
        Me.txtMatriculeC.SelectionLength = 0
        Me.txtMatriculeC.SelectionStart = 0
        Me.txtMatriculeC.ShortcutsEnabled = True
        Me.txtMatriculeC.Size = New System.Drawing.Size(154, 30)
        Me.txtMatriculeC.TabIndex = 1
        Me.txtMatriculeC.UseSelectable = True
        Me.txtMatriculeC.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMatriculeC.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel6.Location = New System.Drawing.Point(45, 229)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(84, 15)
        Me.MetroLabel6.TabIndex = 2
        Me.MetroLabel6.Text = "Type de congé"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(205, 32)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(91, 15)
        Me.MetroLabel5.TabIndex = 2
        Me.MetroLabel5.Text = "Durée du congé"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(45, 163)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(101, 15)
        Me.MetroLabel4.TabIndex = 2
        Me.MetroLabel4.Text = "Reprise de Service"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(45, 98)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(92, 15)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Début du congé"
        '
        'lblMatricule
        '
        Me.lblMatricule.AutoSize = True
        Me.lblMatricule.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblMatricule.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblMatricule.Location = New System.Drawing.Point(45, 32)
        Me.lblMatricule.Name = "lblMatricule"
        Me.lblMatricule.Size = New System.Drawing.Size(57, 15)
        Me.lblMatricule.TabIndex = 2
        Me.lblMatricule.Text = "Matricule"
        '
        'GroupBoxConge
        '
        Me.GroupBoxConge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxConge.Controls.Add(Me.txtCongeNum)
        Me.GroupBoxConge.Controls.Add(Me.checkAnnuler)
        Me.GroupBoxConge.Controls.Add(Me.cmdAppliquer)
        Me.GroupBoxConge.Controls.Add(Me.cmdAjouter)
        Me.GroupBoxConge.Controls.Add(Me.cbxTypeConge)
        Me.GroupBoxConge.Controls.Add(Me.DateReprise)
        Me.GroupBoxConge.Controls.Add(Me.DateDebut)
        Me.GroupBoxConge.Controls.Add(Me.txtDuree)
        Me.GroupBoxConge.Controls.Add(Me.txtMatriculeC)
        Me.GroupBoxConge.Controls.Add(Me.MetroLabel6)
        Me.GroupBoxConge.Controls.Add(Me.MetroLabel5)
        Me.GroupBoxConge.Controls.Add(Me.MetroLabel4)
        Me.GroupBoxConge.Controls.Add(Me.MetroLabel2)
        Me.GroupBoxConge.Controls.Add(Me.lblMatricule)
        Me.GroupBoxConge.Location = New System.Drawing.Point(749, 88)
        Me.GroupBoxConge.Name = "GroupBoxConge"
        Me.GroupBoxConge.Size = New System.Drawing.Size(341, 482)
        Me.GroupBoxConge.TabIndex = 23
        Me.GroupBoxConge.TabStop = False
        Me.GroupBoxConge.Text = "Demande de congé"
        '
        'pnlSwitchC
        '
        Me.pnlSwitchC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSwitchC.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlSwitchC.Controls.Add(Me.btnConge)
        Me.pnlSwitchC.Controls.Add(Me.btnPerso)
        Me.pnlSwitchC.Controls.Add(Me.lnkBack)
        Me.pnlSwitchC.HorizontalScrollbarBarColor = True
        Me.pnlSwitchC.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlSwitchC.HorizontalScrollbarSize = 10
        Me.pnlSwitchC.Location = New System.Drawing.Point(420, 172)
        Me.pnlSwitchC.Name = "pnlSwitchC"
        Me.pnlSwitchC.Size = New System.Drawing.Size(200, 236)
        Me.pnlSwitchC.TabIndex = 37
        Me.pnlSwitchC.UseCustomBackColor = True
        Me.pnlSwitchC.VerticalScrollbarBarColor = True
        Me.pnlSwitchC.VerticalScrollbarHighlightOnWheel = False
        Me.pnlSwitchC.VerticalScrollbarSize = 10
        '
        'btnConge
        '
        Me.btnConge.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnConge.ForeColor = System.Drawing.Color.White
        Me.btnConge.Location = New System.Drawing.Point(33, 127)
        Me.btnConge.Name = "btnConge"
        Me.btnConge.Size = New System.Drawing.Size(134, 38)
        Me.btnConge.TabIndex = 35
        Me.btnConge.Text = "Congé"
        Me.btnConge.UseCustomBackColor = True
        Me.btnConge.UseCustomForeColor = True
        Me.btnConge.UseSelectable = True
        '
        'btnPerso
        '
        Me.btnPerso.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnPerso.ForeColor = System.Drawing.Color.White
        Me.btnPerso.Location = New System.Drawing.Point(33, 71)
        Me.btnPerso.Name = "btnPerso"
        Me.btnPerso.Size = New System.Drawing.Size(134, 38)
        Me.btnPerso.TabIndex = 34
        Me.btnPerso.Text = "Personnel"
        Me.btnPerso.UseCustomBackColor = True
        Me.btnPerso.UseCustomForeColor = True
        Me.btnPerso.UseSelectable = True
        '
        'lnkBack
        '
        Me.lnkBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkBack.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.lnkBack.Image = CType(resources.GetObject("lnkBack.Image"), System.Drawing.Image)
        Me.lnkBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkBack.ImageSize = 30
        Me.lnkBack.Location = New System.Drawing.Point(6, 2)
        Me.lnkBack.Name = "lnkBack"
        Me.lnkBack.NoFocusImage = CType(resources.GetObject("lnkBack.NoFocusImage"), System.Drawing.Image)
        Me.lnkBack.Size = New System.Drawing.Size(30, 34)
        Me.lnkBack.TabIndex = 33
        Me.lnkBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lnkBack.UseCustomBackColor = True
        Me.lnkBack.UseSelectable = True
        '
        'btnSwitch
        '
        Me.btnSwitch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSwitch.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.btnSwitch.Image = CType(resources.GetObject("btnSwitch.Image"), System.Drawing.Image)
        Me.btnSwitch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSwitch.ImageSize = 30
        Me.btnSwitch.Location = New System.Drawing.Point(1015, 592)
        Me.btnSwitch.Name = "btnSwitch"
        Me.btnSwitch.NoFocusImage = CType(resources.GetObject("btnSwitch.NoFocusImage"), System.Drawing.Image)
        Me.btnSwitch.Size = New System.Drawing.Size(32, 34)
        Me.btnSwitch.TabIndex = 36
        Me.btnSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSwitch.UseSelectable = True
        '
        'myUXStyle
        '
        Me.myUXStyle.Owner = Me
        '
        'GridConge
        '
        Me.GridConge.AllowUserToAddRows = False
        Me.GridConge.AllowUserToDeleteRows = False
        Me.GridConge.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Turquoise
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.GridConge.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridConge.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridConge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridConge.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GridConge.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridConge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridConge.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.GridConge.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridConge.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridConge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridConge.DefaultCellStyle = DataGridViewCellStyle3
        Me.GridConge.EnableHeadersVisualStyles = False
        Me.GridConge.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.GridConge.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridConge.Location = New System.Drawing.Point(23, 88)
        Me.GridConge.Name = "GridConge"
        Me.GridConge.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridConge.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GridConge.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Turquoise
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.GridConge.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.GridConge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridConge.Size = New System.Drawing.Size(700, 498)
        Me.GridConge.TabIndex = 38
        Me.GridConge.UseCustomBackColor = True
        Me.GridConge.UseCustomForeColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtCongeNum
        '
        '
        '
        '
        Me.txtCongeNum.CustomButton.Image = Nothing
        Me.txtCongeNum.CustomButton.Location = New System.Drawing.Point(56, 2)
        Me.txtCongeNum.CustomButton.Name = ""
        Me.txtCongeNum.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtCongeNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCongeNum.CustomButton.TabIndex = 1
        Me.txtCongeNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCongeNum.CustomButton.UseSelectable = True
        Me.txtCongeNum.CustomButton.Visible = False
        Me.txtCongeNum.Lines = New String(-1) {}
        Me.txtCongeNum.Location = New System.Drawing.Point(45, 379)
        Me.txtCongeNum.MaxLength = 8
        Me.txtCongeNum.Name = "txtCongeNum"
        Me.txtCongeNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCongeNum.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCongeNum.SelectedText = ""
        Me.txtCongeNum.SelectionLength = 0
        Me.txtCongeNum.SelectionStart = 0
        Me.txtCongeNum.ShortcutsEnabled = True
        Me.txtCongeNum.Size = New System.Drawing.Size(84, 30)
        Me.txtCongeNum.TabIndex = 10
        Me.txtCongeNum.UseSelectable = True
        Me.txtCongeNum.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCongeNum.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'CongeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 640)
        Me.Controls.Add(Me.pnlSwitchC)
        Me.Controls.Add(Me.GroupBoxConge)
        Me.Controls.Add(Me.btnSwitch)
        Me.Controls.Add(Me.GridConge)
        Me.Name = "CongeForm"
        Me.Text = "CongeForm"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.GroupBoxConge.ResumeLayout(False)
        Me.GroupBoxConge.PerformLayout()
        Me.pnlSwitchC.ResumeLayout(False)
        CType(Me.myUXStyle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridConge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents checkAnnuler As System.Windows.Forms.CheckBox
    Friend WithEvents cmdAppliquer As MetroFramework.Controls.MetroButton
    Friend WithEvents cmdAjouter As MetroFramework.Controls.MetroButton
    Friend WithEvents cbxTypeConge As MetroFramework.Controls.MetroComboBox
    Friend WithEvents DateReprise As MetroFramework.Controls.MetroDateTime
    Friend WithEvents DateDebut As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtDuree As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMatriculeC As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblMatricule As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBoxConge As System.Windows.Forms.GroupBox
    Friend WithEvents btnSwitch As MetroFramework.Controls.MetroLink
    Friend WithEvents pnlSwitchC As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnConge As MetroFramework.Controls.MetroButton
    Friend WithEvents lnkBack As MetroFramework.Controls.MetroLink
    Friend WithEvents btnPerso As MetroFramework.Controls.MetroButton
    Public WithEvents myUXStyle As MetroFramework.Components.MetroStyleManager
    Friend WithEvents GridConge As MetroFramework.Controls.MetroGrid
    Friend WithEvents txtCongeNum As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
End Class
