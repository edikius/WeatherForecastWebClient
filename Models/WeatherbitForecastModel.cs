using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace WeatherForecastWebClient.Models
{

    [DataContract]
    class WeatherbitForecastModel
    {
        [DataMember]
        public List<ApiForecastData> data { get; set; }

    }

    [DataContract]
    class ApiForecastData
    {
        [DataMember]
        public float temp { get; set; }

        public string datetime { get; set; }

    }
}
