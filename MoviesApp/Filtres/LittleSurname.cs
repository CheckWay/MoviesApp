using System.ComponentModel.DataAnnotations;

namespace MoviesApp.Filtres
{
    public class LittleSurname : ValidationAttribute
    {
        public int Length { get; }
        public LittleSurname(int number)
        {
            Length = number;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var numberName = ((string) value).Length;
            if (numberName < Length)
            {
                return new ValidationResult("Фамилия человека слишком короткая");
            }
            return null;
        }
    }
}