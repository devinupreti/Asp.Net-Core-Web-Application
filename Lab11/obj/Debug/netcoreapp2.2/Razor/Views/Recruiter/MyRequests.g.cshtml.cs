#pragma checksum "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Recruiter\MyRequests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a89241e3e9fb1a6c8c626f8d6e336dd7a6cad21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recruiter_MyRequests), @"mvc.1.0.view", @"/Views/Recruiter/MyRequests.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recruiter/MyRequests.cshtml", typeof(AspNetCore.Views_Recruiter_MyRequests))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a89241e3e9fb1a6c8c626f8d6e336dd7a6cad21", @"/Views/Recruiter/MyRequests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c172b55b71960e66355fb598a7c159c834642198", @"/Views/_ViewImports.cshtml")]
    public class Views_Recruiter_MyRequests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lab11.Models.Request>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Recruiter\MyRequests.cshtml"
  
    Layout = "~/Views/Shared/_MyLayout.cshtml";

#line default
#line hidden
            BeginContext(100, 99, true);
            WriteLiteral("\r\n<h3>List of Requests</h3>\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(200, 47, false);
#line 12 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Recruiter\MyRequests.cshtml"
           Write(Html.DisplayNameFor(model => model.RequestName));

#line default
#line hidden
            EndContext();
            BeginContext(247, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(303, 50, false);
#line 15 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Recruiter\MyRequests.cshtml"
           Write(Html.DisplayNameFor(model => model.RequestContent));

#line default
#line hidden
            EndContext();
            BeginContext(353, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(409, 49, false);
#line 18 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Recruiter\MyRequests.cshtml"
           Write(Html.DisplayNameFor(model => model.RecruiterName));

#line default
#line hidden
            EndContext();
            BeginContext(458, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 23 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Recruiter\MyRequests.cshtml"
         foreach (var req in Model)
        {

#line default
#line hidden
            BeginContext(569, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(618, 45, false);
#line 27 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Recruiter\MyRequests.cshtml"
           Write(Html.DisplayFor(modelItem => req.RequestName));

#line default
#line hidden
            EndContext();
            BeginContext(663, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(719, 48, false);
#line 30 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Recruiter\MyRequests.cshtml"
           Write(Html.DisplayFor(modelItem => req.RequestContent));

#line default
#line hidden
            EndContext();
            BeginContext(767, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(823, 47, false);
#line 33 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Recruiter\MyRequests.cshtml"
           Write(Html.DisplayFor(modelItem => req.RecruiterName));

#line default
#line hidden
            EndContext();
            BeginContext(870, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 36 "C:\Users\Devin\Desktop\PROJECT\final_project\Lab11\Lab11\Views\Recruiter\MyRequests.cshtml"
        }

#line default
#line hidden
            BeginContext(917, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lab11.Models.Request>> Html { get; private set; }
    }
}
#pragma warning restore 1591