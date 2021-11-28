using Microsoft.AspNetCore.Mvc;
using JsuPlus.Web.Models;
using System.Web;
using System.Linq;
using System.Data;
using JsuPlus.Infrastructure;
using MySql.Data.MySqlClient;


namespace JsuPlus.Web.Controllers
{
    public class ParticipantController : Controller
    {
       //Registration Action
       [HttpGet]
       public ActionResult Registration()
        {
            return View();
        }

        //Registration POST Action
       [HttpPost]
       [ValidateAntiForgeryToken]
       public ActionResult Registration(Participant participant)
        {
            bool Status = false;
            string message = "";
            //
            //Model Validation
            if (ModelState.IsValid)
            {
                #region Email already exist
                var isExist = IsEmailExist(participant.Email);
                if (isExist)
                {
                    ModelState.AddModelError("EmailExist", "Email already exist!");
                    return View(participant);
                }
                #endregion

                #region Password Hashing
                participant.Password = Crypto.Hash(participant.Password);
                participant.ConfirmPassword = Crypto.Hash(participant.ConfirmPassword);
                #endregion

                #region Save to Database
                using(heroku_30ebef2574eacbeContext dc = new heroku_30ebef2574eacbeContext())
                {
                    //dc.Tblparticipants.Add(Tblparticipants);
                    dc.SaveChanges();
                }
                #endregion
            }
            else
            {
                message = "Invalid Request";
            }
           

            //Save data to database

            //Send Email to User
            return View(participant);
        }

        //Login

        //Login POST

        //Logout

        [NonAction]
        public bool IsEmailExist(string Email)
        {
            using(heroku_30ebef2574eacbeContext dc = new heroku_30ebef2574eacbeContext())
            {
                var v = dc.Tblparticipants.Where(a => a.Email == Email).FirstOrDefault();
                return v != null;
            }
        }
    }

    

}
