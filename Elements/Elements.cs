using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Elements
{
    //[DataContract]
    public class Elements
    {
        //[DataMember]
        public int AtomicNum { get; set; }
        //[DataMember]
        public string Name { get; set; }
        //[DataMember]
        public string Symbol { get; set; }
        //[DataMember]
        public string Description { get; set; }

        public Elements(int atmNum, string symb, string name, string desc)
        {
            AtomicNum = atmNum;
            Name = name;
            Symbol = symb;
            Description = desc;
        }

    }
}
