Imports System.IO

Public Class DroppedFile
    Public Filename As String
    Public Fullpath As String
    Public VidStd As String
    Public Bitmap As Bitmap
    Public Bytes() As Byte
    Public BitDepth As String
    Public ColorCount As String
    Public ColorCount_sh As Short
    Public FlippedColors As String
    Public NonRGBColors As String
    Public ColorOrder As String
    Public FinalCTEvaluation As String
    Public DoDrop As Boolean

    Public Sub New(ByVal nPath As String)
        Me.Fullpath = nPath
        Me.Filename = Path.GetFileName(nPath)
        Me.Bytes = GetFileBytes(nPath)
        Try
            Me.Bitmap = New Bitmap(nPath)
        Catch ex As Exception
            MsgBox("This file cannot be processed by 8BC: " & vbNewLine & vbNewLine & nPath & vbNewLine & vbNewLine & "This is usually caused by the drop of a Tiff file with either Jpg or Zip compression (which are not currently supported).", 65600)
            Me.DoDrop = False
            Exit Sub
        End Try
        Me.VidStd = SetVidStd(Me.Bitmap.Height)
        Me.BitDepth = SetBitDepth(Me.Bitmap.PixelFormat.ToString)
        If Not Me.Bytes Is Nothing Then
            Me.ColorCount = ReturnColorCount(Me.Bytes(46))
            Try
                Me.ColorCount_sh = CShort(Me.ColorCount)
            Catch ex As Exception
                Me.ColorCount_sh = -1
                GoTo Escape
            End Try
            Me.FlippedColors = ReturnFlippedColors()
            Me.NonRGBColors = ReturnNonRGB()
            Me.ColorOrder = ReturnColorOrder()
            Me.FinalCTEvaluation = FinishColorTable()
        Else
            Me.ColorCount = "N/A"
Escape:
            Me.FlippedColors = "N/A"
            Me.NonRGBColors = "N/A"
            Me.ColorOrder = "N/A"
            Me.FinalCTEvaluation = "N/A"
            Me.Bitmap.Dispose()
            Me.Bitmap = Nothing
        End If
        DoDrop = True
    End Sub

    Public Function FinishColorTable() As String
        Try
            'flipped, nonRGB, order
            Dim Tmp As String

            If Not Me.FlippedColors = "ok" Then
                Tmp &= Me.FlippedColors
            End If

            If Not Me.NonRGBColors = "ok" Then
                If Not Tmp = "" Then
                    Tmp &= ", " & Me.NonRGBColors
                Else
                    Tmp = Me.NonRGBColors
                End If
            End If

            If Not Me.ColorOrder = "ok" Then
                If Not Tmp = "" Then
                    Tmp &= ", " & Me.ColorOrder
                Else
                    Tmp = Me.ColorOrder
                End If
            End If

            If Tmp = "" Then
                Return "good"
            Else
                Return Replace(Tmp, "N/A,", "", 1, -1, CompareMethod.Text)
            End If
        Catch ex As Exception
            Return "error"
        End Try

    End Function

    Public Function ReturnColorOrder() As String
        'check for out of order colors in the color table using gdmx standard
        Try
            Dim NumCols As Integer, NumBytesColTbl As Integer, LastByteColTbl As Integer
            Dim tmpHoldByte As Byte
            ' look for bytes in the color table that are neither 00 or ff, there shouldn't be any. But if there are then the routiene runs.
            NumCols = ColorCount_sh
            NumBytesColTbl = (NumCols * 4)
            LastByteColTbl = (54 + NumBytesColTbl)
            Dim b1, b2, b3 As Byte
            For i As Short = 54 To LastByteColTbl - 1 Step 4
                If Not i = 54 Then
                    b1 = Me.Bytes(i)
                    b2 = Me.Bytes(i + 1)
                    b3 = Me.Bytes(i + 2)

                    If (b1 = 0 And b2 = 0 And b3 = 0) Or (b1 = 255 And b2 = 255 And b3 = 255) Then
                        Return "non-GDMX"
                        Exit For
                    End If
                End If
            Next i
            Return "ok"
        Catch ex As Exception
            Return "error"
        End Try

    End Function

    Public Function ReturnNonRGB() As String
        Try
            If Not Me.ColorCount = "4" Or Me.ColorCount = "8" Then Return "N/A"

            ' Look for bytes in the color table that are neither 00 or ff, there shouldn't be any. 
            ' But if there are then the routiene runs.
            Dim LastByteColTbl As Integer = (54 + (ColorCount_sh * 4))
            Dim tmpHoldByte As Byte
            For i As Integer = 54 To LastByteColTbl - 1
                tmpHoldByte = Me.Bytes(i)
                'MsgBox (tmpHoldByte)
                If (tmpHoldByte <> 0) And (tmpHoldByte <> 255) Then
                    'MsgBox "byte #: " & i & " is not RGB."
                    Return "non-RGB"
                End If
            Next i
            Return "ok"
        Catch
            Return "error"
        End Try

    End Function

    Public Function ReturnFlippedColors() As String
        Try
            If Me.Bytes(CInt(Me.Bytes(10).ToString) + 1) <> 0 Then
                Return "flipped"
            Else
                Return "ok"
            End If
        Catch ex As Exception
            Return "error"
        End Try
    End Function

    Public Function ReturnColorCount(ByVal nByte As Byte) As String
        Try
            Dim s As String = CStr(nByte)
            If s <> "0" Then
                Return s
            Else
                Return "N/A"
            End If
        Catch ex As Exception
            Return "error"
        End Try
    End Function

    Public Function SetBitDepth(ByVal Value As String) As String
        Try
            Return Microsoft.VisualBasic.Right(Value, Len(Value) - 6)
        Catch ex As Exception
            Return "error"
        End Try
    End Function

    Public Function GetFileBytes(ByVal nPath) As Byte()
        'Get bytes of image file for later use
        Try
            Dim tmpBytes() As Byte
            If Path.GetExtension(nPath) = ".bmp" Then
                Dim fs As New FileStream(nPath, FileMode.Open)
                ReDim tmpBytes(200)
                fs.Read(tmpBytes, 0, 200)
                fs.Close()
                fs = Nothing
                Return tmpBytes


                'Dim br As New BinaryReader(fs)
                'ReDim tmpBytes(200)
                'br.Read(tmpBytes, 0, nPath.Length - 1)
                'br.Close()
                'fs.Close()
                'br = Nothing
                'fs = Nothing
                'Return tmpBytes
            End If
        Catch ex As Exception
            MsgBox("Problem getting bytes of dropped bitmap." & vbNewLine & "Error: " & ex.Message, MsgBoxStyle.Exclamation)
            Return Nothing
        End Try
    End Function


    Public Function SetVidStd(ByVal Value As Short) As String
        Try
            If Value = 480 Then
                Return "NTSC"
            ElseIf Value = "576" Then
                Return "PAL"
            Else
                Return "?"
            End If
        Catch ex As Exception
            Return "error"
        End Try
    End Function
End Class
