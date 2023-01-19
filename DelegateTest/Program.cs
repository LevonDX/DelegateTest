namespace DelegateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 2, 5, 0, 2, 3, 4,
                9, 2, 3, 4, -6, 9, 0, 20, 7 };

            //array.GetElementsByCondition(IsDivThree);

            int x = 10;

            array.GetElementsByCondition(delegate (int item) // հայտարարում (definition)
            {
                x++;
                return item % 5 == 0;

            }).ForEachElement(Console.WriteLine);

            Console.WriteLine($"x = {x}");
        }
    }
}