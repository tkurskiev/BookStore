using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace BookStore.API.Contracts.Attributes
{
    public class CheckDateTimeFormatAttribute : ValidationAttribute
    {
        public string DateTimeFormat { get; set; } = "yyyy-MM-dd";

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if(value is null)
                return null;
            
            if (DateTime.TryParseExact(value.ToString(),
                    DateTimeFormat,
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out _))
            {
                return ValidationResult.Success;
            }

            var memberNames = validationContext.MemberName is { } memberName
                ? new[] { memberName }
                : null;

            return new ValidationResult(FormatErrorMessage(validationContext.DisplayName), memberNames);
        }
    }
}
