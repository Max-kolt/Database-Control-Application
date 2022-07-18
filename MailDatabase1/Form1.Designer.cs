namespace MailDatabase1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ordersDataView = new System.Windows.Forms.DataGridView();
            this.rowsCountOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.citiesList = new System.Windows.Forms.ComboBox();
            this.filterCheck = new System.Windows.Forms.CheckBox();
            this.entryEditPanel = new System.Windows.Forms.GroupBox();
            this.daysCountBox = new System.Windows.Forms.NumericUpDown();
            this.dateTimeService = new System.Windows.Forms.DateTimePicker();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.citiesInputBox = new System.Windows.Forms.ComboBox();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.typeInputBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.adressBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fioBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDeletePhoto = new System.Windows.Forms.Button();
            this.buttonAddPhoto = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.filtersPanel = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filterInputName = new System.Windows.Forms.TextBox();
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.citiesTableAdapter1 = new MailDatabase1.MailDatabaseDataSetTableAdapters.CitiesTableAdapter();
            this.ordersTableAdapter1 = new MailDatabase1.MailDatabaseDataSetTableAdapters.OrdersTableAdapter();
            this.ordersCityTableAdapter1 = new MailDatabase1.MailDatabaseDataSetTableAdapters.OrdersCityTableAdapter();
            this.type_of_servicesTableAdapter1 = new MailDatabase1.MailDatabaseDataSetTableAdapters.Type_of_servicesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataView)).BeginInit();
            this.entryEditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daysCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.filtersPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersDataView
            // 
            this.ordersDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataView.Location = new System.Drawing.Point(12, 200);
            this.ordersDataView.Name = "ordersDataView";
            this.ordersDataView.Size = new System.Drawing.Size(564, 405);
            this.ordersDataView.TabIndex = 0;
            this.ordersDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDataView_CellClick);
            // 
            // rowsCountOutput
            // 
            this.rowsCountOutput.AutoSize = true;
            this.rowsCountOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowsCountOutput.Location = new System.Drawing.Point(12, 613);
            this.rowsCountOutput.Name = "rowsCountOutput";
            this.rowsCountOutput.Size = new System.Drawing.Size(206, 24);
            this.rowsCountOutput.TabIndex = 1;
            this.rowsCountOutput.Text = "Количество записей: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Города";
            // 
            // citiesList
            // 
            this.citiesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.citiesList.FormattingEnabled = true;
            this.citiesList.Location = new System.Drawing.Point(110, 33);
            this.citiesList.Name = "citiesList";
            this.citiesList.Size = new System.Drawing.Size(226, 32);
            this.citiesList.TabIndex = 3;
            this.citiesList.SelectedIndexChanged += new System.EventHandler(this.citiesList_SelectedIndexChanged);
            // 
            // filterCheck
            // 
            this.filterCheck.AutoSize = true;
            this.filterCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterCheck.Location = new System.Drawing.Point(361, 35);
            this.filterCheck.Name = "filterCheck";
            this.filterCheck.Size = new System.Drawing.Size(188, 28);
            this.filterCheck.TabIndex = 4;
            this.filterCheck.Text = "Включить фильтр";
            this.filterCheck.UseVisualStyleBackColor = true;
            this.filterCheck.CheckedChanged += new System.EventHandler(this.filterCheck_CheckedChanged);
            // 
            // entryEditPanel
            // 
            this.entryEditPanel.Controls.Add(this.daysCountBox);
            this.entryEditPanel.Controls.Add(this.dateTimeService);
            this.entryEditPanel.Controls.Add(this.descriptionBox);
            this.entryEditPanel.Controls.Add(this.label13);
            this.entryEditPanel.Controls.Add(this.citiesInputBox);
            this.entryEditPanel.Controls.Add(this.statusBox);
            this.entryEditPanel.Controls.Add(this.label12);
            this.entryEditPanel.Controls.Add(this.typeInputBox);
            this.entryEditPanel.Controls.Add(this.label11);
            this.entryEditPanel.Controls.Add(this.priceBox);
            this.entryEditPanel.Controls.Add(this.label10);
            this.entryEditPanel.Controls.Add(this.weightBox);
            this.entryEditPanel.Controls.Add(this.label9);
            this.entryEditPanel.Controls.Add(this.label8);
            this.entryEditPanel.Controls.Add(this.label7);
            this.entryEditPanel.Controls.Add(this.adressBox);
            this.entryEditPanel.Controls.Add(this.label6);
            this.entryEditPanel.Controls.Add(this.fioBox);
            this.entryEditPanel.Controls.Add(this.label5);
            this.entryEditPanel.Controls.Add(this.label4);
            this.entryEditPanel.Controls.Add(this.buttonDeletePhoto);
            this.entryEditPanel.Controls.Add(this.buttonAddPhoto);
            this.entryEditPanel.Controls.Add(this.pictureBox);
            this.entryEditPanel.Enabled = false;
            this.entryEditPanel.Location = new System.Drawing.Point(592, 11);
            this.entryEditPanel.Name = "entryEditPanel";
            this.entryEditPanel.Size = new System.Drawing.Size(393, 594);
            this.entryEditPanel.TabIndex = 5;
            this.entryEditPanel.TabStop = false;
            this.entryEditPanel.Text = "Данные записи";
            // 
            // daysCountBox
            // 
            this.daysCountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.daysCountBox.Location = new System.Drawing.Point(314, 285);
            this.daysCountBox.Name = "daysCountBox";
            this.daysCountBox.Size = new System.Drawing.Size(72, 29);
            this.daysCountBox.TabIndex = 35;
            // 
            // dateTimeService
            // 
            this.dateTimeService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeService.Location = new System.Drawing.Point(14, 118);
            this.dateTimeService.Name = "dateTimeService";
            this.dateTimeService.Size = new System.Drawing.Size(205, 26);
            this.dateTimeService.TabIndex = 34;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionBox.Location = new System.Drawing.Point(14, 489);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(372, 96);
            this.descriptionBox.TabIndex = 33;
            this.descriptionBox.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(10, 461);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 24);
            this.label13.TabIndex = 32;
            this.label13.Text = "Описание:";
            // 
            // citiesInputBox
            // 
            this.citiesInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.citiesInputBox.FormattingEnabled = true;
            this.citiesInputBox.Location = new System.Drawing.Point(14, 50);
            this.citiesInputBox.Name = "citiesInputBox";
            this.citiesInputBox.Size = new System.Drawing.Size(205, 32);
            this.citiesInputBox.TabIndex = 30;
            // 
            // statusBox
            // 
            this.statusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Location = new System.Drawing.Point(93, 419);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(293, 32);
            this.statusBox.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(10, 422);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 24);
            this.label12.TabIndex = 28;
            this.label12.Text = "Статус:";
            // 
            // typeInputBox
            // 
            this.typeInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeInputBox.FormattingEnabled = true;
            this.typeInputBox.Location = new System.Drawing.Point(66, 328);
            this.typeInputBox.Name = "typeInputBox";
            this.typeInputBox.Size = new System.Drawing.Size(320, 32);
            this.typeInputBox.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(202, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 24);
            this.label11.TabIndex = 26;
            this.label11.Text = "Цена:";
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceBox.Location = new System.Drawing.Point(267, 374);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(119, 29);
            this.priceBox.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(10, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 24);
            this.label10.TabIndex = 24;
            this.label10.Text = "Вес:";
            // 
            // weightBox
            // 
            this.weightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightBox.Location = new System.Drawing.Point(66, 374);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(115, 29);
            this.weightBox.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(10, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Тип:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(10, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(298, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Количество дней для доставки:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(10, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Адрес:";
            // 
            // adressBox
            // 
            this.adressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressBox.Location = new System.Drawing.Point(14, 177);
            this.adressBox.Name = "adressBox";
            this.adressBox.Size = new System.Drawing.Size(205, 29);
            this.adressBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "ФИО:";
            // 
            // fioBox
            // 
            this.fioBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioBox.Location = new System.Drawing.Point(14, 242);
            this.fioBox.Name = "fioBox";
            this.fioBox.Size = new System.Drawing.Size(373, 29);
            this.fioBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Дата отправки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Город:";
            // 
            // buttonDeletePhoto
            // 
            this.buttonDeletePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeletePhoto.Location = new System.Drawing.Point(339, 181);
            this.buttonDeletePhoto.Name = "buttonDeletePhoto";
            this.buttonDeletePhoto.Size = new System.Drawing.Size(48, 32);
            this.buttonDeletePhoto.TabIndex = 2;
            this.buttonDeletePhoto.Text = "-";
            this.buttonDeletePhoto.UseVisualStyleBackColor = true;
            // 
            // buttonAddPhoto
            // 
            this.buttonAddPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPhoto.Location = new System.Drawing.Point(285, 181);
            this.buttonAddPhoto.Name = "buttonAddPhoto";
            this.buttonAddPhoto.Size = new System.Drawing.Size(48, 32);
            this.buttonAddPhoto.TabIndex = 1;
            this.buttonAddPhoto.Text = "+";
            this.buttonAddPhoto.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.ErrorImage = null;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(236, 19);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(151, 156);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // filtersPanel
            // 
            this.filtersPanel.Controls.Add(this.label3);
            this.filtersPanel.Controls.Add(this.filterInputName);
            this.filtersPanel.Controls.Add(this.filterCheck);
            this.filtersPanel.Controls.Add(this.citiesList);
            this.filtersPanel.Controls.Add(this.label1);
            this.filtersPanel.Location = new System.Drawing.Point(12, 12);
            this.filtersPanel.Name = "filtersPanel";
            this.filtersPanel.Size = new System.Drawing.Size(564, 182);
            this.filtersPanel.TabIndex = 6;
            this.filtersPanel.TabStop = false;
            this.filtersPanel.Text = "Фильтр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Поиск по отправителю";
            // 
            // filterInputName
            // 
            this.filterInputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterInputName.Location = new System.Drawing.Point(21, 132);
            this.filterInputName.Name = "filterInputName";
            this.filterInputName.Size = new System.Drawing.Size(528, 29);
            this.filterInputName.TabIndex = 9;
            this.filterInputName.TextChanged += new System.EventHandler(this.filterInputName_TextChanged);
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.FileName = "openFileDialog1";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Ivory;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.Location = new System.Drawing.Point(399, 611);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(187, 30);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Ivory;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editBtn.Location = new System.Drawing.Point(587, 611);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(200, 30);
            this.editBtn.TabIndex = 8;
            this.editBtn.Text = "Редактировать";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.entryBtnChangeMode_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Ivory;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(788, 611);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(200, 30);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.entryBtnChangeMode_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 647);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 109);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(993, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // citiesTableAdapter1
            // 
            this.citiesTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersCityTableAdapter1
            // 
            this.ordersCityTableAdapter1.ClearBeforeFill = true;
            // 
            // type_of_servicesTableAdapter1
            // 
            this.type_of_servicesTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(993, 756);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.filtersPanel);
            this.Controls.Add(this.entryEditPanel);
            this.Controls.Add(this.rowsCountOutput);
            this.Controls.Add(this.ordersDataView);
            this.Name = "Form1";
            this.Text = "Почта России";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataView)).EndInit();
            this.entryEditPanel.ResumeLayout(false);
            this.entryEditPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daysCountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.filtersPanel.ResumeLayout(false);
            this.filtersPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersDataView;
        private System.Windows.Forms.Label rowsCountOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox citiesList;
        private System.Windows.Forms.CheckBox filterCheck;
        private MailDatabaseDataSetTableAdapters.CitiesTableAdapter citiesTableAdapter1;
        private MailDatabaseDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private MailDatabaseDataSetTableAdapters.OrdersCityTableAdapter ordersCityTableAdapter1;
        private System.Windows.Forms.GroupBox entryEditPanel;
        private System.Windows.Forms.GroupBox filtersPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filterInputName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDeletePhoto;
        private System.Windows.Forms.Button buttonAddPhoto;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fioBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox adressBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox typeInputBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox citiesInputBox;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
        private MailDatabaseDataSetTableAdapters.Type_of_servicesTableAdapter type_of_servicesTableAdapter1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimeService;
        private System.Windows.Forms.NumericUpDown daysCountBox;
    }
}

