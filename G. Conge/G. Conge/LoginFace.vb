Imports System.Data
Imports System.Data.SqlClient
Imports MetroFramework

Public Class LoginFace
    ' Private connect As New odbcMannager
    Dim SQLdr As SqlDataReader

    Public Shared Sub DeffautPass()
        cnx.Open()
        LoginFace.SQLdr = runSelectSQL("SELECT * FROM tblUSERS")
        If LoginFace.SQLdr.HasRows Then
            While LoginFace.SQLdr.Read()
                If LoginFace.SQLdr.Item("pass") = "admin" And LoginFace.SQLdr.Item("username") = "admin" Then
                    LoginFace.lblAlerte.Visible = True
                    cnx.Close()
                    Exit Sub
                Else
                    cnx.Close()
                    LoginFace.lblAlerte.Hide()
                    Exit Sub
                End If
            End While
        End If

        '   LoginFace.SQLdr.Close()
    End Sub

    Public Shared Sub LoginFace_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoginFace.txtUser.Text = "admin"
        LoginFace.txtPass.Text = "admin"

        LoginFace.StyleManager = LoginFace.myUXStyle
        LoginFace.myUXStyle.Style = MetroFramework.MetroColorStyle.Red

        getMetaData(".")

        LoginFace.lblAlerte.Visible = False
        LoginFace.txtUser.Focus()

        If LoginFace.cbxServer.Items.Count > 0 And LoginFace.cbxDB.Items.Contains("CongeDB") Then
            LoginFace.cbxServer.SelectedIndex = 0    ' The first item has index 0 '
            LoginFace.cbxDB.SelectedItem = "CongeDB"
        Else
            MsgBox("Exécutez le script SQL pour configurer la base de données." + vbNewLine + "Vous pouvez trouver le fichier db.sql dans: " + vbNewLine + "'Mini Projet VB.net (G. Congé)\database\db.sql'")
            Application.Exit()
            Exit Sub
        End If

        startConnection()
        LoginFace.DeffautPass()


    End Sub

    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click
        If Not String.IsNullOrWhiteSpace(txtUser.Text) And Not String.IsNullOrWhiteSpace(txtPass.Text) Then
            Dim rqt As String
            rqt = "select * from tblusers where username = '" & txtUser.Text & "'and pass = '" & txtPass.Text & "'"
            cnx.Open()
            SQLdr = runSelectSQL(rqt)
            If SQLdr.HasRows Then
                While SQLdr.Read()
                    If SQLdr.Item("username") = txtUser.Text And SQLdr.Item("Pass") = txtPass.Text Then
                        gDataReader.Close()
                        cnx.Close()
                        PersoListing.Show()
                        Me.Close()
                        Exit Sub
                    End If
                End While
            Else
                cnx.Close()
                MetroMessageBox.Show(Me, "Le nom d'utilisateur ou le mot de passe est incorrect." & vbNewLine & "Essayer a nouveau.", "Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Veuillez entrer votre nom d'utilisateur et votre mot de passe pour continuer.", "Connection impossible", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cmdChangePass_Click(sender As Object, e As EventArgs) Handles cmdChangePass.Click
        Dim myForm As New ChangePass
        myForm.ShowDialog()
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Application.Exit()
    End Sub
End Class




