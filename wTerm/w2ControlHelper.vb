Option Explicit On
Option Strict On

Public Class w2ContextMenu
    Dim mMenu As ContextMenuStrip
    Dim mCtrl As Control

    Public Sub New(ByVal Control As Control, ByVal ImageList As ImageList)
        'build menu
        mMenu = New ContextMenuStrip()
        With mMenu.Items
            .Add("Copy")
            .Add("Delete")
            .Add("Clear All")
            .Add(New ToolStripSeparator)
            .Add("Select None")
            .Add("Select All")
        End With
        'add image to the menu items
        If ImageList Is Nothing Then
            mMenu.ShowImageMargin = False
        Else
            mMenu.ShowImageMargin = True
            mMenu.ImageList = ImageList
            For Each x As ToolStripItem In mMenu.Items
                If x.Text <> "" Then x.ImageKey = x.Text
            Next
        End If
        'pass menu to control
        mCtrl = Control
        Control.ContextMenuStrip = mMenu
        'add event handler
        AddHandler mMenu.ItemClicked, AddressOf ContextMenu_ItemClicked
    End Sub

    Public Sub Add(ByVal Item As ToolStripItem)
        mMenu.Items.Add(Item)
    End Sub

    Public Sub Add(ByVal Text As String, ByVal Image As Image)
        mMenu.Items.Add(Text, Image)
    End Sub

    Public Sub Insert(ByVal Index As Integer, ByVal Item As ToolStripItem)
        mMenu.Items.Insert(Index, Item)
    End Sub

    Public Sub Remove(ByVal MenuText As String)
        For Each x As ToolStripItem In mMenu.Items
            If x.Text = MenuText Then
                mMenu.Items.Remove(x)
                Return
            End If
        Next
    End Sub

    Private Sub ContextMenu_ItemClicked(ByVal sender As System.Object, _
                                        ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)
        Select Case True
            Case TypeOf (mCtrl) Is ListBox
                ProcessListBox(CType(mCtrl, ListBox), e.ClickedItem.Text)

            Case TypeOf (mCtrl) Is DataGridView
                ProcessDataGridView(CType(mCtrl, DataGridView), e.ClickedItem.Text)
        End Select
    End Sub

    Private Sub ProcessListBox(ByVal lst As ListBox, ByVal MenuText As String)
        Dim i As Integer
        Dim s As String = ""

        Select Case MenuText
            Case "Clear", "Clear All"
                lst.Items.Clear()

            Case "Delete"
                For i = lst.SelectedIndices.Count - 1 To 0 Step -1
                    lst.Items.RemoveAt(lst.SelectedIndices(i))
                Next

            Case "Copy"
                For Each x As Object In lst.SelectedItems
                    s = s & ControlChars.CrLf & x.ToString
                Next
                If s <> "" Then Clipboard.SetText(s)

            Case "Select All"
                For i = 0 To lst.Items.Count - 1
                    lst.SelectedIndex = i
                Next i

            Case "Select None"
                lst.SelectedIndex = -1
        End Select
    End Sub

    Private Sub ProcessDataGridView(ByVal dgv As DataGridView, ByVal MenuText As String)
        Dim i As Integer

        Select Case MenuText
            Case "Clear", "Clear All"

            Case "Delete"

            Case "Copy"
                dgv.Focus()
                SendKeys.Send("^C")

            Case "Select All"
                dgv.SelectAll()

            Case "Select None"
                For i = 0 To dgv.RowCount - 1
                    dgv.Rows(i).Selected = False
                Next i
        End Select
    End Sub

End Class

