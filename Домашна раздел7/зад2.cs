using System;

class Program
{
    static void Main(string[] args)
    {
        int countLikes = 0;
        // the first two names
        Console.WriteLine("Enter a name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine($"{firstName} liked your post");
        Console.WriteLine("Enter a name: ");
        string secondName = Console.ReadLine();
        Console.WriteLine($"{firstName} and {secondName} liked your post");

        while (true)
        {
            Console.WriteLine("Enter a name: ");
            string user = Console.ReadLine();
            if (user == "")
            {
                break;
            }
            countLikes++;
            Console.WriteLine($"{firstName}, {secondName} and {countLikes} liked your post");
        }
    }
}
