#pragma checksum "D:\Programming\Capstone\HCS-Project\Project\Views\Facility\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6040f4dd68c77c44e7e84709cf0e576b8d3f9e54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Facility_Details), @"mvc.1.0.view", @"/Views/Facility/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Facility/Details.cshtml", typeof(AspNetCore.Views_Facility_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6040f4dd68c77c44e7e84709cf0e576b8d3f9e54", @"/Views/Facility/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df5661587fee894f038b02eb626dd99e5d2e2ecc", @"/Views/_ViewImports.cshtml")]
    public class Views_Facility_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project.Data.Facility>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Programming\Capstone\HCS-Project\Project\Views\Facility\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
            BeginContext(71, 197, true);
            WriteLiteral("\r\n    <div class=\"panel\">\r\n        <div class=\"panel-body\">\r\n            <div class=\"underline-Heading\">\r\n                <h2>Facility Information </h2>\r\n                <h4 style=\"color: indigo\"> ");
            EndContext();
            BeginContext(269, 44, false);
#line 11 "D:\Programming\Capstone\HCS-Project\Project\Views\Facility\Details.cshtml"
                                      Write(Html.DisplayFor(model => model.FacilityName));

#line default
#line hidden
            EndContext();
            BeginContext(313, 4, true);
            WriteLiteral(" | #");
            EndContext();
            BeginContext(318, 46, false);
#line 11 "D:\Programming\Capstone\HCS-Project\Project\Views\Facility\Details.cshtml"
                                                                                       Write(Html.DisplayFor(model => model.FacilityNumber));

#line default
#line hidden
            EndContext();
            BeginContext(364, 118, true);
            WriteLiteral("</h4>\r\n            </div>\r\n            <dl class=\"row\">\r\n\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(483, 50, false);
#line 16 "D:\Programming\Capstone\HCS-Project\Project\Views\Facility\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.FacilityNumber));

#line default
#line hidden
            EndContext();
            BeginContext(533, 87, true);
            WriteLiteral("\r\n                </dt>\r\n\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(621, 46, false);
#line 20 "D:\Programming\Capstone\HCS-Project\Project\Views\Facility\Details.cshtml"
               Write(Html.DisplayFor(model => model.FacilityNumber));

#line default
#line hidden
            EndContext();
            BeginContext(667, 86, true);
            WriteLiteral("\r\n                </dd>\r\n\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(754, 48, false);
#line 24 "D:\Programming\Capstone\HCS-Project\Project\Views\Facility\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.FacilityName));

#line default
#line hidden
            EndContext();
            BeginContext(802, 87, true);
            WriteLiteral("\r\n                </dt>\r\n\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(890, 44, false);
#line 28 "D:\Programming\Capstone\HCS-Project\Project\Views\Facility\Details.cshtml"
               Write(Html.DisplayFor(model => model.FacilityName));

#line default
#line hidden
            EndContext();
            BeginContext(934, 86, true);
            WriteLiteral("\r\n                </dd>\r\n\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(1021, 48, false);
#line 32 "D:\Programming\Capstone\HCS-Project\Project\Views\Facility\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.FacilityType));

#line default
#line hidden
            EndContext();
            BeginContext(1069, 87, true);
            WriteLiteral("\r\n                </dt>\r\n\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1157, 60, false);
#line 36 "D:\Programming\Capstone\HCS-Project\Project\Views\Facility\Details.cshtml"
               Write(Html.DisplayFor(model => model.FacilityType.TypeDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1217, 136, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    ");
            EndContext();
            BeginContext(1353, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6040f4dd68c77c44e7e84709cf0e576b8d3f9e548344", async() => {
                BeginContext(1399, 12, true);
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
            BeginContext(1415, 72, true);
            WriteLiteral("\r\n                    <div class=\"pull-right\">\r\n                        ");
            EndContext();
            BeginContext(1488, 98, false);
#line 43 "D:\Programming\Capstone\HCS-Project\Project\Views\Facility\Details.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = Model.FacilityId }, new { @class = "btn btn-warning" }));

#line default
#line hidden
            EndContext();
            BeginContext(1586, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1777, 126, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n               \r\n            </div>\r\n        </div>       \r\n    </div>\r\n  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project.Data.Facility> Html { get; private set; }
    }
}
#pragma warning restore 1591
