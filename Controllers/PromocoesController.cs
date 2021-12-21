using AgenciaBoaViagem.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgenciaBoaViagem.Controllers
{
    public class PromocoesController : Controller
    {


        private Context _context;

        public PromocoesController(Context context)
        {
            _context = context;
        }

        public IActionResult Promocoes()
        {

            ViewBag.promocoes = _context.Promocoes.ToList();
           

            if (ViewBag.promocoes == null)
            {
                return NotFound();
            }


            return View();
        }

        [HttpPost]
        public IActionResult Create(Promocoes promocoes)
        {
            _context.Add(promocoes);
            _context.SaveChanges();
            return RedirectToAction("Promocoes");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var promocoes = _context.Promocoes.Where(c => c.IdPromocao == id).FirstOrDefault();

            if (promocoes == null)
            {
                return NotFound();
            }

            return PartialView(promocoes);
        }


        [HttpPost]
        public IActionResult Edit(Promocoes promocoes)
        {

            _context.Promocoes.Update(promocoes);
            _context.SaveChanges();


            return RedirectToAction("Promocoes");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var promocoes = _context.Promocoes.Where(c => c.IdPromocao == id).FirstOrDefault();
            
            return PartialView(promocoes); ;
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var promocoes = _context.Promocoes.Where(c => c.IdPromocao == id).FirstOrDefault();

            return PartialView(promocoes);
        }

        [HttpPost]
        public IActionResult Delete(Promocoes promocoes)
        {
            var promoceos1 = _context.Promocoes.Where(c => c.IdPromocao== promocoes.IdPromocao).FirstOrDefault();


            _context.Promocoes.Remove(promoceos1);
            _context.SaveChanges();


            return RedirectToAction("Promocoes");
        }
    }
}
