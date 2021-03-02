using System.ComponentModel.DataAnnotations;

namespace ValidationSample
{
    internal class NotZeroAttribute : ValidationAttribute
    {
        public NotZeroAttribute()
        {
            ErrorMessage = "Property is null";
        }
        public override bool IsValid(object value)
        {
            return value is int intValue && intValue != 0;
        }
    }
}
