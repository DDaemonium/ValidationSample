using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ValidationSample
{
    /// <summary>
    /// Input models validator.
    /// </summary>
    public class InputModelValidator : IInputModelValidator
    {
        /// <summary>Validates the model.</summary>
        /// <typeparam name="T">Model type.</typeparam>
        /// <param name="model">The model.</param>
        /// <returns>
        /// Validation results.
        /// </returns>
        public List<ValidationResult> ValidateModel<T>(T model)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(model);
            if (!Validator.TryValidateObject(model, context, results, true))
            {
                if (results.Any())
                {
                    return results;
                }
            }
            return new List<ValidationResult>();
        }

        /// <summary>Validates the property.</summary>
        /// <typeparam name="T">Model type.</typeparam>
        /// <typeparam name="G">Property type.</typeparam>
        /// <param name="model">The model.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="propertyValue">The property value.</param>
        /// <returns>
        /// Validation results.
        /// </returns>
        public List<ValidationResult> ValidateProperty<T, G>(T model, string propertyName, G propertyValue)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(model)
            {
                MemberName = propertyName
            };
            if (!Validator.TryValidateProperty(propertyValue, context, results))
            {
                if (results.Any())
                {
                    return results;
                }
            }
            return new List<ValidationResult>();
        }
    }
}
