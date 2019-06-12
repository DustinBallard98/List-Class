using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_and_Node_Classes_12_12_18_{
    class StackClass{

        public bool Empty = true;
        private NodeClass Head = null;
        private NodeClass Tail = null;
        public int Count {get; private set;} = 0;

    //PUSH()

        public void Push(object New_Dat){

            NodeClass New_Node = new NodeClass(New_Dat);

                Empty = false;

            if (Head == null){
                Head = New_Node;
                Tail = New_Node;
            }else{
                Head.Next = New_Node;
                Head = Head.Next;
            }
            Count++;
        }//end Push

    //POP()

        public object Pop(){
            NodeClass CurrentNode = Tail;
            NodeClass ReturnNode = null;

            while (CurrentNode.Next != Head){

                   CurrentNode = CurrentNode.Next;
                   
            }//end while

            ReturnNode = CurrentNode.Next;

            CurrentNode.Next = null;

            Head = CurrentNode;

            Count--;

            return ReturnNode.Data;

        }//end Pop

    //PEEK()

        public object Peek(){
            return Head.Data;
        }

    //TOSTRING()

        public override string ToString(){

            NodeClass Current_Node = Head;

            int Index = Count;

            string FinalString = "";

            while (Index > 0){
                Current_Node = Head;

                for (int i = 0; i <= Index - 1; i++){

                    if(Current_Node.Next != null){

                        Current_Node = Current_Node.Next;
                    }else{
                        Current_Node = Tail;
                    }//end if

                }//end for
                    FinalString += Current_Node.Data.ToString();
                    FinalString += "\n";
                Index--;
            }//end while

            return FinalString;
            
        }//end tostring()

    }//end class
}//endname
