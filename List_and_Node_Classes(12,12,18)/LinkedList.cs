using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_and_Node_Classes_12_12_18_{
    class LinkedList{

        //create head of List
        private NodeClass Head = null;
        private NodeClass Tail = null;
        public int Count {get; private set;} = 0;


    //indexed 
        public object this[int index]{
            get{
                return GetNodeByIndex(index);
            }//end get
            set{
                SetNodeByIndex(index, value);
            }
        }//end indexor

    //SetNodeBIndex
        public void SetNodeByIndex(int index, object NewData){
            int CurrentIndex = 0;
            NodeClass CurrentNode = Head;

            while (CurrentNode != null){
                if (CurrentIndex == index){
                    CurrentNode.Data = NewData;
                    return;
                }
            }
            throw new Exception("Object not found.");
        }

    //Getnodebyindex
        private object GetNodeByIndex(int SearchIndex){
            int CurrentIndex = 0;
            NodeClass CurrentNode = Head;

            while (CurrentNode != null){
                if (SearchIndex == CurrentIndex){
                    return CurrentNode.Data;
                }
                CurrentNode = CurrentNode.Next;
                CurrentIndex++;
            }//end while
            throw new Exception("Index not found.");
        }//end nodebyindex

    //add Object to list
        public void Add(object new_data){

            NodeClass new_node = new NodeClass (new_data);

            //if head null dont add just reassign head
            if(Head == null){
                Head = new_node;
                Tail = new_node;
            } else {
                //if head is occupied goto end of list and add node
                Tail.Next = new_node;
                Tail = new_node;

            }//end if
            Count++;
        }//end Add method

    //return index of item in list
        public int IndexOf (object SearchData){

            int Loops = 1;
            int Index = -1;

            NodeClass New_Node  = Head;

            while (New_Node.Next != null){
               
                if(New_Node.Data == SearchData){
                    Index = Loops;
                }

                Loops++;
                New_Node = New_Node.Next;
            }//end while

            return Index;

        }//end indexof method

    //remove entry at specific index
        public void Remove(int SearchDat){
            // delete by index

            NodeClass CurrentNode = Head;
            NodeClass Swap = null;
            int Runs = 0;

            if (SearchDat == 0){
                Head = Head.Next;
                Count--;
            }else if (SearchDat == Count){

                while (CurrentNode.Next != null){
                    if (Runs == Count - 1){
                        Swap = CurrentNode.Next;
                        CurrentNode.Next = CurrentNode.Next.Next;
                        Swap = null;
                        Count--;
                        return ;
                    }else{
                    CurrentNode = CurrentNode.Next;
                    Runs++;
                    }

                }//end while

            }else if (SearchDat < 0 || SearchDat > Count){
                throw new Exception("Index outside of bounds!");
            }

            while (CurrentNode.Next != null){
                if (Runs == SearchDat - 1){
                    Swap = CurrentNode.Next;
                    CurrentNode.Next = CurrentNode.Next.Next;
                    Swap = null;
                    Count--;
                    return ;
                }else{
                    CurrentNode = CurrentNode.Next;
                    Runs++;
                }

            }

        }//end remove method

    //clear list
        public void Clear(){

            Head = null;

        }//end clear method

    //create 1 string for list
        public override string ToString(){

            NodeClass Current_Node = Head;
            string FinalString = "[";

            while (Current_Node != null){

                if (Current_Node.Data is string || Current_Node.Data is char){
                    FinalString += "\"";
                    FinalString += Current_Node.Data;
                    FinalString += "\"";
                }else{
                    FinalString += Current_Node.Data;
                }

                if (Current_Node.Next != null){
                    FinalString += ", ";
                }else{
                    FinalString += "]";
                }

                Current_Node = Current_Node.Next;
            }//end while

            return FinalString;
            
        }//end to string

    //Operator: defines what operator does
        public static LinkedList operator +(LinkedList List1, LinkedList List2){
            LinkedList ReturnList = new LinkedList();

            for (int i = 0; i < List1.Count; i++){
                ReturnList.Add(List1[i]);
            }

            for(int x = 0; x < List2.Count; x++){
                ReturnList.Add(List2[x]);
            }

            return ReturnList;
        }//end + operator

    }//end class
}//end name
