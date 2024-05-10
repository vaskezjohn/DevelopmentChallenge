using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Classes.Shapes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            var report = new ReportShape(Contracts.Constans.Languages.Spanish);
            var shapes = new List<IGeometricShapes>();

            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                report.Print(shapes));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            var report = new ReportShape(Contracts.Constans.Languages.English);
            var shapes = new List<IGeometricShapes>();

            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                report.Print(shapes));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var report = new ReportShape(Contracts.Constans.Languages.Spanish);
            var shapes = new List<IGeometricShapes>
            {
                new Square(5)
            };

            var result = report.Print(shapes);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", result);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var report = new ReportShape(Contracts.Constans.Languages.English);
            var shapes = new List<IGeometricShapes>
            {
                new Square(5),
                new Square(1),
                new Square(3)
            };

            var result = report.Print(shapes);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", result);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var report = new ReportShape(Contracts.Constans.Languages.English);
            var shapes = new List<IGeometricShapes>
            {
                new Square(5),
                new Circle(3),
                new EquilateralTriangle(4),
                new Square(2),
                new EquilateralTriangle(9),
                new Circle(2.75m),
                new EquilateralTriangle(4.2m)
            };

            var result = report.Print(shapes);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 shapes Perimeter 97.66 Area 91.65",
                result);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {

            var report = new ReportShape(Contracts.Constans.Languages.Spanish);
            var shapes = new List<IGeometricShapes>
            {
                new Square(5),
                new Circle(3),
                new EquilateralTriangle(4),
                new Square(2),
                new EquilateralTriangle(9),
                new Circle(2.75m),
                new EquilateralTriangle(4.2m)
            };

            var result = report.Print(shapes);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                result);
        }

        [TestCase]
        public void TestResumenListaConUnRectangulo()
        {
            var report = new ReportShape(Contracts.Constans.Languages.Italian);
            var shapes = new List<IGeometricShapes>
            {
                new Rectangle(10,2)
            };

            var result = report.Print(shapes);

            Console.WriteLine(result);

            Assert.AreEqual("<h1>Rapporto sulle forme</h1>1 Trapezio | Le Area 20 | Perimetro 24 <br/>TOTALE:<br/>1 Forma Perimetro 24 Le Area 20", result);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var report = new ReportShape(Contracts.Constans.Languages.Italian);
            var shapes = new List<IGeometricShapes>
            {
                new Trapeze(5,2,1)
            };

            var result = report.Print(shapes);

            Console.WriteLine(result);

            Assert.AreEqual("<h1>Rapporto sulle forme</h1>1 Trapezio | Le Area 3,5 | Perimetro 10,61 <br/>TOTALE:<br/>1 Forma Perimetro 10,61 Le Area 3,5", result);
        }
    }
}
