using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ShoeStore
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        string connectionString = @"Server=AMISCOMPUTER\SQLEXPRESS;Database=Demo26-1;Integrated Security=True;";

        private (string role, string fio) GetUserInfo(string login, string password)
        {
            string role = "";
            string fio = "";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                    SELECT [Роль сотрудника] as Role, 
                           [Фамилия пользователя] + ' ' + [Имя пользователя] + ' ' + ISNULL([Отчество пользователя], '') as FIO 
                    FROM Пользователи 
                    WHERE Логин = @login AND Пароль = @password";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", password);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        role = reader["Role"].ToString();
                        fio = reader["FIO"].ToString();
                    }
                }
            }
            return (role, fio);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var (role, fio) = GetUserInfo(login, password);

                if (!string.IsNullOrEmpty(role))
                {
                    MessageBox.Show($"Добро пожаловать, {fio}!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Сохраняем имя пользователя
                    LoginClass.UserName = fio;
                    LoginClass.Role = role;
                    // Открыть форму со списком товаров
                    Tovar tovarForm = new Tovar();
                    tovarForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {

            LoginClass.UserName = "Гость";

            Tovar tovarForm = new Tovar();
            tovarForm.Show();
            this.Hide();
        }
    }
}