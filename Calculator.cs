using System;
using System.Linq;

namespace ConsoleApp {
    public static class Calculator {
        public static double Average(params int[] numbers) {
            double sum = 0;
            foreach (var n in numbers) {
                sum += n;
            }
            return sum / numbers.Length;
        }

        public static bool TryDivide(double divisible, double divisor, out double result) {
            result = 0;
            if (divisor == 0) {
                return false;
            }

            result = divisible / divisor;
            return true;
        }
        
        public static double CalcTriangleSquare(double a, double b, double c) {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
        public static double CalcTriangleSquare(double a, double h) {
            return 0.5 * a * h;
        }
        public static double CalcTriangleSquare(double ab, double ac, int alpha, bool isInRadians = false) {
            if (isInRadians) {
                return 0.5 * ab * ac * Math.Sin(alpha);
            } 
            else {
                double rads = alpha * Math.PI / 180;
                return 0.5 * ab * ac * Math.Sin(rads);
            }
            
        }

        
    }
    
} 