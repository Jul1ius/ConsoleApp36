namespace Min_Max_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            
            int N = int.Parse(Console.ReadLine());

            if (N <= numbers.Length)
            {
                int max = numbers.Take(N).Max();
                int min = numbers.Take(N).Min();

                Console.WriteLine(max);
                Console.WriteLine(min);
            }
            else
            {
                Console.WriteLine("N is greater than the number of elements in the array.");
            }
        }
    }
}