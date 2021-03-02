using System;
using System.Linq;

namespace ValidationSample
{
    class Program
    {
        static void Main(string[] args)
        {
           var sampleModel = new SampleModel { MyProperty = 0, MyStringProperty = "123467986549876543216546543" };
            IInputModelValidator inputModelValidator = new InputModelValidator();

            var errors = inputModelValidator.ValidateModel(sampleModel);
            Console.WriteLine(string.Join(Environment.NewLine, errors.Select(x => x.ErrorMessage)));

            errors = inputModelValidator.ValidateProperty(sampleModel, nameof(sampleModel.MyStringProperty), sampleModel.MyStringProperty);
            Console.WriteLine(string.Join(Environment.NewLine, errors.Select(x => x.ErrorMessage)));
        }
    }
}
