using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //Added By me to validate each feilds 

namespace MvcRegistrationApplication.Models
{
    public class UserAccount
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="First Name is Required")]
        public String fName { get; set; }

        [Required(ErrorMessage="Last Name is Required")]
        public String lName { get; set; }

        [StringLength(11)]
        [DataType(DataType.PhoneNumber)]
        public String phNumber { get; set; }

        [Required(ErrorMessage = "City is Required")]
        public String  city { get; set; }

        [StringLength(5)]
        [DataType(DataType.PostalCode)]
        public int zipCode { get; set; }
        
    [Required(ErrorMessage="Username required")]
        public String uName { get; set; }

[Required(ErrorMessage = "Password required")]
        [DataType(DataType.Password)]
        public String password { get; set; }

        [Required(ErrorMessage="re enter-password required")]
        [Compare("password",ErrorMessage="should macth with above entered password")]
        [DataType(DataType.Password)]
public String reEnterPassword { get; set; }



    }
}