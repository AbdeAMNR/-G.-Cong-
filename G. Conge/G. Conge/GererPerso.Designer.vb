<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GererPerso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GererPerso))
        Me.btnMettreAjour = New MetroFramework.Controls.MetroButton()
        Me.bntSupprimer = New MetroFramework.Controls.MetroButton()
        Me.bntCreer = New MetroFramework.Controls.MetroButton()
        Me.cbxNbrEnfants = New MetroFramework.Controls.MetroComboBox()
        Me.cbxGenreP = New MetroFramework.Controls.MetroComboBox()
        Me.dTimeRecrutement = New MetroFramework.Controls.MetroDateTime()
        Me.dTimeNaissance = New MetroFramework.Controls.MetroDateTime()
        Me.ToolTipCreer = New MetroFramework.Components.MetroToolTip()
        Me.ToolTipSupprimer = New MetroFramework.Components.MetroToolTip()
        Me.ToolTipMettreAjour = New MetroFramework.Components.MetroToolTip()
        Me.lnkClear = New MetroFramework.Controls.MetroLink()
        Me.lblSuccess = New MetroFramework.Controls.MetroLabel()
        Me.btnAnnulerP = New MetroFramework.Controls.MetroButton()
        Me.ToolTipClearAll = New MetroFramework.Components.MetroToolTip()
        Me.txtDiplome = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.txtPortable = New MetroFramework.Controls.MetroTextBox()
        Me.txtNaissanceP = New MetroFramework.Controls.MetroTextBox()
        Me.txtAdresse = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtCinP = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtNomP = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.txtMatriculeP = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.myUXStyle = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.cbxSituation = New MetroFramework.Controls.MetroComboBox()
        Me.cbxService = New MetroFramework.Controls.MetroComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.myUXStyle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMettreAjour
        '
        Me.btnMettreAjour.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnMettreAjour.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnMettreAjour.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMettreAjour.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnMettreAjour.ForeColor = System.Drawing.Color.White
        Me.btnMettreAjour.Location = New System.Drawing.Point(447, 346)
        Me.btnMettreAjour.Name = "btnMettreAjour"
        Me.btnMettreAjour.Size = New System.Drawing.Size(127, 44)
        Me.btnMettreAjour.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnMettreAjour.TabIndex = 60
        Me.btnMettreAjour.Text = "Mettre à jour"
        Me.btnMettreAjour.UseCustomBackColor = True
        Me.btnMettreAjour.UseCustomForeColor = True
        Me.btnMettreAjour.UseSelectable = True
        '
        'bntSupprimer
        '
        Me.bntSupprimer.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bntSupprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bntSupprimer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntSupprimer.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.bntSupprimer.ForeColor = System.Drawing.Color.White
        Me.bntSupprimer.Location = New System.Drawing.Point(304, 346)
        Me.bntSupprimer.Name = "bntSupprimer"
        Me.bntSupprimer.Size = New System.Drawing.Size(127, 44)
        Me.bntSupprimer.Style = MetroFramework.MetroColorStyle.Blue
        Me.bntSupprimer.TabIndex = 59
        Me.bntSupprimer.Text = "Supprimer"
        Me.bntSupprimer.UseCustomBackColor = True
        Me.bntSupprimer.UseCustomForeColor = True
        Me.bntSupprimer.UseSelectable = True
        '
        'bntCreer
        '
        Me.bntCreer.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bntCreer.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.bntCreer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bntCreer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntCreer.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.bntCreer.ForeColor = System.Drawing.Color.White
        Me.bntCreer.Location = New System.Drawing.Point(161, 346)
        Me.bntCreer.Name = "bntCreer"
        Me.bntCreer.Size = New System.Drawing.Size(127, 44)
        Me.bntCreer.Style = MetroFramework.MetroColorStyle.Blue
        Me.bntCreer.TabIndex = 57
        Me.bntCreer.Text = "Créer"
        Me.bntCreer.UseCustomBackColor = True
        Me.bntCreer.UseCustomForeColor = True
        Me.bntCreer.UseSelectable = True
        '
        'cbxNbrEnfants
        '
        Me.cbxNbrEnfants.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbxNbrEnfants.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxNbrEnfants.FontWeight = MetroFramework.MetroComboBoxWeight.Bold
        Me.cbxNbrEnfants.FormattingEnabled = True
        Me.cbxNbrEnfants.ItemHeight = 23
        Me.cbxNbrEnfants.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.cbxNbrEnfants.Location = New System.Drawing.Point(710, 283)
        Me.cbxNbrEnfants.Name = "cbxNbrEnfants"
        Me.cbxNbrEnfants.Size = New System.Drawing.Size(85, 29)
        Me.cbxNbrEnfants.TabIndex = 54
        Me.cbxNbrEnfants.UseSelectable = True
        '
        'cbxGenreP
        '
        Me.cbxGenreP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbxGenreP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxGenreP.FontWeight = MetroFramework.MetroComboBoxWeight.Bold
        Me.cbxGenreP.FormattingEnabled = True
        Me.cbxGenreP.ItemHeight = 23
        Me.cbxGenreP.Items.AddRange(New Object() {"Homme", "Femme"})
        Me.cbxGenreP.Location = New System.Drawing.Point(172, 145)
        Me.cbxGenreP.Name = "cbxGenreP"
        Me.cbxGenreP.Size = New System.Drawing.Size(85, 29)
        Me.cbxGenreP.TabIndex = 46
        Me.cbxGenreP.UseSelectable = True
        '
        'dTimeRecrutement
        '
        Me.dTimeRecrutement.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dTimeRecrutement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dTimeRecrutement.Location = New System.Drawing.Point(3, 145)
        Me.dTimeRecrutement.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dTimeRecrutement.Name = "dTimeRecrutement"
        Me.dTimeRecrutement.Size = New System.Drawing.Size(223, 29)
        Me.dTimeRecrutement.TabIndex = 51
        '
        'dTimeNaissance
        '
        Me.dTimeNaissance.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dTimeNaissance.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.dTimeNaissance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dTimeNaissance.Location = New System.Drawing.Point(3, 88)
        Me.dTimeNaissance.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dTimeNaissance.Name = "dTimeNaissance"
        Me.dTimeNaissance.Size = New System.Drawing.Size(223, 29)
        Me.dTimeNaissance.TabIndex = 47
        '
        'ToolTipCreer
        '
        Me.ToolTipCreer.Style = MetroFramework.MetroColorStyle.Blue
        Me.ToolTipCreer.StyleManager = Nothing
        Me.ToolTipCreer.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'ToolTipSupprimer
        '
        Me.ToolTipSupprimer.Style = MetroFramework.MetroColorStyle.Blue
        Me.ToolTipSupprimer.StyleManager = Nothing
        Me.ToolTipSupprimer.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'ToolTipMettreAjour
        '
        Me.ToolTipMettreAjour.Style = MetroFramework.MetroColorStyle.Blue
        Me.ToolTipMettreAjour.StyleManager = Nothing
        Me.ToolTipMettreAjour.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'lnkClear
        '
        Me.lnkClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lnkClear.BackColor = System.Drawing.Color.White
        Me.lnkClear.Image = CType(resources.GetObject("lnkClear.Image"), System.Drawing.Image)
        Me.lnkClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkClear.ImageSize = 25
        Me.lnkClear.Location = New System.Drawing.Point(123, 346)
        Me.lnkClear.Name = "lnkClear"
        Me.lnkClear.NoFocusImage = CType(resources.GetObject("lnkClear.NoFocusImage"), System.Drawing.Image)
        Me.lnkClear.Size = New System.Drawing.Size(32, 44)
        Me.lnkClear.TabIndex = 58
        Me.lnkClear.UseCustomForeColor = True
        Me.lnkClear.UseSelectable = True
        '
        'lblSuccess
        '
        Me.lblSuccess.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSuccess.AutoSize = True
        Me.lblSuccess.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblSuccess.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblSuccess.ForeColor = System.Drawing.Color.Green
        Me.lblSuccess.Location = New System.Drawing.Point(18, 410)
        Me.lblSuccess.Name = "lblSuccess"
        Me.lblSuccess.Size = New System.Drawing.Size(215, 15)
        Me.lblSuccess.TabIndex = 62
        Me.lblSuccess.Text = "Le personnel a été ajouté avec succès"
        Me.lblSuccess.UseCustomForeColor = True
        '
        'btnAnnulerP
        '
        Me.btnAnnulerP.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAnnulerP.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAnnulerP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnulerP.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnAnnulerP.ForeColor = System.Drawing.Color.White
        Me.btnAnnulerP.Location = New System.Drawing.Point(590, 346)
        Me.btnAnnulerP.Name = "btnAnnulerP"
        Me.btnAnnulerP.Size = New System.Drawing.Size(127, 44)
        Me.btnAnnulerP.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnAnnulerP.TabIndex = 61
        Me.btnAnnulerP.Text = "Annuler"
        Me.btnAnnulerP.UseCustomBackColor = True
        Me.btnAnnulerP.UseCustomForeColor = True
        Me.btnAnnulerP.UseSelectable = True
        '
        'ToolTipClearAll
        '
        Me.ToolTipClearAll.Style = MetroFramework.MetroColorStyle.Blue
        Me.ToolTipClearAll.StyleManager = Nothing
        Me.ToolTipClearAll.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'txtDiplome
        '
        Me.txtDiplome.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtDiplome.CustomButton.Image = Nothing
        Me.txtDiplome.CustomButton.Location = New System.Drawing.Point(195, 1)
        Me.txtDiplome.CustomButton.Name = ""
        Me.txtDiplome.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtDiplome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDiplome.CustomButton.TabIndex = 1
        Me.txtDiplome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDiplome.CustomButton.UseSelectable = True
        Me.txtDiplome.CustomButton.Visible = False
        Me.txtDiplome.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtDiplome.Lines = New String(-1) {}
        Me.txtDiplome.Location = New System.Drawing.Point(3, 31)
        Me.txtDiplome.MaxLength = 32767
        Me.txtDiplome.Name = "txtDiplome"
        Me.txtDiplome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDiplome.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDiplome.SelectedText = ""
        Me.txtDiplome.SelectionLength = 0
        Me.txtDiplome.SelectionStart = 0
        Me.txtDiplome.ShortcutsEnabled = True
        Me.txtDiplome.Size = New System.Drawing.Size(223, 29)
        Me.txtDiplome.TabIndex = 50
        Me.txtDiplome.UseSelectable = True
        Me.txtDiplome.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDiplome.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel11
        '
        Me.MetroLabel11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel11.Location = New System.Drawing.Point(3, 13)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(52, 15)
        Me.MetroLabel11.TabIndex = 29
        Me.MetroLabel11.Text = "Diplôme"
        '
        'txtPortable
        '
        Me.txtPortable.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtPortable.CustomButton.Image = Nothing
        Me.txtPortable.CustomButton.Location = New System.Drawing.Point(135, 1)
        Me.txtPortable.CustomButton.Name = ""
        Me.txtPortable.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtPortable.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPortable.CustomButton.TabIndex = 1
        Me.txtPortable.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPortable.CustomButton.UseSelectable = True
        Me.txtPortable.CustomButton.Visible = False
        Me.txtPortable.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPortable.Lines = New String(-1) {}
        Me.txtPortable.Location = New System.Drawing.Point(3, 146)
        Me.txtPortable.MaxLength = 32767
        Me.txtPortable.Name = "txtPortable"
        Me.txtPortable.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPortable.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPortable.SelectedText = ""
        Me.txtPortable.SelectionLength = 0
        Me.txtPortable.SelectionStart = 0
        Me.txtPortable.ShortcutsEnabled = True
        Me.txtPortable.Size = New System.Drawing.Size(163, 29)
        Me.txtPortable.TabIndex = 56
        Me.txtPortable.UseSelectable = True
        Me.txtPortable.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPortable.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNaissanceP
        '
        Me.txtNaissanceP.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtNaissanceP.CustomButton.Image = Nothing
        Me.txtNaissanceP.CustomButton.Location = New System.Drawing.Point(226, 1)
        Me.txtNaissanceP.CustomButton.Name = ""
        Me.txtNaissanceP.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtNaissanceP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNaissanceP.CustomButton.TabIndex = 1
        Me.txtNaissanceP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNaissanceP.CustomButton.UseSelectable = True
        Me.txtNaissanceP.CustomButton.Visible = False
        Me.txtNaissanceP.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNaissanceP.Lines = New String(-1) {}
        Me.txtNaissanceP.Location = New System.Drawing.Point(3, 31)
        Me.txtNaissanceP.MaxLength = 32767
        Me.txtNaissanceP.Name = "txtNaissanceP"
        Me.txtNaissanceP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNaissanceP.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNaissanceP.SelectedText = ""
        Me.txtNaissanceP.SelectionLength = 0
        Me.txtNaissanceP.SelectionStart = 0
        Me.txtNaissanceP.ShortcutsEnabled = True
        Me.txtNaissanceP.Size = New System.Drawing.Size(254, 29)
        Me.txtNaissanceP.TabIndex = 48
        Me.txtNaissanceP.UseSelectable = True
        Me.txtNaissanceP.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNaissanceP.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtAdresse
        '
        Me.txtAdresse.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtAdresse.CustomButton.Image = Nothing
        Me.txtAdresse.CustomButton.Location = New System.Drawing.Point(226, 1)
        Me.txtAdresse.CustomButton.Name = ""
        Me.txtAdresse.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtAdresse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAdresse.CustomButton.TabIndex = 1
        Me.txtAdresse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAdresse.CustomButton.UseSelectable = True
        Me.txtAdresse.CustomButton.Visible = False
        Me.txtAdresse.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtAdresse.Lines = New String(-1) {}
        Me.txtAdresse.Location = New System.Drawing.Point(3, 89)
        Me.txtAdresse.MaxLength = 32767
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdresse.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAdresse.SelectedText = ""
        Me.txtAdresse.SelectionLength = 0
        Me.txtAdresse.SelectionStart = 0
        Me.txtAdresse.ShortcutsEnabled = True
        Me.txtAdresse.Size = New System.Drawing.Size(254, 29)
        Me.txtAdresse.TabIndex = 52
        Me.txtAdresse.UseSelectable = True
        Me.txtAdresse.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAdresse.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel12
        '
        Me.MetroLabel12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel12.Location = New System.Drawing.Point(3, 125)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(115, 15)
        Me.MetroLabel12.TabIndex = 37
        Me.MetroLabel12.Text = "Date de recrutement"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel7.Location = New System.Drawing.Point(3, 14)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(99, 15)
        Me.MetroLabel7.TabIndex = 36
        Me.MetroLabel7.Text = "Lieu de naissance"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel6.Location = New System.Drawing.Point(3, 69)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(111, 15)
        Me.MetroLabel6.TabIndex = 35
        Me.MetroLabel6.Text = "Année de naissance"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(3, 71)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(48, 15)
        Me.MetroLabel5.TabIndex = 34
        Me.MetroLabel5.Text = "Adresse"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(172, 124)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(38, 15)
        Me.MetroLabel4.TabIndex = 33
        Me.MetroLabel4.Text = "Genre"
        '
        'txtCinP
        '
        Me.txtCinP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCinP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtCinP.CustomButton.Image = Nothing
        Me.txtCinP.CustomButton.Location = New System.Drawing.Point(142, 1)
        Me.txtCinP.CustomButton.Name = ""
        Me.txtCinP.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtCinP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCinP.CustomButton.TabIndex = 1
        Me.txtCinP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCinP.CustomButton.UseSelectable = True
        Me.txtCinP.CustomButton.Visible = False
        Me.txtCinP.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtCinP.Lines = New String(-1) {}
        Me.txtCinP.Location = New System.Drawing.Point(15, 145)
        Me.txtCinP.MaxLength = 32767
        Me.txtCinP.Name = "txtCinP"
        Me.txtCinP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCinP.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCinP.SelectedText = ""
        Me.txtCinP.SelectionLength = 0
        Me.txtCinP.SelectionStart = 0
        Me.txtCinP.ShortcutsEnabled = True
        Me.txtCinP.Size = New System.Drawing.Size(170, 29)
        Me.txtCinP.TabIndex = 45
        Me.txtCinP.UseSelectable = True
        Me.txtCinP.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCinP.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(15, 125)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(27, 15)
        Me.MetroLabel3.TabIndex = 32
        Me.MetroLabel3.Text = "CIN"
        '
        'txtNomP
        '
        Me.txtNomP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNomP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtNomP.CustomButton.Image = Nothing
        Me.txtNomP.CustomButton.Location = New System.Drawing.Point(142, 1)
        Me.txtNomP.CustomButton.Name = ""
        Me.txtNomP.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtNomP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNomP.CustomButton.TabIndex = 1
        Me.txtNomP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNomP.CustomButton.UseSelectable = True
        Me.txtNomP.CustomButton.Visible = False
        Me.txtNomP.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNomP.Lines = New String(-1) {}
        Me.txtNomP.Location = New System.Drawing.Point(15, 88)
        Me.txtNomP.MaxLength = 32767
        Me.txtNomP.Name = "txtNomP"
        Me.txtNomP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNomP.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNomP.SelectedText = ""
        Me.txtNomP.SelectionLength = 0
        Me.txtNomP.SelectionStart = 0
        Me.txtNomP.ShortcutsEnabled = True
        Me.txtNomP.Size = New System.Drawing.Size(170, 29)
        Me.txtNomP.TabIndex = 44
        Me.txtNomP.UseSelectable = True
        Me.txtNomP.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNomP.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(15, 69)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(79, 15)
        Me.MetroLabel2.TabIndex = 31
        Me.MetroLabel2.Text = "Nom Prenom"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel10.Location = New System.Drawing.Point(710, 262)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(85, 15)
        Me.MetroLabel10.TabIndex = 30
        Me.MetroLabel10.Text = "Nbr de enfants"
        '
        'txtMatriculeP
        '
        Me.txtMatriculeP.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtMatriculeP.CustomButton.Image = Nothing
        Me.txtMatriculeP.CustomButton.Location = New System.Drawing.Point(142, 1)
        Me.txtMatriculeP.CustomButton.Name = ""
        Me.txtMatriculeP.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtMatriculeP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMatriculeP.CustomButton.TabIndex = 1
        Me.txtMatriculeP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMatriculeP.CustomButton.UseSelectable = True
        Me.txtMatriculeP.CustomButton.Visible = False
        Me.txtMatriculeP.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtMatriculeP.Lines = New String(-1) {}
        Me.txtMatriculeP.Location = New System.Drawing.Point(15, 31)
        Me.txtMatriculeP.MaxLength = 8
        Me.txtMatriculeP.Name = "txtMatriculeP"
        Me.txtMatriculeP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMatriculeP.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMatriculeP.SelectedText = ""
        Me.txtMatriculeP.SelectionLength = 0
        Me.txtMatriculeP.SelectionStart = 0
        Me.txtMatriculeP.ShortcutsEnabled = True
        Me.txtMatriculeP.Size = New System.Drawing.Size(170, 29)
        Me.txtMatriculeP.TabIndex = 43
        Me.txtMatriculeP.UseSelectable = True
        Me.txtMatriculeP.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMatriculeP.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel9
        '
        Me.MetroLabel9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel9.Location = New System.Drawing.Point(11, 183)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(102, 15)
        Me.MetroLabel9.TabIndex = 41
        Me.MetroLabel9.Text = "Situation familiale"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(15, 13)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(57, 15)
        Me.MetroLabel1.TabIndex = 42
        Me.MetroLabel1.Text = "Matricule"
        '
        'myUXStyle
        '
        Me.myUXStyle.Owner = Me
        '
        'MetroLabel8
        '
        Me.MetroLabel8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel8.Location = New System.Drawing.Point(3, 127)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(62, 15)
        Me.MetroLabel8.TabIndex = 66
        Me.MetroLabel8.Text = "Telephone"
        '
        'MetroLabel13
        '
        Me.MetroLabel13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel13.Location = New System.Drawing.Point(254, 265)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(95, 15)
        Me.MetroLabel13.TabIndex = 67
        Me.MetroLabel13.Text = "Service de travail"
        '
        'cbxSituation
        '
        Me.cbxSituation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbxSituation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxSituation.FontWeight = MetroFramework.MetroComboBoxWeight.Bold
        Me.cbxSituation.FormattingEnabled = True
        Me.cbxSituation.ItemHeight = 23
        Me.cbxSituation.Items.AddRange(New Object() {"Célibataire", "Marié"})
        Me.cbxSituation.Location = New System.Drawing.Point(15, 202)
        Me.cbxSituation.Name = "cbxSituation"
        Me.cbxSituation.Size = New System.Drawing.Size(170, 29)
        Me.cbxSituation.TabIndex = 73
        Me.cbxSituation.UseSelectable = True
        '
        'cbxService
        '
        Me.cbxService.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbxService.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxService.FontWeight = MetroFramework.MetroComboBoxWeight.Bold
        Me.cbxService.FormattingEnabled = True
        Me.cbxService.ItemHeight = 23
        Me.cbxService.Items.AddRange(New Object() {"Légalisation de signature bureau central", "Directeur général des services", "Service des affaires économiques sociales et culturelles", "Légalisation de signature Annexe Ikhourbane", "Ressources humaines", "Etat civil bureau central", "Service travaux communaux", "Contrôle fiscal", "Assiette fiscale", "Service urbanisme et de plan", "Comptabilité et exécution de budget", "Service achat", "Secrétariat de conseil et activité des commissions salaire", "Régie de dépense", "Service des patrimoines", "Parc communal"})
        Me.cbxService.Location = New System.Drawing.Point(254, 283)
        Me.cbxService.Name = "cbxService"
        Me.cbxService.Size = New System.Drawing.Size(450, 29)
        Me.cbxService.TabIndex = 74
        Me.cbxService.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.MetroLabel1)
        Me.Panel1.Controls.Add(Me.MetroLabel9)
        Me.Panel1.Controls.Add(Me.cbxSituation)
        Me.Panel1.Controls.Add(Me.txtMatriculeP)
        Me.Panel1.Controls.Add(Me.MetroLabel2)
        Me.Panel1.Controls.Add(Me.txtNomP)
        Me.Panel1.Controls.Add(Me.MetroLabel3)
        Me.Panel1.Controls.Add(Me.txtCinP)
        Me.Panel1.Location = New System.Drawing.Point(23, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(194, 259)
        Me.Panel1.TabIndex = 75
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.MetroLabel11)
        Me.Panel2.Controls.Add(Me.txtDiplome)
        Me.Panel2.Controls.Add(Me.MetroLabel6)
        Me.Panel2.Controls.Add(Me.dTimeRecrutement)
        Me.Panel2.Controls.Add(Me.dTimeNaissance)
        Me.Panel2.Controls.Add(Me.MetroLabel12)
        Me.Panel2.Location = New System.Drawing.Point(251, 81)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(253, 184)
        Me.Panel2.TabIndex = 76
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.MetroLabel7)
        Me.Panel3.Controls.Add(Me.txtNaissanceP)
        Me.Panel3.Controls.Add(Me.txtPortable)
        Me.Panel3.Controls.Add(Me.MetroLabel5)
        Me.Panel3.Controls.Add(Me.MetroLabel8)
        Me.Panel3.Controls.Add(Me.txtAdresse)
        Me.Panel3.Controls.Add(Me.cbxGenreP)
        Me.Panel3.Controls.Add(Me.MetroLabel4)
        Me.Panel3.Location = New System.Drawing.Point(538, 81)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(283, 184)
        Me.Panel3.TabIndex = 77
        '
        'Timer1
        '
        '
        'GererPerso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 441)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbxService)
        Me.Controls.Add(Me.MetroLabel13)
        Me.Controls.Add(Me.cbxNbrEnfants)
        Me.Controls.Add(Me.btnMettreAjour)
        Me.Controls.Add(Me.bntSupprimer)
        Me.Controls.Add(Me.bntCreer)
        Me.Controls.Add(Me.lnkClear)
        Me.Controls.Add(Me.lblSuccess)
        Me.Controls.Add(Me.btnAnnulerP)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GererPerso"
        Me.Padding = New System.Windows.Forms.Padding(15, 60, 15, 16)
        Me.Resizable = False
        Me.Text = "GererPerso"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        CType(Me.myUXStyle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMettreAjour As MetroFramework.Controls.MetroButton
    Friend WithEvents bntSupprimer As MetroFramework.Controls.MetroButton
    Friend WithEvents bntCreer As MetroFramework.Controls.MetroButton
    Friend WithEvents cbxNbrEnfants As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbxGenreP As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dTimeRecrutement As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dTimeNaissance As MetroFramework.Controls.MetroDateTime
    Friend WithEvents ToolTipCreer As MetroFramework.Components.MetroToolTip
    Friend WithEvents ToolTipSupprimer As MetroFramework.Components.MetroToolTip
    Friend WithEvents ToolTipMettreAjour As MetroFramework.Components.MetroToolTip
    Friend WithEvents lnkClear As MetroFramework.Controls.MetroLink
    Friend WithEvents lblSuccess As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnAnnulerP As MetroFramework.Controls.MetroButton
    Friend WithEvents ToolTipClearAll As MetroFramework.Components.MetroToolTip
    Friend WithEvents txtDiplome As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPortable As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNaissanceP As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAdresse As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCinP As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNomP As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMatriculeP As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Public WithEvents myUXStyle As MetroFramework.Components.MetroStyleManager
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbxService As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbxSituation As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
