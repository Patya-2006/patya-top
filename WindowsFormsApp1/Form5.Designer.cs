namespace WindowsFormsApp1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label родителиLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label паспортные_данныхLabel;
            System.Windows.Forms.Label номер_зачеткиLabel;
            System.Windows.Forms.Label дата_поступленияLabel;
            System.Windows.Forms.Label группаLabel;
            System.Windows.Forms.Label курсLabel;
            System.Windows.Forms.Label код_специальностиLabel;
            System.Windows.Forms.Label очная_форма_обучениеLabel;
            this.topaDataSet = new WindowsFormsApp1.topaDataSet();
            this.студентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.студентыTableAdapter = new WindowsFormsApp1.topaDataSetTableAdapters.СтудентыTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.topaDataSetTableAdapters.TableAdapterManager();
            this.студентыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.студентыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.полTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.родителиTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.паспортные_данныхTextBox = new System.Windows.Forms.TextBox();
            this.номер_зачеткиTextBox = new System.Windows.Forms.TextBox();
            this.дата_поступленияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.группаTextBox = new System.Windows.Forms.TextBox();
            this.курсTextBox = new System.Windows.Forms.TextBox();
            this.код_специальностиTextBox = new System.Windows.Forms.TextBox();
            this.очная_форма_обучениеCheckBox = new System.Windows.Forms.CheckBox();
            фИОLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            родителиLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            паспортные_данныхLabel = new System.Windows.Forms.Label();
            номер_зачеткиLabel = new System.Windows.Forms.Label();
            дата_поступленияLabel = new System.Windows.Forms.Label();
            группаLabel = new System.Windows.Forms.Label();
            курсLabel = new System.Windows.Forms.Label();
            код_специальностиLabel = new System.Windows.Forms.Label();
            очная_форма_обучениеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.topaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingNavigator)).BeginInit();
            this.студентыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // topaDataSet
            // 
            this.topaDataSet.DataSetName = "topaDataSet";
            this.topaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // студентыBindingSource
            // 
            this.студентыBindingSource.DataMember = "Студенты";
            this.студентыBindingSource.DataSource = this.topaDataSet;
            // 
            // студентыTableAdapter
            // 
            this.студентыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.topaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ОценкиTableAdapter = null;
            this.tableAdapterManager.ПредметыTableAdapter = null;
            this.tableAdapterManager.СпециальностиTableAdapter = null;
            this.tableAdapterManager.СтудентыTableAdapter = this.студентыTableAdapter;
            // 
            // студентыBindingNavigator
            // 
            this.студентыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.студентыBindingNavigator.BindingSource = this.студентыBindingSource;
            this.студентыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.студентыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.студентыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.студентыBindingNavigatorSaveItem});
            this.студентыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.студентыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.студентыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.студентыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.студентыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.студентыBindingNavigator.Name = "студентыBindingNavigator";
            this.студентыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.студентыBindingNavigator.Size = new System.Drawing.Size(481, 25);
            this.студентыBindingNavigator.TabIndex = 0;
            this.студентыBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // студентыBindingNavigatorSaveItem
            // 
            this.студентыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.студентыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("студентыBindingNavigatorSaveItem.Image")));
            this.студентыBindingNavigatorSaveItem.Name = "студентыBindingNavigatorSaveItem";
            this.студентыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.студентыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.студентыBindingNavigatorSaveItem.Click += new System.EventHandler(this.студентыBindingNavigatorSaveItem_Click);
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(71, 100);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 1;
            фИОLabel.Text = "ФИО:";
            фИОLabel.Click += new System.EventHandler(this.фИОLabel_Click);
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(114, 93);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(100, 20);
            this.фИОTextBox.TabIndex = 2;
            this.фИОTextBox.Text = "Иванов А.И.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(125, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Таблица\"Студенты\"";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(71, 122);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(30, 13);
            полLabel.TabIndex = 4;
            полLabel.Text = "Пол:";
            // 
            // полTextBox
            // 
            this.полTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Пол", true));
            this.полTextBox.Location = new System.Drawing.Point(114, 119);
            this.полTextBox.Name = "полTextBox";
            this.полTextBox.Size = new System.Drawing.Size(100, 20);
            this.полTextBox.TabIndex = 5;
            this.полTextBox.Text = "Мужской";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Location = new System.Drawing.Point(21, 145);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(89, 13);
            дата_рожденияLabel.TabIndex = 6;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.студентыBindingSource, "Дата рождения", true));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(114, 145);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_рожденияDateTimePicker.TabIndex = 7;
            this.дата_рожденияDateTimePicker.Value = new System.DateTime(1983, 12, 12, 16, 14, 0, 0);
            // 
            // родителиLabel
            // 
            родителиLabel.AutoSize = true;
            родителиLabel.Location = new System.Drawing.Point(43, 171);
            родителиLabel.Name = "родителиLabel";
            родителиLabel.Size = new System.Drawing.Size(58, 13);
            родителиLabel.TabIndex = 8;
            родителиLabel.Text = "Родители:";
            // 
            // родителиTextBox
            // 
            this.родителиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Родители", true));
            this.родителиTextBox.Location = new System.Drawing.Point(114, 171);
            this.родителиTextBox.Name = "родителиTextBox";
            this.родителиTextBox.Size = new System.Drawing.Size(100, 20);
            this.родителиTextBox.TabIndex = 9;
            this.родителиTextBox.Text = "Отец и Мать";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(60, 197);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 10;
            адресLabel.Text = "Адрес:";
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(114, 197);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(100, 20);
            this.адресTextBox.TabIndex = 11;
            this.адресTextBox.Text = "Москва";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(53, 224);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(55, 13);
            телефонLabel.TabIndex = 12;
            телефонLabel.Text = "Телефон:";
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(114, 224);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(100, 20);
            this.телефонTextBox.TabIndex = 13;
            this.телефонTextBox.Text = "+74957895674";
            // 
            // паспортные_данныхLabel
            // 
            паспортные_данныхLabel.AutoSize = true;
            паспортные_данныхLabel.Location = new System.Drawing.Point(-2, 250);
            паспортные_данныхLabel.Name = "паспортные_данныхLabel";
            паспортные_данныхLabel.Size = new System.Drawing.Size(113, 13);
            паспортные_данныхLabel.TabIndex = 14;
            паспортные_данныхLabel.Text = "Паспортные данных:";
            // 
            // паспортные_данныхTextBox
            // 
            this.паспортные_данныхTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Паспортные данных", true));
            this.паспортные_данныхTextBox.Location = new System.Drawing.Point(114, 250);
            this.паспортные_данныхTextBox.Name = "паспортные_данныхTextBox";
            this.паспортные_данныхTextBox.Size = new System.Drawing.Size(100, 20);
            this.паспортные_данныхTextBox.TabIndex = 15;
            this.паспортные_данныхTextBox.Text = "8567-567543";
            // 
            // номер_зачеткиLabel
            // 
            номер_зачеткиLabel.AutoSize = true;
            номер_зачеткиLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Дата поступления", true));
            номер_зачеткиLabel.Location = new System.Drawing.Point(14, 280);
            номер_зачеткиLabel.Name = "номер_зачеткиLabel";
            номер_зачеткиLabel.Size = new System.Drawing.Size(87, 13);
            номер_зачеткиLabel.TabIndex = 16;
            номер_зачеткиLabel.Text = "Номер зачетки:";
            // 
            // номер_зачеткиTextBox
            // 
            this.номер_зачеткиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Номер зачетки", true));
            this.номер_зачеткиTextBox.Location = new System.Drawing.Point(114, 280);
            this.номер_зачеткиTextBox.Name = "номер_зачеткиTextBox";
            this.номер_зачеткиTextBox.Size = new System.Drawing.Size(100, 20);
            this.номер_зачеткиTextBox.TabIndex = 17;
            this.номер_зачеткиTextBox.Text = "13245";
            // 
            // дата_поступленияLabel
            // 
            дата_поступленияLabel.AutoSize = true;
            дата_поступленияLabel.Location = new System.Drawing.Point(5, 306);
            дата_поступленияLabel.Name = "дата_поступленияLabel";
            дата_поступленияLabel.Size = new System.Drawing.Size(103, 13);
            дата_поступленияLabel.TabIndex = 18;
            дата_поступленияLabel.Text = "Дата поступления:";
            // 
            // дата_поступленияDateTimePicker
            // 
            this.дата_поступленияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.студентыBindingSource, "Дата поступления", true));
            this.дата_поступленияDateTimePicker.Location = new System.Drawing.Point(114, 306);
            this.дата_поступленияDateTimePicker.Name = "дата_поступленияDateTimePicker";
            this.дата_поступленияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_поступленияDateTimePicker.TabIndex = 19;
            this.дата_поступленияDateTimePicker.Value = new System.DateTime(2007, 9, 1, 16, 17, 0, 0);
            // 
            // группаLabel
            // 
            группаLabel.AutoSize = true;
            группаLabel.Location = new System.Drawing.Point(56, 332);
            группаLabel.Name = "группаLabel";
            группаLabel.Size = new System.Drawing.Size(45, 13);
            группаLabel.TabIndex = 20;
            группаLabel.Text = "Группа:";
            // 
            // группаTextBox
            // 
            this.группаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Группа", true));
            this.группаTextBox.Location = new System.Drawing.Point(114, 332);
            this.группаTextBox.Name = "группаTextBox";
            this.группаTextBox.Size = new System.Drawing.Size(100, 20);
            this.группаTextBox.TabIndex = 21;
            this.группаTextBox.Text = "ММ11";
            // 
            // курсLabel
            // 
            курсLabel.AutoSize = true;
            курсLabel.Location = new System.Drawing.Point(67, 358);
            курсLabel.Name = "курсLabel";
            курсLabel.Size = new System.Drawing.Size(34, 13);
            курсLabel.TabIndex = 22;
            курсLabel.Text = "Курс:";
            // 
            // курсTextBox
            // 
            this.курсTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Курс", true));
            this.курсTextBox.Location = new System.Drawing.Point(114, 358);
            this.курсTextBox.Name = "курсTextBox";
            this.курсTextBox.Size = new System.Drawing.Size(100, 20);
            this.курсTextBox.TabIndex = 23;
            this.курсTextBox.Text = "1";
            // 
            // код_специальностиLabel
            // 
            код_специальностиLabel.AutoSize = true;
            код_специальностиLabel.Location = new System.Drawing.Point(2, 384);
            код_специальностиLabel.Name = "код_специальностиLabel";
            код_специальностиLabel.Size = new System.Drawing.Size(109, 13);
            код_специальностиLabel.TabIndex = 24;
            код_специальностиLabel.Text = "Код специальности:";
            // 
            // код_специальностиTextBox
            // 
            this.код_специальностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.студентыBindingSource, "Код специальности", true));
            this.код_специальностиTextBox.Location = new System.Drawing.Point(114, 384);
            this.код_специальностиTextBox.Name = "код_специальностиTextBox";
            this.код_специальностиTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_специальностиTextBox.TabIndex = 25;
            this.код_специальностиTextBox.Text = "1";
            // 
            // очная_форма_обучениеLabel
            // 
            очная_форма_обучениеLabel.AutoSize = true;
            очная_форма_обучениеLabel.Location = new System.Drawing.Point(-5, 421);
            очная_форма_обучениеLabel.Name = "очная_форма_обучениеLabel";
            очная_форма_обучениеLabel.Size = new System.Drawing.Size(127, 13);
            очная_форма_обучениеLabel.TabIndex = 26;
            очная_форма_обучениеLabel.Text = "Очная форма обучение:";
            // 
            // очная_форма_обучениеCheckBox
            // 
            this.очная_форма_обучениеCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.студентыBindingSource, "Очная форма обучение", true));
            this.очная_форма_обучениеCheckBox.Location = new System.Drawing.Point(128, 416);
            this.очная_форма_обучениеCheckBox.Name = "очная_форма_обучениеCheckBox";
            this.очная_форма_обучениеCheckBox.Size = new System.Drawing.Size(104, 24);
            this.очная_форма_обучениеCheckBox.TabIndex = 27;
            this.очная_форма_обучениеCheckBox.Text = "checkBox1";
            this.очная_форма_обучениеCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 526);
            this.Controls.Add(очная_форма_обучениеLabel);
            this.Controls.Add(this.очная_форма_обучениеCheckBox);
            this.Controls.Add(код_специальностиLabel);
            this.Controls.Add(this.код_специальностиTextBox);
            this.Controls.Add(курсLabel);
            this.Controls.Add(this.курсTextBox);
            this.Controls.Add(группаLabel);
            this.Controls.Add(this.группаTextBox);
            this.Controls.Add(дата_поступленияLabel);
            this.Controls.Add(this.дата_поступленияDateTimePicker);
            this.Controls.Add(номер_зачеткиLabel);
            this.Controls.Add(this.номер_зачеткиTextBox);
            this.Controls.Add(паспортные_данныхLabel);
            this.Controls.Add(this.паспортные_данныхTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(родителиLabel);
            this.Controls.Add(this.родителиTextBox);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker);
            this.Controls.Add(полLabel);
            this.Controls.Add(this.полTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(this.студентыBindingNavigator);
            this.Name = "Form5";
            this.Text = "Таблица\"Студенты\"";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.topaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingNavigator)).EndInit();
            this.студентыBindingNavigator.ResumeLayout(false);
            this.студентыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private topaDataSet topaDataSet;
        private System.Windows.Forms.BindingSource студентыBindingSource;
        private topaDataSetTableAdapters.СтудентыTableAdapter студентыTableAdapter;
        private topaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator студентыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton студентыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox полTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox родителиTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox паспортные_данныхTextBox;
        private System.Windows.Forms.TextBox номер_зачеткиTextBox;
        private System.Windows.Forms.DateTimePicker дата_поступленияDateTimePicker;
        private System.Windows.Forms.TextBox группаTextBox;
        private System.Windows.Forms.TextBox курсTextBox;
        private System.Windows.Forms.TextBox код_специальностиTextBox;
        private System.Windows.Forms.CheckBox очная_форма_обучениеCheckBox;
    }
}