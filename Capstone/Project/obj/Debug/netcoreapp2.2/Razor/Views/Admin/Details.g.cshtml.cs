#pragma checksum "D:\Programming\Capstone\HCS-Project\Project\Views\Admin\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6a5ae923ceb4a17a2cfa0de88c7ce11024a4724"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Details), @"mvc.1.0.view", @"/Views/Admin/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Details.cshtml", typeof(AspNetCore.Views_Admin_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6a5ae923ceb4a17a2cfa0de88c7ce11024a4724", @"/Views/Admin/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df5661587fee894f038b02eb626dd99e5d2e2ecc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(24, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Programming\Capstone\HCS-Project\Project\Views\Admin\Details.cshtml"
  
    ViewData["Title"] = "User Details";

#line default
#line hidden
            BeginContext(74, 266, true);
            WriteLiteral(@"
<div class=""panel"">
    <div class=""panel-body"">
            <div class=""underline-Heading"">
                <h2>User Details</h2>
            </div>
            <br />
            <dl class=""row"">
                <dt class=""col-sm-2"">
                    ");
            EndContext();
            BeginContext(341, 45, false);
#line 15 "D:\Programming\Capstone\HCS-Project\Project\Views\Admin\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(386, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(472, 41, false);
#line 18 "D:\Programming\Capstone\HCS-Project\Project\Views\Admin\Details.cshtml"
               Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(513, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(598, 44, false);
#line 21 "D:\Programming\Capstone\HCS-Project\Project\Views\Admin\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(642, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(728, 40, false);
#line 24 "D:\Programming\Capstone\HCS-Project\Project\Views\Admin\Details.cshtml"
               Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(768, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(853, 41, false);
#line 27 "D:\Programming\Capstone\HCS-Project\Project\Views\Admin\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(894, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(980, 37, false);
#line 30 "D:\Programming\Capstone\HCS-Project\Project\Views\Admin\Details.cshtml"
               Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 136, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    ");
            EndContext();
            BeginContext(1153, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6a5ae923ceb4a17a2cfa0de88c7ce11024a47247351", async() => {
                BeginContext(1199, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1215, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1238, 90, false);
#line 36 "D:\Programming\Capstone\HCS-Project\Project\Views\Admin\Details.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
            EndContext();
            BeginContext(1328, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1351, 93, false);
#line 37 "D:\Programming\Capstone\HCS-Project\Project\Views\Admin\Details.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = Model.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1444, 64, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591