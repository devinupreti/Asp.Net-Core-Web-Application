#pragma checksum "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\EducationProject.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62b1ac2265316c1740e187908d53cd07db236d01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Data_EducationProject), @"mvc.1.0.view", @"/Views/Data/EducationProject.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Data/EducationProject.cshtml", typeof(AspNetCore.Views_Data_EducationProject))]
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
#line 1 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\_ViewImports.cshtml"
using Lab11;

#line default
#line hidden
#line 2 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\_ViewImports.cshtml"
using Lab11.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62b1ac2265316c1740e187908d53cd07db236d01", @"/Views/Data/EducationProject.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c172b55b71960e66355fb598a7c159c834642198", @"/Views/_ViewImports.cshtml")]
    public class Views_Data_EducationProject : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lab11.Models.Project>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteProject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Educations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\EducationProject.cshtml"
  
    Layout = "~/Views/Shared/_MyLayout.cshtml";

#line default
#line hidden
            BeginContext(100, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\EducationProject.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
            BeginContext(130, 97, true);
            WriteLiteral("<h3>List of Projects</h3>\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(228, 47, false);
#line 14 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\EducationProject.cshtml"
           Write(Html.DisplayNameFor(model => model.ProjectName));

#line default
#line hidden
            EndContext();
            BeginContext(275, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(331, 40, false);
#line 17 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\EducationProject.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(371, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(427, 46, false);
#line 20 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\EducationProject.cshtml"
           Write(Html.DisplayNameFor(model => model.Technology));

#line default
#line hidden
            EndContext();
            BeginContext(473, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(529, 47, false);
#line 23 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\EducationProject.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(576, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
#line 25 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\EducationProject.cshtml"
             if (User.IsInRole("Admin"))
            {

#line default
#line hidden
            BeginContext(654, 23, true);
            WriteLiteral("            <th></th>\r\n");
            EndContext();
#line 28 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\EducationProject.cshtml"
            }

#line default
#line hidden
            BeginContext(692, 42, true);
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 32 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\EducationProject.cshtml"
         foreach (var project in Model)
        {

#line default
#line hidden
            BeginContext(786, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(835, 49, false);
#line 36 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\EducationProject.cshtml"
           Write(Html.DisplayFor(modelItem => project.ProjectName));

#line default
#line hidden
            EndContext();
            BeginContext(884, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(940, 42, false);
#line 39 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\EducationProject.cshtml"
           Write(Html.DisplayFor(modelItem => project.Year));

#line default
#line hidden
            EndContext();
            BeginContext(982, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1038, 48, false);
#line 42 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\EducationProject.cshtml"
           Write(Html.DisplayFor(modelItem => project.Technology));

#line default
#line hidden
            EndContext();
            BeginContext(1086, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1142, 49, false);
#line 45 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\EducationProject.cshtml"
           Write(Html.DisplayFor(modelItem => project.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1191, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
#line 47 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\EducationProject.cshtml"
             if (User.IsInRole("Admin"))
            {

#line default
#line hidden
            BeginContext(1269, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(1303, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62b1ac2265316c1740e187908d53cd07db236d019527", async() => {
                BeginContext(1367, 14, true);
                WriteLiteral("Delete Project");
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
#line 50 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\EducationProject.cshtml"
                                                WriteLiteral(project.ProjectId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1385, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1405, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62b1ac2265316c1740e187908d53cd07db236d0111914", async() => {
                BeginContext(1467, 12, true);
                WriteLiteral("Edit Project");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\EducationProject.cshtml"
                                              WriteLiteral(project.ProjectId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1483, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
#line 53 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\EducationProject.cshtml"
            }

#line default
#line hidden
            BeginContext(1519, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 55 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\EducationProject.cshtml"
        }

#line default
#line hidden
            BeginContext(1545, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
#line 58 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\EducationProject.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1581, 59, true);
            WriteLiteral("<br>\r\n<h3>There are no projects for this Education!!</h3>\r\n");
            EndContext();
#line 63 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\EducationProject.cshtml"
}

#line default
#line hidden
            BeginContext(1643, 17, true);
            WriteLiteral("<br>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1660, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62b1ac2265316c1740e187908d53cd07db236d0115415", async() => {
                BeginContext(1687, 17, true);
                WriteLiteral("Back to Education");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1708, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lab11.Models.Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591