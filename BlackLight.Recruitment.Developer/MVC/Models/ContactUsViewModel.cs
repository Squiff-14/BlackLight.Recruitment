using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlackLight.Recruitment.MVC.Models
{
    public class ContactUsViewModel
    {
        [Required]
        public string Name { get; set; }

        public string Email { get; set; }
    }
}