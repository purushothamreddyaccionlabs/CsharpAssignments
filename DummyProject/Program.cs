using System;
class Program
{
    public static void Main()
    {
        /*[[1,5],[7,3],[3,5]]*/
        int[,] accounts =  { { 1, 5 }, { 7, 3 }, { 3, 5 } };
        int i = maximumWealth(accounts);
    }
    public static int maximumWealth(int accounts)
    {
        int wealth = -1;
        for (int i = 0; i < accounts.Length; i++)
        {
            int temp_sum = 0;
            for (int j = 0; j < accounts[i].Length; j++)
            {
                temp_sum += accounts[i,j];
            }
            if (temp_sum > wealth)
            {
                wealth = temp_sum;
            }
        }
        return wealth;
    }
}