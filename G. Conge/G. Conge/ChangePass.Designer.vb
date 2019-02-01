<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePass))
        Me.LblAlert = New MetroFramework.Controls.MetroLabel()
        Me.LblAide = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.BtnAppliquer = New MetroFramework.Controls.MetroButton()
        Me.btnEffacer = New MetroFramework.Controls.MetroButton()
        Me.txtConfirmationPass = New MetroFramework.Controls.MetroTextBox()
        Me.txtNouveauPass = New MetroFramework.Controls.MetroTextBox()
        Me.txtNouveauUser = New MetroFramework.Controls.MetroTextBox()
        Me.txtAncienPass = New MetroFramework.Controls.MetroTextBox()
        Me.myUXStyle = New MetroFramework.Components.MetroStyleManager(Me.components)
        CType(Me.myUXStyle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblAlert
        '
        Me.LblAlert.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblAlert.AutoSize = True
        Me.LblAlert.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LblAlert.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.LblAlert.ForeColor = System.Drawing.Color.Red
        Me.LblAlert.Location = New System.Drawing.Point(343, 261)
        Me.LblAlert.Name = "LblAlert"
        Me.LblAlert.Size = New System.Drawing.Size(236, 15)
        Me.LblAlert.TabIndex = 23
        Me.LblAlert.Text = "Mot de passe de confirmation est incorrect."
        Me.LblAlert.UseCustomForeColor = True
        '
        'LblAide
        '
        Me.LblAide.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblAide.AutoSize = True
        Me.LblAide.FontSize = MetroFramework.MetroLabelSize.Small
        Me.LblAide.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.LblAide.Location = New System.Drawing.Point(42, 111)
        Me.LblAide.Name = "LblAide"
        Me.LblAide.Size = New System.Drawing.Size(272, 165)
        Me.LblAide.TabIndex = 21
        Me.LblAide.Text = resources.GetString("LblAide.Text")
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel6.Location = New System.Drawing.Point(42, 90)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(209, 15)
        Me.MetroLabel6.TabIndex = 22
        Me.MetroLabel6.Text = "Choisir un bon mot de passe sécurisé"
        '
        'BtnAppliquer
        '
        Me.BtnAppliquer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAppliquer.Highlight = True
        Me.BtnAppliquer.Location = New System.Drawing.Point(447, 290)
        Me.BtnAppliquer.Name = "BtnAppliquer"
        Me.BtnAppliquer.Size = New System.Drawing.Size(80, 30)
        Me.BtnAppliquer.TabIndex = 19
        Me.BtnAppliquer.Text = "Appliquer"
        Me.BtnAppliquer.UseSelectable = True
        '
        'btnEffacer
        '
        Me.btnEffacer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEffacer.Highlight = True
        Me.btnEffacer.Location = New System.Drawing.Point(533, 290)
        Me.btnEffacer.Name = "btnEffacer"
        Me.btnEffacer.Size = New System.Drawing.Size(80, 30)
        Me.btnEffacer.TabIndex = 20
        Me.btnEffacer.Text = "Effacer"
        Me.btnEffacer.UseSelectable = True
        '
        'txtConfirmationPass
        '
        Me.txtConfirmationPass.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtConfirmationPass.CustomButton.Image = Nothing
        Me.txtConfirmationPass.CustomButton.Location = New System.Drawing.Point(242, 2)
        Me.txtConfirmationPass.CustomButton.Name = ""
        Me.txtConfirmationPass.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtConfirmationPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtConfirmationPass.CustomButton.TabIndex = 1
        Me.txtConfirmationPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtConfirmationPass.CustomButton.UseSelectable = True
        Me.txtConfirmationPass.CustomButton.Visible = False
        Me.txtConfirmationPass.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtConfirmationPass.Lines = New String(-1) {}
        Me.txtConfirmationPass.Location = New System.Drawing.Point(343, 228)
        Me.txtConfirmationPass.MaxLength = 15
        Me.txtConfirmationPass.Name = "txtConfirmationPass"
        Me.txtConfirmationPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtConfirmationPass.WaterMark = "Confirmation"
        Me.txtConfirmationPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtConfirmationPass.SelectedText = ""
        Me.txtConfirmationPass.SelectionLength = 0
        Me.txtConfirmationPass.SelectionStart = 0
        Me.txtConfirmationPass.ShortcutsEnabled = True
        Me.txtConfirmationPass.ShowClearButton = True
        Me.txtConfirmationPass.Size = New System.Drawing.Size(270, 30)
        Me.txtConfirmationPass.TabIndex = 18
        Me.txtConfirmationPass.UseSelectable = True
        Me.txtConfirmationPass.UseSystemPasswordChar = True
        Me.txtConfirmationPass.WaterMark = "Confirmation"
        Me.txtConfirmationPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtConfirmationPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNouveauPass
        '
        Me.txtNouveauPass.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtNouveauPass.CustomButton.Image = Nothing
        Me.txtNouveauPass.CustomButton.Location = New System.Drawing.Point(242, 2)
        Me.txtNouveauPass.CustomButton.Name = ""
        Me.txtNouveauPass.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtNouveauPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNouveauPass.CustomButton.TabIndex = 1
        Me.txtNouveauPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNouveauPass.CustomButton.UseSelectable = True
        Me.txtNouveauPass.CustomButton.Visible = False
        Me.txtNouveauPass.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNouveauPass.Lines = New String(-1) {}
        Me.txtNouveauPass.Location = New System.Drawing.Point(343, 184)
        Me.txtNouveauPass.MaxLength = 15
        Me.txtNouveauPass.Name = "txtNouveauPass"
        Me.txtNouveauPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtNouveauPass.WaterMark = "Nouveau mot de passe"
        Me.txtNouveauPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNouveauPass.SelectedText = ""
        Me.txtNouveauPass.SelectionLength = 0
        Me.txtNouveauPass.SelectionStart = 0
        Me.txtNouveauPass.ShortcutsEnabled = True
        Me.txtNouveauPass.ShowClearButton = True
        Me.txtNouveauPass.Size = New System.Drawing.Size(270, 30)
        Me.txtNouveauPass.TabIndex = 17
        Me.txtNouveauPass.UseSelectable = True
        Me.txtNouveauPass.UseSystemPasswordChar = True
        Me.txtNouveauPass.WaterMark = "Nouveau mot de passe"
        Me.txtNouveauPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNouveauPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNouveauUser
        '
        Me.txtNouveauUser.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtNouveauUser.CustomButton.Image = Nothing
        Me.txtNouveauUser.CustomButton.Location = New System.Drawing.Point(242, 2)
        Me.txtNouveauUser.CustomButton.Name = ""
        Me.txtNouveauUser.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtNouveauUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNouveauUser.CustomButton.TabIndex = 1
        Me.txtNouveauUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNouveauUser.CustomButton.UseSelectable = True
        Me.txtNouveauUser.CustomButton.Visible = False
        Me.txtNouveauUser.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNouveauUser.Lines = New String(-1) {}
        Me.txtNouveauUser.Location = New System.Drawing.Point(343, 140)
        Me.txtNouveauUser.MaxLength = 15
        Me.txtNouveauUser.Name = "txtNouveauUser"
        Me.txtNouveauUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNouveauUser.WaterMark = "Nouveau Nom d'utilisateur"
        Me.txtNouveauUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNouveauUser.SelectedText = ""
        Me.txtNouveauUser.SelectionLength = 0
        Me.txtNouveauUser.SelectionStart = 0
        Me.txtNouveauUser.ShortcutsEnabled = True
        Me.txtNouveauUser.ShowClearButton = True
        Me.txtNouveauUser.Size = New System.Drawing.Size(270, 30)
        Me.txtNouveauUser.TabIndex = 16
        Me.txtNouveauUser.UseSelectable = True
        Me.txtNouveauUser.WaterMark = "Nouveau Nom d'utilisateur"
        Me.txtNouveauUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNouveauUser.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtAncienPass
        '
        Me.txtAncienPass.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtAncienPass.CustomButton.Image = Nothing
        Me.txtAncienPass.CustomButton.Location = New System.Drawing.Point(242, 2)
        Me.txtAncienPass.CustomButton.Name = ""
        Me.txtAncienPass.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtAncienPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAncienPass.CustomButton.TabIndex = 1
        Me.txtAncienPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAncienPass.CustomButton.UseSelectable = True
        Me.txtAncienPass.CustomButton.Visible = False
        Me.txtAncienPass.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtAncienPass.Lines = New String(-1) {}
        Me.txtAncienPass.Location = New System.Drawing.Point(343, 96)
        Me.txtAncienPass.MaxLength = 15
        Me.txtAncienPass.Name = "txtAncienPass"
        Me.txtAncienPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtAncienPass.WaterMark = "Ancien mot de passe"
        Me.txtAncienPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAncienPass.SelectedText = ""
        Me.txtAncienPass.SelectionLength = 0
        Me.txtAncienPass.SelectionStart = 0
        Me.txtAncienPass.ShortcutsEnabled = True
        Me.txtAncienPass.ShowClearButton = True
        Me.txtAncienPass.Size = New System.Drawing.Size(270, 30)
        Me.txtAncienPass.TabIndex = 15
        Me.txtAncienPass.UseSelectable = True
        Me.txtAncienPass.UseSystemPasswordChar = True
        Me.txtAncienPass.WaterMark = "Ancien mot de passe"
        Me.txtAncienPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAncienPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'myUXStyle
        '
        Me.myUXStyle.Owner = Me
        '
        'ChangePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 362)
        Me.Controls.Add(Me.LblAlert)
        Me.Controls.Add(Me.LblAide)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.BtnAppliquer)
        Me.Controls.Add(Me.btnEffacer)
        Me.Controls.Add(Me.txtConfirmationPass)
        Me.Controls.Add(Me.txtNouveauPass)
        Me.Controls.Add(Me.txtNouveauUser)
        Me.Controls.Add(Me.txtAncienPass)
        Me.MaximizeBox = False
        Me.Name = "ChangePass"
        Me.Resizable = False
        Me.Text = "Modifier ou réinitialiser le mot de passe"
        CType(Me.myUXStyle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblAlert As MetroFramework.Controls.MetroLabel
    Friend WithEvents LblAide As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents BtnAppliquer As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEffacer As MetroFramework.Controls.MetroButton
    Friend WithEvents txtConfirmationPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNouveauPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNouveauUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAncienPass As MetroFramework.Controls.MetroTextBox
    Public WithEvents myUXStyle As MetroFramework.Components.MetroStyleManager
End Class
