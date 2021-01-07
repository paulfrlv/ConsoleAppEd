using System;
using System.Collections.Generic;

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            
            var collection = new BaseList(4);
            
            var shapes = new Shape[2];
            shapes[0] = new Triangle(10, 20, 30);
            shapes[1] = new Rectangle(5, 10);
            foreach (var shape in shapes) {
                shape.Draw();
                Console.WriteLine(shape.Perimeter());
            }
            
            // string line = Console.ReadLine();
            // bool wasParsed = int.TryParse(line, out int num);
            // if ( wasParsed) {
            //     Console.WriteLine(num);
            // }
            // else {
            //     Console.WriteLine("Failed");
            // }
        }

        static void Swap(short a, short b) {
            Console.WriteLine($"Original a={a}, b={b}");
            short tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine($"Modify a={a}, b={b}");
        }

        static void AddNumbers(List<short> numbers) {
            if (numbers == null) throw new ArgumentNullException(nameof(numbers));
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            Console.WriteLine($"Capacity: {numbers.Capacity}; Count: {numbers.Count}");
        }
    } 
}   