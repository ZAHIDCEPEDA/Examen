using Examen.Data;
using Examen.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Controllers
{
    public class CuentasController : Controller
    {
        private readonly ApplicationDbContext _applicationContext;
        public CuentasController(ApplicationDbContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public IActionResult Index()
        {
            List<Cuenta> cuentas = new List<Cuenta>();
            cuentas = _applicationContext.Cuentas.ToList();
            return View(cuentas);
        }
    }
}
