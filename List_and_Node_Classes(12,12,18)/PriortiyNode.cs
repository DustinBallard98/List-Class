using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_and_Node_Classes_12_12_18_{
    class PriortiyNode{

        public object Data { get; set; }

        public PriortiyNode Next;

        public double Priority;

        public PriortiyNode(object PassedData = null, double PassedPrio = 0){

            Data = PassedData;
            Priority = PassedPrio;

        }

    }//end priority Node
}//end namespace
