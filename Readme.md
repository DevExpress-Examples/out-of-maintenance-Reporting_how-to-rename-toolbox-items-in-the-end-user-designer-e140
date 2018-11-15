<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
* [XtraReport1.cs](./CS/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/XtraReport1.vb))
<!-- default file list end -->
# How to rename toolbox items in the End-User Designer


<p>The following example demonstrates how to rename toolbox items in the End-User Designer. To do this, it's necessary to handle the XRDesignPanel.DesignerHostLoaded event, obtain the System.Drawing.Design.IToolboxService object from the report's designer and customize the collection of toolbox items as you need.</p><p><strong>Note</strong>: Since v2008 vol 2, this approach doesn't work, because of the following suggestion implementation: <a href="https://www.devexpress.com/Support/Center/p/AS15661">Localization - Capability to localize toolbox items</a>. Now, toolbox item names are localized along with all other resources of the XtraReports suite. For more information on XtraReports localization, see <a href="https://www.devexpress.com/Support/Center/p/A421">The collection of localized DevExpress assemblies</a>.</p>

<br/>


