using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HallOfFame.Models
{
    public class JobDescriptionValidation: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //return base.IsValid(value, validationContext);
            var job = (Positions)validationContext.ObjectInstance;
            if (job.Duties == null)
            {
                return ValidationResult.Success;
            }

            if (job.Duties.Length < 50)
            {
                return new ValidationResult("The duties field must be either empty or at least 50 characters long!");
            }

            return ValidationResult.Success;
        }
    }
}