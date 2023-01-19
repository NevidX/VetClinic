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
using System.Windows.Forms.DataVisualization.Charting;
using word = Microsoft.Office.Interop.Word;

namespace Ponomarev_N
{
    /*TODO: Нужно сделать: 
     *  
     * 
     * - поиск в форме запись и форме оплата
     * 
     * форму, где будет статистика с диаграммой болезней.
    - сделать роли
    - сделать разные иконки на формах 
    */
    public partial class Main : Form
    {

        SqlConnection sqlConnection = new SqlConnection(connectionLink.connectionString);
        SqlDataAdapter sqlDataAdapter;
        DataSet dataSet;
        SqlCommand cmd;


        // Экземпляр класса Methods для доступа к глобальным методам

        Methods method = new Methods();


       DataBase dataBase = new DataBase();


        void BindDataToChart()
        {
            DataTable table = new DataTable();
            // Заполняем DataTable данными из таблицы bolezn
            table = ponomarev_NDataSet1.Tables["bolezn"];
            table.DefaultView.RowFilter = "bcount > 0";
            // Привязываем DataTable к Chart
            chartBolezn.DataSource = table;
            // Назначаем Chart привязанные данные
            chartBolezn.Series[0].ChartType = SeriesChartType.Pie;
            chartBolezn.Series[0].XValueMember = "bnam";
            chartBolezn.Series[0].YValueMembers = "bcount";
            chartBolezn.Series[0].IsValueShownAsLabel = true;
            Random random = new Random();
            // Цвета для каждой секции диаграммы
            for (int i = 0; i < chartBolezn.Series[0].Points.Count; i++)
            {
                chartBolezn.Series[0].Points[i].Color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            }
            chartBolezn.Series[0].IsVisibleInLegend = true;
            // Вызываем метод Chart.DataBind() для отображения данных на диаграмме
            chartBolezn.DataBind();
        }
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ponomarev_NDataSet1.OplataAdapter". При необходимости она может быть перемещена или удалена.
            this.oplataTableAdapter.Fill(this.ponomarev_NDataSet1.OplataAdapter);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ponomarev_NDataSet11.ZapicAdapter". При необходимости она может быть перемещена или удалена.
            this.zapicAdapterTableAdapter.Fill(this.ponomarev_NDataSet11.ZapicAdapter);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ponomarev_NDataSet1.pet". При необходимости она может быть перемещена или удалена.
            this.petTableAdapter.Fill(this.ponomarev_NDataSet1.pet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ponomarev_NDataSet1.bolezn". При необходимости она может быть перемещена или удалена.
            this.boleznTableAdapter.Fill(this.ponomarev_NDataSet1.bolezn);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ponomarev_NDataSet6.FIOVrach". При необходимости она может быть перемещена или удалена.
            this.fIOVrachTableAdapter.Fill(this.ponomarev_NDataSet6.FIOVrach);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ponomarev_NDataSet5.status". При необходимости она может быть перемещена или удалена.
            this.statusTableAdapter.Fill(this.ponomarev_NDataSet5.status);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ponomarev_NDataSet4.dolg". При необходимости она может быть перемещена или удалена.
            this.dolgTableAdapter.Fill(this.ponomarev_NDataSet4.dolg);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ponomarev_NDataSet3.ZapicAdapter". При необходимости она может быть перемещена или удалена.
            this.fIOTableAdapter.Fill(this.ponomarev_NDataSet1.FIOAdapter);


            this.clientTableAdapter.Fill(this.ponomarev_NDataSet1.client);
           
            this.dolgTableAdapter.Fill(this.ponomarev_NDataSet2.dolg);
           
            this.vrachiTableAdapter.Fill(this.ponomarev_NDataSet1.DataTableVrachi);
           
            this.uslugiTableAdapter.Fill(this.ponomarev_NDataSet1.uslugi);

            dtp_zdate.Format = DateTimePickerFormat.Custom;
            dtp_zdate.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            #region Таблица - клиенты

            #endregion

            #region Таблица - запись

            cb_pcod.Enabled = false;
            cb_ctel.Enabled = false;
            cb_scod.Enabled = false;
            cmb_dcod.Enabled = false;
            dtp_zdate.Enabled = false;
            cb_statusCod.Enabled = false;
            btn_editZapic.Enabled = false;
            cb_bnam.Enabled = false;
            btn_addZapic.Enabled = false;
            btn_delZapic.Enabled = false;
            cb_ucod.Enabled = false;
            #endregion

            #region Таблица - оплата
            btn_documentOplata.Enabled = false;
            btn_acceptOplata.Enabled = false;
            btn_cancelOplata.Enabled = false;
            #endregion

            #region Таблица - болезни
            
            BindDataToChart();
            #endregion
            dataBase.GetList("Sotr", dataGridUsers);
            dataBase.GetList("Client", dataGridClients);
            



        }

       
        // Strip menu 
        
        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Кнопка выводи форму авторизации
            var LoginForm = new log_in();
            LoginForm.Show();
        }

     


