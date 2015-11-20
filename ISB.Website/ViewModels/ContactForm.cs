using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ISB.Website.ViewModels.DocTypes.Base;
using Umbraco.Core.Models;

namespace ISB.Website.ViewModels
{
    public class ContactForm
    {
        [Required(ErrorMessage = "Please enter your name")]
        [DataType(DataType.Text)]
        [StringLength(80, ErrorMessage = "{0} must be a maximum length of {1} characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50, ErrorMessage = "{0} must be a maximum length of {1} characters")]
        [Display(Name = "Email Address ")]
        [RegularExpression(@"[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}", ErrorMessage = "Your email address doesn't look correct, please try again")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter some details of how we can help you")]
        [DataType(DataType.Text)]
        [Display(Name = "Comments ")]
        public string MessageContent { get; set; }
    }
}