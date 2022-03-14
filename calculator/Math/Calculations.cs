using System;
using System.Collections.Generic;

namespace Calculator.Math {
    public class Calculations{
        
        private static List<string> historyList = new List<string>();
        public static string history(){
            string sum = "Calculation history: "; 
            for (int i = 0; i < historyList.Count; i++)
            {
                sum += historyList[i] + ", ";
            }
            return(sum);
        }
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
                var tempCurr = currNumber;
                currNumber += number;
                historyList.Add(string.Format("{0} + {1} = {2}",tempCurr,number,currNumber));
                return currNumber;
            }
        }
        public static double Subtraction (double currNumber){
            Console.WriteLine("Enter a number to subtract:");
            string? input = Console.ReadLine();
            if(!CheckValidNumber(input)){
                return Subtraction(currNumber);
            }else{
                double number = Convert.ToDouble(input);
                var tempCurr = currNumber;
                currNumber -= number;
                historyList.Add(string.Format("{0} - {1} = {2}",tempCurr,number,currNumber));
                return currNumber;
            }
        }
        public static double Multiplication (double currNumber){
            Console.WriteLine("Enter a number to multiply by:");
            string? input = Console.ReadLine();
            if(!CheckValidNumber(input)){
                return Multiplication(currNumber);
            }else{
                double number = Convert.ToDouble(input);
                var tempCurr = currNumber;
                currNumber *= number;
                historyList.Add(string.Format("{0} x {1} = {2}",tempCurr,number,currNumber));
                return currNumber;
            }
        }
        public static double Division (double currNumber){
            Console.WriteLine("Enter a number to divide by:");
            string? input = Console.ReadLine();
            if(!CheckValidNumber(input)){
                return Division(currNumber);
            }else{
                double number = Convert.ToDouble(input);
                var tempCurr = currNumber;
                currNumber /= number;
                historyList.Add(string.Format("{0} / {1} = {2}",tempCurr,number,currNumber));
                return currNumber;
            }
        }
    }
}