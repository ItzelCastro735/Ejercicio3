namespace exercise3.V2;
public class RectangleCalculator
{

    private double width ;
    private double height;

    public double OtherProperty ;

    protected double Myprotege;

    public RectangleCalculator(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    public double GetPerimeter()
    {
        return 2 * (width + height);
    }

    public double GetArea()
    {
        return width * height;
    }

    public double GetDiagonal ()
    {
        return Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
    }
}