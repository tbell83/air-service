using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceLibrary
{
    public class HotelRoom
    {
        private int roomID;
        private int roomNum;
        private string hotel;
        private int price;

        public int RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        public int RoomNum
        {
            get { return roomNum; }
            set { roomNum = value; }
        }

        public string Hotel
        {
            get { return hotel; }
            set { hotel = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
