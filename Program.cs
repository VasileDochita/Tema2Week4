using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8._1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(2);
            //queue.Dequeue();

           
            Console.ReadLine();
        }
        //public void Methods()
        //{


        //    Queue<char> queue = new Queue<char>();

        //    queue.Enqueue('a');
        //    queue.Enqueue('b');
        //    queue.Enqueue('d');
        //    queue.Enqueue('e');
        //    queue.Enqueue('f');

        //    Console.WriteLine("\n Initial queue: ");

        //    foreach (char c in queue)
        //    {
        //        Console.Write(c + " ");
        //    }



        //    queue.Enqueue('g');

        //    queue.Enqueue('h');

        //    queue.Enqueue('i');

        //    Console.WriteLine();

        //    Console.WriteLine("\n New queue: ");

        //    foreach (char c in queue)
        //    {
        //        Console.Write(c + " ");
        //    }

        //    //Console.WriteLine();


        //    char ch = queue.Dequeue();

        //    Console.WriteLine("\n Dequeueing the first element : {0}", ch);

        //    Console.WriteLine("\n Peek (the next element that would be removed) : {0}", queue.Peek());

        //    ch = queue.Dequeue();

        //    Console.WriteLine("\n Dequeueing the new first element : {0}", ch);

        //    Console.WriteLine("\n number of elements remaining in my queue : " + queue.Count);

        //    Console.WriteLine("\n Removing all elements : ");

        //    Console.WriteLine("\n Does the queue contain the character b? : " + queue.Contains('b'));

        //    Console.WriteLine("Is a = b? => " + 'a'.Equals('b'));

        //    queue.Clear();






        //    Console.ReadLine();
        //}
    }
        
    
}
