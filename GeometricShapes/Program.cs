using System.Security.Cryptography;

namespace GeometricShapes;

internal class Program
{
    static void Main(string[] args)
    {
        Sqr s1 = new Sqr(6);
        Console.WriteLine($"Perimeter is {s1.Perimeter()} and the area is {s1.Area()}");
        Rect r1 = new Rect(5, 10);
        Console.WriteLine($"Perimeter is {r1.Perimeter()} and area is {r1.Area()}");

        Quad q1 = new Quad(3, 4, 5, 6);
        Console.WriteLine($"Perimeter is {q1.Perimeter()}");
        Quad q2 = new Quad(15,18, 19, 11);
        Console.WriteLine($"Perimeter is {q2.Perimeter()}");

    }
}

