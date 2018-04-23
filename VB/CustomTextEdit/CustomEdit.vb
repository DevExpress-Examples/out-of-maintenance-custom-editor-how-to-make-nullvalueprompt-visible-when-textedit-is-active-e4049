Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace CustomTextEdit
	Public Class MyCustomTextEdit
		Inherits TextEdit
		Shared Sub New()
			RepositoryItemCustomTextEdit.Register()
		End Sub

		Public Sub New()
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemCustomTextEdit.CustomTextEditName
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemCustomTextEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemCustomTextEdit)
			End Get
		End Property
	End Class
End Namespace
