using System;

class Test
{
    public static void GetId()
    {
        int Id = int.Parse(Console.ReadLine());

        switch (Id)
        {
            case 1:
                Console.WriteLine("you are in Class room A");
                break;
            case 2:
                Console.WriteLine("you are in Class room B");
                break;
            case 3:
                Console.WriteLine("you are in Class room C");
                break;
            default:
                Console.WriteLine("you are in Class room D");
                break;
        }
    }

    public static void Main()
    {
        bool addAgain = true;


        do{ Console.WriteLine("Enter your name\nEnter your age\nEnter your Id");

            string Name = Console.ReadLine();
            int Age = int.Parse(Console.ReadLine());
            GetId();

            Console.WriteLine("Do you want to add another student? (y/n)");
            string ask = Console.ReadLine();
            addAgain = ask.ToLower() == "y";
        } while (addAgain);

    }
}