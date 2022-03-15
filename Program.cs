using System;
using System.Collections.Generic;
namespace Calculator.MainMenu{
    public class MainClass{
        //Value after calculations.

        public static void Main()
        {
            /*Clears the console from any previous action and yellow errors as well as run initial
            and menu methods*/
            while(!Calculator.Initialize.Initializer.Exit()){
                if(Calculator.Initialize.Initializer.hasCalculated){
                    Console.Clear();
                    Console.WriteLine("Current calculation: {0}\n", Calculator.Initialize.Initializer.calcedNumber); 
                    Console.WriteLine(Calculator.Math.Calculations.disHistory());
                    Calculator.Initialize.Initializer.Menu();
                }else{
                    Console.Clear(); 
                    Calculator.Initialize.Initializer.initialNumber();
                    Calculator.Initialize.Initializer.Menu();
                }
            }
        }
}    
}