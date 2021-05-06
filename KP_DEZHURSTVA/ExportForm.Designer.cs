
namespace KP_DEZHURSTVA
{
    partial class ExportForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_end_year = new System.Windows.Forms.Label();
            this.label_end_month = new System.Windows.Forms.Label();
            this.comboBox_end_year = new System.Windows.Forms.ComboBox();
            this.comboBox_end_month = new System.Windows.Forms.ComboBox();
            this.label_start_year = new System.Windows.Forms.Label();
            this.label_start_month = new System.Windows.Forms.Label();
            this.comboBox_start_year = new System.Windows.Forms.ComboBox();
            this.comboBox_start_month = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_end_year);
            this.groupBox1.Controls.Add(this.label_end_month);
            this.groupBox1.Controls.Add(this.comboBox_end_year);
            this.groupBox1.Controls.Add(this.comboBox_end_month);
            this.groupBox1.Controls.Add(this.label_start_year);
            this.groupBox1.Controls.Add(this.label_start_month);
            this.groupBox1.Controls.Add(this.comboBox_start_year);
            this.groupBox1.Controls.Add(this.comboBox_start_month);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Диапазон месяцев для экспорта/печати";
            // 
            // label_end_year
            // 
            this.label_end_year.AutoSize = true;
            this.label_end_year.Location = new System.Drawing.Point(484, 93);
            this.label_end_year.Name = "label_end_year";
            this.label_end_year.Size = new System.Drawing.Size(44, 24);
            this.label_end_year.TabIndex = 38;
            this.label_end_year.Text = "Год";
            this.label_end_year.Visible = false;
            // 
            // label_end_month
            // 
            this.label_end_month.AutoSize = true;
            this.label_end_month.Location = new System.Drawing.Point(256, 91);
            this.label_end_month.Name = "label_end_month";
            this.label_end_month.Size = new System.Drawing.Size(35, 24);
            this.label_end_month.TabIndex = 37;
            this.label_end_month.Text = "До";
            this.label_end_month.Visible = false;
            // 
            // comboBox_end_year
            // 
            this.comboBox_end_year.FormattingEnabled = true;
            this.comboBox_end_year.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031"});
            this.comboBox_end_year.Location = new System.Drawing.Point(534, 89);
            this.comboBox_end_year.Name = "comboBox_end_year";
            this.comboBox_end_year.Size = new System.Drawing.Size(158, 32);
            this.comboBox_end_year.TabIndex = 5;
            this.comboBox_end_year.Visible = false;
            // 
            // comboBox_end_month
            // 
            this.comboBox_end_month.FormattingEnabled = true;
            this.comboBox_end_month.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.comboBox_end_month.Location = new System.Drawing.Point(297, 88);
            this.comboBox_end_month.Name = "comboBox_end_month";
            this.comboBox_end_month.Size = new System.Drawing.Size(158, 32);
            this.comboBox_end_month.TabIndex = 4;
            this.comboBox_end_month.Visible = false;
            // 
            // label_start_year
            // 
            this.label_start_year.AutoSize = true;
            this.label_start_year.Location = new System.Drawing.Point(484, 44);
            this.label_start_year.Name = "label_start_year";
            this.label_start_year.Size = new System.Drawing.Size(44, 24);
            this.label_start_year.TabIndex = 34;
            this.label_start_year.Text = "Год";
            // 
            // label_start_month
            // 
            this.label_start_month.AutoSize = true;
            this.label_start_month.Location = new System.Drawing.Point(256, 42);
            this.label_start_month.Name = "label_start_month";
            this.label_start_month.Size = new System.Drawing.Size(35, 24);
            this.label_start_month.TabIndex = 33;
            this.label_start_month.Text = "От";
            this.label_start_month.Visible = false;
            // 
            // comboBox_start_year
            // 
            this.comboBox_start_year.FormattingEnabled = true;
            this.comboBox_start_year.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031"});
            this.comboBox_start_year.Location = new System.Drawing.Point(534, 40);
            this.comboBox_start_year.Name = "comboBox_start_year";
            this.comboBox_start_year.Size = new System.Drawing.Size(158, 32);
            this.comboBox_start_year.TabIndex = 3;
            // 
            // comboBox_start_month
            // 
            this.comboBox_start_month.FormattingEnabled = true;
            this.comboBox_start_month.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.comboBox_start_month.Location = new System.Drawing.Point(297, 39);
            this.comboBox_start_month.Name = "comboBox_start_month";
            this.comboBox_start_month.Size = new System.Drawing.Size(158, 32);
            this.comboBox_start_month.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(24, 89);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(116, 28);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Диапазон";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(137, 28);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Один месяц";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Экспортировать в Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(346, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Экспортировать в Excel и печать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 218);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(752, 257);
            this.MinimumSize = new System.Drawing.Size(752, 257);
            this.Name = "ExportForm";
            this.Text = "Экспорт и печать графика дежурств";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label_start_year;
        private System.Windows.Forms.ComboBox comboBox_start_year;
        private System.Windows.Forms.ComboBox comboBox_start_month;
        private System.Windows.Forms.Label label_end_year;
        private System.Windows.Forms.Label label_end_month;
        private System.Windows.Forms.ComboBox comboBox_end_year;
        private System.Windows.Forms.ComboBox comboBox_end_month;
        private System.Windows.Forms.Label label_start_month;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}