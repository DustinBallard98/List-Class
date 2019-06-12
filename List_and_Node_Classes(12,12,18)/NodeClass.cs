using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_and_Node_Classes_12_12_18_{
    class NodeClass{

        public object Data { get; set; }

        public NodeClass Next;

        public NodeClass(object PassedData = null){

            Data = PassedData;

        }

    }//end class
}//end name
