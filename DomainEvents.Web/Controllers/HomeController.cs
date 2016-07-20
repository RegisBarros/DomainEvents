using DomainEvents.Application;
using System.Web.Mvc;

namespace DomainEvents.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly SalesApplicationService _saleApplicationService;

        public HomeController()
        {
            _saleApplicationService = new SalesApplicationService();
        }

        public ActionResult Index()
        {
            _saleApplicationService.CreateNewOrder();

            return View();
        }
    }
}