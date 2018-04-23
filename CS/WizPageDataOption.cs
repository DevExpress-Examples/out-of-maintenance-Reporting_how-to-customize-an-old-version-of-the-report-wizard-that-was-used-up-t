using DevExpress.Utils;
using DevExpress.XtraReports.Design;

namespace RepWizardCustomQuery
{
    public partial class WizPageDataOption : DevExpress.Utils.InteriorWizardPage
    {
        XtraReportWizardBase standardWizard;

        public WizPageDataOption(XRWizardRunnerBase runner)
        {
            this.standardWizard = runner.Wizard;

            InitializeComponent();
        }

        protected override bool OnSetActive()
        {
            Wizard.WizardButtons = WizardButton.Back | WizardButton.Next | WizardButton.DisabledFinish;
            return true;
        }

        protected override string OnWizardNext()
        {
            if (radioGroup1.SelectedIndex != 0)
            {
                return "WizPageTables";
            }
            else
            {
                return "WizPageQuery";
            }
        }
    }
}