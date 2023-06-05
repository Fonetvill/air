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

namespace main
{
    public partial class Registration : Form
    {
        private int passengerId;

        public Registration(int passengerId)
        {
            InitializeComponent();
            flightsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.passengerId = passengerId;
        }

        private void passengersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.passengersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airoportDataSet1);
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            this.flightsTableAdapter.Fill(this.airDataSet.Flights);
            this.bookingsTableAdapter.Fill(this.airDataSet.Bookings);
            SqlConnection conn = new SqlConnection(Connection.con);
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            if (flightsDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = flightsDataGridView.SelectedRows[0].Index;
                DataRowView selectedFlight = (DataRowView)flightsDataGridView.Rows[selectedIndex].DataBoundItem;
                int flightId = Convert.ToInt32(selectedFlight["FlightId"]);

                // Проверка, если пассажир уже зарегистрирован на рейс
                bool isRegistered = IsPassengerRegistered(flightId);
                if (isRegistered)
                {
                    MessageBox.Show("Пассажир уже зарегистрирован на выбранный рейс.");
                    return;
                }

                // Получите пассажира из выбранной строки
                DataRowView selectedPassenger = (DataRowView)passengersBindingSource.Current;
                // Показать подтверждающий диалог перед регистрацией
                DialogResult result = MessageBox.Show("Вы уверены, что хотите зарегистрировать пассажира на выбранный рейс?",
                    "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Зарегистрировать пассажира на рейс в базе данных
                    using (SqlConnection conn = new SqlConnection(Connection.con))
                    {
                        conn.Open();
                        string insertQuery = "INSERT INTO [dbo].[Bookings] ([PassengerId], [FlightId]) VALUES (@PassengerId, @FlightId)";
                        SqlCommand insertCommand = new SqlCommand(insertQuery, conn);
                        insertCommand.Parameters.AddWithValue("@PassengerId", passengerId);
                        insertCommand.Parameters.AddWithValue("@FlightId", flightId);
                        insertCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Пассажир успешно зарегистрирован на выбранный рейс!");
                }
            }
            else
            {
                MessageBox.Show("Выберите рейс из списка.");
            }
        }


        private bool IsPassengerRegistered(int flightId)
        {

            // Получение пассажира из выбранной строки
            DataRowView selectedPassenger = (DataRowView)passengersBindingSource.Current;

            using (SqlConnection conn = new SqlConnection(Connection.con))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM [dbo].[Bookings] WHERE [PassengerId] = @PassengerId AND [FlightId] = @FlightId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PassengerId", passengerId);
                cmd.Parameters.AddWithValue("@FlightId", flightId);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
