using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_and_Node_Classes_12_12_18_ {
    class Program {
        static void Main(string[] args) {

           //LinkedList List1 = new LinkedList();
           //LinkedList List2 = new LinkedList();
           // 
           // List1.Add(1);
           // List1.Add(2);
           // List1.Add(3);
           // List1.Add(4);
           // List1.Add(5);
           // List1.Add("a");
           // List1.Add('b');
           // List1.Add(12);
           //
           // List2.Add(10);
           // List2.Add("k");
           // 
           // List1.Remove(1);
           //
           // Console.WriteLine(List1+ List2);
           
            //StackClass New_Stack = new StackClass();

            //New_Stack.Push(1);
            //New_Stack.Push(12);
            //New_Stack.Push(13);
            //New_Stack.Push("Peggy");
            //New_Stack.Push("Hill");
            //New_Stack.Push("got big feet.");


            //Console.WriteLine(New_Stack.Peek());

            //Console.WriteLine();

            //Console.WriteLine(New_Stack.ToString());

            //object Data = New_Stack.Pop();

            //Console.WriteLine(New_Stack.ToString());

            //Console.WriteLine(New_Stack.Peek());

           // while (!New_Stack.Empty) {

                 //New_Stack.Empty = true;
           // }

            DynamicQueue New_Que = new DynamicQueue();


            Random rand = new Random();

            for (int x = 0 ; x < 256; x += 1) {

                New_Que.Enqueue(rand.Next(0,100), rand.Next(int.MinValue , int.MaxValue )) ;

            }


            while (New_Que.Empty == false )
            {
                if (rand.Next(1,100) < 50 ){
                    Console.WriteLine(New_Que.Dequeue_min());
                   // New_Que.Dequeue_min();

                }else{
                    Console.WriteLine(New_Que.Dequeue_max());
                   // New_Que.Dequeue_max();
                }
            }
            //New_Que.Enqueue(100,1.00);
            //New_Que.Enqueue(90 ,0.90);
            //New_Que.Enqueue(80 ,0.80);
            //New_Que.Enqueue(70 ,0.70);
            //
            //Console.WriteLine(New_Que.Peek_Max());
            //Console.WriteLine(New_Que.Peek_Min());
            //Console.WriteLine(New_Que.Dequeue_min());
            //Console.WriteLine(New_Que.Dequeue());
            //Console.WriteLine(New_Que.Dequeue_max());
            //Console.WriteLine(New_Que.Dequeue());
            ////Console.WriteLine(New_Que.Dequeue());

            Console.ReadKey();

        }//end main
    }//end class
}//end namespace
