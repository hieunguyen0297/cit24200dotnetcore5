#pragma checksum "D:\IUPUI\FALL_2021\CIT_24200\code\Homework_15\WorkingWithRazorPage\Pages\employees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a568bc587478b2cd71b13d85dd6798019ccb8bd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_employees), @"mvc.1.0.razor-page", @"/Pages/employees.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a568bc587478b2cd71b13d85dd6798019ccb8bd6", @"/Pages/employees.cshtml")]
    public class Pages_employees : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">

    <h1>Employees</h1>
    <table class=""table"">
        <thead>
           <tr>
               <th>Employee ID</th>
               <th>Last Name</th>
               <th>First Name</th>
               <th>Title</th>
               <th>Birth Date</th>
               <th>Hire Date</th>
               <th>Address</th>
               <th>City</th>
               <th>Region</th>
               <th>Postal Code</th>
               <th>Country</th>
               <th>Home Phone</th>
           </tr> 
           
        </thead>
        <tbody>
");
#nullable restore
#line 26 "D:\IUPUI\FALL_2021\CIT_24200\code\Homework_15\WorkingWithRazorPage\Pages\employees.cshtml"
             foreach (var item in Model.Employees)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 29 "D:\IUPUI\FALL_2021\CIT_24200\code\Homework_15\WorkingWithRazorPage\Pages\employees.cshtml"
                   Write(item.EmployeeID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "D:\IUPUI\FALL_2021\CIT_24200\code\Homework_15\WorkingWithRazorPage\Pages\employees.cshtml"
                   Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "D:\IUPUI\FALL_2021\CIT_24200\code\Homework_15\WorkingWithRazorPage\Pages\employees.cshtml"
                   Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "D:\IUPUI\FALL_2021\CIT_24200\code\Homework_15\WorkingWithRazorPage\Pages\employees.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "D:\IUPUI\FALL_2021\CIT_24200\code\Homework_15\WorkingWithRazorPage\Pages\employees.cshtml"
                   Write(item.BirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <th>");
#nullable restore
#line 34 "D:\IUPUI\FALL_2021\CIT_24200\code\Homework_15\WorkingWithRazorPage\Pages\employees.cshtml"
                   Write(item.HireDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 35 "D:\IUPUI\FALL_2021\CIT_24200\code\Homework_15\WorkingWithRazorPage\Pages\employees.cshtml"
                   Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "D:\IUPUI\FALL_2021\CIT_24200\code\Homework_15\WorkingWithRazorPage\Pages\employees.cshtml"
                   Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "D:\IUPUI\FALL_2021\CIT_24200\code\Homework_15\WorkingWithRazorPage\Pages\employees.cshtml"
                   Write(item.Region);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "D:\IUPUI\FALL_2021\CIT_24200\code\Homework_15\WorkingWithRazorPage\Pages\employees.cshtml"
                   Write(item.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "D:\IUPUI\FALL_2021\CIT_24200\code\Homework_15\WorkingWithRazorPage\Pages\employees.cshtml"
                   Write(item.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "D:\IUPUI\FALL_2021\CIT_24200\code\Homework_15\WorkingWithRazorPage\Pages\employees.cshtml"
                   Write(item.HomePhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 42 "D:\IUPUI\FALL_2021\CIT_24200\code\Homework_15\WorkingWithRazorPage\Pages\employees.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WorkingWithRazorPage.Pages.EmployeesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WorkingWithRazorPage.Pages.EmployeesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WorkingWithRazorPage.Pages.EmployeesModel>)PageContext?.ViewData;
        public WorkingWithRazorPage.Pages.EmployeesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
