using System;
using System.Collections.Generic;

namespace Calculator.Math {
    public class Calculations{
        public static int Addition(int currNumber){
            string input = Console.ReadLine();
            int number = Convert.ToInt32(number);
            currNumber += number;
            return currNumber;
        }
        public static int Subtraction (int currNumber){
            string input = Console.ReadLine();
            int number = Convert.ToInt32(number);
            currNumber -= number;
            return currNumber;
        }
        public static int Multiplication (int currNumber){
            string input = Console.ReadLine();
            int number = Convert.ToInt32(number);
            currNumber *= number;
            return currNumber;
        }
        public static int Division (int currNumber){
            string input = Console.ReadLine();
            int number = Convert.ToInt32(number);
            currNumber /= number;
            return currNumber;
        }
    }
}