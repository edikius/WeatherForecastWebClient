using System;
using System.Collections.Generic;
using System.Text;
using WeatherForecastWebClient.Endpoints;
using WeatherForecastWebClient.Models;
using WeatherForecastWebClient.Output;
using WeatherForecastWebClient.Parser;
using WeatherForecastWebClient.POCO;

namespace WeatherForecastWebClient.Controllers
{
    class Weather2020Controller : Controller
    {
        private Weather2020Endpoint weather2020Endpoint;

        public Weather2020Controller() : base()
        {
            this.weather2020Endpoint = new Weather2020Endpoint();
        }


        public List<Weather2020Forecast> getForecastList(double latitude, double longitude)
        {
            List<Weather2020Forecast> forecastList = new List<Weather2020Forecast>();
            Out output = new Out();
            restClient.endpoint = weather2020Endpoint.getConditions(latitude, longitude);
            string response = restClient.makeRequest();
            output.outputToConsole($"{response}");
            

            JSONParser<Weather2020Model> jsonParser = new JSONParser<Weather2020Model>();

            Weather2020Model deserialisedWeather2020Model = new Weather2020Model();
            deserialisedWeather2020Model =  new deserializeJSON<List<Weather2020Model>>(response);
       //     public System.Xml.XmlDictionaryString RootName { get; set; }
       // output.outputToConsole($"{deserialisedWeather2020Model.Group}");


            /*foreach (Group forecastMain in deserialisedWeather2020Model)
            {

                forecastList.Add(new Weather2020Forecast(forecastMain.startDate, forecastMain.temperatureHighCelcius));
            }*/
            return forecastList;
        }
    }
}
