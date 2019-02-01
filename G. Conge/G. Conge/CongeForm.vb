Imports System.Data.SqlClient
Imports MetroFramework

Public Class CongeForm

    Dim dSetConge As New DataSet
    Dim dSetPerso As New DataSet

    Dim CAdapter As SqlDataAdapter
    Dim dLigne As DataRow
    Dim dSync As SqlCommandBuilder
    Private Sub CongeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlSwitchC.Visible = False
        Me.StyleManager = Me.myUXStyle
        Me.myUXStyle.Style = MetroFramework.MetroColorStyle.Red

        btnPerso.Enabled = True
        btnConge.Enabled = False

        chargerDataSet()
        With GridConge
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "N° de congé"
            .Columns(1).HeaderCell.Value = "Matricule"
            .Columns(2).HeaderCell.Value = "Nom et Prenom"
            .Columns(3).HeaderCell.Value = "Début du congé"
            .Columns(4).HeaderCell.Value = "Reprise de Service"
            .Columns(5).HeaderCell.Value = "Duree"
            .Columns(6).HeaderCell.Value = "type de congé"
            .Columns(7).HeaderCell.Value = "CIN"
            .Columns(8).HeaderCell.Value = "Genre"
            .Columns(9).HeaderCell.Value = "Telephone"
        End With
        checkAnnuler.Checked = False
        txtCongeNum.Hide()
        cmdAppliquer.Hide()

    End Sub

    Private Sub checkAnnuler_CheckedChanged(sender As Object, e As EventArgs) Handles checkAnnuler.CheckedChanged
        If checkAnnuler.Checked = True Then
            txtCongeNum.Show()
            cmdAppliquer.Show()
        Else
            txtCongeNum.Hide()
            cmdAppliquer.Hide()
        End If
    End Sub

    Function getLeavetime() As Integer
        Dim startDate As Date = DateDebut.Value
        Dim endDate As Date = DateReprise.Value
        Dim i As Integer
        Dim totalDays As Integer = DateDiff(DateInterval.Day, startDate, endDate)

        MsgBox("totalDays: " + Convert.ToString(totalDays))
        Dim count As Integer = 0
        If totalDays > 0 Then
            For i = 1 To totalDays
                Dim weekday As DayOfWeek = startDate.AddDays(i).DayOfWeek
                If weekday <> DayOfWeek.Saturday AndAlso weekday <> DayOfWeek.Sunday Then
                    count += 1
                    MsgBox("dkhil " + Convert.ToString(count))
                End If
            Next
            Return count
        Else
            MsgBox("no if: " + Convert.ToString(count))
            Return count
        End If

    End Function

    Private Sub cmdAjouter_Click(sender As Object, e As EventArgs) Handles cmdAjouter.Click
        dLigne = dSetConge.Tables("tblConge").NewRow
        dLigne("Matricule") = txtMatriculeC.Text.Trim
        dLigne("Duree_Conge") = getLeavetime()
        dLigne("Debut_Conge") = DateDebut.Value
        dLigne("Reprise_De_Service") = DateReprise.Value
        dLigne("TypeConge") = cbxTypeConge.SelectedItem
        dSetConge.Tables("tblConge").Rows.Add(dLigne)

        dSync = New SqlCommandBuilder(CAdapter)
        CAdapter.Update(dSetConge, "tblConge")
        
        CongeForm_Load(sender, e)






        'If KeyExist() Then
        '    If getLeavetime() > 0 Then
        '        dLigne = dSetConge.Tables("tblConge").NewRow
        '        dLigne("Matricule") = txtMatriculeC.Text.Trim
        '        dLigne("Duree_Conge") = getLeavetime()
        '        dLigne("Debut_Conge") = DateDebut.Value
        '        dLigne("Reprise_De_Service") = DateReprise.Value
        '        dLigne("TypeConge") = cbxTypeConge.SelectedItem

        '        dSetConge.Tables("tblConge").Rows.Add(dLigne)
        '        dSync = New SqlCommandBuilder(CAdapter)
        '        CAdapter.Update(dSetConge, "tblConge")
        '    Else
        '        Dim myMsg As String = "La durée choisie ne pas valide"
        '        MetroMessageBox.Show(Me, myMsg, "Erreur commise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        Exit Sub
        '    End If
        'Else
        '    Dim myMsg As String = "Matricule déjà existe" + vbNewLine
        '    myMsg += "Matricule doit être uniquement numérique" + vbNewLine
        '    MetroMessageBox.Show(Me, myMsg, "Erreur commise", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If

        'chargerDataSet()
    End Sub

    Private Sub btnPerso_Click(sender As Object, e As EventArgs) Handles btnPerso.Click
        PersoListing.Show()
        Me.Close()
    End Sub

    Private Sub btnSwitch_Click(sender As Object, e As EventArgs) Handles btnSwitch.Click
        pnlSwitchC.Visible = True
    End Sub

    Private Sub lnkBack_Click(sender As Object, e As EventArgs) Handles lnkBack.Click
        pnlSwitchC.Hide()
    End Sub

    Private Sub chargerDataSet()
        If dSetConge.Tables.Contains("newTable") Then
            dSetConge.Tables.Remove(dSetConge.Tables("newTable"))
        End If
        Dim rqt As String = "select * from (select c.Num_Conge,P.Matricule,p.Nom_Prenom,c.Debut_Conge,c.Reprise_De_Service,c.Duree_Conge,c.TypeConge,p.CIN_Perso,p.Genre_Perso,p.Tele_Portable from tblConge c join Personnel p on c.Matricule=p.Matricule) as newTable"
        CAdapter = New SqlDataAdapter(rqt, cnx)
        CAdapter.Fill(dSetConge, "newTable")
        GridConge.DataSource = dSetConge.Tables("newTable")

        If dSetPerso.Tables.Contains("Personnel") Then
            dSetPerso.Tables.Remove(dSetPerso.Tables("Personnel"))
        End If

        rqt = "select * from Personnel"
        CAdapter = New SqlDataAdapter(rqt, cnx)
        CAdapter.Fill(dSetPerso, "Personnel")


        If dSetConge.Tables.Contains("tblConge") Then
            dSetConge.Tables.Remove(dSetConge.Tables("tblConge"))
        End If

        rqt = "select * from tblConge"
        CAdapter = New SqlDataAdapter(rqt, cnx)
        CAdapter.Fill(dSetConge, "tblConge")
    End Sub

    Private Sub MetroLabel6_Click(sender As Object, e As EventArgs) Handles MetroLabel6.Click

    End Sub

    Private Function KeyExist() As Boolean
        If IsNumeric(txtMatriculeC.Text.Trim) Then
            Dim i As Integer = 0
            For i = 0 To dSetPerso.Tables("Personnel").Rows.Count - 1
                dLigne = dSetPerso.Tables("Personnel").Rows(i)
                If dLigne("Matricule") = txtMatriculeC.Text.Trim Then
                    MsgBox("found in " + Convert.ToString(i))
                    Return True
                End If
            Next
        End If
        Return False
    End Function

    Private Sub DateReprise_ValueChanged(sender As Object, e As EventArgs) Handles DateReprise.ValueChanged
        txtDuree.Text = getLeavetime()
    End Sub
    Function getRowIndex() As Integer
        Dim i As Integer = -1
        If dSetConge.Tables.Count > 0 And dSetConge.Tables("tblConge").Rows.Count > 0 Then
            For i = 0 To dSetConge.Tables("tblConge").Rows.Count - 1
                Dim NewLigne As DataRow
                NewLigne = dSetConge.Tables("tblConge").Rows(i)
                If NewLigne("Matricule") = txtMatriculeC.Text.Trim Then
                    Return i
                End If
            Next
        End If
        Return i
    End Function

    Function getCongeIndex() As Integer
        Dim i As Integer = -1
        If dSetConge.Tables.Count > 0 And dSetConge.Tables("tblConge").Rows.Count > 0 Then
            For i = 0 To dSetConge.Tables("tblConge").Rows.Count - 1
                Dim NewLigne As DataRow
                NewLigne = dSetConge.Tables("tblConge").Rows(i)
                If NewLigne("Num_Conge") = txtCongeNum.Text.Trim Then
                    Return i
                End If
            Next
        End If
        Return i
    End Function
    Private Sub cmdAppliquer_Click(sender As Object, e As EventArgs) Handles cmdAppliquer.Click
        Dim index As Integer = getCongeIndex()
        If index = -1 Then

        Else
            'MsgBox(index)
            dSetConge.Tables("tblConge").Rows(index).Delete()
            dSync = New SqlCommandBuilder(CAdapter)
            CAdapter.Update(dSetConge, "tblConge")
            CongeForm_Load(sender, e)
        End If
    End Sub
End Class