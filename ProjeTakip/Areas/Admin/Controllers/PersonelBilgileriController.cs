using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjeTakip.Models;
using ProjeTakip.Repository.Shared.Abstract;

namespace ProjeTakip.Controllers
{
    public class PersonelBilgileriController : ControllerBase
    {
        
        public PersonelBilgileriController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult GetAll()
        {
            return Json(new { data = unitOfWork.Personels.GetAll().ToList() });
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Add(Personel personel)
        {
            unitOfWork.Personels.Add(personel);
            unitOfWork.Save();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            try
            {
                var personel = unitOfWork.Personels.GetById(id);

                if (personel == null)
                {
                    return NotFound(); // Silinecek kişi bulunamadıysa 404 Not Found döndür
                }

                unitOfWork.Personels.Delete(personel);
                unitOfWork.Save();

                return Ok(); // Başarıyla silindiği durumu 200 OK ile döndür
            }
            catch (Exception ex)
            {
                // Hata durumunda istemciye uygun bir hata mesajı döndürebilirsiniz
                return BadRequest($"Silme işlemi sırasında bir hata oluştu: {ex.Message}");
            }
        }

        [HttpPost]
        public IActionResult DeleteById(int personelId)
        {
            unitOfWork.Personels.DeleteById(personelId);
            unitOfWork.Save();
            return Ok("Başarıyla Silindi");
        }
        [HttpPost]
        public IActionResult Update(Personel personel)
        {
            unitOfWork.Personels.Update(personel);
            unitOfWork.Save();
            return Ok();
        }
        [HttpPost]
        public IActionResult List(int id)
        {
            return View();
        }

    }
}
