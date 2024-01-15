using ViewBotTwitch.Helpers;

namespace ViewBotTwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var proxys = Utils.GetProxysJson<List<Proxys>>();

                if (proxys is not null)
                {
                    foreach (var p in proxys)
                    {
                        RequestMain.RequestChanel(Utils.GenerateRandomUsername(), p.proxy);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        public class Proxys
        {
            public string proxy { get; set; }
        }

        public class ProxyData
        {
            public string Proxy { get; set; }
            public DateTime Time { get; set; }
            public string Url { get; set; }
        }
    }
}
