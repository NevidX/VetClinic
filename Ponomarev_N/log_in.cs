using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ponomarev_N
{
    public partial class log_in : Form
    {
        SqlConnection connection;
        public log_in()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=DESKTOP-FKVQ8KB\SQLEXPRESS;Initial Catalog=Ponomarev_N;Integrated Security=True");
        }

        private void log_in_Load(object sender, EventArgs e)
        {
            txt_login.Font = new Font("Microsoft Sans Serif", 16.0f);
            txt_pass.Font = new Font("Microsoft Sans Serif", 16.0f);

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // Объявляем переменные, в которые будем передавать вводимые пользователем данные.
            var loginUser = txt_login.Text;
            var passUser = txt_pass.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            // Создаем переменную - запрос, и обращаемся к базе данных, проверяем есть ли у нас такой пользователь с таким паролем.
            string querystring = $"select slogin, spass from sotr where slogin='{loginUser}' and spass = '{passUser}'";
            // Подключение к базе данных.
            SqlCommand command = new SqlCommand(querystring, connection);

            adapter.SelectCommand = command;
            adapter.Fill(table);
            // Проверяем если найдена запись, то выдаем соообщение об успешной авторизации, если нет, говорим, 
            // Проверяем если найдена запись, то выдаем соообщение об успешной авторизации, если нет, говорим, что такого аккаунта не существует.
            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}