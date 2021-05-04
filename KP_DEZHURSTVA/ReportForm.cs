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
    public partial class ReportForm : Form
    {

        private Random rnd = new Random();

        public ReportForm()
        {
            InitializeComponent();

            this.comboBox_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.comboBox_month.SelectedIndex = 4;
            this.comboBox_year.SelectedIndex = 0;

            CreateGraph();
        }

        private void GenerateColors(int cur_persone = 0)
        {
            int num_persones = dataGridView1.Rows.Count;
            int num_days = dataGridView1.Columns.Count;

            int persones_per_day = rnd.Next(1, 4);
            bool is_night = false;

            if (rnd.Next() % 2 == 0)
            {
                is_night = true;
                persones_per_day *= 2;
            }

            int count = 1;

            for (int i = 1; i < this.dataGridView1.Columns.Count; i++)
                resetColorForColumn(i, Color.White);


            for (int i = 1; i < num_days; i++)
            {
                if (IsItHolyday(dataGridView1.Columns[i].HeaderText))
                {
                    resetColorForColumn(i, Color.LightYellow);
                    continue;
                }
                else
                {

                    if (is_night)
                    {
                        if (count <= persones_per_day / 2)
                        {
                            dataGridView1.Rows[cur_persone].Cells[i].Style.BackColor = Color.LightCoral;
                            dataGridView1.Rows[cur_persone].Cells[i].Style.SelectionBackColor = Color.LightCoral;
                        }
                        else
                        {
                            dataGridView1.Rows[cur_persone].Cells[i].Style.BackColor = Color.MediumPurple;
                            dataGridView1.Rows[cur_persone].Cells[i].Style.SelectionBackColor = Color.MediumPurple;
                        }
                    }
                    else
                    {
                        dataGridView1.Rows[cur_persone].Cells[i].Style.BackColor = Color.LightCoral;
                        dataGridView1.Rows[cur_persone].Cells[i].Style.SelectionBackColor = Color.LightCoral;
                    }
                }

                if (cur_persone == num_persones - 1)
                    cur_persone = 0;
                else
                    cur_persone++;

                if (count == persones_per_day)
                    count = 1;
                else
                {
                    count++;
                    i--;
                }
            }

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


        private void CreateGraph()
        {
            dataGridView1.Rows.Clear();


            String[] Persones = new String[] {
                "Фадеев Корней Митрофанович" ,
                "Галкин Игнатий Протасьевич",
                "Данилов Макар Еремеевич",
                "Ильин Моисей Федорович",
                "Фёдоров Емельян Андреевич",
                "Попов Всеволод Ростиславович",
                "Куликов Рудольф Яковлевич",
                "Владимиров Лазарь Донатович",
                "Максимов Альфред Григорьевич",
                "Жданов Мирон Валерьянович",
                "Киселёва Дарьяна Филипповна",
                "Хохлова Амалия Антоновна",
                "Александрова Джема Богуславовна",
                "Симонова Магда Семёновна",
                "Горбунова Бронислава Наумовна",
                "Калинина Георгина Руслановна",
                "Трофимова Кристина Альбертовна",
                "Уварова Клавдия Парфеньевна",
                "Жданова Гелианна Максовна",
                "Петрова Людмила Леонидовна",
                "Исаев Виссарион Павлович",
                "Матвеев Вилен Альбертович",
                "Силин Богдан Альбертович",
                "Федосеев Ираклий Федотович",
                "Юдин Мстислав Семёнович",
                "Яковлева Милда Евсеевна",
                "Рябова Эллада Натановна",
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


            String[] Months = new String[] {
                "Января" ,
                "Февраля",
                "Марта",
                "Апреля",
                "Мая",
                "Июня",
                "Июля",
                "Августа",
                "Сентября",
                "Октября",
                "Ноября",
                "Декабря"         
            };

            string month = Months[comboBox_month.SelectedIndex];
            int i = 0;

            foreach (DataGridViewColumn col in this.dataGridView1.Columns)
            {
                if (i != 0)
                    col.HeaderText = i.ToString() + " " + month;
                i++;
            }

            foreach (String Persone in Persones)
                dataGridView1.Rows.Add(Persone);

            


            GenerateColors(rnd.Next(0, Persones.Count()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateGraph();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ExportForm().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new SwapForm().ShowDialog();
        }

        private void отчётToolStripMenuItem_Report_Click(object sender, EventArgs e)
        {

        }

        private void экспортПечатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3.PerformClick();
        }

        private void ToolStripMenuItem_Add_Click(object sender, EventArgs e)
        {
            new CreateForm(this).Show();
            this.Hide();
        }

        private void ToolStripMenuItem_Find_Click(object sender, EventArgs e)
        {
            new infoForm().Show();
            this.Hide();
        }

        private void выходToolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void найтиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new GroupFindForm().ShowDialog();
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new HolidayAddForm().ShowDialog();
        }

        private void найтиToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new HolidayFindForm().ShowDialog();
        }

        private void настройкиДежурствToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PreferencesForm().ShowDialog();
        }
    }
}
