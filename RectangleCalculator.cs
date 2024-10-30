namespace exercise3;
internal class RectangleCalculator
{
    public static (double Perimeter, double Area, double Diagonal) CalculateRectangleProperties(double width, double height)
    {
        // Calcular perímetro
        double perimeter = 2 * (width + height);
        
        // Calcular área
        double area = width * height;
        
        // Calcular diagonal usando el teorema de Pitágoras
        double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
        
        return (perimeter, area, diagonal);
    }
}