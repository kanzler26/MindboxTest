namespace Mindbox.LibraryShapes {
    public class Circle : IShape {
        private readonly double pi = 3.14;
        private double _radius;
        public Circle(double r) {
            _radius = r;
        }
        public double GetArea() => _radius * _radius * pi;
    }
}
