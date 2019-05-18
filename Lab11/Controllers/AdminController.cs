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
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {

        private readonly ApplicationDbContext context_;
        private const string sessionId_ = "SessionId";

        public AdminController(ApplicationDbContext context)
        {
            context_ = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        // view all notes
        public IActionResult Notes()
        {
            return View(context_.Notes.ToList<Note>());
        }

        // view all notes
        public IActionResult Requests()
        {
            return View(context_.Requests.ToList<Request>());
        }

        // Notes --------------------------------------------------
        //----< deletes a note by id >-----------------------------
        public IActionResult DeleteNote(int? id)
        {
            if (id == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            try
            {
                var note = context_.Notes.Find(id);
                if (note != null)
                {
                    context_.Remove(note);
                    context_.SaveChanges();
                }
            }
            catch (Exception)
            {
                // nothing for now
            }
            return RedirectToAction("Notes");
        }

        // gets form to edit a specific note via id 
        [HttpGet]
        public IActionResult EditNote(int? id)
        {
            if (id == null)
            {
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest);
            }
            Note note = context_.Notes.Find(id);
            if (note == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            return View(note);
        }

        // posts back edited results for specific note 
        [HttpPost]
        public IActionResult EditNote(int? id, Note note)
        {
            if (id == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            var note_ = context_.Notes.Find(id);
            if (note_ != null)
            {
                note.NoteId = note_.NoteId;
                note.NoteName = note_.NoteName;
                note.NoteContent = note_.NoteContent;
                note.RecruiterName = note_.RecruiterName;

                try
                {
                    context_.SaveChanges();
                }
                catch (Exception)
                {
                    // do nothing for now
                }
            }
            return RedirectToAction("Index");
        }

        // Requests --------------------------------------------------
        //----< deletes a request by id >-----------------------------
        public IActionResult DeleteRequest(int? id)
        {
            if (id == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            try
            {
                var request = context_.Requests.Find(id);
                if (request != null)
                {
                    context_.Remove(request);
                    context_.SaveChanges();
                }
            }
            catch (Exception)
            {
                // nothing for now
            }
            return RedirectToAction("Requests");
        }

        // gets form to edit a specific request via id 
        [HttpGet]
        public IActionResult EditRequest(int? id)
        {
            if (id == null)
            {
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest);
            }
            Request request = context_.Requests.Find(id);
            if (request == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            return View(request);
        }

        // posts back edited results for specific request 
        [HttpPost]
        public IActionResult EditRequest(int? id, Request request)
        {
            if (id == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            var request_ = context_.Requests.Find(id);
            if (request_ != null)
            {
                request.RequestId = request_.RequestId;
                request.RequestName = request_.RequestName;
                request.RequestContent = request_.RequestContent;
                request.RecruiterName = request_.RecruiterName;

                try
                {
                    context_.SaveChanges();
                }
                catch (Exception)
                {
                    // do nothing for now
                }
            }
            return RedirectToAction("Index");
        }

    }
}
