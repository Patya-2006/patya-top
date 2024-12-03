namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группыТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.счетфакиурыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоДатамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоТипамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоКлиентамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контрагентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокИКонтактыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеПерсонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПерсонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(100, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(100, 10, 100, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.label1.Size = new System.Drawing.Size(444, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "ИС учета реализации медикаментов";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(845, 112);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MintCream;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.продажиToolStripMenuItem,
            this.контрагентыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.производителиToolStripMenuItem,
            this.группыТоваровToolStripMenuItem,
            this.добавлениеТоваровToolStripMenuItem,
            this.списокТоваровToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            this.справочникиToolStripMenuItem.Click += new System.EventHandler(this.справочникиToolStripMenuItem_Click);
            // 
            // производителиToolStripMenuItem
            // 
            this.производителиToolStripMenuItem.Name = "производителиToolStripMenuItem";
            this.производителиToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.производителиToolStripMenuItem.Text = "Производители";
            this.производителиToolStripMenuItem.Click += new System.EventHandler(this.производителиToolStripMenuItem_Click);
            // 
            // группыТоваровToolStripMenuItem
            // 
            this.группыТоваровToolStripMenuItem.Name = "группыТоваровToolStripMenuItem";
            this.группыТоваровToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.группыТоваровToolStripMenuItem.Text = "Группы товаров";
            this.группыТоваровToolStripMenuItem.Click += new System.EventHandler(this.группыТоваровToolStripMenuItem_Click);
            // 
            // добавлениеТоваровToolStripMenuItem
            // 
            this.добавлениеТоваровToolStripMenuItem.Name = "добавлениеТоваровToolStripMenuItem";
            this.добавлениеТоваровToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.добавлениеТоваровToolStripMenuItem.Text = "Добавление товаров";
            this.добавлениеТоваровToolStripMenuItem.Click += new System.EventHandler(this.добавлениеТоваровToolStripMenuItem_Click);
            // 
            // списокТоваровToolStripMenuItem
            // 
            this.списокТоваровToolStripMenuItem.Name = "списокТоваровToolStripMenuItem";
            this.списокТоваровToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.списокТоваровToolStripMenuItem.Text = "Список товаров";
            this.списокТоваровToolStripMenuItem.Click += new System.EventHandler(this.списокТоваровToolStripMenuItem_Click);
            // 
            // продажиToolStripMenuItem
            // 
            this.продажиToolStripMenuItem.Checked = true;
            this.продажиToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.продажиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.учетToolStripMenuItem,
            this.счетфакиурыToolStripMenuItem,
            this.отчетПоДатамToolStripMenuItem,
            this.отчетПоТипамToolStripMenuItem,
            this.отчетПоКлиентамToolStripMenuItem});
            this.продажиToolStripMenuItem.Name = "продажиToolStripMenuItem";
            this.продажиToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.продажиToolStripMenuItem.Text = "Продажи";
            this.продажиToolStripMenuItem.Click += new System.EventHandler(this.продажиToolStripMenuItem_Click);
            // 
            // учетToolStripMenuItem
            // 
            this.учетToolStripMenuItem.Name = "учетToolStripMenuItem";
            this.учетToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.учетToolStripMenuItem.Text = "Учет";
            // 
            // счетфакиурыToolStripMenuItem
            // 
            this.счетфакиурыToolStripMenuItem.Name = "счетфакиурыToolStripMenuItem";
            this.счетфакиурыToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.счетфакиурыToolStripMenuItem.Text = "Счет-фактуры";
            // 
            // отчетПоДатамToolStripMenuItem
            // 
            this.отчетПоДатамToolStripMenuItem.Name = "отчетПоДатамToolStripMenuItem";
            this.отчетПоДатамToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.отчетПоДатамToolStripMenuItem.Text = "Отчет по датам";
            // 
            // отчетПоТипамToolStripMenuItem
            // 
            this.отчетПоТипамToolStripMenuItem.Name = "отчетПоТипамToolStripMenuItem";
            this.отчетПоТипамToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.отчетПоТипамToolStripMenuItem.Text = "Отчет по типам";
            // 
            // отчетПоКлиентамToolStripMenuItem
            // 
            this.отчетПоКлиентамToolStripMenuItem.Name = "отчетПоКлиентамToolStripMenuItem";
            this.отчетПоКлиентамToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.отчетПоКлиентамToolStripMenuItem.Text = "Отчет по клиентам";
            // 
            // контрагентыToolStripMenuItem
            // 
            this.контрагентыToolStripMenuItem.Checked = true;
            this.контрагентыToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.контрагентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавлениеToolStripMenuItem,
            this.списокИКонтактыToolStripMenuItem,
            this.добавлениеПерсонToolStripMenuItem,
            this.списокПерсонToolStripMenuItem});
            this.контрагентыToolStripMenuItem.Name = "контрагентыToolStripMenuItem";
            this.контрагентыToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.контрагентыToolStripMenuItem.Text = "Контрагенты";
            // 
            // добавлениеToolStripMenuItem
            // 
            this.добавлениеToolStripMenuItem.Name = "добавлениеToolStripMenuItem";
            this.добавлениеToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.добавлениеToolStripMenuItem.Text = "Добавление";
            this.добавлениеToolStripMenuItem.Click += new System.EventHandler(this.добавлениеToolStripMenuItem_Click);
            // 
            // списокИКонтактыToolStripMenuItem
            // 
            this.списокИКонтактыToolStripMenuItem.Name = "списокИКонтактыToolStripMenuItem";
            this.списокИКонтактыToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.списокИКонтактыToolStripMenuItem.Text = "Список и контакты";
            this.списокИКонтактыToolStripMenuItem.Click += new System.EventHandler(this.списокИКонтактыToolStripMenuItem_Click);
            // 
            // добавлениеПерсонToolStripMenuItem
            // 
            this.добавлениеПерсонToolStripMenuItem.Name = "добавлениеПерсонToolStripMenuItem";
            this.добавлениеПерсонToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.добавлениеПерсонToolStripMenuItem.Text = "Добавление персон";
            // 
            // списокПерсонToolStripMenuItem
            // 
            this.списокПерсонToolStripMenuItem.Name = "списокПерсонToolStripMenuItem";
            this.списокПерсонToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.списокПерсонToolStripMenuItem.Text = "Список персон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(359, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Главная";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(845, 517);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem производителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группыТоваровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеТоваровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокТоваровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem счетфакиурыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоДатамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоТипамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоКлиентамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контрагентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокИКонтактыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеПерсонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПерсонToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}

