using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Core.Enitites
{
    public class Customer:BaseEntity
    {
        public string Name { get; set; }

        public string Email { get; set; }
    }
}
