using Lab11.Data;
using Lab11.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Lab11.Controllers
{
    public class DataController : Controller
    {
        private readonly ApplicationDbContext context_;
        private const string sessionId_ = "SessionId";

        public DataController(ApplicationDbContext context)
        {
            context_ = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        // view all experiences
        public IActionResult Experiences()
        {
            return View(context_.Experiences.ToList<Experience>());
        }

        // view all educations
        public IActionResult Educations()
        {
            return View(context_.Educations.ToList<Education>());
        }

        // view all projects
        public IActionResult Projects()
        {
            return View(context_.Projects.ToList<Project>());
        }

        // view all companies
        public IActionResult Companies()
        {
            return View(context_.Companies.ToList<Company>());
        }

        // list all experiences associated with a specific company
        public IActionResult CompanyExperience(int? id)
        {
            HttpContext.Session.SetInt32(sessionId_, id ?? 0);
            if (id == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            var experiences = context_.Experiences.Where(p => p.CompanyId == id).ToList();
            return View(experiences);
        }

        // list all experiences associated with a specific company
        public IActionResult EducationProject(int? id)
        {
            HttpContext.Session.SetInt32(sessionId_, id ?? 0);
            if (id == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            var projects = context_.Projects.Where(p => p.EducationId == id).ToList();
            return View(projects);
        }

        //---------------------------------------------------------------------------------
        // EXPERIENCES Model Logic
        //---------------------------------------------------------------------------------

        // not used in current implementation
        // displays form for creating a experience 
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult CreateExperience(int id)
        {
            var model = new Experience();
            return View(model);
        }

        // not used in current implementation
        // posts back new experience details
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult CreateExperience(int id, Experience exp)
        {
            context_.Experiences.Add(exp);
            context_.SaveChanges();
            return RedirectToAction("Experiences");
        }

        //----< add new experience to company >--------------------------

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult AddExperience(int id)
        {
            HttpContext.Session.SetInt32(sessionId_, id);

            Company company = context_.Companies.Find(id);
            if (company == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            Experience exp = new Experience();
            return View(exp);
        }

        //----< Add new experience to company >--------------------------

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult AddExperience(int? id, Experience exp)
        {
            if (id == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            // retreive the target course from static field

            int? companyId_ = HttpContext.Session.GetInt32(sessionId_);

            // this works too
            // int courseId_ = (int)TempData[sessionId_];

            var company = context_.Companies.Find(companyId_);

            if (company != null)
            {
                if (company.Experiences == null)  // doesn't have any lectures yet
                {
                    List<Experience> experiences = new List<Experience>();
                    company.Experiences = experiences;
                }
                company.Experiences.Add(exp);

                try
                {
                    context_.SaveChanges();
                }
                catch (Exception)
                {
                    // do nothing for now
                }
            }
            return RedirectToAction("Companies");
        }

        //----< deletes a experience by id >-----------------------------
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteExperience(int? id)
        {
            if (id == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            try
            {
                var ins = context_.Experiences.Find(id);
                if (ins != null)
                {
                    context_.Remove(ins);
                    context_.SaveChanges();
                }
            }
            catch (Exception)
            {
                // nothing for now
            }
            return RedirectToAction("Experiences");
        }

        // gets form to edit a specific experience via id 
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult EditExperience(int? id)
        {
            if (id == null)
            {
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest);
            }
            Experience exp = context_.Experiences.Find(id);
            if (exp == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            return View(exp); 
        }

        // posts back edited results for specific experience 
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult EditExperience(int? id, Experience exp)
        {
            if (id == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            var experience = context_.Experiences.Find(id);
            if (experience != null)
            {
                experience.ExperienceId = exp.ExperienceId;
                experience.JobTitle = exp.JobTitle;
                experience.Location = exp.Location;
                experience.StartDate = exp.StartDate;
                experience.EndDate = exp.EndDate;
                experience.Description = exp.Description;

                try
                {
                    context_.SaveChanges();
                }
                catch (Exception)
                {
                    // do nothing for now
                }
            }
            return RedirectToAction("Experiences");
        }

        //----< shows details for each experience >----------------------
        public ActionResult ExperienceDetails(int? id)
        {
            if (id == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            Experience experience = context_.Experiences.Find(id);

            if (experience == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            //var lects = context_.Lectures.Where(l => l.Course == course);
            //course.Lectures = lects.OrderBy(l => l.Title).Select(l => l).ToList<Lecture>();
            // //course.Lectures = lects.ToList<Lecture>();
            /*
            if (course.Lectures == null)
            {
                course.Lectures = new List<Lecture>();
                Lecture lct = new Lecture();
                lct.Title = "none";
                lct.Content = "none";
                course.Lectures.Add(lct);
            }*/
            return View(experience);
        }


        //---------------------------------------------------------------------------------
        // EDUCATION Model Logic
        //---------------------------------------------------------------------------------

        // displays form for creating a education 
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult CreateEducation(int id)
        {
            var model = new Education();
            return View(model);
        }

        // posts back new education details
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult CreateEducation(int id, Education edu)
        {
            context_.Educations.Add(edu);
            context_.SaveChanges();
            return RedirectToAction("Educations");
        }

        //----< deletes a education by id >-----------------------------
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteEducation(int? id)
        {
            if (id == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            try
            {
                var edu = context_.Educations.Find(id);
                if (edu != null)
                {
                    var projects = context_.Projects.Where(e => EF.Property<int>(e, "EducationId") == id);
                    foreach (var project in projects)
                    {
                        context_.Remove(project);
                        edu.Projects.Remove(project);
                    }
                    context_.Remove(edu);
                    context_.SaveChanges();
                }
            }
            catch (Exception)
            {
                // nothing for now
            }
            return RedirectToAction("Educations");
        }

        // gets form to edit a specific education via id 
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult EditEducation(int? id)
        {
            if (id == null)
            {
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest);
            }
            Education edu = context_.Educations.Find(id);
            if (edu == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            return View(edu);
        }

        // posts back edited results for specific education 
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult EditEducation(int? id, Education edu)
        {
            if (id == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            var education = context_.Educations.Find(id);
            if (education != null)
            {
                education.EducationId = edu.EducationId;
                education.InstituteName = edu.InstituteName;
                education.Location = edu.Location;
                education.Degree = edu.Degree;
                education.StartDate = edu.StartDate;
                education.EndDate = edu.EndDate;
                try
                {
                    context_.SaveChanges();
                }
                catch (Exception)
                {
                    // do nothing for now
                }
            }
            return RedirectToAction("Educations");
        }


        //---------------------------------------------------------------------------------
        // PROJECTS Model Logic
        //---------------------------------------------------------------------------------

        // displays form for creating a project 
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult CreateProject(int id)
        {
            var model = new Project();
            return View(model);
        }

        // posts back new project details
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult CreateProject(int id, Project pro)
        {
            context_.Projects.Add(pro);
            context_.SaveChanges();
            return RedirectToAction("Projects");
        }

        //----< add new project to education >--------------------------

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult AddProject(int id)
        {
            HttpContext.Session.SetInt32(sessionId_, id);

            Education education = context_.Educations.Find(id);
            if (education == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            Project pro = new Project();
            return View(pro);
        }

        //----< Add new project to education >--------------------------

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult AddProject(int? id, Project pro)
        {
            if (id == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            // retreive the target course from static field

            int? educationId_ = HttpContext.Session.GetInt32(sessionId_);

            // this works too
            // int courseId_ = (int)TempData[sessionId_];

            var education = context_.Educations.Find(educationId_);

            if (education != null)
            {
                if (education.Projects == null)  // doesn't have any lectures yet
                {
                    List<Project> projects = new List<Project>();
                    education.Projects = projects;
                }
                education.Projects.Add(pro);

                try
                {
                    context_.SaveChanges();
                }
                catch (Exception)
                {
                    // do nothing for now
                }
            }
            return RedirectToAction("Educations");
        }

        //----< deletes a education by id >-----------------------------
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteProject(int? id)
        {
            if (id == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            try
            {
                var ins = context_.Projects.Find(id);
                if (ins != null)
                {
                    context_.Remove(ins);
                    context_.SaveChanges();
                }
            }
            catch (Exception)
            {
                // nothing for now
            }
            return RedirectToAction("Projects");
        }

        // gets form to edit a specific project via id 
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult EditProject(int? id)
        {
            if (id == null)
            {
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest);
            }
            Project pro = context_.Projects.Find(id);
            if (pro == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            return View(pro);
        }

        // posts back edited results for specific project 
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult EditProject(int? id, Project pro)
        {
            if (id == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            var project = context_.Projects.Find(id);
            if (project != null)
            {
                project.ProjectId = pro.ProjectId;
                project.ProjectName = pro.ProjectName;
                project.Year = pro.Year;
                project.Technology = pro.Technology;
                project.Description = pro.Description;
                
                try
                {
                    context_.SaveChanges();
                }
                catch (Exception)
                {
                    // do nothing for now
                }
            }
            return RedirectToAction("Projects");
        }

        //----< shows details for each project >----------------------

        public ActionResult ProjectDetails(int? id)
        {
            if (id == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            Project project = context_.Projects.Find(id);

            if (project == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            //var lects = context_.Lectures.Where(l => l.Course == course);
            //course.Lectures = lects.OrderBy(l => l.Title).Select(l => l).ToList<Lecture>();
            // //course.Lectures = lects.ToList<Lecture>();
            /*
            if (course.Lectures == null)
            {
                course.Lectures = new List<Lecture>();
                Lecture lct = new Lecture();
                lct.Title = "none";
                lct.Content = "none";
                course.Lectures.Add(lct);
            }*/
            return View(project);
        }


        //---------------------------------------------------------------------------------
        // COMPANIES Model Logic
        //---------------------------------------------------------------------------------

        // displays form for creating a company 
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult CreateCompany(int id)
        {
            var model = new Company();
            return View(model);
        }

        // posts back new company details
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult CreateCompany(int id, Company com)
        {
            context_.Companies.Add(com);
            context_.SaveChanges();
            return RedirectToAction("Companies");
        }

        //----< deletes a company by id >-----------------------------
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteCompany(int? id)
        {
            if (id == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            try
            {
                var com = context_.Companies.Find(id);
                if (com != null)
                {
                    var experiences = context_.Experiences.Where(e => EF.Property<int>(e, "CompanyId") == id);
                    foreach (var experience in experiences)
                    {
                        context_.Remove(experience);
                        com.Experiences.Remove(experience);
                    }
                    context_.Remove(com);
                    context_.SaveChanges();
                }
            }
            catch (Exception)
            {
                // nothing for now
            }
            return RedirectToAction("Companies");
        }

        // gets form to edit a specific company via id 
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult EditCompany(int? id)
        {
            if (id == null)
            {
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status400BadRequest);
            }
            Company com = context_.Companies.Find(id);
            if (com == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            return View(com);
        }

        // posts back edited results for specific company 
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult EditCompany(int? id, Company com)
        {
            if (id == null)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            var company = context_.Companies.Find(id);
            if (company != null)
            {
                company.CompanyId = com.CompanyId;
                company.CompanyName = com.CompanyName;
                company.Headquarters = com.Headquarters;

                try
                {
                    context_.SaveChanges();
                }
                catch (Exception)
                {
                    // do nothing for now
                }
            }
            return RedirectToAction("Companies");
        }


        //---------------------------------------------------------------------------------
        // ERROR
        //---------------------------------------------------------------------------------
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
