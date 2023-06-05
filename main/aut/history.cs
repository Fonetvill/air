using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main.aut
{
    public partial class history : Form
    {
        private bool isLoaded = false;
        private int passengerId;

        public history(int passengerId)
        {
            InitializeComponent();
            this.passengerId = passengerId;
        }
        private void history_Load(object sender, EventArgs e)
        {
            this.flightsTableAdapter.Fill(this.airDataSet.Flights);
            if (!isLoaded)
            {
                dataGridView1.Columns.Add("BookingId", "Booking ID");
                dataGridView1.Columns.Add("PassengerId", "Passenger ID");
                dataGridView1.Columns.Add("FirstName", "First Name");
                dataGridView1.Columns.Add("LastName", "Last Name");
                dataGridView1.Columns.Add("FlightNumber", "Flight Number");
                dataGridView1.Columns.Add("DepartureAirport", "Departure Airport");
                dataGridView1.Columns.Add("DepartureTime", "Departure Time");
                dataGridView1.Columns.Add("ArrivalAirport", "Arrival Airport");
                dataGridView1.Columns.Add("ArrivalTime", "Arrival Time");
                dataGridView1.Columns.Add("IsCompleted", "IsCompleted");
                dataGridView1.Columns["BookingId"].Visible = true;
                dataGridView1.Columns["PassengerId"].Visible = true;
                dataGridView1.Columns["IsCompleted"].Visible = true;
                SqlConnection conn = new SqlConnection(Connection.con);
                try
                {
                    conn.Open();
                    string query = "SELECT [dbo].[Bookings].[BookingId], [dbo].[Passengers].[PassengerId], [dbo].[Passengers].[FirstName], " +
                        "[dbo].[Passengers].[LastName], [dbo].[Flights].[FlightNumber], [dbo].[Flights].[DepartureAirport], " +
                        "[dbo].[Flights].[DepartureTime], [dbo].[Flights].[ArrivalAirport], [dbo].[Flights].[ArrivalTime] ,[dbo].[Flights].[IsCompleted]" +
                        "FROM [dbo].[Bookings], [dbo].[Passengers], [dbo].[Flights] " +
                        "WHERE [dbo].[Bookings].[PassengerId] = @PassengerId AND [dbo].[Flights].[IsCompleted] = 1 AND " +
                        "[dbo].[Passengers].[PassengerId] = [dbo].[Bookings].[PassengerId] AND " +
                        "[dbo].[Flights].[FlightId] = [dbo].[Bookings].[FlightId]";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PassengerId", passengerId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows == false)
                    {
                        MessageBox.Show("Данные не найдены!");
                        this.Close();
                    }
                    else
                    {
                        while (reader.Read())
                        {
                            bool isCompleted = (bool)reader[9];
                            if (isCompleted)
                            {
                                dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7], reader[8], reader[9]);
                            }
                        }
                    }
                    reader.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

                isLoaded = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
