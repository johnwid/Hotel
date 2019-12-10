using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Hotel
{
    public partial class Hotel_Add_Form : Form
    {
        public string hotel_name { get; set; }
        public string address { get; set; }
        public int rooms { get; set; }

        
        public Hotel_Add_Form()
        {
            InitializeComponent();
        }
 
        private void roomsUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (hotelTextBox.Text == "" || addressTextBox.Text == "" || roomsUpDown.Text == "" || roomsUpDown.Text == "0")
                MessageBox.Show("Не всі поля заповнені!");
            else
            {
                hotel_name = hotelTextBox.Text;
                address = addressTextBox.Text;
                rooms = Convert.ToInt32(roomsUpDown.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
