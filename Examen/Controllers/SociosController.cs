using Examen.Data;
using Examen.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Controllers
{
    public class SociosController : Controller
    {
        private readonly ApplicationDbContext _applicationContext;
        public SociosController(ApplicationDbContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public IActionResult Index()
        {
            List<Socio> socios = new List<Socio>();
            socios = _applicationContext.Socios.ToList();
            return View(socios);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Socio socios)
        {
            try
            {
                _applicationContext.Add(socios);
                _applicationContext.SaveChanges();
            }
            catch (Exception)
            {
                return View(socios);
            }
            return RedirectToAction("Index");
        }
    }
}
