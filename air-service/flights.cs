﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Tools;

namespace air_service{
    public static class flights{
        public static int newFlight(string flightCode, int carrierID, int originAirport, int destinationAirport, DateTime departureTime, DateTime arrivalTime, int economySeats, int firstClassSeats, float economyPrice, float firstClassPrice){
            //i don't know what to do with this? probably using this to create a flight in db and returning the dynamic flightID, but not sure how to use to do anything
        }
    }
}