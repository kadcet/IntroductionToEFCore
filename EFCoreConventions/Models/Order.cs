﻿namespace EFCoreConventions.Models
{
	public class Order
	{
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int CustomerId { get; set; }
    }
}