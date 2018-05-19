using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inline_Unobtrusive.Models {
    public class Customer {
        [Required(ErrorMessage = "This field is required")]
        public int ID { get; set; }

        [StringLength(10, ErrorMessage = "Name cannot contain more than 10 characters")]
        public string Name { get; set; }

        public string City { get; set; }
    }
}