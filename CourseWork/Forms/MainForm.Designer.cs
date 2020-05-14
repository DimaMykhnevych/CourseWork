using System.Windows.Forms;

namespace CourseWork
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ownership = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellDataGridViewCM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.nameTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.phoneNumberTBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.startDTPicker = new System.Windows.Forms.DateTimePicker();
            this.endDTPicker = new System.Windows.Forms.DateTimePicker();
            this.ownershipCBox = new System.Windows.Forms.ComboBox();
            this.specializationCBox = new System.Windows.Forms.ComboBox();
            this.moncb = new System.Windows.Forms.CheckBox();
            this.tuecb = new System.Windows.Forms.CheckBox();
            this.wedcb = new System.Windows.Forms.CheckBox();
            this.thicb = new System.Windows.Forms.CheckBox();
            this.fricb = new System.Windows.Forms.CheckBox();
            this.satcb = new System.Windows.Forms.CheckBox();
            this.suncb = new System.Windows.Forms.CheckBox();
            this.workdaysGB = new System.Windows.Forms.GroupBox();
            this.servicesChLB = new System.Windows.Forms.CheckedListBox();
            this.kindCBox = new System.Windows.Forms.ComboBox();
            this.findbtn = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.updatepBox = new System.Windows.Forms.PictureBox();
            this.fileTStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.servTStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.citytextBox = new System.Windows.Forms.TextBox();
            this.streettextBox = new System.Windows.Forms.TextBox();
            this.houseNumtextBox = new System.Windows.Forms.TextBox();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.cellDataGridViewCM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.workdaysGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updatepBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGV
            // 
            this.dataGV.AllowUserToAddRows = false;
            this.dataGV.AllowUserToDeleteRows = false;
            this.dataGV.AutoGenerateColumns = false;
            this.dataGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.specializationDataGridViewTextBoxColumn,
            this.Category,
            this.Ownership});
            this.dataGV.ContextMenuStrip = this.cellDataGridViewCM;
            this.dataGV.DataSource = this.companyBindingSource;
            this.dataGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGV.Location = new System.Drawing.Point(0, 359);
            this.dataGV.MaximumSize = new System.Drawing.Size(0, 500);
            this.dataGV.MultiSelect = false;
            this.dataGV.Name = "dataGV";
            this.dataGV.ReadOnly = true;
            this.dataGV.RowHeadersVisible = false;
            this.dataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV.Size = new System.Drawing.Size(666, 218);
            this.dataGV.TabIndex = 50;
            this.dataGV.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dataGridView_CellContextMenuStripNeeded);
            this.dataGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 54.57534F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 105.1363F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specializationDataGridViewTextBoxColumn
            // 
            this.specializationDataGridViewTextBoxColumn.DataPropertyName = "Specialization";
            this.specializationDataGridViewTextBoxColumn.FillWeight = 126.9036F;
            this.specializationDataGridViewTextBoxColumn.HeaderText = "Специализация";
            this.specializationDataGridViewTextBoxColumn.Name = "specializationDataGridViewTextBoxColumn";
            this.specializationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Разряд";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Ownership
            // 
            this.Ownership.DataPropertyName = "Ownership";
            this.Ownership.HeaderText = "Собственность";
            this.Ownership.Name = "Ownership";
            this.Ownership.ReadOnly = true;
            // 
            // cellDataGridViewCM
            // 
            this.cellDataGridViewCM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTSM,
            this.changeTSM,
            this.deleteTSM});
            this.cellDataGridViewCM.Name = "cellDataGridViewCMS";
            this.cellDataGridViewCM.Size = new System.Drawing.Size(149, 70);
            // 
            // showTSM
            // 
            this.showTSM.Name = "showTSM";
            this.showTSM.Size = new System.Drawing.Size(148, 22);
            this.showTSM.Text = "Просмотреть";
            this.showTSM.Click += new System.EventHandler(this.ShowTSM_Click);
            // 
            // changeTSM
            // 
            this.changeTSM.Name = "changeTSM";
            this.changeTSM.Size = new System.Drawing.Size(148, 22);
            this.changeTSM.Text = "Изменить";
            this.changeTSM.Click += new System.EventHandler(this.ChangeTSM_Click);
            // 
            // deleteTSM
            // 
            this.deleteTSM.Name = "deleteTSM";
            this.deleteTSM.Size = new System.Drawing.Size(148, 22);
            this.deleteTSM.Text = "Удалить";
            this.deleteTSM.Click += new System.EventHandler(this.DeleteTSM_Click);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(CourseWork.Company);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(19, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Название";
            // 
            // nameTBox
            // 
            this.nameTBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTBox.Location = new System.Drawing.Point(97, 71);
            this.nameTBox.MaximumSize = new System.Drawing.Size(200, 100);
            this.nameTBox.Name = "nameTBox";
            this.nameTBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameTBox.Size = new System.Drawing.Size(156, 20);
            this.nameTBox.TabIndex = 28;
            this.nameTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(19, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Разряд";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(412, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Услуги";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(357, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Собственность";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(225, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Справочник потребителя";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(357, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Специализация";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(19, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Часы работы";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(19, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Дни работы";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(19, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 42;
            this.label10.Text = "Телефон";
            // 
            // phoneNumberTBox
            // 
            this.phoneNumberTBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumberTBox.Location = new System.Drawing.Point(97, 199);
            this.phoneNumberTBox.MaximumSize = new System.Drawing.Size(200, 100);
            this.phoneNumberTBox.Name = "phoneNumberTBox";
            this.phoneNumberTBox.Size = new System.Drawing.Size(156, 20);
            this.phoneNumberTBox.TabIndex = 44;
            this.phoneNumberTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(136, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 97;
            this.label11.Text = "Начало";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(262, 286);
            this.label12.MaximumSize = new System.Drawing.Size(500, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 98;
            this.label12.Text = "Конец";
            // 
            // startDTPicker
            // 
            this.startDTPicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startDTPicker.CustomFormat = "HH:mm";
            this.startDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDTPicker.Location = new System.Drawing.Point(186, 282);
            this.startDTPicker.MaximumSize = new System.Drawing.Size(500, 100);
            this.startDTPicker.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.startDTPicker.Name = "startDTPicker";
            this.startDTPicker.ShowUpDown = true;
            this.startDTPicker.Size = new System.Drawing.Size(54, 20);
            this.startDTPicker.TabIndex = 101;
            this.startDTPicker.Value = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.startDTPicker.ValueChanged += new System.EventHandler(this.startTimePicker_ValueChanged);
            // 
            // endDTPicker
            // 
            this.endDTPicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endDTPicker.CustomFormat = "HH:mm";
            this.endDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDTPicker.Location = new System.Drawing.Point(306, 282);
            this.endDTPicker.MaximumSize = new System.Drawing.Size(500, 100);
            this.endDTPicker.MinDate = new System.DateTime(1800, 1, 1, 0, 1, 0, 0);
            this.endDTPicker.Name = "endDTPicker";
            this.endDTPicker.ShowUpDown = true;
            this.endDTPicker.Size = new System.Drawing.Size(50, 20);
            this.endDTPicker.TabIndex = 102;
            this.endDTPicker.Value = new System.DateTime(1800, 1, 1, 23, 59, 0, 0);
            this.endDTPicker.ValueChanged += new System.EventHandler(this.endDTPicker_ValueChanged);
            // 
            // ownershipCBox
            // 
            this.ownershipCBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ownershipCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ownershipCBox.Items.AddRange(new object[] {
            "любая",
            "государственная",
            "частная",
            "муниципальная"});
            this.ownershipCBox.Location = new System.Drawing.Point(475, 110);
            this.ownershipCBox.MaximumSize = new System.Drawing.Size(300, 0);
            this.ownershipCBox.Name = "ownershipCBox";
            this.ownershipCBox.Size = new System.Drawing.Size(179, 21);
            this.ownershipCBox.TabIndex = 111;
            // 
            // specializationCBox
            // 
            this.specializationCBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.specializationCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specializationCBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.specializationCBox.FormattingEnabled = true;
            this.specializationCBox.Items.AddRange(new object[] {
            "любая",
            "коммунальное",
            "промышленное",
            "производственное",
            "коммерческое",
            "другое"});
            this.specializationCBox.Location = new System.Drawing.Point(475, 70);
            this.specializationCBox.MaximumSize = new System.Drawing.Size(300, 0);
            this.specializationCBox.Name = "specializationCBox";
            this.specializationCBox.Size = new System.Drawing.Size(179, 21);
            this.specializationCBox.TabIndex = 112;
            // 
            // moncb
            // 
            this.moncb.AutoSize = true;
            this.moncb.Location = new System.Drawing.Point(7, 19);
            this.moncb.Name = "moncb";
            this.moncb.Size = new System.Drawing.Size(40, 17);
            this.moncb.TabIndex = 138;
            this.moncb.Text = "Пн";
            this.moncb.UseVisualStyleBackColor = true;
            // 
            // tuecb
            // 
            this.tuecb.AutoSize = true;
            this.tuecb.Location = new System.Drawing.Point(53, 19);
            this.tuecb.Name = "tuecb";
            this.tuecb.Size = new System.Drawing.Size(38, 17);
            this.tuecb.TabIndex = 139;
            this.tuecb.Text = "Вт";
            this.tuecb.UseVisualStyleBackColor = true;
            // 
            // wedcb
            // 
            this.wedcb.AutoSize = true;
            this.wedcb.Location = new System.Drawing.Point(97, 19);
            this.wedcb.Name = "wedcb";
            this.wedcb.Size = new System.Drawing.Size(39, 17);
            this.wedcb.TabIndex = 140;
            this.wedcb.Text = "Ср";
            this.wedcb.UseVisualStyleBackColor = true;
            // 
            // thicb
            // 
            this.thicb.AutoSize = true;
            this.thicb.Location = new System.Drawing.Point(144, 19);
            this.thicb.Name = "thicb";
            this.thicb.Size = new System.Drawing.Size(39, 17);
            this.thicb.TabIndex = 141;
            this.thicb.Text = "Чт";
            this.thicb.UseVisualStyleBackColor = true;
            // 
            // fricb
            // 
            this.fricb.AutoSize = true;
            this.fricb.Location = new System.Drawing.Point(191, 19);
            this.fricb.Name = "fricb";
            this.fricb.Size = new System.Drawing.Size(39, 17);
            this.fricb.TabIndex = 142;
            this.fricb.Text = "Пт";
            this.fricb.UseVisualStyleBackColor = true;
            // 
            // satcb
            // 
            this.satcb.AutoSize = true;
            this.satcb.Location = new System.Drawing.Point(237, 19);
            this.satcb.Name = "satcb";
            this.satcb.Size = new System.Drawing.Size(39, 17);
            this.satcb.TabIndex = 143;
            this.satcb.Text = "Сб";
            this.satcb.UseVisualStyleBackColor = true;
            // 
            // suncb
            // 
            this.suncb.AutoSize = true;
            this.suncb.Location = new System.Drawing.Point(283, 19);
            this.suncb.Name = "suncb";
            this.suncb.Size = new System.Drawing.Size(39, 17);
            this.suncb.TabIndex = 144;
            this.suncb.Text = "Вс";
            this.suncb.UseVisualStyleBackColor = true;
            // 
            // workdaysGB
            // 
            this.workdaysGB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.workdaysGB.Controls.Add(this.suncb);
            this.workdaysGB.Controls.Add(this.satcb);
            this.workdaysGB.Controls.Add(this.fricb);
            this.workdaysGB.Controls.Add(this.thicb);
            this.workdaysGB.Controls.Add(this.wedcb);
            this.workdaysGB.Controls.Add(this.tuecb);
            this.workdaysGB.Controls.Add(this.moncb);
            this.workdaysGB.Location = new System.Drawing.Point(117, 225);
            this.workdaysGB.MaximumSize = new System.Drawing.Size(500, 100);
            this.workdaysGB.Name = "workdaysGB";
            this.workdaysGB.Size = new System.Drawing.Size(325, 46);
            this.workdaysGB.TabIndex = 141;
            this.workdaysGB.TabStop = false;
            // 
            // servicesChLB
            // 
            this.servicesChLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.servicesChLB.FormattingEnabled = true;
            this.servicesChLB.Items.AddRange(new object[] {
            "водоснабжение",
            "газ",
            "гостиницы",
            "обувь",
            "одежда",
            "отопление",
            "парикмахерские",
            "перевозка",
            "питание",
            "почтовые",
            "прачечные",
            "ремонт",
            "ритуальные",
            "строительство",
            "электроэнергия",
            "другое"});
            this.servicesChLB.Location = new System.Drawing.Point(475, 149);
            this.servicesChLB.MaximumSize = new System.Drawing.Size(300, 500);
            this.servicesChLB.Name = "servicesChLB";
            this.servicesChLB.Size = new System.Drawing.Size(179, 124);
            this.servicesChLB.TabIndex = 144;
            // 
            // kindCBox
            // 
            this.kindCBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kindCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kindCBox.FormattingEnabled = true;
            this.kindCBox.Items.AddRange(new object[] {
            "любой",
            "высший",
            "первый",
            "второй"});
            this.kindCBox.Location = new System.Drawing.Point(97, 163);
            this.kindCBox.MaximumSize = new System.Drawing.Size(200, 0);
            this.kindCBox.Name = "kindCBox";
            this.kindCBox.Size = new System.Drawing.Size(156, 21);
            this.kindCBox.TabIndex = 145;
            // 
            // findbtn
            // 
            this.findbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.findbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findbtn.Location = new System.Drawing.Point(317, 311);
            this.findbtn.Name = "findbtn";
            this.findbtn.Size = new System.Drawing.Size(125, 30);
            this.findbtn.TabIndex = 146;
            this.findbtn.Text = "Найти";
            this.findbtn.UseVisualStyleBackColor = true;
            this.findbtn.Click += new System.EventHandler(this.Findbtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.resetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetbtn.Location = new System.Drawing.Point(214, 311);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(92, 30);
            this.resetbtn.TabIndex = 147;
            this.resetbtn.Text = "Сброс";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // updatepBox
            // 
            this.updatepBox.Location = new System.Drawing.Point(0, 0);
            this.updatepBox.Name = "updatepBox";
            this.updatepBox.Size = new System.Drawing.Size(100, 50);
            this.updatepBox.TabIndex = 0;
            this.updatepBox.TabStop = false;
            // 
            // fileTStrMenu
            // 
            this.fileTStrMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTStrMenu,
            this.exitTStrMenu});
            this.fileTStrMenu.Name = "fileTStrMenu";
            this.fileTStrMenu.Size = new System.Drawing.Size(48, 20);
            this.fileTStrMenu.Text = "Файл";
            // 
            // saveTStrMenu
            // 
            this.saveTStrMenu.Name = "saveTStrMenu";
            this.saveTStrMenu.Size = new System.Drawing.Size(133, 22);
            this.saveTStrMenu.Text = "Сохранить";
            this.saveTStrMenu.Click += new System.EventHandler(this.SaveTStrMenu_Click);
            // 
            // exitTStrMenu
            // 
            this.exitTStrMenu.Name = "exitTStrMenu";
            this.exitTStrMenu.Size = new System.Drawing.Size(133, 22);
            this.exitTStrMenu.Text = "Выход";
            this.exitTStrMenu.Click += new System.EventHandler(this.ExitTStrMenu_Click);
            // 
            // servTStrMenu
            // 
            this.servTStrMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотретьToolStripMenuItem,
            this.addTStrMenu,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.servTStrMenu.Name = "servTStrMenu";
            this.servTStrMenu.Size = new System.Drawing.Size(70, 20);
            this.servTStrMenu.Text = "Действия";
            // 
            // просмотретьToolStripMenuItem
            // 
            this.просмотретьToolStripMenuItem.Name = "просмотретьToolStripMenuItem";
            this.просмотретьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.просмотретьToolStripMenuItem.Text = "Просмотреть";
            this.просмотретьToolStripMenuItem.Click += new System.EventHandler(this.ShowTSM_Click);
            // 
            // addTStrMenu
            // 
            this.addTStrMenu.Name = "addTStrMenu";
            this.addTStrMenu.Size = new System.Drawing.Size(148, 22);
            this.addTStrMenu.Text = "Добавить";
            this.addTStrMenu.Click += new System.EventHandler(this.AddTStrMenu_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.ChangeTSM_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.DeleteTSM_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTStrMenu,
            this.servTStrMenu,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn1.HeaderText = "Разряд";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 312;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ownership";
            this.dataGridViewTextBoxColumn2.HeaderText = "Собственность";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 311;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(19, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 148;
            this.label7.Text = "Город";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(19, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 17);
            this.label13.TabIndex = 149;
            this.label13.Text = "Улица";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(19, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 17);
            this.label14.TabIndex = 150;
            this.label14.Text = "Номер дома";
            // 
            // citytextBox
            // 
            this.citytextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.citytextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.citytextBox.Location = new System.Drawing.Point(97, 97);
            this.citytextBox.MaximumSize = new System.Drawing.Size(200, 100);
            this.citytextBox.Name = "citytextBox";
            this.citytextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.citytextBox.Size = new System.Drawing.Size(156, 20);
            this.citytextBox.TabIndex = 151;
            this.citytextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // streettextBox
            // 
            this.streettextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.streettextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.streettextBox.Location = new System.Drawing.Point(97, 117);
            this.streettextBox.MaximumSize = new System.Drawing.Size(200, 100);
            this.streettextBox.Name = "streettextBox";
            this.streettextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.streettextBox.Size = new System.Drawing.Size(156, 20);
            this.streettextBox.TabIndex = 152;
            this.streettextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // houseNumtextBox
            // 
            this.houseNumtextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.houseNumtextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.houseNumtextBox.Location = new System.Drawing.Point(158, 137);
            this.houseNumtextBox.MaximumSize = new System.Drawing.Size(200, 100);
            this.houseNumtextBox.Name = "houseNumtextBox";
            this.houseNumtextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.houseNumtextBox.Size = new System.Drawing.Size(31, 20);
            this.houseNumtextBox.TabIndex = 153;
            this.houseNumtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.companyBindingSource;
            // 
            // companyBindingSource1
            // 
            this.companyBindingSource1.DataSource = typeof(CourseWork.Company);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 577);
            this.Controls.Add(this.houseNumtextBox);
            this.Controls.Add(this.streettextBox);
            this.Controls.Add(this.citytextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.findbtn);
            this.Controls.Add(this.kindCBox);
            this.Controls.Add(this.servicesChLB);
            this.Controls.Add(this.workdaysGB);
            this.Controls.Add(this.specializationCBox);
            this.Controls.Add(this.ownershipCBox);
            this.Controls.Add(this.endDTPicker);
            this.Controls.Add(this.startDTPicker);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.phoneNumberTBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Предприятия";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.cellDataGridViewCM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.workdaysGB.ResumeLayout(false);
            this.workdaysGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updatepBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private TextBox nameTBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox phoneNumberTBox;
        private Label label11;
        private Label label12;
        private DateTimePicker startDTPicker;
        private DateTimePicker endDTPicker;
        private ComboBox ownershipCBox;
        private ComboBox specializationCBox;
        private CheckBox moncb;
        private CheckBox tuecb;
        private CheckBox wedcb;
        private CheckBox thicb;
        private CheckBox fricb;
        private CheckBox satcb;
        private CheckBox suncb;
        private GroupBox workdaysGB;
        private CheckedListBox servicesChLB;
        private ComboBox kindCBox;
        private Button findbtn;
        private BindingSource companyBindingSource;
        public DataGridView dataGV;
        private ContextMenuStrip cellDataGridViewCM;
        private ToolStripMenuItem showTSM;
        private ToolStripMenuItem changeTSM;
        private ToolStripMenuItem deleteTSM;
        private Button resetbtn;
        private ImageList imageList1;
        private PictureBox updatepBox;
        private BindingSource companyBindingSource1;
        private ToolStripMenuItem fileTStrMenu;
        private ToolStripMenuItem saveTStrMenu;
        private ToolStripMenuItem exitTStrMenu;
        private ToolStripMenuItem servTStrMenu;
        private ToolStripMenuItem просмотретьToolStripMenuItem;
        private ToolStripMenuItem addTStrMenu;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private MenuStrip menuStrip1;
        //private DataGridViewTextBoxColumn kindDataGridViewTextBoxColumn;
        //private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private BindingSource servicesBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn specializationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Ownership;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label label7;
        private Label label13;
        private Label label14;
        private TextBox citytextBox;
        private TextBox streettextBox;
        private TextBox houseNumtextBox;
    }
}