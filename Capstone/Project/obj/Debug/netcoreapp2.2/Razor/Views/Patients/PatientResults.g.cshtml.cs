#pragma checksum "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68ebc9befd90ab225171b9a8b2519e1eef66fe0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patients_PatientResults), @"mvc.1.0.view", @"/Views/Patients/PatientResults.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patients/PatientResults.cshtml", typeof(AspNetCore.Views_Patients_PatientResults))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68ebc9befd90ab225171b9a8b2519e1eef66fe0d", @"/Views/Patients/PatientResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df5661587fee894f038b02eb626dd99e5d2e2ecc", @"/Views/_ViewImports.cshtml")]
    public class Views_Patients_PatientResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Project.Data.Patient>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PatientLookup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info pull-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
  
    ViewBag.Title = "Patient Results";

#line default
#line hidden
            BeginContext(91, 512, true);
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
        <h2>");
            EndContext();
            BeginContext(604, 19, false);
#line 27 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
       Write(ViewBag.searchQuery);

#line default
#line hidden
            EndContext();
            BeginContext(623, 379, true);
            WriteLiteral(@"</h2>
        <p>*Click on a Patient to View More Information</p>
        <table class=""table"">
            <thead>
                <tr>
                    <th>MRN</th>
                    <th>Name</th>
                    <th>Date Of Birth</th>
                    <th class=""text-center"">Actions</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 39 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1067, 137, true);
            WriteLiteral("                    <tr>\r\n                        <td style=\"vertical-align:middle; cursor:pointer\" data-toggle=\"collapse\" data-target=\"#");
            EndContext();
            BeginContext(1205, 14, false);
#line 42 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
                                                                                                          Write(item.PatientId);

#line default
#line hidden
            EndContext();
            BeginContext(1219, 32, true);
            WriteLiteral("\">\r\n                            ");
            EndContext();
            BeginContext(1252, 54, false);
