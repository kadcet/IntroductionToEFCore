using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreConventions.Models
{
	public class Customer
	{
		public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string CustomerEmail { get; set; }

        public ICollection<Order> Orders { get; set; }

        public CustomerDetail? CustomerDetail { get; set; }
    }
}
