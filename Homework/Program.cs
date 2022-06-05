using System;

namespace Homework
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
            Console.Write("Neyi secirsen?");
            string answer = Console.ReadLine();

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

                    Market.AddProduct(product);


                    
                default:
                    break;
            }







            //1 seçildikdə console bizdən productın yaradılması üçün lazım olan datalrı
            //daxil etməyimizi istəməlidir(No, Name, Price, Count).Daha sonra həmin dəyərlər
            //əsasında bir product yaradıb market obyektimizin AddProduct metodunu işə salır.


            //2 seçildikdə console bizdən satmaq istədiyimiz productın no dəyərini yazmağımızı
            //istəyir.Onu yazdıqdan sonra market obyektimizin Sell metodunu işə salır


            //3 seçildikdə marketdəki bütün məhsullar console-da göstərilir (adları, qiymətləri,
            //nömrələri və sayları)


            //Bu 3 seçimdən hər hansı biri seçilsə uyğun proses icra olub bitidkdən sonra yenidən
            //eyni menu pəncərəsi açılmalıdır.


            //4 seçilərsə menudan çıxır və proqram bitir.
        }
    }
}

