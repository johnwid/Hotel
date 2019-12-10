using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    [Serializable] public class BLLmain
    {
        [field: NonSerialized] private DALmain<BLLmain> data = new DALmain<BLLmain>();
        List<Client> clients = new List<Client>();
        public List<Client> Clients
        {
            get { return clients; }
        }
        List<Hotels> hotels = new List<Hotels>();
        public List<Hotels> Hotels
        {
            get { return hotels; }
        }
        List<Room> rooms = new List<Room>();
        public List<Room> Rooms
        {
            get { return rooms; }
        }
        List<Orders> orders = new List<Orders>();
        public List<Orders> Orders
        {
            get { return orders; }
        }

        public BLLmain()
        { }

        public static BLLmain GetInfo() // get data from DB.bin
        {
            DALmain<BLLmain> dm = new DALmain<BLLmain>();
            BLLmain bll = new BLLmain();
            try
            {
                dm.Deserialize(ref bll);
                bll.data = new DALmain<BLLmain>();
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Файл не знайдено.");
                Console.WriteLine("Натисніть клавішу для виходу...");
                Console.ReadLine();
                Environment.Exit(1);
            }
            catch(NotSupportedException)
            {
                Console.WriteLine("Файл не знайдено.");
                Console.WriteLine("Натисніть клавішу для виходу...");
                Console.ReadLine();
                Environment.Exit(1);
            }
            return bll;
        }

        public virtual void SaveInfo(BLLmain info) // save data to DB.bin
        {
            data.Serialize(info);
        }

        public void AddHotel(Hotels obj)
        {
            hotels.Add(obj);
        }

        public void DeleteHotel(List<Hotels> hotels, int k)
        {
            hotels.Remove(hotels[k]);
        }

        public void AddClient(Client obj)
        {
            clients.Add(obj);
        }

        public void EditClient(string pn, List<Client> clients, int k)
        {
            clients[k].phone_number = pn;
        }

        public void DeleteClient(List<Client> clients, int k)
        {
            clients.Remove(clients[k]);
        }

        public DateTime ConvertToDateTime(string value)
        {
            DateTime convertedDate;
            try
            {
                convertedDate = Convert.ToDateTime(value);
                return convertedDate;
            }
            catch (FormatException)
            {
                DateTime default_date = new DateTime();
                return default_date;
            }
        }

        public void AddRooms(Room obj)
        {
            rooms.Add(obj);
        }

        public void EditRoom(double p, List<Room> rooms, int k)
        {
            rooms[k].price = p;
        }

        public void UpdateRooms(List<Room> rooms, Hotels hotel, List<Orders> orders)
        {
            for (int i = rooms.Count - 1; i >= 0; i--)
            {
                if (rooms[i].hotel == hotel.hotel_name)
                {
                    rooms.Remove(rooms[i]);
                }
            }
            for (int i = orders.Count - 1; i >= 0; i--)
            {
                if(orders[i].hotel == hotel.hotel_name)
                {
                    orders.Remove(orders[i]);
                }
            }
        }

        public void AddOrder(Orders obj, List<Hotels> hotels, List<Room> rooms, List<Client> clients)
        {
            orders.Add(obj);
            for (int i = 0; i < rooms.Count; i++)
            {
                if(rooms[i].hotel == obj.hotel && rooms[i].number == obj.room_number)
                {
                    rooms[i].client = obj.client;
                    rooms[i].date_in = obj.dateIn.ToShortDateString();
                    rooms[i].date_out = obj.dateOut.ToShortDateString();
                }
            }
            for (int i = 0; i < hotels.Count; i++)
            {
                if(hotels[i].hotel_name == obj.hotel)
                {
                    hotels[i].free_rooms--;
                    hotels[i].taken_rooms++;
                }
            }
            for (int i = 0; i < clients.Count; i++)
            {
                if((clients[i].surname + " " + clients[i].name + " " + clients[i].patronymic) == obj.client)
                {
                    clients[i].order = obj.order_number.ToString();
                }
            }
        }

        public void DeleteOrder(List<Orders> orders, int k, List<Room> rooms)
        {
            for(int i = 0; i < rooms.Count; i++)
            {
                if(rooms[i].hotel == orders[k].hotel && rooms[i].number == orders[k].room_number)
                {
                    rooms[i].client = "-";
                    rooms[i].date_in = "-";
                    rooms[i].date_out = "-";
                }
            }
            orders.Remove(orders[k]);
        }
    }

}
