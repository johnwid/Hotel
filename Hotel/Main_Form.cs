using System;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using static System.Windows.Forms.DataGrid;
using System.Globalization;

namespace Hotel
{
    public partial class Main_Form : Form
    {
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wPrm, [MarshalAs(UnmanagedType.LPWStr)] string lPrm);
        BLLmain bll = new BLLmain();
        public static Main_Form SelfRef
        { get; set; }
        private int temp_index = 0;
        public Main_Form()
        {
            try { bll = BLLmain.GetInfo(); }
            catch (ArgumentNullException) { }
            InitializeComponent();
            SelfRef = this;
            ShowHotels(bll.Hotels);
            ShowClients(bll.Clients);
            ShowRooms(bll.Rooms);
            ShowOrders(bll.Orders);
        }

        public void ShowHotels(List<Hotels> hotels) // List<Hotels> hotels
        {
            dataHotels.Controls.Clear();
            toolStripComboBox1.Items.Clear();
            toolStripComboBox1.Items.Add("Всі номери");

            if (hotels != null)
            {
                for(int i = 0; i < hotels.Count; i++)
                {
                    if (dataHotels.Rows.Count < hotels.Count)
                        dataHotels.Rows.Add();

                    dataHotels[0, i].Value = hotels[i].hotel_name;
                    dataHotels[1, i].Value = hotels[i].address;
                    dataHotels[2, i].Value = hotels[i].rooms;
                    dataHotels[3, i].Value = hotels[i].free_rooms;
                    dataHotels[4, i].Value = hotels[i].taken_rooms;
                    toolStripComboBox1.Items.Add(dataHotels[0, i].Value);
                }
            }
            toolStripComboBox1.SelectedIndex = temp_index;
            
        }

        public void ShowRooms(List<Room> rooms)
        {
            dataRooms.Controls.Clear();
            dataRooms.Rows.Clear();
            if (rooms != null)
            {
                for (int i = 0; i < rooms.Count; i++)
                {
                    if (dataRooms.Rows.Count < rooms.Count)
                        dataRooms.Rows.Add();

                    dataRooms[0, i].Value = rooms[i].hotel;
                    dataRooms[1, i].Value = rooms[i].number;
                    dataRooms[2, i].Value = rooms[i].price.ToString("F", CultureInfo.CreateSpecificCulture("fr-FR"));
                    dataRooms[3, i].Value = rooms[i].client;
                    dataRooms[4, i].Value = rooms[i].date_in;
                    dataRooms[5, i].Value = rooms[i].date_out;
                }
            }
        }

        public void ShowHotelRooms(List<Room> rooms) // show rooms by hotel
        {
            ShowRooms(bll.Rooms);
            for (int i = dataRooms.Rows.Count - 1; i >= 0; i--)
            {
                foreach (DataGridViewRow row in dataRooms.Rows)
                {
                    if (!row.Cells["roomsHotel"].Value.Equals(toolStripComboBox1.Text))
                    {
                        dataRooms.Rows.RemoveAt(row.Index);
                        break;
                    }
                }
            }
        }
        public void ShowClients(List<Client> clients)
        {
            dataClients.Controls.Clear();
            dataClients.Rows.Clear();
            if (clients != null)
            {
                for (int i = 0; i < clients.Count; i++)
                {
                    if (dataClients.Rows.Count < clients.Count)
                        dataClients.Rows.Add();

                    dataClients[0, i].Value = clients[i].surname;
                    dataClients[1, i].Value = clients[i].name;
                    dataClients[2, i].Value = clients[i].patronymic;
                    dataClients[3, i].Value = clients[i].birthday.ToShortDateString();
                    dataClients[4, i].Value = clients[i].phone_number;
                    dataClients[5, i].Value = clients[i].order;
                }
            }
        }

