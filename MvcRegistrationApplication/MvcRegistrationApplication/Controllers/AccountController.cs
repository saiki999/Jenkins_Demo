using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcRegistrationApplication.Models;

namespace MvcRegistrationApplication.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {

            using (OurDbContext db=new OurDbContext())
            {
                return View(db.userAccounts.ToList());    
            }
            
        }

        public ActionResult Register() //get Method from db
        {
            return View();
        }

        [HttpPost]   //Post Method to db
        public ActionResult Register(UserAccount account)  //insert useraccount type account to db 
        {
            if (ModelState.IsValid)
            {

                using (OurDbContext db = new OurDbContext())
                {

                    db.userAccounts.Add(account);
                    db.SaveChanges();
                                   
                }
                ModelState.Clear();//once the account is added clear all the controls
                ViewBag.message = account.fName + " " + account.lName + " Succesfully registered";
            
            }
        return View();
        }

        public ActionResult Login() //get method
        {


            return View();
        }

        [HttpPost]
        public ActionResult login(UserAccount user)
        {
            using (OurDbContext db = new OurDbContext())
            {
                var usr = db.userAccounts.Single(u => u.uName == user.uName && u.password == user.password);

                if (usr != null)
                {

                    Session["userid"] = user.Id.ToString();
                    Session["username"] = user.uName.ToString();
                    return RedirectToAction("LoggedIn");


                }

                else
                {
                    ModelState.AddModelError("","Username or Password is wrong");
                }
            }
           return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["userid"] != null)
            {

                return View();
            }

            else {

                return RedirectToAction("Login");
            }

           
        }

    }
}
