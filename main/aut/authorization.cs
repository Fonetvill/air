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
    public partial class authorization : Form
    {
        public authorization()
        {
            InitializeComponent();
        }

        public int id;
        public string name;
        public string Log;
        private void button1_Click(object sender, EventArgs e)
        {
            string logUser = LogTxt.Text;
            string passUser = PassTxt.Text;
            string email = EmailTxt.Text;
            SqlConnection conn = new SqlConnection(Connection.con);
            if (button1.Text == "Войти")
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT * FROM [dbo].[Accounts] WHERE [Username]='{logUser}' AND [Password]='{passUser}'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int? idValue = reader.IsDBNull(reader.GetOrdinal("PassengerId")) ? null : (int?)reader["PassengerId"];
                        
                        reader.Close();
                        if (idValue.HasValue)
                        {
                            id = idValue.Value;
                            string query1 = $"SELECT * FROM [dbo].[Passengers] WHERE [PassengerId]='{id}'";
                            SqlCommand cmd1 = new SqlCommand(query1, conn);
                            SqlDataReader reader1 = cmd1.ExecuteReader();
                            if (reader1.Read())
                            {
                                name = (string)reader1["FirstName"] + " " + (string)reader1["LastName"];
                            }
                            else
                            {
                                MessageBox.Show("Не верный логин и пароль!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            reader1.Close();
                        }
                        else
                        {
                            id = 0;
                        }

                        MessageBox.Show("Вы успешно вошли!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Log = LogTxt.Text;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Не верный логин и пароль!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO [Accounts] (Username, Password, Email, PassengerId, FlightHistoryId) " +
                   "VALUES (@Username, @Password, @Email, @PassengerId, @FlightHistoryId)";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        if (string.IsNullOrEmpty(LogTxt.Text) || string.IsNullOrEmpty(PassTxt.Text) ||
           string.IsNullOrEmpty(EmailTxt.Text))
                        {
                            MessageBox.Show("Пожалуйста, заполните все поля.");
                            return;
                        }
                        // Задаем параметры
                        command.Parameters.AddWithValue("@Username", logUser);
                        command.Parameters.AddWithValue("@Password", passUser);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@PassengerId", DBNull.Value);
                        command.Parameters.AddWithValue("@FlightHistoryId", DBNull.Value);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Запись успешно создана
                            MessageBox.Show("Аккаунт успешно создан.");
                            button1.Text = "Войти";
                            EmailTxt.Visible = false;
                            label3.Visible = false;
                            label4.Visible = false;
                            linkLabel1.Visible = true;
                            LogTxt.Text = "";
                            PassTxt.Text = "";
                        }
                        else
                        {
                            // Произошла ошибка при создании записи
                            MessageBox.Show("Ошибка при создании аккаунта.");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Не получилось сохранить данные ", "Ошибка", MessageBoxButtons.OK);
                }
            }
        }
        private void authorization_Load(object sender, EventArgs e)
        {
            EmailTxt.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel1.Text == "Нету аккаунта ?")
            {
                EmailTxt.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                button1.Text = "Зарегестрироваться";
                linkLabel1.Text = "Выйти";
            }
            else
            {
                button1.Text = "Войти";
                EmailTxt.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                linkLabel1.Visible = true;
                LogTxt.Text = "";
                PassTxt.Text = "";
                linkLabel1.Text = "Нету аккаунта ?";
            }
        }
    }
}
