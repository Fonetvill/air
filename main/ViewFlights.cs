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
    public partial class ViewFlights : Form
    {
        public ViewFlights()
        {
            InitializeComponent();
        }
        private DataGridViewColumn col;
        private void ViewFlights_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.Flights". При необходимости она может быть перемещена или удалена.
            this.flightsTableAdapter.Fill(this.airDataSet.Flights);
            flightsBindingSource.Filter = "";
            flightNumberComboBox.Text = "Все";
            departureAirportComboBox.Text = "Все";
            arrivalAirportComboBox.Text = "Все";
        }
        private void flightNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void departureAirportComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void arrivalAirportComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void FilterBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Connection.con);
            try
            {
                conn.Open();
                string flightNumber = flightNumberComboBox.SelectedItem.ToString();
                string departureAirport = departureAirportComboBox.SelectedItem.ToString();
                string arrivalAirport = arrivalAirportComboBox.SelectedItem.ToString();
                string query = "SELECT * FROM [dbo].[Flights] WHERE 1 = 1";
                if (flightNumber != "Все")
                    query += " AND FlightNumber = '" + flightNumber + "'";
                if (departureAirport != "Все")
                    query += " AND DepartureAirport = '" + departureAirport + "'";
                if (arrivalAirport != "Все")
                    query += " AND ArrivalAirport = '" + arrivalAirport + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                flightsDataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        private void CancellBtn_Click(object sender, EventArgs e)
        {
            flightNumberComboBox.SelectedItem = null;
            departureAirportComboBox.SelectedItem = null;
            arrivalAirportComboBox.SelectedItem = null;
            flightNumberComboBox.Text = "Все";
            departureAirportComboBox.Text = "Все";
            arrivalAirportComboBox.Text = "Все";
            flightsBindingSource.Filter ="";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            col = new DataGridViewColumn();
            col = flightsDataGridView.Columns[4];
            flightsDataGridView.Sort(col, System.ComponentModel.ListSortDirection.Ascending);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            col = new DataGridViewColumn();
            col = flightsDataGridView.Columns[4];
            flightsDataGridView.Sort(col, System.ComponentModel.ListSortDirection.Descending);
        }
    }
}
