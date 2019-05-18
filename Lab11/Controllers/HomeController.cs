using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab11.Models;
using Lab11.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Extensions;
using Microsoft.AspNetCore.Authorization;

namespace Lab11.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext context_;
        private const string sessionId_ = "SessionId";

        public HomeController(ApplicationDbContext context)
        {
            context_ = context;
        }

        //----< first page / index >-------------------------------
        public IActionResult Index()
        {
            return View();
        }

        // view containing description about me
        public IActionResult About()
        {
            return View();
        }

        // personal info view
        public IActionResult Personal()
        {
            return View();
        }

        // professional info view
        public IActionResult Professional()
        {
            return View();
        }

        // contact information view
        public IActionResult Contact()
        {
            return View();
        }

        // professional info view
        public IActionResult Resume()
        {
            return View();
        }

        //----< wizard generated actions >---------------------------
        public IActionResult Privacy()
        {
            return View();
        }

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
