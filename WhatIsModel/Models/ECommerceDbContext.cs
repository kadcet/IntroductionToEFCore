using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsModel.Models
{
	public class ECommerceDbContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Server=.;Database=WhatisModelDb;Integrated Security=true;TrustServerCertificate=true");
			//optionsBuilder.UseSqlServer("Server=.;Database=WhatisModelDb;user id=sa;Password=123456!a;TrustServerCertificate");
		}

        public DbSet<Category> Categories { get; set; }

        //public DbSet<Product> Products { get; set; }
    }
}
