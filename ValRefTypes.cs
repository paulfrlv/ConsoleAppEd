using System;

namespace ConsoleApp {

    public struct EvilStruct {
        public int X;
        public int Y;
        public PointRef PointRef;
    }
    public struct PointVal {
        public int X;
        public int Y;
        public void LogValue() {
            Console.WriteLine($"X={X}; Y={Y}"); 
        }
    }
    
    public class PointRef {
        public int X;
        public int Y;
        public void LogValue() {
            Console.WriteLine($"X={X}; Y={Y}"); 
        }
    }
}