#pragma checksum "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\ExperienceDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f12a9ed6a0bc1c0831355cbf3706b6d33d37b754"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Data_ExperienceDetails), @"mvc.1.0.view", @"/Views/Data/ExperienceDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Data/ExperienceDetails.cshtml", typeof(AspNetCore.Views_Data_ExperienceDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f12a9ed6a0bc1c0831355cbf3706b6d33d37b754", @"/Views/Data/ExperienceDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c172b55b71960e66355fb598a7c159c834642198", @"/Views/_ViewImports.cshtml")]
    public class Views_Data_ExperienceDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab11.Models.Experience>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Experiences", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\ExperienceDetails.cshtml"
  
    Layout = "~/Views/Shared/_MyLayout.cshtml";

#line default
#line hidden
            BeginContext(90, 142, true);
            WriteLiteral("\r\n<h1>Experience Details</h1>\r\n\r\n<div>\r\n    <h4>Experience</h4>\r\n    <hr />\r\n    <ul>\r\n        <li>\r\n            <strong>Job Title :</strong> ");
            EndContext();
            BeginContext(233, 40, false);
#line 14 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\ExperienceDetails.cshtml"
                                    Write(Html.DisplayFor(model => model.JobTitle));

#line default
#line hidden
            EndContext();
            BeginContext(273, 71, true);
            WriteLiteral("\r\n        </li>\r\n        <li>\r\n            <strong>Location :</strong> ");
            EndContext();
            BeginContext(345, 40, false);
#line 17 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\ExperienceDetails.cshtml"
                                   Write(Html.DisplayFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(385, 73, true);
            WriteLiteral("\r\n        </li>\r\n        <li>\r\n            <strong>Start Date :</strong> ");
            EndContext();
            BeginContext(459, 41, false);
#line 20 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\ExperienceDetails.cshtml"
                                     Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(500, 71, true);
            WriteLiteral("\r\n        </li>\r\n        <li>\r\n            <strong>End Date :</strong> ");
            EndContext();
            BeginContext(572, 39, false);
#line 23 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\ExperienceDetails.cshtml"
                                   Write(Html.DisplayFor(model => model.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(611, 74, true);
            WriteLiteral("\r\n        </li>\r\n        <li>\r\n            <strong>Description :</strong> ");
            EndContext();
            BeginContext(686, 43, false);
#line 26 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Data\ExperienceDetails.cshtml"
                                      Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(729, 53, true);
            WriteLiteral("\r\n        </li>\r\n    </ul>\r\n</div>\r\n<br>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(782, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f12a9ed6a0bc1c0831355cbf3706b6d33d37b7546360", async() => {
                BeginContext(810, 23, true);
                WriteLiteral("Back to all Experiences");
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
            BeginContext(837, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab11.Models.Experience> Html { get; private set; }
    }
}
#pragma warning restore 1591
