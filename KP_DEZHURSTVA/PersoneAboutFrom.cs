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
    public partial class aboutPersoneForm : Form
    {
        private Random rnd = new Random();
        public aboutPersoneForm()
        {
            InitializeComponent();

            GenerateColors();
            this.dataGridView1.ClearSelection();
        }


        private void resetColorForColumn(int col_index, Color color)
        {
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                dataGridView1[col_index, i].Style.BackColor = color;
                dataGridView1[col_index, i].Style.SelectionBackColor = color;
                dataGridView1[col_index, i].Style.ForeColor = Color.Black;
                dataGridView1[col_index, i].Style.SelectionForeColor = Color.Black;
            }
        }

        private bool IsItHolyday(String header)
        {

            String[] Holidays = new String[] {
                "01.01",
                "02.01",
                "03.01",
                "04.01",
                "05.01",
                "06.01",
                "07.01",
                "08.01",
                "19.01",
                "23.02",
                "08.03",
                "01.05",
                "09.05",
                "12.06",
                "04.11",
            };

            foreach (String Holyday in Holidays)
                if (Holyday == header)
                    return true;

            return false;
        }



        private void GenerateColors(int cur_persone = 0)
        {
            this.dataGridView1.Rows.Clear();

            this.dataGridView1.Rows.Add();

            int num_days = dataGridView1.Columns.Count;

            bool is_night = false;

            if (rnd.Next() % 2 == 0)
            {
                is_night = true;
            }

            for (int i = 1; i < num_days; i += rnd.Next(2, 5))
            {

                if (i > num_days - 1)
                    break;

                if (IsItHolyday(dataGridView1.Columns[i].HeaderText))
                {
                    resetColorForColumn(i, Color.LightYellow);
                    continue;
                }
                else
                {

                    if (is_night)
                    {
                        if (rnd.Next() % 2 == 0)
                        {
                            dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.LightCoral;
                            dataGridView1.Rows[0].Cells[i].Style.SelectionBackColor = Color.LightCoral;
                        }
                        else
                        {
                            dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.MediumPurple;
                            dataGridView1.Rows[0].Cells[i].Style.SelectionBackColor = Color.MediumPurple;
                        }
                    }
                    else
                    {
                        dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.LightCoral;
                        dataGridView1.Rows[0].Cells[i].Style.SelectionBackColor = Color.LightCoral;
                    }
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ExportForm(true).ShowDialog();
        }
    }
}
