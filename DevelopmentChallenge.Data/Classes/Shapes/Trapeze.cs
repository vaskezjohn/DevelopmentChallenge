using DevelopmentChallenge.Data.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Shapes
{
    public class Trapeze : IGeometricShapes
    {
        private decimal _baseMajor;
        private decimal _baseMinor;
        private decimal _height;
        private readonly ResourceManager _resourceManager;

        public Trapeze(decimal baseMajor, decimal baseMinor, decimal height)
        {
            this._baseMajor = baseMajor;
            this._baseMinor = baseMinor;
            this._height = height;
            _resourceManager = new ResourceManager(typeof(ResDevelopmentChallenge));
        }

        public decimal CalculateArea()
        {
            return ((_baseMajor + _baseMinor) * _height) / 2;
        }

        public decimal CalculatePerimeter()
        {
            double slantSide = (double)(Math.Abs(_baseMajor - _baseMinor) / (2 * _height)); 
            double parallelSide = Math.Sqrt(Math.Pow((double)((_baseMajor - _baseMinor) / 2), 2) + Math.Pow((double)_height, 2)); 

            return _baseMajor + _baseMinor + (decimal)parallelSide * 2;
        }

        public string GetName(int quantity)
        {
            return quantity == 1 ? _resourceManager.GetString("Trapeze") : _resourceManager.GetString("Trapezoids");
        }
    }
}
