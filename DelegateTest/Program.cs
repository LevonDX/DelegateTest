namespace DelegateTest
{
    internal class Program
    {
        static bool IsEven(int item)
        {
            return item % 2 == 0;
        }

        static bool IsOdd(int item)
        {
            return item % 2 == 1;
        }

        static void Main(string[] args)
        {
            int[] x = { 1, 3, 2, 5, 0, 2, 3, 4, 9, 2, 3, 4, -6, 9, 0, 20 };

            x.GetElementsByCondition(IsOdd)
                .ForEachElement(Console.WriteLine);
        }
    }
}