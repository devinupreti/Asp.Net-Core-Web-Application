using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.IO;
using Microsoft.AspNetCore.Identity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment_;
        private string webRootPath = null;
        private string filePath = null;

        public FilesController(IHostingEnvironment hostingEnvironment)
        {
            hostingEnvironment_ = hostingEnvironment;
            webRootPath = hostingEnvironment_.WebRootPath;
            filePath = Path.Combine(webRootPath, "FileStorage");
        }

        // GET: api/<controller>
        [HttpGet]
        public string Get()
        {
            List<string> files = null;
            string result = "";
            try
            {
                files = Directory.GetFiles(filePath).ToList<string>();
                for (int i = 0; i < files.Count; ++i)
                { 
                    files[i] = Path.GetFileName(files[i]);
                    result = result + files[i] + ",";
                }

            }
            catch
            {
                files = new List<string>();
                files.Add("404 - Not Found");
            }
            //return files;
            return result;
        }

        //----< download single file in wwwroot\FileStorage >------
        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Download(int id)
        {
            List<string> files = null;
            string file = "";
            try
            {
                files = Directory.GetFiles(filePath).ToList<string>();
                if (0 <= id && id < files.Count)
                    file = Path.GetFileName(files[id]);
                else
                    return NotFound();
            }
            catch
            {
                return NotFound();
            }
            var memory = new MemoryStream();
            file = files[id];
            using (var stream = new FileStream(file, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, GetContentType(file), Path.GetFileName(file));
        }

        private string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }

        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
              {
                {".cs", "application/C#" },
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformatsofficedocument.spreadsheetml.sheet"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
              };
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Upload()
        {
            var request = HttpContext.Request;
            if (request.Form == null || request.Form.Files == null || request.Form.Files.Count == 0)
            {
                return Json("File not found");
            }
            foreach (var file in request.Form.Files)
            {
                if (file.Length > 0)
                {
                    var path = Path.Combine(filePath, file.FileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                }
                else
                {
                    return BadRequest();
                }
            }
            return Json("File uploaded");
            //return Ok();
        }

        // delete request: api/<controller>/5 for deleting a file with a given id
        [HttpGet("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            // ToDo
            List<string> files = null;
            string fileFullPath = "";
            try
            {
                files = Directory.GetFiles(filePath).ToList<string>();
                if (0 <= id && id < files.Count)
                {
                    fileFullPath = Path.GetFullPath(files[id]);
                }
                else
                {
                    return Json("File not found");
                }
            }
            catch
            {
                return Json("File not found");
            }
            // delete the file
            System.IO.File.Delete(fileFullPath);
            return Json("File deleted");
        }
        
    }
}
