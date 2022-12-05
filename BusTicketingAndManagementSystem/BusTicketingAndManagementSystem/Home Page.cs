using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BusTicketingAndManagementSystem
{
    public partial class Home_Page : Form
    {
        
        public Home_Page()
        {
            InitializeComponent();
            //  Load();
            
        }

        private void btnPrint_Click(object sender, System.EventArgs e)
        {
            try
            {
                Connection.Connection.DB();
                Function.Function.gen = "Insert into Passenger(firstName,lastName,phoneNumber,date)values('"+txtFirstName.Text+"','"+txtLastName.Text+"','"+txtPhoneNumber.Text+"','"+DateTime.Now.ToString("yyyy-MM-dd")+"')";
                Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
                Function.Function.command.ExecuteNonQuery();
                Connection.Connection.con.Close();
                MessageBox.Show("Done", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadMe()
        {
            
            Connection.Connection.DB();
            Function.Function.gen = "Select TicketNumber FROM Passenger";
            Function.Function.command = new SqlCommand(Function.Function.gen, Connection.Connection.con);
            Function.Function.reader = Function.Function.command.ExecuteReader();
            
            txtTextNumber.Text = Function.Function.reader["TicketNumber"].ToString(); ;
            
            Function.Function.reader.Close();
            

            
        }



        private void Home_Page_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'busTicketingAndManagementDataSet.ticket' table. You can move, or remove it, as needed.
            this.ticketTableAdapter.Fill(this.busTicketingAndManagementDataSet.ticket);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fare, amount, change;
            double.TryParse(txtFarePrice.Text, out fare);
            double.TryParse(txtAmount.Text, out amount);
            
            change = amount - fare;
            if(change > 0)
                txtChange.Text = change.ToString("c".Remove(0,1));
            
        }
    }
}
