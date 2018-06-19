using System;
using System.Web.Mvc;
using GameShareManager.Application.Filters.DataTables;
using GameShareManager.Application.Interfaces;
using GameShareManager.Application.ViewModels;

namespace GameShareManager.Controllers
{
    [Authorize]
    public class GameController : Controller
    {
        private readonly IGameAppService _gameAppService;

        public GameController(IGameAppService gameAppService)
        {
            _gameAppService = gameAppService;
        }

        // GET: Game
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult DataTable(GameAppFilter appFilter)
        {
            return Json(_gameAppService.GetFilter(appFilter), JsonRequestBehavior.AllowGet);
        }

        // GET: Game/Details/5
        public ActionResult Details(Guid id)
        {
            var game = _gameAppService.GetById(id);
            if (game == default(GameViewModel)) return HttpNotFound();
            return View(game);
        }

        // GET: Game/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Game/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name, CompanyId")]GameViewModel game)
        {
            try
            {
                _gameAppService.Add(game);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(game);
            }
        }

        // GET: Game/Edit/5
        public ActionResult Edit(Guid id)
        {

            var game = _gameAppService.GetById(id);
            if (game == default(GameViewModel)) return HttpNotFound();
            return View(game);
        }

        // POST: Game/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id, Name, CompanyId")]GameViewModel game)
        {
            try
            {
                _gameAppService.Update(game);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(game);
            }
        }

        // GET: Game/Delete/5
        public ActionResult Delete(Guid id)
        {
            var game = _gameAppService.GetById(id);
            if (game == default(GameViewModel)) return HttpNotFound();
            return View(game);
        }

        // POST: Game/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed([Bind(Include = "Id")]Guid id)
        {
            var game = _gameAppService.GetById(id);
            if (game == default(GameViewModel)) return HttpNotFound();
            try
            {
                _gameAppService.Remove(game);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(game);
            }
        }
    }
}
