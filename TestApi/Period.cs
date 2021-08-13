using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApi
{
    class Period
    {
        public int Number { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsDaytime { get; set; }
        public int Temperature { get; set; }

        public string WindSpeed { get; set; }
        public string WindDirection { get; set; }
        public string ShortForecast { get; set; }
    }

    /*
"number": 1,
                "name": "Today",
                "startTime": "2021-08-13T11:00:00-04:00",
                "endTime": "2021-08-13T18:00:00-04:00",
                "isDaytime": true,
                "temperature": 98,
                "temperatureUnit": "F",
                "temperatureTrend": null,
                "windSpeed": "3 to 7 mph",
                "windDirection": "SW",
                "icon": "https://api.weather.gov/icons/land/day/hot/tsra_hi,40?size=medium",
                "shortForecast": "Mostly Sunny then Chance Showers And Thunderstorms",
                "detailedForecast": "A chance of showers and thunderstorms between 2pm and 5pm, then a chance of showers and thunderstorms. Mostly sunny, with a high near 98. Heat index values as high as 107. Southwest wind 3 to 7 mph. Chance of precipitation is 40%. New rainfall amounts between a tenth and quarter of an inch possible."
     */
}
