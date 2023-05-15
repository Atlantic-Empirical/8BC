Imports System.IO

Module modMain

    Public Sub main(ByVal CmdArgs() As String)
        Dim s As New clsSettings
        s = GetSettings(True)
        Dim frmMain As New frmMain(s, CmdArgs)
        frmMain.ShowDialog()
    End Sub
End Module
