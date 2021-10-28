using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBook
{
    public class Contact
    {
        [Required, StringLength(30), RegularExpression("/^[A-Za-z]+$/")]
        public string FirstName { get; set; }
        [Required, StringLength(30), RegularExpression("/^[A-Za-z]+$/")]
        public string LastName { get; set; }
        [Required, RangeAttribute(0, 10)]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
