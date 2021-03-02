using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ValidationSample
{
    public interface IInputModelValidator
    {
        List<ValidationResult> ValidateModel<T>(T model);
        List<ValidationResult> ValidateProperty<T, G>(T model, string propertyName, G propertyValue);
    }
}