using DevExpress.Utils;
using DevExpress.XtraReports.Design;

namespace RepWizardCustomQuery
{
    public partial class WizPageConnectionCustom : DevExpress.Utils.InteriorWizardPage
    {

        XtraReportWizardBase standardWizard;

        public WizPageConnectionCustom(XRWizardRunnerBase runner)
        {
            this.standardWizard = runner.Wizard;

            InitializeComponent();

            textEdit1.Text = @"Provider=SQLOLEDB;Data Source=.\SQLExpress;Initial Catalog=Northwind;Integrated Security=SSPI";
        }

        protected override bool OnSetActive()
        {
            Wizard.WizardButtons = WizardButton.Back | WizardButton.Next | WizardButton.DisabledFinish;
            return true;
        }

        protected override string OnWizardNext()
        {
            ((NewStandardReportWizard)this.standardWizard).ConnectionString = textEdit1.Text;

            return "WizPageDataOption";
        }

    }
}
