using System;

namespace OOP1 {

    internal class Program {

        static void Main(string[] args) {

            //Creating a new object using the Circle constructor
            var circle1 = new Circle(5f);
            Console.WriteLine( $"Area of 1st circle: {circle1.GetArea()}");
            Console.WriteLine($"Circumference of 1st circle: {circle1.GetCircumference()}");
            Console.WriteLine($"Volume of 1st circle: {circle1.GetVolume()}\n");

            var circle2 = new Circle(6f);
            Console.WriteLine( $"Area of 2nd circle: {circle2.GetArea()}");
            Console.WriteLine( $"Circumference of 2nd circle: {circle2.GetCircumference()}");
            Console.WriteLine( $"Volume of 2nd circle: {circle2.GetVolume()}\n");

            var triangle1 = new Triangle(5f, 6f, 7f);
            Console.WriteLine( $"Area of 1st triangle: {triangle1.GetArea()}");

        }

    }

    class Triangle {

        float _a;
        float _b;
        float _c;
 
        public Triangle(float a, float b, float c) {

            _a = a;
            _b = b;
            _c = c;

        }

        //Error handling, incase of a user misstypes
        public Triangle() : this(0f, 0f, 0f) { }

        public float GetArea() {

            //Easier to read the return
            float per = (_a + _b + _c) / 2;

            //Math.Pow = power of, returns a double 
            return (float)Math.Pow( (per * (per - _a) * (per - _b) * (per - _c)), 0.5f);

        }

    }

    class Circle {

        float _pi = 3.141f;
        float _radius;

        public Circle(float radius) {

            _radius = radius;

        }

        //Error handling, incase of a user misstypes
        public Circle() : this(0f) { }

        public float GetArea() {

            return _radius * _radius * _pi;

        }

        public float GetCircumference() {

            return (_radius + _radius) * _pi;

        }

        public float GetVolume() {

            //Math.Pow = power of, returns a double 
            return 4 / 3 * _pi * (float)Math.Pow(_radius, 3f);

        }

    }

}
