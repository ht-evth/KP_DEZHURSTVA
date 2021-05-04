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

            this.comboBox_month.SelectedIndex = 4;
            this.comboBox_year.SelectedIndex = 0;

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

        private bool CheckForHolidays(int row, int col)
        {
            if (this.dataGridView1.Rows[row].Cells[col - 1].Style.BackColor == Color.LightCoral || this.dataGridView1.Rows[row].Cells[col - 1].Style.BackColor == Color.MediumPurple)
                return false;

            if (col + 1 < this.dataGridView1.Columns.Count)
                if (this.dataGridView1.Rows[row].Cells[col + 1].Style.BackColor == Color.LightCoral || this.dataGridView1.Rows[row].Cells[col + 1].Style.BackColor == Color.MediumPurple)
                    return false;

            return true;
        }



        private void GenerateColors(int cur_persone = 0)
        {
            int num_persones = dataGridView1.Rows.Count;
            int num_days = dataGridView1.Columns.Count;

            int persones_per_day = 1;

            if (numericUpDown1.Enabled)
            {
                persones_per_day = Convert.ToInt32(this.numericUpDown1.Value);

                if (persones_per_day > this.dataGridView1.Rows.Count)
                {
                    persones_per_day = this.dataGridView1.Rows.Count / 2;
                    this.numericUpDown1.Value = persones_per_day;
                    MessageBox.Show("Кол-во сотрудников в смене уменьшено, иначе не удаётся соблюсти правило не более 1 дежурства подряд!");
                }
            }

            if (radioButton_day_might.Checked)
                persones_per_day *= 2;

            int count = 1;


            for(int i = 1; i < this.dataGridView1.Columns.Count; i++)
            {
                resetColorForColumn(i, Color.White);
            }

            for (int i = 1; i < num_days; i++)
             {
                if (IsItHolyday(dataGridView1.Columns[i].HeaderText))
                {
                    resetColorForColumn(i, Color.LightYellow);
                    continue;
                }
                else
                {
                    //if (dataGridView1.Rows[cur_persone].Cells[i - 1].Style.BackColor == Color.LightCoral)
                    //{
                    //   dataGridView1.Rows[GetNextPersone(cur_persone, num_persones)].Cells[i].Style.BackColor = Color.LightCoral;
                    //   dataGridView1.Rows[GetNextPersone(cur_persone, num_persones)].Cells[i].Style.SelectionBackColor = Color.LightCoral;
                    //}
                    //else
                    // {
                    if (radioButton_day_might.Checked)
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
                    //}
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

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            if (this.radioButton_individ.Checked)
            {
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

                foreach (String Persone in Persones)
                    dataGridView1.Rows.Add(Persone);

            }
            else
            {
                String[] Groups = new String[] {
                    "Группа - 1",
                    "Группа - 2",
                    "Группа - 3",
                    "Группа - 4"
                };

                foreach (String Group in Groups)
                    dataGridView1.Rows.Add(Group);
            }

            GenerateColors();


        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                return;

            if (e.Button == MouseButtons.Left)
            {
                if (e.ColumnIndex == 0)
                    GenerateColors(e.RowIndex);
                else
                {
                    if (CheckForHolidays(e.RowIndex, e.ColumnIndex))
                    {
                        if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor != Color.LightCoral)
                        {
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightCoral;
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.LightCoral;
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionForeColor = Color.Black;
                        }
                        else if (radioButton_day_might.Checked)
                        {
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.MediumPurple;
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.MediumPurple;
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionForeColor = Color.Black;
                        }
                    }
                    else
                        MessageBox.Show("Нельзья установить более 1 дежурства подряд!");
                }
            }
            else if (e.Button == MouseButtons.Right && e.ColumnIndex > 0)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.White;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionForeColor = Color.Black;
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex < 1)
                return;

            if (e.Button == MouseButtons.Left )
            {
                if (e.ColumnIndex == 0)
                    return;
                else
                {
                    
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";

                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightYellow;
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.LightYellow;
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionForeColor = Color.Black;
                }
            }
           
        }

        private void radioButton_group_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = radioButton_individ.Checked;
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void настройкиДежурствToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PreferencesForm().ShowDialog();
        }

        private void отчётToolStripMenuItem_Report_Click(object sender, EventArgs e)
        {
            new ReportForm().Show();
            this.Hide();
        }
    }
}
