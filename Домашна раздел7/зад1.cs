using System;

class Program
{
    static void Main()
    {
        Console.Write("Въведете височината на триъгълника: ");
        int h = int.Parse(Console.ReadLine());

        Console.Write("Въведете посоката на триъгълника (left или right): ");
        string pos = Console.ReadLine().ToLower();

        if (pos == "right")
        {
            DrawRightAlignedTriangle(h);
        }
        else if (pos == "left")
        {
            DrawLeftAlignedTriangle(h);
        }
        else
        {
            Console.WriteLine("Невалидна посока. Моля, въведете 'left' или 'right'.");
        }
    }

    static void DrawRightAlignedTriangle(int h)
    {
        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < h - i - 1; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k <= i; k++)
            {
                if (i == h - 1 || k == 0 || k == i)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    static void DrawLeftAlignedTriangle(int h)
    {
        for (int i = 0; i < h; i++)
        {
            for (int k = 0; k <= i; k++)
            {
                if (i == h - 1 || k == 0 || k == i)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}