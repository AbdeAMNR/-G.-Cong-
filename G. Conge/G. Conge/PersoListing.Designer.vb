<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersoListing
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PersoListing))
        Me.lblRecherche = New MetroFramework.Controls.MetroLabel()
        Me.cbxSearch = New MetroFramework.Controls.MetroComboBox()
        Me.GridPersonnel = New MetroFramework.Controls.MetroGrid()
        Me.CmdSearch = New MetroFramework.Controls.MetroButton()
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.lnkGérer = New MetroFramework.Controls.MetroLink()
        Me.lnkActualiser = New MetroFramework.Controls.MetroLink()
        Me.myUXStyle = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.btnSwitch = New MetroFramework.Controls.MetroLink()
        Me.lnkBack = New MetroFramework.Controls.MetroLink()
        Me.cbxOnly = New MetroFramework.Controls.MetroComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlSwitch = New MetroFramework.Controls.MetroPanel()
        Me.btnConge = New MetroFramework.Controls.MetroButton()
        Me.btnPerso = New MetroFramework.Controls.MetroButton()
        CType(Me.GridPersonnel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.myUXStyle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSwitch.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRecherche
        '
        Me.lblRecherche.AutoSize = True
        Me.lblRecherche.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblRecherche.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblRecherche.Location = New System.Drawing.Point(302, 85)
        Me.lblRecherche.Name = "lblRecherche"
        Me.lblRecherche.Size = New System.Drawing.Size(89, 15)
        Me.lblRecherche.TabIndex = 31
        Me.lblRecherche.Text = "Recherche avec"
        '
        'cbxSearch
        '
        Me.cbxSearch.FormattingEnabled = True
        Me.cbxSearch.ItemHeight = 23
        Me.cbxSearch.Items.AddRange(New Object() {"Matricule", "Nom_Prenom", "CIN_Perso", "Tele_Portable"})
        Me.cbxSearch.Location = New System.Drawing.Point(302, 103)
        Me.cbxSearch.Name = "cbxSearch"
        Me.cbxSearch.Size = New System.Drawing.Size(157, 29)
        Me.cbxSearch.TabIndex = 24
        Me.cbxSearch.UseSelectable = True
        '
        'GridPersonnel
        '
        Me.GridPersonnel.AllowUserToAddRows = False
        Me.GridPersonnel.AllowUserToDeleteRows = False
        Me.GridPersonnel.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Turquoise
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.GridPersonnel.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridPersonnel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPersonnel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridPersonnel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GridPersonnel.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridPersonnel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridPersonnel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.GridPersonnel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridPersonnel.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridPersonnel.DefaultCellStyle = DataGridViewCellStyle3
        Me.GridPersonnel.EnableHeadersVisualStyles = False
        Me.GridPersonnel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.GridPersonnel.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridPersonnel.Location = New System.Drawing.Point(45, 144)
        Me.GridPersonnel.Name = "GridPersonnel"
        Me.GridPersonnel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridPersonnel.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GridPersonnel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Turquoise
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.GridPersonnel.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.GridPersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridPersonnel.Size = New System.Drawing.Size(1002, 397)
        Me.GridPersonnel.TabIndex = 30
        Me.GridPersonnel.UseCustomBackColor = True
        Me.GridPersonnel.UseCustomForeColor = True
        '
        'CmdSearch
        '
        Me.CmdSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CmdSearch.BackgroundImage = CType(resources.GetObject("CmdSearch.BackgroundImage"), System.Drawing.Image)
        Me.CmdSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CmdSearch.Location = New System.Drawing.Point(746, 103)
        Me.CmdSearch.Name = "CmdSearch"
        Me.CmdSearch.Size = New System.Drawing.Size(29, 29)
        Me.CmdSearch.TabIndex = 26
        Me.CmdSearch.UseSelectable = True
        '
        'txtSearch
        '
        '
        '
        '
        Me.txtSearch.CustomButton.Image = Nothing
        Me.txtSearch.CustomButton.Location = New System.Drawing.Point(249, 1)
        Me.txtSearch.CustomButton.Name = ""
        Me.txtSearch.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearch.CustomButton.TabIndex = 1
        Me.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearch.CustomButton.UseSelectable = True
        Me.txtSearch.CustomButton.Visible = False
        Me.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(465, 103)
        Me.txtSearch.MaxLength = 100
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PromptText = "Recherche"
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShortcutsEnabled = True
        Me.txtSearch.Size = New System.Drawing.Size(277, 29)
        Me.txtSearch.TabIndex = 25
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.WaterMark = "Recherche"
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lnkGérer
        '
        Me.lnkGérer.Image = CType(resources.GetObject("lnkGérer.Image"), System.Drawing.Image)
        Me.lnkGérer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkGérer.ImageSize = 32
        Me.lnkGérer.Location = New System.Drawing.Point(132, 103)
        Me.lnkGérer.Name = "lnkGérer"
        Me.lnkGérer.Size = New System.Drawing.Size(73, 29)
        Me.lnkGérer.TabIndex = 22
        Me.lnkGérer.Text = "Gérer"
        Me.lnkGérer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lnkGérer.UseSelectable = True
        '
        'lnkActualiser
        '
        Me.lnkActualiser.Image = CType(resources.GetObject("lnkActualiser.Image"), System.Drawing.Image)
        Me.lnkActualiser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkActualiser.ImageSize = 27
        Me.lnkActualiser.Location = New System.Drawing.Point(208, 103)
        Me.lnkActualiser.Margin = New System.Windows.Forms.Padding(0)
        Me.lnkActualiser.Name = "lnkActualiser"
        Me.lnkActualiser.Size = New System.Drawing.Size(91, 29)
        Me.lnkActualiser.TabIndex = 23
        Me.lnkActualiser.Text = "Actualiser"
        Me.lnkActualiser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lnkActualiser.UseSelectable = True
        '
        'myUXStyle
        '
        Me.myUXStyle.Owner = Me
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
        Me.btnSwitch.TabIndex = 32
        Me.btnSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSwitch.UseSelectable = True
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
        'cbxOnly
        '
        Me.cbxOnly.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbxOnly.FormattingEnabled = True
        Me.cbxOnly.ItemHeight = 23
        Me.cbxOnly.Items.AddRange(New Object() {"5", "10", "20", "40", "80", "160"})
        Me.cbxOnly.Location = New System.Drawing.Point(23, 592)
        Me.cbxOnly.Name = "cbxOnly"
        Me.cbxOnly.Size = New System.Drawing.Size(66, 29)
        Me.cbxOnly.TabIndex = 34
        Me.cbxOnly.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 575)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Sélectionnez"
        '
        'pnlSwitch
        '
        Me.pnlSwitch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSwitch.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlSwitch.Controls.Add(Me.btnConge)
        Me.pnlSwitch.Controls.Add(Me.lnkBack)
        Me.pnlSwitch.Controls.Add(Me.btnPerso)
        Me.pnlSwitch.HorizontalScrollbarBarColor = True
        Me.pnlSwitch.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlSwitch.HorizontalScrollbarSize = 10
        Me.pnlSwitch.Location = New System.Drawing.Point(892, 404)
        Me.pnlSwitch.Name = "pnlSwitch"
        Me.pnlSwitch.Size = New System.Drawing.Size(200, 236)
        Me.pnlSwitch.TabIndex = 36
        Me.pnlSwitch.UseCustomBackColor = True
        Me.pnlSwitch.VerticalScrollbarBarColor = True
        Me.pnlSwitch.VerticalScrollbarHighlightOnWheel = False
        Me.pnlSwitch.VerticalScrollbarSize = 10
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
        'PersoListing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 640)
        Me.Controls.Add(Me.pnlSwitch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxOnly)
        Me.Controls.Add(Me.btnSwitch)
        Me.Controls.Add(Me.lblRecherche)
        Me.Controls.Add(Me.cbxSearch)
        Me.Controls.Add(Me.GridPersonnel)
        Me.Controls.Add(Me.CmdSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lnkGérer)
        Me.Controls.Add(Me.lnkActualiser)
        Me.Name = "PersoListing"
        Me.Text = "Liste des personnels"
        CType(Me.GridPersonnel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.myUXStyle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSwitch.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRecherche As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbxSearch As MetroFramework.Controls.MetroComboBox
    Friend WithEvents GridPersonnel As MetroFramework.Controls.MetroGrid
    Friend WithEvents CmdSearch As MetroFramework.Controls.MetroButton
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lnkGérer As MetroFramework.Controls.MetroLink
    Friend WithEvents lnkActualiser As MetroFramework.Controls.MetroLink
    Public WithEvents myUXStyle As MetroFramework.Components.MetroStyleManager
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxOnly As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnSwitch As MetroFramework.Controls.MetroLink
    Friend WithEvents lnkBack As MetroFramework.Controls.MetroLink
    Friend WithEvents pnlSwitch As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnPerso As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConge As MetroFramework.Controls.MetroButton
End Class
