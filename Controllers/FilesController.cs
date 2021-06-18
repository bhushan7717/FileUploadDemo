using FileUploadDemo.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
        public ActionResult UploadFiles(HttpPostedFileBase file)
        {
                if(file != null)
                { 
                string fileName = Path.GetFileName(file.FileName);
                string path = Path.Combine(Server.MapPath("~/UploadedFiles"), fileName);
                file.SaveAs(path);
                ViewBag.Message = "File uploaded successfully";
                return View();
                }
            return View();
        }
		protected override void OnException(ExceptionContext filterContext)
		{
			
		}
	}
}