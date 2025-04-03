using System;

namespace ColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Color color = new Color(23, 125, 37, 255);
            Sphere sphere = new Sphere(color.GetGray(), color);

            sphere.Throw();
            sphere.Throw();
            sphere.Pop();
            sphere.Throw();

            Console.WriteLine($"Sphere color: {color.GetRed()} {color.GetGreen()} {color.GetBlue()} {color.GetAlpha()}");
            Console.WriteLine($"Thrown: {sphere.GetTimesThrown()}");
        }
    }
}
