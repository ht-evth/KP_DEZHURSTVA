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
    public partial class GroupAddForm : Form
    {
        private bool is_edit = false;
        public GroupAddForm(bool is_edit = false)
        {
            InitializeComponent();

            listBox_all.DrawMode = DrawMode.OwnerDrawVariable;
            listBox_all.MeasureItem += new MeasureItemEventHandler(ListBox1_MeasureItem);
            listBox_all.DrawItem += new DrawItemEventHandler(ListBox1_DrawItem);
            listBox_this.DrawMode = DrawMode.OwnerDrawVariable;
            listBox_this.MeasureItem += new MeasureItemEventHandler(ListBox1_MeasureItem);
            listBox_this.DrawItem += new DrawItemEventHandler(ListBox2_DrawItem);

            if (is_edit)
            {
                this.Text = "Справочник - Редактировать группу сотрудников";
                this.button_Add.Text = "Изменить";
                this.button_AddAndClose.Text = "Изменить и закрыть";

                this.textBox_NameEquipment.Text = "Группа - 1";

                String[] src = new String[] {
                "Воронова Береслава Якововна",
                "Гусева Стефания Прокловна",
                "Боброва Джульетта Денисовна",
                "Панова Янина Олеговна",
                "Сазонова Лада Михаиловна",
                "Мамонтова Ирэна Николаевна",
                "Шубина Аза Яковлевна",
                "Андреева Полианна Юлиановна",
                "Гурьев Григорий Геннадьевич",
                "Петухов Михаил Денисович",
                "Фёдоров Самуил Максович",
                "Воронов Гордий Николаевич",
                "Карпов Дональд Васильевич"
                };

                this.listBox_this.Items.AddRange(src);

                this.is_edit = is_edit;
            }
        }

        private void ListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e.Graphics.FillRectangle(Brushes.CornflowerBlue, e.Bounds);

            else
                e.Graphics.FillRectangle(Brushes.Beige, e.Bounds);


            e.Graphics.DrawRectangle(Pens.Black, e.Bounds);

            // Draw the text in the item.
            if (listBox_all.Items.Count > 0)
                e.Graphics.DrawString(listBox_all.Items[e.Index].ToString(),
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
            if (listBox_this.Items.Count > 0)
                e.Graphics.DrawString(listBox_this.Items[e.Index].ToString(),
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
            for (int i = 0; i < listBox_all.SelectedItems.Count; i++)
            {
                listBox_this.Items.Add(listBox_all.SelectedItems[i]);
                listBox_all.Items.Remove(listBox_all.SelectedItems[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox_this.SelectedItems.Count; i++)
            {
                listBox_all.Items.Add(listBox_this.SelectedItems[i]);
                listBox_this.Items.Remove(listBox_this.SelectedItems[i]);
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
