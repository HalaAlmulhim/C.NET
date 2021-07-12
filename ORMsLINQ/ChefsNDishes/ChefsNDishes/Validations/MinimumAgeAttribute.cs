using System;
using System.ComponentModel.DataAnnotations;
using ChefsNDishes.Models;

namespace ChefsNDishes.Validations
{
    public class MinimumAgeAttribute : ValidationAttribute
    {
        int _minimumAge;

        public MinimumAgeAttribute (int MinimumAge)
        {
            _minimumAge = MinimumAge;
        }

        public override bool IsValid(object value)
        {
            DateTime date ;
            
            if(DateTime.TryParse(value.ToString(), out date))
            {
                return date.AddYears(_minimumAge) < DateTime.Now;
            }
            else
            {
                return false;
            }
        }
    }
}