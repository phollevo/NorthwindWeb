using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Libraries
{
    [DataContract]
    public class Supplier
    {
        [DataMember]
        public long id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string contactName { get; set; }

        [DataMember]
        public string contactTitle { get; set; }

        [DataMember]
        public string address { get; set; }

        [DataMember]
        public string ville { get; set; }

        [DataMember]
        public string region { get; set; }

        [DataMember]
        public string country { get; set; }

        [DataMember]
        public string tel { get; set; }

        [DataMember]
        public string fax { get; set; }

        [DataMember]
        public string webSite { get; set; }
    }
}