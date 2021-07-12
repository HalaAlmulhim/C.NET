using System;
using System.ComponentModel.DataAnnotations;

namespace models.Models
{
    public class User{
    
        [Required ]
        [MinLength(3)]
        public string Name{get; set;}

        [Required (ErrorMessage = "Flooty Flurbin Hippity Hoop!!")]
        [MinLength(3)]
        // [Display(Name ="E-mail:")]
        public string Email{get; set;}

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password{get; set;}
    }
}