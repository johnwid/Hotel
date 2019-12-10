using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Hotel
{
    public partial class Client_Add_Form : Form
    {
        BLLmain bll = new BLLmain();
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public DateTime birthday { get; set; }
        public string phone_number { get; set; }
        public Client_Add_Form()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (surnameTextBox.Text == "" || nameTextBox.Text == "" || patronymicTextBox.Text == "" || birthdayTextBox.Text == "" || phoneTextBox.Text == "")
                MessageBox.Show("Не всі поля заповнені!");
            else
            {
                DateTime temp_date;
                if (DateTime.TryParseExact(birthdayTextBox.Text, "dd.MM.yyyy", CultureInfo.GetCultureInfo("ru-RU"), DateTimeStyles.AssumeLocal, out temp_date))
                {
                    surname = surnameTextBox.Text;
                    name = nameTextBox.Text;
                    patronymic = patronymicTextBox.Text;
                    birthday = temp_date;
                    phone_number = phoneTextBox.Text;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("Ви ввели невірну дату народження! (хх.хх.хххх)");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
        
        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            char key = e.KeyChar;
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]|[І,і,Є,є,Ї,ї,Ґ,ґ]").Success && !new[] { 8, 39, 96 }.Contains(key))
            {
                e.Handled = true;
            }
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            char key = e.KeyChar;
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]|[І,і,Є,є,Ї,ї,Ґ,ґ]").Success && !new[] { 8, 39, 96 }.Contains(key))
            {
                e.Handled = true;
            }
        }

        private void patronymicTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            char key = e.KeyChar;
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]|[І,і,Є,є,Ї,ї,Ґ,ґ]").Success && !new[] { 8, 39, 96 }.Contains(key))
            {
                e.Handled = true;
            }
        }
        
        private void birthdayTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!Char.IsDigit(key) && !new[] { 8, 46 }.Contains(key))
            {
                e.Handled = true;
            }
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!Char.IsDigit(key) && !new[] { 8, 43, 45 }.Contains(key))
            {
                e.Handled = true;
            }
        }
    }
}
