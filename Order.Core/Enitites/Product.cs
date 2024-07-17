using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Core.Enitites
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }

        public float Price { get; set; }
        public bool Stock { get; set; }

    }
}
