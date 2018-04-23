using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.Native;

namespace RepWizardCustomQuery
{
    public partial class WizPageQuery : DevExpress.Utils.InteriorWizardPage
    {
        private XtraReportWizardBase standardWizard;
        private IDbDataAdapter da;
        private DataSet ds;

        static IDbDataAdapter CreateDataAdapter(string connectionString, string selectQuery)
        {
            IDbDataAdapter result;

            if (ConnectionStringHelper.GetConnectionType(connectionString) == ConnectionType.Sql)
            {
                connectionString = ConnectionStringHelper.RemoveProviderFromConnectionString(connectionString);
                SqlCommand sqlSelectCommand = new SqlCommand(selectQuery, new SqlConnection(connectionString));
                result = new SqlDataAdapter(sqlSelectCommand);
            }
            else
            {
                OleDbCommand selectCommand = new OleDbCommand(selectQuery, new OleDbConnection(connectionString));
                result = new OleDbDataAdapter(selectCommand);
            }

            result.TableMappings.Add("Table", "Table");

            return result;
        }

        public WizPageQuery(XRWizardRunnerBase runner)
        {
            standardWizard = (NewStandardReportWizard)runner.Wizard;

            ds = new DataSet();

            InitializeComponent();
        }

        private void Test_simpleButton_Click(object sender, EventArgs e)
        {
            da = CreateDataAdapter(((NewStandardReportWizard)this.standardWizard).ConnectionString, this.Query_memoEdit.Text);

            ds.Reset();

            try
            {
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            this.dataGridView1.Columns.Clear();
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        protected override bool OnSetActive()
        {
            WizardHelper.LastDataSourceWizardType = "WizPageQuery";

            Wizard.WizardButtons = WizardButton.Back | WizardButton.Next | WizardButton.DisabledFinish;

            return true;
        }

        protected override string OnWizardBack()
        {
            return "WizPageDataOption";
        }

        protected override string OnWizardNext()
        {
            NewStandardReportWizard reportWizard = (NewStandardReportWizard)this.standardWizard;

            ds.DataSetName = reportWizard.DatasetName;
            reportWizard.Dataset = ds;
            reportWizard.DataAdapters.Clear();
            reportWizard.DataAdapters.Add(da);

            return "WizPageChooseFields";
        }
    }
}