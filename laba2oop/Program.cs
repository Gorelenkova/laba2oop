using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace laba2oop
{
    internal class Program
    {
        //Uri uri1 = new Uri("https://dummyjson.com/products");
        //Uri uri2 = new Uri("https://dummyjson.com/products/1");
        //Uri uri3 = new Uri("https://dummyjson.com/products/2");
        static void Main(string[] args)
        {          
                Console.WriteLine("Какой запрос хотите сделать?");
                Console.WriteLine("1 - синхронный");
                Console.WriteLine("2 - асинхронный");
                int a;
                a = Convert.ToInt32(Console.ReadLine());
                WriteRequest request = new WriteRequest();
                switch (a)
                {
                    case 1:

                        request.WriteSyncRequest();
                        break;
                    case 2:
                        request.WriteAsyncRequest();
                        break;
                    
                }     
            Console.ReadKey();
        }
    }
}
