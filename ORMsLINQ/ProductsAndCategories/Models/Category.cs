using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsAndCategories.Models
{
    public class Category
    {
        
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [Display(Name ="Name")]
        public string CategoryName { get; set; }

        public List<Store> ProductsOfCategory { get; set;}


        // Time Stamps
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


    }
}