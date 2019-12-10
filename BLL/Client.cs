using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BLL
{
    [Serializable] public class Client : ISerializable
    {
        // public List<Client> clients { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public DateTime birthday { get; set; }
        public string phone_number { get; set; }
        public string order { get; set; }

        public Client(string srn, string nm, string ptr, DateTime bd, string pn)
        {
            surname = srn;
            name = nm;
            patronymic = ptr;
            birthday = bd;
            phone_number = pn;
            order = "-";
        }

        public Client(SerializationInfo info, StreamingContext context)
        {
            surname = (string)info.GetValue("Surname", typeof(string));
            name = (string)info.GetValue("Name", typeof(string));
            patronymic = (string)info.GetValue("Patronymic", typeof(string));
            birthday = (DateTime)info.GetValue("Birthday", typeof(DateTime));
            phone_number = (string)info.GetValue("PhoneNumber", typeof(string));
            order = (string)info.GetValue("Order", typeof(string));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Surname", surname, typeof(string));
            info.AddValue("Name", name, typeof(string));
            info.AddValue("Patronymic", patronymic, typeof(string));
            info.AddValue("Birthday", birthday, typeof(DateTime));
            info.AddValue("PhoneNumber", phone_number, typeof(long));
            info.AddValue("Order", order, typeof(string));
        }

    }
}
