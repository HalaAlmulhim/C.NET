using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;
using Microsoft.EntityFrameworkCore;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1() 
        {
            //starting from here
            ViewBag.One = _context.Leagues.Where(w => w.Name.Contains("Women")).ToList();
            ViewBag.Two = _context.Leagues.Where(h => h.Name.Contains("Hockey")).ToList();
            ViewBag.Three = _context.Leagues.Where(f => !f.Name.Contains("Football")).ToList();
            ViewBag.Four = _context.Leagues.Where(c => c.Name.Contains("Conference")).ToList();
            ViewBag.Five = _context.Leagues.Where(a => a.Name.Contains("Atlantic")).ToList();   
            ViewBag.Six = _context.Teams.Where(d => d.Location == "Dallas").ToList();
            ViewBag.Seven = _context.Teams.Where(r => r.TeamName == "Raptors").ToList();
            ViewBag.Eight = _context.Teams.Where(c => c.Location.Contains("City")).ToList();
            ViewBag.Nine = _context.Teams.Where(t => t.TeamName.StartsWith("T")).ToList();
            ViewBag.Ten = _context.Teams.OrderBy(l => l.Location).ToList();
            ViewBag.Eleven = _context.Teams.OrderByDescending(b => b.TeamName).ToList();
            ViewBag.Twelve  = _context.Players.Where(c => c.LastName == "Cooper").ToList(); 
            ViewBag.Thirteen  = _context.Players.Where(j => j.FirstName == "Joshua").ToList();
            ViewBag.Fourteen  = _context.Players.Where(n => n.LastName == "Cooper" && n.FirstName != "Joshua").ToList();
            ViewBag.Fifteen  = _context.Players.Where(n => n.FirstName == "Alexander" || n.FirstName == "Wyatt").ToList();
            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            ViewBag.One = _context.Teams.Include(a => a.CurrLeague)
                                    .Where(a => a.CurrLeague.Name
                                    .Contains("Atlantic Soccer Conference"))
                                    .ToList();
            ViewBag.Two = _context.Players.Include(p => p.CurrentTeam)
                                    .Where(p => p.CurrentTeam.TeamName == "Penguins" && p.CurrentTeam.Location == "Boston")
                                    .ToList();
            ViewBag.Three = _context.Teams.Include(i => i.CurrLeague)
                                    .Where(i => i.CurrLeague.Name == "International Collegiate Baseball Conference")
                                    .ToList();
            ViewBag.Four = _context.Teams.Include(a => a.CurrLeague)
                                    .Where(a => a.CurrLeague.Name == "American Conference of Amateur Football")
                                    .ToList();
            ViewBag.Five = _context.Teams.Include(f => f.CurrLeague)
                                    .Where(f => f.CurrLeague.Sport.ToLower() == "football")
                                    .ToList();
            ViewBag.Six = _context.Teams.Include(s => s.CurrentPlayers)
                                    .Where(s => s.CurrentPlayers.Any(s => s.FirstName == "Sophia" || s.LastName == "Sophia"))
                                    .ToList();
            ViewBag.eight = _context.Players.Include(f => f.CurrentTeam)
                                    .Where(f => f.CurrentTeam.TeamName != "Raptors" && f.LastName == "Flores")
                                    .ToList();
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
             // .all teams, past and present, that Samuel Evans has played with
            ViewBag.One = _context.Players.Include(p => p.CurrentTeam)
                            .Include(s => s.AllTeams)
                            .ThenInclude(pt => pt.TeamOfPlayer)
                            .Where(e => e.FirstName == "Samuel" && e.LastName == "Evans")
                            .ToList();
             // all players, past and present, with the Manitoba Tiger-Cats
            ViewBag.Two = _context.Teams.Include(m => m.AllPlayers)
                            .ThenInclude(pt => pt.PlayerOnTeam)
                            .FirstOrDefault(t => t.Location == "Manitoba" && t.TeamName == "Tiger-Cats");
            // all players who were formerly (but aren't currently) with the Wichita Vikings
            ViewBag.Three = _context.PlayerTeams.Include(pt => pt.PlayerOnTeam)
                            .ThenInclude(w => w.CurrentTeam)
                            .Include(pt => pt.TeamOfPlayer)
                            .Where(pt => pt.TeamOfPlayer.Location == "Wichita" && pt.TeamOfPlayer.TeamName == "Vikings")
                            .Where(pt => pt.PlayerOnTeam.CurrentTeam.Location != "Wichita" && pt.PlayerOnTeam.CurrentTeam.TeamName != "Vikings")
                            .ToList();
            // every team that Jacob Gray played for before he joined the Oregon Colts
            ViewBag.Four = _context.PlayerTeams.Include(pt => pt.PlayerOnTeam)
                            .ThenInclude(j => j.CurrentTeam)
                            .Include(pt => pt.TeamOfPlayer)
                            .Where(pt => pt.PlayerOnTeam.FirstName == "Jacob" && pt.PlayerOnTeam.LastName == "Gray")
                            .Where(pt => pt.TeamOfPlayer.Location != "Oregon" && pt.TeamOfPlayer.TeamName != "Colts")
                            .ToList();
            // everyone named "Joshua" who has ever played in the Atlantic Federation of Amateur Baseball Players
            ViewBag.Five = _context.Players
                            .Include(p => p.CurrentTeam)
                            .ThenInclude(ct => ct.CurrLeague)
                            .Include(p => p.AllTeams)
                            .ThenInclude(at => at.TeamOfPlayer)
                            .ThenInclude(tp => tp.CurrLeague)
                            .Where(p => 
                                p.FirstName == "Joshua"
                                &&
                                (
                                    p.AllTeams
                                        .Where(at => at.TeamOfPlayer.CurrLeague.Name == "Atlantic Federation of Amateur Baseball Players")
                                        .Count() > 0
                                    ||
                                    p.CurrentTeam.CurrLeague.Name == "Atlantic Federation of Amateur Baseball Players"
                                )
                            );
            // all teams that have had 12 or more players, past and present.
            ViewBag.Six = _context.Teams.Include(p => p.CurrentPlayers)
                            .Include(s => s.AllPlayers)
                            .Where(e => e.CurrentPlayers.Count > 12)
                            .ToList();
            // all players, sorted by the number of teams they've played for
            ViewBag.Seven = _context.Players.Include(p => p.AllTeams)
                            .OrderByDescending(p => p.AllTeams.Count)
                            .ToList();
            return View();
        }

    }
}