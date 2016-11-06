using labo5.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace labo5.DataAccessObject
{
    class WeatherService
    {
        public async Task<IEnumerable<WeatherForecast>> GetForecast()
        {
            // creation d'un client http
            var wc = new HttpClient();
            // récupération via la requette http et l'uri de notre objet json
            // notifié await pour lancer ceci sur un autre thread pour éviter que cela soit trop lent
            var weather = await wc.GetStringAsync(new Uri("api.openweathermap.org/data/2.5/forecast/city?id=2790472&APPID=1523711503b3ff5dda928d734c87b5be"));
            // changement de ce json en un objet via la parse des balises
            var rawWeather = JObject.Parse(weather);
            //récupération des enfants de l'objet json en selectionnant balise par balise
            var forecast = rawWeather["list"].Children().Select(d => new WeatherForecast()
            {
                Date = d["dt_txt"].Value<DateTime>(),
                MinTemp = d["main"]["temp_min"].Value<double>(),
                MaxTemp = d["main"]["temp_max"].Value<double>(),
                WeatherDescription = d["weather"].First["description"].Value<String>(),
                WindSpeed = d["wind"]["speed"].Value<double>()
            });
            return forecast;
        }
    }
}
