using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BLL
{
    [Serializable]
    public class Orders : ISerializable
    {
        public int order_number { get; set; }
        public string client { get; set; }
        public string hotel { get; set; }
        public int room_number { get; set; }
        public DateTime dateIn { get; set; }
        public DateTime dateOut { get; set; }
        public double price { get; set; }
        public DateTime date_order { get; set; }
        public Orders(int on, string cl, string h, int rn, DateTime dIn, DateTime dOut, double pr)
        {
            order_number = on;
            client = cl;
            hotel = h;
            room_number = rn;
            dateIn = dIn;
            dateOut = dOut;
            price = pr;
            date_order = DateTime.Now;
        }

        public Orders(SerializationInfo info, StreamingContext context)
        {
            order_number = (int)info.GetValue("OrderNumber", typeof(int));
            client = (string)info.GetValue("Client", typeof(string));
            hotel = (string)info.GetValue("Hotel", typeof(string));
            room_number = (int)info.GetValue("RoomNumber", typeof(int));
            dateIn = (DateTime)info.GetValue("DateIn", typeof(DateTime));
            dateOut = (DateTime)info.GetValue("DateOut", typeof(DateTime));
            price = (double)info.GetValue("Price", typeof(double));
            date_order = (DateTime)info.GetValue("DateOrder", typeof(DateTime));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("OrderNumber", order_number, typeof(int));
            info.AddValue("Client", client, typeof(string));
            info.AddValue("Hotel", hotel, typeof(string));
            info.AddValue("RoomNumber", room_number, typeof(int));
            info.AddValue("DateIn", dateIn, typeof(DateTime));
            info.AddValue("DateOut", dateOut, typeof(DateTime));
            info.AddValue("Price", price, typeof(double));
            info.AddValue("DateOrder", date_order, typeof(DateTime));
        }
    }
}
