
namespace RGR
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.writersDataGridView = new System.Windows.Forms.DataGridView();
            this.writersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.writersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLoadInternet = new System.Windows.Forms.ToolStripButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.checkBoxIsDead = new System.Windows.Forms.CheckBox();
            this.labelPicture = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelJobTitle = new System.Windows.Forms.Label();
            this.labelBirthPlace = new System.Windows.Forms.Label();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDeathDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxBirthPlace = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxJobTitle = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.загрузитьКартинкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьКартинкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnDeathDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnBirthPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnJobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.writersDBDataSet = new RGR.writersDBDataSet();
            this.writersTableAdapter = new RGR.writersDBDataSetTableAdapters.writersTableAdapter();
            this.tableAdapterManager = new RGR.writersDBDataSetTableAdapters.TableAdapterManager();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.writersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.writersBindingNavigator)).BeginInit();
            this.writersBindingNavigator.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.writersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.writersDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.writersDataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.writersBindingNavigator);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Size = new System.Drawing.Size(1280, 659);
            this.splitContainer1.SplitterDistance = 877;
            this.splitContainer1.TabIndex = 2;
            // 
            // writersDataGridView
            // 
            this.writersDataGridView.AllowUserToAddRows = false;
            this.writersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.writersDataGridView.AutoGenerateColumns = false;
            this.writersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.writersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnName,
            this.dataGridViewTextBoxColumnSurname,
            this.dataGridViewTextBoxColumnBirthDate,
            this.dataGridViewTextBoxColumnDeathDate,
            this.dataGridViewTextBoxColumnGender,
            this.dataGridViewTextBoxColumnBirthPlace,
            this.dataGridViewTextBoxColumnJobTitle});
            this.writersDataGridView.DataSource = this.writersBindingSource;
            this.writersDataGridView.Location = new System.Drawing.Point(0, 25);
            this.writersDataGridView.MultiSelect = false;
            this.writersDataGridView.Name = "writersDataGridView";
            this.writersDataGridView.ReadOnly = true;
            this.writersDataGridView.Size = new System.Drawing.Size(877, 609);
            this.writersDataGridView.TabIndex = 0;
            this.writersDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.writersDataGridView_DataError);
            this.writersDataGridView.SelectionChanged += new System.EventHandler(this.writersDataGridView_SelectionChanged);
            // 
            // writersBindingNavigator
            // 
            this.writersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.writersBindingNavigator.BindingSource = this.writersBindingSource;
            this.writersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.writersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.writersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.writersBindingNavigatorSaveItem,
            this.toolStripButtonUpdate,
            this.toolStripButtonEdit,
            this.toolStripButtonLoadInternet});
            this.writersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.writersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.writersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.writersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.writersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.writersBindingNavigator.Name = "writersBindingNavigator";
            this.writersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.writersBindingNavigator.Size = new System.Drawing.Size(877, 25);
            this.writersBindingNavigator.TabIndex = 3;
            this.writersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // writersBindingNavigatorSaveItem
            // 
            this.writersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.writersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("writersBindingNavigatorSaveItem.Image")));
            this.writersBindingNavigatorSaveItem.Name = "writersBindingNavigatorSaveItem";
            this.writersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.writersBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.writersBindingNavigatorSaveItem.Click += new System.EventHandler(this.writersBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonUpdate
            // 
            this.toolStripButtonUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdate.Image")));
            this.toolStripButtonUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdate.Name = "toolStripButtonUpdate";
            this.toolStripButtonUpdate.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUpdate.Text = "Сохранить изменения";
            this.toolStripButtonUpdate.Click += new System.EventHandler(this.toolStripButtonUpdate_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdit.Image")));
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEdit.Text = "Изменить текущий элемент";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripButtonLoadInternet
            // 
            this.toolStripButtonLoadInternet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLoadInternet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoadInternet.Image")));
            this.toolStripButtonLoadInternet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoadInternet.Name = "toolStripButtonLoadInternet";
            this.toolStripButtonLoadInternet.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLoadInternet.Text = "Выгрузить данные";
            this.toolStripButtonLoadInternet.Click += new System.EventHandler(this.toolStripButtonLoadInternet_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.comboBoxGender);
            this.groupBox.Controls.Add(this.checkBoxIsDead);
            this.groupBox.Controls.Add(this.labelPicture);
            this.groupBox.Controls.Add(this.labelName);
            this.groupBox.Controls.Add(this.labelBirthDate);
            this.groupBox.Controls.Add(this.labelSurname);
            this.groupBox.Controls.Add(this.labelGender);
            this.groupBox.Controls.Add(this.pictureBox);
            this.groupBox.Controls.Add(this.labelJobTitle);
            this.groupBox.Controls.Add(this.labelBirthPlace);
            this.groupBox.Controls.Add(this.dateTimePickerBirthDate);
            this.groupBox.Controls.Add(this.dateTimePickerDeathDate);
            this.groupBox.Controls.Add(this.textBoxBirthPlace);
            this.groupBox.Controls.Add(this.textBoxName);
            this.groupBox.Controls.Add(this.textBoxJobTitle);
            this.groupBox.Controls.Add(this.textBoxSurname);
            this.groupBox.Controls.Add(this.buttonSave);
            this.groupBox.Controls.Add(this.buttonCancel);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(399, 659);
            this.groupBox.TabIndex = 18;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Редактирование";
            // 
            // checkBoxIsDead
            // 
            this.checkBoxIsDead.AutoSize = true;
            this.checkBoxIsDead.Location = new System.Drawing.Point(9, 474);
            this.checkBoxIsDead.Name = "checkBoxIsDead";
            this.checkBoxIsDead.Size = new System.Drawing.Size(109, 20);
            this.checkBoxIsDead.TabIndex = 18;
            this.checkBoxIsDead.Text = "Дата смерти";
            this.checkBoxIsDead.UseVisualStyleBackColor = true;
            this.checkBoxIsDead.CheckedChanged += new System.EventHandler(this.checkBoxIsDead_CheckedChanged);
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.ContextMenuStrip = this.contextMenuStrip1;
            this.labelPicture.Location = new System.Drawing.Point(165, 348);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(64, 16);
            this.labelPicture.TabIndex = 0;
            this.labelPicture.Text = "Портрет";
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 388);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(34, 16);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(6, 445);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(107, 16);
            this.labelBirthDate.TabIndex = 4;
            this.labelBirthDate.Text = "Дата рождения";
            // 
            // labelSurname
            // 
            this.labelSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(6, 415);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(67, 16);
            this.labelSurname.TabIndex = 3;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelGender
            // 
            this.labelGender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(6, 505);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(34, 16);
            this.labelGender.TabIndex = 6;
            this.labelGender.Text = "Пол";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox.Location = new System.Drawing.Point(3, 18);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(393, 327);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // labelJobTitle
            // 
            this.labelJobTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelJobTitle.AutoSize = true;
            this.labelJobTitle.Location = new System.Drawing.Point(6, 565);
            this.labelJobTitle.Name = "labelJobTitle";
            this.labelJobTitle.Size = new System.Drawing.Size(56, 16);
            this.labelJobTitle.TabIndex = 8;
            this.labelJobTitle.Text = "Работа";
            // 
            // labelBirthPlace
            // 
            this.labelBirthPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBirthPlace.AutoSize = true;
            this.labelBirthPlace.Location = new System.Drawing.Point(6, 535);
            this.labelBirthPlace.Name = "labelBirthPlace";
            this.labelBirthPlace.Size = new System.Drawing.Size(116, 16);
            this.labelBirthPlace.TabIndex = 7;
            this.labelBirthPlace.Text = "Место рождения";
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(168, 439);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(228, 22);
            this.dateTimePickerBirthDate.TabIndex = 9;
            // 
            // dateTimePickerDeathDate
            // 
            this.dateTimePickerDeathDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDeathDate.Location = new System.Drawing.Point(168, 470);
            this.dateTimePickerDeathDate.Name = "dateTimePickerDeathDate";
            this.dateTimePickerDeathDate.Size = new System.Drawing.Size(228, 22);
            this.dateTimePickerDeathDate.TabIndex = 10;
            // 
            // textBoxBirthPlace
            // 
            this.textBoxBirthPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBirthPlace.Location = new System.Drawing.Point(168, 532);
            this.textBoxBirthPlace.Name = "textBoxBirthPlace";
            this.textBoxBirthPlace.Size = new System.Drawing.Size(228, 22);
            this.textBoxBirthPlace.TabIndex = 12;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(168, 385);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(228, 22);
            this.textBoxName.TabIndex = 14;
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // textBoxJobTitle
            // 
            this.textBoxJobTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxJobTitle.Location = new System.Drawing.Point(168, 562);
            this.textBoxJobTitle.Name = "textBoxJobTitle";
            this.textBoxJobTitle.Size = new System.Drawing.Size(228, 22);
            this.textBoxJobTitle.TabIndex = 13;
            this.textBoxJobTitle.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSurname.Location = new System.Drawing.Point(168, 412);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(228, 22);
            this.textBoxSurname.TabIndex = 15;
            this.textBoxSurname.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(3, 616);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(104, 31);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(292, 616);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(104, 31);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 637);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(877, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(108, 17);
            this.toolStripStatusLabel.Text = "Просмотр данных";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьКартинкуToolStripMenuItem,
            this.удалитьКартинкуToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 48);
            // 
            // загрузитьКартинкуToolStripMenuItem
            // 
            this.загрузитьКартинкуToolStripMenuItem.Name = "загрузитьКартинкуToolStripMenuItem";
            this.загрузитьКартинкуToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.загрузитьКартинкуToolStripMenuItem.Text = "Загрузить картинку";
            this.загрузитьКартинкуToolStripMenuItem.Click += new System.EventHandler(this.загрузитьКартинкуToolStripMenuItem_Click);
            // 
            // удалитьКартинкуToolStripMenuItem
            // 
            this.удалитьКартинкуToolStripMenuItem.Name = "удалитьКартинкуToolStripMenuItem";
            this.удалитьКартинкуToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.удалитьКартинкуToolStripMenuItem.Text = "Удалить картинку";
            this.удалитьКартинкуToolStripMenuItem.Click += new System.EventHandler(this.удалитьКартинкуToolStripMenuItem_Click);
            // 
            // dataGridViewTextBoxColumnName
            // 
            this.dataGridViewTextBoxColumnName.DataPropertyName = "writer_first_name";
            this.dataGridViewTextBoxColumnName.HeaderText = "Имя";
            this.dataGridViewTextBoxColumnName.Name = "dataGridViewTextBoxColumnName";
            this.dataGridViewTextBoxColumnName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnSurname
            // 
            this.dataGridViewTextBoxColumnSurname.DataPropertyName = "writer_last_name";
            this.dataGridViewTextBoxColumnSurname.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumnSurname.Name = "dataGridViewTextBoxColumnSurname";
            this.dataGridViewTextBoxColumnSurname.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnBirthDate
            // 
            this.dataGridViewTextBoxColumnBirthDate.DataPropertyName = "writer_birthDate";
            this.dataGridViewTextBoxColumnBirthDate.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumnBirthDate.Name = "dataGridViewTextBoxColumnBirthDate";
            this.dataGridViewTextBoxColumnBirthDate.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnDeathDate
            // 
            this.dataGridViewTextBoxColumnDeathDate.DataPropertyName = "writer_deathDate";
            this.dataGridViewTextBoxColumnDeathDate.HeaderText = "Дата смерти";
            this.dataGridViewTextBoxColumnDeathDate.Name = "dataGridViewTextBoxColumnDeathDate";
            this.dataGridViewTextBoxColumnDeathDate.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnGender
            // 
            this.dataGridViewTextBoxColumnGender.DataPropertyName = "writer_gender";
            this.dataGridViewTextBoxColumnGender.HeaderText = "Пол";
            this.dataGridViewTextBoxColumnGender.Name = "dataGridViewTextBoxColumnGender";
            this.dataGridViewTextBoxColumnGender.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnBirthPlace
            // 
            this.dataGridViewTextBoxColumnBirthPlace.DataPropertyName = "writer_birthPlace";
            this.dataGridViewTextBoxColumnBirthPlace.HeaderText = "Место рождения";
            this.dataGridViewTextBoxColumnBirthPlace.Name = "dataGridViewTextBoxColumnBirthPlace";
            this.dataGridViewTextBoxColumnBirthPlace.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnJobTitle
            // 
            this.dataGridViewTextBoxColumnJobTitle.DataPropertyName = "writer_jobTitle";
            this.dataGridViewTextBoxColumnJobTitle.HeaderText = "Работа";
            this.dataGridViewTextBoxColumnJobTitle.Name = "dataGridViewTextBoxColumnJobTitle";
            this.dataGridViewTextBoxColumnJobTitle.ReadOnly = true;
            // 
            // writersBindingSource
            // 
            this.writersBindingSource.DataMember = "writers";
            this.writersBindingSource.DataSource = this.writersDBDataSet;
            // 
            // writersDBDataSet
            // 
            this.writersDBDataSet.DataSetName = "writersDBDataSet";
            this.writersDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // writersTableAdapter
            // 
            this.writersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = RGR.writersDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.writersTableAdapter = this.writersTableAdapter;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.comboBoxGender.Location = new System.Drawing.Point(168, 499);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(228, 24);
            this.comboBoxGender.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 659);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(1200, 684);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.writersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.writersBindingNavigator)).EndInit();
            this.writersBindingNavigator.ResumeLayout(false);
            this.writersBindingNavigator.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.writersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.writersDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private writersDBDataSet writersDBDataSet;
        private System.Windows.Forms.BindingSource writersBindingSource;
        private writersDBDataSetTableAdapters.writersTableAdapter writersTableAdapter;
        private writersDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator writersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton writersBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView writersDataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdate;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoadInternet;
        private System.Windows.Forms.Label labelJobTitle;
        private System.Windows.Forms.Label labelBirthPlace;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelPicture;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxJobTitle;
        private System.Windows.Forms.TextBox textBoxBirthPlace;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeathDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox checkBoxIsDead;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnDeathDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnBirthPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnJobTitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьКартинкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьКартинкуToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxGender;
    }
}

