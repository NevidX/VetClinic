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
    public partial class boleznHistory : Form
    {
        SqlConnection sqlConnection = new SqlConnection(connectionLink.connectionString);
        Methods method = new Methods();
        DataBase dataBase = new DataBase();
        SqlConnection connection;
        SqlDataAdapter sqlDataAdapter;
        DataSet dataSet;
        SqlCommand cmd;

        private Form _mainForm;
        string _petName;
        string _pcod;
        public boleznHistory(Form mainForm, string petName,string pcod)
        {
            InitializeComponent();
            connection = new SqlConnection(connectionLink.connectionString);
            _petName = petName;
            _mainForm = mainForm;
            _pcod = pcod;
        }

        private void GetPetHistory()
        {
            string selectSql = "SELECT pet.pcod AS 'Код питомца', pet.pnam AS 'Имя', bolezn.bnam AS 'Болезнь', zapic.zdate AS 'Дата заболевания', zapic.zdate2 AS 'Дата выздоровления', zapic.zcod, zapic.zmethod FROM bolezn INNER JOIN zapic ON bolezn.bcod = zapic.bcod INNER JOIN pet ON zapic.pcod = pet.pcod WHERE(pet.pcod = @pcod)";
            SqlCommand selectCommand = new SqlCommand(selectSql, connection);
            selectCommand.Parameters.AddWithValue("@pcod", _pcod);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridHistory.DataSource = dt;
        }

        private void boleznHistory_Load(object sender, EventArgs e)
        {
            lb_petName.Text = _petName;
            GetPetHistory();
        }

        private void btn_openZakluch_Click(object sender, EventArgs e)
        {
            if(currentZakluch == null)
            {
                MessageBox.Show("Сначала выберите запись", "Внимание!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(currentZakluch, "Заключение врача", MessageBoxButtons.OK);
            }
        }
        string currentZakluch;
        private void dataGridHistory_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            currentZakluch = dataGridHistory.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
