using System;
namespace Homework12
{
	public interface IStore
	{


		public Product[] Products { set; get; }
		public int ProductLimit { set; get; }
		public double TotalIncome { set; get; }

		void AddProduct(Product product);

		void SellProduct(string noStr);
	


		
	}
}

