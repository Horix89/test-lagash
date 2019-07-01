using System.Web.Mvc;

namespace Lagash.Test.Web.Areas.Clients.Controllers
{
    public class HomeController : Controller
    {
        // GET: Clients/Home
        public ActionResult Index()
        {   
            return View("Index");
        }
    }
}