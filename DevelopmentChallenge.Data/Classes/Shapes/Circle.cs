using DevelopmentChallenge.Data.Languages;
using System;
using System.Resources;

namespace DevelopmentChallenge.Data.Classes.Shapes
{
    public class Circle : IGeometricShapes
    {
        private decimal _radius;
        private readonly ResourceManager _resourceManager;

        public Circle(decimal radius)
        {
            this._radius = radius;
            _resourceManager = new ResourceManager(typeof(ResDevelopmentChallenge));
        }

        public decimal CalculateArea()
        {
            return (decimal)Math.PI * (_radius / 2) * (_radius / 2);
        }

        public decimal CalculatePerimeter()
        {
            return (decimal)Math.PI * _radius;
        }

        public string GetName(int quantity)
        {
            return quantity == 1 ? _resourceManager.GetString("Circle") : _resourceManager.GetString("Circles");
        }
    }
}
