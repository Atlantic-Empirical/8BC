Public Class frmOptions
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal _TargColTb As clsSettings)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.Settings = _TargColTb

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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tpColorTable As System.Windows.Forms.TabPage
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCurBGColor As System.Windows.Forms.Button
    Friend WithEvents rbBGWhite As System.Windows.Forms.RadioButton
    Friend WithEvents rbBGBlack As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnColOneCurCol As System.Windows.Forms.Button
    Friend WithEvents btnColTwoCurCol As System.Windows.Forms.Button
    Friend WithEvents btnColThreeCurCol As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txColOne_B As System.Windows.Forms.TextBox
    Friend WithEvents txColOne_G As System.Windows.Forms.TextBox
    Friend WithEvents txColOne_R As System.Windows.Forms.TextBox
    Friend WithEvents txColTwo_B As System.Windows.Forms.TextBox
    Friend WithEvents txColTwo_G As System.Windows.Forms.TextBox
    Friend WithEvents txColTwo_R As System.Windows.Forms.TextBox
    Friend WithEvents txColThree_B As System.Windows.Forms.TextBox
    Friend WithEvents txColThree_G As System.Windows.Forms.TextBox
    Friend WithEvents txColThree_R As System.Windows.Forms.TextBox
    Friend WithEvents rbMapBlackTo_col3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbMapBlackTo_col2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbMapBlackTo_col1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbMapBlackTo_bg As System.Windows.Forms.RadioButton
    Friend WithEvents cbConvert24s As System.Windows.Forms.CheckBox
    Friend WithEvents cbDisplayProgBar As System.Windows.Forms.CheckBox
    Friend WithEvents cbFixReadOnly As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmOptions))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tpGeneral = New System.Windows.Forms.TabPage
        Me.cbConvert24s = New System.Windows.Forms.CheckBox
        Me.cbDisplayProgBar = New System.Windows.Forms.CheckBox
        Me.cbFixReadOnly = New System.Windows.Forms.CheckBox
        Me.tpColorTable = New System.Windows.Forms.TabPage
        Me.Label2 = New System.Windows.Forms.Label
        Me.rbMapBlackTo_col3 = New System.Windows.Forms.RadioButton
        Me.rbMapBlackTo_col2 = New System.Windows.Forms.RadioButton
        Me.rbMapBlackTo_col1 = New System.Windows.Forms.RadioButton
        Me.rbMapBlackTo_bg = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txColThree_B = New System.Windows.Forms.TextBox
        Me.txColThree_G = New System.Windows.Forms.TextBox
        Me.txColThree_R = New System.Windows.Forms.TextBox
        Me.btnColThreeCurCol = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txColTwo_B = New System.Windows.Forms.TextBox
        Me.txColTwo_G = New System.Windows.Forms.TextBox
        Me.txColTwo_R = New System.Windows.Forms.TextBox
        Me.btnColTwoCurCol = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txColOne_B = New System.Windows.Forms.TextBox
        Me.txColOne_G = New System.Windows.Forms.TextBox
        Me.txColOne_R = New System.Windows.Forms.TextBox
        Me.btnColOneCurCol = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbBGBlack = New System.Windows.Forms.RadioButton
        Me.rbBGWhite = New System.Windows.Forms.RadioButton
        Me.btnCurBGColor = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.tpGeneral.SuspendLayout()
        Me.tpColorTable.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpGeneral)
        Me.TabControl1.Controls.Add(Me.tpColorTable)
        Me.TabControl1.Location = New System.Drawing.Point(2, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(400, 166)
        Me.TabControl1.TabIndex = 0
        '
        'tpGeneral
        '
        Me.tpGeneral.Controls.Add(Me.cbConvert24s)
        Me.tpGeneral.Controls.Add(Me.cbDisplayProgBar)
        Me.tpGeneral.Controls.Add(Me.cbFixReadOnly)
        Me.tpGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tpGeneral.Name = "tpGeneral"
        Me.tpGeneral.Size = New System.Drawing.Size(392, 140)
        Me.tpGeneral.TabIndex = 0
        Me.tpGeneral.Text = "General"
        '
        'cbConvert24s
        '
        Me.cbConvert24s.Location = New System.Drawing.Point(16, 64)
        Me.cbConvert24s.Name = "cbConvert24s"
        Me.cbConvert24s.TabIndex = 2
        Me.cbConvert24s.Text = "Convert 24 bits"
        '
        'cbDisplayProgBar
        '
        Me.cbDisplayProgBar.Location = New System.Drawing.Point(16, 40)
        Me.cbDisplayProgBar.Name = "cbDisplayProgBar"
        Me.cbDisplayProgBar.Size = New System.Drawing.Size(216, 24)
        Me.cbDisplayProgBar.TabIndex = 1
        Me.cbDisplayProgBar.Text = "Display progress bar"
        '
        'cbFixReadOnly
        '
        Me.cbFixReadOnly.Location = New System.Drawing.Point(16, 16)
        Me.cbFixReadOnly.Name = "cbFixReadOnly"
        Me.cbFixReadOnly.Size = New System.Drawing.Size(224, 24)
        Me.cbFixReadOnly.TabIndex = 0
        Me.cbFixReadOnly.Text = "Automatically fix read-only attribute"
        '
        'tpColorTable
        '
        Me.tpColorTable.Controls.Add(Me.Label2)
        Me.tpColorTable.Controls.Add(Me.rbMapBlackTo_col3)
        Me.tpColorTable.Controls.Add(Me.rbMapBlackTo_col2)
        Me.tpColorTable.Controls.Add(Me.rbMapBlackTo_col1)
        Me.tpColorTable.Controls.Add(Me.rbMapBlackTo_bg)
        Me.tpColorTable.Controls.Add(Me.Label1)
        Me.tpColorTable.Controls.Add(Me.GroupBox4)
        Me.tpColorTable.Controls.Add(Me.GroupBox3)
        Me.tpColorTable.Controls.Add(Me.GroupBox2)
        Me.tpColorTable.Controls.Add(Me.GroupBox1)
        Me.tpColorTable.Location = New System.Drawing.Point(4, 22)
        Me.tpColorTable.Name = "tpColorTable"
        Me.tpColorTable.Size = New System.Drawing.Size(392, 140)
        Me.tpColorTable.TabIndex = 1
        Me.tpColorTable.Text = "Color Table"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(376, 32)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Use integer values for colors.  Do not use hex values such as ""ff"". Valid numbers" & _
        " are between 0 and 255."
        '
        'rbMapBlackTo_col3
        '
        Me.rbMapBlackTo_col3.Location = New System.Drawing.Point(248, 88)
        Me.rbMapBlackTo_col3.Name = "rbMapBlackTo_col3"
        Me.rbMapBlackTo_col3.Size = New System.Drawing.Size(32, 16)
        Me.rbMapBlackTo_col3.TabIndex = 8
        Me.rbMapBlackTo_col3.Text = "3"
        '
        'rbMapBlackTo_col2
        '
        Me.rbMapBlackTo_col2.Location = New System.Drawing.Point(208, 88)
        Me.rbMapBlackTo_col2.Name = "rbMapBlackTo_col2"
        Me.rbMapBlackTo_col2.Size = New System.Drawing.Size(32, 16)
        Me.rbMapBlackTo_col2.TabIndex = 7
        Me.rbMapBlackTo_col2.Text = "2"
        '
        'rbMapBlackTo_col1
        '
        Me.rbMapBlackTo_col1.Location = New System.Drawing.Point(168, 88)
        Me.rbMapBlackTo_col1.Name = "rbMapBlackTo_col1"
        Me.rbMapBlackTo_col1.Size = New System.Drawing.Size(24, 16)
        Me.rbMapBlackTo_col1.TabIndex = 6
        Me.rbMapBlackTo_col1.Text = "1"
        '
        'rbMapBlackTo_bg
        '
        Me.rbMapBlackTo_bg.Location = New System.Drawing.Point(80, 88)
        Me.rbMapBlackTo_bg.Name = "rbMapBlackTo_bg"
        Me.rbMapBlackTo_bg.Size = New System.Drawing.Size(88, 16)
        Me.rbMapBlackTo_bg.TabIndex = 5
        Me.rbMapBlackTo_bg.Text = "Background"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Map black to:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txColThree_B)
        Me.GroupBox4.Controls.Add(Me.txColThree_G)
        Me.GroupBox4.Controls.Add(Me.txColThree_R)
        Me.GroupBox4.Controls.Add(Me.btnColThreeCurCol)
        Me.GroupBox4.Location = New System.Drawing.Point(296, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(88, 72)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Color Three"
        '
        'txColThree_B
        '
        Me.txColThree_B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txColThree_B.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txColThree_B.Location = New System.Drawing.Point(56, 32)
        Me.txColThree_B.MaxLength = 3
        Me.txColThree_B.Name = "txColThree_B"
        Me.txColThree_B.Size = New System.Drawing.Size(20, 18)
        Me.txColThree_B.TabIndex = 36
        Me.txColThree_B.Text = "255"
        Me.txColThree_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txColThree_G
        '
        Me.txColThree_G.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txColThree_G.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txColThree_G.Location = New System.Drawing.Point(32, 32)
        Me.txColThree_G.MaxLength = 3
        Me.txColThree_G.Name = "txColThree_G"
        Me.txColThree_G.Size = New System.Drawing.Size(20, 18)
        Me.txColThree_G.TabIndex = 35
        Me.txColThree_G.Text = "255"
        Me.txColThree_G.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txColThree_R
        '
        Me.txColThree_R.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txColThree_R.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txColThree_R.Location = New System.Drawing.Point(8, 32)
        Me.txColThree_R.MaxLength = 3
        Me.txColThree_R.Name = "txColThree_R"
        Me.txColThree_R.Size = New System.Drawing.Size(20, 18)
        Me.txColThree_R.TabIndex = 34
        Me.txColThree_R.Text = "255"
        Me.txColThree_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnColThreeCurCol
        '
        Me.btnColThreeCurCol.BackColor = System.Drawing.Color.White
        Me.btnColThreeCurCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColThreeCurCol.Location = New System.Drawing.Point(8, 16)
        Me.btnColThreeCurCol.Name = "btnColThreeCurCol"
        Me.btnColThreeCurCol.Size = New System.Drawing.Size(68, 16)
        Me.btnColThreeCurCol.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txColTwo_B)
        Me.GroupBox3.Controls.Add(Me.txColTwo_G)
        Me.GroupBox3.Controls.Add(Me.txColTwo_R)
        Me.GroupBox3.Controls.Add(Me.btnColTwoCurCol)
        Me.GroupBox3.Location = New System.Drawing.Point(200, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(88, 72)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Color Two"
        '
        'txColTwo_B
        '
        Me.txColTwo_B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txColTwo_B.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txColTwo_B.Location = New System.Drawing.Point(56, 32)
        Me.txColTwo_B.MaxLength = 3
        Me.txColTwo_B.Name = "txColTwo_B"
        Me.txColTwo_B.Size = New System.Drawing.Size(20, 18)
        Me.txColTwo_B.TabIndex = 36
        Me.txColTwo_B.Text = "255"
        Me.txColTwo_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txColTwo_G
        '
        Me.txColTwo_G.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txColTwo_G.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txColTwo_G.Location = New System.Drawing.Point(32, 32)
        Me.txColTwo_G.MaxLength = 3
        Me.txColTwo_G.Name = "txColTwo_G"
        Me.txColTwo_G.Size = New System.Drawing.Size(20, 18)
        Me.txColTwo_G.TabIndex = 35
        Me.txColTwo_G.Text = "255"
        Me.txColTwo_G.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txColTwo_R
        '
        Me.txColTwo_R.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txColTwo_R.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txColTwo_R.Location = New System.Drawing.Point(8, 32)
        Me.txColTwo_R.MaxLength = 3
        Me.txColTwo_R.Name = "txColTwo_R"
        Me.txColTwo_R.Size = New System.Drawing.Size(20, 18)
        Me.txColTwo_R.TabIndex = 34
        Me.txColTwo_R.Text = "255"
        Me.txColTwo_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnColTwoCurCol
        '
        Me.btnColTwoCurCol.BackColor = System.Drawing.Color.White
        Me.btnColTwoCurCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColTwoCurCol.Location = New System.Drawing.Point(8, 16)
        Me.btnColTwoCurCol.Name = "btnColTwoCurCol"
        Me.btnColTwoCurCol.Size = New System.Drawing.Size(68, 16)
        Me.btnColTwoCurCol.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txColOne_B)
        Me.GroupBox2.Controls.Add(Me.txColOne_G)
        Me.GroupBox2.Controls.Add(Me.txColOne_R)
        Me.GroupBox2.Controls.Add(Me.btnColOneCurCol)
        Me.GroupBox2.Location = New System.Drawing.Point(104, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(88, 72)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Color One"
        '
        'txColOne_B
        '
        Me.txColOne_B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txColOne_B.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txColOne_B.Location = New System.Drawing.Point(56, 32)
        Me.txColOne_B.MaxLength = 3
        Me.txColOne_B.Name = "txColOne_B"
        Me.txColOne_B.Size = New System.Drawing.Size(20, 18)
        Me.txColOne_B.TabIndex = 33
        Me.txColOne_B.Text = "255"
        Me.txColOne_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txColOne_G
        '
        Me.txColOne_G.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txColOne_G.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txColOne_G.Location = New System.Drawing.Point(32, 32)
        Me.txColOne_G.MaxLength = 3
        Me.txColOne_G.Name = "txColOne_G"
        Me.txColOne_G.Size = New System.Drawing.Size(20, 18)
        Me.txColOne_G.TabIndex = 32
        Me.txColOne_G.Text = "255"
        Me.txColOne_G.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txColOne_R
        '
        Me.txColOne_R.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txColOne_R.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txColOne_R.Location = New System.Drawing.Point(8, 32)
        Me.txColOne_R.MaxLength = 3
        Me.txColOne_R.Name = "txColOne_R"
        Me.txColOne_R.Size = New System.Drawing.Size(20, 18)
        Me.txColOne_R.TabIndex = 31
        Me.txColOne_R.Text = "255"
        Me.txColOne_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnColOneCurCol
        '
        Me.btnColOneCurCol.BackColor = System.Drawing.Color.White
        Me.btnColOneCurCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColOneCurCol.Location = New System.Drawing.Point(8, 16)
        Me.btnColOneCurCol.Name = "btnColOneCurCol"
        Me.btnColOneCurCol.Size = New System.Drawing.Size(68, 16)
        Me.btnColOneCurCol.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbBGBlack)
        Me.GroupBox1.Controls.Add(Me.rbBGWhite)
        Me.GroupBox1.Controls.Add(Me.btnCurBGColor)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 72)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Background"
        '
        'rbBGBlack
        '
        Me.rbBGBlack.Location = New System.Drawing.Point(16, 48)
        Me.rbBGBlack.Name = "rbBGBlack"
        Me.rbBGBlack.Size = New System.Drawing.Size(64, 16)
        Me.rbBGBlack.TabIndex = 2
        Me.rbBGBlack.Text = "Black"
        '
        'rbBGWhite
        '
        Me.rbBGWhite.Location = New System.Drawing.Point(16, 32)
        Me.rbBGWhite.Name = "rbBGWhite"
        Me.rbBGWhite.Size = New System.Drawing.Size(56, 16)
        Me.rbBGWhite.TabIndex = 1
        Me.rbBGWhite.Text = "White"
        '
        'btnCurBGColor
        '
        Me.btnCurBGColor.BackColor = System.Drawing.Color.White
        Me.btnCurBGColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCurBGColor.Location = New System.Drawing.Point(8, 16)
        Me.btnCurBGColor.Name = "btnCurBGColor"
        Me.btnCurBGColor.Size = New System.Drawing.Size(72, 16)
        Me.btnCurBGColor.TabIndex = 0
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(240, 176)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(320, 176)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        '
        'Timer1
        '
        Me.Timer1.Interval = 25
        '
        'frmOptions
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(404, 206)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOptions"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "8BC Options"
        Me.TabControl1.ResumeLayout(False)
        Me.tpGeneral.ResumeLayout(False)
        Me.tpColorTable.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Shared Settings As clsSettings

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Timer1.Enabled = True
    End Sub

    Private Sub btnColOneCurCol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColOneCurCol.Click
        SetMaptoColor(CType(sender, Button))
    End Sub

    Private Sub SetMaptoColor(ByVal sender As Button)
        Dim tmp As Button = CType(sender, Button)
        Dim colDialog As New ColorDialog
        colDialog.FullOpen = True
        colDialog.Color = tmp.BackColor
        colDialog.ShowDialog()
        tmp.BackColor = colDialog.Color
        SetTxtColors(sender, colDialog.Color)
        colDialog = Nothing
    End Sub

    Private Sub SetTxtColors(ByVal sender As Button, ByVal Color As System.Drawing.Color)
        Select Case sender.Name
            Case "btnColOneCurCol"
                Me.txColOne_R.Text = Color.R
                Me.txColOne_G.Text = Color.G
                Me.txColOne_B.Text = Color.B

            Case "btnColTwoCurCol"
                Me.txColTwo_R.Text = Color.R
                Me.txColTwo_G.Text = Color.G
                Me.txColTwo_B.Text = Color.B

            Case "btnColThreeCurCol"
                Me.txColThree_R.Text = Color.R
                Me.txColThree_G.Text = Color.G
                Me.txColThree_B.Text = Color.B
        End Select
    End Sub

    Private Sub rbBGWhite_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbBGWhite.CheckedChanged
        If rbBGWhite.Checked Then
            Me.btnCurBGColor.BackColor = System.Drawing.Color.White
        End If
    End Sub

    Private Sub rbBGBlack_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbBGBlack.CheckedChanged
        If rbBGBlack.Checked Then
            Me.btnCurBGColor.BackColor = System.Drawing.Color.Black
        End If
    End Sub

    Private Sub btnColTwoCurCol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColTwoCurCol.Click
        SetMaptoColor(CType(sender, Button))
    End Sub

    Private Sub btnColThreeCurCol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColThreeCurCol.Click
        SetMaptoColor(CType(sender, Button))
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Opacity = Me.Opacity - 0.1
        If Me.Opacity <= 0 Then Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        'COLOR TABLE SAVE
        Settings.TargetColorTable.bgB = CByte(Me.btnCurBGColor.BackColor.B) ' Blue Value
        Settings.TargetColorTable.bgG = CByte(Me.btnCurBGColor.BackColor.G) ' Green Value
        Settings.TargetColorTable.bgR = CByte(Me.btnCurBGColor.BackColor.R) ' Red Value

        Settings.TargetColorTable.c1_B = CByte(Me.txColOne_B.Text) ' Blue Value
        Settings.TargetColorTable.c1_G = CByte(Me.txColOne_G.Text) ' Green Value
        Settings.TargetColorTable.c1_R = CByte(Me.txColOne_R.Text) ' Red Value

        Settings.TargetColorTable.c2_B = CByte(Me.txColTwo_B.Text) ' Blue Value
        Settings.TargetColorTable.c2_G = CByte(Me.txColTwo_G.Text) ' Green Value
        Settings.TargetColorTable.c2_R = CByte(Me.txColTwo_R.Text) ' Red Value

        Settings.TargetColorTable.c3_B = CByte(Me.txColThree_B.Text) ' Blue Value
        Settings.TargetColorTable.c3_G = CByte(Me.txColThree_G.Text) ' Green Value
        Settings.TargetColorTable.c3_R = CByte(Me.txColThree_R.Text) ' Red Value

        If Me.cbConvert24s.Checked Then
            Settings.Process24s = True
        Else
            Settings.Process24s = False
        End If

        If Me.cbDisplayProgBar.Checked Then
            Settings.DisplayProgBar = True
        Else
            Settings.DisplayProgBar = False
        End If

        If Me.cbFixReadOnly.Checked Then
            Settings.AutoFixReadOnly = True
        Else
            Settings.AutoFixReadOnly = False
        End If

        If Me.rbMapBlackTo_bg.Checked Then
            Settings.MapBlackTo = "0"
        ElseIf Me.rbMapBlackTo_col1.Checked Then
            Settings.MapBlackTo = "1"
        ElseIf Me.rbMapBlackTo_col2.Checked Then
            Settings.MapBlackTo = "2"
        ElseIf Me.rbMapBlackTo_col3.Checked Then
            Settings.MapBlackTo = "3"
        End If

        UpdateTextSettings(Settings)
        Timer1.Enabled = True
    End Sub

    Private Sub frmOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Settings.AutoFixReadOnly Then
            Me.cbFixReadOnly.Checked = True
        Else
            Me.cbFixReadOnly.Checked = False
        End If

        If Settings.DisplayProgBar Then
            Me.cbDisplayProgBar.Checked = True
        Else
            Me.cbDisplayProgBar.Checked = False
        End If

        If Settings.Process24s Then
            Me.cbConvert24s.Checked = True
        Else
            Me.cbConvert24s.Checked = False
        End If

        Select Case Settings.MapBlackTo
            Case 0
                Me.rbMapBlackTo_bg.Checked = True
            Case 1
                Me.rbMapBlackTo_col1.Checked = True
            Case 2
                Me.rbMapBlackTo_col2.Checked = True
            Case 3
                Me.rbMapBlackTo_col3.Checked = True
        End Select

        'BG Color
        Me.btnCurBGColor.BackColor = Color.FromArgb(Settings.TargetColorTable.bgR, Settings.TargetColorTable.bgG, Settings.TargetColorTable.bgB)
        If Settings.TargetColorTable.bgB = 255 Then Me.rbBGWhite.Checked = True
        If Settings.TargetColorTable.bgB = 0 Then Me.rbBGBlack.Checked = True

        'Col 1
        Me.btnColOneCurCol.BackColor = Color.FromArgb(Settings.TargetColorTable.c1_R, Settings.TargetColorTable.c1_G, Settings.TargetColorTable.c1_B)
        Me.txColOne_R.Text = Settings.TargetColorTable.c1_R.ToString
        Me.txColOne_G.Text = Settings.TargetColorTable.c1_G.ToString
        Me.txColOne_B.Text = Settings.TargetColorTable.c1_B.ToString

        'Col 2
        Me.btnColTwoCurCol.BackColor = Color.FromArgb(Settings.TargetColorTable.c2_R, Settings.TargetColorTable.c2_G, Settings.TargetColorTable.c2_B)
        Me.txColTwo_R.Text = Settings.TargetColorTable.c2_R.ToString
        Me.txColTwo_G.Text = Settings.TargetColorTable.c2_G.ToString
        Me.txColTwo_B.Text = Settings.TargetColorTable.c2_B.ToString

        'Col 3
        Me.btnColThreeCurCol.BackColor = Color.FromArgb(Settings.TargetColorTable.c3_R, Settings.TargetColorTable.c3_G, Settings.TargetColorTable.c3_B)
        Me.txColThree_R.Text = Settings.TargetColorTable.c3_R.ToString
        Me.txColThree_G.Text = Settings.TargetColorTable.c3_G.ToString
        Me.txColThree_B.Text = Settings.TargetColorTable.c3_B.ToString

    End Sub

End Class
