namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a max number: ");
            int maxNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < maxNum; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Enter how many asterisk");
            int asterisk = int.Parse(Console.ReadLine());

            for (int i = 0; i < asterisk; i++)
            { 
                    Console.Write("*");
            }
            //Console.WriteLine(maxNum);
        }
    }
}