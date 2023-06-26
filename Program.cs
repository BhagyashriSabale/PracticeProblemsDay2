namespace PracticeProblemDay2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Practice Problem Day 2");
            Console.WriteLine("Please Choose one program from below list");
            Console.WriteLine("\n1.NumbersEqualorNot");
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    NumbersEqualorNot number = new NumbersEqualorNot();
                    number.num();
                    break;
            }
            
        }
    }
}