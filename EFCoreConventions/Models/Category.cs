using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreConventions.Models
{
	public class Category
	{
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
