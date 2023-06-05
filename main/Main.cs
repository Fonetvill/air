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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private int PassId;
        private string LogUser;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            aut.authorization aut = new aut.authorization();
            aut.ShowDialog();
            PassId = aut.id;
            if (PassId != 0)

            {
                panel1.Visible = true;
                label2.Text = aut.name;
                LogUser = aut.Log;
            }
            else
            {
                panel1.Visible = true;
                label2.Text = "";
                InfBtn.Visible = true;
                LogUser = aut.Log;
            }
        }

        

        private void ticket_btn_Click(object sender, EventArgs e)
        {
            if (PassId != 0)

            {
                aut.Ticket tik = new aut.Ticket(PassId);
                tik.Show();
            }
            else
            {
                MessageBox.Show("Cначало зарегестрируйтесь");
            }

        }

        private void ViewFlightBtn_Click(object sender, EventArgs e)
        {

            ViewFlights view = new ViewFlights();
            view.Show();

        }

        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            if (PassId != 0)

            {
                Registration reg = new Registration(PassId);
                reg.Show();
            }
            else
            {
                MessageBox.Show("Cначало зарегестрируйтесь");
            }
        }

        private void InfBtn_Click(object sender, EventArgs e)
        {
            aut.Info inf = new aut.Info();
            inf.ShowDialog();
            PassId = inf.id;
            if (PassId != 0)
            {
                SqlConnection conn = new SqlConnection(Connection.con);
                try
                {
                    conn.Open();
                    string query = "UPDATE [Accounts] SET PassengerId = @PassengerId WHERE Username = @Username";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@PassengerId", PassId);
                        command.Parameters.AddWithValue("@Username", LogUser);

                        // Выполнение запроса
                        int rowsAffected = command.ExecuteNonQuery();
                        InfBtn.Visible = false;
                        label2.Text = inf.name;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }


            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            InfBtn.Visible = false;
            panel1.Visible = false;
        }

        private void history_Click(object sender, EventArgs e)
        {
            if (PassId != 0)

            {
                aut.history his = new aut.history(PassId);
                his.ShowDialog();

            }
            else
            {
                MessageBox.Show("Cначало зарегестрируйтесь");
            }
        }
    }
}
