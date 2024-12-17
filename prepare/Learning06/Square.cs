// Square.cs
public class Square : Shape
{
    private double _side;

    // Constructor to set color and side length
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Override GetArea() method
    public override double GetArea()
    {
        return _side * _side;
    }
}
