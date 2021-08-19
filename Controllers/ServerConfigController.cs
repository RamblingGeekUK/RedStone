using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RedStone.Controllers
{
    public class ServerConfig : Controller
    {
        // GET: ServerConfig
        public ActionResult Index()
        {
            return View();
        }

        // GET: ServerConfig/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ServerConfig/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServerConfig/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {

                //Filename 
                string filename = "server.properties";
                
                // Set a variable to the Documents path.
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // Write the file using the collection
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, filename),false))
                {  
                   foreach (var setting in collection)
                    {
                        if(setting.Key != "__RequestVerificationToken")  // It's grabbing this of the form and writing it out...I assume it being passed back as part of the collection.
                        { 
                            outputFile.WriteLine(setting.Key + "=" + setting.Value); 
                        }
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ServerConfig/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ServerConfig/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ServerConfig/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ServerConfig/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
