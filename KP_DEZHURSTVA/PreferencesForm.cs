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
    public partial class PreferencesForm : Form
    {
        public PreferencesForm()
        {
            InitializeComponent();

            dateTimePicker_day_start.Text = "08:00";
            dateTimePicker_day_end.Text = "20:00";
            dateTimePicker_day_per_start.Text = "13:00";
            dateTimePicker_day_per_end.Text = "14:00";

            dateTimePicker_night_start.Text = "20:00";
            dateTimePicker_night_end.Text = "08:00";
            dateTimePicker_night_per_start.Text = "01:00";
            dateTimePicker_night_per_end.Text = "02:00";

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
