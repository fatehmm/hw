using System;

namespace Homework12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("> 1. Product elave et.");
            Console.WriteLine("> 2. Product sat");
            Console.WriteLine("> 3. Productlara bax.");
            Console.WriteLine("> 4. Menudan cix.");
            Console.WriteLine(" ");
            //Console.Write("Neyi secirsen?");
            string answer;
            do
            {
                Console.Write("Neyi secirsen?");
                answer = Console.ReadLine();

            } while (answer != "1" && answer != "2" && answer != "3" && answer != "4");
            

            Product product1 = new Product
            {
                Name = "TV",
                Count = 5,
                No = 123212,
                Price = 1000
            };

            Product product2 = new Product
            {
                Name = "AC",
                Count = 3,
                No = 432178,
                Price = 500
            };

            Product product3 = new Product
            {
                Name = "Book",
                Count = 34,
                No = 904578,
                Price = 5
            };

            Product[] produucts = { product2, product1, product3 };

            Market market = new Market
            {
                Products = produucts,
                ProductLimit = 30,
                TotalIncome = 0
            };


                switch (answer)
                {
                    case "1":
                        Console.Write("Productun nomresini daxil ele...");
                        int productNo = int.Parse(Console.ReadLine());
                        Console.Write("Productun adini daxil ele...");
                        string productName = Console.ReadLine();
                        Console.Write("Productun price ini daxil ele...");
                        double productPrice = double.Parse(Console.ReadLine());
                        Console.WriteLine("Productdan nece dene var?...");
                        int productCount = int.Parse(Console.ReadLine());


                        Product product = new Product()
                        {
                            No = productNo,
                            Name = productName,
                            Price = productPrice,
                            Count = productCount
                        };

                        market.AddProduct(product);
                    break;


                    case "2":
                        Console.Write("Satmaq istediyin productun nomresini yaz...");
                        string no = Console.ReadLine();
                        market.SellProduct(no);
                    break;


                    case "3":
                        ShowProducts(market.Products);
                    break;

                    case "4":
                    return;
                    

                    default:
                        
                        break;







                }

            static void ShowProducts(Product[] products)
            {
                foreach (var item in products)
                {
                    Console.WriteLine($"Product No:{item.No} {item.Name},  Price: {item.Price} -- Count: {item.Count}");
                }
            }
            
        }
    }
}

