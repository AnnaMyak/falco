using System.Web.Mvc;
using Sharpness.Persistence;
using Sharpness.Persistence.Entities;

namespace IdentitySample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SharpnessContext _context = new SharpnessContext() ;
            
            var organ = new Organ() {Name="Liver"};
            if (_context.Organs.Find(organ.OrganId) == null)
            {
                _context.Organs.Add(organ);
                _context.SaveChanges();

            }
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
