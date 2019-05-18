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
    [Authorize(Roles = "User")]
    public class RecruiterController : Controller
    {
        private readonly ApplicationDbContext context_;
        private const string sessionId_ = "SessionId";

        public RecruiterController(ApplicationDbContext context)
        {
            context_ = context;
        }

        //----< first page / index >-------------------------------
        public IActionResult Index()
        {
            return View();
        }

        // view my notes
        public IActionResult MyNotes()
        {
            var myNotes = context_.Notes.Where(n => n.RecruiterName == User.Identity.Name).ToList();
            return View(myNotes);
            //return View(context_.Notes.ToList<Note>());
        }

        // view my notes
        public IActionResult MyRequests()
        {
            var myReq = context_.Requests.Where(n => n.RecruiterName == User.Identity.Name).ToList();
            return View(myReq);
            return View(context_.Requests.ToList<Request>());
        }

        //---------------------------------------------------------
        // NOTES LOGIC
        //---------------------------------------------------------

        // displays form for creating a note 
        [HttpGet]
        public IActionResult CreateNote(int id)
        {
            var model = new Note();
            return View(model);
        }

        // posts back new note details
        [HttpPost]
        public IActionResult CreateNote(int id, Note note)
        {
            string username = User.Identity.Name;
            note.RecruiterName = username;
            context_.Notes.Add(note);
            context_.SaveChanges();
            return RedirectToAction("Index");
        }
        

        //---------------------------------------------------------
        // REQUESTS LOGIC
        //---------------------------------------------------------

        // displays form for creating a request 
        [HttpGet]
        public IActionResult CreateRequest(int id)
        {
            var model = new Request();
            return View(model);
        }

        // posts back new request details
        [HttpPost]
        public IActionResult CreateRequest(int id, Request req)
        {
            string username = User.Identity.Name;
            req.RecruiterName = username;
            context_.Requests.Add(req);
            context_.SaveChanges();
            return RedirectToAction("Index");
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
