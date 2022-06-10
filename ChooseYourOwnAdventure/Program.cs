using System;

namespace VotingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product()
            {
                Name = "Kitab",
                Rating = 5
            };

            Product product2 = new Product()
            {
                Name = "Stol",
                Rating = 3.5
            };

            Product product3 = new Product()
            {
                Name = "Spirt",
                Rating = 4
            };

            Product[] productList = new Product[] { product1, product2, product3 };

            string answer;
            do
            {
                Console.WriteLine("1. Ratinglere product elave ele...");
                Console.WriteLine("2. Olan productlara ve ratinglerine bax...");
                Console.WriteLine("3. Productu rate ele...");
                Console.WriteLine("0. Menudan cix...");
                Console.WriteLine("____________________________________");
                Console.WriteLine(" ");
                do
                {
                    Console.Write("Secimini ele");
                    answer = Console.ReadLine();

                } while ((answer != "1" && answer != "2" && answer != "3" && answer != "0") || answer == null);

                if (answer == "1")
                {
                    AddProduct(productList);
                    Console.WriteLine("Productun elave olundu..");
                } else if(answer == "2")
                {
                    Console.WriteLine("---------------------------------");
                    ShowProducts(productList);
                    Console.WriteLine("---------------------------------");
                } else if(answer == "3")
                {

                }
                else
                {

                }


            } while (answer != "0");
        }

        public static Product[] AddProduct(Product[] productos)
        {
            Product product = new Product();

            Console.Write("Productun adini yaz...");
            string productName = Console.ReadLine();

            Console.Write("Productun ratingini yaz...");
            string productRatingStr = Console.ReadLine();

            bool checkParse = double.TryParse(productRatingStr, out double productRating);

            if (!string.IsNullOrWhiteSpace(productName) && !string.IsNullOrWhiteSpace(productRatingStr) && checkParse == true)
            {

                product.Name = productName;
                product.Rating = productRating;

                Array.Resize(ref productos, productos.Length + 1);
                productos[productos.Length - 1] = product;
                
            }
            return productos;

        }

        public static void ShowProducts(Product[] productos)
        {
            foreach (var product in productos)
            {
                Console.WriteLine($"Product: {product.Name}, Rating: {product.Rating} ");
            }
        }
    }
}

