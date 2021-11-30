using Microsoft.AspNetCore.Mvc;
using JsuPlus.Web.Models;
using System.Web;
using System.Linq;
using System.Data;
using JsuPlus.Infrastructure;
using MySql.Data.MySqlClient;
using System;
using JsuPlus.Core.Interfaces;
using System.Threading.Tasks;

namespace JsuPlus.Web.Controllers
{

    public class ParticipantController : Controller
    {
        private readonly IAsyncRepository _repository;

        public ParticipantController(IAsyncRepository repository)
        {
            this._repository = repository;
        }

       //Registration Action
       [HttpGet]
       public ActionResult Registration()
        {
            return View();
        }

        //Registration POST Action
       [HttpPost]
       [ValidateAntiForgeryToken]
       public async Task<IActionResult> Registration(ParticipantViewModel participant)
        {
            bool Status = false;
            string message = "";
            //
            //Model Validation
            if (ModelState.IsValid)
            {
                #region Email already exist
                //var isExist = IsEmailExist(participant.Email);
                var isExist = false;
                if (isExist)
                {
                    ModelState.AddModelError("EmailExist", "Email already exist!");
                    return View(participant);
                }
                #endregion

                #region Password Hashing
                participant.Password = Crypto.Hash(participant.Password);
                participant.ConfirmPassword = Crypto.Hash(participant.ConfirmPassword);
                
                if(participant.Password != participant.ConfirmPassword)
                {
                    return BadRequest("Passwords do not match");
                }
                #endregion

                
                JsuPlus.Core.Entities.Participant p = new Core.Entities.Participant();

                p.CreateParticipant(participant.FirstName, participant.LastName, participant.DateOfBirth, participant.Email, participant.Password);

                #region Save to Database
               await _repository.Add(p);
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
            using(JSUPlusDbContext dc = new JSUPlusDbContext())
            {
                var v = dc.Tblparticipants.Where(a => a.Email == Email).FirstOrDefault();
                return v != null;
            }
        }
    }

    

}
