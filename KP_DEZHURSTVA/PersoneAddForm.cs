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
    public partial class PersoneAddForm : Form
    {
        private bool is_edit = false;
        public PersoneAddForm(bool is_edit = false)
        {
            InitializeComponent();

            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            if (is_edit)
            {
                this.textBox_Lastname.Text = " Фадеев";
                this.textBox_Firstname.Text = " Корней";
                this.textBox_Midname.Text = " Митрофанович";
                this.textBox_phone.Text = " +7(913)549-21-79";
                this.comboBox.SelectedIndex = 5;

                this.Text = "Справочник - Редактировать информацию о сотруднике";
                this.button_Add.Text = "Изменить";
                this.button_AddAndClose.Text = "Изменить и закрыть";

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
