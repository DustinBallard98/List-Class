using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_and_Node_Classes_12_12_18_{
    class DynamicQueue{

        public int Count = 0;
        public bool Empty = true;
        private PriortiyNode Head = null;
        private PriortiyNode Tail = null;
    //PEEK MAX

           public double Peek_Max(){
                
                PriortiyNode CurrentNode = Tail;
                int Index = 0;
                double LargestPriority = -1000;

            if (CurrentNode == null){
                throw new Exception("Queue is empty please try again.");
            }

                while (Index <= Count){

                    if (CurrentNode.Priority > LargestPriority){
                        LargestPriority = CurrentNode.Priority;
                    }//end if

                    if (CurrentNode.Next != null){
                        CurrentNode = CurrentNode.Next;
                    }//end if

                    Index++;

                }//end while

                return LargestPriority;
                 
            }//end peek_max
    //PEEK MIN

           public double Peek_Min(){
           
                PriortiyNode CurrentNode = Tail;
                int Index = 0;
                double SmallestPriority = 1000;

            if (CurrentNode == null){
                throw new Exception("Queue is empty please try again.");
            }

                while (Index <= Count){

                    if (CurrentNode.Priority < SmallestPriority){
                        SmallestPriority = CurrentNode.Priority;
                    }//end if

                    if (CurrentNode.Next != null){
                        CurrentNode = CurrentNode.Next;
                    }//end if

                    Index++;
                }//end while

                return SmallestPriority;
           
           }//end Peek_min
    //ENQUEUE

           public void Enqueue(Object Data = null, double Priority = 0){
             
                PriortiyNode New_Node = new PriortiyNode(Data,Priority);

                Empty = false;

                 if (Head == null){
                     Head = New_Node;
                     Tail = New_Node;
                 }else{
                     Head.Next = New_Node;
                     Head = Head.Next;
                 }
                 Count++;

            }//end Enqueue
    //DEQUEUE

           public object Dequeue(){
            
                 PriortiyNode CurrentNode = Tail;
                 PriortiyNode ReturnNode = null;

               


                   if(CurrentNode.Next != null) {
                   
                       while (CurrentNode.Next != Head){
               
                              CurrentNode = CurrentNode.Next;
                              
                       }//end while
               
                   }else{
                       
                       Tail = null;
                       Head = null;
               
                       return CurrentNode.Data;
               
                   }
               
               
                    ReturnNode = CurrentNode.Next;
               
                    CurrentNode.Next = null;
               
                    Head = CurrentNode;
               
                    Count--;
               
                
               if(Count == 0){

                    Empty = true;
               }
                
                   return ReturnNode.Data;
                
               //throw new Exception("Queue is empty please try again.");
            
           }//end Dequeue
    //DEQUEUE MIN

           public object Dequeue_min(){
            
                PriortiyNode CurrentNode = Tail;
                PriortiyNode PlaceHolder_Node = null;
                int Index = 0;
                int Smallest = 0;
                double SmallestPriority = 1000;


                    while (CurrentNode.Next != null){

                        if (CurrentNode.Priority < SmallestPriority){
                            SmallestPriority = CurrentNode.Priority;
                            Smallest = Index;
                        }//end if
                        
                        CurrentNode = CurrentNode.Next;
                        Index++;
                    }//end while

                    CurrentNode = Tail;
                    Index = 0;

                    while (Index <= Smallest - 1){

                        if (CurrentNode.Next.Priority == SmallestPriority){
                            PlaceHolder_Node = CurrentNode.Next;
                        }else if (CurrentNode.Next != null) {
                            CurrentNode = CurrentNode.Next;
                        }//end if

                        Index++;
                    }//end while

                    if(Index == 0){
                        PlaceHolder_Node = CurrentNode;
                        Tail = CurrentNode.Next;
                    } else if(CurrentNode.Next == null){ 
                        Head = CurrentNode;

                    }else {
                       CurrentNode.Next = CurrentNode.Next.Next;
                        Head = CurrentNode;
                    }

                    Count--;
                
                if(Count == 0){
                    Empty = true;
                }

                    return PlaceHolder_Node.Data;
               
           }//end Dequeue_min
    //DEQUEUE MAX

           public object Dequeue_max(){
            
                PriortiyNode CurrentNode = Tail;
                PriortiyNode PlaceHolder_Node = null;
                int Index = 0;
                int Largest = 0;
                double LargestPriority = -1000;

                         while (CurrentNode.Next != null){

                             if (CurrentNode.Priority > LargestPriority){
                                 LargestPriority = CurrentNode.Priority;
                                 Largest = Index;
                             }//end if

                             CurrentNode = CurrentNode.Next;
                             Index++;
                         }//end while

                         CurrentNode = Tail;
                         Index = 0;
                
                         while (Index <= Largest - 1){

                             if (CurrentNode.Next.Priority == LargestPriority){
                                 PlaceHolder_Node = CurrentNode.Next;
                             }else if (CurrentNode.Next != null) {
                                 CurrentNode = CurrentNode.Next;
                             }//end if

                             Index++;
                         }//end while

                         

                         if(Index == 0){
                             PlaceHolder_Node = CurrentNode;
                             Tail = CurrentNode.Next;
                         }

                         if (CurrentNode.Next == null){ 
                             Head = CurrentNode;

                         }else {
                            CurrentNode.Next = CurrentNode.Next.Next;
                             Head = CurrentNode;
                         }

                         Count--;

                if(Count == 0){

                   Empty = true;
                }

                return PlaceHolder_Node.Data;

                //throw new Exception("Queue is empty please try again.");
            }///end Dequeue_max

        }//end class
}//end name
