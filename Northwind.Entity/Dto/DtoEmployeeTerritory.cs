using Northwind.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Northwind.Entity.Dto
{
    public  class DtoEmployeeTerritory:DtoBase
    {
        public int EmployeeId { get; set; }
        public string TerritoryId { get; set; }


    }
}
