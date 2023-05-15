Public Class frmProcessing
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
    Friend WithEvents pb8BC As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCur As System.Windows.Forms.Label
    Friend WithEvents lblOf As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.pb8BC = New System.Windows.Forms.ProgressBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblCur = New System.Windows.Forms.Label
        Me.lblOf = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'pb8BC
        '
        Me.pb8BC.Location = New System.Drawing.Point(8, 24)
        Me.pb8BC.Minimum = 1
        Me.pb8BC.Name = "pb8BC"
        Me.pb8BC.Size = New System.Drawing.Size(392, 16)
        Me.pb8BC.TabIndex = 0
        Me.pb8BC.Value = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Now processing:"
        '
        'lblCur
        '
        Me.lblCur.Location = New System.Drawing.Point(96, 8)
        Me.lblCur.Name = "lblCur"
        Me.lblCur.Size = New System.Drawing.Size(24, 16)
        Me.lblCur.TabIndex = 2
        Me.lblCur.Text = "x"
        Me.lblCur.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOf
        '
        Me.lblOf.Location = New System.Drawing.Point(128, 8)
        Me.lblOf.Name = "lblOf"
        Me.lblOf.Size = New System.Drawing.Size(16, 16)
        Me.lblOf.TabIndex = 3
        Me.lblOf.Text = "of"
        Me.lblOf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(144, 8)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(32, 16)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "x"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmProcessing
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 46)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblOf)
        Me.Controls.Add(Me.lblCur)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb8BC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmProcessing"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Please Wait"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Shared Total As Short
    '    Private Shared Current As Short

    Private Sub frmProcessing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public WriteOnly Property TotalToProcess() As Short
        Set(ByVal Value As Short)
            Me.lblTotal.Text = CStr(Value)
            Me.pb8BC.Maximum = Value
        End Set
    End Property

    Public WriteOnly Property CurrentlyProcessing() As Short
        Set(ByVal Value As Short)
            Me.lblCur.Text = CStr(Value)
            Me.pb8BC.Value = Value
        End Set
    End Property

End Class
