using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsAndCategories.Models
{
    public class Product
    {
        
        [Key]
        public int ProductId { get; set; }

        [Required]
        [Display(Name ="Name")]
        public string ProductName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }


        public List<Store> CategoriesOfProduct { get; set;}


        // Time Stamps
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}