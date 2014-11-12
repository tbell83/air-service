using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace air_service
{
    public class City
    {
        private int cityID;
        private string cityName;
        private string state;

        public int CityID
        {
            get { return cityID; }
            set { cityID = value; }
        }

        public string CityName
        {
            get { return cityName; }
            set { cityName = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }
    }
}