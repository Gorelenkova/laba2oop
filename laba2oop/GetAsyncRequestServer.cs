using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace laba2oop
{
    public class GetAsyncRequestServer : GetRequest
    {
        private Uri uri {  get; set; }
        public void SetUri()
        {
            Console.WriteLine("Введите URI:");
            string uriString;
            uriString = Console.ReadLine();
            if (Uri.TryCreate(uriString, UriKind.Absolute, out Uri Myuri))
            {
                this.uri = Myuri;
            }
            else
            {
                Console.WriteLine("Некорректный ввод данных");
            }
        }
        public async Task Get()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var result = await client.GetAsync(uri);
                    var json = result.Content.ReadAsStringAsync().Result;
                    Console.WriteLine(json);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
             
            }
        }
    }
}
