Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging

Public Class frmMain
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

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
    Friend WithEvents btnLBFILESclear As System.Windows.Forms.Button
    Friend WithEvents btn8BC As System.Windows.Forms.Button
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
    Friend WithEvents MainMenus As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents miExit As System.Windows.Forms.MenuItem
    Friend WithEvents miHelpContents As System.Windows.Forms.MenuItem
    Friend WithEvents miSeqWeb As System.Windows.Forms.MenuItem
    Friend WithEvents miAbout As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents miOptions As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents btnClearSelected As System.Windows.Forms.Button
    Friend WithEvents miSaveReport As System.Windows.Forms.MenuItem
    Friend WithEvents miClearSelected As System.Windows.Forms.MenuItem
    Friend WithEvents miClearAll As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents miSelectAll As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents mi8BCAll As System.Windows.Forms.MenuItem
    Friend WithEvents mi8BCSelected As System.Windows.Forms.MenuItem
    Friend WithEvents btn8BCSelected As System.Windows.Forms.Button
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents lvMain As System.Windows.Forms.ListView
    Friend WithEvents chFileName As System.Windows.Forms.ColumnHeader
    Friend WithEvents chVidStd As System.Windows.Forms.ColumnHeader
    Friend WithEvents chBits As System.Windows.Forms.ColumnHeader
    Friend WithEvents chColors As System.Windows.Forms.ColumnHeader
    Friend WithEvents chColorTable As System.Windows.Forms.ColumnHeader
    Friend WithEvents chFullPath As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents gbPreview As System.Windows.Forms.GroupBox
    Friend WithEvents pbPreview As System.Windows.Forms.PictureBox
    Friend WithEvents btnFormResize As System.Windows.Forms.Button
    Friend WithEvents btnViewColorTable As System.Windows.Forms.Button
    Friend WithEvents FadeOutTimer As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
        Me.btnLBFILESclear = New System.Windows.Forms.Button
        Me.btn8BC = New System.Windows.Forms.Button
        Me.lblCount = New System.Windows.Forms.Label
        Me.btnSelectAll = New System.Windows.Forms.Button
        Me.MainMenus = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.miSaveReport = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.miOptions = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.miExit = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.miClearSelected = New System.Windows.Forms.MenuItem
        Me.miClearAll = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.miSelectAll = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.mi8BCAll = New System.Windows.Forms.MenuItem
        Me.mi8BCSelected = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.miHelpContents = New System.Windows.Forms.MenuItem
        Me.miSeqWeb = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.miAbout = New System.Windows.Forms.MenuItem
        Me.btnClearSelected = New System.Windows.Forms.Button
        Me.btn8BCSelected = New System.Windows.Forms.Button
        Me.lvMain = New System.Windows.Forms.ListView
        Me.chFileName = New System.Windows.Forms.ColumnHeader
        Me.chVidStd = New System.Windows.Forms.ColumnHeader
        Me.chBits = New System.Windows.Forms.ColumnHeader
        Me.chColors = New System.Windows.Forms.ColumnHeader
        Me.chColorTable = New System.Windows.Forms.ColumnHeader
        Me.chFullPath = New System.Windows.Forms.ColumnHeader
        Me.txtLog = New System.Windows.Forms.TextBox
        Me.gbPreview = New System.Windows.Forms.GroupBox
        Me.btnViewColorTable = New System.Windows.Forms.Button
        Me.pbPreview = New System.Windows.Forms.PictureBox
        Me.btnFormResize = New System.Windows.Forms.Button
        Me.FadeOutTimer = New System.Windows.Forms.Timer(Me.components)
        Me.gbPreview.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLBFILESclear
        '
        Me.btnLBFILESclear.Location = New System.Drawing.Point(56, 304)
        Me.btnLBFILESclear.Name = "btnLBFILESclear"
        Me.btnLBFILESclear.Size = New System.Drawing.Size(90, 18)
        Me.btnLBFILESclear.TabIndex = 2
        Me.btnLBFILESclear.Text = "Clear All"
        '
        'btn8BC
        '
        Me.btn8BC.Location = New System.Drawing.Point(248, 288)
        Me.btn8BC.Name = "btn8BC"
        Me.btn8BC.Size = New System.Drawing.Size(90, 18)
        Me.btn8BC.TabIndex = 3
        Me.btn8BC.Text = "8BC All"
        '
        'lblCount
        '
        Me.lblCount.Location = New System.Drawing.Point(8, 288)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(48, 16)
        Me.lblCount.TabIndex = 5
        Me.lblCount.Text = "#"
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Location = New System.Drawing.Point(152, 288)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(90, 18)
        Me.btnSelectAll.TabIndex = 8
        Me.btnSelectAll.Text = "Select All"
        '
        'MainMenus
        '
        Me.MainMenus.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem4})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miSaveReport, Me.MenuItem9, Me.miOptions, Me.MenuItem11, Me.miExit})
        Me.MenuItem1.Text = "File"
        '
        'miSaveReport
        '
        Me.miSaveReport.Index = 0
        Me.miSaveReport.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.miSaveReport.Text = "Save Report"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 1
        Me.MenuItem9.Text = "-"
        '
        'miOptions
        '
        Me.miOptions.Index = 2
        Me.miOptions.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.miOptions.Text = "Options"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 3
        Me.MenuItem11.Text = "-"
        '
        'miExit
        '
        Me.miExit.Index = 4
        Me.miExit.Shortcut = System.Windows.Forms.Shortcut.CtrlX
        Me.miExit.Text = "Exit"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miClearSelected, Me.miClearAll, Me.MenuItem6, Me.miSelectAll, Me.MenuItem8, Me.mi8BCAll, Me.mi8BCSelected})
        Me.MenuItem2.Text = "Edit"
        '
        'miClearSelected
        '
        Me.miClearSelected.Index = 0
        Me.miClearSelected.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftC
        Me.miClearSelected.Text = "Clear Selected"
        '
        'miClearAll
        '
        Me.miClearAll.Index = 1
        Me.miClearAll.Shortcut = System.Windows.Forms.Shortcut.CtrlC
        Me.miClearAll.Text = "Clear All"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 2
        Me.MenuItem6.Text = "-"
        '
        'miSelectAll
        '
        Me.miSelectAll.Index = 3
        Me.miSelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA
        Me.miSelectAll.Text = "Select All"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 4
        Me.MenuItem8.Text = "-"
        '
        'mi8BCAll
        '
        Me.mi8BCAll.Index = 5
        Me.mi8BCAll.Shortcut = System.Windows.Forms.Shortcut.CtrlB
        Me.mi8BCAll.Text = "8BC All"
        '
        'mi8BCSelected
        '
        Me.mi8BCSelected.Index = 6
        Me.mi8BCSelected.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftB
        Me.mi8BCSelected.Text = "8BC Selected"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miHelpContents, Me.miSeqWeb, Me.MenuItem3, Me.miAbout})
        Me.MenuItem4.Text = "Help"
        '
        'miHelpContents
        '
        Me.miHelpContents.Index = 0
        Me.miHelpContents.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.miHelpContents.Text = "Contents"
        '
        'miSeqWeb
        '
        Me.miSeqWeb.Index = 1
        Me.miSeqWeb.Text = "Sequoyan.com"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "-"
        '
        'miAbout
        '
        Me.miAbout.Index = 3
        Me.miAbout.Text = "About"
        '
        'btnClearSelected
        '
        Me.btnClearSelected.Location = New System.Drawing.Point(56, 288)
        Me.btnClearSelected.Name = "btnClearSelected"
        Me.btnClearSelected.Size = New System.Drawing.Size(90, 18)
        Me.btnClearSelected.TabIndex = 9
        Me.btnClearSelected.Text = "Clear Selected"
        '
        'btn8BCSelected
        '
        Me.btn8BCSelected.Location = New System.Drawing.Point(248, 304)
        Me.btn8BCSelected.Name = "btn8BCSelected"
        Me.btn8BCSelected.Size = New System.Drawing.Size(90, 18)
        Me.btn8BCSelected.TabIndex = 10
        Me.btn8BCSelected.Text = "8BC Selected"
        '
        'lvMain
        '
        Me.lvMain.AllowDrop = True
        Me.lvMain.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chFileName, Me.chVidStd, Me.chBits, Me.chColors, Me.chColorTable, Me.chFullPath})
        Me.lvMain.FullRowSelect = True
        Me.lvMain.GridLines = True
        Me.lvMain.Location = New System.Drawing.Point(8, 8)
        Me.lvMain.Name = "lvMain"
        Me.lvMain.Size = New System.Drawing.Size(440, 274)
        Me.lvMain.TabIndex = 11
        Me.lvMain.View = System.Windows.Forms.View.Details
        '
        'chFileName
        '
        Me.chFileName.Text = "Filename"
        Me.chFileName.Width = 150
        '
        'chVidStd
        '
        Me.chVidStd.Text = "VidStd"
        Me.chVidStd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chVidStd.Width = 45
        '
        'chBits
        '
        Me.chBits.Text = "Format"
        Me.chBits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chBits.Width = 75
        '
        'chColors
        '
        Me.chColors.Text = "Colors"
        Me.chColors.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chColors.Width = 45
        '
        'chColorTable
        '
        Me.chColorTable.Text = "Color Table"
        Me.chColorTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chColorTable.Width = 120
        '
        'chFullPath
        '
        Me.chFullPath.Text = "FullPath"
        Me.chFullPath.Width = 0
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(8, 336)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(296, 240)
        Me.txtLog.TabIndex = 4
        Me.txtLog.Text = ""
        '
        'gbPreview
        '
        Me.gbPreview.Controls.Add(Me.btnViewColorTable)
        Me.gbPreview.Controls.Add(Me.pbPreview)
        Me.gbPreview.Location = New System.Drawing.Point(456, 8)
        Me.gbPreview.Name = "gbPreview"
        Me.gbPreview.Size = New System.Drawing.Size(424, 312)
        Me.gbPreview.TabIndex = 12
        Me.gbPreview.TabStop = False
        Me.gbPreview.Text = "Image Preview"
        '
        'btnViewColorTable
        '
        Me.btnViewColorTable.Location = New System.Drawing.Point(376, 16)
        Me.btnViewColorTable.Name = "btnViewColorTable"
        Me.btnViewColorTable.Size = New System.Drawing.Size(40, 23)
        Me.btnViewColorTable.TabIndex = 3
        Me.btnViewColorTable.Text = "CT"
        '
        'pbPreview
        '
        Me.pbPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbPreview.Location = New System.Drawing.Point(8, 16)
        Me.pbPreview.Name = "pbPreview"
        Me.pbPreview.Size = New System.Drawing.Size(360, 240)
        Me.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPreview.TabIndex = 2
        Me.pbPreview.TabStop = False
        '
        'btnFormResize
        '
        Me.btnFormResize.Location = New System.Drawing.Point(416, 288)
        Me.btnFormResize.Name = "btnFormResize"
        Me.btnFormResize.Size = New System.Drawing.Size(32, 18)
        Me.btnFormResize.TabIndex = 13
        Me.btnFormResize.Text = ">>"
        '
        'FadeOutTimer
        '
        Me.FadeOutTimer.Interval = 25
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(454, 329)
        Me.Controls.Add(Me.btnFormResize)
        Me.Controls.Add(Me.gbPreview)
        Me.Controls.Add(Me.lvMain)
        Me.Controls.Add(Me.btnSelectAll)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.btnLBFILESclear)
        Me.Controls.Add(Me.btn8BCSelected)
        Me.Controls.Add(Me.btn8BC)
        Me.Controls.Add(Me.btnClearSelected)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenus
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "8BC by Sequoyan Software"
        Me.gbPreview.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Globals"
    Private Shared Settings As New clsSettings
