using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ECommerceLibrary
{
    [Serializable]
    public class VacationPackage
    {
        private ArrayList cars = new ArrayList(); //add CarService.Car objects 
        private ArrayList hotels = new ArrayList(); //add HotelService.Hotel objects
        private ArrayList flights = new ArrayList();
        private ArrayList events = new ArrayList();

        public ArrayList CarReservations 
        {
            get { return cars; }
            set { cars = value; }
        }

        public ArrayList HotelReservations
        {
            get { return hotels; }
            set { hotels = value; }
        }

        public ArrayList FlightReservations
        {
            get { return flights; }
            set { flights = value; }
        }

        public ArrayList EventReservations
        {
            get { return events; }
            set { events = value; }
        }
        

    }
}
