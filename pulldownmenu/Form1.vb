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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents mnubackcolor As System.Windows.Forms.MenuItem
    Friend WithEvents mnuforecolor As System.Windows.Forms.MenuItem
    Friend WithEvents mnufont As System.Windows.Forms.MenuItem
    Friend WithEvents mnuopen As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.mnuopen = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.mnubackcolor = New System.Windows.Forms.MenuItem
        Me.mnuforecolor = New System.Windows.Forms.MenuItem
        Me.mnufont = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem4, Me.MenuItem9})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuopen, Me.MenuItem3})
        Me.MenuItem1.Text = "File"
        '
        'mnuopen
        '
        Me.mnuopen.Index = 0
        Me.mnuopen.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.mnuopen.Text = "&Open"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "E&xit"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.mnufont})
        Me.MenuItem4.Text = "Edit"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnubackcolor, Me.mnuforecolor})
        Me.MenuItem5.Text = "Color"
        '
        'mnubackcolor
        '
        Me.mnubackcolor.Index = 0
        Me.mnubackcolor.Text = "BackColor"
        '
        'mnuforecolor
        '
        Me.mnuforecolor.Index = 1
        Me.mnuforecolor.Text = "Forecolor"
        '
        'mnufont
        '
        Me.mnufont.Index = 1
        Me.mnufont.Text = "Font"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 2
        Me.MenuItem9.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem10, Me.MenuItem11})
        Me.MenuItem9.Text = "Time"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 0
        Me.MenuItem10.Text = "Date"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.Text = "Time"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 120)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "hello"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(152, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(8, 208)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnubackcolor.Click
        ColorDialog1.ShowDialog()
        Label1.BackColor = ColorDialog1.Color

    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuforecolor.Click
        ColorDialog1.ShowDialog()
        Label1.ForeColor() = ColorDialog1.Color
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnufont.Click
        FontDialog1.ShowDialog()
        Label1.Font = FontDialog1.Font
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuopen.Click
        OpenFileDialog1.Filter = "Images (*.ico)|*.ico|(*.jpg)|*.jpg"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)


    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        Label1.Text = Format(Now, "MMMM dd, yyyy dddd")
    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        Timer1.Enabled = True


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = Format(Now, "hh:mmmm:ss")
    End Sub
End Class
