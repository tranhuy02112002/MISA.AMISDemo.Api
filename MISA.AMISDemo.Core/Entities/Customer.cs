using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMISDemo.Core.Entities
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public String CustomerCode { get; set;}
        public String FullName  { get; set; }   
    }
}
