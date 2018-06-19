using System;
using System.Web.Mvc;
using GameShareManager.Application.Filters.DataTables;
using GameShareManager.Application.Interfaces;
using GameShareManager.Application.ViewModels;

namespace GameShareManager.Controllers
{
    [Authorize]
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
            return Json(_companyAppService.GetFilter(appFilter), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Select2(string term, int page = 1)
        {
            return Json(_companyAppService.GetSelect2Filter(page, term), JsonRequestBehavior.AllowGet);
        }

        // GET: Company/Details/5
        public ActionResult Details(Guid id)
        {
            var company = _companyAppService.GetById(id);
            if (company == default(CompanyViewModel)) return HttpNotFound();
            return View(company);
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
        public ActionResult Edit(Guid id)
        {

            var company = _companyAppService.GetById(id);
            if (company == default(CompanyViewModel)) return HttpNotFound();
            return View(company);
        }

        // POST: Company/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id, Name")]CompanyViewModel company)
        {
            try
            {
                _companyAppService.Update(company);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(company);
            }
        }

        // GET: Company/Delete/5
        public ActionResult Delete(Guid id)
        {
            var company = _companyAppService.GetById(id);
            if (company == default(CompanyViewModel)) return HttpNotFound();
            return View(company);
        }

        // POST: Company/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed([Bind(Include = "Id")]Guid id)
        {
            var company = _companyAppService.GetById(id);
            if (company == default(CompanyViewModel)) return HttpNotFound();
            try
            {
                _companyAppService.Remove(company);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(company);
            }
        }
    }
}
