using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new BloggingContext())
            {
                // Create and save a new Blog
               
                var url = "http://vishalkhatal.wordpress.com";

                var blog = new Blog { Url = url };
                db.Blogs.Add(blog);
                db.SaveChanges();

                // Display all Blogs from the database
                var query = from b in db.Blogs
                            orderby b.Url
                            select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Url);
                }
            }
                return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}