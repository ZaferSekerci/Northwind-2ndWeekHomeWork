using Northwind.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Northwind.Entity.Dto
{
    public  class DtoShipper:DtoBase
    {
        
        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

    }
}
