#pragma checksum "D:\Programming\Capstone\HCS-Project\Project\Views\RoleAdmin\EditAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "484cf6bd91f895edc853238066654689357d3a15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RoleAdmin_EditAdd), @"mvc.1.0.view", @"/Views/RoleAdmin/EditAdd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RoleAdmin/EditAdd.cshtml", typeof(AspNetCore.Views_RoleAdmin_EditAdd))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"484cf6bd91f895edc853238066654689357d3a15", @"/Views/RoleAdmin/EditAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df5661587fee894f038b02eb626dd99e5d2e2ecc", @"/Views/_ViewImports.cshtml")]
    public class Views_RoleAdmin_EditAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleEditModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Programming\Capstone\HCS-Project\Project\Views\RoleAdmin\EditAdd.cshtml"
  
    ViewData["Title"] = "Add Users";

#line default
#line hidden
            BeginContext(69, 124, true);
            WriteLiteral("\r\n<div class=\"panel\">\r\n    <div class=\"panel-body\">\r\n        <div class=\"underline-Heading\">\r\n            <h2>Add Users to: ");
            EndContext();
            BeginContext(194, 15, false);
#line 10 "D:\Programming\Capstone\HCS-Project\Project\Views\RoleAdmin\EditAdd.cshtml"
                         Write(Model.Role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(209, 166, true);
            WriteLiteral(" Role</h2>\r\n        </div>\r\n        <br />\r\n        <input class=\"form-control\" id=\"userSearch\" type=\"text\" placeholder=\"Search for user..\">\r\n        <br />\r\n        ");
            EndContext();
            BeginContext(375, 1417, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "484cf6bd91f895edc853238066654689357d3a155924", async() => {
                BeginContext(413, 50, true);
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"roleName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 463, "\"", 487, 1);
#line 16 "D:\Programming\Capstone\HCS-Project\Project\Views\RoleAdmin\EditAdd.cshtml"
WriteAttributeValue("", 471, Model.Role.Name, 471, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(488, 51, true);
                WriteLiteral(" />\r\n            <input type=\"hidden\" name=\"roleId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 539, "\"", 561, 1);
#line 17 "D:\Programming\Capstone\HCS-Project\Project\Views\RoleAdmin\EditAdd.cshtml"
WriteAttributeValue("", 547, Model.Role.Id, 547, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(562, 312, true);
                WriteLiteral(@" />

            <table class=""table table-striped table-sm"" id=""userTable"">
                <tr>
                    <th><input type=""checkbox"" id=""checkAll"" /></th>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>Email</th>
                </tr>
");
                EndContext();
#line 26 "D:\Programming\Capstone\HCS-Project\Project\Views\RoleAdmin\EditAdd.cshtml"
                 if (Model.NonMembers.Count() == 0)
                {

#line default
#line hidden
                BeginContext(946, 73, true);
                WriteLiteral("                    <tr><td colspan=\"4\">All Users Are Members</td></tr>\r\n");
                EndContext();
#line 29 "D:\Programming\Capstone\HCS-Project\Project\Views\RoleAdmin\EditAdd.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#line 32 "D:\Programming\Capstone\HCS-Project\Project\Views\RoleAdmin\EditAdd.cshtml"
                     foreach (ApplicationUser user in Model.NonMembers)
                    {

#line default
#line hidden
                BeginContext(1175, 148, true);
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <input class=\"check\" type=\"checkbox\" name=\"IdsToAdd\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1323, "\"", 1339, 1);
#line 36 "D:\Programming\Capstone\HCS-Project\Project\Views\RoleAdmin\EditAdd.cshtml"
WriteAttributeValue("", 1331, user.Id, 1331, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1340, 72, true);
                WriteLiteral(" />\r\n                            </td>\r\n                            <td>");
                EndContext();
                BeginContext(1413, 14, false);
#line 38 "D:\Programming\Capstone\HCS-Project\Project\Views\RoleAdmin\EditAdd.cshtml"
                           Write(user.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(1427, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(1467, 13, false);
#line 39 "D:\Programming\Capstone\HCS-Project\Project\Views\RoleAdmin\EditAdd.cshtml"
                           Write(user.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(1480, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(1520, 10, false);
#line 40 "D:\Programming\Capstone\HCS-Project\Project\Views\RoleAdmin\EditAdd.cshtml"
                           Write(user.Email);

#line default
#line hidden
                EndContext();
                BeginContext(1530, 38, true);
                WriteLiteral("</td>\r\n                        </tr>\r\n");
                EndContext();
#line 42 "D:\Programming\Capstone\HCS-Project\Project\Views\RoleAdmin\EditAdd.cshtml"
                    }

#line default
#line hidden
#line 42 "D:\Programming\Capstone\HCS-Project\Project\Views\RoleAdmin\EditAdd.cshtml"
                     
                }

#line default
#line hidden
                BeginContext(1610, 107, true);
                WriteLiteral("            </table>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n            ");
                EndContext();
                BeginContext(1717, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "484cf6bd91f895edc853238066654689357d3a1510838", async() => {
                    BeginContext(1765, 6, true);
                    WriteLiteral("Cancel");
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
                BeginContext(1775, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1792, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1834, 552, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            $(""#userSearch"").on(""keyup"", function () {
                var value = $(this).val().toLowerCase();
                $(""#userTable tr"").filter(function () {
                    $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                });
            });

            $(""#checkAll"").click(function () {
                $(""#userTable .check"").prop('checked', $(this).prop('checked'));
            });
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(2389, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleEditModel> Html { get; private set; }
    }
}
#pragma warning restore 1591