Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.Design
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner

Namespace RepWizardCustomQuery
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim designForm As New XRDesignFormEx()

			designForm.DesignPanel.AddCommandHandler(New WizardCommandHandler(designForm.DesignPanel))
			AddHandler designForm.Load, AddressOf designForm_Load
			designForm.DesignPanel.ExecCommand(ReportCommand.NewReport)

			designForm.ShowDialog()
		End Sub

		Private Sub designForm_Load(ByVal sender As Object, ByVal e As EventArgs)
			' Create a new report and run the Report Wizard every time a form is loaded.
			CType(sender, XRDesignFormEx).DesignPanel.ExecCommand(ReportCommand.NewReportWizard)
		End Sub
	End Class

	Public Class WizardCommandHandler
        Implements ICommandHandler
		Private panel As XRDesignPanel

		Public Sub New(ByVal panel As XRDesignPanel)
			Me.panel = panel
		End Sub

        Public Overridable Function CanHandleCommand(ByVal command As ReportCommand) As Boolean Implements ICommandHandler.CanHandleCommand
            Return command = ReportCommand.NewReportWizard OrElse command = ReportCommand.AddNewDataSource OrElse command = ReportCommand.VerbReportWizard
        End Function

        Public Overridable Sub HandleCommand(ByVal command As ReportCommand, ByVal args() As Object, ByRef handled As Boolean) Implements ICommandHandler.HandleCommand

            If (Not CanHandleCommand(command)) Then
                Return

            End If

            Dim wizard As New CustomWizard(panel.Report)

            wizard.Run()
            handled = True
        End Sub
	End Class

	Public Class CustomWizard
		Inherits XRWizardRunnerBase
		Public Sub New(ByVal report As XtraReport)
			MyBase.New(report)
			Me.Wizard = New NewStandardReportWizard(report)
		End Sub

		Public Function Run() As DialogResult

			If Me.Report Is Nothing Then
				Return DialogResult.Cancel
			End If

			Dim form As New XtraReportWizardForm(Wizard.DesignerHost)

			form.Controls.AddRange(New Control() { New WizPageWelcome(Me), New WizPageDataset(Me), New WizPageConnectionCustom(Me), New WizPageDataOption(Me), New WizPageTablesCustom(Me), New WizPageQuery(Me), New WizPageChooseFieldsCustom(Me), New WizPageGrouping(Me), New WizPageSummary(Me), New WizPageGroupedLayout(Me), New WizPageUngroupedLayout(Me), New WizPageStyle(Me), New WizPageReportTitle(Me), New WizPageLabelType(Me), New WizPageLabelOptions(Me) })

			Dim result As DialogResult = form.ShowDialog()

			If result = DialogResult.OK Then
				Wizard.BuildReport()
			End If

			Return result
		End Function
	End Class

	Public Class WizPageTablesCustom
		Inherits WizPageTables
		Private standardWizard As XtraReportWizardBase

		Public Sub New(ByVal runner As XRWizardRunnerBase)
			MyBase.New(runner)
			standardWizard = CType(runner.Wizard, NewStandardReportWizard)
		End Sub

		Protected Overrides Function OnSetActive() As Boolean
			WizardHelper.LastDataSourceWizardType = "WizPageTables"

			Return MyBase.OnSetActive()
		End Function

		Protected Overrides Function OnWizardNext() As String
			MyBase.OnWizardNext()

			Return "WizPageChooseFields"
		End Function
	End Class

	Public Class WizPageChooseFieldsCustom
		Inherits WizPageChooseFields
		Public Sub New(ByVal runner As XRWizardRunnerBase)
			MyBase.New(runner)

		End Sub

		Protected Overrides Function OnWizardBack() As String
			MyBase.OnWizardBack()

			Return WizardHelper.LastDataSourceWizardType
		End Function

	End Class

	Public Class WizardHelper
		Private Shared _lastDataSourceWizardType As String

		Public Shared Property LastDataSourceWizardType() As String
			Get
				Return WizardHelper._lastDataSourceWizardType
			End Get
			Set(ByVal value As String)
				WizardHelper._lastDataSourceWizardType = value
			End Set
		End Property
	End Class

End Namespace

