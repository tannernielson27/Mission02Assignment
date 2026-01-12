internal class Program
{
    private static void Main(string[] args)
    {
        // Gather Inputs and store them to be passed into the DiceRolls class
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        string numberRollsString = Console.ReadLine();
        int userChoice = int.Parse(numberRollsString);
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + userChoice);

        // Calculation
        DiceRolls mySimulator = new DiceRolls();
        int[] results = mySimulator.SimulateRolls(userChoice);

        // For loop to calculate and display results
        for (int i = 2; i < results.Length; i++) {
            float count = results[i];
            float totalRolls = userChoice;
            float percent = ((count / totalRolls) * 100);
            int percentInt = (int)percent;
            string asteriks = new string('*', (int)percentInt);
            Console.Write(i + ": " + asteriks);
            Console.WriteLine();
        }
        Console.WriteLine("Thank you for using the dice throwing simulator.  Goodbye!");

    }
}


