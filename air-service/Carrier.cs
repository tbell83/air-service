using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace air_service
{
    public class Carrier
    {
        private int carrierID;
        private string carrierName;

        public int CarrierID
        {
            get { return carrierID; }
            set { carrierID = value; }
        }

        public string CarrierName
        {
            get { return carrierName; }
            set { carrierName = value; }
        }
    }
}