using BLL;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models.EF;
using ClassLibrary1;
using System;

namespace MvcMovie.Controllers
{
    public class UserController : Controller
    {
        private AngularMvcDbContext db = null;


        public UserController()
        {
            db = new AngularMvcDbContext();
        }



        // GET: /User/ 

        public JsonResult Index()
        {
            UserBll userBll = new UserBll();
            var users = userBll.GetUsers();
            return Json(users, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Create(APP_USER cc)
        {
            try
            {
                UserBll userBll = new UserBll();
                userBll.addUser(cc);
                var res = true;
                return Json(res, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                var res = false;
                return Json(res, JsonRequestBehavior.AllowGet);
            }

        }
        public JsonResult Update(APP_USER oModel)
        {
            try
            {
                UserBll userBll = new UserBll();
                userBll.Update(oModel, oModel.ID);
                var res = true;
                return Json(res, JsonRequestBehavior.AllowGet);

            }
            catch
            {
                var res = false;
                return Json(res, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult Delete(int oId)
        {
            try
            {
                UserBll userBll = new UserBll();
                userBll.Delete(oId);
                var res = true;
                return Json(res, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                var res = false;
                return Json(res, JsonRequestBehavior.AllowGet);
            }
            

        }
    }
}