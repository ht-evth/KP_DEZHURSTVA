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
    public partial class GroupFindForm : Form
    {
        public GroupFindForm()
        {
            InitializeComponent();

            String[] src = new string[] { "Группа - 1", "Группа - 2", "Группа - 3", "Группа - 4" };
            foreach (String item in src)
                dataGridView.Rows.Add(item);

        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView.SelectedRows.Count == 1)
            {
                this.button3.Enabled = true;
                this.button4.Enabled = true;
            }
            else if (this.dataGridView.SelectedRows.Count > 1)
            {
                this.button3.Enabled = false;
                this.button4.Enabled = true;
            }
            else
            {
                this.button3.Enabled = false;
                this.button4.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new GroupAddForm(is_edit: true).ShowDialog();
        }
    }
}
