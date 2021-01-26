using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMethods19Jan
{
    class ListOfMethods //18 methods
    {
        static void Main(string[] args)
        {
            List<int> evenNumber = new List<int>();

            //Add
            evenNumber.Add(2);
            evenNumber.Add(4);
            evenNumber.Add(6);
            evenNumber.Add(12);
            evenNumber.Add(18);
            evenNumber.Add(10);
            evenNumber.Add(16);
            evenNumber.Add(12);
            evenNumber.Add(8);
            evenNumber.Add(14);
            evenNumber.Add(20);

            int p = 0;
            foreach (var item in evenNumber)
            {
                Console.Write("At position {0} : " , p);
                Console.WriteLine(item);
                p++;
            }

            //Sort
            evenNumber.Sort();
            Console.WriteLine("\nAfter Sorting the list");
            int k = 0;
            foreach (var item in evenNumber)
            {
                Console.Write("At position {0} : ", k);
                Console.WriteLine(item);
                k++;
            }

            //Capacity
            Console.WriteLine($"\nCapacity of the list is : {evenNumber.Capacity}");

            //Count
            Console.WriteLine($"\nNumber of elements in the list is : {evenNumber.Count}");

            //Contains
            Console.WriteLine($"\nDoes the list contains element 5? {evenNumber.Contains(5)}");

            //CopyTo
            Console.WriteLine("\nUsing CopyTo method");
            int[] myArr = new int[evenNumber.Count];
            evenNumber.CopyTo(myArr, 0);
            foreach (var copy in evenNumber)
            {
                Console.WriteLine(copy);
            }

            //Insert
            evenNumber.Insert(4, 100);
            Console.WriteLine("\nAfter inserting element at the index 4");
            foreach (var rem in evenNumber)
            {
                Console.WriteLine(rem);
            }

            //InsertRange
            var newArr = new int[] {200,300,400,500};
            evenNumber.InsertRange(4, newArr);
            Console.WriteLine("\nAfter inserting range of elements in the list");
            foreach (var rem in evenNumber)
            {
                Console.WriteLine(rem);
            }

            //Remove
            evenNumber.Remove(100);
            Console.WriteLine("\nAfter removing element 100 from the list");
            foreach (var item in evenNumber)
            {
                Console.WriteLine(item);
            }

            //RemoveAt
            evenNumber.RemoveAt(0);
            Console.WriteLine("\nAfter removing element from the index 0");
            foreach (var rem in evenNumber)
            {
                Console.WriteLine(rem);
            }

            //RemoveRange
            evenNumber.RemoveRange(5, 2);
            Console.WriteLine("\nAfter removing range of elements from the list");
            foreach (var rem in evenNumber)
            {
                Console.WriteLine(rem);
            }

            //IndexOf
            int idx = evenNumber.IndexOf(8);
            Console.WriteLine($"\nIndex of element 8 : {idx}");

            //Find
            Console.WriteLine($"\nFinding 1st occurrence of 6 : {evenNumber.Find((x) => x == 6)}"); //parameter to method

            //FindAll
            Console.WriteLine($"\nFinding all even numbers in the list");
            List<int> res = evenNumber.FindAll(x => x % 2 == 0);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            //FindIndex
            Console.WriteLine($"\nFirst Index of 12 : {evenNumber.FindIndex(x => x == 12)}");

            //FindLastIndex
            Console.WriteLine($"\nLast Index of 12 : {evenNumber.FindLastIndex(x => x == 12)}");

            //GetEnumerator
            Console.WriteLine("\nBefore using Clear method");
            List<int>.Enumerator em = evenNumber.GetEnumerator();
            while (em.MoveNext())
            {
                Console.WriteLine(em.Current);
            }

            //Clear
            evenNumber.Clear();
            Console.WriteLine("\nAfter using Clear method");
            List<int>.Enumerator cl = evenNumber.GetEnumerator();
            while (cl.MoveNext())
            {
                Console.WriteLine(cl.Current);
            }

            Console.ReadLine();
        }
    }
}
