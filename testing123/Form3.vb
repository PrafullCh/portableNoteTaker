Imports MySql.Data.MySqlClient
Public Class Form3
    Dim str As String
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim Reader As MySqlDataReader
    Dim query As String
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password=;database=notesdb"
    End Sub

    Private Sub BunifuCustomTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuCustomTextbox1.KeyPress
        If IsNumeric(e.KeyChar) Then
            MetroFramework.MetroMessageBox.Show(Me, "Number are not allowed", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.KeyChar = Nothing
        End If
    End Sub


    Private Sub BunifuCustomTextbox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuCustomTextbox3.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            MetroFramework.MetroMessageBox.Show(Me, "Number only", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim pass1 As String
        pass1 = BunifuCustomTextbox4.Text
        Dim pass2 As String
        pass2 = BunifuCustomTextbox5.Text
        If Not pass1 = pass2 Then
            MetroFramework.MetroMessageBox.Show(Me, "Password do not match", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MySqlConn.Open()
            query = "insert into notesdb.users Values('" & BunifuCustomTextbox3.Text & "','" & BunifuCustomTextbox1.Text & "','" & BunifuCustomTextbox4.Text & "')"
            COMMAND = New MySqlCommand(query, MySqlConn)
            Reader = COMMAND.ExecuteReader
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        BunifuCustomTextbox4.Text = ""
        BunifuCustomTextbox5.Text = ""
        BunifuCustomTextbox1.Text = ""
        BunifuCustomTextbox3.Text = ""
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Form1.Show()
        Me.Hide()

    End Sub
End Class