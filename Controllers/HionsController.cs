using Hion.Models;
using Hion.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hion.Controllers
{
    public class HionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HionsController()
        {
            _context = new ApplicationDbContext();
        }
        
        [Authorize]
        public ActionResult Create()
        {
            var vm = new HionFormViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View(vm);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HionFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Genres = _context.Genres.ToList();
                return View("Create", viewModel);
            }
     
            var hion = new Models.Hion
            {
                HostId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                GenrerId = viewModel.Genre,
                Venue = viewModel.Venue,
                Title = viewModel.Title
            };

            _context.Hions.Add(hion);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");

        }
    }
}