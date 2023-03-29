using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int i in arr)
            {
                if (!list.Contains(i))
                {
                    list.Add(i);
                }
            }
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
