﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace NorthWindServices
{
    [DataContract]
    public class Supplier
    {
        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string country { get; set; }

        [DataMember]
        public string contact { get; set; }
    }
}