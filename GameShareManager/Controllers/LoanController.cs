using System;
using System.Web.Mvc;
using GameShareManager.Application.Filters.DataTables;
using GameShareManager.Application.Interfaces;
using GameShareManager.Application.ViewModels;

namespace GameShareManager.Controllers
{
    [Authorize]
    public class LoanController : Controller
    {
        private readonly IGameAppService _service;

        public LoanController(IGameAppService service)
        {
            _service = service;
        }

        // GET: Loan
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Loan()
        {
            return View();
        }

        public ActionResult GiveBack(Guid id)
        {
            var game = _service.GetById(id);
            return View(game);
        }
        [HttpPost, ActionName("GiveBack")]
        [ValidateAntiForgeryToken]
        public ActionResult GiveBackConfirmed([Bind(Include = "Id")]Guid id)
        {
            var game = _service.GetById(id);
            if (game == default(GameViewModel)) return HttpNotFound();
            try
            {
                _service.GiveBack(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(game);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Loan([Bind(Include = "GameId, FriendId")]LoanViewModel loan)
        {

            try
            {
                _service.Loan(loan);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(loan);
            }
        }


        public JsonResult DataTableLoan(GameAppFilter appFilter)
        {
            return Json(_service.GetDataTableResultLoansByFilter(appFilter), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Select2Available(string term, int page = 0)
        {
            return Json(_service.GetSelect2OnlyAvailableFilter(page, term), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Select2(string term, int page = 0)
        {
            return Json(_service.GetSelect2Filter(page, term), JsonRequestBehavior.AllowGet);
        }
    }
}