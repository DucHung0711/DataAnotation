using DataAnotation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataAnotation.Controllers
{
    public class UserController : Controller
    {
        private static List<UserModel> listUserModel = new List<UserModel>();
        // GET: User
        public ActionResult Index(UserModel model)
        {
            //if (!ModelState.IsValid) 
            //{ 
            //    return View();
            //}
            return View(listUserModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Details(int id) 
        {
            UserModel model = listUserModel.Find(emp => emp.Id == id);
            return View(model); 
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                UserModel model = new UserModel();
                model.Id = Int32.Parse(collection["Id"]);
                model.Name = collection["Name"];
                model.Email = collection["Email"];
                model.Password = collection["Password"];
                model.ConfirmPassword = collection["ConfirmPassword"];
                listUserModel.Add(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}