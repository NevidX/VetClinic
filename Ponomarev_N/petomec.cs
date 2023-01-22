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
    public partial class petomec : Form
    {
        SqlConnection sqlConnection = new SqlConnection(connectionLink.connectionString);
        Methods method = new Methods();
        DataBase dataBase = new DataBase();
        SqlConnection connection;
        SqlDataAdapter sqlDataAdapter;
        DataSet dataSet;
        SqlCommand cmd;

        List<TextBox> ignoredTextboxes;
        public petomec()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionLink.connectionString);
            ignoredTextboxes = new List<TextBox>() { txt_posoben,txt_pprotiv};
        }
        private void txt_pvozrast_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void GetPet()
        {
            string selectSql = "SELECT pcod as 'Код питомца',pnam as 'Имя', pvozrast as 'Возраст', pvid as 'Вид животного', pprotiv as 'Противопоказания', posoben as 'Особенности',ccod as 'Код клиента' FROM Pet WHERE ccod = @clientId";
            SqlCommand selectCommand = new SqlCommand(selectSql, connection);
            selectCommand.Parameters.AddWithValue("@clientId", curentCcod);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridPet.DataSource = dt;
        }
        
        private void petomec_Load(object sender, EventArgs e)
        {
            GetPet();
            dataGridPet.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        string curentCcod;
        public void SetSelectedClientId(string id)
        {
            curentCcod = id;
        }

        private void btn_addPet_Click(object sender, EventArgs e)
        {
            // Иницилизируем методы, проверяющие правильность значений
            if (!ValidateEmptyValues(ignoredTextboxes))
            {
                return;
            }
            else
            {

                // создаем запрос insert для того, что бы занести новую инфо в таблицу.
                string query = "Insert into Pet (pnam,pvozrast,pvid,pprotiv,posoben,ccod) values (@pnam,@pvozrast,@pvid,@pprotiv,@posoben,@ccod)";
                cmd = new SqlCommand(query, sqlConnection);
                // Берем введеные пользователем параметры и передаем их.
                cmd.Parameters.AddWithValue("@pnam", txt_pnam.Text);
                cmd.Parameters.AddWithValue("@pvozrast", Convert.ToString(txt_pvozrast.Text));
                cmd.Parameters.AddWithValue("@pvid", txt_pvid.Text);
                cmd.Parameters.AddWithValue("@pprotiv", txt_pprotiv.Text);
                cmd.Parameters.AddWithValue("@posoben", txt_posoben.Text);
                cmd.Parameters.AddWithValue("@ccod", curentCcod);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                // Обновляем таблицу
                GetPet();
            }
        }
        private void btn_delPet_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удалить запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Delete from Pet where pcod=@pcod";
                cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.AddWithValue("@pcod", dataGridPet.CurrentRow.Cells[0].Value);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                GetPet();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_editPet_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите отредактировать запись?", "Редактировать запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (!ValidateEmptyValues(ignoredTextboxes))
                {
                    return;
                }
                else
                {
                    // Запрос на обновление введнных полей.
                    string query = "Update Pet set pnam=@pnam,pvozrast = @pvozrast, pvid=@pvid,pprotiv=@pprotiv,posoben=@posoben where pcod=@pcod";
                    cmd = new SqlCommand(query, sqlConnection);
                    // Передаем введнные данные.

                    cmd.Parameters.AddWithValue("@pnam", txt_pnam.Text);
                    cmd.Parameters.AddWithValue("@pvozrast", Convert.ToString(txt_pvozrast.Text));
                    cmd.Parameters.AddWithValue("@pvid", txt_pvid.Text);
                    cmd.Parameters.AddWithValue("@pprotiv", txt_pprotiv.Text);
                    cmd.Parameters.AddWithValue("@posoben", txt_posoben.Text);
                    cmd.Parameters.AddWithValue("@pcod", Convert.ToInt32(currentPcod));
                    cmd.Connection = sqlConnection;
                    sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    GetPet();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

       
          public bool ValidateEmptyValues(List<TextBox> ignoredTextboxes)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is ComboBox)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        if (!ignoredTextboxes.Contains(textBox)) // добавить условие проверки наличия в списке игнорируемых
                        {
                            if (string.IsNullOrEmpty(textBox.Text))
                            {
                                MessageBox.Show("Заполнены не все значения или они некорректны!");
                                return false;
                            }
                        }
                    }
                    else if (control is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)control;
                        if (comboBox.SelectedIndex == -1)
                        {
                            MessageBox.Show("Заполнены не все значения или они некорректны!");
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public void ClearTextBoxes()
        {
            // Запускаем цикл, который проходится по всем элементам управления, в текущем TabPage
            foreach (Control control in this.Controls)
            {
                // Если элемент управления является textBox очищаем его содержимое
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
                // combobox также очищаем, если находим
                if (control is ComboBox)
                {
                    (control as ComboBox).SelectedValue = -1;
                }
                // для элементов MaskedTextBox
                if (control is MaskedTextBox)
                {
                    control.Text = string.Empty;
                }
            }
        }
        string currentPcod;
        private void dataGridPet_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Переменная, которая хранит в себе текущий первичный код scod
             // Метод при нажатии на запись, все данные передаются в textBox 
            
                currentPcod = dataGridPet.CurrentRow.Cells[0].Value.ToString();
                txt_pnam.Text = dataGridPet.CurrentRow.Cells[1].Value.ToString();
                txt_pvozrast.Text = dataGridPet.CurrentRow.Cells[2].Value.ToString();
                txt_pvid.Text = dataGridPet.CurrentRow.Cells[3].Value.ToString();
                txt_pprotiv.Text = dataGridPet.CurrentRow.Cells[4].Value.ToString();
                txt_posoben.Text = dataGridPet.CurrentRow.Cells[5].Value.ToString();

         
        }
       
        private void btn_clearPet_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите очистить все значения?", "Очистить значения", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ClearTextBoxes();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
