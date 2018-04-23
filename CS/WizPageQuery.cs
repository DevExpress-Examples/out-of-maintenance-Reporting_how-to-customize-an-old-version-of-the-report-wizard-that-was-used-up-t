using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.Native;
using DevExpress.XtraReports.Design;
using DevExpress.Utils;

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
            standardWizard = (NewXtraReportStandardBuilderWizard)runner.Wizard;

            ds = new DataSet();

            InitializeComponent();
        }

        private void Test_simpleButton_Click(object sender, EventArgs e)
        {
            da = CreateDataAdapter(((NewXtraReportStandardBuilderWizard)this.standardWizard).ConnectionString, this.Query_memoEdit.Text);

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
            NewXtraReportStandardBuilderWizard reportWizard = (NewXtraReportStandardBuilderWizard)this.standardWizard;

            ds.DataSetName = reportWizard.DatasetName;
            reportWizard.Dataset = ds;
            reportWizard.DataAdapters.Clear();
            reportWizard.DataAdapters.Add(da);

            return "WizPageChooseFields";
        }
    }
}