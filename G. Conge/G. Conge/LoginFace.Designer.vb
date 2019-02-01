<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginFace
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginFace))
        Me.myUXStyle = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.cmdExit = New MetroFramework.Controls.MetroButton()
        Me.cmdConnect = New MetroFramework.Controls.MetroButton()
        Me.txtUser = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxDB = New System.Windows.Forms.ComboBox()
        Me.cbxServer = New System.Windows.Forms.ComboBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.cmdChangePass = New MetroFramework.Controls.MetroButton()
        Me.lblAlerte = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txtPass = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.myUXStyle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'myUXStyle
        '
        Me.myUXStyle.Owner = Me
        Me.myUXStyle.Style = MetroFramework.MetroColorStyle.Red
        '
        'picLogo
        '
        Me.picLogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(139, 117)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(282, 270)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Highlight = True
        Me.cmdExit.Location = New System.Drawing.Point(789, 311)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(123, 34)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "Quitter "
        Me.cmdExit.UseSelectable = True
        '
        'cmdConnect
        '
        Me.cmdConnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdConnect.Highlight = True
        Me.cmdConnect.Location = New System.Drawing.Point(645, 311)
        Me.cmdConnect.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(123, 34)
        Me.cmdConnect.TabIndex = 3
        Me.cmdConnect.Text = "Se connecter"
        Me.cmdConnect.UseSelectable = True
        '
        'txtUser
        '
        Me.txtUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtUser.CustomButton.Image = Nothing
        Me.txtUser.CustomButton.Location = New System.Drawing.Point(413, 1)
        Me.txtUser.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUser.CustomButton.Name = ""
        Me.txtUser.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.txtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUser.CustomButton.TabIndex = 1
        Me.txtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUser.CustomButton.UseSelectable = True
        Me.txtUser.DisplayIcon = True
        Me.txtUser.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtUser.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtUser.Lines = New String(-1) {}
        Me.txtUser.Location = New System.Drawing.Point(463, 192)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUser.MaxLength = 30
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUser.WaterMark = "Nom d'utilisateur"
        Me.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUser.SelectedText = ""
        Me.txtUser.SelectionLength = 0
        Me.txtUser.SelectionStart = 0
        Me.txtUser.ShortcutsEnabled = True
        Me.txtUser.ShowButton = True
        Me.txtUser.ShowClearButton = True
        Me.txtUser.Size = New System.Drawing.Size(449, 37)
        Me.txtUser.TabIndex = 0
        Me.txtUser.UseCustomForeColor = True
        Me.txtUser.UseSelectable = True
        Me.txtUser.WaterMark = "Nom d'utilisateur"
        Me.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUser.WaterMarkFont = New System.Drawing.Font("Helvetica-Normal", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cbxDB)
        Me.GroupBox1.Controls.Add(Me.cbxServer)
        Me.GroupBox1.Controls.Add(Me.MetroLabel5)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Location = New System.Drawing.Point(689, 384)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(335, 74)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'cbxDB
        '
        Me.cbxDB.Font = New System.Drawing.Font("Helvetica-Normal", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDB.FormattingEnabled = True
        Me.cbxDB.Location = New System.Drawing.Point(191, 38)
        Me.cbxDB.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxDB.Name = "cbxDB"
        Me.cbxDB.Size = New System.Drawing.Size(131, 27)
        Me.cbxDB.TabIndex = 3
        '
        'cbxServer
        '
        Me.cbxServer.Font = New System.Drawing.Font("Helvetica-Normal", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxServer.FormattingEnabled = True
        Me.cbxServer.Location = New System.Drawing.Point(11, 38)
        Me.cbxServer.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxServer.Name = "cbxServer"
        Me.cbxServer.Size = New System.Drawing.Size(171, 27)
        Me.cbxServer.TabIndex = 2
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(191, 16)
        Me.MetroLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(63, 17)
        Me.MetroLabel5.TabIndex = 1
        Me.MetroLabel5.Text = "Database"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(11, 16)
        Me.MetroLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(45, 17)
        Me.MetroLabel4.TabIndex = 0
        Me.MetroLabel4.Text = "Server"
        '
        'cmdChangePass
        '
        Me.cmdChangePass.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdChangePass.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmdChangePass.ForeColor = System.Drawing.Color.White
        Me.cmdChangePass.Location = New System.Drawing.Point(689, 465)
        Me.cmdChangePass.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdChangePass.Name = "cmdChangePass"
        Me.cmdChangePass.Size = New System.Drawing.Size(335, 31)
        Me.cmdChangePass.TabIndex = 5
        Me.cmdChangePass.Text = "Modifier ou réinitialiser le mot de passe"
        Me.cmdChangePass.UseCustomBackColor = True
        Me.cmdChangePass.UseCustomForeColor = True
        Me.cmdChangePass.UseSelectable = True
        '
        'lblAlerte
        '
        Me.lblAlerte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAlerte.AutoSize = True
        Me.lblAlerte.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblAlerte.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblAlerte.ForeColor = System.Drawing.Color.Red
        Me.lblAlerte.Location = New System.Drawing.Point(70, 415)
        Me.lblAlerte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAlerte.Name = "lblAlerte"
        Me.lblAlerte.Size = New System.Drawing.Size(438, 34)
        Me.lblAlerte.TabIndex = 10
        Me.lblAlerte.Text = "NOM D'UTILISATEUR : ""admin"" - MOT DE PASSE : ""admin""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pour faire disparaître cett" & _
    "e ligne veuillez changer votre mot de passe."
        Me.lblAlerte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAlerte.UseCustomForeColor = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel7.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel7.Location = New System.Drawing.Point(7, 485)
        Me.MetroLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(321, 17)
        Me.MetroLabel7.TabIndex = 11
        Me.MetroLabel7.Text = "© Designed and Developed by Abderrahim AMANAR"
        '
        'txtPass
        '
        Me.txtPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtPass.CustomButton.Image = Nothing
        Me.txtPass.CustomButton.Location = New System.Drawing.Point(413, 1)
        Me.txtPass.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass.CustomButton.Name = ""
        Me.txtPass.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPass.CustomButton.TabIndex = 1
        Me.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPass.CustomButton.UseSelectable = True
        Me.txtPass.DisplayIcon = True
        Me.txtPass.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPass.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtPass.Lines = New String(-1) {}
        Me.txtPass.Location = New System.Drawing.Point(463, 256)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass.MaxLength = 30
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPass.WaterMark = "Mot de passe"
        Me.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPass.SelectedText = ""
        Me.txtPass.SelectionLength = 0
        Me.txtPass.SelectionStart = 0
        Me.txtPass.ShortcutsEnabled = True
        Me.txtPass.ShowButton = True
        Me.txtPass.ShowClearButton = True
        Me.txtPass.Size = New System.Drawing.Size(449, 37)
        Me.txtPass.TabIndex = 1
        Me.txtPass.UseCustomForeColor = True
        Me.txtPass.UseSelectable = True
        Me.txtPass.WaterMark = "Mot de passe"
        Me.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPass.WaterMarkFont = New System.Drawing.Font("Helvetica-Normal", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(278, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(487, 52)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "GESTION DES CONGES"
        '
        'LoginFace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 512)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.lblAlerte)
        Me.Controls.Add(Me.cmdChangePass)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.cmdConnect)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.picLogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "LoginFace"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Resizable = False
        CType(Me.myUXStyle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents myUXStyle As MetroFramework.Components.MetroStyleManager
    Friend WithEvents txtUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cmdConnect As MetroFramework.Controls.MetroButton
    Friend WithEvents cmdExit As MetroFramework.Controls.MetroButton
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblAlerte As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmdChangePass As MetroFramework.Controls.MetroButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Public WithEvents cbxDB As System.Windows.Forms.ComboBox
    Public WithEvents cbxServer As System.Windows.Forms.ComboBox
    Friend WithEvents txtPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
