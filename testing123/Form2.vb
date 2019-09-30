
Imports MySql.Data.MySqlClient
Public Class Form2
    Dim str As String
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim Reader As MySqlDataReader
    Dim query As String
    Dim startpointX As Integer = 0
    Dim startpointY As Integer = 0
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        'Me.Refresh()

        BunifuCustomLabel1.Text = My.Settings.current_user
        BunifuCustomLabel2.Text = My.Settings.current_user_mob_no
        BunifuCustomTextbox1.Hide()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password=;database=notesdb"
        MetroPanel1.AutoScroll = True


        Try
            MySqlConn.Open()
            query = "select * from notesdb.notes where mobno = '" & My.Settings.current_user_mob_no & "'"
            COMMAND = New MySqlCommand(query, MySqlConn)

            Reader = COMMAND.ExecuteReader

            Dim count As Integer
            count = 0
            While Reader.Read
                count = count + 1
            End While
            If count <> 0 Then
                Reader.Dispose()
                Dim adpt As New MySqlDataAdapter(COMMAND)
                Dim table As New DataTable
                adpt.Fill(table)
                Dim i As Integer
                For i = 0 To count - 1
                    Dim MachinePanel = New Panel() '
                    Dim MachineName = New Label()
                    Dim MachineStatus = New TextBox()
                    Dim RunningProg = New Label()
                    Dim RunningPart = New Label()
                    Dim PartsComplete = New Label()
                    ''''''''''''''''''''''''''''''''''''''''''''''''


                    With MachinePanel
                        .Name = table.Rows(i)(1).ToString()
                        .Size = New Size(300, 150)
                        .Location = New Point(startpointX, startpointY)
                        .BackColor = Color.White
                    End With


                    With MachineName
                        '.Name = table.Rows(i)(0).ToString()
                        .Text = table.Rows(i)(0).ToString()
                        .Font = New Font("Bookman Old Style", 14, FontStyle.Bold)
                        .Location = New Point(0, 0) '<- In relation to MachinePanel.ClientRectangle
                        .AutoSize = True
                        .Width = 100
                    End With

                    With MachineStatus
                        '.Name = table.Rows(i)(0).ToString()
                        .Text = table.Rows(i)(1).ToString()
                        .Font = New Font("Bookman Old Style", 12, FontStyle.Bold)
                        .Location = New Point(0, 30)
                        .AutoSize = True
                        .Multiline = True
                        .ScrollBars = ScrollBars.Both
                        .ReadOnly = True
                        .Enabled = True
                        .Width = 250
                        .Height = 300
                        .Visible = True
                    End With

                    MachinePanel.Controls.AddRange(New Control() {MachineName, MachineStatus})
                    Me.MetroPanel1.Controls.Add(MachinePanel)
                    startpointY = startpointY + 150
                    ''''''''''''''''''''''''''''''''''''''''''''''


                Next



                'MetroFramework.MetroMessageBox.Show(Me, "User Found", "user Status", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                BunifuCustomTextbox1.Show()
                BunifuCustomTextbox1.Text = "no Record Exist"
            End If
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            MySqlConn.Dispose()
        End Try












    End Sub

    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel1.Click

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        My.Settings.current_user = ""
        My.Settings.current_user_mob_no = ""
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub BunifuCustomLabel2_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel2.Click

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub MetroPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form2_Load(Me, New System.EventArgs)


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuCustomTextbox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
        Me.Hide()
    End Sub
End Class