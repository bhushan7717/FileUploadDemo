using FileUploadDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileUploadDemo.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        [HttpGet]
        public ActionResult UploadFiles()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadFiles(FileViewModel fileViewModel)
        {
            return View();
        }
    }
}