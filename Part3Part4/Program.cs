using System;

class ReadingInt
{
    static void Main(string[] args)
    {
        string input = "";

        while (input != "end")
        {
            Console.WriteLine("Geef een nummer of typ 'end' om te stoppen");
            input = Console.ReadLine();

            if (input != "end")
            {
                int num = int.Parse(input);
                int uitkomst = num * num * num;
                Console.WriteLine($"de uitkomst is {uitkomst}");
            }
        }
    }
}