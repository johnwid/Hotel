namespace Hotel
{
    partial class Client_Edit_Form
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
            this.ClientEdit_bCancel = new System.Windows.Forms.Button();
            this.ClientEdit_bOK = new System.Windows.Forms.Button();
            this.Client_editPNTBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientEdit_bCancel
            // 
            this.ClientEdit_bCancel.BackColor = System.Drawing.SystemColors.Window;
            this.ClientEdit_bCancel.Location = new System.Drawing.Point(113, 60);
            this.ClientEdit_bCancel.Name = "ClientEdit_bCancel";
            this.ClientEdit_bCancel.Size = new System.Drawing.Size(75, 23);
            this.ClientEdit_bCancel.TabIndex = 7;
            this.ClientEdit_bCancel.Text = "Відмінити";
            this.ClientEdit_bCancel.UseVisualStyleBackColor = false;
            this.ClientEdit_bCancel.Click += new System.EventHandler(this.ClientEdit_bCancel_Click);
            // 
            // ClientEdit_bOK
            // 
            this.ClientEdit_bOK.BackColor = System.Drawing.SystemColors.Window;
            this.ClientEdit_bOK.Location = new System.Drawing.Point(13, 60);
            this.ClientEdit_bOK.Name = "ClientEdit_bOK";
            this.ClientEdit_bOK.Size = new System.Drawing.Size(75, 23);
            this.ClientEdit_bOK.TabIndex = 6;
            this.ClientEdit_bOK.Text = "Зберегти";
            this.ClientEdit_bOK.UseVisualStyleBackColor = false;
            this.ClientEdit_bOK.Click += new System.EventHandler(this.ClientEdit_bOK_Click);
            // 
            // Client_editPNTBox
            // 
            this.Client_editPNTBox.Location = new System.Drawing.Point(15, 27);
            this.Client_editPNTBox.Name = "Client_editPNTBox";
            this.Client_editPNTBox.Size = new System.Drawing.Size(173, 20);
            this.Client_editPNTBox.TabIndex = 10;
            this.Client_editPNTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Client_editPNTBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Номер телефону";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ClientEdit_bOK);
            this.panel1.Controls.Add(this.ClientEdit_bCancel);
            this.panel1.Controls.Add(this.Client_editPNTBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 105);
            this.panel1.TabIndex = 16;
            // 
            // Client_Edit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 105);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Client_Edit_Form";
            this.Text = "Client_Edit_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClientEdit_bCancel;
        private System.Windows.Forms.Button ClientEdit_bOK;
        private System.Windows.Forms.TextBox Client_editPNTBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}