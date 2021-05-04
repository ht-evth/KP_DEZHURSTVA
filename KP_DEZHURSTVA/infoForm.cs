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
    public partial class infoForm : Form
    {
        private bool showOwner = true;
        private Form Owner = null;
        public infoForm(Form Owner = null)
        {
            InitializeComponent();

            DateTime current_time = DateTime.Now;
            DateTime current_time_end = current_time.AddHours(8);
            DateTime next_time_start = current_time.AddHours(8).AddMinutes(30);
            
            groupBox_Current.Text = "Сейчас дежурят (до " + current_time_end.ToString("dd.MM.yyyy HH:mm") + ")";
            groupBox_Next.Text = "Следующие на дежурство (с " + next_time_start.ToString("dd.MM.yyyy HH:mm") + ")";
            Time.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");

            listBox_Current.DrawMode = DrawMode.OwnerDrawVariable;
            listBox_Current.MeasureItem += new MeasureItemEventHandler(ListBox1_MeasureItem);
            listBox_Current.DrawItem += new DrawItemEventHandler(ListBox1_DrawItem);
            listBox_Next.DrawMode = DrawMode.OwnerDrawVariable;
            listBox_Next.MeasureItem += new MeasureItemEventHandler(ListBox1_MeasureItem);
            listBox_Next.DrawItem += new DrawItemEventHandler(ListBox2_DrawItem);

        }

        private void ListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e.Graphics.FillRectangle(Brushes.CornflowerBlue, e.Bounds);

            else
                e.Graphics.FillRectangle(Brushes.Beige, e.Bounds);
 

            e.Graphics.DrawRectangle(Pens.Black, e.Bounds);

            // Draw the text in the item.
            e.Graphics.DrawString(listBox_Current.Items[e.Index].ToString(),
                this.Font, Brushes.Black, e.Bounds.X + 5, e.Bounds.Y + 7);

            // Draw the focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }

        private void ListBox2_DrawItem(object sender, DrawItemEventArgs e)
        {

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e.Graphics.FillRectangle(Brushes.CornflowerBlue, e.Bounds);

            else
                e.Graphics.FillRectangle(Brushes.Beige, e.Bounds);


            e.Graphics.DrawRectangle(Pens.Black, e.Bounds);

            // Draw the text in the item.
            e.Graphics.DrawString(listBox_Next.Items[e.Index].ToString(),
                this.Font, Brushes.Black, e.Bounds.X + 5, e.Bounds.Y + 7);

            // Draw the focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }

        // Handle the MeasureItem event for an owner-drawn ListBox.
        private void ListBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
                e.ItemHeight = 40;
        }



        private void ToolStripMenuItem_Add_EquipmentDebit_Click(object sender, EventArgs e)
        {
            showOwner = false;

            CreateForm new_window = new CreateForm(this);
            this.Visible = false;
            new_window.Visible = true;
        }

        private void выходToolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            Timer timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += RefreshTime;
            timer1.Enabled = true;
        }

        public void RefreshTime(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void listBox_Current_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Current.SelectedIndex == -1)
                button_Current.Enabled = false;
            else
                button_Current.Enabled = true;
        }

        private void listBox_Next_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Next.SelectedIndex == -1)
                button_Next.Enabled = false;
            else
                button_Next.Enabled = true;
        }

        private void button_Current_Click(object sender, EventArgs e)
        {
            new aboutPersoneForm().ShowDialog();
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            new aboutPersoneForm().ShowDialog();
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new PersoneAddForm().ShowDialog();
        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PersoneFindForm().ShowDialog();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GroupAddForm().ShowDialog();
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void найтиToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new HolidayFindForm().ShowDialog();
        }

        private void найтиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new GroupFindForm().ShowDialog();
        }

        private void ToolStripMenuItem_Find_Click(object sender, EventArgs e)
        {

        }

        private void infoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (showOwner)
              //  Owner.Visible = true;
        }

        private void настройкиДежурствToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PreferencesForm().ShowDialog();
        }
    }
}
