Imports Microsoft.VisualBasic
Imports System
Namespace RepWizardCustomQuery
	Partial Public Class WizPageConnectionCustom
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			CType(Me.headerPicture, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' titleLabel
			' 
			Me.titleLabel.Text = "Custom Connection String Setup"
			' 
			' textEdit1
			' 
			Me.textEdit1.Location = New System.Drawing.Point(101, 141)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(294, 20)
			Me.textEdit1.TabIndex = 5
			' 
			' XtraUserControl1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.textEdit1)
			Me.Name = "XtraUserControl1"
			Me.Size = New System.Drawing.Size(497, 303)
			Me.Controls.SetChildIndex(Me.textEdit1, 0)
			Me.Controls.SetChildIndex(Me.headerPanel, 0)
			Me.Controls.SetChildIndex(Me.headerSeparator, 0)
			Me.Controls.SetChildIndex(Me.titleLabel, 0)
			Me.Controls.SetChildIndex(Me.subtitleLabel, 0)
			Me.Controls.SetChildIndex(Me.headerPicture, 0)
			CType(Me.headerPicture, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private textEdit1 As DevExpress.XtraEditors.TextEdit

	End Class
End Namespace