#End Region 'Globals

#Region "Form Code"

    Public Sub New(ByVal tmpCtb As clsSettings, ByVal CommandArgs As String())
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Settings = tmpCtb
        For Each tmp As String In CommandArgs
            Select Case Path.GetExtension(tmp).ToLower
                Case ".bmp", ".jpg", ".jpeg", ".gif", ".ico", ".emf", ".wmf", ".png", ".tif", ".tiff", ".exif"
                    ParseDroppedFile(tmp)
            End Select
        Next
        ConfirmSendTo()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Develoment ToDo:
        'todo: extensive options menu asking whether to notify of non-PAL or NTSC images
        'todo: save a report of fixing
        Try
            'AUTHENTICATION
            Dim T As New System.Threading.Thread(AddressOf Authenticate)
            T.Start()
            'END AUTHENTICATION
        Catch ex As Exception

        End Try

        Try
            Me.Left = Settings.FormPositionX
            Me.Top = Settings.FormPositionY
            If Settings.PreviewWindowIsOpen Then
                Me.Width = 896
                Me.btnFormResize.Text = "<<"
            Else
                Me.Width = 464
                Me.btnFormResize.Text = ">>"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            Settings.FormPositionX = Me.Left
            Settings.FormPositionY = Me.Top
            If Me.Width > 890 Then
                Settings.PreviewWindowIsOpen = True
            Else
                Settings.PreviewWindowIsOpen = False
            End If
            If UpdateTextSettings(Settings) Then
                e.Cancel = True
                FadeOutTimer.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

