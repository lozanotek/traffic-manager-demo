using System.Web.Mvc;

namespace DemoApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new HomeViewModel
            {
                RegionName = ConfigService.GetRegionName()
            };

            return View(viewModel);
        }
    }
}