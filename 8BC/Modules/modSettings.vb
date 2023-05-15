Option Explicit On 
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization

Public Module modSettings

    Public Sub ConfirmSendTo()
        'check to make sure the link is in the send to path
        Try
            Dim SendToPath As String = "C:\Documents and Settings\" & Environment.UserName & "\SendTo\8BC.lnk"
            If Not File.Exists(SendToPath) Then
                Dim fs As New FileStream(SendToPath, FileMode.OpenOrCreate)
                Dim bw As New BinaryWriter(fs)
                bw.Write(stringToByteArray("76 0 0 0 1 20 2 0 0 0 0 0 192 0 0 0 0 0 0 70 155 0 0 0 32 0 0 0 0 44 188 172 244 211 195 1 64 250 89 67 247 211 195 1 48 129 131 233 245 211 195 1 0 48 2 0 0 0 0 0 1 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 37 1 20 0 31 80 224 79 208 32 234 58 105 16 162 216 8 0 43 48 48 157 25 0 47 67 58 92 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 74 0 49 0 0 0 0 0 38 48 137 8 17 0 80 82 79 71 82 65 126 49 0 0 50 0 3 0 4 0 239 190 144 46 141 110 38 48 140 8 20 0 0 0 80 0 114 0 111 0 103 0 114 0 97 0 109 0 32 0 70 0 105 0 108 0 101 0 115 0 0 0 24 0 64 0 49 0 0 0 0 0 38 48 137 8 16 0 83 101 113 117 111 121 97 110 0 0 40 0 3 0 4 0 239 190 38 48 137 8 38 48 172 8 20 0 0 0 83 0 101 0 113 0 117 0 111 0 121 0 97 0 110 0 0 0 24 0 48 0 49 0 0 0 0 0 38 48 33 13 16 0 56 66 67 0 30 0 3 0 4 0 239 190 38 48 137 8 38 48 33 13 20 0 0 0 56 0 66 0 67 0 0 0 18 0 60 0 50 0 0 48 2 0 38 48 236 12 32 0 56 66 67 46 101 120 101 0 38 0 3 0 4 0 239 190 38 48 208 11 38 48 34 14 20 0 0 0 56 0 66 0 67 0 46 0 101 0 120 0 101 0 0 0 22 0 0 0 84 0 0 0 28 0 0 0 1 0 0 0 28 0 0 0 45 0 0 0 0 0 0 0 83 0 0 0 17 0 0 0 3 0 0 0 9 46 155 28 16 0 0 0 0 67 58 92 80 114 111 103 114 97 109 32 70 105 108 101 115 92 83 101 113 117 111 121 97 110 92 56 66 67 92 56 66 67 46 101 120 101 0 0 43 0 46 0 46 0 92 0 46 0 46 0 92 0 46 0 46 0 92 0 80 0 114 0 111 0 103 0 114 0 97 0 109 0 32 0 70 0 105 0 108 0 101 0 115 0 92 0 83 0 101 0 113 0 117 0 111 0 121 0 97 0 110 0 92 0 56 0 66 0 67 0 92 0 56 0 66 0 67 0 46 0 101 0 120 0 101 0 29 0 67 0 58 0 92 0 80 0 114 0 111 0 103 0 114 0 97 0 109 0 32 0 70 0 105 0 108 0 101 0 115 0 92 0 83 0 101 0 113 0 117 0 111 0 121 0 97 0 110 0 92 0 56 0 66 0 67 0 16 0 0 0 5 0 0 160 38 0 0 0 119 0 0 0 96 0 0 0 3 0 0 160 88 0 0 0 0 0 0 0 103 101 99 107 111 0 0 0 0 0 0 0 0 0 0 0 170 109 212 122 248 71 250 70 143 156 64 165 179 207 159 17 16 74 107 213 234 63 216 17 144 199 0 144 75 177 182 3 170 109 212 122 248 71 250 70 143 156 64 165 179 207 159 17 16 74 107 213 234 63 216 17 144 199 0 144 75 177 182 3 0 0 0 0"))
                bw.Close()
                bw = Nothing
                fs.Close()
                fs = Nothing
            End If
        Catch ex As Exception
            'eat it, who really cares huh?
            'if they must have it they'll do it themselves
        End Try
    End Sub

    Public Function GetSettings(ByVal DoLoop As Boolean) As clsSettings
        'try to load the settings
        Dim nPath As String = Path.GetDirectoryName(Application.ExecutablePath) & "\8BC_Settings.SEQ_SET"
        If File.Exists(nPath) Then
            Dim fs As New FileStream(nPath, FileMode.Open)
            Try
                'Dim binary_formatter As New BinaryFormatter
                'Dim file_stream As New FileStream(Path.GetDirectoryName(Application.ExecutablePath) & "\8BC_Settings.SEQ_SET", FileMode.Open)
                'Dim settings As clsSettings = CType(binary_formatter.Deserialize(file_stream), clsSettings)
                'file_stream.Close()

                Dim xml_serializer As New XmlSerializer(GetType(clsSettings))
                Dim settings As clsSettings = CType(xml_serializer.Deserialize(fs), clsSettings)
                xml_serializer = Nothing
                fs.Close()
                fs = Nothing

                Return settings
            Catch ex As Exception
                MsgBox("Error loading settings, settings recreated. Error message: " & ex.Message)
                If fs.CanRead Then fs.Close()
                File.Delete(nPath)
                If DoLoop Then
                    GetSettings(False)
                End If
            End Try
        Else
            'create new settings
            Dim Settings As New clsSettings
            Settings.AutoFixReadOnly = True
            Settings.DisplayProgBar = True
            Settings.FirstRun = CStr(DateTime.Now)
            Settings.FormPositionX = 100
            Settings.FormPositionY = 100
            Settings.Process24s = False
            Settings.MapBlackTo = 0
            settings.PreviewWindowIsOpen = False

            Settings.TargetColorTable.bgB = 255
            Settings.TargetColorTable.bgG = 255
            Settings.TargetColorTable.bgR = 255

            Settings.TargetColorTable.c1_B = 0
            Settings.TargetColorTable.c1_G = 0
            Settings.TargetColorTable.c1_R = 255

            Settings.TargetColorTable.c2_B = 0
            Settings.TargetColorTable.c2_G = 255
            Settings.TargetColorTable.c2_R = 0

            Settings.TargetColorTable.c3_B = 255
            Settings.TargetColorTable.c3_G = 0
            Settings.TargetColorTable.c3_R = 0
            Return Settings
        End If
    End Function

    Public Function UpdateTextSettings(ByVal newSettings As clsSettings) As Boolean
        Try
            'If File.Exists(Path.GetDirectoryName(Application.ExecutablePath) & "\8BC_Settings.SEQ_SET") Then File.Delete(Path.GetDirectoryName(Application.ExecutablePath) & "\8BC_Settings.SEQ_SET")
            'Dim binary_formatter As New BinaryFormatter
            'Dim file_stream As New FileStream(Path.GetDirectoryName(Application.ExecutablePath) & "\8BC_Settings.SEQ_SET", FileMode.Create)
            'binary_formatter.Serialize(file_stream, GetType(clsSettings))
            'file_stream.Close()

            If File.Exists(Path.GetDirectoryName(Application.ExecutablePath) & "\8BC_Settings.SEQ_SET") Then File.Delete(Path.GetDirectoryName(Application.ExecutablePath) & "\8BC_Settings.SEQ_SET")
            Dim fs As New FileStream(Path.GetDirectoryName(Application.ExecutablePath) & "\8BC_Settings.SEQ_SET", FileMode.OpenOrCreate)
            Dim xml_serializer As New XmlSerializer(GetType(clsSettings))
            xml_serializer.Serialize(fs, newSettings)
            fs.Close()
            fs = Nothing
        Catch ex As Exception
            MsgBox("Problem updating text settings. Error: " & ex.Message)
        End Try
    End Function

    <Serializable()> _
    Public Class clsSettings
        Public FormPositionX As Short
        Public FormPositionY As Short
        Public FirstRun As String
        Public AutoFixReadOnly As Boolean
        Public Process24s As Boolean
        Public DisplayProgBar As Boolean
        Public MapBlackTo As Short
        Public TargetColorTable As clsTargetColorTable
        Public PreviewWindowIsOpen As Boolean

        Public Sub New()
            TargetColorTable = New clsTargetColorTable
        End Sub
    End Class

    Public Class clsTargetColorTable
        'Background
        Public bgB As Byte 'Blue
        Public bgG As Byte 'Green
        Public bgR As Byte 'Red
        Public bgDummy As Byte 'Dummy

        'Color One
        Public c1_B As Byte
        Public c1_G As Byte
        Public c1_R As Byte
        Public c1_Dummy As Byte

        'Color Two
        Public c2_B As Byte
        Public c2_G As Byte
        Public c2_R As Byte
        Public c2_Dummy As Byte

        'Color Three
        Public c3_B As Byte
        Public c3_G As Byte
        Public c3_R As Byte
        Public c3_Dummy As Byte
    End Class

End Module
