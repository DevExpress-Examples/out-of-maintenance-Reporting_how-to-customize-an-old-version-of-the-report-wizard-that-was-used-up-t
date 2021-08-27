<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128600046/12.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1538)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))**
* [WizPageConnectionCustom.cs](./CS/WizPageConnectionCustom.cs) (VB: [WizPageConnectionCustom.vb](./VB/WizPageConnectionCustom.vb))
* [WizPageDataOption.cs](./CS/WizPageDataOption.cs) (VB: [WizPageDataOption.vb](./VB/WizPageDataOption.vb))
* [WizPageQuery.cs](./CS/WizPageQuery.cs) (VB: [WizPageQuery.vb](./VB/WizPageQuery.vb))
<!-- default file list end -->
# How to customize an old version of the Report Wizard (that was used up to version 13.2)


<p><strong>Important Note</strong>: The approach demonstrated in this code example is related to an <strong>old</strong> version of the Report Wizard that was used up to version 13.2. Starting with version 14.1, a new version of the Report Wizard was introduced, so please refer to the <a href="https://www.devexpress.com/Support/Center/p/T140683">How to customize the New Report Wizard (introduced in the 2014 vol.1 release) in the End-User Designer</a> code example to learn how to customize the new version of the Report Wizard.</p>
<p><br>This example demonstrates how to create a Custom Report Wizard with the capability to define the SQL query, based on which the resulting report's data source will be generated (see the corresponding suggestion: <a href="https://www.devexpress.com/Support/Center/p/AS4685">AS4685</a>).</p>
<p>In order to run you custom wizard in the corresponding handler, override the <strong>ReportCommand.NewReportWizard, ReportCommand.AddNewDataSource</strong>, and <strong>ReportCommand.VerbReportWizard </strong>commands (as described in this documentation article: <a href="http://help.devexpress.com/#XtraReports/CustomDocument2211"><u>How to: Override Commands in the End-User Designer (Custom Saving)</u></a>. A Custom Report Wizard inherits from the <strong>XRWizardRunnerBase </strong>class, custom wizard pages are inherited from the <strong>InteriorWizardPage </strong>class.</p>
<p>Note that for most custom wizard pages, you should override the <strong>InteriorWizardPage.OnWizardBack</strong>() and <strong>InteriorWizardPage.OnWizardNext</strong>() virtual methods, to provide proper wizard navigation logic.</p>

<br/>


