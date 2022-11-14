using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using MBGeometry.Figures;

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
