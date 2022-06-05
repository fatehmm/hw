using System;
namespace Homework
{
	public interface IStore
	{
		Product[] Products { get; set; }
		
		public int ProductLimit { get; set; }

		public double TotalIncome { get; set; }

		public void AddProduct(Product product);
		

		public void SellProduct(string noStr)
        {
			double dummyIncome = TotalIncome;
			int no = Convert.ToInt32(noStr);
            for (int i = 0; i < Products.Length; i++)
            {
                if (no == Products[i].No && Products[i].Count != 0)
                {
					dummyIncome += Products[i].Price;
					Products[i].Count--;
					break;
                }
            }
			TotalIncome = dummyIncome;
        }
	}
	 
}

