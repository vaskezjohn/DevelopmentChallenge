using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;
using DevelopmentChallenge.Data.Languages;
using System.Resources;
using Microsoft.SqlServer.Server;

namespace DevelopmentChallenge.Data.Classes
{
    public class ReportShape
    {
        private readonly ResourceManager _resourceManager;

        public ReportShape(string language)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(language);
            _resourceManager = new ResourceManager(typeof(ResDevelopmentChallenge));
        }

        public string Print(List<IGeometricShapes> formas)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
                sb.Append($"<h1>{_resourceManager.GetString("Empty")}!</h1>");
            else
            {
                sb.Append($"<h1>{_resourceManager.GetString("Header")}</h1>");
                var quantity = 1;
                var area = 0m;
                var perimeter = 0m;
                var name = string.Empty; 
                var totalArea = 0m;
                var totalPerimeter = 0m;

                var groupedShapes = formas.GroupBy(f => f.GetName(1)); 

                foreach (var group in groupedShapes)
                {
                    name = group.First().GetName(group.Count());
                    quantity = group.Count();
                    area = group.Sum(f => f.CalculateArea());
                    perimeter = group.Sum(f => f.CalculatePerimeter());

                    totalArea += area;
                    totalPerimeter += perimeter;

                    sb.Append($"{quantity} {name} | ");
                    sb.Append($"{_resourceManager.GetString("FooterArea")} {area:#.##} | ");
                    sb.Append($"{_resourceManager.GetString("FooterPerimeter")} {perimeter:#.##} <br/>");
                }

                sb.Append($"{_resourceManager.GetString("FooterTotal")}:<br/>{formas.Count} {_resourceManager.GetString("FooterShape")} ");
                sb.Append($"{_resourceManager.GetString("FooterPerimeter")} {totalPerimeter.ToString("#.##")} ");
                sb.Append($"{_resourceManager.GetString("FooterArea")} {totalArea.ToString("#.##")}");
            }

            return sb.ToString();
        }

    }
}
