using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreConventions.Models
{
	public class CustomerDetail
	{
        public int CustomerDetailId { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; } = null!;

        public string ImageUrl { get; set; }

        public bool EnableTwoFactorAuth { get; set; }
    }
}
