namespace UchetKlientov
{
    partial class fmUchet
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьУслугуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экпортВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb = new System.Windows.Forms.GroupBox();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.cbUsluga = new System.Windows.Forms.ComboBox();
            this.uslugaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientiDataSet = new UchetKlientov.KlientiDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFIOSoprovozhd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFIOKlienta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKlient = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIOKlienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIORoditela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientTableAdapter = new UchetKlientov.KlientiDataSetTableAdapters.KlientTableAdapter();
            this.tableAdapterManager = new UchetKlientov.KlientiDataSetTableAdapters.TableAdapterManager();
            this.uslugaTableAdapter = new UchetKlientov.KlientiDataSetTableAdapters.UslugaTableAdapter();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1227, 67);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.сохранитьИзмененияToolStripMenuItem,
            this.обновитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.добавитьУслугуToolStripMenuItem,
            this.экпортВExcelToolStripMenuItem,
            this.назадToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Gabriola", 16F);
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(90, 63);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(408, 64);
            this.создатьToolStripMenuItem.Text = "Сохранить нового клиента";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // сохранитьИзмененияToolStripMenuItem
            // 
            this.сохранитьИзмененияToolStripMenuItem.Name = "сохранитьИзмененияToolStripMenuItem";
            this.сохранитьИзмененияToolStripMenuItem.Size = new System.Drawing.Size(408, 64);
            this.сохранитьИзмененияToolStripMenuItem.Text = "Сохранить изменения";
            this.сохранитьИзмененияToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИзмененияToolStripMenuItem_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(408, 64);
            this.обновитьToolStripMenuItem.Text = "Обновить ";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(408, 64);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // добавитьУслугуToolStripMenuItem
            // 
            this.добавитьУслугуToolStripMenuItem.Name = "добавитьУслугуToolStripMenuItem";
            this.добавитьУслугуToolStripMenuItem.Size = new System.Drawing.Size(408, 64);
            this.добавитьУслугуToolStripMenuItem.Text = "Добавить услугу";
            this.добавитьУслугуToolStripMenuItem.Click += new System.EventHandler(this.добавитьУслугуToolStripMenuItem_Click);
            // 
            // экпортВExcelToolStripMenuItem
            // 
            this.экпортВExcelToolStripMenuItem.Name = "экпортВExcelToolStripMenuItem";
            this.экпортВExcelToolStripMenuItem.Size = new System.Drawing.Size(408, 64);
            this.экпортВExcelToolStripMenuItem.Text = "Экпорт в Excel";
            this.экпортВExcelToolStripMenuItem.Click += new System.EventHandler(this.экпортВExcelToolStripMenuItem_Click);
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(408, 64);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(408, 64);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // gb
            // 
            this.gb.Controls.Add(this.mtbPhone);
            this.gb.Controls.Add(this.label6);
            this.gb.Controls.Add(this.tbNum);
            this.gb.Controls.Add(this.cbUsluga);
            this.gb.Controls.Add(this.label5);
            this.gb.Controls.Add(this.label4);
            this.gb.Controls.Add(this.dtpDateOfBirth);
            this.gb.Controls.Add(this.label3);
            this.gb.Controls.Add(this.tbFIOSoprovozhd);
            this.gb.Controls.Add(this.label2);
            this.gb.Controls.Add(this.tbFIOKlienta);
            this.gb.Controls.Add(this.label1);
            this.gb.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb.Location = new System.Drawing.Point(0, 67);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(1227, 269);
            this.gb.TabIndex = 1;
            this.gb.TabStop = false;
            // 
            // mtbPhone
            // 
            this.mtbPhone.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPhone.Location = new System.Drawing.Point(406, 55);
            this.mtbPhone.Mask = "+7(999) 999-99-99";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(205, 39);
            this.mtbPhone.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(609, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 59);
            this.label6.TabIndex = 10;
            this.label6.Text = "№ п/п";
            // 
            // tbNum
            // 
            this.tbNum.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNum.Location = new System.Drawing.Point(705, 55);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(78, 39);
            this.tbNum.TabIndex = 11;
            // 
            // cbUsluga
            // 
            this.cbUsluga.DataSource = this.uslugaBindingSource;
            this.cbUsluga.DisplayMember = "Name";
            this.cbUsluga.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsluga.FormattingEnabled = true;
            this.cbUsluga.Location = new System.Drawing.Point(767, 105);
            this.cbUsluga.Name = "cbUsluga";
            this.cbUsluga.Size = new System.Drawing.Size(460, 42);
            this.cbUsluga.TabIndex = 9;
            // 
            // uslugaBindingSource
            // 
            this.uslugaBindingSource.DataMember = "Usluga";
            this.uslugaBindingSource.DataSource = this.klientiDataSet;
            // 
            // klientiDataSet
            // 
            this.klientiDataSet.DataSetName = "KlientiDataSet";
            this.klientiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 59);
            this.label5.TabIndex = 8;
            this.label5.Text = "Выбранная услуга";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(390, 59);
            this.label4.TabIndex = 6;
            this.label4.Text = "Номер телефона сопровождающего";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Location = new System.Drawing.Point(302, 108);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(243, 39);
            this.dtpDateOfBirth.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 59);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата рождения клиента";
            // 
            // tbFIOSoprovozhd
            // 
            this.tbFIOSoprovozhd.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFIOSoprovozhd.Location = new System.Drawing.Point(284, 215);
            this.tbFIOSoprovozhd.Name = "tbFIOSoprovozhd";
            this.tbFIOSoprovozhd.Size = new System.Drawing.Size(941, 39);
            this.tbFIOSoprovozhd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 59);
            this.label2.TabIndex = 2;
            this.label2.Text = "ФИО сопровождающего";
            // 
            // tbFIOKlienta
            // 
            this.tbFIOKlienta.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFIOKlienta.Location = new System.Drawing.Point(189, 162);
            this.tbFIOKlienta.Name = "tbFIOKlienta";
            this.tbFIOKlienta.Size = new System.Drawing.Size(1038, 39);
            this.tbFIOKlienta.TabIndex = 1;
            this.tbFIOKlienta.TextChanged += new System.EventHandler(this.tbFIOKlienta_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО клиента";
            // 
            // dgvKlient
            // 
            this.dgvKlient.AllowUserToAddRows = false;
            this.dgvKlient.AllowUserToDeleteRows = false;
            this.dgvKlient.AutoGenerateColumns = false;
            this.dgvKlient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKlient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvKlient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.FIOKlienta,
            this.FIORoditela,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvKlient.DataSource = this.klientBindingSource;
            this.dgvKlient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKlient.Location = new System.Drawing.Point(0, 336);
            this.dgvKlient.Name = "dgvKlient";
            this.dgvKlient.ReadOnly = true;
            this.dgvKlient.RowHeadersVisible = false;
            this.dgvKlient.RowTemplate.Height = 28;
            this.dgvKlient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlient.Size = new System.Drawing.Size(1227, 345);
            this.dgvKlient.TabIndex = 3;
            this.dgvKlient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvKlient_MouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.FillWeight = 30F;
            this.dataGridViewTextBoxColumn1.HeaderText = "№ п/п";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // FIOKlienta
            // 
            this.FIOKlienta.DataPropertyName = "FIOKlienta";
            this.FIOKlienta.HeaderText = "ФИО клиента";
            this.FIOKlienta.Name = "FIOKlienta";
            this.FIOKlienta.ReadOnly = true;
            // 
            // FIORoditela
            // 
            this.FIORoditela.DataPropertyName = "FIORoditela";
            this.FIORoditela.HeaderText = "ФИО родителей";
            this.FIORoditela.Name = "FIORoditela";
            this.FIORoditela.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер телефона";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateOfBirth";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Usluga";
            this.dataGridViewTextBoxColumn5.HeaderText = "Услуга";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataMember = "Klient";
            this.klientBindingSource.DataSource = this.klientiDataSet;
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AvtorizaciaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KlientTableAdapter = this.klientTableAdapter;
            this.tableAdapterManager.UpdateOrder = UchetKlientov.KlientiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UslugaTableAdapter = null;
            // 
            // uslugaTableAdapter
            // 
            this.uslugaTableAdapter.ClearBeforeFill = true;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.Image = global::UchetKlientov.Properties.Resources.PlayDay;
            this.pbLogo.Location = new System.Drawing.Point(800, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(427, 150);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 10;
            this.pbLogo.TabStop = false;
            // 
            // fmUchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 59F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1227, 681);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.dgvKlient);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Gabriola", 16F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.Name = "fmUchet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет клиентов";
            this.Load += new System.EventHandler(this.fmUchet_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзмененияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private KlientiDataSet klientiDataSet;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private KlientiDataSetTableAdapters.KlientTableAdapter klientTableAdapter;
        private KlientiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvKlient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUsluga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFIOSoprovozhd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFIOKlienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIOKlienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIORoditela;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource uslugaBindingSource;
        private KlientiDataSetTableAdapters.UslugaTableAdapter uslugaTableAdapter;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьУслугуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экпортВExcelToolStripMenuItem;
    }
}