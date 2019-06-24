<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/Inline_Unobtrusive/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/Inline_Unobtrusive/Controllers/HomeController.vb))
* [Global.asax.cs](./CS/Inline_Unobtrusive/Global.asax.cs) (VB: [Global.asax.vb](./VB/Inline_Unobtrusive/Global.asax.vb))
* [Customer.cs](./CS/Inline_Unobtrusive/Models/Customer.cs) (VB: [Customer.vb](./VB/Inline_Unobtrusive/Models/Customer.vb))
* [GridViewPartial.cshtml](./CS/Inline_Unobtrusive/Views/Home/GridViewPartial.cshtml)
* [Index.cshtml](./CS/Inline_Unobtrusive/Views/Home/Index.cshtml)
* [Editor.cshtml](./CS/Inline_Unobtrusive/Views/Shared/Editor.cshtml)
<!-- default file list end -->
# OBSOLETE - GridView - How to enable unobtrusive validation for inline edit form
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4741)**
<!-- run online end -->


<p>Starting with DevExpress 14.1, the ASP.NET MVC GridView extension fully supports the unobtrusive client validation for built-in edit forms. Refer to the <a href="https://www.devexpress.com/Support/Center/p/S173266">Support unobtrusive validation for the GridView's built-in edit form</a> thread to learn more.<br /><br />If you have version v14.1+ available, consider using the built-in functionality instead of the approach detailed below.<br />If you need further clarification, create a new ticket in our Support Center.<br /><br />This example demonstrates how to implement unobtrusive validation for the editors inside the grid's inline edit form.</p>
<br />
<p>jQuery parsing is only done after the initial page load, so the forms that were loaded via callbacks after the page load are not parsed. To resolve this, use the approach from the <a href="https://www.devexpress.com/Support/Center/p/KA20014">How to correctly enable Model, Unobtrusive or jQuery Client validation</a> article.</p>
<p>Since the client click should be handled to validate editors on the client, use the unbound column that will serve as a command column during editing.</p>
<br />
<p>Note that the actual data source update isn't implemented in this example.</p>
<p><strong>See </strong><strong>Also:<br /> </strong><a href="https://www.devexpress.com/Support/Center/p/E3744">How to enable unobtrusive validation for GridView using the EditForm template</a></p>

<br/>


