Imports MySql.Data.MySqlClient

Public Class MakeConnection
    Public server As String
    Public database As String
    Private user As String
    Private password As String

    Private _sqlConn As MySqlConnection
    Private _sqlCmd As MySqlCommand
    Private _sqlAdapter As MySqlDataAdapter
    Private _sqlReader As MySqlDataReader
    Private _sqlSet As DataSet

    Public Sub SetUser(name As String, pass As String)
        user = name
        password = pass
    End Sub

    Public Function GetUser() As String()
        Return {user, password}
    End Function

    Public Function ConnectionString()
        Return $"DataSource={server};Database={database};User={user};Password={password};"
    End Function

    Public Function Connect() As MySqlConnection
        _sqlConn = New MySqlConnection(ConnectionString())
        Return _sqlConn
    End Function


End Class
