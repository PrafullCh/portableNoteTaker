Imports MySql.Data.MySqlClient
Public Class Form4
    Dim str As String
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim Reader As MySqlDataReader
    Dim query As String
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Try
            MySqlConn.Open()
            query = "insert into notesdb.notes values('" & BunifuCustomTextbox1.Text & "','" & BunifuCustomTextbox2.Text & "','" & My.Settings.current_user_mob_no & "')"
            COMMAND = New MySqlCommand(query, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()


            Form2.Show()
            Me.Hide()



        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password=;database=notesdb"
    End Sub

    Private Sub BunifuCustomTextbox1_TextChanged(sender As Object, e As EventArgs) Handles BunifuCustomTextbox1.TextChanged

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        BunifuCustomTextbox1.Text = ""
        BunifuCustomTextbox2.Text = ""
        Form2.Show()
        Me.Hide()

    End Sub
End Class