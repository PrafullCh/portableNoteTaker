Imports MySql.Data.MySqlClient
Public Class Form1
    Dim str As String
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim Reader As MySqlDataReader
    Dim query As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password=;database=notesdb"
        If My.Settings.current_user <> "" Then
            Form2.Show()
            Me.Hide()
        End If
    End Sub






    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Try
            MySqlConn.Open()
            query = "select * from notesdb.users where mobno = '" & BunifuCustomTextbox1.Text & "' and password = '" & BunifuCustomTextbox2.Text & "'"
            COMMAND = New MySqlCommand(query, MySqlConn)

            Reader = COMMAND.ExecuteReader

            Dim count As Integer
            count = 0
            While Reader.Read
                count = count + 1

            End While
            If count = 1 Then
                Reader.Dispose()
                Dim adpt As New MySqlDataAdapter(COMMAND)
                Dim table As New DataTable
                adpt.Fill(table)
                'MetroFramework.MetroMessageBox.Show(Me, "User Found", "user Status", MessageBoxButtons.OK, MessageBoxIcon.Information)

                My.Settings.current_user = table.Rows(0)(1).ToString()
                My.Settings.current_user_mob_no = BunifuCustomTextbox1.Text
                Form2.Show()
                Me.Hide()
            Else
                MetroFramework.MetroMessageBox.Show(Me, "User Status", "user not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            MySqlConn.Dispose()
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub


    Private Sub BunifuCustomTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuCustomTextbox1.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            If e.KeyChar = Convert.ToChar(Keys.Back) Then Exit Sub
            MetroFramework.MetroMessageBox.Show(Me, "Number only", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.KeyChar = Nothing
        End If
    End Sub
End Class
