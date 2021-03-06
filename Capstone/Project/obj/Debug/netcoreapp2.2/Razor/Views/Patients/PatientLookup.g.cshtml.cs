#pragma checksum "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientLookup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc70030ae8d11ed81b96f16887abc6eb89f69d7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patients_PatientLookup), @"mvc.1.0.view", @"/Views/Patients/PatientLookup.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patients/PatientLookup.cshtml", typeof(AspNetCore.Views_Patients_PatientLookup))]
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
#line 1 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientLookup.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc70030ae8d11ed81b96f16887abc6eb89f69d7b", @"/Views/Patients/PatientLookup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df5661587fee894f038b02eb626dd99e5d2e2ecc", @"/Views/_ViewImports.cshtml")]
    public class Views_Patients_PatientLookup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("lookupForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Patients", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PatientLookup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(142, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientLookup.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(189, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientLookup.cshtml"
 if (SignInManager.IsSignedIn(User))
{

#line default
#line hidden
            BeginContext(232, 23, true);
            WriteLiteral("    <div class=\"row\">\r\n");
            EndContext();
#line 12 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientLookup.cshtml"
         if (User.IsInRole("Administrator") || User.IsInRole("Instructor") || User.IsInRole("DataEntry"))
        {

#line default
#line hidden
            BeginContext(373, 191, true);
            WriteLiteral("            <div class=\"panel\">\r\n                <div class=\"panel-body\">\r\n                    <!--Patient lookup form-->\r\n                    <h2>Search for Mother</h2>\r\n                    ");
            EndContext();
            BeginContext(564, 2172, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc70030ae8d11ed81b96f16887abc6eb89f69d7b6371", async() => {
                BeginContext(673, 2056, true);
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-xs-7"">
                                <div class=""form-group"">
                                    <label for=""lastNameText"">Last Name:</label>
                                    <input type=""text"" name=""lastName"" id=""lastName"" class=""form-control"" />
                                </div>
                                <div class=""form-group"">
                                    <label for=""DOBText"">Date of Birth: (Optional)</label>
                                    <input type=""date"" name=""dob"" id=""DOBText"" class=""form-control"" />
                                </div>
                                <div style=""vertical-align: bottom"" class=""form-group"">
                                    <button type=""submit"" name=""button"" value=""nameSearch"" class=""btn btn-primary"">
                                        <span class=""glyphicon glyphicon-search""></span>
                                    </button>
");
                WriteLiteral(@"                                </div>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class=""row"">
                            <div class=""col-xs-6"">

                                <div class=""form-group"">
                                    <label for=""MRNText"">Medical Record Number:</label>
                                    <input type=""number"" name=""mrn"" id=""mrn"" class=""form-control"" />
                                </div>
                                <div style=""vertical-align: bottom"" class=""form-group"">
                                    <button type=""submit"" name=""button"" value=""mrnSearch"" class=""btn btn-primary"">
                                        <span class=""glyphicon glyphicon-search""></span>
                                    </button>
                                </div>
                            </div>

                        </div>

            ");
                WriteLiteral("        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2736, 46, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 58 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientLookup.cshtml"
             if (ViewBag.PatientFound == false)
            {

#line default
#line hidden
            BeginContext(2848, 148, true);
            WriteLiteral("                <h4 class=\"text-danger\">Patient not found. Would you like to create a patient?</h4>\r\n                <button class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2996, "\"", 3043, 3);
            WriteAttributeValue("", 3006, "location.href=\'", 3006, 15, true);
#line 61 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientLookup.cshtml"
WriteAttributeValue("", 3021, Url.Action("Create"), 3021, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 3042, "\'", 3042, 1, true);
            EndWriteAttribute();
            BeginContext(3044, 18, true);
            WriteLiteral(">Create</button>\r\n");
            EndContext();
#line 62 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientLookup.cshtml"
            }
            

#line default
#line hidden
#line 86 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientLookup.cshtml"
              
        }
        else
        {

#line default
#line hidden
            BeginContext(4337, 326, true);
            WriteLiteral(@"            <div class=""panel"">
                <div class=""panel-body centerText"">
                    <h2>Welcome to BRIT Systems!</h2>
                    <h4>Your account is currently under review. <br />Once the review is complete, you will have access to the system.</h4>
                </div>
            </div>
");
            EndContext();
#line 96 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientLookup.cshtml"
        }

#line default
#line hidden
            BeginContext(4674, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 98 "D:\Programming\Capstone\HCS-Project\Project\Views\Patients\PatientLookup.cshtml"
}


#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
