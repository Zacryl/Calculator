using System;
using System.Collections.Generic;
namespace Calculator.MainMenu{
class MainClass{
    //Value after calculations.
    private static int calcedNumber = 0;
    private static void initialNumber(){
    //To replaced calcedNumber with an initial number.
        Console.WriteLine("Enter a number");
        string newNumber = Console.ReadLine(); 
        if(!Calculator.Math.Calculations.CheckValidNumber(newNumber)){
            initialNumber();
        }else{
            calcedNumber =  Convert.ToInt32(newNumber);
        }
    }
    private static void Menu(){
        //Asks the user for what kind of calculations they want to do.
        Console.WriteLine("Enter the following letters for the corresponding option"+ 
        "\n-a: Addition\n-s: Subtraction\n-m: Multiplication\n-d: Division");
        string input = Console.ReadLine();
        switch (input)
        {
            case "a":
                calcedNumber = Calculator.Math.Calculations.Addition(calcedNumber);
                Console.WriteLine("Calculation is: {0}", calcedNumber);
                break;
            case "s":
                calcedNumber = Calculator.Math.Calculations.Subtraction(calcedNumber);
                Console.WriteLine("Calculation is: {0}", calcedNumber);
                break;
            case "m":
                calcedNumber = Calculator.Math.Calculations.Multiplication(calcedNumber);
                Console.WriteLine("Calculation is: {0}", calcedNumber);
                break;
            case "d":
                calcedNumber = Calculator.Math.Calculations.Division(calcedNumber);
                Console.WriteLine("Calculation is: {0}", calcedNumber);
                break;
            default:
                Console.WriteLine("Sorry not an option");
                Menu();
                break;
        }
    }
    static void Main(string[] args)
    {
        /*Clears the console from any previous action and yellow errors as well as run initial
        and menu methods*/
        Console.Clear(); 
        initialNumber();
        Menu();
    }
}    
}