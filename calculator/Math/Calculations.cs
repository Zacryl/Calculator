using System;
using System.Collections.Generic;

namespace Calculator.Math {
    public class Calculations{

        public static bool CheckValidNumber(string? input){
            try{
                Convert.ToDouble(input);
                return true;
            }
            catch (FormatException){
                Console.WriteLine("Not a valid number");
                return false;
            }
            catch(OverflowException){
                Console.WriteLine("Not a valid number");
                return false;
            }
        }   
        public static double Addition(double currNumber){
            Console.WriteLine("Enter a number to add:");
            string? input = Console.ReadLine();
            if(!CheckValidNumber(input)){
                return Addition(currNumber);
            }else{
                double number = Convert.ToDouble(input);
                return currNumber += number;
            }
        }
        public static double Subtraction (double currNumber){
            Console.WriteLine("Enter a number to subtract:");
            string? input = Console.ReadLine();
            if(!CheckValidNumber(input)){
                return Subtraction(currNumber);
            }else{
                double number = Convert.ToDouble(input);
                return currNumber -= number;
            }
        }
        public static double Multiplication (double currNumber){
            Console.WriteLine("Enter a number to multiply by:");
            string? input = Console.ReadLine();
            if(!CheckValidNumber(input)){
                return Multiplication(currNumber);
            }else{
                double number = Convert.ToDouble(input);
                return currNumber *= number;
            }
        }
        public static double Division (double currNumber){
            Console.WriteLine("Enter a number to divide by:");
            string? input = Console.ReadLine();
            if(!CheckValidNumber(input)){
                return Division(currNumber);
            }else{
                double number = Convert.ToDouble(input);
                return currNumber /= number;
            }
        }
    }
}