using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BLL
{
    [Serializable]
    public class Hotels : ISerializable
    {
        public string hotel_name { get; set; }
        public string address { get; set; }
        public int rooms { get; set; }
        public int free_rooms { get; set; }
        public int taken_rooms { get; set; }
        public Hotels(string hn, string adr, int rms)
        {
            hotel_name = hn;
            address = adr;
            rooms = rms;
            taken_rooms = 0;
            free_rooms = rms - taken_rooms;
        }

        public Hotels(SerializationInfo info, StreamingContext context)
        {
            hotel_name = (string)info.GetValue("HotelName", typeof(string));
            address = (string)info.GetValue("Address", typeof(string));
            rooms = (int)info.GetValue("Rooms", typeof(int));
            free_rooms = (int)info.GetValue("freeRooms", typeof(int));
            taken_rooms = (int)info.GetValue("takenRooms", typeof(int));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("HotelName", hotel_name, typeof(string));
            info.AddValue("Address", address, typeof(string));
            info.AddValue("Rooms", rooms, typeof(int));
            info.AddValue("freeRooms", free_rooms, typeof(int));
            info.AddValue("takenRooms", taken_rooms, typeof(int));
        }

       
    }
}
