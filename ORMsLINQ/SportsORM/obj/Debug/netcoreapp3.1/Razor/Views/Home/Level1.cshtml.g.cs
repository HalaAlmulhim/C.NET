#pragma checksum "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b0cd65a671984d6be35efbfe690fa775aa43256"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Level1), @"mvc.1.0.view", @"/Views/Home/Level1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b0cd65a671984d6be35efbfe690fa775aa43256", @"/Views/Home/Level1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9a3b39dc302e35aa04228b18cde52e620ba27a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Level1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-header bg-dark text-light"">Level 1</div>
    <div class=""card-body"">
        <p>Using the SportsORM, complete all the following queries and show their results on Level1.cshtml.</p>
        <ol>
            <li>...all womens' leagues</li>
            <li>...all leagues where sport is any type of hockey</li>
            <li>...all leagues where sport is something OTHER THAN football</li>
            <li>...all leagues that call themselves ""conferences""</li>
            <li>...all leagues in the Atlantic region</li>
            <li>...all teams based in Dallas</li>
            <li>...all teams named the Raptors</li>
            <li>...all teams whose location includes ""City""</li>
            <li>...all teams whose names begin with ""T""</li>
            <li>...all teams, ordered alphabetically by location</li>
            <li>...all teams, ordered by team name in reverse alphabetical order</li>
            <li>...every player with last name ""Cooper""</li>
            <li>...");
            WriteLiteral(@"every player with first name ""Joshua""</li>
            <li>...every player with last name ""Cooper"" EXCEPT those with ""Joshua"" as the first name</li>
            <li>...all players with first name ""Alexander"" OR first name ""Wyatt""</li>
        </ol>
    </div>
</div>

<div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h3>All womens' leagues</h3>
                <table class=""table table-striped""> 
                    <tr>
                        <th>League Name</th>
                        <th>League Sport</th>
                    </tr>
");
#nullable restore
#line 35 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                     foreach(var l in ViewBag.WomensLeagues)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 38 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(l.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 39 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(l.Sport);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 41 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </table>
            </div>
        </div>
    </div>

    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h3>All Hockey leagues</h3>
                <table class=""table table-striped""> 
                    <tr>
                        <th>League Name</th>
                        <th>League Sport</th>
                    </tr>
");
#nullable restore
#line 56 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                     foreach(var l in ViewBag.HockeyLeagues)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 59 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(l.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 60 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(l.Sport);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 62 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </table>
            </div>
        </div>
    </div>

    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h3>All leagues where sport is something OTHER THAN football</h3>
                <table class=""table table-striped""> 
                    <tr>
                        <th>League Name</th>
                        <th>League Sport</th>
                    </tr>
");
#nullable restore
#line 77 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                     foreach(var l in ViewBag.NotFootballLeages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 80 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(l.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 81 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(l.Sport);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 83 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </table>
            </div>
        </div>
    </div>

    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h3>Conference Leagues</h3>
                <table class=""table table-striped""> 
                    <tr>
                        <th>League Name</th>
                        <th>League Sport</th>
                    </tr>
");
#nullable restore
#line 98 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                     foreach(var l in ViewBag.ConferenceLeagues)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 101 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(l.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 102 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(l.Sport);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 104 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </table>
            </div>
        </div>
    </div>

    
    
    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h3>Atlantic Leagues</h3>
                <table class=""table table-striped""> 
                    <tr>
                        <th>League Name</th>
                        <th>League Sport</th>
                    </tr>
");
#nullable restore
#line 121 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                     foreach(var l in ViewBag.AtlanticLeagues)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 124 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(l.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 125 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(l.Sport);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 127 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </table>
            </div>
        </div>
    </div>

    
    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h3>Dallas Teams</h3>
                <table class=""table table-striped""> 
                    <tr>
                        <th>Team Name</th>
                        <th>Team Location</th>
                    </tr>
");
#nullable restore
#line 143 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                     foreach(var t in ViewBag.DallasTeams)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 146 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(t.TeamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 147 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(t.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 149 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </table>
            </div>
        </div>
    </div>

    

    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h3>Raptors Teams</h3>
                <table class=""table table-striped""> 
                    <tr>
                        <th>Team Name</th>
                        <th>Team Location</th>
                    </tr>
");
#nullable restore
#line 166 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                     foreach(Team t in ViewBag.RaptorsTeams)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 169 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(t.TeamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 170 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(t.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 172 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </table>
            </div>
        </div>
    </div>


    
    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h3>City Teams</h3>
                <table class=""table table-striped""> 
                    <tr>
                        <th>Team Name</th>
                        <th>Team Location</th>
                    </tr>
");
#nullable restore
#line 189 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                     foreach(Team t in ViewBag.CityTeams)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 192 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(t.TeamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 193 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(t.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 195 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </table>
            </div>
        </div>
    </div>

        <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h3>Teams Start with T</h3>
                <table class=""table table-striped""> 
                    <tr>
                        <th>Team Name</th>
                        <th>Team Location</th>
                    </tr>
");
#nullable restore
#line 210 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                     foreach(Team t in ViewBag.Tteams)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 213 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(t.TeamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 214 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(t.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 216 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </table>
            </div>
        </div>
    </div>

    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h3>All teams, ordered alphabetically by location</h3>
                <table class=""table table-striped""> 
                    <tr>
                        <th>Team Name</th>
                        <th>Team Location</th>
                    </tr>
");
#nullable restore
#line 231 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                     foreach(Team t in ViewBag.TeamsOrderedByLoc)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 234 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(t.TeamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 235 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(t.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 237 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </table>
            </div>
        </div>
    </div>

    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h3>All teams, ordered by team name in reverse alphabetical order</h3>
                <table class=""table table-striped""> 
                    <tr>
                        <th>Team Name</th>
                        <th>Team Location</th>
                    </tr>
");
#nullable restore
#line 252 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                     foreach(Team t in ViewBag.TeamsOrderdByNameRev)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 255 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(t.TeamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 256 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(t.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 258 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </table>
            </div>
        </div>
    </div>

    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h3>Player with last name ""Cooper""</h3>
                <table class=""table table-striped""> 
                    <tr>
                        <th>Player First Name</th>
                        <th>Player Last Name</th>
                    </tr>
");
#nullable restore
#line 273 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                     foreach(Player p in ViewBag.PlayersWithLnCooper)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 276 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(p.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 277 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(p.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 279 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </table>
            </div>
        </div>
    </div>

    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h3>Player with first name Joshua</h3>
                <table class=""table table-striped""> 
                    <tr>
                        <th>Player First Name</th>
                        <th>Player Last Name</th>
                    </tr>
");
#nullable restore
#line 294 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                     foreach(Player p in ViewBag.PlayersWithFnJoshua)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 297 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(p.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 298 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(p.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 300 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </table>
            </div>
        </div>
    </div>

    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h3>Players with last name ""Cooper"" EXCEPT those with ""Joshua"" as the first name</h3>
                <table class=""table table-striped""> 
                    <tr>
                        <th>Player First Name</th>
                        <th>Player Last Name</th>
                    </tr>
");
#nullable restore
#line 315 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                     foreach(Player p in ViewBag.CoopersNotJoshuas)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 318 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(p.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 319 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(p.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 321 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </table>
            </div>
        </div>
    </div>

    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h3>Players with first name ""Alexander"" OR first name ""Wyatt""</h3>
                <table class=""table table-striped""> 
                    <tr>
                        <th>Player First Name</th>
                        <th>Player Last Name</th>
                    </tr>
");
#nullable restore
#line 336 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                     foreach(Player p in ViewBag.AlexandersAndWyatts)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 339 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(p.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 340 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                           Write(p.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 342 "C:\Users\halmu\Downloads\Csharp_ASP.NET_Core-main\Csharp_ASP.NET_Core-main\ASPNetCore\ORMs\SportsORM\Views\Home\Level1.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\n            </div>\n        </div>\n    </div>\n\n\n\n\n\n    ");
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
