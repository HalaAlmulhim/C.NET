using System;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class FutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime date = (DateTime)value;
            if(date > DateTime.Now)
            {
                return true;
            }
            return false;
        }
    }
}