
namespace Ponomarev_N
{
    partial class zakluchenie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.txt_zakluch = new System.Windows.Forms.TextBox();
            this.btn_finishZapic = new System.Windows.Forms.Button();
            this.btn_cancelZapic = new System.Windows.Forms.Button();
            this.lb_txtPet = new System.Windows.Forms.Label();
            this.lb_petName = new System.Windows.Forms.Label();
            this.lb_txtClient = new System.Windows.Forms.Label();
            this.lb_clientName = new System.Windows.Forms.Label();
            this.lb_dateText = new System.Windows.Forms.Label();
            this.lb_zdate2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.boleznTableAdapter1 = new Ponomarev_N.Ponomarev_NDataSetTableAdapters.boleznTableAdapter();
            this.btn_zakDoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(72, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 25);
            this.label10.TabIndex = 53;
            this.label10.Text = "Заключение врача";
            // 
            // txt_zakluch
            // 
            this.txt_zakluch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_zakluch.Location = new System.Drawing.Point(12, 166);
            this.txt_zakluch.MaxLength = 500;
            this.txt_zakluch.Multiline = true;
            this.txt_zakluch.Name = "txt_zakluch";
            this.txt_zakluch.Size = new System.Drawing.Size(449, 410);
            this.txt_zakluch.TabIndex = 54;
            // 
            // btn_finishZapic
            // 
            this.btn_finishZapic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_finishZapic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_finishZapic.Location = new System.Drawing.Point(12, 586);
            this.btn_finishZapic.Name = "btn_finishZapic";
            this.btn_finishZapic.Size = new System.Drawing.Size(201, 28);
            this.btn_finishZapic.TabIndex = 55;
            this.btn_finishZapic.Text = "Завершить прием";
            this.btn_finishZapic.UseVisualStyleBackColor = true;
            this.btn_finishZapic.Click += new System.EventHandler(this.btn_finishZapic_Click);
            // 
            // btn_cancelZapic
            // 
            this.btn_cancelZapic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelZapic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_cancelZapic.Location = new System.Drawing.Point(12, 620);
            this.btn_cancelZapic.Name = "btn_cancelZapic";
            this.btn_cancelZapic.Size = new System.Drawing.Size(201, 28);
            this.btn_cancelZapic.TabIndex = 56;
            this.btn_cancelZapic.Text = "Отказать в приеме";
            this.btn_cancelZapic.UseVisualStyleBackColor = true;
            this.btn_cancelZapic.Click += new System.EventHandler(this.btn_cancelZapic_Click);
            // 
            // lb_txtPet
            // 
            this.lb_txtPet.AutoSize = true;
            this.lb_txtPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lb_txtPet.Location = new System.Drawing.Point(12, 106);
            this.lb_txtPet.Name = "lb_txtPet";
            this.lb_txtPet.Size = new System.Drawing.Size(114, 25);
            this.lb_txtPet.TabIndex = 57;
            this.lb_txtPet.Text = "Питомец:";
            // 
            // lb_petName
            // 
            this.lb_petName.AutoSize = true;
            this.lb_petName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lb_petName.Location = new System.Drawing.Point(119, 106);
            this.lb_petName.Name = "lb_petName";
            this.lb_petName.Size = new System.Drawing.Size(30, 25);
            this.lb_petName.TabIndex = 58;
            this.lb_petName.Text = "   ";
            // 
            // lb_txtClient
            // 
            this.lb_txtClient.AutoSize = true;
            this.lb_txtClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lb_txtClient.Location = new System.Drawing.Point(12, 81);
            this.lb_txtClient.Name = "lb_txtClient";
            this.lb_txtClient.Size = new System.Drawing.Size(94, 25);
            this.lb_txtClient.TabIndex = 59;
            this.lb_txtClient.Text = "Клиент:";
            // 
            // lb_clientName
            // 
            this.lb_clientName.AutoSize = true;
            this.lb_clientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lb_clientName.Location = new System.Drawing.Point(96, 81);
            this.lb_clientName.Name = "lb_clientName";
            this.lb_clientName.Size = new System.Drawing.Size(30, 25);
            this.lb_clientName.TabIndex = 60;
            this.lb_clientName.Text = "   ";
            // 
            // lb_dateText
            // 
            this.lb_dateText.AutoSize = true;
            this.lb_dateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lb_dateText.Location = new System.Drawing.Point(12, 131);
            this.lb_dateText.Name = "lb_dateText";
            this.lb_dateText.Size = new System.Drawing.Size(201, 25);
            this.lb_dateText.TabIndex = 61;
            this.lb_dateText.Text = "Дата заключения:";
            // 
            // lb_zdate2
            // 
            this.lb_zdate2.AutoSize = true;
            this.lb_zdate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lb_zdate2.Location = new System.Drawing.Point(204, 131);
            this.lb_zdate2.Name = "lb_zdate2";
            this.lb_zdate2.Size = new System.Drawing.Size(30, 25);
            this.lb_zdate2.TabIndex = 62;
            this.lb_zdate2.Text = "   ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Ponomarev_N.Properties.Resources.free_icon_clipboard_1647909;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // boleznTableAdapter1
            // 
            this.boleznTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_zakDoc
            // 
            this.btn_zakDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_zakDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_zakDoc.Location = new System.Drawing.Point(219, 620);
            this.btn_zakDoc.Name = "btn_zakDoc";
            this.btn_zakDoc.Size = new System.Drawing.Size(201, 28);
            this.btn_zakDoc.TabIndex = 63;
            this.btn_zakDoc.Text = "Документ";
            this.btn_zakDoc.UseVisualStyleBackColor = true;
            this.btn_zakDoc.Click += new System.EventHandler(this.btn_zakDoc_Click);
            // 
            // zakluchenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 660);
            this.Controls.Add(this.btn_zakDoc);
            this.Controls.Add(this.lb_zdate2);
            this.Controls.Add(this.lb_dateText);
            this.Controls.Add(this.lb_clientName);
            this.Controls.Add(this.lb_txtClient);
            this.Controls.Add(this.lb_petName);
            this.Controls.Add(this.lb_txtPet);
            this.Controls.Add(this.btn_cancelZapic);
            this.Controls.Add(this.btn_finishZapic);
            this.Controls.Add(this.txt_zakluch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox3);
            this.Name = "zakluchenie";
            this.Text = "Заключение врача";
            this.Load += new System.EventHandler(this.zakluchenie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_zakluch;
        private System.Windows.Forms.Button btn_finishZapic;
        private System.Windows.Forms.Button btn_cancelZapic;
        private System.Windows.Forms.Label lb_txtPet;
        private System.Windows.Forms.Label lb_petName;
        private System.Windows.Forms.Label lb_txtClient;
        private System.Windows.Forms.Label lb_clientName;
        private System.Windows.Forms.Label lb_dateText;
        private System.Windows.Forms.Label lb_zdate2;
        private Ponomarev_NDataSetTableAdapters.boleznTableAdapter boleznTableAdapter1;
        private System.Windows.Forms.Button btn_zakDoc;
    }
}