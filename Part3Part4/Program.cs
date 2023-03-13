namespace Part3Part4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercise 3-24

            //Login();
            LastPartSplit();

            static void Login()
            {
                string username = "alex";
                string username2 = "emma";
                string password = "sunshine";
                string password2 = "haskell";

                Console.WriteLine("Enter username");
                string input1 = Console.ReadLine();
                Console.WriteLine("Enter password");
                string input2 = Console.ReadLine();

                if (username == input1 && password == input2 || username2 == input1 && password2 == input2)
                {
                    Console.WriteLine("You have successfully logged in!");
                } else
                {
                    Console.WriteLine("Incorrect username or password!");
                }
            }

            //exercise 3-28
            static void LastPartSplit()
            {
                Console.WriteLine("Give a input");
                string input1 = (Console.ReadLine());

                string awnser = input1.Split(' ').LastOrDefault();
                Console.WriteLine(awnser);
            }
        }
    }
}