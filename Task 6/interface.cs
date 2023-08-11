using System;

public interface ICircle
{
    void Area();
}

public interface IRectangle
{
    void Area();
}

public class Shape : ICircle, IRectangle
{
    public double Radius { get; set; }

    public double Width { get; set; }
    public double Length { get; set; }

    void ICircle.Area()

    {
        Console.WriteLine("enter Radius");
         Radius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Area of circle" + Math.PI * Radius * Radius);
    }
    void  IRectangle.Area()
    {
        Console.WriteLine("enter width");
         Width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter length");
         Length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Area of Rectangle" + Length * Width);
    }
}

class Program
{
    static void Main()
    {      
        ICircle circle;
        circle= new Shape();
      
        circle.Area();

        IRectangle rectangle;
        rectangle = new Shape();
   
        rectangle.Area();
      
        Console.ReadLine();
    }
}
