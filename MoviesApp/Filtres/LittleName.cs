using System.ComponentModel.DataAnnotations;

namespace MoviesApp.Filtres
{
    public class LittleName : ValidationAttribute
    {
        public int Length { get; }
        public LittleName(int number)
        {
            Length = number;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var numberName = ((string) value).Length;
            if (numberName < Length)
            {
                return new ValidationResult("Имя человека слишком короткое");
            }
            return null;
        }
    }
}