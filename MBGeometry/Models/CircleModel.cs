using System.ComponentModel.DataAnnotations;

namespace MBGeometry.Models
{
    public class CircleModel : BaseModel
    {
        [Required(ErrorMessage = "Radius is required")]
        [Range(0, Double.MaxValue, ErrorMessage = "Radius must be at least {1} and at most double max value")]
        public double Radius { get; set; }
    }
}
