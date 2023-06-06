using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSortInt
{
    internal class Task13me
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ListFilterer.GetIntegersFromList(new List<object>() { 1, 2, "a", "b" }));
        }
    }
    public class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> listofInts = new List<int>();
            foreach (object item in listOfItems)
            {
                if (item is int)
                {
                    listofInts.Add((int)item);
                }
            }

            return listofInts;
        }
    }
    public class ListFilterer1 // ответ с сайта
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            return listOfItems.OfType<int>();
        }
    }
}
