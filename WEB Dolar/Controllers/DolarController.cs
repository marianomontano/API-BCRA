using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using WEB_Dolar.Models;
using WEB_Dolar.Services;
using System.Linq;
using System;

namespace WEB_Dolar.Controllers
{
    public class DolarController : Controller
    { 
        // GET: Dolar
        public async Task<ActionResult> Index(string ordenamiento, DateTime? inicio, DateTime? fin)
        {
            ApiHelper.InicializarCliente();
            var cotizaciones =
                from c in await BCRA_Service.ListarTodos()
                select c;

            ViewBag.OrdenPorFecha = string.IsNullOrEmpty(ordenamiento) ? "fecha_desc" : "";
            ViewBag.OrdenPorValor = string.IsNullOrEmpty(ordenamiento) ? "valor_desc" : "";
            
            //Ordenamiento
            if (ordenamiento == "fecha_desc")
                cotizaciones = cotizaciones.OrderByDescending(x => x.D);

            if (ordenamiento == "valor_desc")
                cotizaciones = cotizaciones.OrderByDescending(x => x.V);


            //Filtrado
            DateTime _inicio = cotizaciones.OrderBy(x => x.D).Take(1).First().D;
            DateTime _fin = cotizaciones.OrderByDescending(x => x.D).Take(1).First().D;

            if (string.IsNullOrEmpty(inicio.ToString()) == false)
            {
                _inicio = inicio.Value;
                cotizaciones = cotizaciones.Where(x => x.D >= _inicio).ToList();
            }

            if (string.IsNullOrWhiteSpace(fin.ToString()) == false)
            {
                _fin = fin.Value;
                cotizaciones = cotizaciones.Where(x => x.D <= _fin).ToList();
            }


            return View(cotizaciones);
        }

        // GET: Dolar/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dolar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dolar/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dolar/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dolar/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dolar/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dolar/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
