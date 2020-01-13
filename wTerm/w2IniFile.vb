Option Explicit On 
Option Strict On

Public Class w2IniFile
    ' API functions
#Region "API"
    Private Declare Ansi Function GetPrivateProfileString _
      Lib "kernel32.dll" Alias "GetPrivateProfileStringA" _
      (ByVal lpApplicationName As String, _
      ByVal lpKeyName As String, ByVal lpDefault As String, _
      ByVal lpReturnedString As String, _
      ByVal nSize As Integer, ByVal lpFileName As String) _
      As Integer

    Private Declare Ansi Function WritePrivateProfileString _
      Lib "kernel32.dll" Alias "WritePrivateProfileStringA" _
      (ByVal lpApplicationName As String, _
      ByVal lpKeyName As String, ByVal lpString As String, _
      ByVal lpFileName As String) As Integer

    'Private Declare Ansi Function GetPrivateProfileInt _
    '  Lib "kernel32.dll" Alias "GetPrivateProfileIntA" _
    '  (ByVal lpApplicationName As String, _
    '  ByVal lpKeyName As String, ByVal nDefault As Integer, _
    '  ByVal lpFileName As String) As Integer

    'Private Declare Ansi Function FlushPrivateProfileString _
    '  Lib "kernel32.dll" Alias "WritePrivateProfileStringA" _
    '  (ByVal lpApplicationName As Integer, _
    '  ByVal lpKeyName As Integer, ByVal lpString As Integer, _
    '  ByVal lpFileName As String) As Integer

#End Region

    Private mFile As String
    Private mSize As Integer

    Public Sub New(ByVal sFile As String)
        mFile = sFile
        mSize = 1024
    End Sub

    Public Sub New(ByVal sFile As String, ByVal MaxStringLength As Integer)
        mFile = sFile
        mSize = MaxStringLength
    End Sub

    Public ReadOnly Property FileName() As String
        Get
            Return mFile
        End Get
    End Property

    'read/write parameters
    Public Overloads Function ReadParameter(ByVal sSection As String, ByVal sKey As String, _
                                            ByVal sDefault As String) As String
        Dim sReturn As String
        Dim X As Integer

        sReturn = Space(mSize)
        X = GetPrivateProfileString(sSection, sKey, sDefault, sReturn, sReturn.Length, mFile)

        If X > 0 Then
            Return sReturn.Substring(0, X).Trim
        Else
            Return sDefault
        End If
    End Function

    Public Overloads Function ReadParameter(ByVal sSection As String, ByVal sKey As String, _
                                            ByVal vDefault As Double) As Double
        Dim s As String

        s = Me.ReadParameter(sSection, sKey, "")
        If s <> "" Then
            Try
                Return Double.Parse(s)
            Catch ex As Exception
                Return vDefault
            End Try
        Else
            Return vDefault
        End If
    End Function

    Public Overloads Function ReadParameter(ByVal sSection As String, ByVal sKey As String, _
                                           ByVal vDefault As Integer) As Integer
        Return Convert.ToInt32(ReadParameter(sSection, sKey, Convert.ToDouble(vDefault)))
    End Function

    Public Overloads Function ReadParameter(ByVal sSection As String, ByVal sKey As String, _
                                            ByVal bDefault As Boolean) As Boolean
        Dim s As String

        s = Me.ReadParameter(sSection, sKey, "")
        If s = "" Then
            Return bDefault
        Else
            Return s.ToLower = "true" Or s.ToLower = "1"
        End If

    End Function

    Public Function WriteParemeter(ByVal sSection As String, ByVal sKey As String, _
                                   ByVal sValue As String) As Boolean
        Dim X As Integer

        X = WritePrivateProfileString(sSection, sKey, sValue, mFile)

        Return (X <> 0)
    End Function

    'read all section headers
    Public Function GetAllSections(Optional ByVal TotalLength As Integer = 1024, _
                                   Optional ByVal sDelimiter As String = Chr(0)) As String
        Dim sReturn As String
        Dim X As Integer

        'creat bufffer
        sReturn = Space(TotalLength)

        'read
        X = GetPrivateProfileString(vbNullString, "", "", sReturn, sReturn.Length, mFile)


        If X > 0 Then
            'parse
            sReturn = sReturn.Substring(0, X)
            If sReturn.Substring(X - 1, 1) = Chr(0) Then sReturn = sReturn.Substring(0, X - 1)
            If sDelimiter <> Chr(0) Then
                sReturn = sReturn.Replace(Chr(0), sDelimiter)
            End If

            'return
            Return sReturn

        Else
            Return ""
        End If
    End Function

    Public Function GetAllKeys(ByVal sSection As String, _
                               Optional ByVal TotalLength As Integer = 1024, _
                               Optional ByVal sDelimiter As String = Chr(0)) As String

        Dim sReturn As String
        Dim X As Integer

        'creat bufffer
        sReturn = Space(TotalLength)

        'read
        X = GetPrivateProfileString(sSection, vbNullString, "", sReturn, sReturn.Length, mFile)

        'parse
        If X > 0 Then
            sReturn = sReturn.Substring(0, X)
            If sReturn.Substring(X - 1, 1) = Chr(0) Then sReturn = sReturn.Substring(0, X - 1)
            If sDelimiter <> Chr(0) Then
                sReturn = sReturn.Replace(Chr(0), sDelimiter)
            End If
            'return
            Return sReturn

        Else
            Return ""
        End If
    End Function

    'delete part of files
    Public Function DeleteParameter(ByVal sSection As String, ByVal sKey As String) As Boolean
        Dim X As Integer

        X = WritePrivateProfileString(sSection, sKey, vbNullString, mFile)

        Return (X <> 0)
    End Function

    Public Function DeleteSection(ByVal sSection As String) As Boolean
        Dim X As Integer

        X = WritePrivateProfileString(sSection, vbNullString, vbNullString, mFile)

        Return (X <> 0)
    End Function
End Class

Public Class w2TrackUser
    Private Const cstCUSection$ = "Current Users"
    Private Const cstAUSection$ = "All Users"

    Private mIniFile As w2IniFile

    Public Sub New(ByVal sFile As String)
        mIniFile = New w2IniFile(sFile)
    End Sub

    Public ReadOnly Property FileName() As String
        Get
            Return mIniFile.FileName
        End Get
    End Property

    Public ReadOnly Property ComputerName() As String
        Get
            Return SystemInformation.ComputerName
        End Get
    End Property

    Public ReadOnly Property UserName() As String
        Get
            Return SystemInformation.UserName
        End Get
    End Property

    Public Sub AddToList()
        Dim sValue As String = ""
        Dim sKey As String = ""

        GetKeyAndValue(sKey, sValue)
        mIniFile.WriteParemeter(cstCUSection, sKey, sValue)
    End Sub

    Public Sub RemoveFromList()
        Dim sValue As String = ""
        Dim sKey As String = ""

        GetKeyAndValue(sKey, sValue)

        'remove from current
        mIniFile.DeleteParameter(cstCUSection, sKey)

        'add to history
        mIniFile.WriteParemeter(cstAUSection, sKey, sValue)
    End Sub

    Private Sub GetKeyAndValue(ByRef sKey As String, ByRef sValue As String)
        Dim sRev As String

        'get rev
        sRev = "Rev " & Application.ProductVersion

        'use computer name as key, this unique
        sKey = Me.ComputerName

        'use user name and time stamp as value, now with rev
        sValue = Me.UserName & vbTab & sKey & vbTab & vbTab & sRev & vbTab & Date.Now
    End Sub

End Class