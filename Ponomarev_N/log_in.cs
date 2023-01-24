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

        string userCod;
        private void btn_login_Click(object sender, EventArgs e)
        {
            // Объявляем переменные, в которые будем передавать вводимые пользователем данные.
            var loginUser = txt_login.Text;
            var passUser = txt_pass.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            // Создаем переменную - запрос, и обращаемся к базе данных, проверяем есть ли у нас такой пользователь с таким паролем.
            // queryDcod = нужен для того, что бы передать его в основную форму и выдать соответсвующий доступы.
            string querystring = $"select slogin, spass, dcod from sotr where slogin collate SQL_Latin1_General_CP1_CS_AS = '{loginUser}'  and spass collate SQL_Latin1_General_CP1_CS_AS = '{passUser}' ";
            string queryDcod = $"select dcod from sotr where slogin collate SQL_Latin1_General_CP1_CS_AS = '{loginUser}' and spass collate SQL_Latin1_General_CP1_CS_AS = '{passUser}' ";
            // Подключение к базе данных.

            SqlCommand command = new SqlCommand(querystring, connection);
            SqlCommand command2 = new SqlCommand(queryDcod, connection);
            connection.Open();
            object result = command2.ExecuteScalar();
            userCod = Convert.ToString(result);
            connection.Close();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            // Проверяем если найдена запись, то выдаем соообщение об успешной авторизации, если нет, говорим, что такого аккаунта не существует.
            if (table.Rows.Count == 1)
            {
                var mainForm = new Main();
               
                this.Hide();
                mainForm.userValue(userCod);
                mainForm.Show();
                
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void log_in_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainForm = new Main();
            mainForm.Show();
        }
    }
    
    
}