using DevelopmentChallenge.Data.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Shapes
{
    public class Rectangle : IGeometricShapes
    {
        private decimal _length;
        private decimal _height;
        private readonly ResourceManager _resourceManager;

        public Rectangle(decimal length, decimal height)
        {
            this._length = length;
            this._height = height;
            _resourceManager = new ResourceManager(typeof(ResDevelopmentChallenge));
        }

        public decimal CalculateArea()
        {
            return _length * _height;
        }

        public decimal CalculatePerimeter()
        {
            return 2 * (_length + _height);
        }

        public string GetName(int quantity)
        {
            return quantity == 1 ? _resourceManager.GetString("Trapeze") : _resourceManager.GetString("Trapezoids");
        }
    }
}
