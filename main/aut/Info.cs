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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }
        public int id;
        public string name;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Connection.con);
            try
            {
                conn.Open();
                if (string.IsNullOrEmpty(firstNameTextBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text) ||
          string.IsNullOrEmpty(genderComboBox.Text) ||
        string.IsNullOrEmpty(phoneTextBox.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                    return;
                }
                int age = (int)ageNumericUpDown.Value;

                string query = "INSERT INTO [Passengers] (FirstName, LastName, Age, Gender, Phone) " +
                   "VALUES (@FirstName, @LastName, @Age, @Gender, @Phone); SELECT @@IDENTITY";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    // Задаем параметры
                    command.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text);
                    command.Parameters.AddWithValue("@LastName", lastNameTextBox.Text);
                    command.Parameters.AddWithValue("@Age", age);
                    command.Parameters.AddWithValue("@Gender", genderComboBox.Text);
                    command.Parameters.AddWithValue("@Phone", phoneTextBox.Text);

                    id = Convert.ToInt32(command.ExecuteScalar());

                    if (id > 0)
                    {
                        // Ваш остальной код после успешной вставки записи
                        name = firstNameTextBox.Text + " " + lastNameTextBox.Text;
                        MessageBox.Show("Аккаунт успешно создан.");
                        ClearForm();
                        this.Close();
                    }
                    else
                    {
                        // Произошла ошибка при создании записи
                        MessageBox.Show("Ошибка при создании аккаунта.");
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar));
        }
        private void ClearForm()
        {
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            ageNumericUpDown.Value = 18;
            genderComboBox.SelectedIndex = -1;
            phoneTextBox.Text = string.Empty;
        }
    }
}
