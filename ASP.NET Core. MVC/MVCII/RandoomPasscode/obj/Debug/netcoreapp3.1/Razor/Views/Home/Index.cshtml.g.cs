#pragma checksum "C:\Users\halmu\OneDrive\Documents\C#.NET core\ASP.NET Core. MVC\MVCII\RandoomPasscode\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc703951edd111e2a26dd02190094a14f659fd10"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc703951edd111e2a26dd02190094a14f659fd10", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ASP.NET Core. MVC\MVCII\RandoomPasscode\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Random Passcode Generator";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <p>Random Passcode (psscode number #");
#nullable restore
#line 6 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ASP.NET Core. MVC\MVCII\RandoomPasscode\Views\Home\Index.cshtml"
                                   Write(ViewBag.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</p>\n    <div class=\"pass\">\n        <h4>");
#nullable restore
#line 8 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ASP.NET Core. MVC\MVCII\RandoomPasscode\Views\Home\Index.cshtml"
       Write(ViewBag.RandCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n        <form action=\"/generate\" method=\"POST\">\n            <button type=\"submit\">Generate</button>\n        </form>\n    </div>\n</div>\n");
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
