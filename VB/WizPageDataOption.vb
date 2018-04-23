Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraReports.Design

Namespace RepWizardCustomQuery
	Partial Public Class WizPageDataOption
		Inherits DevExpress.Utils.InteriorWizardPage
		Private standardWizard As XtraReportWizardBase

		Public Sub New(ByVal runner As XRWizardRunnerBase)
			Me.standardWizard = runner.Wizard

			InitializeComponent()
		End Sub

		Protected Overrides Function OnSetActive() As Boolean
			Wizard.WizardButtons = WizardButton.Back Or WizardButton.Next Or WizardButton.DisabledFinish
			Return True
		End Function

		Protected Overrides Function OnWizardNext() As String
			If radioGroup1.SelectedIndex <> 0 Then
				Return "WizPageTables"
			Else
				Return "WizPageQuery"
			End If
		End Function
	End Class
End Namespace