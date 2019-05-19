#pragma checksum "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54cb162e1051aad35a2d327d9de902cb2096a3e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patients_Details), @"mvc.1.0.view", @"/Views/Patients/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patients/Details.cshtml", typeof(AspNetCore.Views_Patients_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Programming\Capstone\HCS-Project\Project\Views\_ViewImports.cshtml"
using Project;

#line default
#line hidden
#line 2 "D:\Programming\Capstone\HCS-Project\Project\Views\_ViewImports.cshtml"
using Project.Data;

#line default
#line hidden
#line 3 "D:\Programming\Capstone\HCS-Project\Project\Views\_ViewImports.cshtml"
using Project.Models;

#line default
#line hidden
#line 4 "D:\Programming\Capstone\HCS-Project\Project\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54cb162e1051aad35a2d327d9de902cb2096a3e8", @"/Views/Patients/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df5661587fee894f038b02eb626dd99e5d2e2ecc", @"/Views/_ViewImports.cshtml")]
    public class Views_Patients_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project.Data.Patient>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(74, 557, true);
            WriteLiteral(@"
<style>
    .table thead > tr > th,
    .table tbody > tr > th,
    .table tfoot > tr > th,
    .table thead > tr > td,
    .table tbody > tr > td,
    .table tfoot > tr > td {
        padding: 8px;
        line-height: 1.428571429;
        vertical-align: top;
        border: 0px solid #dddddd;
    }

    .table tbody tr:nth-child(4n+1), .table tbody tr:nth-child(4n+2) {
        background-color: ghostwhite;
    }
</style>

<div class=""panel"">
    <div class=""panel-body"">
        <div class=""underline-Heading"">
            <h2>");
            EndContext();
            BeginContext(632, 48, false);
#line 28 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
           Write(Html.DisplayFor(model => model.Person.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(680, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(682, 47, false);
#line 28 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
                                                             Write(Html.DisplayFor(model => model.Person.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(729, 216, true);
            WriteLiteral(" Details</h2>\r\n        </div>\r\n        <br />\r\n        <div>\r\n            <dl class=\"dl-horizontal\">\r\n                <dt>\r\n                    MRN\r\n                </dt>\r\n\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(946, 51, false);
#line 38 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
               Write(Html.DisplayFor(model => model.MedicalRecordNumber));

#line default
#line hidden
            EndContext();
            BeginContext(997, 142, true);
            WriteLiteral("\r\n                </dd>\r\n\r\n                <dt>\r\n                    Name\r\n                </dt>\r\n\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1140, 48, false);
#line 46 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
               Write(Html.DisplayFor(model => model.Person.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1188, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1211, 49, false);
#line 47 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
               Write(Html.DisplayFor(model => model.Person.MiddleName));

#line default
#line hidden
            EndContext();
            BeginContext(1260, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1283, 47, false);
#line 48 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
               Write(Html.DisplayFor(model => model.Person.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1330, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1353, 45, false);
#line 49 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
               Write(Html.DisplayFor(model => model.Person.Suffix));

#line default
#line hidden
            EndContext();
            BeginContext(1398, 144, true);
            WriteLiteral("\r\n                </dd>\r\n\r\n                <dt>\r\n                    Gender\r\n                </dt>\r\n\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1543, 45, false);
#line 57 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
               Write(Html.DisplayFor(model => model.Person.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1588, 136, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(1724, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54cb162e1051aad35a2d327d9de902cb2096a3e88652", async() => {
                BeginContext(1767, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1783, 86, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-2\">\r\n                    ");
            EndContext();
            BeginContext(1870, 97, false);
#line 65 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = Model.PatientId }, new { @class = "btn btn-warning" }));

#line default
#line hidden
            EndContext();
            BeginContext(1967, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 66 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
                     if (User.IsInRole("Administrator") || User.IsInRole("Instructor"))
                    {
                        

#line default
#line hidden
            BeginContext(2106, 100, false);
#line 68 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id = Model.PatientId }, new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
#line 68 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
                                                                                                                             
                    }

#line default
#line hidden
            BeginContext(2231, 46, true);
            WriteLiteral("                </div>\r\n            </div>\r\n\r\n");
            EndContext();
#line 73 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
             if (ViewBag.records == null)
            {

#line default
#line hidden
            BeginContext(2335, 88, true);
            WriteLiteral("                <br />\r\n                <div class=\"col-md-2\">\r\n                </div>\r\n");
            EndContext();
#line 78 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
                 if (Model.Person.Gender == "Female")
                {
                    if (ViewBag.isDisabled != true)
                    {
                        

#line default
#line hidden
            BeginContext(2598, 140, false);
#line 82 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
                   Write(Html.ActionLink("Add New Birth Record", "create", "birthRecords", new { id = Model.PatientId }, new { @class = "btn btn-success col-md-8" }));

#line default
#line hidden
            EndContext();
#line 82 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
                                                                                                                                                                     
                    }
                }

#line default
#line hidden
#line 84 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(2797, 38, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
#line 90 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
 if (ViewBag.records != null)
{

#line default
#line hidden
            BeginContext(2869, 124, true);
            WriteLiteral("    <div class=\"panel\">\r\n        <div class=\"panel-body\">\r\n            <div class=\"underline-Heading\">\r\n                <h2>");
            EndContext();
            BeginContext(2994, 48, false);
#line 95 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
               Write(Html.DisplayFor(model => model.Person.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(3042, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3044, 47, false);
#line 95 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
                                                                 Write(Html.DisplayFor(model => model.Person.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(3091, 412, true);
            WriteLiteral(@" Records</h2>
            </div>
            <br />
            <p>*Click on a Record to View the Printing Option(s)</p>
            <table class=""table"">
                <thead>
                    <tr>
                        <th class=""col-md-8"">Record ID</th>
                        <th class=""text-center"">Actions</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 107 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
                     foreach (var item in ViewBag.records)
                    {

#line default
#line hidden
            BeginContext(3586, 145, true);
            WriteLiteral("                        <tr>\r\n                            <td style=\"vertical-align:middle; cursor:pointer\" data-toggle=\"collapse\" data-target=\"#");
            EndContext();
            BeginContext(3732, 18, false);
#line 110 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
                                                                                                              Write(item.BirthRecordId);

#line default
#line hidden
            EndContext();
            BeginContext(3750, 36, true);
            WriteLiteral("\">\r\n                                ");
            EndContext();
            BeginContext(3787, 18, false);
#line 111 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
                           Write(item.BirthRecordId);

#line default
#line hidden
            EndContext();
            BeginContext(3805, 123, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-center\">\r\n                                ");
            EndContext();
            BeginContext(3929, 138, false);
#line 114 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
                           Write(Html.ActionLink("Details", "Details", "birthRecords", new { id = item.BirthRecordId }, htmlAttributes: new { @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(4067, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(4102, 132, false);
#line 115 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
                           Write(Html.ActionLink("Edit", "Edit", "birthRecords", new { id = item.BirthRecordId }, htmlAttributes: new { @class = "btn btn-warning" }));

#line default
#line hidden
            EndContext();
            BeginContext(4234, 233, true);
            WriteLiteral("\r\n                            </td>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <td colspan=\"2\" style=\"padding:0;\">\r\n                                <div class=\"accordian-body collapse\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4467, "\"", 4491, 1);
#line 121 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
WriteAttributeValue("", 4472, item.BirthRecordId, 4472, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4492, 39, true);
            WriteLiteral(">\r\n                                    ");
            EndContext();
            BeginContext(4532, 134, false);
#line 122 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
                               Write(Html.ActionLink("Print Souvenir Certificate", "SouvenirForm", new { id = Model.PatientId }, htmlAttributes: new { target = "_blank" }));

#line default
#line hidden
            EndContext();
            BeginContext(4666, 108, true);
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 126 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(4797, 104, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n            <div class=\"col-md-2\">\r\n            </div>\r\n");
            EndContext();
#line 131 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
             if (Model.Person.Gender == "Female")
            {
                if (ViewBag.isDisabled != true)
                {
                    

#line default
#line hidden
            BeginContext(5056, 140, false);
#line 135 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
               Write(Html.ActionLink("Add New Birth Record", "create", "birthRecords", new { id = Model.PatientId }, new { @class = "btn btn-success col-md-8" }));

#line default
#line hidden
            EndContext();
#line 135 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
                                                                                                                                                                 
                }
            }

#line default
#line hidden
            BeginContext(5232, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 141 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\Details.cshtml"
}

#line default
#line hidden
            BeginContext(5265, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project.Data.Patient> Html { get; private set; }
    }
}
#pragma warning restore 1591