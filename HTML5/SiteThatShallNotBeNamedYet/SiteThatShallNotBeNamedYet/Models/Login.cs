using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SiteThatShallNotBeNamedYet.Models
{
    public class Login
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Please Enter a Username")]
        public string UserName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please Enter you Email")]
        public string UserEmail { get; set; }

        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You must have a Password")]
        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Please provided an appropriate Password")]
        public string Password { get; set; }

        [Display(Name ="Confrim Password")]
        public string ConfrimPassword { get; set; }

    }
}
