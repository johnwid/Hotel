using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Hotel
{
    public partial class Client_Edit_Form : Form
    {
        BLLmain bll = new BLLmain();
        int k = Main_Form.clients_rowindex;
        public Client_Edit_Form()
        {
            try { bll = BLLmain.GetInfo(); }
            catch (ArgumentNullException) { }
            InitializeComponent();
            Client_editPNTBox.Text = bll.Clients[k].phone_number;
        }

        private void ClientEdit_bOK_Click(object sender, EventArgs e)
        {
            if (Client_editPNTBox.Text == "")
                MessageBox.Show("Не всі поля заповнені!");
            else
            {
                string pn;
                pn = Client_editPNTBox.Text;
                bll.EditClient(pn, bll.Clients, k);
                bll.SaveInfo(bll);
                Close();
                try { Main_Form.SelfRef.ShowClients(bll.Clients); }
                catch { return; }
            }
        }

        private void ClientEdit_bCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Client_editPNTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!Char.IsDigit(key) && !new[] { 8, 43, 45 }.Contains(key))
            {
                e.Handled = true;
            }
        }
    }
}
