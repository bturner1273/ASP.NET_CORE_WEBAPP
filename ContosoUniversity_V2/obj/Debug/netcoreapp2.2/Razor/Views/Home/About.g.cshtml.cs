#pragma checksum "C:\Users\bturner\source\repos\ContosoUniversity_V2\ContosoUniversity_V2\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33dd9548c45c2f220ac50e942d5eeb9048e2b33c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\bturner\source\repos\ContosoUniversity_V2\ContosoUniversity_V2\Views\_ViewImports.cshtml"
using ContosoUniversity_V2;

#line default
#line hidden
#line 2 "C:\Users\bturner\source\repos\ContosoUniversity_V2\ContosoUniversity_V2\Views\_ViewImports.cshtml"
using ContosoUniversity_V2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33dd9548c45c2f220ac50e942d5eeb9048e2b33c", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da12e36148339a5ac4ea0638329ab586b83ffe2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ContosoUniversity_V2.Models.SchoolViewModels.EnrollmentDateGroup>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(87, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\bturner\source\repos\ContosoUniversity_V2\ContosoUniversity_V2\Views\Home\About.cshtml"
  
    ViewData["Title"] = "Student Body Statistics";

#line default
#line hidden
            BeginContext(148, 145, true);
            WriteLiteral("\r\n<h1>Student Body Statistics</h1>\r\n\r\n<table>\r\n    <tr>\r\n        <th>Enrollment Date</th>\r\n        <th class=\"pl-sm-3\">Students</th>\r\n    </tr>\r\n");
            EndContext();
#line 14 "C:\Users\bturner\source\repos\ContosoUniversity_V2\ContosoUniversity_V2\Views\Home\About.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
            BeginContext(333, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(382, 49, false);
#line 18 "C:\Users\bturner\source\repos\ContosoUniversity_V2\ContosoUniversity_V2\Views\Home\About.cshtml"
           Write(Html.DisplayFor(modelItem => item.EnrollmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(431, 71, true);
            WriteLiteral("\r\n            </td>\r\n            <td class=\"pl-sm-3\">\r\n                ");
            EndContext();
            BeginContext(503, 17, false);
#line 21 "C:\Users\bturner\source\repos\ContosoUniversity_V2\ContosoUniversity_V2\Views\Home\About.cshtml"
           Write(item.StudentCount);

#line default
#line hidden
            EndContext();
            BeginContext(520, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 24 "C:\Users\bturner\source\repos\ContosoUniversity_V2\ContosoUniversity_V2\Views\Home\About.cshtml"
     }

#line default
#line hidden
            BeginContext(564, 14, true);
            WriteLiteral("</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ContosoUniversity_V2.Models.SchoolViewModels.EnrollmentDateGroup>> Html { get; private set; }
    }
}
#pragma warning restore 1591
