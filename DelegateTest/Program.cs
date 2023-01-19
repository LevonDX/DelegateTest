using System.Net.Http.Headers;

namespace DelegateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 2, 5, 0, 2, 3, 4,
                9, 2, 3, 4, -6, 9, 0, 20, 7 };

            //array.GetElementsByCondition(IsDivThree);

            //array.GetElementsByCondition(delegate (int item)
            //{
            //    return item % 5 == 0;

            //})

            array.GetElementsByCondition(item => item > 0)
                .ForEachElement(Console.WriteLine);

            string[] strs = new string[10];
        }
    }
}