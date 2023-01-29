
namespace Ponomarev_N
{
    partial class boleznHistory
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
            this.components = new System.ComponentModel.Container();
            this.dataGridHistory = new System.Windows.Forms.DataGridView();
            this.historyAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ponomarev_NDataSet = new Ponomarev_N.Ponomarev_NDataSet();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_petName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_openZakluch = new System.Windows.Forms.Button();
            this.historyTableAdapter = new Ponomarev_N.Ponomarev_NDataSetTableAdapters.historyTableAdapter();
            this.zcodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПитомцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.болезньDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаболеванияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВыздоровленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zmethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ponomarev_NDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridHistory
            // 
            this.dataGridHistory.AllowUserToAddRows = false;
            this.dataGridHistory.AllowUserToDeleteRows = false;
            this.dataGridHistory.AutoGenerateColumns = false;
            this.dataGridHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zcodDataGridViewTextBoxColumn,
            this.кодПитомцаDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.болезньDataGridViewTextBoxColumn,
            this.датаЗаболеванияDataGridViewTextBoxColumn,
            this.датаВыздоровленияDataGridViewTextBoxColumn,
            this.zmethodDataGridViewTextBoxColumn});
            this.dataGridHistory.DataSource = this.historyAdapterBindingSource;
            this.dataGridHistory.Location = new System.Drawing.Point(12, 182);
            this.dataGridHistory.Name = "dataGridHistory";
            this.dataGridHistory.ReadOnly = true;
            this.dataGridHistory.Size = new System.Drawing.Size(932, 401);
            this.dataGridHistory.TabIndex = 0;
            this.dataGridHistory.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHistory_CellEnter);
            // 
            // historyAdapterBindingSource
            // 
            this.historyAdapterBindingSource.DataMember = "historyAdapter";
            this.historyAdapterBindingSource.DataSource = this.ponomarev_NDataSet;
            // 
            // ponomarev_NDataSet
            // 
            this.ponomarev_NDataSet.DataSetName = "Ponomarev_NDataSet";
            this.ponomarev_NDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ponomarev_N.Properties.Resources.history;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // lb_petName
            // 
            this.lb_petName.AutoSize = true;
            this.lb_petName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lb_petName.Location = new System.Drawing.Point(295, 87);
            this.lb_petName.Name = "lb_petName";
            this.lb_petName.Size = new System.Drawing.Size(18, 25);
            this.lb_petName.TabIndex = 60;
            this.lb_petName.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 25);
            this.label1.TabIndex = 61;
            this.label1.Text = "История болезни питомца:";
            // 
            // btn_openZakluch
            // 
            this.btn_openZakluch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_openZakluch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_openZakluch.Location = new System.Drawing.Point(12, 115);
            this.btn_openZakluch.Name = "btn_openZakluch";
            this.btn_openZakluch.Size = new System.Drawing.Size(129, 61);
            this.btn_openZakluch.TabIndex = 85;
            this.btn_openZakluch.Text = "Просмотр заключения";
            this.btn_openZakluch.UseVisualStyleBackColor = true;
            this.btn_openZakluch.Click += new System.EventHandler(this.btn_openZakluch_Click);
            // 
            // historyTableAdapter
            // 
            this.historyTableAdapter.ClearBeforeFill = true;
            // 
            // zcodDataGridViewTextBoxColumn
            // 
            this.zcodDataGridViewTextBoxColumn.DataPropertyName = "zcod";
            this.zcodDataGridViewTextBoxColumn.HeaderText = "Код записи";
            this.zcodDataGridViewTextBoxColumn.Name = "zcodDataGridViewTextBoxColumn";
            this.zcodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодПитомцаDataGridViewTextBoxColumn
            // 
            this.кодПитомцаDataGridViewTextBoxColumn.DataPropertyName = "Код питомца";
            this.кодПитомцаDataGridViewTextBoxColumn.HeaderText = "Код питомца";
            this.кодПитомцаDataGridViewTextBoxColumn.Name = "кодПитомцаDataGridViewTextBoxColumn";
            this.кодПитомцаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодПитомцаDataGridViewTextBoxColumn.Visible = false;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            this.имяDataGridViewTextBoxColumn.Visible = false;
            // 
            // болезньDataGridViewTextBoxColumn
            // 
            this.болезньDataGridViewTextBoxColumn.DataPropertyName = "Болезнь";
            this.болезньDataGridViewTextBoxColumn.HeaderText = "Болезнь";
            this.болезньDataGridViewTextBoxColumn.Name = "болезньDataGridViewTextBoxColumn";
            this.болезньDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаЗаболеванияDataGridViewTextBoxColumn
            // 
            this.датаЗаболеванияDataGridViewTextBoxColumn.DataPropertyName = "Дата заболевания";
            this.датаЗаболеванияDataGridViewTextBoxColumn.HeaderText = "Дата заболевания";
            this.датаЗаболеванияDataGridViewTextBoxColumn.Name = "датаЗаболеванияDataGridViewTextBoxColumn";
            this.датаЗаболеванияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаВыздоровленияDataGridViewTextBoxColumn
            // 
            this.датаВыздоровленияDataGridViewTextBoxColumn.DataPropertyName = "Дата выздоровления";
            this.датаВыздоровленияDataGridViewTextBoxColumn.HeaderText = "Дата выздоровления";
            this.датаВыздоровленияDataGridViewTextBoxColumn.Name = "датаВыздоровленияDataGridViewTextBoxColumn";
            this.датаВыздоровленияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zmethodDataGridViewTextBoxColumn
            // 
            this.zmethodDataGridViewTextBoxColumn.DataPropertyName = "zmethod";
            this.zmethodDataGridViewTextBoxColumn.HeaderText = "zmethod";
            this.zmethodDataGridViewTextBoxColumn.Name = "zmethodDataGridViewTextBoxColumn";
            this.zmethodDataGridViewTextBoxColumn.ReadOnly = true;
            this.zmethodDataGridViewTextBoxColumn.Visible = false;
            // 
            // boleznHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 595);
            this.Controls.Add(this.btn_openZakluch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_petName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridHistory);
            this.Name = "boleznHistory";
            this.Text = "История болезни";
            this.Load += new System.EventHandler(this.boleznHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ponomarev_NDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridHistory;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_petName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_openZakluch;
        private System.Windows.Forms.BindingSource historyAdapterBindingSource;
        private Ponomarev_NDataSet ponomarev_NDataSet;
        private Ponomarev_NDataSetTableAdapters.historyTableAdapter historyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn zcodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПитомцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn болезньDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаболеванияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыздоровленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zmethodDataGridViewTextBoxColumn;
    }
}