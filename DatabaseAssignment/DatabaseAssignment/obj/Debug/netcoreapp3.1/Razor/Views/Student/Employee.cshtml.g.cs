#pragma checksum "D:\net sol\DatabaseAssignment\DatabaseAssignment\Views\Student\Employee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ae76421f5c28189bfc3bfa20a88c41911e2dd59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Employee), @"mvc.1.0.view", @"/Views/Student/Employee.cshtml")]
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
#nullable restore
#line 1 "D:\net sol\DatabaseAssignment\DatabaseAssignment\Views\_ViewImports.cshtml"
using DatabaseAssignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\net sol\DatabaseAssignment\DatabaseAssignment\Views\_ViewImports.cshtml"
using DatabaseAssignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ae76421f5c28189bfc3bfa20a88c41911e2dd59", @"/Views/Student/Employee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"167006b6c7c8732361aa951fc3257563fe3ac307", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Employee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DatabaseEntities.Entities.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\net sol\DatabaseAssignment\DatabaseAssignment\Views\Student\Employee.cshtml"
  
    ViewData["Title"] = "Employee";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Employee</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "D:\net sol\DatabaseAssignment\DatabaseAssignment\Views\Student\Employee.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\net sol\DatabaseAssignment\DatabaseAssignment\Views\Student\Employee.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\net sol\DatabaseAssignment\DatabaseAssignment\Views\Student\Employee.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeAge));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\net sol\DatabaseAssignment\DatabaseAssignment\Views\Student\Employee.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "D:\net sol\DatabaseAssignment\DatabaseAssignment\Views\Student\Employee.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "D:\net sol\DatabaseAssignment\DatabaseAssignment\Views\Student\Employee.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "D:\net sol\DatabaseAssignment\DatabaseAssignment\Views\Student\Employee.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "D:\net sol\DatabaseAssignment\DatabaseAssignment\Views\Student\Employee.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeAge));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "D:\net sol\DatabaseAssignment\DatabaseAssignment\Views\Student\Employee.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 44 "D:\net sol\DatabaseAssignment\DatabaseAssignment\Views\Student\Employee.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n<nav aria-label=\"Page navigation example\">\r\n    <ul class=\"pagination\">\r\n");
#nullable restore
#line 51 "D:\net sol\DatabaseAssignment\DatabaseAssignment\Views\Student\Employee.cshtml"
         if (ViewBag.PageNo > 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">");
#nullable restore
#line 53 "D:\net sol\DatabaseAssignment\DatabaseAssignment\Views\Student\Employee.cshtml"
                             Write(Html.ActionLink("Previous", "Employee", new { id = ViewBag.PageNo - 1 }, new { @class = "page-link" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 54 "D:\net sol\DatabaseAssignment\DatabaseAssignment\Views\Student\Employee.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\net sol\DatabaseAssignment\DatabaseAssignment\Views\Student\Employee.cshtml"
         for (int i = 1; i <= ViewBag.TotalPages; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">");
#nullable restore
#line 57 "D:\net sol\DatabaseAssignment\DatabaseAssignment\Views\Student\Employee.cshtml"
                             Write(Html.ActionLink("" + i, "Employee", new { id = i }, new { @class = "page-link" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 58 "D:\net sol\DatabaseAssignment\DatabaseAssignment\Views\Student\Employee.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\net sol\DatabaseAssignment\DatabaseAssignment\Views\Student\Employee.cshtml"
         if (ViewBag.PageNo != ViewBag.TotalPages)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">");
#nullable restore
#line 61 "D:\net sol\DatabaseAssignment\DatabaseAssignment\Views\Student\Employee.cshtml"
                             Write(Html.ActionLink("Next", "Employee", new { id = ViewBag.PageNo + 1 }, new { @class = "page-link" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 62 "D:\net sol\DatabaseAssignment\DatabaseAssignment\Views\Student\Employee.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DatabaseEntities.Entities.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
