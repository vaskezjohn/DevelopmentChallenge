namespace DevelopmentChallenge.Data.Classes
{
    public interface IGeometricShapes
    {
        decimal CalculateArea();
        decimal CalculatePerimeter();
        string GetName(int quantity);
    }
}
