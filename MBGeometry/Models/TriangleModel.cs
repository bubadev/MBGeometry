using System.ComponentModel.DataAnnotations;

namespace MBGeometry.Models
{
    public class TriangleModel : BaseModel
    {
        [Required(ErrorMessage = "Sides are required")]
        [MaxLength(3, ErrorMessage = "Sides count must be 3")]
        [MinLength(3, ErrorMessage = "Sides count must be 3")]
        public double[] Sides { get; set; }
    }
}
