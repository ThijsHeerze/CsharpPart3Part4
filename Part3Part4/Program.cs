using System;

class GuestlistTxt
{
    void Main(string[] args)
    {
            string[] names = File.ReadAllLines("C:\\Users\\thijs\\OneDrive\\Documenten\\Roc\\C#\\Part3Part4\\.vs\\Part3Part4\\guestlist.txt");

            Console.WriteLine("Enter names, an empty line quits.");

            while (true)
            {
                Console.Write("> ");
                string name = Console.ReadLine().Trim();

                if (name == "")
                    if (name == "")
                    {
                        break;
                    }

                bool onList = false;

                foreach (string guestName in names)
                {
                    if (guestName.ToLower() == name.ToLower())
                    {
                        onList = true;
                        break;
                    }
                }

                if (onList)
                {
                    Console.WriteLine("The name is on the list.");
                }
                else
                {
                    Console.WriteLine("The name is not on the list.");
                }
            }

            Console.WriteLine("\nThank you!");
        }
}