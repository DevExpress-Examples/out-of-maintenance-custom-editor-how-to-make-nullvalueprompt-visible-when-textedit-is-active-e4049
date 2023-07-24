Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports System
Imports System.Runtime.InteropServices

Namespace CustomTextEdit

    <UserRepositoryItem("Register")>
    Public Class RepositoryItemCustomTextEdit
        Inherits RepositoryItemTextEdit

        Private _nullValuePromptAlwaysVisible As Boolean

        Public Property NullValuePromptAlwaysVisible As Boolean
            Get
                Return _nullValuePromptAlwaysVisible
            End Get

            Set(ByVal value As Boolean)
                _nullValuePromptAlwaysVisible = value
                ShowNullPrompt()
            End Set
        End Property

        Public Overrides Property NullValuePrompt As String
            Get
                Return MyBase.NullValuePrompt
            End Get

            Set(ByVal value As String)
                MyBase.NullValuePrompt = value
                ShowNullPrompt()
            End Set
        End Property

        Public Const CustomTextEditName As String = "CustomTextEdit"

        Shared Sub New()
            Call Register()
        End Sub

        Public Sub New()
        End Sub

        Public Overrides ReadOnly Property EditorTypeName As String
            Get
                Return CustomTextEditName
            End Get
        End Property

        Public Overrides Sub Assign(ByVal item As RepositoryItem)
            BeginUpdate()
            Try
                MyBase.Assign(item)
                Dim source As RepositoryItemCustomTextEdit = TryCast(item, RepositoryItemCustomTextEdit)
                If source Is Nothing Then Return
                NullValuePromptAlwaysVisible = source.NullValuePromptAlwaysVisible
            Finally
                EndUpdate()
            End Try
        End Sub

        Public Shared Sub Register()
            Call EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomTextEditName, GetType(MyCustomTextEdit), GetType(RepositoryItemCustomTextEdit), GetType(TextEditViewInfo), New TextEditPainter(), True))
        End Sub

        Private Sub ShowNullPrompt()
            Dim behaviour As Integer = Convert.ToInt32(NullValuePromptAlwaysVisible)
            If OwnerEdit IsNot Nothing AndAlso OwnerEdit.IsHandleCreated AndAlso Not String.IsNullOrEmpty(NullValuePrompt) Then
                Call SendMessage(OwnerEdit.MaskBox.Handle, &H1501, CType(behaviour, IntPtr), NullValuePrompt)
            End If
        End Sub

        <DllImport("user32.dll", CharSet:=CharSet.Unicode)>
        Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wp As IntPtr, ByVal lp As String) As IntPtr
        End Function
    End Class
End Namespace
