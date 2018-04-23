using System;
using System.Windows.Forms;
using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;

namespace RepWizardCustomQuery {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            XRDesignFormEx designForm = new XRDesignFormEx();

            designForm.DesignPanel.AddCommandHandler(new WizardCommandHandler(designForm.DesignPanel));
            designForm.Load += new EventHandler(designForm_Load);
            designForm.DesignPanel.ExecCommand(ReportCommand.NewReport);

            designForm.ShowDialog();
        }

        void designForm_Load(object sender, EventArgs e) {
            // Create a new report and run the Report Wizard every time a form is loaded.
            ((XRDesignFormEx)sender).DesignPanel.ExecCommand(ReportCommand.NewReportWizard);
        }
    }
    public class WizardCommandHandler : ICommandHandler {
        #region ICommandHandler Members
        XRDesignPanel panel;
        public WizardCommandHandler(XRDesignPanel panel) {
            this.panel = panel;
        }

        public void HandleCommand(DevExpress.XtraReports.UserDesigner.ReportCommand command,
        object[] args) {
            CustomWizard wizard = new CustomWizard(panel.Report);
            wizard.Run();
        }

        public bool CanHandleCommand(DevExpress.XtraReports.UserDesigner.ReportCommand command,
        ref bool useNextHandler) {
            useNextHandler = !(command == ReportCommand.NewReportWizard ||
                command == ReportCommand.AddNewDataSource ||
                command == ReportCommand.VerbReportWizard);
            return !useNextHandler;
        }


        #endregion
    }


    public class CustomWizard : XRWizardRunnerBase {
        public CustomWizard(XtraReport report)
            : base(report) {
            this.Wizard = new NewStandardReportWizard(report);
        }

        public DialogResult Run() {

            if(this.Report == null)
                return DialogResult.Cancel;

            XtraReportWizardForm form = new XtraReportWizardForm(Wizard.DesignerHost);

            form.Controls.AddRange(new Control[] {
                new WizPageWelcome(this), 
                new WizPageDataset(this), 
                new WizPageConnectionCustom(this),          // Custom
                new WizPageDataOption(this),                // New
                new WizPageTablesCustom(this),              // Custom
                new WizPageQuery(this),                     // New
                new WizPageChooseFieldsCustom(this),        // Custom
                new WizPageGrouping(this), 
                new WizPageSummary(this), 
                new WizPageGroupedLayout(this), 
                new WizPageUngroupedLayout(this), 
                new WizPageStyle(this), 
                new WizPageReportTitle(this), 
                new WizPageLabelType(this), 
                new WizPageLabelOptions(this)               //, and so on...
                });

            DialogResult result = form.ShowDialog();

            if(result == DialogResult.OK)
                Wizard.BuildReport();

            return result;
        }
    }

    public class WizPageTablesCustom : WizPageTables {
        private XtraReportWizardBase standardWizard;

        public WizPageTablesCustom(XRWizardRunnerBase runner)
            : base(runner) {
            standardWizard = (NewStandardReportWizard)runner.Wizard;
        }

        protected override bool OnSetActive() {
            WizardHelper.LastDataSourceWizardType = "WizPageTables";

            return base.OnSetActive();
        }

        protected override string OnWizardNext() {
            base.OnWizardNext();

            return "WizPageChooseFields";
        }
    }

    public class WizPageChooseFieldsCustom : WizPageChooseFields {
        public WizPageChooseFieldsCustom(XRWizardRunnerBase runner)
            : base(runner) {

        }

        protected override string OnWizardBack() {
            base.OnWizardBack();

            return WizardHelper.LastDataSourceWizardType;
        }

    }

    public class WizardHelper {
        private static string _lastDataSourceWizardType;

        public static string LastDataSourceWizardType {
            get { return WizardHelper._lastDataSourceWizardType; }
            set { WizardHelper._lastDataSourceWizardType = value; }
        }
    }

}

