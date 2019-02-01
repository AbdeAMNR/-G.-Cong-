Imports System.Data.SqlClient
Imports MetroFramework
Public Class ChangePass
    ' Private connect As New odbcMannager
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private Sub ChangePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        startConnection()
        Me.StyleManager = Me.myUXStyle
        Me.myUXStyle.Style = MetroFramework.MetroColorStyle.Red

        LblAlert.Hide()
        txtAncienPass.Focus()

    End Sub


    Private Sub btnEffacer_Click(sender As Object, e As EventArgs) Handles btnEffacer.Click
        txtAncienPass.Clear()
        txtNouveauUser.Clear()
        txtNouveauPass.Clear()
        txtConfirmationPass.Clear()
        LblAlert.Hide()
    End Sub

    Private Sub txtNouveauPass_TextChanged(sender As Object, e As EventArgs) Handles txtNouveauPass.TextChanged
        LblAlert.Hide()
    End Sub



    Private Sub txtConfirmationPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmationPass.TextChanged
        LblAlert.Hide()
    End Sub

    Private Sub BtnAppliquer_Click(sender As Object, e As EventArgs) Handles BtnAppliquer.Click

        If Not String.IsNullOrWhiteSpace(txtAncienPass.Text) And Not String.IsNullOrWhiteSpace(txtNouveauUser.Text) And Not String.IsNullOrWhiteSpace(txtNouveauPass.Text) And Not String.IsNullOrWhiteSpace(txtConfirmationPass.Text) Then
            Dim sql As String = "SELECT * FROM tblUSERS where Pass = '" & txtAncienPass.Text & "'"
            cnx.Open()
            dr = runSelectSQL(sql)
            If dr.HasRows Then
                cnx.Close()
                '   dr.Close()
                If txtNouveauPass.Text <> txtConfirmationPass.Text Then
                    LblAlert.Show()
                Else

                    Dim rqt As String = "update tblUSERS set username= '" & txtNouveauUser.Text & "', Pass = '" & txtConfirmationPass.Text & "' where Pass = '" & txtAncienPass.Text & "'"
                    Dim affectedRows As Integer = runUpdateSQL(rqt)
                    'Console.WriteLine("seert 3lah ============" & affectedRows)
                    If affectedRows > 0 Then
                        MetroMessageBox.Show(Me, "Mot de passe changé avec succès, utilisez votre nouveau mot de passe à la prochaine connexion.", "Mot de passe modifié", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                        LoginFace.DeffautPass()

                    End If
                End If
            Else
                '   dr.Close()
                MetroMessageBox.Show(Me, "Invalide ancien mot de passe.", "Invalide", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End If
        Else
            MetroMessageBox.Show(Me, "Toutes les informations sont requises", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        cnx.Close()
    End Sub
End Class