using System;
using System.Collections.Generic;

namespace Calculator.Math {
    public class Calculations{

        public static bool CheckValidNumber(string input){
            try
            {
                Convert.ToInt32(input);
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a valid number");
                return false;
            }
        }
        public static int Addition(int currNumber){
            Console.WriteLine("Enter a number to add:");
            string input = Console.ReadLine();
            if(!CheckValidNumber(input)){
                return Addition(currNumber);
            }else{
                int number = Convert.ToInt32(input);
                return currNumber += number;
            }
        }
        public static int Subtraction (int currNumber){
            Console.WriteLine("Enter a number to subtract:");
            string input = Console.ReadLine();
            if(!CheckValidNumber(input)){
                return Subtraction(currNumber);
            }else{
                int number = Convert.ToInt32(input);
                return currNumber += number;
            }
        }
        public static int Multiplication (int currNumber){
            Console.WriteLine("Enter a number to multiply by:");
            string input = Console.ReadLine();
            if(!CheckValidNumber(input)){
                return Multiplication(currNumber);
            }else{
                int number = Convert.ToInt32(input);
                return currNumber += number;
            }
        }
        public static int Division (int currNumber){
            Console.WriteLine("Enter a number to divide by:");
            string input = Console.ReadLine();
            if(!CheckValidNumber(input)){
                return Division(currNumber);
            }else{
                int number = Convert.ToInt32(input);
                return currNumber += number;
            }
        }
    }
}