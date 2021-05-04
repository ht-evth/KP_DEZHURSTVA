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
    public partial class SwapForm : Form
    {
        public SwapForm()
        {
            InitializeComponent();

            listBox_Current.DrawMode = DrawMode.OwnerDrawVariable;
            listBox_Current.MeasureItem += new MeasureItemEventHandler(ListBox1_MeasureItem);
            listBox_Current.DrawItem += new DrawItemEventHandler(ListBox1_DrawItem);
            listBox1.DrawMode = DrawMode.OwnerDrawVariable;
            listBox1.MeasureItem += new MeasureItemEventHandler(ListBox1_MeasureItem);
            listBox1.DrawItem += new DrawItemEventHandler(ListBox2_DrawItem);

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
            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(),
                this.Font, Brushes.Black, e.Bounds.X + 5, e.Bounds.Y + 7);

            // Draw the focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }

        // Handle the MeasureItem event for an owner-drawn ListBox.
        private void ListBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 40;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнено!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
