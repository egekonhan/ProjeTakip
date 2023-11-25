using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjeTakip.Repository.Shared.Abstract;

namespace ProjeTakip.Controllers
{
    [Area("Admin")]

    public class ControllerBase : Controller
    {
        public readonly IUnitOfWork unitOfWork;

        public ControllerBase(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
