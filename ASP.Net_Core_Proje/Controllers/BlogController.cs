﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Core_Proje.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm=new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {

            var values = bm.GetBlogListWithCategory();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values=bm.GetBlogByID(id);

            return View(values);
        }

        
    }
}
