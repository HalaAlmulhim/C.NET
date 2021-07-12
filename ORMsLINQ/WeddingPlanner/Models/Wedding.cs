using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId { get; set; }


        [Required]
        [Display(Name ="Wedder One")]
        public string WedderOne { get; set; }


        [Required]
        [Display(Name ="Wedder Two")]
        public string WedderTwo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [FutureDate(ErrorMessage = "Date must be in the future")]
        public DateTime Date { get; set; }
        

        [Required]
        [Display(Name ="Wedding Address")]
        public string WeddingAddress { get; set; }

        public User Creator { get; set; }
        public int UserId { get; set; }

        public List<Reservation> Guests { get; set; }


        // TimeStamps
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;


    }
}