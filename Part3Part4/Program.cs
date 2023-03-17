namespace Part3Part4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Login();
            //LastPartSplit();
            //CSVAge();
            //CSVName();
            MaxNameAndAge();

            //exercise 3-24
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
                }
                else
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

            //exercise 3-29
            static void CSVAge()
            {
                string input;
                int maxAge = 0;

                Console.WriteLine("Enter your name and age");

                while ((input = Console.ReadLine()) != "")
                {

                    string[] parts = input.Split(',');
                    string name = parts[0].Trim();

                    int age = int.Parse(parts[1]);
                    if (age > maxAge)
                    {
                        maxAge = age;
                    }
                }
                Console.WriteLine($"Age of the oldest: {maxAge}.");
            }

            //exercise 3-30
            static void CSVName()
            {
                string input;
                int maxAge = 0;
                string maxAgeName = "";

                Console.WriteLine("Enter your name and age");

                while ((input = Console.ReadLine()) != "")
                {

                    string[] parts = input.Split(',');
                    string name = parts[0];

                    int age = int.Parse(parts[1]);
                    if (age > maxAge)
                    {
                        maxAge = age;
                        maxAgeName = name;
                    }
                }
                Console.WriteLine($"The name of the oldest: {maxAgeName}.");
            }

            //exercise 3-31
            static void MaxNameAndAge()
            {
                List<string> names = new List<string>();
                List<int> birthYears = new List<int>();

                while (true)
                {
                    Console.Write("Enter name and birth year (or press Enter to finish): ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input))
                    {
                        break;
                    }

                    string[] parts = input.Split(',');
                    string name = parts[0].Trim();
                    int birthYear = int.Parse(parts[1]);
                    names.Add(name);
                    birthYears.Add(birthYear);
                }

                int currentYear = DateTime.Now.Year;
                int maxAge = int.MinValue;
                string longestName = string.Empty;

                for (int i = 0; i < names.Count; i++)
                {
                    string name = names[i];
                    int birthYear = birthYears[i];
                    int age = currentYear - birthYear;

                    if (age > maxAge || (age == maxAge && name.Length > longestName.Length))
                    {
                        maxAge = age;
                        longestName = name;
                    }
                }

                Console.WriteLine("The longest name is: " + longestName);
                Console.WriteLine("The highest age is: " + maxAge);
                Console.ReadLine();
            }
        }
    }
}