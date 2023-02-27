using Mindbox.LibraryShapes;

namespace ConsoleApp {
    internal static class Program {
        static void Main(string[] args) {
            Circle circle = new(5);
            Triangle triangle = new Triangle(6, 8, 10);
            Console.WriteLine(triangle.GetArea());
            Console.WriteLine(triangle.isRectangular());
            Console.WriteLine(circle.GetArea());
        }
    }
}