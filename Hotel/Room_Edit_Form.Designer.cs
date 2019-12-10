namespace Hotel
{
    partial class Room_Edit_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Room_editPTextBox = new System.Windows.Forms.TextBox();
            this.HotelEdit_bOK = new System.Windows.Forms.Button();
            this.HotelEdit_bCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Room_editPTextBox);
            this.panel1.Controls.Add(this.HotelEdit_bOK);
            this.panel1.Controls.Add(this.HotelEdit_bCancel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 105);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ціна (грн/доб)";
            // 
            // Room_editPTextBox
            // 
            this.Room_editPTextBox.Location = new System.Drawing.Point(15, 27);
            this.Room_editPTextBox.Name = "Room_editPTextBox";
            this.Room_editPTextBox.Size = new System.Drawing.Size(173, 20);
            this.Room_editPTextBox.TabIndex = 9;
            // 
            // HotelEdit_bOK
            // 
            this.HotelEdit_bOK.BackColor = System.Drawing.SystemColors.Window;
            this.HotelEdit_bOK.Location = new System.Drawing.Point(13, 60);
            this.HotelEdit_bOK.Name = "HotelEdit_bOK";
            this.HotelEdit_bOK.Size = new System.Drawing.Size(75, 23);
            this.HotelEdit_bOK.TabIndex = 6;
            this.HotelEdit_bOK.Text = "Зберегти";
            this.HotelEdit_bOK.UseVisualStyleBackColor = false;
            this.HotelEdit_bOK.Click += new System.EventHandler(this.RoomEdit_bOK_Click);
            // 
            // HotelEdit_bCancel
            // 
            this.HotelEdit_bCancel.BackColor = System.Drawing.SystemColors.Window;
            this.HotelEdit_bCancel.Location = new System.Drawing.Point(113, 60);
            this.HotelEdit_bCancel.Name = "HotelEdit_bCancel";
            this.HotelEdit_bCancel.Size = new System.Drawing.Size(75, 23);
            this.HotelEdit_bCancel.TabIndex = 7;
            this.HotelEdit_bCancel.Text = "Відмінити";
            this.HotelEdit_bCancel.UseVisualStyleBackColor = false;
            this.HotelEdit_bCancel.Click += new System.EventHandler(this.RoomEdit_bCancel_Click);
            // 
            // Room_Edit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(205, 105);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Room_Edit_Form";
            this.Text = "Room_Edit_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button HotelEdit_bOK;
        private System.Windows.Forms.Button HotelEdit_bCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Room_editPTextBox;
    }
}