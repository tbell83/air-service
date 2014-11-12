using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace air_service
{
    public class Airport
    {
        private int airportID;
        private int airportCode;
        private string airportName;
        private int cityID;

        public int AirportID
        {
            get { return airportID; }
            set { airportID = value; }
        }

        public int AirportCode
        {
            get { return airportCode; }
            set { airportCode = value; }
        }

        public string AirportName
        {
            get { return airportName; }
            set { airportName = value; }
        }

        public int CityID
        {
            get { return cityID; }
            set { cityID = value; }
        }
    }
}