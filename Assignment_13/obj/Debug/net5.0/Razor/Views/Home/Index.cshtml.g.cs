#pragma checksum "D:\IUPUI\FALL_2021\CIT_24200\code\Assignment_13\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bb01132d78ac8165c18d4fc866026954a84eddb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\IUPUI\FALL_2021\CIT_24200\code\Assignment_13\Views\_ViewImports.cshtml"
using Assignment_12;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\IUPUI\FALL_2021\CIT_24200\code\Assignment_13\Views\_ViewImports.cshtml"
using Assignment_12.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bb01132d78ac8165c18d4fc866026954a84eddb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d6d9ac630e1995cabbe35e06c21093e1a49ceb9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Assignment_12.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\IUPUI\FALL_2021\CIT_24200\code\Assignment_13\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Our exclusive products</h1>\r\n");
#nullable restore
#line 9 "D:\IUPUI\FALL_2021\CIT_24200\code\Assignment_13\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"product-div\">\r\n            <div>Product Id: ");
#nullable restore
#line 12 "D:\IUPUI\FALL_2021\CIT_24200\code\Assignment_13\Views\Home\Index.cshtml"
                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"name-box\">\r\n                <h1><a");
            BeginWriteAttribute("href", " href=\"", 361, "\"", 396, 2);
            WriteAttributeValue("", 368, "/home/productdetail/", 368, 20, true);
#nullable restore
#line 14 "D:\IUPUI\FALL_2021\CIT_24200\code\Assignment_13\Views\Home\Index.cshtml"
WriteAttributeValue("", 388, item.Id, 388, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "D:\IUPUI\FALL_2021\CIT_24200\code\Assignment_13\Views\Home\Index.cshtml"
                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h1>\r\n                <p>$");
#nullable restore
#line 15 "D:\IUPUI\FALL_2021\CIT_24200\code\Assignment_13\Views\Home\Index.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div>Product Description: ");
#nullable restore
#line 17 "D:\IUPUI\FALL_2021\CIT_24200\code\Assignment_13\Views\Home\Index.cshtml"
                                 Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n");
#nullable restore
#line 19 "D:\IUPUI\FALL_2021\CIT_24200\code\Assignment_13\Views\Home\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Assignment_12.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
