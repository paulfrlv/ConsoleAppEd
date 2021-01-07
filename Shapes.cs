using System;

namespace ConsoleApp {
    public abstract class Shape {
        public Shape() {
            Console.WriteLine("Shape Created");
        }
        public abstract void Draw();
        public abstract double Area();
        public abstract double Perimeter();
    }
    public class Triangle : Shape {
        private readonly double _ab;
        private readonly double _bc;
        private readonly double _ac;

        public Triangle(double ab, double bc, double ac) {
            this._ab = ab;
            this._ac = ac;
            this._bc = bc;
        }
        public override void Draw() {
            Console.WriteLine("Drawing Triangle");
        }

        public override double Area() {
            double s = (_ab + _bc + _ac) / 2;
            return Math.Sqrt(s * (s - _ab) * (s - _bc) * (s - _ac));
        }

        public override double Perimeter() {
            return _ab + _bc + _ac;
        }
    }

    public class Rectangle : Shape {
        private readonly double _width;
        private readonly double _height;

        public Rectangle(double width, double height) {
            this._width = width;
            this._height = height;
        }
        public override void Draw() {
            Console.WriteLine("Drawing Rectangle");
        }

        public override double Area() {
            return _width * _height; 
        }

        public override double Perimeter() {
            return 2 * (_width + _height);
        }
    }
}