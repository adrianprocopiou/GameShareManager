using System;
using System.Web.Mvc;
using GameShareManager.Application.Filters;
using GameShareManager.Application.Filters.DataTables;
using GameShareManager.Application.Interfaces;
using GameShareManager.Application.ViewModels;

namespace GameShareManager.Controllers
{
    public class FriendController : Controller
    {
        private readonly IFriendAppService _friendAppService;

        public FriendController(IFriendAppService friendAppService)
        {
            _friendAppService = friendAppService;
        }

        // GET: Friend
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult DataTable(FriendAppFilter appFilter)
        {
            return Json(_friendAppService.GetFilter(appFilter), JsonRequestBehavior.AllowGet);
        }

        // GET: Friend/Details/5
        public ActionResult Details(Guid id)
        {
            var friend = _friendAppService.GetById(id);
            if (friend == default(FriendViewModel)) return HttpNotFound();
            return View(friend);
        }

        // GET: Friend/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Friend/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name, Nickname, Email, PhoneNumber")]FriendViewModel Friend)
        {
            try
            {
                _friendAppService.Add(Friend);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(Friend);
            }
        }

        // GET: Friend/Edit/5
        public ActionResult Edit(Guid id)
        {

            var friend = _friendAppService.GetById(id);
            if (friend == default(FriendViewModel)) return HttpNotFound();
            return View(friend);
        }

        // POST: Friend/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id, Name, Nickname, Email, PhoneNumber")]FriendViewModel friend)
        {
            try
            {
                _friendAppService.Update(friend);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(friend);
            }
        }

        // GET: Friend/Delete/5
        public ActionResult Delete(Guid id)
        {
            var friend = _friendAppService.GetById(id);
            if (friend == default(FriendViewModel)) return HttpNotFound();
            return View(friend);
        }

        // POST: Friend/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed([Bind(Include = "Id")]Guid id)
        {
            var friend = _friendAppService.GetById(id);
            if (friend == default(FriendViewModel)) return HttpNotFound();
            try
            {
                _friendAppService.Remove(friend);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(friend);
            }
        }
    }
}
