Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace CustomTextEdit

    Public Partial Class Form1
        Inherits Form

        Private myCustomTextEdit1 As MyCustomTextEdit

        Public Sub New()
            InitializeComponent()
            'myCustomTextEdit1
            myCustomTextEdit1 = New MyCustomTextEdit()
            Controls.Add(myCustomTextEdit1)
            'checkEdit1
            AddHandler checkEdit1.CheckStateChanged, AddressOf checkEdit1_CheckStateChanged
            'textEdit1
            AddHandler textEdit1.EditValueChanged, AddressOf textEdit1_EditValueChanged
            textEdit1.EditValue = "Enter some value"
        End Sub

        Protected Overrides Sub Finalize()
            RemoveHandler checkEdit1.CheckStateChanged, AddressOf checkEdit1_CheckStateChanged
            RemoveHandler textEdit1.EditValueChanged, AddressOf textEdit1_EditValueChanged
        End Sub

        Private Sub textEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As TextEdit = TryCast(sender, TextEdit)
            myCustomTextEdit1.Properties.NullValuePrompt = edit.EditValue.ToString()
        End Sub

        Private Sub checkEdit1_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As CheckEdit = TryCast(sender, CheckEdit)
            myCustomTextEdit1.Properties.NullValuePromptAlwaysVisible = edit.Checked
        End Sub
    End Class
End Namespace
