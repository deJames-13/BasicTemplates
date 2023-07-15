Imports MySql.Data.MySqlClient

Public Module DatabaseManager

    Public _mysqlString = ""
    Public _sqlConn As MySqlConnection
    Public _sqlCmd As MySqlCommand
    Public _sqlAdapter As MySqlDataAdapter
    Public _sqlReader As MySqlDataReader
    Public _sqlSet As DataSet



    Public Sub ConnectDB(server As String, database As String, user As String, pass As String)
        _mysqlString = $"DataSource={server};Database={database};User={user};Password={pass};"
        _sqlConn = New MySqlConnection(_mysqlString)
        OpenDB()
    End Sub

    Public Sub OpenDB()
        Try
            If _sqlConn Is Nothing Then
                Return
            End If
            If _sqlConn.State = ConnectionState.Open Then
                _sqlConn.Close()
            End If
            _sqlConn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub CloseDB()
        Try
            If _sqlConn Is Nothing Then
                Return
            End If
            If _sqlConn.State = ConnectionState.Open Then
                _sqlConn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' ExecuteQuery is used for SELECT
    Public Function ExecuteQuery(query As String, Optional table As String = "temp") As DataSet
        Try
            OpenDB()
            _sqlCmd = New MySqlCommand(query, _sqlConn)
            _sqlAdapter = New MySqlDataAdapter(_sqlCmd)
            _sqlSet = New DataSet
            _sqlAdapter.Fill(_sqlSet, table)
            _sqlAdapter.Update(_sqlSet, table)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CloseDB()
        End Try
        Return _sqlSet
    End Function

    ' Use a database and return the list 
    Public Function UseDB(name As String) As DataTable
        ExecuteNonQuery($"USE {name}")
        Dim dt As DataTable = ExecuteQuery("SHOW TABLES").Tables(0)
        Return dt
    End Function



    ' Load table to DataGridView
    Public Function LoadTable(ByRef grid As DataGridView, table As String, Optional column As String = "*") As DataTable
        Dim dt As New DataTable
        Try
            OpenDB()

            dt = ExecuteQuery("SELECT " & column & " FROM " & table, table).Tables(table)
            grid.DataSource = dt.DefaultView
            grid.Refresh()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CloseDB()
        End Try
        Return dt
    End Function

    ' Get the last inserted ID
    Public Function GetLastID() As Integer
        Dim id As Integer = 0
        Try
            OpenDB()
            _sqlCmd = New MySqlCommand("SELECT LAST_INSERT_ID()", _sqlConn)
            id = _sqlCmd.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CloseDB()
        End Try
        Return id
    End Function

    ' Get by ID
    Public Function GetByID(table As String, id As Integer) As DataTable
        Dim dt As New DataTable
        Try
            OpenDB()
            dt = ExecuteQuery("SELECT * FROM " & table & " WHERE id = " & id, table).Tables(table)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CloseDB()
        End Try
        Return dt
    End Function

    ' ExecuteNonQuery is used for INSERT, UPDATE, DELETE
    Public Sub ExecuteNonQuery(query As String)
        Try
            OpenDB()
            _sqlCmd = New MySqlCommand(query, _sqlConn)
            _sqlCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CloseDB()
        End Try
    End Sub

    ' Insert Builder
    Public Sub InsertValues(table As String, columns As String, values As String)
        Dim query As String = $"INSERT INTO {table} ({columns}) VALUES ({values})"
        ExecuteNonQuery(query)
    End Sub

    ' Update Builder
    Public Sub UpdateValues(table As String, values As String, condition As String)
        Dim query As String = $"UPDATE {table} SET {values} WHERE {condition}"
        ExecuteNonQuery(query)
    End Sub

    ' Delete Builder
    Public Sub DeleteValues(table As String, condition As String)
        Dim query As String = $"DELETE FROM {table} WHERE {condition}"
        ExecuteNonQuery(query)
    End Sub

    ' Filter Builder
    Public Function Filter(table As String, column As String, value As String) As DataTable
        Dim dt As New DataTable
        Try

            OpenDB()
            dt = ExecuteQuery($"SELECT * FROM {table} WHERE {column} LIKE '%{value}%'", table).Tables(table)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'CloseDB()
        End Try
        Return dt
    End Function




End Module
