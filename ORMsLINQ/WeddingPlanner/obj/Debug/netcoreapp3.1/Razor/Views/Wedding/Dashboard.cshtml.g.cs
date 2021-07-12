#pragma checksum "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\WeddingPlanner\Views\Wedding\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c1dc694bce4ca371dde6a9aa33b4426bf22ead8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wedding_Dashboard), @"mvc.1.0.view", @"/Views/Wedding/Dashboard.cshtml")]
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
#line 1 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\WeddingPlanner\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c1dc694bce4ca371dde6a9aa33b4426bf22ead8", @"/Views/Wedding/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74b8ca08b40f37ad1199f2c8f4e56e10e34ca9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Wedding_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Wedding>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav>
    <h2>Welcome to The Wedding Planner</h2> <a href=""/logout"">Logout</a>
</nav>

<div class=""table mt-5"">
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th scope=""col"">Wedding</th>
                <th scope=""col"">Date</th>
                <th scope=""col"">Guests</th>
                <th scope=""col"">Action</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 17 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\WeddingPlanner\Views\Wedding\Dashboard.cshtml"
              
                foreach( Wedding w in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <th><a");
            BeginWriteAttribute("href", " href=\"", 565, "\"", 593, 2);
            WriteAttributeValue("", 572, "/wedding/", 572, 9, true);
#nullable restore
#line 21 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\WeddingPlanner\Views\Wedding\Dashboard.cshtml"
WriteAttributeValue("", 581, w.WeddingId, 581, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\WeddingPlanner\Views\Wedding\Dashboard.cshtml"
                                                       Write(w.WedderOne);

#line default
#line hidden
#nullable disable
            WriteLiteral(" & ");
#nullable restore
#line 21 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\WeddingPlanner\Views\Wedding\Dashboard.cshtml"
                                                                      Write(w.WedderTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></th>\n                        <td>");
#nullable restore
#line 22 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\WeddingPlanner\Views\Wedding\Dashboard.cshtml"
                       Write(w.Date.Date.ToString("MMM dd yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 23 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\WeddingPlanner\Views\Wedding\Dashboard.cshtml"
                       Write(w.Guests.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 24 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\WeddingPlanner\Views\Wedding\Dashboard.cshtml"
                          
                            if (ViewBag.LoggedInUser == w.UserId)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><a");
            BeginWriteAttribute("href", " href=\"", 912, "\"", 939, 2);
            WriteAttributeValue("", 919, "/delete/", 919, 8, true);
#nullable restore
#line 27 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\WeddingPlanner\Views\Wedding\Dashboard.cshtml"
WriteAttributeValue("", 927, w.WeddingId, 927, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></td>\n");
#nullable restore
#line 28 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\WeddingPlanner\Views\Wedding\Dashboard.cshtml"
                            }
                            else if (w.Guests.Any( u => u.UserId == ViewBag.LoggedInUser))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1146, "\"", 1173, 2);
            WriteAttributeValue("", 1153, "/unrsvp/", 1153, 8, true);
#nullable restore
#line 31 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\WeddingPlanner\Views\Wedding\Dashboard.cshtml"
WriteAttributeValue("", 1161, w.WeddingId, 1161, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Un-RSVP</a></td>\n");
#nullable restore
#line 32 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\WeddingPlanner\Views\Wedding\Dashboard.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1323, "\"", 1348, 2);
            WriteAttributeValue("", 1330, "/rsvp/", 1330, 6, true);
#nullable restore
#line 35 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\WeddingPlanner\Views\Wedding\Dashboard.cshtml"
WriteAttributeValue("", 1336, w.WeddingId, 1336, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">RSVP</a></td>\n");
#nullable restore
#line 36 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\WeddingPlanner\Views\Wedding\Dashboard.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \n                    </tr>\n");
#nullable restore
#line 40 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\WeddingPlanner\Views\Wedding\Dashboard.cshtml"
                }
                   
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            \n        </tbody>\n    </table>\n\n    <a href=\"new\" class=\"btn btn-info float-right mt-4\">New Wedding</a>\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Wedding>> Html { get; private set; }
    }
}
#pragma warning restore 1591
