Namespace CustomTextEdit

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' checkEdit1
            ' 
            Me.checkEdit1.Location = New System.Drawing.Point(178, 33)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = ""
            Me.checkEdit1.Size = New System.Drawing.Size(19, 19)
            Me.checkEdit1.TabIndex = 0
            ' 
            ' textEdit1
            ' 
            Me.textEdit1.Location = New System.Drawing.Point(97, 58)
            Me.textEdit1.Name = "textEdit1"
            Me.textEdit1.Size = New System.Drawing.Size(100, 20)
            Me.textEdit1.TabIndex = 1
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(14, 61)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(77, 13)
            Me.labelControl1.TabIndex = 2
            Me.labelControl1.Text = "NullValuePrompt"
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Location = New System.Drawing.Point(14, 36)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(140, 13)
            Me.labelControl2.TabIndex = 3
            Me.labelControl2.Text = "NullValuePromptAlwaysVisible"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(317, 106)
            Me.Controls.Add(Me.labelControl2)
            Me.Controls.Add(Me.labelControl1)
            Me.Controls.Add(Me.textEdit1)
            Me.Controls.Add(Me.checkEdit1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

'#End Region
        Private checkEdit1 As DevExpress.XtraEditors.CheckEdit

        Private textEdit1 As DevExpress.XtraEditors.TextEdit

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private labelControl2 As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace
