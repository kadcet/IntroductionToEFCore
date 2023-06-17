using WhatIsModel.Models;

namespace WhatIsModel
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ECommerceDbContext context = new ECommerceDbContext();
			if (context.Database.EnsureCreated())
			{
				if (!context.Categories.Any())
				{
					context.Categories.Add(new Category { Name = "GSM" });
					context.Categories.Add(new Category { Name = "Bilgisayar" });
					context.Categories.Add(new Category { Name = "Aksesuar" });
					context.SaveChanges();
				}
			}
			else
			{
				MessageBox.Show("Db Oluþturulamadý");
			}


		}
	}
}