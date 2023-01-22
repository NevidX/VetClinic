using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;

namespace Ponomarev_N
    
{
    class Methods
    {
        // Ссылка на подключение
        string connectionString = connectionLink.connectionString;
        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;
        SqlCommand cmd;
        DataSet dataSet;
        #region Методы
        /// <summary>
        /// Метод очищения textBox и Combox
        /// </summary>
        public void ClearTextBoxes(TabPage tabPageName)
        {
            // Запускаем цикл, который проходится по всем элементам управления, в текущем TabPage
            foreach (Control control in tabPageName.Controls)
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
                if (control is DateTimePicker)
                {
                    control.Text = string.Empty;
                }
            }
        }

        /// <summary>
        /// Метод провери на пустые значения
        /// </summary>
        /// <param name="tabPageName"></param>
        /// <returns></returns>
       

        public bool ValidateEmptyValues(Control tabPageName, List<TextBox> ignoredTextboxes)
        {
            foreach (Control control in tabPageName.Controls)
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


        /// <summary>
        /// Метод проверки на существование введенного значения в таблице
        /// </summary>
        /// <param name="TextBoxName">Имя textBox откуда берем значение для проверки</param>
        /// <param name="valueName">Имя значения, которое хотим проверить</param>
        /// <param name="tableName">Имя таблицы, в которой будем проверять значения</param>
        /// <param name="tableName">Имя значения, которое нужно будет выводить в сообщении пользователю</param>
        /// <returns></returns>
        public bool CheckIfValueExists(Control TextBoxName, string valueName, string tableName,string alertName)
        {// Использование using гарантирует закрытие подключения к базе данных после использования
            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                connection.ConnectionString = connectionLink.connectionString;
                connection.Open();

                string query = $"SELECT COUNT(*) FROM {tableName} WHERE {valueName} = @param";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@param", TextBoxName.Text);

                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show($"Значение поля [{alertName}] должно быть уникальным");
                    flashing(TextBoxName);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name = "TextBoxName" > Имя textBox откуда берем значение для проверки</param>
        /// <param name="valueName">Имя значения, которое хотим проверить</param>
        /// <param name="tableName">Имя таблицы, в которой будем проверять значения</param>
        /// <param name="tableName">Имя значения, которое нужно будет выводить в сообщении пользователю</param>
        /// <param name="selectedRowId">Выбранная строка в данный момент, которую проверять не нужно</param>
        /// <param name="id_name">Названия первичного ключа в этой таблице</param>
        /// <returns></returns>
        public bool CheckIfValueExistsEdit(Control TextBoxName, string valueName, string tableName, string alertName, string selectedRowId, string id_name)
        {// Использование using гарантирует закрытие подключения к базе данных после использования
            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                connection.ConnectionString = connectionLink.connectionString;
                connection.Open();

                string query = $"SELECT COUNT(*) FROM {tableName} WHERE {valueName} = @param and {id_name} != @selectedRowId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@param", TextBoxName.Text);
                command.Parameters.AddWithValue("@selectedRowId", selectedRowId);

                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show($"Значение поля [{alertName}] должно быть уникальным");
                    flashing(TextBoxName);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Метод, заставляющий мигать определенный textBox
        /// </summary>
        /// <param name="TextBoxName"></param>
        public void flashing(Control TextBoxName) {
            Timer timer = new Timer();
            timer.Interval = 500;


            int counter = 0;

            
            timer.Tick += (s, e) => {
                if (counter == 5)
                {
                    // 
                    TextBoxName.BackColor = SystemColors.Window;

               
                    timer.Stop();
                }
                else
                {
                    if (TextBoxName.BackColor == SystemColors.Window)
                    {
                        TextBoxName.BackColor = Color.Red;
                    }
                    else
                    {
                        TextBoxName.BackColor = SystemColors.Window;
                    }
                }

                
                counter++;
            };

            // Запускает таймер
            timer.Start();
        }


        public void CheckIfNumber(object sender, KeyPressEventArgs e)
        {
            // Разрешает ввод только букв
           

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                DialogResult result = MessageBox.Show("Можно вводить только буквы", "Ошибка", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    return;
                }
            }

            
        }

        public void CheckIfNumberPaste(object sender, EventArgs e)
        {
            string clipboardText = Clipboard.GetText(); // Получаем то, что находится в буфере обмена пользователя.
            if (clipboardText.Any(c => char.IsNumber(c))) // Проверяем на числа
            {
                Clipboard.Clear();

                DialogResult result = MessageBox.Show("Можно вводить только буквы", "Ошибка", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    return;
                }
            }
        }

       
        //public void ChangeCellColour(DataGridView dataGridName)
        //{

        //    if (dataGridName.Columns[e.ColumnIndex].Name == "ColumnName")
        //    {
        //        if (e.Value.ToString() == "SomeValue")
        //        {
        //            e.CellStyle.BackColor = Color.Red;
        //        }
        //        else if (e.Value.ToString() == "AnotherValue")
        //        {
        //            e.CellStyle.BackColor = Color.Green;
        //        }
        //    }
        //}
        #endregion
    }
}
