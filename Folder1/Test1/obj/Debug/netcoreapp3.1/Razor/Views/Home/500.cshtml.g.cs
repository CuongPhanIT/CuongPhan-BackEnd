#pragma checksum "/home/cuong/NET CORE/Folder1/Test1/Views/Home/500.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94b64919d1633d8127fa18cf18f96d0bf47fea41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_500), @"mvc.1.0.view", @"/Views/Home/500.cshtml")]
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
#line 1 "/home/cuong/NET CORE/Folder1/Test1/Views/_ViewImports.cshtml"
using Test1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/cuong/NET CORE/Folder1/Test1/Views/_ViewImports.cshtml"
using Test1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94b64919d1633d8127fa18cf18f96d0bf47fea41", @"/Views/Home/500.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d141cd04f235e3d15b7011b4eee70e5574f9b1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_500 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/cuong/NET CORE/Folder1/Test1/Views/Home/500.cshtml"
  
    ViewBag.Title = "(500) An Error Occurred";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/cuong/NET CORE/Folder1/Test1/Views/Home/500.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>(500) An Error Occurred.</h1>\n<p>Something went wrong.</p>\n<p>Please, contact the support by emailing them this page error.</p>\n<p>To find the available contacts go to: ");
#nullable restore
#line 10 "/home/cuong/NET CORE/Folder1/Test1/Views/Home/500.cshtml"
                                    Write(Html.ActionLink("Contacts", "Privacy", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
