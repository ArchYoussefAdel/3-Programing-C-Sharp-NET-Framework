class Greatings
{
    private static void Main(string[] args)
    {
        Console.WriteLine("what is your name? ");
        string Name;
        Name = Console.ReadLine();

        Console.WriteLine("Nice to meet you {0} may you tell me your age too  ? ", Name);
        int Age;
        Age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Hi,{Name} you are {Age} so we are the same age");


    }
}