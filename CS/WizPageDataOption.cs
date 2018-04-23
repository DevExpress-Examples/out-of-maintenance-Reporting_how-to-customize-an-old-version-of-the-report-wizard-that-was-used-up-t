using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.Native;
using DevExpress.XtraReports.Design;
using DevExpress.Utils;

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