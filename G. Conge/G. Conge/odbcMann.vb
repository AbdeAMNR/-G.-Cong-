Imports System.Data.SqlClient
Module odbcMann


    Public cnx As SqlConnection
    Public SQLcmd As SqlCommand
    Public gDataReader As SqlDataReader
    Public dt As New DataTable

    Public Sub getMetaData(ByVal str As String)
        Try
            Dim con = New SqlConnection("Data Source=" & str & ";Database=Master;integrated security=SSPI;")
            con.Open()
            SQLcmd = New SqlCommand("SELECT * FROM sysservers WHERE srvproduct='SQL Server'", con)
            gDataReader = SQLcmd.ExecuteReader
            While gDataReader.Read
                LoginFace.cbxServer.Items.Add(gDataReader("srvname"))
            End While
            gDataReader.Close()

            SQLcmd = New SqlCommand("SELECT * FROM sys.databases", con)
            gDataReader = SQLcmd.ExecuteReader
            While gDataReader.Read
                LoginFace.cbxDB.Items.Add(gDataReader("name"))
            End While
            gDataReader.Close()
            con.Close()
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Function startConnection() As Boolean
        Try
            Dim cnxString As String
            cnxString = "Data Source=" & LoginFace.cbxServer.SelectedItem + "; Initial Catalog=" & LoginFace.cbxDB.SelectedItem
            cnxString += "; Integrated Security=True"
            cnx = New SqlConnection(cnxString)
            ' MsgBox("connection string is: " + vbNewLine + cnxString, MsgBoxStyle.Information)
            'cnx.Open()
            'MsgBox("l'etat de connection " + CStr(cnx.State))
            'cnx.Close()
            'MsgBox("l'etat de connection " + CStr(cnx.State))
            'MsgBox("Connexion a été établie", MsgBoxStyle.Information)
            'cnx.Open()
            'cnx.Close()
            Return True
        Catch ex As SqlException
            MsgBox("Echec de connexion, erreur au " & ex.Message)
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
            Return False
        End Try
    End Function

    Public Function DB() As SqlConnection
        Return cnx
    End Function

    Public Sub closeDR()
        Try
            gDataReader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function runSelectSQL(ByVal myQeury As String) As SqlDataReader
        Try
            ' MsgBox("l'etat de connection en select sub " + CStr(cnx.State))
            SQLcmd = New SqlCommand(myQeury, cnx)
            gDataReader = SQLcmd.ExecuteReader
        Catch ex As SqlException
            MsgBox("select sub exception: " + vbNewLine + ex.Message)
        End Try
        Return gDataReader
    End Function
    Public Function runUpdateSQL(ByVal myQeury As String) As Integer
        cnx.Open()
        '  gDataReader.Close()
        Dim ChangeCount As Integer = 0
        Try
            SQLcmd = New SqlCommand(myQeury, cnx)
            ChangeCount = SQLcmd.ExecuteNonQuery()

        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        cnx.Close()
        Return ChangeCount
    End Function

    Public Function FillDGV(resultSet As SqlDataReader) As DataTable
        Try
            dt.Clear()
            dt.Load(resultSet)
        Catch ex As Exception
            MsgBox("fill data grid " + vbNewLine + ex.Message, MsgBoxStyle.Information)
        End Try
        Return dt
    End Function


End Module
