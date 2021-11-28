using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JsuPlus.Web.Models
{
    [MetadataType(typeof(ParticipantMetaData))]
    public partial class Participant
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public int AddressId { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

    }

    //Validation
    public class ParticipantMetaData
    {
        [Display(Name = "First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "First Name required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(AllowEmptyStrings =false, ErrorMessage = "Last Name required")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [Required(AllowEmptyStrings =false, ErrorMessage = "Email required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime DateOfBirth { get; set; }

        [Required(AllowEmptyStrings =false,ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage ="Minimum 6 characters required")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Confirm password and Password do not match!")]
        public string ConfirmPassword { get; set; }
    }
}
