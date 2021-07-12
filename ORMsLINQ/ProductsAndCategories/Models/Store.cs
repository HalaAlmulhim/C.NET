using System.ComponentModel.DataAnnotations;

namespace ProductsAndCategories.Models
{
    public class Store
    {
        
        [Key]
        public int StoreId { get; set; }

        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public Product ProductInCategory { get; set; }

        public Category CategoryOfProduct { get; set; }

    }
}