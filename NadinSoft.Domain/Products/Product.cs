using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadinSoft.Domain.Products
{
    public class Product
    {
        public ProductId Id { get; private set; }
        public string Name { get;  private set; }
        public DateOnly ProduceDate { get; private set; }
        public string ManufactureEmail { get; set; }
        public string ManufacturePhone { get; set; }
        public bool IsAvailable { get; set; }

    }
}
