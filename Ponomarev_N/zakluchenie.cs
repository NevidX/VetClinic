using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;
using System.Diagnostics;
using Microsoft.Office.Interop.Word;

namespace Ponomarev_N
{
    public partial class zakluchenie : Form
    {

        private Main _mainForm;
        string _petName;
        string _clientName;
        string _statusCod;
        string _currentZakluchText;
        string _zdate2;
        public zakluchenie(Main mainForm, string petName,string clientName,string statusCod, string currentZakluchText, string zdate2)
        {
            InitializeComponent();
            _petName = petName;
            _clientName = clientName;
            _mainForm = mainForm;
            _statusCod = statusCod;
            _zdate2 = zdate2;
            _currentZakluchText = currentZakluchText;
        }

        private void zakluchenie_Load(object sender, EventArgs e)
        {
            
            lb_petName.Text = _petName;
            lb_clientName.Text = _clientName;
           if(_statusCod == "1")
            {
                txt_zakluch.Text = "";
                btn_finishZapic.Enabled = true;
                btn_cancelZapic.Enabled = true;
                txt_zakluch.ReadOnly = false;
                lb_dateText.Visible = false;
                btn_zakDoc.Enabled = false;

            }
            else
            {
                lb_zdate2.Text = _zdate2;
                txt_zakluch.ReadOnly = true;
                btn_finishZapic.Enabled = false;
                btn_cancelZapic.Enabled = false;
                

                txt_zakluch.Text = _currentZakluchText;
                txt_zakluch.SelectionStart = 0;
                txt_zakluch.SelectionLength = 0;
            }
        }

        private void btn_finishZapic_Click(object sender, EventArgs e)
        {
            _mainForm.GetInfoZakluch(txt_zakluch.Text, "2");
            this.Close();
        }

        private void btn_cancelZapic_Click(object sender, EventArgs e)
        {
            _mainForm.GetInfoZakluch(txt_zakluch.Text, "3");
            this.Close();
        }
        void ExportToWord()
        {
            // Create a new Microsoft Word application object
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();

            wordApp.Visible = true;
            var wordDocument = wordApp.Documents.Add();

            var zakluchParagraph = wordDocument.Content.Paragraphs.Add();
            zakluchParagraph.Range.Text = "Заключение врача";
            zakluchParagraph.Range.Bold = 1;
            zakluchParagraph.Range.Font.Size = 14;
            zakluchParagraph.Range.Font.Name = "Arial";
            zakluchParagraph.Range.InsertParagraphAfter();

            var clientParagraph = wordDocument.Content.Paragraphs.Add();
            clientParagraph.Range.Text = "Клиент: " + lb_clientName.Text;
            clientParagraph.Range.InsertParagraphAfter();

            var petParagraph = wordDocument.Content.Paragraphs.Add();
            petParagraph.Range.Text = "Питомец: " + lb_petName.Text;
            petParagraph.Range.InsertParagraphAfter();

            var dateParagraph = wordDocument.Content.Paragraphs.Add();
            dateParagraph.Range.Text = "Дата заключения: " + lb_zdate2.Text;
            dateParagraph.Range.InsertParagraphAfter();

            var txtParagraph = wordDocument.Content.Paragraphs.Add();
            txtParagraph.Range.Text = txt_zakluch.Text;
            txtParagraph.Range.InsertParagraphAfter();

            // Сохраняем документ
            string filename = "ExportedData.docx";
            wordDocument.SaveAs2(filename);

            // Открываем документ
            wordApp.Visible = true;
            wordDocument = wordApp.Documents.Open(filename);
        }


        private void btn_zakDoc_Click(object sender, EventArgs e)
        {
            ExportToWord();
        }
    }
}