#End Region 'Form Code

#Region "Control Code"

    Private SelectedFilePath As String

    Private Sub lvMain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvMain.SelectedIndexChanged
        If Me.Width > 465 Then
            'try to display thumbnail
            Try
                If Not Me.lvMain.SelectedItems.Count = 0 Then
                    Dim TmpPath As String = CStr(Me.lvMain.SelectedItems(0).SubItems(5).ToString)
                    TmpPath = Microsoft.VisualBasic.Right(TmpPath, Len(TmpPath) - 18)
                    TmpPath = Microsoft.VisualBasic.Left(TmpPath, Len(TmpPath) - 1)
                    Dim bm As New Bitmap(TmpPath)
                    SelectedFilePath = TmpPath

                    'show thubnail
                    Dim callback As System.Drawing.Image.GetThumbnailImageAbort
                    Dim callbackdata As System.IntPtr
                    Dim nWidth As Short = Math.Round(bm.Width / 2)
                    Dim nHeight As Short = Math.Round(bm.Height / 2)
                    Me.pbPreview.Width = nWidth
                    Me.pbPreview.Height = nHeight
                    Me.pbPreview.Image = bm.GetThumbnailImage(nWidth, nHeight, callback, callbackdata)

                    bm.Dispose()
                    bm = Nothing
                Else
                    Me.pbPreview.Image = New Bitmap(Me.pbPreview.Width, Me.pbPreview.Height)
                End If
            Catch ex As Exception
                'MsgBox("Problem generating preview image." & vbnewline & "Error: " & ex.Message)
            End Try
        ElseIf Me.Width < 890 Then

        End If
    End Sub

    Private Sub btnViewColorTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewColorTable.Click
        'check the file to see if it even has a color table
        Dim bm As New Bitmap(SelectedFilePath)
        If System.IO.Path.GetExtension(SelectedFilePath) = ".bmp" And InStr(bm.PixelFormat.ToString.ToLower, "indexed", CompareMethod.Text) Then
            bm.Dispose()
            bm = Nothing
            Dim f As New frmCT(SelectedFilePath)
            f.ShowDialog()
        Else
            bm.Dispose()
            bm = Nothing
            MsgBox("Color table is not available for this image.")
        End If
    End Sub

    Private Sub lvMain_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvMain.KeyUp
        If e.KeyCode = 65 Then
            'MsgBox(e.KeyCode)
            Me.lvMain.BeginUpdate()
            For tmp As Short = 0 To Me.lvMain.Items.Count - 1
                Me.lvMain.Items(tmp).Selected = True
            Next
            Me.lvMain.EndUpdate()
        End If

    End Sub

    Private Sub lvMain_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lvMain.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim MyFiles() As String = e.Data.GetData(DataFormats.FileDrop)
            Dim Ext As String = Path.GetExtension(MyFiles(0)).ToLower
            If (Ext = "") Or (Ext = ".bmp") Or (Ext = ".jpg") Or (Ext = ".jpeg") Or (Ext = ".gif") Or (Ext = ".emf") Or (Ext = ".wmf") Or (Ext = ".png") Or (Ext = ".tif") Or (Ext = ".tiff") Then
                e.Effect = DragDropEffects.All
            Else
                e.Effect = DragDropEffects.None
            End If
        End If
    End Sub

    Private Sub lvMain_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lvMain.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim MyFiles() As String
            Dim i As Integer
            Dim IterateChildren As Short = 0

            ' Assign the files to an array.
            MyFiles = e.Data.GetData(DataFormats.FileDrop)
            ' Loop through the array and add the files to the list.
            lvMain.BeginUpdate()
            For i = 0 To MyFiles.Length - 1
                Dim Ext As String = Path.GetExtension(MyFiles(i)).ToLower
                If (Ext = ".bmp") Or (Ext = ".jpg") Or (Ext = ".jpeg") Or (Ext = ".gif") Or (Ext = ".emf") Or (Ext = ".wmf") Or (Ext = ".png") Or (Ext = ".tif") Or (Ext = ".tiff") Then
                    ParseDroppedFile(MyFiles(i))
                ElseIf Ext = "" Then
                    If IterateChildren = 0 Then
                        If MsgBox("Do you wish to include images in sub-directories?", 65540) = MsgBoxResult.Yes Then
                            IterateChildren = 1
                            iterateDirectories(MyFiles(i), True)
                        Else
                            'do not iterate childen
                            IterateChildren = 2
                        End If
                    ElseIf IterateChildren = 1 Then
                        iterateDirectories(MyFiles(i), True)
                    End If
                End If
            Next
            lvMain.EndUpdate()
            Me.lblCount.Text = CStr(Me.lvMain.Items.Count)
        End If
    End Sub

    Private Sub btn8BCSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8BCSelected.Click
        Selected8BC()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FadeOutTimer.Tick
        Me.Opacity = Me.Opacity - 0.1
        If Me.Opacity <= 0 Then
            Me.Close()
            Application.Exit()
        End If
    End Sub

    Private Sub btnLBFILESclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLBFILESclear.Click
        ClearAll()
    End Sub

    Private Sub btn8BC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8BC.Click
        All8BC()
    End Sub

    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
        SelectAll()
    End Sub

    Private Sub btnClearSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearSelected.Click
        ClearSelected()
    End Sub

    Private Sub btnFormResize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFormResize.Click
        If Me.Width > 890 Then
            Me.Width = 464
            Me.btnFormResize.Text = ">>"
        Else
            Me.Width = 896
            Me.btnFormResize.Text = "<<"
        End If
    End Sub

