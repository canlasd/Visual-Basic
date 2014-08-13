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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtinput As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl1000 As System.Windows.Forms.Label
    Friend WithEvents lbl500 As System.Windows.Forms.Label
    Friend WithEvents lbl200 As System.Windows.Forms.Label
    Friend WithEvents lbl100 As System.Windows.Forms.Label
    Friend WithEvents lbl50 As System.Windows.Forms.Label
    Friend WithEvents lbl20 As System.Windows.Forms.Label
    Friend WithEvents lbl10 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtinput = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbl1000 = New System.Windows.Forms.Label
        Me.lbl500 = New System.Windows.Forms.Label
        Me.lbl200 = New System.Windows.Forms.Label
        Me.lbl100 = New System.Windows.Forms.Label
        Me.lbl50 = New System.Windows.Forms.Label
        Me.lbl20 = New System.Windows.Forms.Label
        Me.lbl10 = New System.Windows.Forms.Label
        Me.lbl5 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lbl1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "input amount"
        '
        'txtinput
        '
        Me.txtinput.Location = New System.Drawing.Point(136, 40)
        Me.txtinput.Name = "txtinput"
        Me.txtinput.Size = New System.Drawing.Size(128, 20)
        Me.txtinput.TabIndex = 1
        Me.txtinput.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "1000"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "500"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(32, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "200"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(32, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "100"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(32, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "50"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(32, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 23)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "20"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(32, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 23)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "10"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(32, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 23)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "5"
        '
        'lbl1000
        '
        Me.lbl1000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl1000.Location = New System.Drawing.Point(128, 96)
        Me.lbl1000.Name = "lbl1000"
        Me.lbl1000.Size = New System.Drawing.Size(104, 16)
        Me.lbl1000.TabIndex = 10
        '
        'lbl500
        '
        Me.lbl500.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl500.Location = New System.Drawing.Point(128, 128)
        Me.lbl500.Name = "lbl500"
        Me.lbl500.Size = New System.Drawing.Size(104, 16)
        Me.lbl500.TabIndex = 11
        '
        'lbl200
        '
        Me.lbl200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl200.Location = New System.Drawing.Point(128, 160)
        Me.lbl200.Name = "lbl200"
        Me.lbl200.Size = New System.Drawing.Size(104, 16)
        Me.lbl200.TabIndex = 12
        '
        'lbl100
        '
        Me.lbl100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl100.Location = New System.Drawing.Point(128, 192)
        Me.lbl100.Name = "lbl100"
        Me.lbl100.Size = New System.Drawing.Size(104, 16)
        Me.lbl100.TabIndex = 13
        '
        'lbl50
        '
        Me.lbl50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl50.Location = New System.Drawing.Point(128, 224)
        Me.lbl50.Name = "lbl50"
        Me.lbl50.Size = New System.Drawing.Size(104, 16)
        Me.lbl50.TabIndex = 14
        '
        'lbl20
        '
        Me.lbl20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl20.Location = New System.Drawing.Point(128, 256)
        Me.lbl20.Name = "lbl20"
        Me.lbl20.Size = New System.Drawing.Size(104, 16)
        Me.lbl20.TabIndex = 15
        '
        'lbl10
        '
        Me.lbl10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl10.Location = New System.Drawing.Point(128, 288)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(104, 16)
        Me.lbl10.TabIndex = 16
        '
        'lbl5
        '
        Me.lbl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl5.Location = New System.Drawing.Point(128, 320)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(104, 16)
        Me.lbl5.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(32, 360)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 23)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "1"
        '
        'lbl1
        '
        Me.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl1.Location = New System.Drawing.Point(128, 360)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(104, 16)
        Me.lbl1.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(336, 437)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.lbl20)
        Me.Controls.Add(Me.lbl50)
        Me.Controls.Add(Me.lbl100)
        Me.Controls.Add(Me.lbl200)
        Me.Controls.Add(Me.lbl500)
        Me.Controls.Add(Me.lbl1000)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtinput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub txtinput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtinput.TextChanged
        lbl1000.Text = Val(txtinput.Text) \ 1000
        lbl500.Text = (Val(txtinput.Text) Mod 1000) \ 500
        lbl200.Text = (Val(txtinput.Text) Mod 500) \ 200
        lbl100.Text = (Val(txtinput.Text) Mod 200) \ 100
        lbl50.Text = (Val(txtinput.Text) Mod 100) \ 50
        lbl20.Text = (Val(txtinput.Text) Mod 50) \ 20
        lbl10.Text = (Val(txtinput.Text) Mod 20) \ 10
        lbl5.Text = (Val(txtinput.Text) Mod 10) \ 5
        lbl1.Text = (Val(txtinput.Text) Mod 5) \ 1



    End Sub

    Private Sub lbl1000_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl1000.Click

    End Sub

    Private Sub lbl100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl100.Click

    End Sub

    Private Sub lbl200_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl200.Click

    End Sub
End Class
