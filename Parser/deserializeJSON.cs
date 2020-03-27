using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherForecastWebClient.Parser
{
    class deserializeJSON
    {
        public T deserializeJSON<T>(string result)
        {
            T data_back;
            DataContractJsonSerializer jsonSer = new DataContractJsonSerializer(typeof(T));
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(result)))
            {
                ms.Position = 0;
                data_back = (T)jsonSer.ReadObject(ms);
                return data_back = (T)jsonSer.ReadObject(ms);
            }
        }
    }
}
