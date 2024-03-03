namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz gorna granice.");
            int limit = int.Parse(Console.ReadLine());
            FizzBuzz fz1 = new FizzBuzz(limit);
            fz1.Display();
        }
    }
}
