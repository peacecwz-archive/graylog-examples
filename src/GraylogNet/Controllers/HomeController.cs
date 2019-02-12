using System.Web.Mvc;
using NLog;

namespace GraylogNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public ActionResult Index()
        {
            _logger.Info("Index Page");
            return View();
        }

        public ActionResult About()
        {
            _logger.Info("About Page");
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            _logger.Info("Contact Page");
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}