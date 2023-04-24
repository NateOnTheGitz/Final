using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class Entertainer
    {
        [Required(ErrorMessage = "No key given")]
        [Key]
        public int EntertainerID { get; set; }
        //[Required(ErrorMessage = "Please enter a stage name")]
        public string EntStageName { get; set; }
        //[Required(ErrorMessage = "Please enter a SSN")]
        public string EntSSN { get; set; }
        //[Required(ErrorMessage = "Please enter an address")]
        public string EntStreetAddress { get; set; }
        //[Required(ErrorMessage = "Please enter a city")]
        public string EntCity { get; set; }
        //[Required(ErrorMessage = "Please enter a state")]
        public string EntState { get; set; }
        //[Required(ErrorMessage = "Please enter a zipcode")]
        public string EntZipCode { get; set; }
        public string EntPhoneNumber { get; set; }
        public string EntWebPage { get; set; }
        public string EntEmailAddress { get; set; }
        public string DateEntered { get; set; }

    }
}
