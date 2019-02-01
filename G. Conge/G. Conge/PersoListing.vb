Imports System.Data
Imports System.Data.SqlClient
Imports MetroFramework

Public Class PersoListing
    '   Private connect As New odbcMannager
    Private SQLdr As SqlDataReader
    Private Sub setTable()
        With GridPersonnel
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Matricule"
            .Columns(1).HeaderCell.Value = "Nom prénom"
            .Columns(2).HeaderCell.Value = "CIN"
            .Columns(3).HeaderCell.Value = "Genre"
            .Columns(4).HeaderCell.Value = "Année naissance"
            .Columns(5).HeaderCell.Value = "Lieu naissance"
            .Columns(6).HeaderCell.Value = "Situation familiale"
            .Columns(7).HeaderCell.Value = "Nombre enfants"
            .Columns(8).HeaderCell.Value = "Diplôme"
            .Columns(9).HeaderCell.Value = "Date recrutement"
            .Columns(10).HeaderCell.Value = "Adresse"
            .Columns(11).HeaderCell.Value = "Service travail "
            .Columns(12).HeaderCell.Value = "Téléphone"
        End With
    End Sub
    Private Sub FillPersoGrid(rqt As String)
        cnx.Open()
        SQLdr = runSelectSQL(rqt)
        If SQLdr.HasRows Then
            Me.GridPersonnel.DataSource = FillDGV(SQLdr)
              setTable()
        End If
        cnx.Close()
    End Sub
    Private Sub PersoListing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlSwitch.Visible = False
        Me.StyleManager = Me.myUXStyle
        Me.myUXStyle.Style = MetroFramework.MetroColorStyle.Red

        txtSearch.Clear()
        If cbxSearch.Items.Count > 0 Then
            cbxSearch.SelectedIndex = 0    ' The first item has index 0 '
        End If

        'Dim rqt As String
        'rqt = "select * from Personnel"
        'FillPersoGrid(rqt)
        GererPerso.reValidateTable()
        setTable()
        btnPerso.Enabled = False
        btnConge.Enabled = True

    End Sub
    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxOnly.SelectedIndexChanged

        Dim rqt As String

        rqt = "SELECT TOP " + Me.cbxOnly.SelectedItem + " * from Personnel"
        '  MsgBox(rqt)
        FillPersoGrid(rqt)
    End Sub


    Private Sub lnkActualiser_Click(sender As Object, e As EventArgs) Handles lnkActualiser.Click
        PersoListing_Load(sender, e)
    End Sub

    Private Sub lnkGérer_Click(sender As Object, e As EventArgs) Handles lnkGérer.Click
        Dim myForm2 As New GererPerso
        myForm2.ShowDialog()
    End Sub

 

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
            Dim rqt As String
            rqt = "select * from Personnel where " & cbxSearch.SelectedItem & " like '%" & txtSearch.Text & "%'"

            FillPersoGrid(rqt)
        End If
    End Sub
 
    Private Sub CmdSearch_Click(sender As Object, e As EventArgs) Handles CmdSearch.Click
        txtSearch_TextChanged(sender, e)
    End Sub
 
    Private Sub btnSwitch_Click(sender As Object, e As EventArgs) Handles btnSwitch.Click
        pnlSwitch.Visible = True
    End Sub

    Private Sub MetroLink2_Click(sender As Object, e As EventArgs) Handles lnkBack.Click
        pnlSwitch.Visible = False

    End Sub

     
   
    Private Sub btnConge_Click(sender As Object, e As EventArgs) Handles btnConge.Click
        CongeForm.Show()
        Me.Close()
    End Sub

 

    Private Sub GridPersonnel_DoubleClick(sender As Object, e As EventArgs) Handles GridPersonnel.DoubleClick
        lnkGérer_Click(sender, e)
    End Sub
End Class