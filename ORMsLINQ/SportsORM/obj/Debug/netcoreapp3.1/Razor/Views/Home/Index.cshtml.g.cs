#pragma checksum "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46d44f698e2b31ecefc6a56cccc7ea52b934ab5c"
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
#line 1 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\_ViewImports.cshtml"
using SportsORM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\_ViewImports.cshtml"
using SportsORM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46d44f698e2b31ecefc6a56cccc7ea52b934ab5c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9a3b39dc302e35aa04228b18cde52e620ba27a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""card mb-3"">
    <div class=""card-header text-light bg-dark"">
        Sports ORM
    </div>
    <div class=""card-body"">
        <p>Using the SportsORM, complete all the following queries and show their results in <a href=""/level_1"">Level 1</a>, <a href=""/level_2"">Level 2</a>, and <a href=""/level_3"">Level 3</a>. The purpose of this assignment is to practice using LINQ and Entity Framework to make queries on a pre-existing database. Your goal for this assignment is to modify Controllers/HomeController.cs to display the information in Level1.cshtml, Level2.cshtml, and Level3.cshtml with the correct data.</p>
        <p><strong>Hint:</strong> use ViewBag to pass the data to the Razor templates.</p>
    </div>
</div>

<div class=""row"">

    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <pre class=""prettyprint"">
// Inside of HomeController.cs
[HttpGet("""")]
public IActionResult Index()
&#123;
    ViewBag.BaseballLeagues = context.Leagues
        .Whe");
            WriteLiteral(@"re(l => l.Sport.Contains(""Baseball""))
        .ToList();
    return View();
&#125;
                </pre>
                <pre class=""prettyprint"">
&lt;!-- Inside of Index.cshtml --&gt;
&lt;table class=""table table-striped""&gt;
    &lt;tr&gt;
        &lt;th&gt;League Name&lt;/th&gt;
        &lt;th&gt;League Sport&lt;/th&gt;
    &lt;/tr&gt;
    &#64;foreach(var l in ViewBag.BaseballLeagues)
    &#123;
        &lt;tr&gt;
            &lt;td&gt;&#64;l.Name&lt;/td&gt;
            &lt;td&gt;&#64;l.Sport&lt;/td&gt;
        &lt;/tr&gt;
    &#125;
&lt;/table&gt;
                </pre>
            </div>
        </div>
    </div>

    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h3>All Baseball Leagues</h3>
                <table class=""table table-striped"">
                    <tr>
                        <th>League Name</th>
                        <th>League Sport</th>
                    </tr>
");
#nullable restore
#line 56 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Index.cshtml"
                     foreach(var l in ViewBag.BaseballLeagues)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 59 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Index.cshtml"
                           Write(l.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 60 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Index.cshtml"
                           Write(l.Sport);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 62 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\n            </div>\n        </div>\n    </div>\n\n</div>\n\n<script src=\"https://cdn.rawgit.com/google/code-prettify/master/loader/run_prettify.js\"></script>");
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
