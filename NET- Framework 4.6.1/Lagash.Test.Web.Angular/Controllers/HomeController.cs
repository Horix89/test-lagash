namespace Lagash.Test.Web.Angular.Controllers
{    
    using System.Web.Mvc;
    using ViewModels.Client;

    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

    }
}