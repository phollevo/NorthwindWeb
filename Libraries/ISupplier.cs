﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Libraries
{
    [ServiceContract]
    public interface ISupplier
    {
        [OperationContract]
        List<Supplier> searchSuppliers();

        [OperationContract]
        Supplier seeDatails(int Id);

        [OperationContract]
        Boolean modify(Supplier supplier);

        [OperationContract]
        Boolean delete(int id);
    }
}
