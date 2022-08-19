using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
  public class Product:IEntity
    {
        public int ProductId   { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int UnitInStock { get; set; }
        public int UnitPrice { get; set; }
    }
}
