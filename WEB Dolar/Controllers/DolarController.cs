using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using WEB_Dolar.Models;
using WEB_Dolar.Services;

namespace WEB_Dolar.Controllers
{
    public class DolarController : Controller
    {
        // GET: Dolar
        public async Task<ActionResult> Index()
        {
            ApiHelper.InicializarCliente();
            List<DolarModel> Cotizaciones = new List<DolarModel>();
            Cotizaciones = await BCRA_Service.ListarTodos();
            return View(Cotizaciones);
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