Public Class w2TxtBuffer
    Private Const MyFile As String = "isave.wlx"
    Private mKey As String = ""
    Private mCmdIndex As Integer
    Private mCmdBuffer As New List(Of String)
    Private mUpperCase As Boolean = False
    Private mClearLast As Boolean = False

    Public Sub New(ByVal TextBox As TextBox)
        AddHandler TextBox.KeyDown, AddressOf ctrl_KeyDown
        AddHandler TextBox.KeyPress, AddressOf ctrl_KeyPress
        mKey = TextBox.Name
        If mKey <> "" Then ReadHistry()
    End Sub

    Public Sub New(ByVal TextBox As TextBox, ByVal ConvertCharacter2Uppercase As Boolean)
        Me.New(TextBox)
        mUpperCase = ConvertCharacter2Uppercase
    End Sub

    Public Sub New(ByVal ToolStripTextBox As ToolStripTextBox)
        Me.New(ToolStripTextBox.TextBox)
        mKey = ToolStripTextBox.Name
        If mKey <> "" Then ReadHistry()
    End Sub

    Public Sub New(ByVal ToolStripTextBox As ToolStripTextBox, ByVal ConvertCharacter2Uppercase As Boolean)
        Me.New(ToolStripTextBox)
        mUpperCase = ConvertCharacter2Uppercase
    End Sub

    Public Property Uppercase() As Boolean
        Get
            Return mUpperCase
        End Get
        Set(ByVal value As Boolean)
            mUpperCase = value
        End Set
    End Property

    Public Property ClearLastCommand() As Boolean
        Get
            Return mClearLast
        End Get
        Set(ByVal value As Boolean)
            mClearLast = value
        End Set
    End Property

    Public Sub ReadHistry()
        Dim s As String = Me.IniFile.ReadParameter(Me.ToString, mKey, "")
        If s = "" Then Return
        mCmdBuffer.Clear()
        mCmdBuffer.AddRange(s.Split("|"c))
        mCmdIndex = mCmdBuffer.Count
    End Sub

    Public Sub SaveHistory()
        If mKey = "" Then Return
        If mCmdBuffer.Count = 0 Then Return

        Dim s As String = ""
        Dim k As Integer = 0
        If mCmdBuffer.Count > 100 Then k = mCmdBuffer.Count - 100
        For i As Integer = k To mCmdBuffer.Count - 1
            s += ("|" + mCmdBuffer(i))
        Next
        s = s.Substring(1)

        Me.IniFile.WriteParemeter(Me.ToString, mKey, s)
    End Sub

    Private ReadOnly Property IniFile() As w2IniFile
        Get
            Dim sFile As String = IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory(), MyFile)
            Return (New w2IniFile(sFile))
        End Get
    End Property

    Private Sub ctrl_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'convert sender
        Dim mTextBox As TextBox
        Select Case True
            Case TypeOf (sender) Is TextBox
                mTextBox = CType(sender, TextBox)
            Case TypeOf (sender) Is ToolStripTextBox
                mTextBox = CType(sender, ToolStripTextBox).TextBox
            Case Else
                Return
        End Select
        'process event
        Dim ShowText As Boolean = False
        Dim AddText As Boolean = False
        Dim s As String

        Select Case e.KeyCode
            Case Keys.Up
                mCmdIndex = mCmdIndex - 1
                If mCmdIndex < 0 Then mCmdIndex = 0
                ShowText = True

            Case Keys.Down
                mCmdIndex = mCmdIndex + 1
                If mCmdIndex >= mCmdBuffer.Count Then mCmdIndex = mCmdBuffer.Count - 1
                ShowText = True

            Case Keys.Return
                s = mTextBox.Text
                If s = "" Then Return

                If mCmdBuffer.Count = 0 Then
                    AddText = True
                ElseIf s <> mCmdBuffer(mCmdBuffer.Count - 1) Then
                    AddText = True
                End If

                If AddText Then
                    'add to buffer
                    mCmdBuffer.Add(s)
                    'move index to the last one
                    If mClearLast Then
                        mCmdIndex = mCmdBuffer.Count
                    Else
                        mCmdIndex = mCmdBuffer.Count - 1
                    End If
                End If
        End Select

        If ShowText Then
            If mCmdBuffer.Count > 0 Then
                s = mCmdBuffer(mCmdIndex)
                mTextBox.Text = s
                mTextBox.SelectionStart = s.Length
                'mTextBox.SelectAll()
                e.SuppressKeyPress = True
            End If
        End If
    End Sub

    Private Sub ctrl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not mUpperCase Then Return
        Dim KeyAscii As Integer = Asc(e.KeyChar)
        If KeyAscii >= 97 And KeyAscii <= 122 Then
            KeyAscii = KeyAscii - 32    'a and A are offset by 32
            e.KeyChar = Chr(KeyAscii)
        End If
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        Me.SaveHistory()
    End Sub
End Class
