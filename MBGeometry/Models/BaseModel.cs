using System.ComponentModel.DataAnnotations;

namespace MBGeometry.Models
{
    public class BaseModel
    {
        public void Validate()
        {
            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(this);
            if (!Validator.TryValidateObject(this, context, results, true))
            {
                foreach (var error in results)
                {
                    throw new ArgumentException(error.ErrorMessage);
                }
            }
        }
    }
}
