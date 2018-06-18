using System.Linq;
using System.Web.Mvc;
using GameShareManager.Application.DataTables;
using GameShareManager.Application.Filters;
using GameShareManager.Application.Interfaces;
using GameShareManager.Application.ViewModels;
using GameShareManager.Extension;
using Microsoft.Ajax.Utilities;

namespace GameShareManager.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyAppService _companyAppService;

        public CompanyController(ICompanyAppService companyAppService)
        {
            _companyAppService = companyAppService;
        }

        // GET: Company
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult DataTable(CompanyAppFilter appFilter)
        {
            return Json( _companyAppService.GetFilter(appFilter), JsonRequestBehavior.AllowGet);
        }

        // GET: Company/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Company/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Company/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name")]CompanyViewModel company)
        {
            try
            {
                _companyAppService.Add(company);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(company);
            }
        }

        // GET: Company/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Company/Edit/5
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

        // GET: Company/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Company/Delete/5
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
