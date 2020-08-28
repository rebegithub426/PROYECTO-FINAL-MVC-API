using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SolutionMvc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolutionMvc2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
    



            if (User.Identity.IsAuthenticated)
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    var idUsuarioActual = User.Identity.GetUserId();


                    if (User.Identity.GetUserId().ToString() == null)
                    {
                        var roleManager = new RoleManager<IdentityRole>
                    (new RoleStore<IdentityRole>(db));

                    //crear rol
                    var resultado = roleManager.Create(new IdentityRole("Cliente"));

                    var userManager = new UserManager<ApplicationUser>
                        (new UserStore<ApplicationUser>(db));

                    //agregar usuario a rol
                    resultado = userManager.AddToRole(idUsuarioActual, "Cliente");


                    //usuario esta en rol?
                    var usuarioEstaEnRol = userManager.IsInRole(idUsuarioActual, "Cliente");

                    //roles del usuario
                    var roles = userManager.GetRoles(idUsuarioActual);

                    RedirectToAction("Home", "Cliente");

                }
                    else if (User.Identity.GetUserId().ToString() == "Administrador")
                {
                    RedirectToAction("Home", "Admin");
                }
                else if (User.Identity.GetUserId().ToString() == "Cliente")
                {
                    RedirectToAction("Home", "Cliente");

                }



            }
            }
            return View();
        }


        [Authorize (Roles = "Administrador")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        


        [Authorize (Users = "rebecam26@gmail.com")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}