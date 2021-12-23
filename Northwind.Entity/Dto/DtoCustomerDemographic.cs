using Northwind.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Northwind.Entity.Dto
{
    public  class DtoCustomerDemographic:DtoBase
    {

        public string CustomerTypeId { get; set; }
        public string CustomerDesc { get; set; }

       
    }
}
