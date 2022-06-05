using System;
namespace Homework
{
	public class Market: IStore
	{
		public Market()
		{
		}

        Product[] IStore.Products { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IStore.ProductLimit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        double IStore.TotalIncome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddProduct(Product product)
        {
            Product[] products = new Product[IStore.Products.Length];
			bool checkNo = true;
            for (int i = 0; i < Products.Length; i++)
            {
                if (product.No == Products[i].No)
                {
					checkNo = false;
					break;
                }
            }
            if (Products.Length < ProductLimit && checkNo ==true)
            {
				Array.Copy(Products, products, Products.Length + 1);
				products[products.Length - 1] = product;

            }
			Products = products;
        }
    }
}

