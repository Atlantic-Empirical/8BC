Imports System.Net

Module Authentication

    Public Sub Authenticate()
        Try
            'Dim AuthServer As New AuthServer_localhost.AuthServer
            'Dim AD As New AuthServer_localhost.AuthData

            Dim AuthServer As New AuthServer_SequoyanCom.AuthServer
            Dim AD As New AuthServer_SequoyanCom.AuthData

            Dim SE As System.Environment
            Dim DNSInfo As IPHostEntry = Dns.Resolve("localhost")
            With AD
                .HostName = DNSInfo.HostName
                .IPAddress = DNSInfo.AddressList(0).ToString
                .CLRVersion = SE.Version.ToString
                .DomainName = SE.UserDomainName.ToString
                .LogicalDrives = SE.GetLogicalDrives
                .MachineName = SE.MachineName
                .OSVersion = SE.OSVersion.Platform.ToString & " " & SE.OSVersion.Version.ToString
                .UserName = SE.UserName
                .AppName = Application.ProductName
                .AppVersion = Application.ProductVersion
                .MACAddress = GetNetworkInfo("macaddress")
                .HDSerial = GetVolumeSerial("C")
                .CPUSerial = CPUInfo("cpuserial")
                .CPUInfo = CPUInfo("cpuinfo")
            End With
            If Not AuthServer.AuthMe(AD) Then
                If MsgBox("Authentication failed. Application exiting.", MsgBoxStyle.OKOnly) = MsgBoxResult.OK Then
                    'will this catch if they close the msgbox?
                    Application.Exit()
                End If
            End If
        Catch ex As Exception
            'oh well, do nothing
        End Try
    End Sub

    Public Function GetVolumeSerial(ByVal strDriveLetter As String) As String
        Try
            If strDriveLetter = "" OrElse strDriveLetter Is Nothing Then
                strDriveLetter = "C"
            End If
            Dim disk As New System.Management.ManagementObject("win32_logicaldisk.deviceid=""" + strDriveLetter + ":""")
            disk.Get()
            Return disk("VolumeSerialNumber").ToString()
        Catch ex As Exception
            Return "Error: " & ex.Message
        End Try
    End Function

    Public Function GetNetworkInfo(ByVal GetWhat As String) As String
        Try
            Dim mc As System.Management.ManagementClass
            Dim mo As System.Management.ManagementObject
            mc = New System.Management.ManagementClass("Win32_NetworkAdapterConfiguration")
            Dim moc As System.Management.ManagementObjectCollection = mc.GetInstances()
            For Each mo In moc
                Select Case GetWhat.ToLower
                    Case "macaddress"
                        If mo.Item("IPEnabled") = True Then
                            Return Trim(mo.Item("MacAddress").ToString())
                        End If
                End Select
            Next
        Catch ex As Exception
            Return "Error: " & ex.Message
        End Try
    End Function

    Public Function CPUInfo(ByVal GetWhat As String) As String
        Try
            Dim moReturn As System.Management.ManagementObjectCollection
            Dim moSearch As System.Management.ManagementObjectSearcher
            Dim mo As System.Management.ManagementObject
            moSearch = New System.Management.ManagementObjectSearcher("Select * from Win32_Processor")
            moReturn = moSearch.Get
            For Each mo In moReturn
                Select Case GetWhat.ToLower
                    Case "cpuinfo"
                        Return Trim(String.Format("{0} - {1}", mo("Name"), mo("CurrentClockSpeed")))
                    Case "cpuserial"
                        Return Trim(mo("ProcessorID"))
                End Select
            Next
        Catch ex As Exception
            Return "Error:" & ex.Message
        End Try
    End Function

End Module
