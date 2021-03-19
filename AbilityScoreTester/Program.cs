using System;

namespace AbilityScoreTester
{
    class Program
    {
        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            while (true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Add Amount");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Calculated ability score: " + calculator.Score);
                Console.WriteLine("Press Q to quit, any other key to continue");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;
            }
            // Add a method called ReadInt it takes, 2 parameters, a prompt to display to the user, and a default value.
            //It writes the prompt to the console, followed by the default value in square brackets, Then it reads a line 
            //from the console and attempts to parse it. If the value can be parsed, it uses that value, otherwise, it uses a default value

            /*
             * Writes a prompt and reads an int value from the console. 
             * param name = "lastUsedValue" - the default value
             * param name = "prompt" - prompt to print to the console
             * returns - the int value read, or the default value if unable to parse
             */

            static int Readint(int lastUsedValue, string prompt)
            {
                // Write the prompt followed by [default value]:
                // Read the line from the input and use int. TryParse to attempt to parse it. 
                //if it can be parsed, write "  using value" + value to the console.
                //otherwise write " using default value" + last used value to the console
                Console.Write(prompt + " [" + lastUsedValue + "]: ");
                string line = Console.ReadLine();
                if (int.TryParse(line, out int value))
                {
                    Console.WriteLine(" using value " + value);
                    return value;
                }
                else
                {
                    Console.WriteLine(" using default value " + lastUsedValue);
                    return lastUsedValue;
                }


            }

            /*
             * Add a ReadDouble method that is exactly like ReadInt, except that it uses double.TryParse instead of int.TryParse. 
             * The double.TryParse method works exactly link int.tryparse, except its out variable needs a double not an int. 
             */
            static double ReadDouble(double lastUsedValue, string prompt)
            {
                Console.Write(prompt + " [" + lastUsedValue + "]: ");
                string line = Console.ReadLine();
                if (double.TryParse(line, out double value)) 
                {
                    Console.WriteLine(" using value " + value);
                    return value;
                }
                else
                {
                    Console.WriteLine(" using default value " + lastUsedValue);
                    return lastUsedValue;
                }


            }
        }
    }
}
