using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DAL
{
    public class DALmain<T>
    {
        private string path { get; }
        public DALmain()
        {
            path = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "DB");
            Directory.CreateDirectory(path);
        }

        public virtual void Serialize(T obj)
        {
            IFormatter frm = new BinaryFormatter();
            Stream str = new FileStream(path + "\\" + "DB.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            frm.Serialize(str, obj);
            str.Close();
        }

        public virtual void Deserialize(ref T obj)
        {
            if (File.Exists(path + "\\" + "DB.bin"))
            {
                IFormatter frm = new BinaryFormatter();
                Stream str = new FileStream(path + "\\" + "DB.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                obj = (T)frm.Deserialize(str);
                str.Close();
            }
            else
                throw new ArgumentNullException();
        }
    }
}
