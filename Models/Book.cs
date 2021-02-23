using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class Book
    {
        //Testing my github branch
        //This is my model
        [Key]
        public int BookId { get; set; } //This is my Private key
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthFirstName { get; set; } //I split up the first, middle, and last name
        public string AuthMiddleName { get; set; }
        [Required]
        public string AuthLastName { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        [RegularExpression(@"^([0-9]{3})-([0-9]{10})$")]
        public string ISBN { get; set; } //accepts the following format '###-##########'
        [Required]
        public bool Fiction { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
