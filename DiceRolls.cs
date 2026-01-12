using System;

public class DiceRolls
{
    public int[] SimulateRolls(int UserChoice)
    {
        int[] totals = new int[13];
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