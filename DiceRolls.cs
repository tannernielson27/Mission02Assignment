using System;

public class DiceRolls
{   
    // Create the method in the DiceRolls class
    public int[] SimulateRolls(int UserChoice)
    {   
        // Create an array to hold totals
        int[] totals = new int[13];
        // Random calculations
        Random rnd = new Random();
        for (int i = 0; i < UserChoice; i++)
        {
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            int rollResult = dice1 + dice2;
            totals[rollResult]++;
        }
        return totals;
    }
}