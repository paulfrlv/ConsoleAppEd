/*using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) { 
            Console.WriteLine(ExTen("XIV"));
        }

        private static Dictionary<char, int> _map = new Dictionary<char, int>() {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        }; 
        public static int ExTen (string roman) {
            int result = 0;
            for (int i = 0; i < roman.Length; i++) {
                if (i+1 < roman.Length && IsSubtrective(roman[i], roman[i+1])) {
                    result -= _map[roman[i]];
                }
                else {
                    result += _map[roman[i]]; 
                }
            }

            return result;
        }

        private static bool IsSubtrective(char c1, char c2) {
            return _map[c1] < _map[c2]; 
        }


        static void ExNine() {
            var people = new Dictionary<string, int>() {
                {"Paul", 46123815},
                {"Mike", 161321351},
                {"Susy", 56516}
            };
            foreach (var man in people) {
                Console.WriteLine(man.Key);
                Console.WriteLine(man.Value);
            }
            
            var numbers = new List<int>() {1,6153,465,41,465,48,39};
            int[] n = new []{ 123, 156,12 };
            Console.WriteLine(numbers.Count);
            numbers.Add(7);
            numbers.Add(7);
            numbers.AddRange(n);
            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers.Capacity);
            
        }
         
         static void ExEightLogin() {
            const string login = "paul";
            const string password = "qwerty";
            
            int i = 1;
            while (i <= 3) {
                Console.WriteLine($"Try number {i}");
                Console.WriteLine("Input login:");
                string log = Console.ReadLine();
                Console.WriteLine("Input password:");
                string pass = Console.ReadLine();
                
                if (log == login && pass == password) {
                    Console.WriteLine("Enter the System");
                    break;
                } else if (i == 3 && (log != login || pass != password)) {
                    Console.WriteLine("The number of available tries have been exceeded");
                }
                
                i++;
            }
        }
         static void ExSevenFactorial() {
            Console.WriteLine("Input number n >= 0:");
            int number = Convert.ToInt32(Console.ReadLine());
            long multi = 1;
            for (int i = number; i >= 1; i--) {
                multi *= i;
            }

            Console.WriteLine(multi);
        }
       static void ExSix() {
            int[] arr = new int[10];
            int i = 0;
            while (i < 10) {
                int n = int.Parse(Console.ReadLine());
                if (n == 0) {
                    break;
                }
                arr[i] = n;
                i++;
            }
            Console.WriteLine("Enter numbers to find the arithmetic mean:");
            
            for (var i = 0; i < 10; i++) {
                int n = Convert.ToInt32(Console.ReadLine());
                arr[i] = n;
                if (n == 0)
                    break;
            }
            
            arr = arr.Where(x => x != 0).ToArray();
            
            double sum = 0;
            for (var i = 0; i < arr.Length; i++) {
                sum += arr[i];
            }
            var result = sum / arr.Length;
            
            Console.WriteLine("");
            Console.WriteLine($"Result: {result}");
        }
        static void ExFive() {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
        }
        static void ExFour() {
            Console.WriteLine("Input x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input y:");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > y) {
                Console.WriteLine(x);
            } else if (y > x) {
                Console.WriteLine(y);
            } else {
                Console.WriteLine("x = y"); 
            }

            int[] numbers = {0, 55, 4, 31, -42, -7, 82};
            for (int i = 0; i < numbers.Length; i++) {
                Console.Write(numbers[i] + " ");
            }
        }
        static void ExThree() {
            Console.WriteLine("Input surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Input name:");
            string name = Console.ReadLine();
            Console.WriteLine("Input age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input weight:");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input height:");
            double height = Convert.ToDouble(Console.ReadLine());
            
            double imt = weight / (height * height);
            Console.WriteLine($"Your profile: \nFull Name: {surname}, {name} \nAge: {age} \nWeight: {weight} \nHeight: {height} \nBody Mass Index: {imt}");
        }
        static void ExTwo() {
            double a, b, c, p;
            Console.WriteLine("Input a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input c:");
            c = Convert.ToDouble(Console.ReadLine());

            p = (a + b + c) / 2;
            double square = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            Console.WriteLine($"Result: {square}");
        }
        static void ExOne() {
            //1
            Console.WriteLine("Input name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}");
            //2
            Console.WriteLine("input x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"x: {x}, y: {y}");
            int a = x;
            x = y;
            y = a;
            Console.WriteLine($"x: {x}, y: {y}");
            //3
            Console.WriteLine("Input number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number.ToString().Length);
        }
    }
}*/