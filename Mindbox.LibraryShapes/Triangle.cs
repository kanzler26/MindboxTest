namespace Mindbox.LibraryShapes {
    public class Triangle : IShape {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        public Triangle(double a, double b, double c) {
            _sideA = a;
            _sideB = b;
            _sideC = c;
        }
        public bool isRectangular() {
            return Math.Round((_sideA * _sideA) + (_sideB * _sideB)) == Math.Round(_sideC * _sideC);
        }
        public double GetArea() {
            double halfP = (_sideA + _sideB + _sideC) / 2;
            return Math.Round(Math.Sqrt(halfP * (halfP - _sideA) * (halfP - _sideB) * (halfP - _sideC)));
        }
    }
}
