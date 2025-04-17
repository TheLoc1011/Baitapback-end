using Lab4;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
namespace Lab4
{
    class Program
    {
        public static List<User> users = new List<User>();
        public static HttpClient client = new HttpClient();
        public static async Task<List<User>> getUsers()
        {
            List<User> result = new List<User>();
            try
            {
                HttpResponseMessage response = await
               client.GetAsync("https://67fd43053da09811b1753a6e.mockapi.io/tttt/users");
                string data = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<List<User>>(data);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"Can not load the data!\nError: {ex.Message}");
            }
        }
        public static void showUsers()
        {
            foreach (var item in users)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Loading...");
            try
            {
                //Get Data
                users = getUsers().Result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Load False!", ex.Message);
            }
            //Show Data
            showUsers();
            Console.WriteLine("Load Success!");
        }
    }
}