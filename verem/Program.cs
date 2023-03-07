using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verem
{
    class Program
    {
        static Stack<int> verem = new Stack<int>();
        static void Main(string[] args)
        {
            verem.Push(11);
            verem.Push(12);
            verem.Push(9);

            Console.WriteLine(verem.Peek());

            //Console.WriteLine(verem.Pop()); 
            //Console.WriteLine(verem.Pop()); 
            //Console.WriteLine(verem.Pop()); 

            //verem.Clear();

            //while (verem.Count > 0)
            //{
            //    Console.WriteLine(verem.Pop());
            //}

            Kiiratas();

            Console.ReadKey();
        }

        static void Kiiratas()
        {
            foreach (var item in verem)
            {
                Console.WriteLine(item);
            }
        }
    }
}
