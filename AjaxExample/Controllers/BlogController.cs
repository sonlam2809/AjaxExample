using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AjaxExample.Data;
using AjaxExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace AjaxExample.Controllers
{
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public BlogController(ApplicationDbContext context)
        {
            this.dbContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SaveData([FromBody]Blog blog)
        {
            dbContext.Add(blog);
            dbContext.SaveChanges();
            return View(blog);
        }
    }
}