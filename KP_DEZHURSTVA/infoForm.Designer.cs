
namespace KP_DEZHURSTVA
{
    partial class infoForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_EquipmentDebit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Find = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётToolStripMenuItem_Report = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Handbooks = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Equipment_Handbook = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_GroupEquipment_Handbook = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Workshop_Handbook = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Time = new System.Windows.Forms.Label();
            this.groupBox_Current = new System.Windows.Forms.GroupBox();
            this.button_Current = new System.Windows.Forms.Button();
            this.listBox_Current = new System.Windows.Forms.ListBox();
            this.groupBox_Next = new System.Windows.Forms.GroupBox();
            this.button_Next = new System.Windows.Forms.Button();
            this.listBox_Next = new System.Windows.Forms.ListBox();
            this.menuStrip.SuspendLayout();
            this.groupBox_Current.SuspendLayout();
            this.groupBox_Next.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_EquipmentDebit,
            this.ToolStripMenuItem_Handbooks});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(1034, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_EquipmentDebit
            // 
            this.ToolStripMenuItem_EquipmentDebit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Add,
            this.ToolStripMenuItem_Find,
            this.отчётToolStripMenuItem_Report,
            this.выходToolStripMenuItem_Exit});
            this.ToolStripMenuItem_EquipmentDebit.Name = "ToolStripMenuItem_EquipmentDebit";
            this.ToolStripMenuItem_EquipmentDebit.Size = new System.Drawing.Size(55, 20);
            this.ToolStripMenuItem_EquipmentDebit.Text = "Файл";
            // 
            // ToolStripMenuItem_Add
            // 
            this.ToolStripMenuItem_Add.Name = "ToolStripMenuItem_Add";
            this.ToolStripMenuItem_Add.Size = new System.Drawing.Size(215, 22);
            this.ToolStripMenuItem_Add.Text = "Создать";
            this.ToolStripMenuItem_Add.Click += new System.EventHandler(this.ToolStripMenuItem_Add_EquipmentDebit_Click);
            // 
            // ToolStripMenuItem_Find
            // 
            this.ToolStripMenuItem_Find.Enabled = false;
            this.ToolStripMenuItem_Find.Name = "ToolStripMenuItem_Find";
            this.ToolStripMenuItem_Find.Size = new System.Drawing.Size(215, 22);
            this.ToolStripMenuItem_Find.Text = "Краткая информация";
            this.ToolStripMenuItem_Find.Click += new System.EventHandler(this.ToolStripMenuItem_Find_Click);
            // 
            // отчётToolStripMenuItem_Report
            // 
            this.отчётToolStripMenuItem_Report.Name = "отчётToolStripMenuItem_Report";
            this.отчётToolStripMenuItem_Report.Size = new System.Drawing.Size(215, 22);
            this.отчётToolStripMenuItem_Report.Text = "Отчёт";
            // 
            // выходToolStripMenuItem_Exit
            // 
            this.выходToolStripMenuItem_Exit.Name = "выходToolStripMenuItem_Exit";
            this.выходToolStripMenuItem_Exit.Size = new System.Drawing.Size(215, 22);
            this.выходToolStripMenuItem_Exit.Text = "Выход";
            this.выходToolStripMenuItem_Exit.Click += new System.EventHandler(this.выходToolStripMenuItem_Exit_Click);
            // 
            // ToolStripMenuItem_Handbooks
            // 
            this.ToolStripMenuItem_Handbooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Equipment_Handbook,
            this.ToolStripMenuItem_GroupEquipment_Handbook,
            this.ToolStripMenuItem_Workshop_Handbook});
            this.ToolStripMenuItem_Handbooks.Name = "ToolStripMenuItem_Handbooks";
            this.ToolStripMenuItem_Handbooks.Size = new System.Drawing.Size(108, 20);
            this.ToolStripMenuItem_Handbooks.Text = "Справочники";
            // 
            // ToolStripMenuItem_Equipment_Handbook
            // 
            this.ToolStripMenuItem_Equipment_Handbook.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.найтиToolStripMenuItem});
            this.ToolStripMenuItem_Equipment_Handbook.Name = "ToolStripMenuItem_Equipment_Handbook";
            this.ToolStripMenuItem_Equipment_Handbook.Size = new System.Drawing.Size(212, 22);
            this.ToolStripMenuItem_Equipment_Handbook.Text = "Сотрудники";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.toolStripMenuItem1.Text = "Добавить";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.найтиToolStripMenuItem.Text = "Найти";
            this.найтиToolStripMenuItem.Click += new System.EventHandler(this.найтиToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_GroupEquipment_Handbook
            // 
            this.ToolStripMenuItem_GroupEquipment_Handbook.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.найтиToolStripMenuItem1});
            this.ToolStripMenuItem_GroupEquipment_Handbook.Name = "ToolStripMenuItem_GroupEquipment_Handbook";
            this.ToolStripMenuItem_GroupEquipment_Handbook.Size = new System.Drawing.Size(212, 22);
            this.ToolStripMenuItem_GroupEquipment_Handbook.Text = "Группы сотрудников";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // найтиToolStripMenuItem1
            // 
            this.найтиToolStripMenuItem1.Name = "найтиToolStripMenuItem1";
            this.найтиToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.найтиToolStripMenuItem1.Text = "Найти";
            this.найтиToolStripMenuItem1.Click += new System.EventHandler(this.найтиToolStripMenuItem1_Click);
            // 
            // ToolStripMenuItem_Workshop_Handbook
            // 
            this.ToolStripMenuItem_Workshop_Handbook.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.найтиToolStripMenuItem2});
            this.ToolStripMenuItem_Workshop_Handbook.Name = "ToolStripMenuItem_Workshop_Handbook";
            this.ToolStripMenuItem_Workshop_Handbook.Size = new System.Drawing.Size(212, 22);
            this.ToolStripMenuItem_Workshop_Handbook.Text = "Праздничные дни";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.добавитьToolStripMenuItem1_Click);
            // 
            // найтиToolStripMenuItem2
            // 
            this.найтиToolStripMenuItem2.Name = "найтиToolStripMenuItem2";
            this.найтиToolStripMenuItem2.Size = new System.Drawing.Size(139, 22);
            this.найтиToolStripMenuItem2.Text = "Найти";
            this.найтиToolStripMenuItem2.Click += new System.EventHandler(this.найтиToolStripMenuItem2_Click);
            // 
            // Time
            // 
            this.Time.Dock = System.Windows.Forms.DockStyle.Top;
            this.Time.Location = new System.Drawing.Point(0, 28);
            this.Time.Name = "Time";
            this.Time.Padding = new System.Windows.Forms.Padding(3);
            this.Time.Size = new System.Drawing.Size(1034, 30);
            this.Time.TabIndex = 2;
            this.Time.Text = "Time";
            this.Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_Current
            // 
            this.groupBox_Current.Controls.Add(this.button_Current);
            this.groupBox_Current.Controls.Add(this.listBox_Current);
            this.groupBox_Current.Location = new System.Drawing.Point(10, 57);
            this.groupBox_Current.Name = "groupBox_Current";
            this.groupBox_Current.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox_Current.Size = new System.Drawing.Size(502, 400);
            this.groupBox_Current.TabIndex = 3;
            this.groupBox_Current.TabStop = false;
            this.groupBox_Current.Text = "Сейчас дежурят";
            // 
            // button_Current
            // 
            this.button_Current.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Current.Enabled = false;
            this.button_Current.Location = new System.Drawing.Point(10, 359);
            this.button_Current.Name = "button_Current";
            this.button_Current.Size = new System.Drawing.Size(482, 31);
            this.button_Current.TabIndex = 1;
            this.button_Current.Text = "Информация о сотруднике";
            this.button_Current.UseVisualStyleBackColor = true;
            this.button_Current.Click += new System.EventHandler(this.button_Current_Click);
            // 
            // listBox_Current
            // 
            this.listBox_Current.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox_Current.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Current.FormattingEnabled = true;
            this.listBox_Current.ItemHeight = 20;
            this.listBox_Current.Items.AddRange(new object[] {
            "Фадеев Корней Митрофанович",
            "Галкин Игнатий Протасьевич",
            "Данилов Макар Еремеевич",
            "Ильин Моисей Федорович",
            "Фёдоров Емельян Андреевич",
            "Попов Всеволод Ростиславович",
            "Куликов Рудольф Яковлевич",
            "Владимиров Лазарь Донатович",
            "Максимов Альфред Григорьевич",
            "Жданов Мирон Валерьянович"});
            this.listBox_Current.Location = new System.Drawing.Point(10, 32);
            this.listBox_Current.Name = "listBox_Current";
            this.listBox_Current.Size = new System.Drawing.Size(482, 304);
            this.listBox_Current.TabIndex = 0;
            this.listBox_Current.SelectedIndexChanged += new System.EventHandler(this.listBox_Current_SelectedIndexChanged);
            // 
            // groupBox_Next
            // 
            this.groupBox_Next.Controls.Add(this.button_Next);
            this.groupBox_Next.Controls.Add(this.listBox_Next);
            this.groupBox_Next.Location = new System.Drawing.Point(522, 57);
            this.groupBox_Next.Name = "groupBox_Next";
            this.groupBox_Next.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox_Next.Size = new System.Drawing.Size(502, 400);
            this.groupBox_Next.TabIndex = 4;
            this.groupBox_Next.TabStop = false;
            this.groupBox_Next.Text = "Следующие на дежурство";
            // 
            // button_Next
            // 
            this.button_Next.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Next.Enabled = false;
            this.button_Next.Location = new System.Drawing.Point(10, 359);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(482, 31);
            this.button_Next.TabIndex = 2;
            this.button_Next.Text = "Информация о сотруднике";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // listBox_Next
            // 
            this.listBox_Next.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Next.FormattingEnabled = true;
            this.listBox_Next.ItemHeight = 20;
            this.listBox_Next.Items.AddRange(new object[] {
            "Киселёва Дарьяна Филипповна",
            "Хохлова Амалия Антоновна",
            "Александрова Джема Богуславовна",
            "Симонова Магда Семёновна",
            "Горбунова Бронислава Наумовна",
            "Калинина Георгина Руслановна",
            "Трофимова Кристина Альбертовна",
            "Уварова Клавдия Парфеньевна",
            "Жданова Гелианна Максовна",
            "Петрова Людмила Леонидовна"});
            this.listBox_Next.Location = new System.Drawing.Point(10, 32);
            this.listBox_Next.Name = "listBox_Next";
            this.listBox_Next.Size = new System.Drawing.Size(482, 304);
            this.listBox_Next.TabIndex = 1;
            this.listBox_Next.SelectedIndexChanged += new System.EventHandler(this.listBox_Next_SelectedIndexChanged);
            // 
            // infoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 461);
            this.Controls.Add(this.groupBox_Next);
            this.Controls.Add(this.groupBox_Current);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "infoForm";
            this.Text = "График дежурств - Краткая информация";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox_Current.ResumeLayout(false);
            this.groupBox_Next.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_EquipmentDebit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Add;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Find;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Handbooks;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Equipment_Handbook;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_GroupEquipment_Handbook;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Workshop_Handbook;
        private System.Windows.Forms.ToolStripMenuItem отчётToolStripMenuItem_Report;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem_Exit;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.GroupBox groupBox_Current;
        private System.Windows.Forms.GroupBox groupBox_Next;
        private System.Windows.Forms.ListBox listBox_Current;
        private System.Windows.Forms.ListBox listBox_Next;
        private System.Windows.Forms.Button button_Current;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem2;
    }
}

