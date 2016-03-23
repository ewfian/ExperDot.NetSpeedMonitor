Imports System.Diagnostics


''' <summary>
''' Represents a network adapter installed on the machine.
''' Properties of this class can be used to obtain current network speed.
''' </summary>
Public Class NetworkAdapter
        ''' <summary>
        ''' Instances of this class are supposed to be created only in an NetworkMonitor.
        ''' </summary>
        Friend Sub New(name As String)
            Me.m_name = name
        End Sub

        Private dlSpeed As Long, ulSpeed As Long
        ' Download/Upload speed in bytes per second.
        Private dlValue As Long, ulValue As Long
        ' Download/Upload counter value in bytes.
        Private dlValueOld As Long, ulValueOld As Long
        ' Download/Upload counter value one second earlier, in bytes.
        Friend m_name As String
        ' The name of the adapter.
        Friend dlCounter As PerformanceCounter, ulCounter As PerformanceCounter
        ' Performance counters to monitor download and upload speed.
        ''' <summary>
        ''' Preparations for monitoring.
        ''' </summary>
        Friend Sub init()
            ' Since dlValueOld and ulValueOld are used in method refresh() to calculate network speed, they must have be initialized.
            Me.dlValueOld = Me.dlCounter.NextSample().RawValue
            Me.ulValueOld = Me.ulCounter.NextSample().RawValue
        End Sub
        ''' <summary>
        ''' Obtain new sample from performance counters, and refresh the values saved in dlSpeed, ulSpeed, etc.
        ''' This method is supposed to be called only in NetworkMonitor, one time every second.
        ''' </summary>
        Friend Sub refresh()
            Me.dlValue = Me.dlCounter.NextSample().RawValue
            Me.ulValue = Me.ulCounter.NextSample().RawValue

            ' Calculates download and upload speed.
            Me.dlSpeed = Me.dlValue - Me.dlValueOld
            Me.ulSpeed = Me.ulValue - Me.ulValueOld

            Me.dlValueOld = Me.dlValue
            Me.ulValueOld = Me.ulValue
        End Sub
        ''' <summary>
        ''' Overrides method to return the name of the adapter.
        ''' </summary>
        ''' <returns>The name of the adapter.</returns>
        Public Overrides Function ToString() As String
            Return Me.m_name
        End Function
        ''' <summary>
        ''' The name of the network adapter.
        ''' </summary>
        Public ReadOnly Property Name() As String
            Get
                Return Me.m_name
            End Get
        End Property
        ''' <summary>
        ''' Current download speed in bytes per second.
        ''' </summary>
        Public ReadOnly Property DownloadSpeed() As Long
            Get
                Return Me.dlSpeed
            End Get
        End Property
        ''' <summary>
        ''' Current upload speed in bytes per second.
        ''' </summary>
        Public ReadOnly Property UploadSpeed() As Long
            Get
                Return Me.ulSpeed
            End Get
        End Property
        ''' <summary>
        ''' Current download speed in kbytes per second.
        ''' </summary>
        Public ReadOnly Property DownloadSpeedKbps() As Double
            Get
                Return Me.dlSpeed / 1024.0
            End Get
        End Property
    ''' <summary>
    ''' Current upload speed in kbytes per second.
    ''' </summary>
    Public ReadOnly Property UploadSpeedKbps() As Double
        Get
            Return Me.ulSpeed / 1024.0
        End Get
    End Property
    ''' <summary>
    ''' Current upload speed in kbytes per second.
    ''' </summary>
    Public ReadOnly Property DownloadSpeedString() As String
        Get
            If dlSpeed < 1048576 Then
                Return [String].Format("{0:n} KB/S", Me.dlSpeed / 1024.0)
            Else
                Return [String].Format("{0:n} MB/S", Me.dlSpeed / 1048576)
            End If
        End Get
    End Property
    ''' <summary>
    ''' Current upload speed in kbytes per second.
    ''' </summary>
    Public ReadOnly Property UploadSpeedString() As String
        Get
            If ulSpeed < 1048576 Then
                Return [String].Format("{0:n} KB/S", Me.ulSpeed / 1024.0)
            Else
                Return [String].Format("{0:n} MB/S", Me.ulSpeed / 1048576)
            End If
        End Get
    End Property
End Class

