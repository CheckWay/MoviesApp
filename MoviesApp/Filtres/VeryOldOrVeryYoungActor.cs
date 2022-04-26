using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesApp.Filtres
{
    public class VeryOldOrVeryYoungActor : ValidationAttribute
    {
        public int OldYear { get; }
        public int YoungYear { get; }

        public VeryOldOrVeryYoungActor(int oldyear, int youngyear)
        {
            OldYear = oldyear;
            YoungYear = youngyear;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var yearBirth = ((DateTime) value).Year;
            if (yearBirth > YoungYear)
            {
                return new ValidationResult("Человек слишком молод что бы стать актером");
            }
            else if (yearBirth < OldYear)
            {
                return new ValidationResult("Человек слишком стар что бы быть актером");
            }

            return ValidationResult.Success;
        }
    }
}