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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lbllessthan As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblresult1 As System.Windows.Forms.Label
    Friend WithEvents lblresult2 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblresult3 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblresult4 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblresult5 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblresult6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.lbllessthan = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblresult1 = New System.Windows.Forms.Label
        Me.lblresult2 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblresult3 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblresult4 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblresult5 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblresult6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(32, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(232, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = ""
        '
        'lbllessthan
        '
        Me.lbllessthan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllessthan.Location = New System.Drawing.Point(32, 104)
        Me.lbllessthan.Name = "lbllessthan"
        Me.lbllessthan.TabIndex = 2
        Me.lbllessthan.Text = "a<b"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "a>b"
        '
        'lblresult1
        '
        Me.lblresult1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresult1.Location = New System.Drawing.Point(240, 104)
        Me.lblresult1.Name = "lblresult1"
        Me.lblresult1.TabIndex = 4
        '
        'lblresult2
        '
        Me.lblresult2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresult2.Location = New System.Drawing.Point(240, 136)
        Me.lblresult2.Name = "lblresult2"
        Me.lblresult2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "a<=b"
        '
        'lblresult3
        '
        Me.lblresult3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresult3.Location = New System.Drawing.Point(240, 168)
        Me.lblresult3.Name = "lblresult3"
        Me.lblresult3.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "a>=b"
        '
        'lblresult4
        '
        Me.lblresult4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresult4.Location = New System.Drawing.Point(240, 208)
        Me.lblresult4.Name = "lblresult4"
        Me.lblresult4.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "a<>b"
        '
        'lblresult5
        '
        Me.lblresult5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresult5.Location = New System.Drawing.Point(240, 248)
        Me.lblresult5.Name = "lblresult5"
        Me.lblresult5.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "a=b"
        '
        'lblresult6
        '
        Me.lblresult6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresult6.Location = New System.Drawing.Point(240, 288)
        Me.lblresult6.Name = "lblresult6"
        Me.lblresult6.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(360, 413)
        Me.Controls.Add(Me.lblresult1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbllessthan)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblresult2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblresult3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblresult4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblresult5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblresult6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        'If Val(TextBox1.Text) < Val(TextBox2.Text) Then lblresult1.Text = "True" Else lblresult1.Text = "False"
        'If Val(TextBox1.Text) > Val(TextBox2.Text) Then lblresult2.Text = "True" Else lblresult2.Text = "False"
        'If Val(TextBox1.Text) <= Val(TextBox2.Text) Then lblresult3.Text = "True" Else lblresult3.Text = "False"
        'If Val(TextBox1.Text) >= Val(TextBox2.Text) Then lblresult4.Text = "True" Else lblresult4.Text = "False"
        'If Val(TextBox1.Text) <> Val(TextBox2.Text) Then lblresult5.Text = "True" Else lblresult5.Text = "False"
        'If Val(TextBox1.Text) = Val(TextBox2.Text) Then lblresult6.Text = "True" Else lblresult6.Text = "False"

        lblresult1.Text = Val(TextBox1.Text) > Val(TextBox2.Text)
        lblresult2.Text = Val(TextBox1.Text) < Val(TextBox2.Text)
        lblresult3.Text = Val(TextBox1.Text) <= Val(TextBox2.Text)
        lblresult4.Text = Val(TextBox1.Text) >= Val(TextBox2.Text)
        lblresult5.Text = Val(TextBox1.Text) <> Val(TextBox2.Text)
        lblresult6.Text = Val(TextBox1.Text) = Val(TextBox2.Text)

    End Sub
End Class
