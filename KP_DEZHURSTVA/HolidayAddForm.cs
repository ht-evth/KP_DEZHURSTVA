using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP_DEZHURSTVA
{
    public partial class HolidayAddForm : Form
    {
        private bool is_edit = false;
        public HolidayAddForm(bool is_edit = false)
        {
            InitializeComponent();

            if (is_edit)
            {
                this.textBox_Lastname.Text = "Новогодние каникулы";
                this.Text = "Справочник - Редактировать праздничный день";
                this.button_Add.Text = "Изменить";
                this.button_AddAndClose.Text = "Изменить и закрыть";
                this.checkBox1.Checked = true;
                this.dateTimePicker1.Text = "1 Января";

                this.is_edit = is_edit;
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (is_edit)
                MessageBox.Show("Успешно изменено!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Успешно Добавлено!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_AddAndClose_Click(object sender, EventArgs e)
        {
            button_Add.PerformClick();
            this.Close();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