        #region Таблицы

        #region Таблица - пользователи
       // Кнопка добавления нового пользователя
        private void btn_userAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите добавить запись?", "Добавить запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Иницилизируем методы, проверяющие правильность значений
                if (!method.ValidateEmptyValues(tabPage3) || method.CheckIfValueExists(txt_slogin, "slogin", "Sotr", "логин") == true || method.CheckIfValueExists(txt_stel, "stel", "Sotr", "телефон") == true)
                {
                    return;
                }
                else
                {

                    // создаем запрос insert для того, что бы занести новую инфо в таблицу.
                    string query = "Insert into Sotr (snam,sfam,sotch,stel,dcod,slogin,spass) values (@snam,@sfam,@sotch,@stel,@dcod,@slogin,@spass)";
                    cmd = new SqlCommand(query, sqlConnection);
                    // Берем введеные пользователем параметры и передаем их.
                    cmd.Parameters.AddWithValue("@snam", txt_snam.Text);
                    cmd.Parameters.AddWithValue("@sfam", txt_sfam.Text);
                    cmd.Parameters.AddWithValue("@sotch", txt_sotch.Text);
                    cmd.Parameters.AddWithValue("@stel", txt_stel.Text);
                    cmd.Parameters.AddWithValue("@dcod", Convert.ToString(cb_dcod.SelectedValue));
                    cmd.Parameters.AddWithValue("@slogin", txt_slogin.Text);
                    cmd.Parameters.AddWithValue("@spass", txt_spass.Text);
                    cmd.Connection = sqlConnection;
                    sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    // Обновляем таблицу
                    dataBase.GetList("Sotr", dataGridUsers);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            
          
        }
        // Предупреждение об удалении записи из таблицы
        private void btn_userDel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удалить запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Delete from Sotr where scod=@scod";
                cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.AddWithValue("@scod", dataGridUsers.CurrentRow.Cells[0].Value);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                dataBase.GetList("Sotr", dataGridUsers);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
           

        }
        // Кнопка редактированя записи
        private void btn_userEdit_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите отредактировать запись?", "Редактировать запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (!method.ValidateEmptyValues(tabPage3) || method.CheckIfValueExistsEdit(txt_slogin, "slogin", "Sotr","логин",currentScod,"scod") == true || method.CheckIfValueExistsEdit(txt_stel, "stel", "Sotr","телефон",currentScod, "scod") == true)
                {
                    return;
                }
                else
                {
                    // Запрос на обновление введнных полей.
                    string query = "Update Sotr set snam=@snam,sfam = @sfam, sotch=@sotch,stel=@stel,dcod=@dcod,slogin=@slogin,spass=@spass where scod=@scod";
                    cmd = new SqlCommand(query, sqlConnection);
                    // Передаем введнные данные.

                    cmd.Parameters.AddWithValue("@snam", txt_snam.Text);
                    cmd.Parameters.AddWithValue("@sfam", txt_sfam.Text);
                    cmd.Parameters.AddWithValue("@sotch", txt_sotch.Text);
                    cmd.Parameters.AddWithValue("@stel", txt_stel.Text);
                    cmd.Parameters.AddWithValue("@dcod", Convert.ToString(cb_dcod.SelectedValue));
                    cmd.Parameters.AddWithValue("@slogin", txt_slogin.Text);
                    cmd.Parameters.AddWithValue("@spass", txt_spass.Text);
                    cmd.Parameters.AddWithValue("@scod", Convert.ToInt32(currentScod));
                    cmd.Connection = sqlConnection;
                    sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    dataBase.GetList("Sotr", dataGridUsers);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            
        }

        string currentScod; // Переменная, которая хранит в себе текущий первичный код scod
        // Метод при нажатии на запись, все данные передаются в textBox и comboBox
        private void dataGridUsers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            currentScod = dataGridUsers.CurrentRow.Cells[0].Value.ToString();
            txt_snam.Text = dataGridUsers.CurrentRow.Cells[1].Value.ToString();
            txt_sfam.Text = dataGridUsers.CurrentRow.Cells[2].Value.ToString();
            txt_sotch.Text = dataGridUsers.CurrentRow.Cells[3].Value.ToString();
            txt_stel.Text = dataGridUsers.CurrentRow.Cells[4].Value.ToString();
            cb_dcod.SelectedValue = dataGridUsers.CurrentRow.Cells[5].Value.ToString();
            txt_slogin.Text = dataGridUsers.CurrentRow.Cells[6].Value.ToString();
            txt_spass.Text = dataGridUsers.CurrentRow.Cells[7].Value.ToString();


        }

        

        private void btn_clear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите очистить все значения?", "Очистить значения", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                method.ClearTextBoxes(tabPage3);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            
        }
        // Предотвращение ввода цифр в поля, который предназначены, только для букв
        private void txt_snam_KeyPress(object sender, KeyPressEventArgs e)
        {
            method.CheckIfNumber(sender, e);
        }
        private void txt_sfam_KeyPress(object sender, KeyPressEventArgs e)
        {
            method.CheckIfNumber(sender, e);
        }

        private void txt_sotch_KeyPress(object sender, KeyPressEventArgs e)
        {
            method.CheckIfNumber(sender, e);
        }



        #endregion

        #region Таблица - клиенты
        string currentCcod;
        // Метод добавления клиента
        private void btn_addClient_Click(object sender, EventArgs e)
        {
            // Иницилизируем методы, проверяющие правильность значений
            if (!method.ValidateEmptyValues(tabPage4) || method.CheckIfValueExists(txt_ctel, "ctel", "Client","телефон") == true)
            {
                return;
            }
            else
            {

                // создаем запрос insert для того, что бы занести новую инфо в таблицу.
                string query = "Insert into Client (cnam,cfam,cotch,ctel) values (@cnam,@cfam,@cotch,@ctel)";
                cmd = new SqlCommand(query, sqlConnection);
                // Берем введеные пользователем параметры и передаем их.
                cmd.Parameters.AddWithValue("@cnam", txt_cnam.Text);
                cmd.Parameters.AddWithValue("@cfam", txt_cfam.Text);
                cmd.Parameters.AddWithValue("@cotch", txt_cotch.Text);
                cmd.Parameters.AddWithValue("@ctel",txt_ctel.Text);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                // Обновляем таблицу
                dataBase.GetList("Client", dataGridClients);
            }
        }
        // Метод удаления клиента
        private void btn_delClient_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удалить запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Delete from Client where ccod=@ccod";
                cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.AddWithValue("@ccod", currentCcod);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                dataBase.GetList("Client", dataGridClients);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

        }
        // Метод редактирования клиента
        private void btn_editClient_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите отредактировать запись?", "Редактировать запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (!method.ValidateEmptyValues(tabPage4) || method.CheckIfValueExistsEdit(txt_ctel, "ctel", "Client", "телефон",currentCcod,"ccod") == true)
                {
                    return;
                }
                else
                {

                    // Запрос на обновление введнных полей.
                    string query = "Update Client set cnam=@cnam,cfam = @cfam, cotch=@cotch,ctel=@ctel where ccod=@ccod";
                    cmd = new SqlCommand(query, sqlConnection);
                    // Передаем введнные данные.

                    cmd.Parameters.AddWithValue("@cnam", txt_cnam.Text);
                    cmd.Parameters.AddWithValue("@cfam", txt_cfam.Text);
                    cmd.Parameters.AddWithValue("@cotch", txt_cotch.Text);
                    cmd.Parameters.AddWithValue("@ctel", txt_ctel.Text);
                    cmd.Parameters.AddWithValue("@ccod", Convert.ToInt32(currentCcod));
                    cmd.Connection = sqlConnection;
                    sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    dataBase.GetList("Client", dataGridClients);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        // Метод очистки значений
        private void btn_clearClient_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите очистить все значения?", "Очистить значения", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                method.ClearTextBoxes(tabPage4);
                btn_editPet.Enabled = false;

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void dataGridClients_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            currentCcod = dataGridClients.CurrentRow.Cells[0].Value.ToString();
            btn_editPet.Enabled = true;
            txt_cnam.Text = dataGridClients.CurrentRow.Cells[1].Value.ToString();
            txt_cfam.Text = dataGridClients.CurrentRow.Cells[2].Value.ToString();
            txt_cotch.Text = dataGridClients.CurrentRow.Cells[3].Value.ToString();
            txt_ctel.Text = dataGridClients.CurrentRow.Cells[4].Value.ToString();
        }
        // Предотвращение ввода цифр в поля, который предназначены, только для букв
        private void txt_cnam_KeyPress(object sender, KeyPressEventArgs e)
        {
            method.CheckIfNumber(sender, e);
        }

        private void txt_cfam_KeyPress(object sender, KeyPressEventArgs e)
        {
            method.CheckIfNumber(sender, e);
        }

        private void txt_cotch_KeyPress(object sender, KeyPressEventArgs e)
        {
            method.CheckIfNumber(sender, e);
        }
        #endregion

        #region  Таблица - петомцы

        private void btn_editPet_Click(object sender, EventArgs e)
        {
            var PetomecForm = new petomec();
            PetomecForm.SetSelectedClientId(currentCcod);
            PetomecForm.ShowDialog();

        }

        #endregion

        #region Таблица - запись
        string currentPcod;

        private void cb_cnam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_pcod.Enabled = true;
            cb_ctel.Enabled = true;
            cb_scod.Enabled = true;
            cmb_dcod.Enabled = true;
            dtp_zdate.Enabled = true;
            cb_statusCod.Enabled = true;
            btn_editZapic.Enabled = true;
            cb_bnam.Enabled = true;
            btn_addZapic.Enabled = true;
            btn_delZapic.Enabled = true;
            cb_ucod.Enabled = true;
            // Извлекаем текущйи код клиента
            currentCcod = Convert.ToString(cb_cnam.SelectedValue);


            // Извлекаем информацию о выбранном клиенте из базы данных
            string connectionString = connectionLink.connectionString;
            string query = "SELECT * FROM Client WHERE ccod = @ccod"; // В эту переменную будет заносится код питомца у выбранного клиента
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ccod", currentCcod);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Заполняем другие элементы управления в завимости от выбранной инфо
                        cb_ctel.Text = reader["ctel"].ToString();
                    }
                }
            }
            try
            {
                petListCbTableAdapter.Fill(this.ponomarev_NDataSet7.PetListCb, Convert.ToInt32(currentCcod)); // Заполняем combobox питомец, исходя из выбранного клиента.
                currentPcod = Convert.ToString(cb_pcod.SelectedValue);
            }
            catch (FormatException)
            {
                Application.Exit();
            }

        }



        string currentDcod;
        private void cb_scod_SelectedIndexChanged(object sender, EventArgs e)
        {

            currentDcod = Convert.ToString(cb_scod.SelectedValue);


            try
            {
                dolgVrachTableAdapter.Fill(this.ponomarev_NDataSet12.DolgVrach, Convert.ToInt32(currentDcod)); 
            }
            catch (FormatException)
            {
                Application.Exit();
            }
        }

        private void btn_infoPet_Click(object sender, EventArgs e)
        {
            var PetomecForm = new petomec();
            PetomecForm.SetSelectedClientId(currentCcod);
            PetomecForm.ShowDialog();
        }
        private void btn_addZapic_Click(object sender, EventArgs e)
        {
            // Иницилизируем методы, проверяющие правильность значений
            // создаем запрос insert для того, что бы занести новую инфо в таблицу.
            string query = "Insert into Zapic (ccod,pcod,scod,zdate,statusCod,bcod,dcod,ucod) values (@ccod,@pcod,@scod,@zdate,@statusCod,@bcod,@dcod,@ucod)";
            cmd = new SqlCommand(query, sqlConnection);
            // Берем введеные пользователем параметры и передаем их.
            cmd.Parameters.AddWithValue("@ccod", Convert.ToString(cb_cnam.SelectedValue));
            cmd.Parameters.AddWithValue("@pcod", Convert.ToInt32(currentPcod));
            cmd.Parameters.AddWithValue("@scod", Convert.ToString(cb_scod.SelectedValue));
            cmd.Parameters.AddWithValue("@zdate", dtp_zdate.Value);
            cmd.Parameters.AddWithValue("@statusCod", Convert.ToString(cb_statusCod.SelectedValue));
            cmd.Parameters.AddWithValue("@bcod", Convert.ToString(cb_bnam.SelectedValue));
            cmd.Parameters.AddWithValue("@dcod", Convert.ToString(cmb_dcod.SelectedValue));
            cmd.Parameters.AddWithValue("@ucod", Convert.ToString(cb_ucod.SelectedValue));
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            // Обновляем таблицу
            this.zapicAdapterTableAdapter.Fill(this.ponomarev_NDataSet11.ZapicAdapter);

        }


        private void btn_delZapic_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удалить запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Delete from Zapic where zcod=@zcod";
                cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.AddWithValue("@zcod", currentZcod);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                // Обновляем таблицу
                this.zapicAdapterTableAdapter.Fill(this.ponomarev_NDataSet11.ZapicAdapter);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        string preCbSatusCod;
        private void btn_editZapic_Click(object sender, EventArgs e)
        {
       
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите изменить статус?", "Изменить статус", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes )
            {

                if(Convert.ToString(cb_statusCod.SelectedValue)  != preCbSatusCod)
                {
                    // Запрос на обновление введнных полей.
                    string query = "Update Zapic set statusCod=@statusCod where zcod=@zcod";
                    cmd = new SqlCommand(query, sqlConnection);
                    // Передаем введнные данные.
                    cmd.Parameters.AddWithValue("@zcod", Convert.ToString(currentZcod));
                    cmd.Parameters.AddWithValue("@statusCod", Convert.ToString(cb_statusCod.SelectedValue));
                    cmd.Connection = sqlConnection;
                    sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    this.zapicAdapterTableAdapter.Fill(this.ponomarev_NDataSet11.ZapicAdapter);
                    this.oplataTableAdapter.Fill(this.ponomarev_NDataSet1.OplataAdapter);
                }
                else
                {
                    MessageBox.Show("Новый статус должен отличаться от предыдущего!");
                    return;
                }
                
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        private void btn_clearZapic_Click(object sender, EventArgs e)
        {
        }
        string currentZcod;

        private void dataGridZapic_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                currentZcod = dataGridZapic.CurrentRow.Cells[0].Value.ToString();
                cb_cnam.SelectedValue = dataGridZapic.CurrentRow.Cells[10].Value.ToString();
                cb_pcod.SelectedValue = dataGridZapic.CurrentRow.Cells[11].Value.ToString();
                cb_ctel.Text = dataGridZapic.CurrentRow.Cells[4].Value.ToString();
                cb_scod.SelectedValue = dataGridZapic.CurrentRow.Cells[12].Value.ToString();
                cb_statusCod.SelectedValue = dataGridZapic.CurrentRow.Cells[14].Value.ToString();
                preCbSatusCod = dataGridZapic.CurrentRow.Cells[14].Value.ToString();
                cb_bnam.SelectedValue = dataGridZapic.CurrentRow.Cells[15].Value.ToString();
                cb_ucod.SelectedValue = dataGridZapic.CurrentRow.Cells[16].Value.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Выберите строку");
            }
        }

        #endregion

        #region Таблица - услуги

        private void btn_addUslugi_Click(object sender, EventArgs e)
        {
            // Иницилизируем методы, проверяющие правильность значений
            if (!method.ValidateEmptyValues(tabPage1) || method.CheckIfValueExists(txt_unam,"unam","uslugi","название услуги") == true)
            {
                return;
            }
            else
            {

                // создаем запрос insert для того, что бы занести новую инфо в таблицу.
                string query = "Insert into uslugi (unam,ucena) values (@unam,@ucena)";
                cmd = new SqlCommand(query, sqlConnection);
                // Берем введеные пользователем параметры и передаем их.
                cmd.Parameters.AddWithValue("@unam", txt_unam.Text);
                cmd.Parameters.AddWithValue("@ucena", txt_ucena.Text);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                // Обновляем таблицу
                this.uslugiTableAdapter.Fill(this.ponomarev_NDataSet1.uslugi);
            }
        }
        string currentUcod;
        private void btn_delUslugi_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удалить запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Delete from uslugi where ucod=@ucod";
                cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.AddWithValue("@ucod", currentUcod);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                this.uslugiTableAdapter.Fill(this.ponomarev_NDataSet1.uslugi);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_uslugiEdit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите отредактировать запись?", "Редактировать запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (!method.ValidateEmptyValues(tabPage1) || method.CheckIfValueExistsEdit(txt_unam,"unam","uslugi","название услуги",currentUcod,"ucod") == true)
                {
                    return;
                }
                else
                {

                    // Запрос на обновление введнных полей.
                    string query = "Update uslugi set unam=@unam,ucena = @ucena where ucod=@ucod";
                    cmd = new SqlCommand(query, sqlConnection);
                    // Передаем введнные данные.
                    cmd.Parameters.AddWithValue("@ucod", currentUcod);
                    cmd.Parameters.AddWithValue("@unam", txt_unam.Text);
                    cmd.Parameters.AddWithValue("@ucena", txt_ucena.Text);
                    cmd.Connection = sqlConnection;
                    sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    this.uslugiTableAdapter.Fill(this.ponomarev_NDataSet1.uslugi);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_clearUslugi_Click(object sender, EventArgs e)
        {
            method.ClearTextBoxes(tabPage1);
        }
        private void dataGridUslugi_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            currentUcod = dataGridUslugi.CurrentRow.Cells[0].Value.ToString();
            txt_unam.Text = dataGridUslugi.CurrentRow.Cells[1].Value.ToString();
            txt_ucena.Text = dataGridUslugi.CurrentRow.Cells[2].Value.ToString();
           
        }
        #endregion

        #region Таблица - болезни

        
        private void btn_addBolezn_Click(object sender, EventArgs e)
        {
            // Иницилизируем методы, проверяющие правильность значений
            if (!method.ValidateEmptyValues(tabPage6) || method.CheckIfValueExists(txt_bnam, "bnam", "bolezn", "название болезни") == true)
            {
                return;
            }
            else
            {

                // создаем запрос insert для того, что бы занести новую инфо в таблицу.
                string query = "Insert into bolezn (bnam) values (@bnam)";
                cmd = new SqlCommand(query, sqlConnection);
                // Берем введеные пользователем параметры и передаем их.
                cmd.Parameters.AddWithValue("@bnam", txt_bnam.Text);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                // Обновляем таблицу
                dataBase.GetList("bolezn", dataGridBolezn);
            }
        }
        string currentBcod;
        private void btn_delBolezn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удалить запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Delete from bolezn where bcod=@bcod";
                cmd = new SqlCommand(query, sqlConnection);
                cmd.Parameters.AddWithValue("@bcod", currentBcod);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                dataBase.GetList("bolezn", dataGridBolezn);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_EditBolezn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите отредактировать запись?", "Редактировать запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (!method.ValidateEmptyValues(tabPage1) || method.CheckIfValueExistsEdit(txt_bnam, "bnam", "bolezn", "название услуги", currentBcod, "bcod") == true)
                {
                    return;
                }
                else
                {

                    // Запрос на обновление введнных полей.
                    string query = "Update bolezn set bnam=@bnam where bcod=@bcod";
                    cmd = new SqlCommand(query, sqlConnection);
                    // Передаем введнные данные.
                    cmd.Parameters.AddWithValue("@bcod", currentBcod);
                    cmd.Parameters.AddWithValue("@bnam", txt_bnam.Text);
                    cmd.Connection = sqlConnection;
                    sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    dataBase.GetList("bolezn", dataGridBolezn);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_clearBolezn_Click(object sender, EventArgs e)
        {
            method.ClearTextBoxes(tabPage6);
        }

        private void dataGridBolezn_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            currentBcod = dataGridBolezn.CurrentRow.Cells[0].Value.ToString();
            txt_bnam.Text = dataGridBolezn.CurrentRow.Cells[1].Value.ToString();
        }
        #endregion

        #region Таблица - оплата
        private void btn_acceptOplata_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите подтвердить оплату?", "Подтвердить оплату", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                if (Convert.ToString(cb_statusCod.SelectedValue) != preCbSatusCod)
                {
                    // Запрос на обновление введнных полей.
                    string query = "Update Oplata set oplStatusCod=@oplStatusCod where ocod=@ocod";
                    cmd = new SqlCommand(query, sqlConnection);
                    // Передаем введнные данные.
                    cmd.Parameters.AddWithValue("@ocod", Convert.ToString(currentOcod));
                    cmd.Parameters.AddWithValue("@oplStatusCod", 2);
                    cmd.Connection = sqlConnection;
                    sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    this.zapicAdapterTableAdapter.Fill(this.ponomarev_NDataSet11.ZapicAdapter);
                    this.oplataTableAdapter.Fill(this.ponomarev_NDataSet1.OplataAdapter);
                }
                else
                {
                    
                    MessageBox.Show("Новый статус должен отличаться от предыдущего!");
                    return;
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        private void btn_cancelOplata_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите подтвердить оплату?", "Подтвердить оплату", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                
                    // Запрос на обновление введнных полей.
                    string query = "Update Oplata set oplStatusCod=@oplStatusCod where ocod=@ocod";
                    cmd = new SqlCommand(query, sqlConnection);
                    // Передаем введнные данные.
                    cmd.Parameters.AddWithValue("@ocod", Convert.ToString(currentOcod));
                    cmd.Parameters.AddWithValue("@oplStatusCod", 3);
                    cmd.Connection = sqlConnection;
                    sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    this.zapicAdapterTableAdapter.Fill(this.ponomarev_NDataSet11.ZapicAdapter);
                    this.oplataTableAdapter.Fill(this.ponomarev_NDataSet1.OplataAdapter);
                
               

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_documentOplata_Click(object sender, EventArgs e)
        {
            // Create a new Word application
            word.Application wordApp = new word.Application();

            // Create a new Word document
            word.Document doc = wordApp.Documents.Add();

            // Add a table to the document
            word.Table table = doc.Tables.Add(doc.Range(), 2, 8);
            table.Borders.Enable = 1;

            // Get the index of the selected row
            int rowIndex = dataGridOplata.CurrentCell.RowIndex;

            // Fill the table with data from the DataGridView
            for (int i = 0; i < 8; i++)
            {
                if(i >= 0 && i <= 8)
                {
                    table.Cell(1, i + 1).Range.Text = dataGridOplata.Columns[i].HeaderText;
                    table.Cell(2, i + 1).Range.Text = dataGridOplata[i, rowIndex].Value.ToString();
                }
                
            }

            // Save the document
            string filename = "ExportedData.docx";
            doc.SaveAs2(filename);

            // Open the document
            wordApp.Visible = true;
            doc = wordApp.Documents.Open(filename);

            // Close the Word application
            //wordApp.Quit();
        }


        string currentOcod;
        private void dataGridOplata_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            currentOcod = dataGridOplata.CurrentRow.Cells[0].Value.ToString();
            if(dataGridOplata.CurrentRow.Cells[14].Value.ToString() == "2")
            {
                btn_documentOplata.Enabled = true;
                btn_cancelOplata.Enabled = false;
            }
            else if(dataGridOplata.CurrentRow.Cells[14].Value.ToString() == "1" )
            {
                btn_acceptOplata.Enabled = true;
                btn_cancelOplata.Enabled = true;
                btn_documentOplata.Enabled = false;
            }
            else if (dataGridOplata.CurrentRow.Cells[14].Value.ToString() == "3" )
            {
                btn_cancelOplata.Enabled = false;
                btn_acceptOplata.Enabled = false;
                btn_documentOplata.Enabled = true;
            }
            else
            {
                btn_cancelOplata.Enabled = true;
            }
        }
        
        #endregion


        #endregion








        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void cmb_dcod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_statusCod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
