using System;

class Program
{

    public static void Main()
    {
        if (SumArray(12, 13, 14))
            {
            Console.WriteLine("True");
            }
        else 
            { 
            Console.WriteLine("False");
            }
    }

    public static bool SumArray(params int[] arr)
    {
        int sum = 0;
        foreach (int element in arr)
        {
            sum += element;

        }
        if (sum % 2 == 0)
            return true;
        return false;


    } 

}
