using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Libraries
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public Categorie categorie { get; set; }

        [DataMember]
        public Supplier supplier { get; set; }

        [DataMember]
        public string quantityPerUnit { get; set; }

        [DataMember]
        public int reorderLevel{ get; set;}

        [DataMember]
        public bool discontinued { get; set; }
    }
}
