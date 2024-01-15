using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ViewBotTwitch
{
    public class RequestMain
    {
        private static readonly string _URL = "https://www.twitch.tv/tujefeef";

        public static void RequestChanel(string userAgent, string proxy)
        {
            try
            {
                using HttpClientHandler handler = new HttpClientHandler();

                handler.Proxy = new WebProxy($"http://{proxy}");
                handler.UseProxy = true;

                using var httpClient = new HttpClient(handler);

                var response = httpClient.SendAsync(
                        new HttpRequestMessage(HttpMethod.Head, _URL)
                        {
                            Headers = {
                                { "Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8" },
                                { "Accept-Encoding", "gzip, deflate, br" },
                                { "Accept-Language", "es-419,es;q=0.6" },
                                { "Cache-Control", "max-age=0" },
                                { "Connection", "keep-alive" },
                                { "Cookie", "unique_id=atBMZK4d7yAwu9rTPAZOZ0zV8pIqcs7K; unique_id_durable=atBMZK4d7yAwu9rTPAZOZ0zV8pIqcs7K; twitch.lohp.countryCode=MX; experiment_overrides={%22experiments%22:{}%2C%22disabled%22:[]}; api_token=twilight.fdda4314c58c05aa08e792f18fa984be; server_session_id=2aa0aa39c8994f4b8ac607c9210f2d1d" },
                                { "Host", "www.twitch.tv" },
                                { "Sec-Fetch-Dest", "document" },
                                { "Sec-Fetch-Mode", "navigate" },
                                { "Sec-Fetch-Site", "same-origin" },
                                { "Sec-Fetch-User", "?1" },
                                { "Sec-GPC", "1" },
                                { "Upgrade-Insecure-Requests", "1" },
                                { "User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36" },
                                { "sec-ch-ua", "'Not_A Brand';v='8', 'Chromium';v='120', 'Brave';v='120'" },
                                { "sec-ch-ua-mobile", "?0" },
                                { "sec-ch-ua-platform", "Windows" },
                            }
                        }
                    ).Result;

                httpClient.Dispose();

                Console.WriteLine($"Respuesta --> ${response}");

                Thread.Sleep(5000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
