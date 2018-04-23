Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraReports.Design
Imports DevExpress.XtraReports.Native

Namespace RepWizardCustomQuery
	Partial Public Class WizPageQuery
		Inherits DevExpress.Utils.InteriorWizardPage
		Private standardWizard As XtraReportWizardBase
		Private da As IDbDataAdapter
		Private ds As DataSet

		Private Shared Function CreateDataAdapter(ByVal connectionString As String, ByVal selectQuery As String) As IDbDataAdapter
			Dim result As IDbDataAdapter

			If ConnectionStringHelper.GetConnectionType(connectionString) = ConnectionType.Sql Then
				connectionString = ConnectionStringHelper.RemoveProviderFromConnectionString(connectionString)
				Dim sqlSelectCommand As New SqlCommand(selectQuery, New SqlConnection(connectionString))
				result = New SqlDataAdapter(sqlSelectCommand)
			Else
				Dim selectCommand As New OleDbCommand(selectQuery, New OleDbConnection(connectionString))
				result = New OleDbDataAdapter(selectCommand)
			End If

			result.TableMappings.Add("Table", "Table")

			Return result
		End Function

		Public Sub New(ByVal runner As XRWizardRunnerBase)
			standardWizard = CType(runner.Wizard, NewStandardReportWizard)

			ds = New DataSet()

			InitializeComponent()
		End Sub

		Private Sub Test_simpleButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Test_simpleButton.Click
			da = CreateDataAdapter((CType(Me.standardWizard, NewStandardReportWizard)).ConnectionString, Me.Query_memoEdit.Text)

			ds.Reset()

			Try
				da.Fill(ds)
			Catch ex As Exception
				MessageBox.Show(ex.Message)
				Return
			End Try

			Me.dataGridView1.Columns.Clear()
			Me.dataGridView1.DataSource = ds.Tables(0)
		End Sub

		Protected Overrides Function OnSetActive() As Boolean
			WizardHelper.LastDataSourceWizardType = "WizPageQuery"

			Wizard.WizardButtons = WizardButton.Back Or WizardButton.Next Or WizardButton.DisabledFinish

			Return True
		End Function

		Protected Overrides Function OnWizardBack() As String
			Return "WizPageDataOption"
		End Function

		Protected Overrides Function OnWizardNext() As String
			Dim reportWizard As NewStandardReportWizard = CType(Me.standardWizard, NewStandardReportWizard)

			ds.DataSetName = reportWizard.DatasetName
			reportWizard.Dataset = ds
			reportWizard.DataAdapters.Clear()
			reportWizard.DataAdapters.Add(da)

			Return "WizPageChooseFields"
		End Function
	End Class
End Namespace