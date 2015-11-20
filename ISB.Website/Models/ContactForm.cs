using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ISB.Website.Models
{
    public class ContactFormVm 
    {
        [Required]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50, ErrorMessage = "{0} must be a maximum length of {1} characters")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter some details of how we can help you")]
        [DataType(DataType.Text)]
        [Display(Name = "Comments ")]
        public string MessageContent { get; set; }
    }
}