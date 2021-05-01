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
    public partial class HolidayFindForm : Form
    {
        public HolidayFindForm()
        {
            InitializeComponent();

            String[,] Holidays = new String[,] {
                { "Новогодние каникулы", "1 января", "+" },
                { "Новогодние каникулы", "2 января", "+" },
                { "Новогодние каникулы", "3 января", "+" },
                { "Новогодние каникулы", "4 января", "+" },
                { "Новогодние каникулы", "5 января", "+" },
                { "Новогодние каникулы", "6 января", "+" },
                { "Рождество Христово", "7 января", "+" },
                { "Новогодние каникулы", "8 января", "+" },
                { "Годовщина открытия производства", "19 января", "-" },
                { "День Защитника Отечества", "23 февраля", "+" },
                { "Международный женский день", "8 марта", "+" },
                { "Праздник Весны и Труда", "1 мая", "+" },
                { "День Победы", "9 мая", "+" },
                { "День России", "12 Июня", "+" },
                { "День народного единства", "4 ноября", "+" }
            };

            for (int i = 0; i < Holidays.Length / 3; i++)
            {
                if ("+".Contains(Holidays[i, 2]))
                    dataGridView.Rows.Add(Holidays[i, 0], Holidays[i, 1], true);
                else
                    dataGridView.Rows.Add(Holidays[i, 0], Holidays[i, 1], false);
            }
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
    }
}
