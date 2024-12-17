// Shape.cs
public abstract class Shape
{
    private string _color;

    // Constructor to set the color
    public Shape(string color)
    {
        _color = color;
    }

    // Getter and setter for color
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // Abstract method to get area
    public abstract double GetArea();
}
