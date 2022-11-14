using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBGeometry.Models
{
    public class CircleModel : BaseModel
    {
        [Required(ErrorMessage = "Radius is required")]
        [Range(0, Double.MaxValue, ErrorMessage = "Radius must be at least {1} and at most double max value")]
        public double Radius { get; set; }
    }
}
