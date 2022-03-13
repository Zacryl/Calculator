using System;
using System.Collections.Generic;
namespace Calculator.MainMenu{
class MainClass{
    //Value after calculations.
    int calcedNumber = 0;
    private int initialNumber(){
    //To replaced calcedNumber with an initial number.
        Console.WriteLine("Enter a number");
        string newNumber = Console.ReadLine();
        return Convert.ToInt32(newNumber);
    }
    static void Main(string[] args)
    {
        Console.Clear(); 
        //Starts asking the user for what kind of calculations they want to do.
        Console.WriteLine("Enter the following letters for the corresponding option"+ 
        "\n-a: Addition\n-s: Subtraction\n-m: Multiplication\n-d: Division");
        string input = Console.ReadLine();
        switch (input)
        {
            case a:
                
            default:
        }
    }
}    
}