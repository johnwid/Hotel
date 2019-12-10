using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BLL
{
    [Serializable] public class Room : ISerializable
    {
        public string hotel { get; set; }
        public int number { get; set; }
        public double price { get; set; }
        public string client { get; set; }
        public string date_in { get; set; }
        public string date_out { get; set; }
        public Room(string htl, int n)
        {
            hotel = htl;
            number = n;
            price = 0.0;
            client = "-";
            date_in = "-";
            date_out = "-";
        }

        public Room(SerializationInfo info, StreamingContext context)
        {
            hotel = (string)info.GetValue("Hotel", typeof(string));
            number = (int)info.GetValue("Number", typeof(int));
            price = (float)info.GetValue("Price", typeof(float));
            client = (string)info.GetValue("Client", typeof(string));
            date_in = (string)info.GetValue("DateIn", typeof(string));
            date_out = (string)info.GetValue("DateOut", typeof(string));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Hotel", hotel, typeof(string));
            info.AddValue("Number", number, typeof(int));
            info.AddValue("Price", price, typeof(float));
            info.AddValue("Client", client, typeof(string));
            info.AddValue("DateIn", date_in, typeof(string));
            info.AddValue("DateOut", date_out, typeof(string));
        }
    }
}
