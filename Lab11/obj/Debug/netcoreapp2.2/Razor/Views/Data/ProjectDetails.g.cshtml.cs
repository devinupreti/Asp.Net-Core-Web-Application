#pragma checksum "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\ProjectDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66cd96f6645d7fb10fa1b0961bb0e9c61c095879"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Data_ProjectDetails), @"mvc.1.0.view", @"/Views/Data/ProjectDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Data/ProjectDetails.cshtml", typeof(AspNetCore.Views_Data_ProjectDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66cd96f6645d7fb10fa1b0961bb0e9c61c095879", @"/Views/Data/ProjectDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c172b55b71960e66355fb598a7c159c834642198", @"/Views/_ViewImports.cshtml")]
    public class Views_Data_ProjectDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab11.Models.Project>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Projects", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\ProjectDetails.cshtml"
  
    Layout = "~/Views/Shared/_MyLayout.cshtml";

#line default
#line hidden
            BeginContext(87, 136, true);
            WriteLiteral("\r\n<h1>Project Details</h1>\r\n\r\n<div>\r\n    <h4>Project</h4>\r\n    <hr />\r\n    <ul>\r\n        <li>\r\n            <strong>Job Title :</strong> ");
            EndContext();
            BeginContext(224, 43, false);
#line 14 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\ProjectDetails.cshtml"
                                    Write(Html.DisplayFor(model => model.ProjectName));

#line default
#line hidden
            EndContext();
            BeginContext(267, 67, true);
            WriteLiteral("\r\n        </li>\r\n        <li>\r\n            <strong>Year :</strong> ");
            EndContext();
            BeginContext(335, 36, false);
#line 17 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\ProjectDetails.cshtml"
                               Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(371, 73, true);
            WriteLiteral("\r\n        </li>\r\n        <li>\r\n            <strong>Technology :</strong> ");
            EndContext();
            BeginContext(445, 42, false);
#line 20 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\ProjectDetails.cshtml"
                                     Write(Html.DisplayFor(model => model.Technology));

#line default
#line hidden
            EndContext();
            BeginContext(487, 74, true);
            WriteLiteral("\r\n        </li>\r\n        <li>\r\n            <strong>Description :</strong> ");
            EndContext();
            BeginContext(562, 43, false);
#line 23 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\ProjectDetails.cshtml"
                                      Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(605, 53, true);
            WriteLiteral("\r\n        </li>\r\n    </ul>\r\n</div>\r\n<br>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(658, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66cd96f6645d7fb10fa1b0961bb0e9c61c0958795837", async() => {
                BeginContext(683, 20, true);
                WriteLiteral("Back to all Projects");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(707, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab11.Models.Project> Html { get; private set; }
    }
}
#pragma warning restore 1591