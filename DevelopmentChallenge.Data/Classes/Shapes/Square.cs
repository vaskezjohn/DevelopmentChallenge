using DevelopmentChallenge.Data.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Shapes
{
    public class Square : IGeometricShapes
    {
        private decimal _side;
        private readonly ResourceManager _resourceManager;

        public Square(decimal side) 
        {
            this._side = side;
            _resourceManager = new ResourceManager(typeof(ResDevelopmentChallenge));
        }

        public decimal CalculateArea()
        {
            return _side * _side;
        }

        public decimal CalculatePerimeter()
        {
            return _side * 4;
        }

        public string GetName(int quantity)
        {
            return quantity == 1 ? _resourceManager.GetString("Square") : _resourceManager.GetString("Squares");
        }
    }
}
