Imports MySql.Data.MySqlClient
Public Class Form5
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim connection As New MySqlConnection("server=localhost;userid=root;password=;database=notesdb")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("select * from notesdb.notes where mobno='" & My.Settings.current_user_mob_no & "'", connection)
        adapter.Fill(table)
        DataGridView1.DataSource = table


    End Sub
End Class