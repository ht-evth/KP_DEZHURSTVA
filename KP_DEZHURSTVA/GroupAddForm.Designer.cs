
namespace KP_DEZHURSTVA
{
    partial class GroupAddForm
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
            this.textBox_NameEquipment = new System.Windows.Forms.TextBox();
            this.label_LastName = new System.Windows.Forms.Label();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_AddAndClose = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.listBox_all = new System.Windows.Forms.ListBox();
            this.listBox_this = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_NameEquipment
            // 
            this.textBox_NameEquipment.Location = new System.Drawing.Point(300, 25);
            this.textBox_NameEquipment.MaxLength = 249;
            this.textBox_NameEquipment.Name = "textBox_NameEquipment";
            this.textBox_NameEquipment.Size = new System.Drawing.Size(272, 29);
            this.textBox_NameEquipment.TabIndex = 28;
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(145, 28);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(151, 24);
            this.label_LastName.TabIndex = 29;
            this.label_LastName.Text = "Наименование*";
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(587, 378);
            this.button_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(180, 35);
            this.button_Close.TabIndex = 32;
            this.button_Close.Text = "Отмена";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_AddAndClose
            // 
            this.button_AddAndClose.Location = new System.Drawing.Point(364, 378);
            this.button_AddAndClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_AddAndClose.Name = "button_AddAndClose";
            this.button_AddAndClose.Size = new System.Drawing.Size(215, 35);
            this.button_AddAndClose.TabIndex = 31;
            this.button_AddAndClose.Text = "Добавить и закрыть";
            this.button_AddAndClose.UseVisualStyleBackColor = true;
            this.button_AddAndClose.Click += new System.EventHandler(this.button_AddAndClose_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(175, 378);
            this.button_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(180, 35);
            this.button_Add.TabIndex = 30;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // listBox_all
            // 
            this.listBox_all.FormattingEnabled = true;
            this.listBox_all.ItemHeight = 24;
            this.listBox_all.Items.AddRange(new object[] {
            "Ситникова Фрида Вадимовна",
            "Щербакова Азиза Платоновна",
            "Терентьева Анисья Тимофеевна",
            "Никитина Гертруда Парфеньевна",
            "Князева Даниэла Вячеславовна",
            "Рыбакова Христина Геласьевна",
            "Крюкова Диодора Кимовна",
            "Максимова Милда Львовна",
            "Комиссарова Фаиза Егоровна",
            "Королёва Жасмин Аркадьевна",
            "Юдина Нонна Богдановна",
            "Савина Адель Борисовна",
            "Сысоев Бенедикт Витальевич",
            "Ситников Евгений Митрофанович",
            "Дмитриев Илларион Петрович",
            "Никифоров Даниил Тарасович",
            "Денисов Панкрат Вадимович",
            "Ермаков Мстислав Васильевич",
            "Кириллов Адриан Лукьянович",
            "Цветков Вениамин Платонович",
            "Волков Роман Константинович",
            "Богданов Феликс Якунович",
            "Алексеев Клим Куприянович",
            "Воронов Егор Анатольевич",
            "Чернов Авраам Лаврентьевич",
            "Калашникова Вероника Макаровна",
            "Бобылёва Юстина Олеговна",
            "Егорова Хана Степановна",
            "Калинина Гражина Филипповна",
            "Колесникова Розалина Богдановна",
            "Макарова Илена Всеволодовна",
            "Уварова Эмилия Феликсовна",
            "Анисимова Розалина Мироновна",
            "Юдин Алексей Германнович",
            "Михеев Соломон Григорьевич",
            "Агафонов Нинель Лукьянович",
            "Зыков Роберт Мэлорович",
            "Белоусов Герасим Тихонович",
            "Давыдов Владимир Семёнович",
            "Ковалёв Варлам Михайлович"});
            this.listBox_all.Location = new System.Drawing.Point(14, 86);
            this.listBox_all.Name = "listBox_all";
            this.listBox_all.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_all.Size = new System.Drawing.Size(350, 268);
            this.listBox_all.TabIndex = 33;
            // 
            // listBox_this
            // 
            this.listBox_this.FormattingEnabled = true;
            this.listBox_this.ItemHeight = 24;
            this.listBox_this.Location = new System.Drawing.Point(417, 86);
            this.listBox_this.Name = "listBox_this";
            this.listBox_this.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_this.Size = new System.Drawing.Size(350, 268);
            this.listBox_this.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 39);
            this.button1.TabIndex = 35;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 39);
            this.button2.TabIndex = 36;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GroupAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 429);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox_this);
            this.Controls.Add(this.listBox_all);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_AddAndClose);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_NameEquipment);
            this.Controls.Add(this.label_LastName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "GroupAddForm";
            this.Text = "Справочник - Добавить группу сотрудников";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_NameEquipment;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_AddAndClose;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ListBox listBox_all;
        private System.Windows.Forms.ListBox listBox_this;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}