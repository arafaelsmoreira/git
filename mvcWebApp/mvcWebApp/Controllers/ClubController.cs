﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvcWebApp.Data;
using mvcWebApp.Models;

namespace mvcWebApp.Controllers
{
    public class ClubController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ClubController(ApplicationDbContext context)
        {
            _context = context;

        }


        public IActionResult Index()
        {

            List<Club> clubs = _context.Clubs.ToList();
            return View(clubs);
        }

        public IActionResult Detail(int id)
        {
            Club club = _context.Clubs.Include(a => a.Address).FirstOrDefault(c => c.Id == id);
            return View(club);
        }
    }
}
