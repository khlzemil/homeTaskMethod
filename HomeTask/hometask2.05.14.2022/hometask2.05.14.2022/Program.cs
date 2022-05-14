using System;
class Program

{

    public static void Main()
    {
        Pyramid(5, 5);

    }


    public static void Pyramid( int en, int uzunluq)
    {
        for (int i = 1; i <= en; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write("* ");

            }
            Console.WriteLine("");
        }


    }
}
