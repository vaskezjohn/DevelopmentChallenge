using DevelopmentChallenge.Data.Languages;
using System;
using System.Resources;

namespace DevelopmentChallenge.Data.Classes.Shapes
{
    public class EquilateralTriangle : IGeometricShapes
    {
        private decimal _sideLength;
        private readonly ResourceManager _resourceManager;

        public EquilateralTriangle(decimal sideLength)
        {
            this._sideLength = sideLength;
            _resourceManager = new ResourceManager(typeof(ResDevelopmentChallenge));
        }

        public decimal CalculateArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _sideLength * _sideLength;
        }

        public decimal CalculatePerimeter()
        {
            return _sideLength * 3;
        }

        public string GetName(int quantity)
        {
            return quantity == 1 ? _resourceManager.GetString("EquilateralTriangle") : _resourceManager.GetString("EquilateralTriangles");
        }
    }
}
