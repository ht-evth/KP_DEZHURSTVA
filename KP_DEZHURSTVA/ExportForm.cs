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
    public partial class ExportForm : Form
    {
        public ExportForm(bool is_persone = false)
        {
            InitializeComponent();

            if (is_persone)
                this.Text = "Экспорт и печать графика дежурств для сотрудника";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            bool value = this.radioButton2.Checked;

            label_start_month.Visible = value;
            label_end_month.Visible = value;
            label_end_year.Visible = value;
            comboBox_end_month.Visible = value;
            comboBox_end_year.Visible = value;
        }
    }
}
