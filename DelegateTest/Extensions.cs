using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest
{
    delegate bool Condition(int element);
    delegate void SomeAction(int element);

    internal static class Extensions
    {
        public static IEnumerable<int> GetElementsByCondition(this int[] array, Condition condition)
        {
            foreach(int element in array)
            {
                if(condition(element))
                    yield return element;
            }
        }

        public static int[] GetElementsByConditonEx(this int[] array)
        {
            int count = 0;

            foreach (int element in array)
            {
                if (element % 3 == 0)
                    count++;
            }

            int[] newArray = new int[count];

            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0)
                    newArray[j++] = array[i];
            }

            return newArray;
        }

        public static void ForEachElement(this IEnumerable<int> array, SomeAction action)
        {
            foreach (int item in array)
            {
                action(item);
            }
        }
    }
}
