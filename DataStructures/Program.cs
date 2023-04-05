using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Linear Data Structures 
            //int[] p = { 1, 2, 12, 3, 4, 4, 5, 4, 5 };
            //List<int> list = new List<int>(50);
            //list.Add(1);
            //list.AddRange(p);


            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add("hello");

            //Stacks and Queues


            //Generic Stacks 
            Stack stack = new Stack();
            stack.Push("John");
            stack.Push(1);
            stack.Push(5f);
            stack.Push(12);

            stack.Push(new Person("James", 1));


            Person personP = (Person)stack.Pop();
            Console.WriteLine(personP.Id);

            //Removing an element from the stack 
            var remElement = stack.Pop(); //remove an element 

            ////Peek(); return the topmost element of the stack without removing it 
            Console.WriteLine($"{stack.Peek()}");


            while (stack.Count > 0)
            {
                Console.WriteLine(stack);
                
            }

            //Generic queue
            Queue queue = new Queue ();
            queue.Enqueue(1);   
            queue.Enqueue("hello");

            Console.WriteLine();

            Console.WriteLine(queue.Count);

            //Remove and element from the queue
            var remElement2 = queue.Dequeue();
            foreach ( var item in queue )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(item);
            }

          
        }

        class Person
        {
            public string Name { get; set; }
            public int Id { get; set; }

            public Person(string Name, int Id) { 
                this.Name = Name;
                this.Id = Id;
            }
        }
    }
}