#End Region 'Control Code

#Region "Functions and Subs"

    Public Sub ParseDroppedFile(ByVal InFile As String)
        Me.btn8BC.Enabled = False
        Me.btn8BCSelected.Enabled = False

        Dim DF As DroppedFile
        Try
            DF = New DroppedFile(InFile)
        Catch ex As Exception
            MsgBox("Problem dropping file. Error: " & ex.Message)
            Exit Sub
        End Try

        'create the listitem and subitems
        If DF.DoDrop = False Then GoTo EndSub
        Try
            Dim fnt As New Font("TimesNewRoman", 8.25)
            Dim itm As New ListViewItem
            itm.UseItemStyleForSubItems = False
            itm.Text = DF.Filename

            If DF.VidStd = "PAL" Or DF.VidStd = "NTSC" Then
                itm.SubItems.Add(DF.VidStd, System.Drawing.Color.Black, System.Drawing.Color.White, fnt)
            Else
                itm.SubItems.Add(DF.VidStd, System.Drawing.Color.White, System.Drawing.Color.Red, fnt)
            End If

            If DF.BitDepth.ToLower = "8bppindexed" Then
                itm.SubItems.Add(DF.BitDepth, System.Drawing.Color.Black, System.Drawing.Color.White, fnt)
            Else
                itm.SubItems.Add(DF.BitDepth, System.Drawing.Color.White, System.Drawing.Color.Red, fnt)
            End If

            If DF.ColorCount = "4" Then
                itm.SubItems.Add(DF.ColorCount, System.Drawing.Color.Black, System.Drawing.Color.White, fnt)
            Else
                itm.SubItems.Add(DF.ColorCount, System.Drawing.Color.White, System.Drawing.Color.Red, fnt)
            End If

            If DF.FinalCTEvaluation.ToLower = "good" Then
                itm.SubItems.Add(DF.FinalCTEvaluation, System.Drawing.Color.Black, System.Drawing.Color.White, fnt)
            Else
                itm.SubItems.Add(DF.FinalCTEvaluation, System.Drawing.Color.White, System.Drawing.Color.Red, fnt)
            End If

            itm.SubItems.Add(DF.Fullpath)

            'add the item
            lvMain.Items.Add(itm)

        Catch ex As Exception
            MsgBox("Problem adding file to listview.  Filename: " & InFile & vbNewLine & "Error: " & ex.Message, MsgBoxStyle.Exclamation)
        End Try

EndSub:
        Me.btn8BCSelected.Enabled = True
        Me.btn8BC.Enabled = True
        DF = Nothing
    End Sub


    Public Sub iterateDirectories(ByVal StartingDirectory As String, ByVal IncludeChildren As Boolean)
        'try to drop folder
        Dim Contents() As String = Directory.GetFileSystemEntries(StartingDirectory)
        For Each tmp As String In Contents
            Dim Ext As String = Microsoft.VisualBasic.Right(Path.GetExtension(tmp).ToLower, 3)
            If (Ext = "bmp") Or (Ext = "jpg") Or (Ext = "jpeg") Or (Ext = "gif") Or (Ext = "emf") Or (Ext = "wmf") Or (Ext = "png") Or (Ext = "tif") Or (Ext = "tiff") Then
                ParseDroppedFile(tmp)
            ElseIf (Ext = "") And (IncludeChildren = True) Then
                iterateDirectories(tmp, True)
            End If
        Next
    End Sub

    Private Sub SelectAll()
        Me.lvMain.Focus()
        Me.lvMain.BeginUpdate()
        For tmp As Short = 0 To Me.lvMain.Items.Count - 1
            Me.lvMain.Items(tmp).Selected = True
        Next
        Me.lvMain.EndUpdate()
    End Sub

    Private Sub ClearAll()
        Me.lvMain.Items.Clear()
        Me.lblCount.Text = "0"
        Me.pbPreview.Image = New Bitmap(Me.pbPreview.Width, Me.pbPreview.Height)
    End Sub

    Private Sub ClearSelected()
        For tmp As Short = Me.lvMain.Items.Count - 1 To 0 Step -1
            If Me.lvMain.Items(tmp).Selected = True Then
                Me.lvMain.Items.RemoveAt(tmp)
            End If
        Next
        Me.pbPreview.Image = New Bitmap(Me.pbPreview.Width, Me.pbPreview.Height)
        Me.lblCount.Text = Me.lvMain.Items.Count
    End Sub

#End Region 'Functions and Subs

