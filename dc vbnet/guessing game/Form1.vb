Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim a As Integer

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(96, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "guess the number"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(96, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "guess the number"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(136, 64)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "TextBox1"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "enter number"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(88, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 48)
        Me.Label4.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(104, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "guess"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = 15

        If a > Val(TextBox2.Text) Then
            Label4.Text = "Higher Please"

        ElseIf a < Val(TextBox2.Text) Then
            Label4.Text = "Lower Please"

        Else

            Label4.Text = "You are correct"

        End If



    End Sub
End Class