        public void ShowOrders(List<Orders> orders)
        {
            dataOrders.Rows.Clear();
            if (orders != null)
            {
                for (int i = 0; i < orders.Count; i++)
                {
                    if (dataOrders.Rows.Count < orders.Count)
                        dataOrders.Rows.Add();

                    dataOrders[0, i].Value = orders[i].order_number;
                    dataOrders[1, i].Value = orders[i].client;
                    dataOrders[2, i].Value = "Готель \"" + orders[i].hotel + "\" (н. " + orders[i].room_number + ")";
                    dataOrders[3, i].Value = orders[i].dateIn.ToShortDateString() + "—" + orders[i].dateOut.ToShortDateString();
                    dataOrders[4, i].Value = orders[i].price;
                    dataOrders[5, i].Value = orders[i].date_order;
                }
            }
        }
        private void списокГотелівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabData.SelectTab(tabHotels);
        }

        private void додатиГотельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hotel_Add_Form form = new Hotel_Add_Form();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                bll.AddHotel(new Hotels(form.hotel_name, form.address, form.rooms));
                for(int i = 1; i <= form.rooms; i++)
                {
                    bll.AddRooms(new Room(form.hotel_name, i));
                }
                dataHotels.Controls.Clear();
                dataRooms.Controls.Clear();
                ShowHotels(bll.Hotels);
                ShowRooms(bll.Rooms);
            }
            bll.SaveInfo(bll);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (tabData.SelectedIndex == 0) // hotelsTab selected
            {
                for (int i = 0; i < dataHotels.RowCount; i++)
                {
                    dataHotels.Rows[i].Selected = false;
                    for (int j = 0; j < dataHotels.ColumnCount; j++)
                        if (dataHotels.Rows[i].Cells[j].Value != null)
                            if (dataHotels.Rows[i].Cells[j].Value.ToString().Contains(searchTextBox.Text))
                            {
                                dataHotels.Rows[i].Selected = true;
                                dataHotels.FirstDisplayedScrollingRowIndex = i;
                                break;
                            }
                }
            }
            else if (tabData.SelectedIndex == 1) // clientsTab selected
            {
                for (int i = 0; i < dataClients.RowCount; i++)
                {
                    dataClients.Rows[i].Selected = false;
                    for (int j = 0; j < dataClients.ColumnCount; j++)
                        if (dataClients.Rows[i].Cells[j].Value != null)
                            if (dataClients.Rows[i].Cells[j].Value.ToString().Contains(searchTextBox.Text))
                            {
                                dataClients.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            else if (tabData.SelectedIndex == 2)// roomsTab selected
            {
                for (int i = 0; i < dataRooms.RowCount; i++) 
                {
                    dataRooms.Rows[i].Selected = false;
                    for (int j = 0; j < dataRooms.ColumnCount; j++)
                        if (dataRooms.Rows[i].Cells[j].Value != null)
                            if (dataRooms.Rows[i].Cells[j].Value.ToString().Contains(searchTextBox.Text))
                            {
                                dataRooms.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            else // ordersTab selected
            {
                for (int i = 0; i < dataOrders.RowCount; i++)
                {
                    dataOrders.Rows[i].Selected = false;
                    for (int j = 0; j < dataOrders.ColumnCount; j++)
                        if (dataOrders.Rows[i].Cells[j].Value != null)
                            if (dataOrders.Rows[i].Cells[j].Value.ToString().Contains(searchTextBox.Text))
                            {
                                dataOrders.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            searchTextBox.Clear();
        }

        public static int hotels_rowindex { get; set; }
        private void dataHotels_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try {
                    dataHotels.ClearSelection();
                    dataHotels[e.ColumnIndex, e.RowIndex].Selected = true;
                    редагуватиToolStripMenuItem.Visible = false;
                    видалитиToolStripMenuItem.Visible = true;
                    contextMenuStrip.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
                    hotels_rowindex = e.RowIndex;
                }
                catch
                {
                    return;
                }
                
            }
        }

        private void редагуватиStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabData.SelectedIndex == 1)
            {
                Client_Edit_Form form = new Client_Edit_Form();
                form.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
                form.ShowDialog();
            }
            if (tabData.SelectedIndex == 2)
            {
                Room_Edit_Form form = new Room_Edit_Form();
                form.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
                form.ShowDialog();
            }
            else
                return;
            
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Видалити даний елемент?", "Підтвердити", MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                if(temp_index != 0)
                {
                    temp_index = 0;
                }

                if (tabData.SelectedIndex == 0)
                {
                    dataHotels.Rows.RemoveAt(hotels_rowindex);
                    for (int i = dataRooms.Rows.Count - 1; i >= 0; i--)
                    {
                        foreach (DataGridViewRow row in dataRooms.Rows)
                        {
                            if (row.Cells["roomsHotel"].Value.Equals(bll.Hotels[hotels_rowindex].hotel_name))
                            {
                                dataRooms.Rows.RemoveAt(row.Index);
                                break;
                            }
                        }
                    }
                    bll.UpdateRooms(bll.Rooms, bll.Hotels[hotels_rowindex], bll.Orders);
                    bll.DeleteHotel(bll.Hotels, hotels_rowindex);

                    bll.SaveInfo(bll);

                    ShowHotels(bll.Hotels);
                    ShowRooms(bll.Rooms);
                    ShowOrders(bll.Orders);
                }
                else if (tabData.SelectedIndex == 1)
                {
                    bll.DeleteClient(bll.Clients, clients_rowindex);
                    bll.SaveInfo(bll);
                    dataClients.Rows.RemoveAt(clients_rowindex);
                    ShowClients(bll.Clients);
                }
                else if (tabData.SelectedIndex == 3)
                {
                    bll.DeleteOrder(bll.Orders, orders_rowindex, bll.Rooms);
                    bll.SaveInfo(bll);
                    dataOrders.Rows.RemoveAt(orders_rowindex);
                    ShowOrders(bll.Orders);
                }
                else
                    return;
            }
        }

        private void tabData_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tabData.SelectedIndex)
            {
                case 0:
                    {
                        try { bll = BLLmain.GetInfo(); }
                        catch (ArgumentNullException) { }
                        ShowHotels(bll.Hotels);
                    }
                    break;
                case 1:
                    {
                        try { bll = BLLmain.GetInfo(); }
                        catch (ArgumentNullException) { }
                        ShowClients(bll.Clients);
                    }
                    break;
                case 2:
                    {
                        try { bll = BLLmain.GetInfo(); }
                        catch (ArgumentNullException) { }
                        if (toolStripComboBox1.SelectedIndex == 0)
                            ShowRooms(bll.Rooms);
                        else
                            ShowHotelRooms(bll.Rooms);
                    }
                    break;
                case 3:
                    {
                        try { bll = BLLmain.GetInfo(); }
                        catch (ArgumentNullException) { }
                        ShowOrders(bll.Orders);
                    }
                    break;
                default:
                    break;
            }
        }

        public static int clients_rowindex { get; set; }
        private void додатиКлієнтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client_Add_Form form = new Client_Add_Form();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                bll.AddClient(new Client(form.surname, form.name, form.patronymic, form.birthday, form.phone_number));
                dataClients.Controls.Clear();
                bll.SaveInfo(bll);
                ShowClients(bll.Clients);
            }
        }

        private void списокКлієнтівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabData.SelectTab(tabClients);
        }

        private void dataClients_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dataClients.ClearSelection();
                    dataClients[e.ColumnIndex, e.RowIndex].Selected = true;
                    редагуватиToolStripMenuItem.Visible = true;
                    видалитиToolStripMenuItem.Visible = true;
                    contextMenuStrip.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
                    clients_rowindex = e.RowIndex;
                }
                catch
                {
                    return;
                }

            }
        }

        private void списокНомерівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabData.SelectTab(tabRooms);
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "Всі номери")
            {
                ShowRooms(bll.Rooms);
            }
            else
            {
                ShowHotelRooms(bll.Rooms);
            }
            temp_index = toolStripComboBox1.SelectedIndex;
        }

        public static int rooms_rowindex { get; set; }
        private void dataRooms_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dataRooms.ClearSelection();
                    dataRooms[e.ColumnIndex, e.RowIndex].Selected = true;
                    редагуватиToolStripMenuItem.Visible = true;
                    видалитиToolStripMenuItem.Visible = true;
                    contextMenuStrip.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
                    rooms_rowindex = e.RowIndex;
                }
                catch
                {
                    return;
                }

            }
        }

        private void створитиЗамовленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order_Add_Form form = new Order_Add_Form(bll.Clients, bll.Hotels, bll.Rooms);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                int c;
                if (bll.Orders == null)
                    c = 1;
                else
                    c = bll.Orders.Count + 1;
                bll.AddOrder(new Orders(c, form.client, form.hotel, form.room, form.dateIn, form.dateOut, form.price), bll.Hotels, bll.Rooms, bll.Clients);
                dataClients.Controls.Clear();
                bll.SaveInfo(bll);
                ShowOrders(bll.Orders);
                ShowRooms(bll.Rooms);
            }
        }

        private void списокЗамовленьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabData.SelectTab(tabOrders);
        }

        public static int orders_rowindex { get; set; }
        private void dataOrders_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dataOrders.ClearSelection();
                    dataOrders[e.ColumnIndex, e.RowIndex].Selected = true;
                    редагуватиToolStripMenuItem.Visible = false;
                    видалитиToolStripMenuItem.Visible = true;
                    contextMenuStrip.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
                    orders_rowindex = e.RowIndex;
                }
                catch
                {
                    return;
                }

            }
        }
    }
}
