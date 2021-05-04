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
    public partial class CreateForm : Form
    {
        private Form Owner = null;
        private bool showOwner = true;
        public CreateForm(Form Owner)
        {
            
            InitializeComponent();
            this.Owner = Owner;

            this.comboBox_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

        }

        private void CreateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (showOwner)
              //  Owner.Visible = true;
        }

        private void ToolStripMenuItem_Find_Click(object sender, EventArgs e)
        {
            showOwner = false;

            infoForm new_window = new infoForm(this);
            this.Visible = false;
            new_window.Visible = true;
        }
    }
}
