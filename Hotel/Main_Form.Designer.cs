namespace Hotel
{
    partial class Main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.списокГотелівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиГотельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокКлієнтівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиКлієнтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокНомерівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обратиГотельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.списокЗамовленьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.створитиЗамовленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabData = new System.Windows.Forms.TabControl();
            this.tabHotels = new System.Windows.Forms.TabPage();
            this.dataHotels = new System.Windows.Forms.DataGridView();
            this.HotelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreeRooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TakenRooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.dataClients = new System.Windows.Forms.DataGridView();
            this.tabRooms = new System.Windows.Forms.TabPage();
            this.dataRooms = new System.Windows.Forms.DataGridView();
            this.roomsHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.dataOrders = new System.Windows.Forms.DataGridView();
            this.orderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateLiving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateCrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.редагуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameі = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPatronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabData.SuspendLayout();
            this.tabHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHotels)).BeginInit();
            this.tabClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataClients)).BeginInit();
            this.tabRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRooms)).BeginInit();
            this.tabOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrders)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокГотелівToolStripMenuItem,
            this.списокКлієнтівToolStripMenuItem,
            this.списокНомерівToolStripMenuItem,
            this.списокЗамовленьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // списокГотелівToolStripMenuItem
            // 
            this.списокГотелівToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.списокГотелівToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиГотельToolStripMenuItem});
            this.списокГотелівToolStripMenuItem.Name = "списокГотелівToolStripMenuItem";
            this.списокГотелівToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.списокГотелівToolStripMenuItem.Text = "Список готелів";
            this.списокГотелівToolStripMenuItem.Click += new System.EventHandler(this.списокГотелівToolStripMenuItem_Click);
            // 
            // додатиГотельToolStripMenuItem
            // 
            this.додатиГотельToolStripMenuItem.Name = "додатиГотельToolStripMenuItem";
            this.додатиГотельToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.додатиГотельToolStripMenuItem.Text = "Додати готель";
            this.додатиГотельToolStripMenuItem.Click += new System.EventHandler(this.додатиГотельToolStripMenuItem_Click);
            // 
            // списокКлієнтівToolStripMenuItem
            // 
            this.списокКлієнтівToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиКлієнтаToolStripMenuItem});
            this.списокКлієнтівToolStripMenuItem.Name = "списокКлієнтівToolStripMenuItem";
            this.списокКлієнтівToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.списокКлієнтівToolStripMenuItem.Text = "Список клієнтів";
            this.списокКлієнтівToolStripMenuItem.Click += new System.EventHandler(this.списокКлієнтівToolStripMenuItem_Click);
            // 
            // додатиКлієнтаToolStripMenuItem
            // 
            this.додатиКлієнтаToolStripMenuItem.Name = "додатиКлієнтаToolStripMenuItem";
            this.додатиКлієнтаToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.додатиКлієнтаToolStripMenuItem.Text = "Додати клієнта";
            this.додатиКлієнтаToolStripMenuItem.Click += new System.EventHandler(this.додатиКлієнтаToolStripMenuItem_Click);
            // 
            // списокНомерівToolStripMenuItem
            // 
            this.списокНомерівToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обратиГотельToolStripMenuItem});
            this.списокНомерівToolStripMenuItem.Name = "списокНомерівToolStripMenuItem";
            this.списокНомерівToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.списокНомерівToolStripMenuItem.Text = "Список номерів";
            this.списокНомерівToolStripMenuItem.Click += new System.EventHandler(this.списокНомерівToolStripMenuItem_Click);
            // 
            // обратиГотельToolStripMenuItem
            // 
            this.обратиГотельToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.обратиГотельToolStripMenuItem.Name = "обратиГотельToolStripMenuItem";
            this.обратиГотельToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.обратиГотельToolStripMenuItem.Text = "Обрати готель";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // списокЗамовленьToolStripMenuItem
            // 
            this.списокЗамовленьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.створитиЗамовленняToolStripMenuItem});
            this.списокЗамовленьToolStripMenuItem.Name = "списокЗамовленьToolStripMenuItem";
            this.списокЗамовленьToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.списокЗамовленьToolStripMenuItem.Text = "Список замовлень";
            this.списокЗамовленьToolStripMenuItem.Click += new System.EventHandler(this.списокЗамовленьToolStripMenuItem_Click);
            // 
            // створитиЗамовленняToolStripMenuItem
            // 
            this.створитиЗамовленняToolStripMenuItem.Name = "створитиЗамовленняToolStripMenuItem";
            this.створитиЗамовленняToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.створитиЗамовленняToolStripMenuItem.Text = "Створити замовлення";
            this.створитиЗамовленняToolStripMenuItem.Click += new System.EventHandler(this.створитиЗамовленняToolStripMenuItem_Click);
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.tabHotels);
            this.tabData.Controls.Add(this.tabClients);
            this.tabData.Controls.Add(this.tabRooms);
            this.tabData.Controls.Add(this.tabOrders);
            this.tabData.Location = new System.Drawing.Point(13, 28);
            this.tabData.Name = "tabData";
            this.tabData.SelectedIndex = 0;
            this.tabData.Size = new System.Drawing.Size(775, 390);
            this.tabData.TabIndex = 1;
            this.tabData.SelectedIndexChanged += new System.EventHandler(this.tabData_SelectedIndexChanged);
            // 
            // tabHotels
            // 
            this.tabHotels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabHotels.Controls.Add(this.dataHotels);
            this.tabHotels.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabHotels.Location = new System.Drawing.Point(4, 22);
            this.tabHotels.Name = "tabHotels";
            this.tabHotels.Padding = new System.Windows.Forms.Padding(3);
            this.tabHotels.Size = new System.Drawing.Size(767, 364);
            this.tabHotels.TabIndex = 0;
            this.tabHotels.Text = "Готелі";
            this.tabHotels.UseVisualStyleBackColor = true;
            // 
            // dataHotels
            // 
            this.dataHotels.AllowUserToAddRows = false;
            this.dataHotels.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataHotels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHotels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HotelName,
            this.Address,
            this.Rooms,
            this.FreeRooms,
            this.TakenRooms});
            this.dataHotels.Location = new System.Drawing.Point(-42, -2);
            this.dataHotels.Name = "dataHotels";
            this.dataHotels.ReadOnly = true;
            this.dataHotels.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataHotels.Size = new System.Drawing.Size(812, 372);
            this.dataHotels.TabIndex = 0;
            this.dataHotels.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataHotels_CellMouseDown);
            // 
            // HotelName
            // 
            this.HotelName.HeaderText = "Готель";
            this.HotelName.Name = "HotelName";
            this.HotelName.ReadOnly = true;
            this.HotelName.Width = 219;
            // 
            // Address
            // 
            this.Address.HeaderText = "Адреса";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 220;
            // 
            // Rooms
            // 
            this.Rooms.HeaderText = "Кількість номерів";
            this.Rooms.Name = "Rooms";
            this.Rooms.ReadOnly = true;
            this.Rooms.Width = 110;
            // 
            // FreeRooms
            // 
            this.FreeRooms.HeaderText = "Вільні номери";
            this.FreeRooms.Name = "FreeRooms";
            this.FreeRooms.ReadOnly = true;
            this.FreeRooms.Width = 110;
            // 
            // TakenRooms
            // 
            this.TakenRooms.HeaderText = "Зайняті номери";
            this.TakenRooms.Name = "TakenRooms";
            this.TakenRooms.ReadOnly = true;
            this.TakenRooms.Width = 110;
            // 
            // tabClients
            // 
            this.tabClients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabClients.Controls.Add(this.dataClients);
            this.tabClients.Location = new System.Drawing.Point(4, 22);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabClients.Size = new System.Drawing.Size(767, 364);
            this.tabClients.TabIndex = 1;
            this.tabClients.Text = "Клієнти";
            this.tabClients.UseVisualStyleBackColor = true;
            // 
            // dataClients
            // 
            this.dataClients.AllowUserToAddRows = false;
            this.dataClients.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sSurname,
            this.cNameі,
            this.cPatronymic,
            this.cBirthday,
            this.cNumber,
            this.cOrder});
            this.dataClients.Location = new System.Drawing.Point(-42, -2);
            this.dataClients.Name = "dataClients";
            this.dataClients.ReadOnly = true;
            this.dataClients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataClients.Size = new System.Drawing.Size(812, 372);
            this.dataClients.TabIndex = 0;
            this.dataClients.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataClients_CellMouseDown);
            // 
            // tabRooms
            // 
            this.tabRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabRooms.Controls.Add(this.dataRooms);
            this.tabRooms.Location = new System.Drawing.Point(4, 22);
            this.tabRooms.Name = "tabRooms";
            this.tabRooms.Size = new System.Drawing.Size(767, 364);
            this.tabRooms.TabIndex = 2;
            this.tabRooms.Text = "Номери";
            this.tabRooms.UseVisualStyleBackColor = true;
            // 
            // dataRooms
            // 
            this.dataRooms.AllowUserToAddRows = false;
            this.dataRooms.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomsHotel,
            this.roomsNumber,
            this.roomsPrice,
            this.roomsClient,
            this.roomsInDate,
            this.roomsOut});
            this.dataRooms.Location = new System.Drawing.Point(-42, -2);
            this.dataRooms.Name = "dataRooms";
            this.dataRooms.Size = new System.Drawing.Size(812, 372);
            this.dataRooms.TabIndex = 0;
            this.dataRooms.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataRooms_CellMouseDown);
            // 
            // roomsHotel
            // 
            this.roomsHotel.HeaderText = "Готель";
            this.roomsHotel.Name = "roomsHotel";
            this.roomsHotel.Width = 140;
            // 
            // roomsNumber
            // 
            this.roomsNumber.HeaderText = "Номер";
            this.roomsNumber.Name = "roomsNumber";
            this.roomsNumber.Width = 50;
            // 
            // roomsPrice
            // 
            this.roomsPrice.HeaderText = "Ціна (грн/доб)";
            this.roomsPrice.Name = "roomsPrice";
            this.roomsPrice.Width = 75;
            // 
            // roomsClient
            // 
            this.roomsClient.HeaderText = "Клієнт";
            this.roomsClient.Name = "roomsClient";
            this.roomsClient.Width = 300;
            // 
            // roomsInDate
            // 
            this.roomsInDate.HeaderText = "Дата поселення";
            this.roomsInDate.Name = "roomsInDate";
            // 
            // roomsOut
            // 
            this.roomsOut.HeaderText = "Дата виселення";
            this.roomsOut.Name = "roomsOut";
            // 
            // tabOrders
            // 
            this.tabOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabOrders.Controls.Add(this.dataOrders);
            this.tabOrders.Location = new System.Drawing.Point(4, 22);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Size = new System.Drawing.Size(767, 364);
            this.tabOrders.TabIndex = 3;
            this.tabOrders.Text = "Замовлення";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // dataOrders
            // 
            this.dataOrders.AllowUserToAddRows = false;
            this.dataOrders.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumber,
            this.orderClient,
            this.orderRoom,
            this.orderDateLiving,
            this.orderPrice,
            this.orderDateCrt});
            this.dataOrders.Location = new System.Drawing.Point(-42, -2);
            this.dataOrders.Name = "dataOrders";
            this.dataOrders.Size = new System.Drawing.Size(812, 372);
            this.dataOrders.TabIndex = 0;
            this.dataOrders.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataOrders_CellMouseDown);
            // 
            // orderNumber
            // 
            this.orderNumber.HeaderText = "№";
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.Width = 50;
            // 
            // orderClient
            // 
            this.orderClient.HeaderText = "Клієнт";
            this.orderClient.Name = "orderClient";
            this.orderClient.Width = 233;
            // 
            // orderRoom
            // 
            this.orderRoom.HeaderText = "Номер кімнати";
            this.orderRoom.Name = "orderRoom";
            this.orderRoom.Width = 165;
            // 
            // orderDateLiving
            // 
            this.orderDateLiving.HeaderText = "Дати проживання";
            this.orderDateLiving.Name = "orderDateLiving";
            this.orderDateLiving.Width = 125;
            // 
            // orderPrice
            // 
            this.orderPrice.HeaderText = "Ціна (загальна)";
            this.orderPrice.Name = "orderPrice";
            this.orderPrice.Width = 78;
            // 
            // orderDateCrt
            // 
            this.orderDateCrt.HeaderText = "Дата створення замовлення";
            this.orderDateCrt.Name = "orderDateCrt";
            this.orderDateCrt.Width = 114;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(13, 424);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(306, 20);
            this.searchTextBox.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.Window;
            this.SearchButton.Location = new System.Drawing.Point(329, 423);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 22);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Пошук";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редагуватиToolStripMenuItem,
            this.видалитиToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(135, 48);
            // 
            // редагуватиToolStripMenuItem
            // 
            this.редагуватиToolStripMenuItem.Name = "редагуватиToolStripMenuItem";
            this.редагуватиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.редагуватиToolStripMenuItem.Text = "Редагувати";
            this.редагуватиToolStripMenuItem.Click += new System.EventHandler(this.редагуватиStripMenuItem_Click);
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.видалитиToolStripMenuItem.Text = "Видалити";
            this.видалитиToolStripMenuItem.Click += new System.EventHandler(this.видалитиToolStripMenuItem_Click);
            // 
            // sSurname
            // 
            this.sSurname.HeaderText = "Прізвище";
            this.sSurname.Name = "sSurname";
            this.sSurname.ReadOnly = true;
            this.sSurname.Width = 130;
            // 
            // cNameі
            // 
            this.cNameі.HeaderText = "Ім\'я";
            this.cNameі.Name = "cNameі";
            this.cNameі.ReadOnly = true;
            this.cNameі.Width = 130;
            // 
            // cPatronymic
            // 
            this.cPatronymic.HeaderText = "По батькові";
            this.cPatronymic.Name = "cPatronymic";
            this.cPatronymic.ReadOnly = true;
            this.cPatronymic.Width = 130;
            // 
            // cBirthday
            // 
            this.cBirthday.HeaderText = "Дата народження";
            this.cBirthday.Name = "cBirthday";
            this.cBirthday.ReadOnly = true;
            this.cBirthday.Width = 120;
            // 
            // cNumber
            // 
            this.cNumber.HeaderText = "Номер телефону";
            this.cNumber.Name = "cNumber";
            this.cNumber.ReadOnly = true;
            this.cNumber.Width = 130;
            // 
            // cOrder
            // 
            this.cOrder.HeaderText = "№ Замовлення";
            this.cOrder.Name = "cOrder";
            this.cOrder.ReadOnly = true;
            this.cOrder.Width = 125;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.tabData);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.Text = "Hotel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabData.ResumeLayout(false);
            this.tabHotels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataHotels)).EndInit();
            this.tabClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataClients)).EndInit();
            this.tabRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataRooms)).EndInit();
            this.tabOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataOrders)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem списокГотелівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокКлієнтівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокНомерівToolStripMenuItem;
        private System.Windows.Forms.TabControl tabData;
        private System.Windows.Forms.TabPage tabHotels;
        private System.Windows.Forms.DataGridView dataHotels;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.TabPage tabRooms;
        private System.Windows.Forms.ToolStripMenuItem додатиГотельToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиКлієнтаToolStripMenuItem;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataClients;
        private System.Windows.Forms.DataGridView dataRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreeRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn TakenRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomsHotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomsNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomsPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomsClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomsInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomsOut;
        private System.Windows.Forms.ToolStripMenuItem списокЗамовленьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem створитиЗамовленняToolStripMenuItem;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.ToolStripMenuItem обратиГотельToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.DataGridView dataOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateLiving;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateCrt;
        private System.Windows.Forms.ToolStripMenuItem редагуватиToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameі;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPatronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOrder;
    }
}

