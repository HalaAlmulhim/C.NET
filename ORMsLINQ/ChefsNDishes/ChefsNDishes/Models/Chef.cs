using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ChefsNDishes.Validations;

namespace ChefsNDishes.Models
{
    public class Chef
    {
        public int ChefId{get;set;}
        
        [Required]
        public string FirstName{get;set;}

        [Required]
        public string LastName{get;set;}

        [Required]
        [DataType(DataType.Date)]
        // [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DisplayFormat(ApplyFormatInEditMode=true, DataFormatString = "{0:d}")]
        // [Range(typeof(DateTime),"02/07/1940","02/07/2003")]
        [PastDate(ErrorMessage="The date of the birth should be in the past")]
        [MinimumAge(18,ErrorMessage="The chef must be greater than 18 years")]
        // [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false )]
        [Display(Name ="Date of Birth")]
        public DateTime DoB{get;set;}

        public int Age{get;set;}

        public List<Dish> Dishes {get;set;}
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}