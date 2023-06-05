using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSortInt
{
    internal class Program
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
            //new string(str.ToArray().Reverse().ToArray()
            // Enumerable.Range(1, 10).Select(x => x * x);
            List<int> listofInts = new List<int>();
            foreach (object item in listOfItems)
            {
                if (item is int)
                    listofInts.Add((int)item);
            }

            return listofInts;
        }
    }
}
