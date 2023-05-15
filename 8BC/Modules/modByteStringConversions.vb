Module modByteStringConversions
    'stringToByteArray(): converts a string of numbers into a byte array. 
    Public Function stringToByteArray(ByVal str As String) As Byte()
        ' e.g. "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16" to 
        '{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16}
        Dim s As String()
        s = str.Split(" ")
        Dim b(s.Length - 1) As Byte
        Dim i As Integer
        For i = 0 To s.Length - 1
            b(i) = Convert.ToByte(s(i))
        Next
        Return b
    End Function
End Module
