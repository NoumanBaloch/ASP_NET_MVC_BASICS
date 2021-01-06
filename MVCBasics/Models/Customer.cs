using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBasics.Models
{
    public class Customer
    {
        public string Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Your string is too long!")]
        public string Name { get; set; }
        [Required]
        [Display(Name="Phone No")]
        public string PhoneNumber { get; set; }
    }
}