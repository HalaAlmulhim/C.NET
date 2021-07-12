using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccounts.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [Display(Name="First Name: ")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name="Last Name: ")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [NotMapped]
        [Compare("Password", ErrorMessage ="Passwords must match")]
        [DataType(DataType.Password)]
        [Display(Name="Confirm Password: ")]
        public string ConfirmPassword { get; set; }

        public List<Transaction> UserTransactions { get; set; }


        // TimeStamps
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

    }
}