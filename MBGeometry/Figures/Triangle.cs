using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MBGeometry.Models;

namespace MBGeometry.Figures
{
    public class Triangle
    {
        private TriangleModel _model { get; set; }

        public Triangle(TriangleModel model)
        {
            model.Validate();

            if (model.Sides == null)
                throw new ArgumentNullException();

            if (model.Sides.Any(x => x <= 0 || x > Double.MaxValue))
                throw new ArgumentException("Side lenght must be at least 0 and at most double max value");

            // Одна сторона треугольника не может быть больше либо равна сумме двух других сторон
            if (model.Sides.Max() >= model.Sides.Sum() - model.Sides.Max())
                throw new ArgumentException("Sides lenght is invalid");

            _model = model;
        }

        /// <returns>Triangle square</returns>
        public double GetSquare()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - _model.Sides[0]) * (p - _model.Sides[1]) * (p - _model.Sides[2]));
        }

        /// <returns>Triangle perimeter</returns>
        public double GetPerimeter() => _model.Sides.Sum();

        /// <returns>True, if triangle is right-angle, otherwise false</returns>
        public bool IsRight()
        {
            int hypotenuse = Array.IndexOf(_model.Sides, _model.Sides.Max());
            
            List<int> cathetuses = new List<int>();

            for (int i = 0; i < _model.Sides.Length; i++)
                if (i != hypotenuse)
                    cathetuses.Add(i);

            return Math.Pow(_model.Sides[hypotenuse], 2) == Math.Pow(_model.Sides[cathetuses[0]], 2) + Math.Pow(_model.Sides[cathetuses[1]], 2);
        }
    }
}
