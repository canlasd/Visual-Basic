Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents btnusername As System.Windows.Forms.Button
    Friend WithEvents btnpassword As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnlogin = New System.Windows.Forms.Button
        Me.btnusername = New System.Windows.Forms.Button
        Me.btnpassword = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.txtusername = New System.Windows.Forms.TextBox
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnlogin
        '
        Me.btnlogin.Location = New System.Drawing.Point(24, 192)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.TabIndex = 0
        Me.btnlogin.Text = "login"
        '
        'btnusername
        '
        Me.btnusername.Location = New System.Drawing.Point(24, 56)
        Me.btnusername.Name = "btnusername"
        Me.btnusername.TabIndex = 0
        Me.btnusername.Text = "username"
        '
        'btnpassword
        '
        Me.btnpassword.Location = New System.Drawing.Point(24, 96)
        Me.btnpassword.Name = "btnpassword"
        Me.btnpassword.TabIndex = 0
        Me.btnpassword.Text = "password"
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(152, 192)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.TabIndex = 0
        Me.btncancel.Text = "cancel"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(136, 56)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtusername.Size = New System.Drawing.Size(128, 20)
        Me.txtusername.TabIndex = 1
        Me.txtusername.Text = ""
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(136, 104)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(128, 20)
        Me.txtpassword.TabIndex = 1
        Me.txtpassword.Text = ""
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.btnusername)
        Me.Controls.Add(Me.btnpassword)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.txtpassword)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim username As Char
        Dim password As Char
        Static Dim n As Integer





        If txtusername.Text = "username" And txtpassword.Text = "password" Then
            MsgBox("Welcome to the System", MsgBoxStyle.OKOnly)


        Else

            MsgBox("Login Failed")
            txtusername.Clear()
            txtpassword.Clear()
            txtusername.Focus()


            n = n + 1

            If n = 3 Then
                txtusername.Enabled = False
                txtpassword.Enabled = False
                btnlogin.Enabled = False
            End If


        End If




    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class
