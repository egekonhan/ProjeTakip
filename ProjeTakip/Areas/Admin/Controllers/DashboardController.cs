using Microsoft.AspNetCore.Mvc;
using ProjeTakip.Repository.Shared.Abstract;

namespace ProjeTakip.Controllers
{
    [Area("Admin")]
    public class DashboardController : ControllerBase
    {
        public DashboardController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
