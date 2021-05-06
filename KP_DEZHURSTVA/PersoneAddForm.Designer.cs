
namespace KP_DEZHURSTVA
{
    partial class PersoneAddForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Midname = new System.Windows.Forms.TextBox();
            this.textBox_Firstname = new System.Windows.Forms.TextBox();
            this.textBox_Lastname = new System.Windows.Forms.TextBox();
            this.label_InventoryNum = new System.Windows.Forms.Label();
            this.label_SerialNum = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_AddAndClose = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Группа";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(178, 197);
            this.textBox_phone.MaxLength = 99;
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(370, 29);
            this.textBox_phone.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Телефон*";
            // 
            // textBox_Midname
            // 
            this.textBox_Midname.Location = new System.Drawing.Point(178, 109);
            this.textBox_Midname.MaxLength = 99;
            this.textBox_Midname.Name = "textBox_Midname";
            this.textBox_Midname.Size = new System.Drawing.Size(370, 29);
            this.textBox_Midname.TabIndex = 3;
            // 
            // textBox_Firstname
            // 
            this.textBox_Firstname.Location = new System.Drawing.Point(178, 64);
            this.textBox_Firstname.MaxLength = 99;
            this.textBox_Firstname.Name = "textBox_Firstname";
            this.textBox_Firstname.Size = new System.Drawing.Size(370, 29);
            this.textBox_Firstname.TabIndex = 2;
            // 
            // textBox_Lastname
            // 
            this.textBox_Lastname.Location = new System.Drawing.Point(178, 22);
            this.textBox_Lastname.MaxLength = 249;
            this.textBox_Lastname.Name = "textBox_Lastname";
            this.textBox_Lastname.Size = new System.Drawing.Size(370, 29);
            this.textBox_Lastname.TabIndex = 1;
            // 
            // label_InventoryNum
            // 
            this.label_InventoryNum.AutoSize = true;
            this.label_InventoryNum.Location = new System.Drawing.Point(57, 112);
            this.label_InventoryNum.Name = "label_InventoryNum";
            this.label_InventoryNum.Size = new System.Drawing.Size(98, 24);
            this.label_InventoryNum.TabIndex = 30;
            this.label_InventoryNum.Text = "Отчество";
            // 
            // label_SerialNum
            // 
            this.label_SerialNum.AutoSize = true;
            this.label_SerialNum.Location = new System.Drawing.Point(109, 67);
            this.label_SerialNum.Name = "label_SerialNum";
            this.label_SerialNum.Size = new System.Drawing.Size(53, 24);
            this.label_SerialNum.TabIndex = 29;
            this.label_SerialNum.Text = "Имя*";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(64, 25);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(98, 24);
            this.label_LastName.TabIndex = 28;
            this.label_LastName.Text = "Фамилия*";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Любая",
            "Не указана",
            "Группа - 1",
            "Группа - 2",
            "Группа - 3",
            "Группа - 4"});
            this.comboBox.Location = new System.Drawing.Point(178, 153);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(370, 32);
            this.comboBox.TabIndex = 4;
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(425, 250);
            this.button_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(180, 32);
            this.button_Close.TabIndex = 8;
            this.button_Close.Text = "Отмена";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_AddAndClose
            // 
            this.button_AddAndClose.Location = new System.Drawing.Point(202, 250);
            this.button_AddAndClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_AddAndClose.Name = "button_AddAndClose";
            this.button_AddAndClose.Size = new System.Drawing.Size(215, 32);
            this.button_AddAndClose.TabIndex = 7;
            this.button_AddAndClose.Text = "Добавить и закрыть";
            this.button_AddAndClose.UseVisualStyleBackColor = true;
            this.button_AddAndClose.Click += new System.EventHandler(this.button_AddAndClose_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(13, 250);
            this.button_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(180, 32);
            this.button_Add.TabIndex = 6;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // PersoneAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 293);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_AddAndClose);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Midname);
            this.Controls.Add(this.textBox_Firstname);
            this.Controls.Add(this.textBox_Lastname);
            this.Controls.Add(this.label_InventoryNum);
            this.Controls.Add(this.label_SerialNum);
            this.Controls.Add(this.label_LastName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(635, 332);
            this.MinimumSize = new System.Drawing.Size(635, 332);
            this.Name = "PersoneAddForm";
            this.Text = "Справочник - Добавить сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Midname;
        private System.Windows.Forms.TextBox textBox_Firstname;
        private System.Windows.Forms.TextBox textBox_Lastname;
        private System.Windows.Forms.Label label_InventoryNum;
        private System.Windows.Forms.Label label_SerialNum;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_AddAndClose;
        private System.Windows.Forms.Button button_Add;
    }
}