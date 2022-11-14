using MBGeometry.Models;

namespace MBGeometry.Figures
{
    public class Circle : IFigure
    {
        private CircleModel _model { get; set; }

        public Circle(CircleModel model)
        {
            model.Validate();
            _model = model;
        }

        /// <returns>Circle square</returns>
        public double GetSquare()
        {
            return Math.PI * Math.Pow(_model.Radius, 2);
        }
    }
}
