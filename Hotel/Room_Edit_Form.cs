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
    public partial class Room_Edit_Form : Form
    {
        BLLmain bll = new BLLmain();
        int k = Main_Form.rooms_rowindex;
        public Room_Edit_Form()
        {
            try { bll = BLLmain.GetInfo(); }
            catch (ArgumentNullException) { }
            InitializeComponent();
            Room_editPTextBox.Text = bll.Rooms[k].price.ToString("F", CultureInfo.CreateSpecificCulture("fr-FR"));
        }

        private void RoomEdit_bCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void RoomEdit_bOK_Click(object sender, EventArgs e)
        {
            if (Room_editPTextBox.Text == "")
                MessageBox.Show("Не всі поля заповнені!");
            else
            {
                double p;
                p = Convert.ToDouble(Room_editPTextBox.Text);
                bll.EditRoom(p, bll.Rooms, k);
                bll.SaveInfo(bll);
                Close();
                try { Main_Form.SelfRef.ShowRooms(bll.Rooms); }
                catch { return; }
            }
        }
    }
}
