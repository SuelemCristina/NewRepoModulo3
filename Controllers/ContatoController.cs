using AgenciaBoaViagem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AgenciaBoaViagem.Controllers
{
    public class ContatoController : Controller
    {

        private Context _context;

        public ContatoController(Context context)
        {
            _context = context;
        }

       
        public IActionResult Contato()
        {

            ViewBag.contato = _context.Contato.ToList();


            if (ViewBag.contato == null)
            {
                return NotFound();
            }


            return View();
        }

        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return RedirectToAction("Contato");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            var contato = _context.Contato.Where(c => c.IdContato == id).FirstOrDefault();


            if (contato == null)
            {
                return NotFound();
            }

            return View(contato);
        }


        [HttpPost]
        public IActionResult Edit(Contato contato)
        {

            _context.Contato.Update(contato);
            _context.SaveChanges();


            return RedirectToAction("Contato");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var contato = _context.Contato.Where(c => c.IdContato == id).FirstOrDefault();
            return View(contato); ;
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contato = _context.Contato.Where(c => c.IdContato == id).FirstOrDefault();

            return View(contato); ;
        }

        [HttpPost]
        public IActionResult Delete(Contato contato)
        {
            var contato1 = _context.Contato.Where(c => c.IdContato == contato.IdContato).FirstOrDefault();
            _context.Contato.Remove(contato1);
            _context.SaveChanges();


            return RedirectToAction("Contato");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
