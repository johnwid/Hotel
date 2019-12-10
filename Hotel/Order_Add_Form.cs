using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Hotel
{
    public partial class Order_Add_Form : Form
    {
        BLLmain bll = new BLLmain();
        public string client { get; set; }
        public string hotel { get; set; }
        public int room { get; set; }
        public DateTime dateIn { get; set; }
        public DateTime dateOut { get; set; }
        public double price { get; set; }

        List<Hotels> temp_hotels = new List<Hotels>();
        List<Room> temp_rooms = new List<Room>();
        //List<Client> temp_clients = new List<Client>();

        public Order_Add_Form(List<Client> clients, List<Hotels> hotels, List<Room> rooms)
        {
            try { bll = BLLmain.GetInfo(); }
            catch (ArgumentNullException) { }
            InitializeComponent();
            temp_hotels = hotels;
            temp_rooms = rooms;
            textBox1.Text = DateTime.Now.ToShortDateString();
            comboBox3.Items.Clear();
            for (int i = 0; i < clients.Count; i++)
            {
                comboBox1.Items.Add(clients[i].surname + " " + clients[i].name + " " + clients[i].patronymic);
            }
            for (int i = 0; i < hotels.Count; i++)
            {
                comboBox2.Items.Add(hotels[i].hotel_name);
            }
            DateTime temp = DateTime.Now;
            for (int i = 0; i < 7; i++)
            {
                temp = temp.AddDays(1);
                comboBox4.Items.Add(temp.ToShortDateString());
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || textBox1.Text == "" || comboBox4.Text == "")
                MessageBox.Show("Не всі поля заповнені!");
            else
            {
                DateTime temp_date;
                if (DateTime.TryParseExact(textBox1.Text, "dd.MM.yyyy", CultureInfo.GetCultureInfo("ru-RU"), DateTimeStyles.AssumeLocal, out temp_date))
                {
                    dateIn = temp_date;
                    if (DateTime.TryParseExact(comboBox4.Text, "dd.MM.yyyy", CultureInfo.GetCultureInfo("ru-RU"), DateTimeStyles.AssumeLocal, out temp_date))
                    {
                        dateOut = temp_date;

                        client = comboBox1.Text;
                        hotel = comboBox2.Text;
                        room = Convert.ToInt32(comboBox3.Text);

                        price = temp_price * (dateOut - dateIn).Days;

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ви ввели невірну дату виїзду! (хх.хх.хххх)");
                }
                else
                    MessageBox.Show("Ви ввели невірну дату в'їзду! (хх.хх.хххх)");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            for (int i = 0; i < temp_rooms.Count; i++)
            {
                if(temp_rooms[i].hotel == temp_hotels[comboBox2.SelectedIndex].hotel_name && temp_rooms[i].client == "-")
                    comboBox3.Items.Add(temp_rooms[i].number);
            }
        }
        double temp_price;
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < temp_rooms.Count; i++)
            {
                if (temp_rooms[i].hotel == temp_hotels[comboBox2.SelectedIndex].hotel_name && temp_rooms[i].number == Convert.ToInt32(comboBox3.Text))
                {
                    temp_price = temp_rooms[i].price;
                }
            }
        }
    }
}
