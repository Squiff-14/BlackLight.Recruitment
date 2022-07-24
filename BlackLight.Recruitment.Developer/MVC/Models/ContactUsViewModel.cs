using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlackLight.Recruitment.MVC.Models
{
    public class ContactUsViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }

        public string Message { get; set; }
    }

}