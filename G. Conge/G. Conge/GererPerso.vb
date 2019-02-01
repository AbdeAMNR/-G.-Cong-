Imports System.Data.SqlClient
Imports MetroFramework

Public Class GererPerso
    '  Dim i As Integer
    '  Dim comp As Integer
    '  Dim cnx As New SqlConnection
    Dim cmd As New SqlCommand
    '  Dim dSet As New DataSet
    Dim dSetPerso As New DataSet
    Dim dAdapter As SqlDataAdapter
    Dim dRow As DataRow
    Dim cmdBuilder As SqlCommandBuilder
 





    Private Sub GererPerso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StyleManager = Me.myUXStyle
        Me.myUXStyle.Style = MetroFramework.MetroColorStyle.Red

        cbxGenreP.SelectedIndex = 0
        cbxNbrEnfants.SelectedIndex = 0
        cbxService.SelectedIndex = 0
        cbxSituation.SelectedIndex = 0
        lblSuccess.Visible = False

        LoadDataSet()


    End Sub



    Private Sub LoadDataSet()
        If dSetPerso.Tables.Contains("Personnel") Then
            dSetPerso.Tables.Remove(dSetPerso.Tables("Personnel"))
        End If
    
        Dim rqt As String = "select * from Personnel"
        dAdapter = New SqlDataAdapter(rqt, cnx)
        dAdapter.Fill(dSetPerso, "Personnel")

        FillTxtFeilds()
   
    End Sub

    Private Sub FillTxtFeilds()
        Dim myTarget As String = PersoListing.GridPersonnel.Item(0, PersoListing.GridPersonnel.CurrentRow.Index).Value
        Dim cle As Integer = getRowIndex(myTarget)
        Me.txtNomP.Clear()
        Me.txtCinP.Clear()
        Me.txtNaissanceP.Clear()
        Me.txtDiplome.Clear()
        Me.txtAdresse.Clear()
        Me.txtPortable.Clear()
        Me.lblSuccess.Hide()
        Dim dRow = dSetPerso.Tables("Personnel").Rows(cle)
        Me.txtMatriculeP.Text = dRow("Matricule")
        Me.txtNomP.Text = dRow("Nom_Prenom")
        Me.txtCinP.Text = dRow("CIN_Perso")
        If Not IsDBNull(dRow("LieuNaissance_Perso")) Then Me.txtNaissanceP.Text = dRow("LieuNaissance_Perso")
        If Not IsDBNull(dRow("Diplome")) Then Me.txtDiplome.Text = dRow("Diplome")
        If Not IsDBNull(dRow("Adresse_Perso")) Then Me.txtAdresse.Text = dRow("Adresse_Perso")
        If Not IsDBNull(dRow("Tele_Portable")) Then Me.txtPortable.Text = dRow("Tele_Portable")
        Me.dTimeNaissance.Value = dRow("AnneeNaissance_Perso")
        Me.dTimeRecrutement.Value = dRow("Date_Recrutement")
        Me.cbxGenreP.SelectedItem = dRow("Genre_Perso")
        Me.cbxSituation.SelectedItem = dRow("Situtation_Familiale")
        Me.cbxNbrEnfants.SelectedIndex = dRow("Nombre_Enfants").ToString()
        Me.cbxService.SelectedItem = dRow("ServiceDeTravail")
    End Sub
    Private Function formValide() As Boolean
        If IsNumeric(txtMatriculeP.Text) And Not String.IsNullOrWhiteSpace(txtMatriculeP.Text) Then
            If Not String.IsNullOrWhiteSpace(txtCinP.Text) And Not String.IsNullOrWhiteSpace(txtNomP.Text) Then
                Return True
            End If
        End If
        Return False
    End Function
    Function cleExiste() As Boolean
        If Not String.IsNullOrWhiteSpace(txtMatriculeP.Text) And IsNumeric(txtMatriculeP.Text.Trim) Then
            Dim i As Integer = 0
            For i = 0 To dSetPerso.Tables("Personnel").Rows.Count - 1
                dRow = dSetPerso.Tables("Personnel").Rows(i)
                If dRow("Matricule") = txtMatriculeP.Text.Trim Then
                    '    MsgBox(dRow("Matricule"))
                    Return True
                End If
            Next
        End If
        Return False
    End Function
    Public Sub reValidateTable()
        Dim dSetPerso As New DataSet
        If dSetPerso.Tables.Contains("Personnel") Then
            dSetPerso.Tables.Remove(dSetPerso.Tables("Personnel"))
        End If
        Dim rqt As String = "select * from Personnel "
        dAdapter = New SqlDataAdapter(rqt, cnx)
        dAdapter.Fill(dSetPerso, "Personnel")
        PersoListing.GridPersonnel.DataSource = dSetPerso.Tables("Personnel")
    End Sub
    Private Sub bntCreer_Click(sender As Object, e As EventArgs) Handles bntCreer.Click

        If formValide() = True And cleExiste() = False Then
            dRow = dSetPerso.Tables("Personnel").NewRow
            '  MsgBox(cbxService.SelectedValue)
            dRow("Matricule") = txtMatriculeP.Text.Trim
            dRow("Nom_Prenom") = txtNomP.Text.Trim
            dRow("CIN_Perso") = txtCinP.Text.Trim
            dRow("Genre_Perso") = cbxGenreP.SelectedItem
            dRow("AnneeNaissance_Perso") = dTimeNaissance.Value.Date
            dRow("LieuNaissance_Perso") = txtNaissanceP.Text.Trim
            dRow("Situtation_Familiale") = cbxSituation.SelectedItem
            dRow("Nombre_Enfants") = cbxNbrEnfants.SelectedItem
            dRow("Diplome") = txtDiplome.Text.Trim
            dRow("Date_Recrutement") = dTimeRecrutement.Value.Date
            dRow("Adresse_Perso") = txtAdresse.Text.Trim
            dRow("ServiceDeTravail") = cbxService.SelectedItem
            dRow("Tele_Portable") = txtPortable.Text.Trim

            dSetPerso.Tables("Personnel").Rows.Add(dRow)
            cmdBuilder = New SqlCommandBuilder(dAdapter)
            dAdapter.Update(dSetPerso, "Personnel")

            reValidateTable()
            lblAlert("Le personnel a été ajouté avec succès")
        Else
            Dim myMsg As String = "Matricule, Nom Prenom et CIN sont nécessaires." + vbNewLine
            myMsg += "Matricule déjà existe" + vbNewLine
            myMsg += "Matricule doit être uniquement numérique" + vbNewLine

            MetroMessageBox.Show(Me, myMsg, "Erreur commise", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Function getRowIndex(target As String) As Integer
        Dim i As Integer = -1
        If dSetPerso.Tables.Count > 0 And dSetPerso.Tables("Personnel").Rows.Count > 0 Then
            For i = 0 To dSetPerso.Tables("Personnel").Rows.Count - 1
                Dim Ligne As DataRow
                Ligne = dSetPerso.Tables("Personnel").Rows(i)
                If Ligne("Matricule") = target Then
                    Return i
                End If
            Next
        End If
        Return i
    End Function

    Sub lblAlert(alert As String)
        lblSuccess.Text = alert
        lblSuccess.Visible = True
        Timer1.Interval = 2800 '2.8 second
        Timer1.Enabled = True
    End Sub



    Private Sub btnAnnulerP_Click(sender As Object, e As EventArgs) Handles btnAnnulerP.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'mli sali timer had lcode s'execute
        lblSuccess.Visible = False
        Timer1.Enabled = False
    End Sub

    Private Sub bntSupprimer_Click(sender As Object, e As EventArgs) Handles bntSupprimer.Click

        If cleExiste() = True And IsNumeric(txtMatriculeP.Text) And Not String.IsNullOrWhiteSpace(txtMatriculeP.Text) Then
            If MetroMessageBox.Show(Me, "Voulez-vous vraiment supprimer définitivement le personnel avec ce matricule " & txtMatriculeP.Text & "?", "Retirer le personnel", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
                Dim index As Integer = getRowIndex(txtMatriculeP.Text.Trim)
                ' MsgBox(index)
                dSetPerso.Tables("Personnel").Rows(index).Delete()

                cmdBuilder = New SqlCommandBuilder(dAdapter)
                dAdapter.Update(dSetPerso, "Personnel")
                lblAlert("Personnel a été supprimée")
                reValidateTable()
            End If
        Else
            Dim myMsg As String = "Matricule n'existe pas." + vbNewLine
            myMsg += "Matricule doit être uniquement numérique" + vbNewLine

            MetroMessageBox.Show(Me, myMsg, "Erreur commise", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub lnkClear_Click(sender As Object, e As EventArgs) Handles lnkClear.Click
        txtMatriculeP.Clear()
        txtNomP.Clear()
        txtCinP.Clear()
        txtNaissanceP.Clear()
         txtDiplome.Clear()
        txtAdresse.Clear()
         txtPortable.Clear()
    End Sub

    Private Sub btnMettreAjour_Click(sender As Object, e As EventArgs) Handles btnMettreAjour.Click
        If formValide() = True And cleExiste() = True Then
            Dim index As Integer = getRowIndex(txtMatriculeP.Text.Trim)
            ' MsgBox(index)
            dRow = dSetPerso.Tables("Personnel").Rows(index)
            dRow("Nom_Prenom") = txtNomP.Text.Trim
            dRow("CIN_Perso") = txtCinP.Text.Trim
            dRow("Genre_Perso") = cbxGenreP.SelectedItem
            dRow("AnneeNaissance_Perso") = dTimeNaissance.Value.Date
            dRow("LieuNaissance_Perso") = txtNaissanceP.Text.Trim
            dRow("Situtation_Familiale") = cbxSituation.SelectedItem
            dRow("Nombre_Enfants") = cbxNbrEnfants.SelectedItem
            dRow("Diplome") = txtDiplome.Text.Trim
            dRow("Date_Recrutement") = dTimeRecrutement.Value.Date
            dRow("Adresse_Perso") = txtAdresse.Text.Trim
            dRow("ServiceDeTravail") = cbxService.SelectedItem
            dRow("Tele_Portable") = txtPortable.Text.Trim

            cmdBuilder = New SqlCommandBuilder(dAdapter)
            dAdapter.Update(dSetPerso, "Personnel")

            reValidateTable()

            lblAlert("les modification sont effectués avec succès")
        Else
            Dim myMsg As String = "Matricule, Nom Prenom et CIN sont nécessaires." + vbNewLine
            myMsg += "Matricule déjà existe" + vbNewLine
            myMsg += "Matricule doit être uniquement numérique" + vbNewLine

            MetroMessageBox.Show(Me, myMsg, "Erreur commise", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub
End Class