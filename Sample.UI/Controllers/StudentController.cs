using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleTest.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sample.UI.Controllers
{
    public class StudentController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(new Student());
        }

        [HttpPost]
        public IActionResult Index(Student model)
        {

            return View(model);

        }
    }
}
