Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.Design
Imports DevExpress.Utils

Namespace RepWizardCustomQuery
	Partial Public Class WizPageConnectionCustom
		Inherits DevExpress.Utils.InteriorWizardPage

		Private standardWizard As XtraReportWizardBase

		Public Sub New(ByVal runner As XRWizardRunnerBase)
			Me.standardWizard = runner.Wizard

			InitializeComponent()

			textEdit1.Text = "Provider=SQLOLEDB;Data Source=.\SQLExpress;Initial Catalog=Northwind;Integrated Security=SSPI"
		End Sub

		Protected Overrides Function OnSetActive() As Boolean
			Wizard.WizardButtons = WizardButton.Back Or WizardButton.Next Or WizardButton.DisabledFinish
			Return True
		End Function

		Protected Overrides Function OnWizardNext() As String
			CType(Me.standardWizard, NewXtraReportStandardBuilderWizard).ConnectionString = textEdit1.Text

			Return "WizPageDataOption"
		End Function

	End Class
End Namespace
