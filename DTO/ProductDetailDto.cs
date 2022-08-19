using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTO
{
    public class ProductDetailDto:IDto
    {
        public int ProductId { get; set; }
       
        public string CategoryName { get; set; }
        public int ProductName { get; set; }
        public int UnitPrice { get; set; }
    }
}
