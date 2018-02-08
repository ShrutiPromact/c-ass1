using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1c
{
    class Program
    {
        static void Main(string[] args)
        {

            IList<Product> productList = new List<Product>() {
                new Product(){ pName="lettuce", price=10.5, quantity=50,type="Leafy green"},
               new Product(){ pName="cabbage", price=20, quantity=100,type="Cruciferous"},
                new Product(){ pName="pumpkin", price=30, quantity=30,type="Marrow"},
                new Product(){ pName="cauliflower", price=10, quantity=25,type="Cruciferous"},
                new Product(){ pName="zucchini", price=20.5, quantity=50,type="Marrow"},
                new Product(){ pName="yam", price=30, quantity=50,type="Root"},
                 new Product(){ pName="spinach", price=10, quantity=100,type="Leafy green"},
                new Product(){ pName="broccoli", price=20.2, quantity=75,type="Cruciferous"},
                new Product(){ pName="Garlic", price=30, quantity=20,type="Leafy green"},
                new Product(){ pName="silverbeet", price=10, quantity=50,type="Marrow"},

            };
            int count = productList.Count;
            Console.WriteLine("Total no of products=" + count);


            productList.Add(new Product() { pName = "Potato", price = 10, quantity = 50, type = "Root" });
            Console.WriteLine("Total no of products=" + productList.Count);


            Console.WriteLine("The Type leafy caabage are:");
            var leafy = productList.Where(x => x.type == "Leafy green").ToList();
            foreach (var pr in leafy)
            Console.WriteLine(pr.pName);
            Console.WriteLine();

            productList.RemoveAt(8);
            foreach (Product item in productList)
            {

                Console.WriteLine("Name: " + item.pName + "; price: " + item.price + "; quantity: " + item.quantity + "; type: " + item.type);

            }

         

            Console.ReadKey();
        }
    }
}