#Region "8BC"

    Private Sub All8BC()
        Dim TmpPath As String
        If Settings.DisplayProgBar Then
            Dim frmP As New frmProcessing
            frmP.Show()
            frmP.TotalToProcess = Me.lvMain.Items.Count
            Me.lvMain.BeginUpdate()
            Dim i As Short
            For i = 0 To Me.lvMain.Items.Count - 1
                frmP.CurrentlyProcessing = i + 1
                frmP.Refresh()
                Try
                    TmpPath = CStr(Me.lvMain.Items(i).SubItems(5).ToString)
                    TmpPath = Microsoft.VisualBasic.Right(TmpPath, Len(TmpPath) - 18)
                    TmpPath = Microsoft.VisualBasic.Left(TmpPath, Len(TmpPath) - 1)

                    If Not fn8BC(TmpPath) Then
                        Me.txtLog.Text &= "Error in processing: " & TmpPath
                    End If
                Catch ex As Exception
                    Me.txtLog.Text &= "Error: " & Chr(34) & ex.Message & Chr(34) & " in processing: " & TmpPath
                End Try
            Next
            Me.lvMain.EndUpdate()
            frmP.Close()
            frmP.Dispose()
        Else
            Me.lvMain.BeginUpdate()
            Dim i As Short
            For i = 0 To Me.lvMain.Items.Count - 1
                Try
                    TmpPath = CStr(Me.lvMain.SelectedItems(i).SubItems(5).ToString)
                    TmpPath = Microsoft.VisualBasic.Right(TmpPath, Len(TmpPath) - 18)
                    TmpPath = Microsoft.VisualBasic.Left(TmpPath, Len(TmpPath) - 1)

                    If Not fn8BC(TmpPath) Then
                        Me.txtLog.Text &= "Error in processing: " & TmpPath
                    End If
                Catch ex As Exception
                    Me.txtLog.Text &= "Error: " & Chr(34) & ex.Message & Chr(34) & " in processing: " & TmpPath
                End Try
            Next
            Me.lvMain.EndUpdate()
        End If
        ClearAll()
        UpdateListView()
    End Sub

    Private Sub Selected8BC()
        Dim TmpPath As String
        If Settings.DisplayProgBar Then
            Dim frmP As New frmProcessing
            frmP.Show()
            frmP.TotalToProcess = Me.lvMain.SelectedItems.Count
            Me.lvMain.BeginUpdate()
            Dim i As Short
            For i = 0 To Me.lvMain.SelectedItems.Count - 1
                frmP.CurrentlyProcessing = i + 1
                frmP.Refresh()
                Try
                    TmpPath = CStr(Me.lvMain.SelectedItems(i).SubItems(5).ToString)
                    TmpPath = Microsoft.VisualBasic.Right(TmpPath, Len(TmpPath) - 18)
                    TmpPath = Microsoft.VisualBasic.Left(TmpPath, Len(TmpPath) - 1)

                    If Not fn8BC(TmpPath) Then
                        Me.txtLog.Text &= "Error in processing: " & TmpPath
                    Else
                        Me.lvMain.SelectedItems.Item(i).Remove()
                    End If
                Catch ex As Exception
                    Me.txtLog.Text &= "Error: " & Chr(34) & ex.Message & Chr(34) & " in processing: " & TmpPath
                End Try
            Next
            Me.lvMain.EndUpdate()
            frmP.Close()
            frmP.Dispose()
        Else
            Me.lvMain.BeginUpdate()
            Dim i As Short
            For i = 0 To Me.lvMain.SelectedItems.Count - 1
                Try
                    TmpPath = CStr(Me.lvMain.SelectedItems(i).SubItems(5).ToString)
                    TmpPath = Microsoft.VisualBasic.Right(TmpPath, Len(TmpPath) - 18)
                    TmpPath = Microsoft.VisualBasic.Left(TmpPath, Len(TmpPath) - 1)

                    If Not fn8BC(TmpPath) Then
                        Me.txtLog.Text &= "Error in processing: " & TmpPath
                    End If
                Catch ex As Exception
                    Me.txtLog.Text &= "Error: " & Chr(34) & ex.Message & Chr(34) & " in processing: " & TmpPath
                End Try
            Next
            Me.lvMain.EndUpdate()
        End If
        UpdateListView()
    End Sub

    Public Sub UpdateListView()
        Try
            Dim tmpLIs(Me.lvMain.Items.Count - 1) As ListViewItem
            For tmpInt As Short = 0 To Me.lvMain.Items.Count - 1
                tmpLIs(tmpInt) = Me.lvMain.Items(tmpInt)
            Next

            Me.lvMain.Items.Clear()

            Dim TmpPath As String
            For Each tmpLi As ListViewItem In tmpLIs
                TmpPath = CStr(tmpLi.SubItems(5).ToString)
                TmpPath = Microsoft.VisualBasic.Right(TmpPath, Len(TmpPath) - 18)
                TmpPath = Microsoft.VisualBasic.Left(TmpPath, Len(TmpPath) - 1)
                ParseDroppedFile(TmpPath)
            Next
        Catch ex As Exception
            MsgBox("Problem refreshing the listview." & vbNewLine & "Error: " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Function fn8BC(ByVal SrcPath As String) As Boolean
        Dim bm As Bitmap
        Try
            'fix readonly?
            Dim FAts As FileAttributes = File.GetAttributes(SrcPath)
            If Settings.AutoFixReadOnly Then
                If FAts.ReadOnly Then
                    File.SetAttributes(SrcPath, FileAttributes.Normal)
                End If
            Else
                If FAts.ReadOnly Then
                    MsgBox("Read-only file found and autofix read-only is not activated. File: " & SrcPath)
                    Exit Function
                End If
            End If

            'Dim FS As New FileStream(SrcPath, FileMode.Open, FileAccess.ReadWrite)
            'Me.pbTemp.Image = Image.FromStream(FS)
            'FS.Close()
            'File.Delete(SrcPath)

            bm = New Bitmap(SrcPath)
            Dim pd As String = bm.PixelFormat.ToString

            'Pre proc checks
            'process 24?
            If Not Settings.Process24s Then
                pd = Microsoft.VisualBasic.Right(pd, Len(pd) - 6)
                Dim PixelDepth As Short = Val(pd)
                If PixelDepth = 24 Then
                    MsgBox("Processing of 24bits is disabled. File not processed: " & vbNewLine & SrcPath, MsgBoxStyle.Information)
                    Exit Function
                End If
            End If

            'make as tiff
            If IMG2TIFF(SrcPath, bm) Then
                'now make it a 24b bitmap
                If TIF2BMP(SrcPath) Then
                    'now convert the 24b to an 8b
                    If rou24to8(SrcPath) Then
                        Return True
                        bm.Dispose()
                        bm = Nothing
                    End If
                End If
            End If
            bm.Dispose()
            bm = Nothing
            Return False
        Catch ex As Exception
            MsgBox("Problem in fn8BC." & vbNewLine & "Error: " & ex.Message, MsgBoxStyle.Exclamation)
            Return False
        End Try
        bm = Nothing
    End Function

    Public Function IMG2TIFF(ByVal SrcPath As String, ByVal bm As Bitmap) As Boolean
        Try
            'Dim bm As Bitmap = Me.pbTemp.Image

            Dim imgCodecs() As ImageCodecInfo = ImageCodecInfo.GetImageEncoders()
            Dim imgParams As EncoderParameters = New EncoderParameters(3)

            ' Set quality
            imgParams.Param(0) = New EncoderParameter(Imaging.Encoder.Compression, Imaging.EncoderValue.CompressionNone)
            imgParams.Param(1) = New EncoderParameter(Encoder.ColorDepth, ColorDepth.Depth24Bit)
            imgParams.Param(2) = New EncoderParameter(Encoder.SaveFlag, 0)

            'to save out for testing
            'bm.Save("C:\Documents and Settings\Thomas Fisher\Desktop\temp.tiff", imgCodecs(3), imgParams)

            'bm.Save(SrcPath, imgCodecs(3), imgParams)

            'Dim ms As New MemoryStream
            'bm.Save(ms, imgCodecs(3), imgParams)

            Dim nPath As String = Path.GetDirectoryName(SrcPath) & "\TMPtiff_" & Path.GetFileNameWithoutExtension(SrcPath) & ".tiff"
            Dim fs As New FileStream(nPath, FileMode.OpenOrCreate)
            bm.Save(fs, imgCodecs(3), imgParams)
            fs.Close()
            fs = Nothing
            bm.Dispose()
            bm = Nothing
            Return True
        Catch ex As Exception
            MsgBox("Problem in IMG2TIFF." & vbNewLine & "Error: " & ex.Message, MsgBoxStyle.Exclamation)
            Return False
        End Try
        bm = Nothing
    End Function

    Public Function TIF2BMP(ByVal SrcPath As String) As Boolean
        Dim bm As Bitmap
        Try
            'Kill(SrcPath)
            Dim nPath As String = Path.GetDirectoryName(SrcPath) & "\TMPtiff_" & Path.GetFileNameWithoutExtension(SrcPath) & ".tiff"
            Dim oPath As String = Path.GetDirectoryName(SrcPath) & "\" & "for24to8_" & Path.GetFileNameWithoutExtension(SrcPath) & ".bmp"
            'If File.Exists(oPath) Then File.Delete(oPath)
            bm = New Bitmap(nPath)
            bm.Save(oPath, ImageFormat.Bmp)
            'could open the file here to verify it got created as a 24bit bmp
            bm.Dispose()
            Kill(nPath) 'kill the temp tiff
            Return True
        Catch ex As Exception
            MsgBox("Problem in TIF2BMP." & vbNewLine & "Error: " & ex.Message, MsgBoxStyle.Exclamation)
            Return False
        End Try
        bm = Nothing
    End Function

    Public Function rou24to8(ByVal SrcPath As String) As Boolean
        If Not Directory.Exists(Path.GetDirectoryName(SrcPath) & "\8BC") Then Directory.CreateDirectory(Path.GetDirectoryName(SrcPath) & "\8BC")
        Dim TargPath As String = Path.GetDirectoryName(SrcPath) & "\8BC\" & Path.GetFileNameWithoutExtension(SrcPath) & ".bmp"
        SrcPath = Path.GetDirectoryName(SrcPath) & "\" & "for24to8_" & Path.GetFileNameWithoutExtension(SrcPath) & ".bmp"

        Try
            ' Procedure:
            ' 1) Create array for source 24
            ' 2) Create target array (make sure size is correct)
            ' 3) Populate the 8 bit array (target) up through BOB, make color index correct.
            ' 4) Parse the 24 bit data using the same procedure used in rouFndClstCol
            ' 5) Put the 8 bit array to #f and close #f

            Dim tArray() As Byte
            Dim tArrLng As Long, sArrRasLng As Long, tArrRasLng As Long
            Dim sWidth1 As Byte, sWidth2 As Byte, sWidth3 As Byte, sWidth4 As Byte
            Dim sHeight1 As Byte, sHeight2 As Byte, sHeight3 As Byte, sHeight4 As Byte
            Dim lngFileLen As Long = FileLen(SrcPath)

            Dim tfInt As Long, tfIncre As Long
            Dim Byte1 As Byte, Byte2 As Byte, byte3 As Byte
            Dim Byte1dec As Long, Byte2dec As Long, Byte3dec As Long
            Dim tfInt1 As Long, tfInt2 As Long, tfInt3 As Long
            'Dim tfTFF As Byte, tfZro As Byte
            Dim ABC As Integer, XYZ As Integer
            Dim tf4cnt As Integer, tfIncAdd As Integer
            Dim BGIsBlack As Boolean

            ' 1) Create array for source 24, put data into it

            'opens the file as a stream, uses binary reader to get bytes
            Dim FS As New FileStream(SrcPath, FileMode.Open, FileAccess.ReadWrite)
            Dim BR As New BinaryReader(FS)
            Dim sArray() As Byte = BR.ReadBytes(FS.Length - 1)
            FS.Close()

            Kill(SrcPath) 'kill the temp 24bit bitmap

            ' 2) Create target array (make sure size is correct)
            sArrRasLng = (lngFileLen - 44)
            tArrRasLng = (sArrRasLng / 3)
            tArrLng = (70 + tArrRasLng)

            ReDim tArray(tArrLng)

            ' 3) Populate the 8 bit array (target) up through BOB, make color index correct.

            ' Set File Signature to "BM"
            tArray(0) = CByte(66)
            tArray(1) = CByte(77)

            ' Set File Size
            Dim HexSize As String = Hex(tArrLng)
            tArray(2) = CByte(CInt("&H" & Microsoft.VisualBasic.Right(HexSize, 2)))
            tArray(3) = CByte(CInt("&H" & Microsoft.VisualBasic.Left(Mid(HexSize, 2), 2)))
            tArray(4) = CByte(CInt("&H" & Microsoft.VisualBasic.Left(HexSize, 1)))
            tArray(5) = CByte(0)

            ' Set Reserved
            tArray(6) = CByte(56)
            tArray(7) = CByte(66)
            tArray(8) = CByte(67)
            tArray(9) = CByte(33)

            ' Set Data Offset
            tArray(10) = CByte(70)
            tArray(11) = CByte(0)
            tArray(12) = CByte(0)
            tArray(13) = CByte(0)

            ' Set Info Header Size
            tArray(14) = CByte(40)
            tArray(15) = CByte(0)
            tArray(16) = CByte(0)
            tArray(17) = CByte(0)

            ' Set width
            tArray(18) = sArray(18)
            tArray(19) = sArray(19)
            tArray(20) = sArray(20)
            tArray(21) = sArray(21)

            ' Set height
            tArray(22) = sArray(22)
            tArray(23) = sArray(23)
            tArray(24) = sArray(24)
            tArray(25) = sArray(25)

            ' Set planes
            tArray(26) = CByte(1)
            tArray(27) = CByte(0)

            ' Set bit count
            tArray(28) = CByte(8)
            tArray(29) = CByte(0)

            ' Set compression
            tArray(30) = CByte(0)
            tArray(31) = CByte(0)
            tArray(32) = CByte(0)
            tArray(33) = CByte(0)

            ' Set image size
            tArray(34) = CByte(0)
            tArray(35) = CByte(0)
            tArray(36) = CByte(0)
            tArray(37) = CByte(0)

            ' Set xPixelsPerM
            tArray(38) = CByte(18)
            tArray(39) = CByte(11)
            tArray(40) = CByte(0)
            tArray(41) = CByte(0)

            ' Set yPixelsPerM
            tArray(42) = CByte(18)
            tArray(43) = CByte(11)
            tArray(44) = CByte(0)
            tArray(45) = CByte(0)

            ' Set Colors Used
            tArray(46) = CByte(4)
            tArray(47) = CByte(0)
            tArray(48) = CByte(0)
            tArray(49) = CByte(0)

            ' Set Colors Important
            tArray(50) = CByte(4)
            tArray(51) = CByte(0)
            tArray(52) = CByte(0)
            tArray(53) = CByte(0)

            ' Begin Color Table

            'WORKS
            '' Background
            'tArray(54) = CByte(255)
            'tArray(55) = CByte(255)
            'tArray(56) = CByte(255)
            'tArray(57) = CByte(0)

            '' Position 1 (red)
            'tArray(58) = CByte(0)
            'tArray(59) = CByte(0)
            'tArray(60) = CByte(255)
            'tArray(61) = CByte(0)

            '' Position 2 (green)
            'tArray(62) = CByte(0)
            'tArray(63) = CByte(255)
            'tArray(64) = CByte(0)
            'tArray(65) = CByte(0)

            '' Position 3 (blue)
            'tArray(66) = CByte(255)
            'tArray(67) = CByte(0)
            'tArray(68) = CByte(0)
            'tArray(69) = CByte(0)
            'END WORKS

            ' Background
            tArray(54) = CByte(Settings.TargetColorTable.bgB)
            tArray(55) = CByte(Settings.TargetColorTable.bgG)
            tArray(56) = CByte(Settings.TargetColorTable.bgR)
            tArray(57) = CByte(0)

            ' Position 1 (red)
            tArray(58) = CByte(Settings.TargetColorTable.c1_B)
            tArray(59) = CByte(Settings.TargetColorTable.c1_G)
            tArray(60) = CByte(Settings.TargetColorTable.c1_R)
            tArray(61) = CByte(0)

            ' Position 2 (green)
            tArray(62) = CByte(Settings.TargetColorTable.c2_B)
            tArray(63) = CByte(Settings.TargetColorTable.c2_G)
            tArray(64) = CByte(Settings.TargetColorTable.c2_R)
            tArray(65) = CByte(0)

            ' Position 3 (blue)
            tArray(66) = CByte(Settings.TargetColorTable.c3_B)
            tArray(67) = CByte(Settings.TargetColorTable.c3_G)
            tArray(68) = CByte(Settings.TargetColorTable.c3_R)
            tArray(69) = CByte(0)


            ' 4) Parse the 24 bit data using the same procedure used in rouFndClstCol

            tfIncre = 69

            ' a) For-Next through 24 bit raster data

            For tfInt = 54 To lngFileLen - 4 Step 3
                'On Error GoTo ExitNext

                tfIncre = (tfIncre + 1)

                Byte1dec = CInt(sArray(tfInt))
                Byte2dec = CInt(sArray(tfInt + 1))
                Byte3dec = CInt(sArray(tfInt + 2))

                ' first check if black or white
                If (Byte1dec = 255) And (Byte2dec = 255) And (Byte3dec = 255) Then
                    If tfInt > 54 And BGIsBlack Then
                        'background is black and there are white pixels - bad bad bad graphics designers.
                        MsgBox("Warning: the image currently being processed has a black background and non-background pixels which are white.  These white pixels would be lost during processing so the file will not be processed.  Filename: " & Replace(Path.GetFileName(SrcPath), "for24to8_", "", 1, -1, CompareMethod.Text), MsgBoxStyle.Exclamation)
                        Return True
                    End If
                    GoTo tfBWit
                End If

                If (Byte1dec = 0) And (Byte2dec = 0) And (Byte3dec = 0) Then
                    If tfInt = 54 Then
                        'the background is black. store this info because we need to check to see if there are any
                        'white pixels. Because if there are, they will be lost as the black bg is turned white.
                        BGIsBlack = True
                    End If
                    GoTo tfBlack
                End If

                ' Check for near black or white
                If (Byte1dec > 200) And (Byte2dec > 200) And (Byte3dec > 200) Then GoTo tfBWit
                If (Byte1dec < 50) And (Byte2dec < 50) And (Byte3dec < 50) Then GoTo tfBlack

                ' Now check for other colors
                If (Byte1dec = Byte2dec) Then GoTo tfUnDblit1
                If (Byte1dec = Byte3dec) Then GoTo tfUnDblit2
                If (Byte2dec = Byte3dec) Then GoTo tfUnDblit3
                If (Byte1dec > Byte2dec) And (Byte1dec > Byte3dec) Then GoTo tfBLit
                If (Byte2dec > Byte1dec) And (Byte2dec > Byte3dec) Then GoTo tfGRit
                If (Byte3dec > Byte1dec) And (Byte3dec > Byte2dec) Then GoTo tfRDit

                ' if the referenced color is not black, white, near black, near white, or R, G, or B
                ' then turn the pixel white

tfBWit:
                'turns near white, and white color to white
                tArray(tfIncre) = CByte(0)
                GoTo EndOfNext

tfBlack:
                'turns near black, and black color to whichever position is specified in the options window
                tArray(tfIncre) = CByte(Settings.MapBlackTo)
                GoTo EndOfNext

tfUnDblit1:
                ABC = Byte1dec
                XYZ = Byte3dec

                If ABC > XYZ Then
                    tArray(tfIncre) = CByte(3)
                Else
                    tArray(tfIncre) = CByte(1)
                End If
                GoTo EndOfNext

tfUnDblit2:
                If (Byte1dec > Byte2dec) Then
                    tArray(tfIncre) = CByte(3)
                Else
                    tArray(tfIncre) = CByte(2)
                End If
                GoTo EndOfNext

tfUnDblit3:
                ABC = Byte1dec
                XYZ = Byte2dec

                If ABC < XYZ Then
                    tArray(tfIncre) = CByte(2)
                Else
                    tArray(tfIncre) = CByte(3)
                End If
                GoTo EndOfNext

tfBLit:
                tArray(tfIncre) = CByte(3)
                GoTo EndOfNext

tfGRit:
                tArray(tfIncre) = CByte(2)
                GoTo EndOfNext

tfRDit:
                tArray(tfIncre) = CByte(1)
                GoTo EndOfNext

EndOfNext:
            Next tfInt

ExitNext:

            ' 5) Put the 8 bit array to #f and close #f

            ' open file stream to create new 8bit, write bytes from tArray
            FS = New FileStream(TargPath, FileMode.OpenOrCreate, FileAccess.ReadWrite)
            Dim BW As New IO.BinaryWriter(FS)
            BW.BaseStream.Write(tArray, 0, UBound(tArray))
            FS.Close()
            Return True
        Catch ex As Exception
            MsgBox("Problem in rou24to8." & vbNewLine & "Error: " & ex.Message, MsgBoxStyle.Exclamation)
            Return False
        End Try
    End Function

#End Region '8BC

#Region "Menu Items"

    Private Sub miExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miExit.Click
        Application.Exit()
    End Sub

    Private Sub miSeqWeb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miSeqWeb.Click
        Process.Start("http://www.sequoyan.com")
    End Sub

    Private Sub miHelpContents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miHelpContents.Click
        Process.Start("http://support.sequoyan.com")
    End Sub

    Private Sub miOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miOptions.Click
        Settings.FormPositionX = Me.Left
        Settings.FormPositionY = Me.Top
        Dim frmOptions As New frmOptions(Settings)
        frmOptions.ShowDialog()
    End Sub

    Private Sub miSaveReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miSaveReport.Click
        MsgBox("Not Implemented")
    End Sub

    Private Sub miClearSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miClearSelected.Click
        ClearSelected()
    End Sub

    Private Sub miSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miSelectAll.Click
        SelectAll()
    End Sub

    Private Sub miClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miClearAll.Click
        ClearAll()
    End Sub

    Private Sub mi8BCSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mi8BCSelected.Click
        Selected8BC()
    End Sub

    Private Sub miAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miAbout.Click
        MsgBox("8BC by Sequoyan Software" & vbNewLine & "Version: " & Application.ProductVersion & vbNewLine & vbNewLine & "8BC Copyright " & Chr(169) & " 2002-2004 Sequoyan Software." & vbNewLine & vbNewLine & "WARNING: This computer program is protected by copyright law and international treaties. Unauthorized duplication or distribution of this program, or any portion of it, may result in severe civil or criminal penalties, and will be prosecuted to the maximum extent possible under the law.", MsgBoxStyle.Information, "About 8BC")
    End Sub

    Private Sub mi8BCAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mi8BCAll.Click
        All8BC()
    End Sub

#End Region 'Menu Items

End Class
