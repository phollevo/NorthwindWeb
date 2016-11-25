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
        public long id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public long categorie { get; set; }

        [DataMember]
        public long supplier { get; set; }

        [DataMember]
        public string quantityPerUnit { get; set; }

        [DataMember]
        public long reorderLevel{ get; set;}

        [DataMember]
        public string discontinued { get; set; }
    }
}
