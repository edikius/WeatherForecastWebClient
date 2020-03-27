using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace WeatherForecastWebClient.Models
{

    [DataContract(Name ="groups")]
    class Weather2020Model
    {
        [DataMember]
        public List<Group> groups;
    }
    [DataContract]
    public class Group
    {
        [DataMember]
        public float temperatureHighCelcius { get; set; }
        [DataMember]
        public long startDate { get; set; }
    }
    /*
    [DataContract]
    class UnnamedObject
    {
        [DataMember]
        public float temperatureHighCelcius { get; set; }
        [DataMember]
        public long startDate { get; set; }
    }*/
}