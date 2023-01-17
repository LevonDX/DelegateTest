namespace DelegateTest
{
    delegate void SomeDelegate();

    internal class Program
    {
        static void F1()
        {
            Console.Write("Hello");
        }

        static void F2()
        {
            Console.Write(" World");
        }

        static void Main(string[] args)
        {
            int x = 1;
            object o = x;

            //SomeDelegate del1 = F1;
            //SomeDelegate del2 = F2;

            //SomeDelegate del = Delegate.Combine(del1, del2) as SomeDelegate;

            SomeDelegate del = F1;
            del += F2;
            del += F1;

            del -= F1;

            del(); // del.Invoke();
        }
    }
}