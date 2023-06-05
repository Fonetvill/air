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
    public partial class Ticket : Form
    {
        private int passengerId;
        private bool isLoaded = false;

        public Ticket(int passengerId)
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.passengerId = passengerId;
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.Passengers". При необходимости она может быть перемещена или удалена.
            this.passengersTableAdapter.Fill(this.airDataSet.Passengers);
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
                dataGridView1.Columns["BookingId"].Visible = false;
                dataGridView1.Columns["PassengerId"].Visible = false;
                dataGridView1.Columns["IsCompleted"].Visible = false;

                SqlConnection conn = new SqlConnection(Connection.con);
                try
                {
                    conn.Open();//открыть подключение
                    string query = "SELECT [dbo].[Bookings].[BookingId], [dbo].[Passengers].[PassengerId], [dbo].[Passengers].[FirstName], " +
                        "[dbo].[Passengers].[LastName], [dbo].[Flights].[FlightNumber], [dbo].[Flights].[DepartureAirport], " +
                        "[dbo].[Flights].[DepartureTime], [dbo].[Flights].[ArrivalAirport], [dbo].[Flights].[ArrivalTime] ,[dbo].[Flights].[IsCompleted]" +
                        "FROM [dbo].[Bookings], [dbo].[Passengers], [dbo].[Flights] " +
                        "WHERE [dbo].[Bookings].[PassengerId] = @PassengerId  AND " +
                        "[dbo].[Passengers].[PassengerId] = [dbo].[Bookings].[PassengerId] AND " +
                        "[dbo].[Flights].[FlightId] = [dbo].[Bookings].[FlightId]";


                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PassengerId", passengerId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows == false)
                    {
                        MessageBox.Show("данные не найдены!");
                    }
                    else
                    {
                        while (reader.Read())
                        {
                            bool isCompleted = (bool)reader[9];
                            if (isCompleted==false)
                            {
                                dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7], reader[8], reader[9]);

                            }
                        }
                    }

                    reader.Close();
                    conn.Close();//закрыть подключение
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                // Получите значение ключа, которое необходимо удалить
                int bookingId = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells["BookingId"].Value);

                // Показать подтверждающий диалог перед удалением
                DialogResult result = MessageBox.Show("Вы уверены, что хотите вернуть билет назад?",
                    "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Удалите строку из базы данных
                    using (SqlConnection conn = new SqlConnection(Connection.con))
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM [dbo].[Bookings] WHERE [BookingId] = @BookingId";
                        SqlCommand deleteCommand = new SqlCommand(deleteQuery, conn);
                        deleteCommand.Parameters.AddWithValue("@BookingId", bookingId);
                        deleteCommand.ExecuteNonQuery();
                    }
                    // Удалите выбранную строку из DataGridView
                    dataGridView1.Rows.RemoveAt(selectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Выберите строку .");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}