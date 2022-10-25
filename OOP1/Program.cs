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

        private float _a;
        private float _b;
        private float _c;
 
        //Constructor, takes all sides of a triangle
        public Triangle(float a, float b, float c) {

            _a = a;
            _b = b;
            _c = c;

        }

        public float GetArea() {

            //Holding var since we don't need to write out the same thing several times
            float hold = (_a + _b + _c) / 2;

            //Math.Pow = power of, returns a double 
            return (float)Math.Pow( (hold * (hold - _a) * (hold - _b) * (hold - _c)), 0.5f);

        }

    }

    class Circle {

        private float _pi = 3.141f;
        private float _radius;

        //Constructor, takes raidus of the circle
        public Circle(float radius) {

            _radius = radius;

        }

        public float GetArea() {

            //Area of a circle
            return _radius * _radius * _pi;

        }

        public float GetCircumference() {

            //Circumference of a circle
            return (_radius + _radius) * _pi;

        }

        public float GetVolume() {

            //Math.Pow power of, returns a double 
            return 4 / 3 * _pi * (float)Math.Pow(_radius, 3f);

        }

    }

}
