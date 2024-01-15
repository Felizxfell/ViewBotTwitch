using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewBotTwitch.Helpers
{
    public class Utils
    {
        public static string GenerateRandomUsername()
        {
            Random random = new Random();
            const string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            int usernameLength = random.Next(6, 12); // Puedes ajustar la longitud del nombre de usuario

            char[] usernameChars = new char[usernameLength];

            for (int i = 0; i < usernameLength; i++)
            {
                usernameChars[i] = allowedChars[random.Next(allowedChars.Length)];
            }

            string username = new string(usernameChars);
            return username;
        }

        public static T? GetProxysJson<T>()
        {
            //string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string filePath = Path.Combine("resources", "Proxys.json");//we create path of file json

            //if (!File.Exists(filePath))//we verify that exist the file 
            //    return default(T);

            string jsonstring = File.ReadAllText(filePath, Encoding.UTF8);//we read the file json

            var basesname = JsonConvert.DeserializeObject<T>(jsonstring);//we deserealize the json to an object

            return basesname;//returns the object
        }
    }
}
