
namespace Ponomarev_N
{
    partial class petomec
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clearPet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pvid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_pnam = new System.Windows.Forms.TextBox();
            this.btn_editPet = new System.Windows.Forms.Button();
            this.btn_delPet = new System.Windows.Forms.Button();
            this.btn_addPet = new System.Windows.Forms.Button();
            this.txt_pvozrast = new System.Windows.Forms.TextBox();
            this.dataGridPet = new System.Windows.Forms.DataGridView();
            this.txt_pprotiv = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_posoben = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 60;
            this.label1.Text = "Питомец";
            // 
            // btn_clearPet
            // 
            this.btn_clearPet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clearPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_clearPet.Location = new System.Drawing.Point(12, 469);
            this.btn_clearPet.Name = "btn_clearPet";
            this.btn_clearPet.Size = new System.Drawing.Size(155, 36);
            this.btn_clearPet.TabIndex = 58;
            this.btn_clearPet.Text = "Очистить";
            this.btn_clearPet.UseVisualStyleBackColor = true;
            this.btn_clearPet.Click += new System.EventHandler(this.btn_clearPet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "Противопоказания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(260, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "Вид";
            // 
            // txt_pvid
            // 
            this.txt_pvid.Location = new System.Drawing.Point(263, 114);
            this.txt_pvid.MaxLength = 50;
            this.txt_pvid.Name = "txt_pvid";
            this.txt_pvid.Size = new System.Drawing.Size(117, 20);
            this.txt_pvid.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(135, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "Возраст";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(9, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 52;
            this.label7.Text = "Имя";
            // 
            // txt_pnam
            // 
            this.txt_pnam.Location = new System.Drawing.Point(12, 114);
            this.txt_pnam.MaxLength = 50;
            this.txt_pnam.Name = "txt_pnam";
            this.txt_pnam.Size = new System.Drawing.Size(117, 20);
            this.txt_pnam.TabIndex = 51;
            // 
            // btn_editPet
            // 
            this.btn_editPet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_editPet.Location = new System.Drawing.Point(12, 427);
            this.btn_editPet.Name = "btn_editPet";
            this.btn_editPet.Size = new System.Drawing.Size(155, 36);
            this.btn_editPet.TabIndex = 50;
            this.btn_editPet.Text = "Редактировать";
            this.btn_editPet.UseVisualStyleBackColor = true;
            this.btn_editPet.Click += new System.EventHandler(this.btn_editPet_Click);
            // 
            // btn_delPet
            // 
            this.btn_delPet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_delPet.Location = new System.Drawing.Point(12, 385);
            this.btn_delPet.Name = "btn_delPet";
            this.btn_delPet.Size = new System.Drawing.Size(155, 36);
            this.btn_delPet.TabIndex = 49;
            this.btn_delPet.Text = "Удалить";
            this.btn_delPet.UseVisualStyleBackColor = true;
            this.btn_delPet.Click += new System.EventHandler(this.btn_delPet_Click);
            // 
            // btn_addPet
            // 
            this.btn_addPet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_addPet.Location = new System.Drawing.Point(12, 343);
            this.btn_addPet.Name = "btn_addPet";
            this.btn_addPet.Size = new System.Drawing.Size(155, 36);
            this.btn_addPet.TabIndex = 48;
            this.btn_addPet.Text = "Добавить";
            this.btn_addPet.UseVisualStyleBackColor = true;
            this.btn_addPet.Click += new System.EventHandler(this.btn_addPet_Click);
            // 
            // txt_pvozrast
            // 
            this.txt_pvozrast.Location = new System.Drawing.Point(138, 114);
            this.txt_pvozrast.MaxLength = 50;
            this.txt_pvozrast.Name = "txt_pvozrast";
            this.txt_pvozrast.Size = new System.Drawing.Size(117, 20);
            this.txt_pvozrast.TabIndex = 53;
            this.txt_pvozrast.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pvozrast_KeyPress);
            // 
            // dataGridPet
            // 
            this.dataGridPet.AllowUserToAddRows = false;
            this.dataGridPet.AllowUserToDeleteRows = false;
            this.dataGridPet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPet.Location = new System.Drawing.Point(456, 12);
            this.dataGridPet.Name = "dataGridPet";
            this.dataGridPet.ReadOnly = true;
            this.dataGridPet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridPet.Size = new System.Drawing.Size(661, 514);
            this.dataGridPet.TabIndex = 62;
            this.dataGridPet.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPet_CellEnter);
            // 
            // txt_pprotiv
            // 
            this.txt_pprotiv.Location = new System.Drawing.Point(12, 166);
            this.txt_pprotiv.MaxLength = 500;
            this.txt_pprotiv.Multiline = true;
            this.txt_pprotiv.Name = "txt_pprotiv";
            this.txt_pprotiv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_pprotiv.Size = new System.Drawing.Size(216, 157);
            this.txt_pprotiv.TabIndex = 63;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ponomarev_N.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(12, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // txt_posoben
            // 
            this.txt_posoben.Location = new System.Drawing.Point(234, 166);
            this.txt_posoben.MaxLength = 500;
            this.txt_posoben.Multiline = true;
            this.txt_posoben.Name = "txt_posoben";
            this.txt_posoben.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_posoben.Size = new System.Drawing.Size(216, 157);
            this.txt_posoben.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(231, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Особенности";
            // 
            // petomec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 527);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_posoben);
            this.Controls.Add(this.txt_pprotiv);
            this.Controls.Add(this.dataGridPet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clearPet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_pvid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_pvozrast);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_pnam);
            this.Controls.Add(this.btn_editPet);
            this.Controls.Add(this.btn_delPet);
            this.Controls.Add(this.btn_addPet);
            this.Controls.Add(this.pictureBox2);
            this.Name = "petomec";
            this.Text = "petomec";
            this.Load += new System.EventHandler(this.petomec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clearPet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pvid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_pnam;
        private System.Windows.Forms.Button btn_editPet;
        private System.Windows.Forms.Button btn_delPet;
        private System.Windows.Forms.Button btn_addPet;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_pvozrast;
        private System.Windows.Forms.DataGridView dataGridPet;
        private System.Windows.Forms.TextBox txt_pprotiv;
        private System.Windows.Forms.TextBox txt_posoben;
        private System.Windows.Forms.Label label2;
    }
}