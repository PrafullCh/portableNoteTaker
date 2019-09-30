<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BunifuCustomTextbox1 = New Bunifu.Framework.BunifuCustomTextbox()
        Me.BunifuCustomTextbox2 = New Bunifu.Framework.BunifuCustomTextbox()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(110, 103)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(109, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Enter Mobile No."
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(156, 143)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Password"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(129, 231)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(142, 19)
        Me.MetroLabel3.TabIndex = 7
        Me.MetroLabel3.Text = "Don't have an account?"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Aqua
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(286, 189)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 32)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Log In"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(286, 227)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 35)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Sign Up"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'BunifuCustomTextbox1
        '
        Me.BunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomTextbox1.Location = New System.Drawing.Point(253, 89)
        Me.BunifuCustomTextbox1.Multiline = True
        Me.BunifuCustomTextbox1.Name = "BunifuCustomTextbox1"
        Me.BunifuCustomTextbox1.Size = New System.Drawing.Size(116, 33)
        Me.BunifuCustomTextbox1.TabIndex = 11
        '
        'BunifuCustomTextbox2
        '
        Me.BunifuCustomTextbox2.BorderColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomTextbox2.Location = New System.Drawing.Point(253, 128)
        Me.BunifuCustomTextbox2.Multiline = True
        Me.BunifuCustomTextbox2.Name = "BunifuCustomTextbox2"
        Me.BunifuCustomTextbox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.BunifuCustomTextbox2.Size = New System.Drawing.Size(116, 34)
        Me.BunifuCustomTextbox2.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 384)
        Me.Controls.Add(Me.BunifuCustomTextbox2)
        Me.Controls.Add(Me.BunifuCustomTextbox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(13, 60, 13, 13)
        Me.Text = "Log In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BunifuCustomTextbox1 As Bunifu.Framework.BunifuCustomTextbox
    Friend WithEvents BunifuCustomTextbox2 As Bunifu.Framework.BunifuCustomTextbox
End Class