#line 43 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
                       Write(Html.DisplayFor(modelItem => item.MedicalRecordNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1306, 144, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"vertical-align:middle; cursor:pointer\" data-toggle=\"collapse\" data-target=\"#");
            EndContext();
            BeginContext(1451, 14, false);
#line 45 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
                                                                                                          Write(item.PatientId);

#line default
#line hidden
            EndContext();
            BeginContext(1465, 32, true);
            WriteLiteral("\">\r\n                            ");
            EndContext();
            BeginContext(1498, 51, false);
#line 46 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Person.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1549, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1551, 52, false);
#line 46 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
                                                                            Write(Html.DisplayFor(modelItem => item.Person.MiddleName));

#line default
#line hidden
            EndContext();
            BeginContext(1603, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1605, 50, false);
#line 46 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
                                                                                                                                  Write(Html.DisplayFor(modelItem => item.Person.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1655, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1657, 48, false);
#line 46 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
                                                                                                                                                                                      Write(Html.DisplayFor(modelItem => item.Person.Suffix));

#line default
#line hidden
            EndContext();
            BeginContext(1705, 144, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"vertical-align:middle; cursor:pointer\" data-toggle=\"collapse\" data-target=\"#");
            EndContext();
            BeginContext(1850, 14, false);
#line 48 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
                                                                                                          Write(item.PatientId);

#line default
#line hidden
            EndContext();
            BeginContext(1864, 4, true);
            WriteLiteral("\">\r\n");
            EndContext();
#line 49 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
                             if (item.Person.BirthDate != null)
                            {
                                

#line default
#line hidden
            BeginContext(1997, 51, false);
#line 51 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Person.BirthDate));

#line default
#line hidden
            EndContext();
#line 51 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
                                                                                    
                            }

#line default
#line hidden
            BeginContext(2081, 109, true);
            WriteLiteral("                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
            EndContext();
            BeginContext(2190, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68ebc9befd90ab225171b9a8b2519e1eef66fe0d13645", async() => {
                BeginContext(2269, 11, true);
                WriteLiteral("View Record");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
                                                      WriteLiteral(item.PatientId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2284, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2314, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68ebc9befd90ab225171b9a8b2519e1eef66fe0d16115", async() => {
                BeginContext(2390, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
                                                   WriteLiteral(item.PatientId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2398, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 57 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
                             if (User.IsInRole("Administrator") || User.IsInRole("Instructor"))
                            {

#line default
#line hidden
            BeginContext(2528, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(2560, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68ebc9befd90ab225171b9a8b2519e1eef66fe0d18930", async() => {
                BeginContext(2637, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
                                                         WriteLiteral(item.PatientId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2647, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 60 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
                            }

#line default
#line hidden
            BeginContext(2680, 213, true);
            WriteLiteral("                            </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td colspan=\"4\" style=\"padding:0;\">\r\n                            <div class=\"accordian-body collapse\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2893, "\"", 2913, 1);
#line 65 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
WriteAttributeValue("", 2898, item.PatientId, 2898, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2914, 486, true);
            WriteLiteral(@">
                                <div class=""col-md-12"">
                                    <p style=""color: indigo; font-weight:bold;"">Addition Patient Information:</p>
                                </div>
                                <div class=""col-md-12"">
                                    <div class=""row"">
                                        <div class=""col-md-4"">
                                            <p><span style=""font-weight:bold;"">Gender: </span> ");
            EndContext();
            BeginContext(3401, 48, false);
#line 72 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.Person.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(3449, 210, true);
            WriteLiteral("</p>\r\n                                        </div>\r\n                                        <div class=\"col-md-4\">\r\n                                            <p><span style=\"font-weight:bold;\">SSN: </span> ");
            EndContext();
            BeginContext(3660, 45, false);
#line 75 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
                                                                                       Write(Html.DisplayFor(modelItem => item.Person.Ssn));

#line default
#line hidden
            EndContext();
            BeginContext(3705, 218, true);
            WriteLiteral("</p>\r\n                                        </div>\r\n                                        <div class=\"col-md-4\">\r\n                                            <p><span style=\"font-weight:bold;\">Last Update: </span> ");
            EndContext();
            BeginContext(3924, 46, false);
#line 78 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
                                                                                               Write(Html.DisplayFor(modelItem => item.DateUpdated));

#line default
#line hidden
            EndContext();
            BeginContext(3970, 313, true);
            WriteLiteral(@"</p>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-md-4"">
                                            <p><span style=""font-weight:bold;"">Address: </span> ");
            EndContext();
            BeginContext(4284, 63, false);
#line 83 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
                                                                                           Write(Html.DisplayFor(modelItem => item.Person.ResidentStreetAddress));

#line default
#line hidden
            EndContext();
            BeginContext(4347, 211, true);
            WriteLiteral("</p>\r\n                                        </div>\r\n                                        <div class=\"col-md-2\">\r\n                                            <p><span style=\"font-weight:bold;\">City: </span> ");
            EndContext();
            BeginContext(4559, 55, false);
#line 86 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
                                                                                        Write(Html.DisplayFor(modelItem => item.Person.ResidenceCity));

#line default
#line hidden
            EndContext();
            BeginContext(4614, 212, true);
            WriteLiteral("</p>\r\n                                        </div>\r\n                                        <div class=\"col-md-2\">\r\n                                            <p><span style=\"font-weight:bold;\">State: </span> ");
            EndContext();
            BeginContext(4827, 56, false);
#line 89 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Person.ResidenceState));

#line default
#line hidden
            EndContext();
            BeginContext(4883, 215, true);
            WriteLiteral("</p>\r\n                                        </div>\r\n                                        <div class=\"col-md-2\">\r\n                                            <p><span style=\"font-weight:bold;\">Zip-Code: </span> ");
            EndContext();
            BeginContext(5099, 54, false);
#line 92 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"
                                                                                            Write(Html.DisplayFor(modelItem => item.Person.ResidenceZip));

#line default
#line hidden
            EndContext();
            BeginContext(5153, 232, true);
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 99 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientResults.cshtml"

                }

#line default
#line hidden
            BeginContext(5406, 298, true);
            WriteLiteral(@"                </tbody>
        </table>
        <div class=""text-center"">
            <p>Can't Find the Patient Your Looking For? <br /> Please Select From One of the Options Below</p>
        </div>            
        <div class=""row"">
            <div class=""col-md-6"">
                ");
            EndContext();
            BeginContext(5704, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68ebc9befd90ab225171b9a8b2519e1eef66fe0d28129", async() => {
                BeginContext(5765, 21, true);
                WriteLiteral("Return to Search Page");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5790, 74, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                ");
            EndContext();
            BeginContext(5864, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68ebc9befd90ab225171b9a8b2519e1eef66fe0d29680", async() => {
                BeginContext(5922, 18, true);
                WriteLiteral("Create New Patient");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5944, 58, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Project.Data.Patient>> Html { get; private set; }
    }
}
#pragma warning restore 1591