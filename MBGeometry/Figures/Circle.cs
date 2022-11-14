using MBGeometry.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
