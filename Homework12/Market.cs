using System;
namespace Homework12
{
	public class Market: IStore
	{
		public Market()
		{
		}
        private Product[] _products;
        private int _productLimit;
        private double _totalIncome;

        public Product[] Products { get => _products; set => value = _products; }
        public int ProductLimit { get => _productLimit; set => value = _productLimit; }
		public double TotalIncome { get => _totalIncome; set => value = _totalIncome; }

        public void AddProduct(Product product)
        {
            bool checkNo = true;
            
            for (int i = 0; i < Products.Length; i++)
            {
                if (product.No ==Products[i].No)
                {
                    checkNo = false;
                    break;
                }
            }
            if (ProductLimit < Products.Length && checkNo ==true)
            {
                Product[] productArray = new Product[Products.Length + 1];
                productArray[productArray.Length - 1] = product;
                Products = productArray;
            }
        }

        public void SellProduct(string noStr)
        {
            int no = Convert.ToInt32(noStr);          
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No == no && Products[i].Count !=0)
                {
                    TotalIncome += Products[i].Price;
                    Products[i].Count--;
                    break;
                }
            }

        }
    }
}

