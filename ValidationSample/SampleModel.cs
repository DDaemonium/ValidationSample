using System.ComponentModel.DataAnnotations;

namespace ValidationSample
{
    internal class SampleModel
    {
        [NotZero]
        public int MyProperty { get; set; }
        [MaxLength(10)]
        public string MyStringProperty { get; set; }
    }
}
