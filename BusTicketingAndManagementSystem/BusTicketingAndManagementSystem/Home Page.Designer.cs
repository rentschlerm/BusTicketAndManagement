namespace BusTicketingAndManagementSystem
{
    partial class Home_Page
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTicketType = new System.Windows.Forms.ComboBox();
            this.ticketBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.busTicketingAndManagementDataSet = new BusTicketingAndManagementSystem.BusTicketingAndManagementDataSet();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtFarePrice = new System.Windows.Forms.TextBox();
            this.txtTextNumber = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.ticketTableAdapter = new BusTicketingAndManagementSystem.BusTicketingAndManagementDataSetTableAdapters.ticketTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busTicketingAndManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtChange);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbTicketType);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.txtFarePrice);
            this.panel1.Controls.Add(this.txtTextNumber);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 433);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Change";
            // 
            // txtChange
            // 
            this.txtChange.Enabled = false;
            this.txtChange.Location = new System.Drawing.Point(465, 257);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(67, 20);
            this.txtChange.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Enter Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(465, 231);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(67, 20);
            this.txtAmount.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ticket Number";
            // 
            // cmbTicketType
            // 
            this.cmbTicketType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource1, "ticketType", true));
            this.cmbTicketType.DataSource = this.ticketBindingSource;
            this.cmbTicketType.DisplayMember = "ticketType";
            this.cmbTicketType.FormattingEnabled = true;
            this.cmbTicketType.Location = new System.Drawing.Point(175, 223);
            this.cmbTicketType.Name = "cmbTicketType";
            this.cmbTicketType.Size = new System.Drawing.Size(140, 21);
            this.cmbTicketType.TabIndex = 5;
            // 
            // ticketBindingSource1
            // 
            this.ticketBindingSource1.DataMember = "ticket";
            this.ticketBindingSource1.DataSource = this.busTicketingAndManagementDataSet;
            // 
            // busTicketingAndManagementDataSet
            // 
            this.busTicketingAndManagementDataSet.DataSetName = "BusTicketingAndManagementDataSet";
            this.busTicketingAndManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "ticket";
            this.ticketBindingSource.DataSource = this.busTicketingAndManagementDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fare Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ticket Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(357, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Location = new System.Drawing.Point(256, 364);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtFarePrice
            // 
            this.txtFarePrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "farePrice", true));
            this.txtFarePrice.Enabled = false;
            this.txtFarePrice.Location = new System.Drawing.Point(465, 204);
            this.txtFarePrice.Name = "txtFarePrice";
            this.txtFarePrice.Size = new System.Drawing.Size(67, 20);
            this.txtFarePrice.TabIndex = 0;
            // 
            // txtTextNumber
            // 
            this.txtTextNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketBindingSource, "TicketNumber", true));
            this.txtTextNumber.Enabled = false;
            this.txtTextNumber.Location = new System.Drawing.Point(175, 256);
            this.txtTextNumber.Name = "txtTextNumber";
            this.txtTextNumber.Size = new System.Drawing.Size(140, 20);
            this.txtTextNumber.TabIndex = 0;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(175, 192);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(140, 20);
            this.txtPhoneNumber.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(175, 160);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(140, 20);
            this.txtLastName.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(175, 128);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(140, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(595, 457);
            this.Controls.Add(this.panel1);
            this.Name = "Home_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home_Page";
            this.Load += new System.EventHandler(this.Home_Page_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busTicketingAndManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTicketType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtFarePrice;
        private System.Windows.Forms.TextBox txtTextNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private BusTicketingAndManagementDataSet busTicketingAndManagementDataSet;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private BusTicketingAndManagementDataSetTableAdapters.ticketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.BindingSource ticketBindingSource1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Button button1;
    }
}