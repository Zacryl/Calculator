namespace Calculator.Initialize {
    public class Initializer{
        public static double calcedNumber = 0.0;
        private static bool exit = false;
        public static bool hasCalculated = false;
        public static void initialNumber(){
        //To replaced calcedNumber with an initial number.
            Console.WriteLine("Enter a number");
            string? newNumber = Console.ReadLine(); 
            if(!Calculator.Math.Calculations.CheckValidNumber(newNumber)){
                initialNumber();
            }else{
                calcedNumber =  Convert.ToDouble(newNumber);
            }
        }
        //Input options called through Menu
        public static void inputOptions(){
            string? input = Console.ReadLine();
                    switch (input){
                case "a":
                    calcedNumber = Calculator.Math.Calculations.Addition(calcedNumber);
                    hasCalculated = true;
                    break;
                case "s":
                    calcedNumber = Calculator.Math.Calculations.Subtraction(calcedNumber);
                    hasCalculated = true;
                    break;
                case "m":
                    calcedNumber = Calculator.Math.Calculations.Multiplication(calcedNumber);
                    hasCalculated = true;
                    break;
                case "d":
                    calcedNumber = Calculator.Math.Calculations.Division(calcedNumber);
                    hasCalculated = true;
                    break;
                case "x":
                    exit = true;
                    break;
                case "c":
                    calcedNumber = 0;
                    hasCalculated = false;
                    break;
                default:
                    Console.WriteLine("Sorry not an option");
                    Menu();
                    break;
            }
        }
        public static bool Exit(){
            return exit;
        }
        public static void Menu(){
            Calculator.Math.Calculations.history();
            //Asks the user for what kind of calculations they want to do.
            Console.WriteLine("Enter the following letter on the list for the corresponding option"+ 
            "\n~ c : Clear the calculator\n~ a : Addition\n~ s : Subtraction\n~ m : Multiplication"
            + "\n~ d : Division\n~ x : Exit the calculator");
            inputOptions();
        }
    }
}