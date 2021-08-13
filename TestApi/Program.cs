using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

using System.Text.Json;

namespace TestApi
{
    class Program
    {
        static void Main(string[] args)
        {
            //"https://api.weather.gov/gridpoints/LWX/96,70/forecast"
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.weather.gov/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("User-Agent", "C# Application");

                HttpResponseMessage httpResponseMessage = client.GetAsync("gridpoints/LWX/96,70/forecast").Result;

                try
                {
                    httpResponseMessage.EnsureSuccessStatusCode();

                    string json = httpResponseMessage.Content.ReadAsStringAsync().Result;

                    JsonDocument jsonDocument = JsonDocument.Parse(json);
                    JsonElement rootElement = jsonDocument.RootElement;

                    JsonElement properties = rootElement.GetProperty("properties");
                    JsonElement periods = properties.GetProperty("periods");

                    IEnumerable<Period> periodsResult = JsonSerializer.Deserialize<Period[]>(periods.ToString(), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

                    foreach (Period period in periodsResult)
                    {
                        Console.WriteLine($"{period.Number} : {period.ShortForecast}");
                    }

                    Console.WriteLine(json);
                }
                catch (Exception)
                {
                    throw;
                }
                

                
            }


        }
    }
}
