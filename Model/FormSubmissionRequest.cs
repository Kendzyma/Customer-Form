using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace CustomerForm.Model
{
    public class FormSubmissionRequest
    {
        [Required]
        public string CustomerName { get; set; }

        [Required]
        [EmailAddress]

        public string CustomerEmail { get; set; }

        [Required]

        public string CustomerMessage { get; set; }


        public string _formName { get; set; }


        public string _formDomainName { get; set; }
    }
}
