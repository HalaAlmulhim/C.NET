using System;
using System.ComponentModel.DataAnnotations;
using ChefsNDishes.Models;


namespace ChefsNDishes.Validations
{
    internal class PastDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        // public override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime date = (DateTime)value;
            
            if(date < DateTime.Now)
            {
                return true;
                // return new ValidationResult("Date Entered Must be in the past");
            }
            else
            {
                return false;
                // return ValidationResult.Success;
            }
        }

    }
}