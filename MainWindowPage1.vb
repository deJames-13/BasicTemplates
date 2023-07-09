
Public Class MainWindowPage1

    Public currentTable = "tb_customers"

    Private Sub btnDebug_Click(sender As Object, e As EventArgs) Handles btnDebug.Click


    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click


    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged


        dtGridView1.DataSource = Filter(currentTable, cbColumns.SelectedItem, txtSearch.Text)
        dtGridView1.Refresh()

    End Sub

    Private Sub MainWindowPage1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentTable = "tb_customers"
        ConnectDB("localhost", "db_sqlgame", "root", "")
        LoadTable(dtGridView1, currentTable)
        ' load columns to cbColumns
        cbColumns.Items.Clear()
        For Each col In dtGridView1.Columns
            cbColumns.Items.Add(col.HeaderText)
        Next
        cbColumns.SelectedIndex = 1
    End Sub
End Class
