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

        private void GenerateColors()
        {
            int num_persones = dataGridView1.Rows.Count;
            int num_days = dataGridView1.Columns.Count;




            int cur_persone = 0;
             for (int i = 1; i < num_days; i++)
             {
                 dataGridView1.Rows[cur_persone].Cells[i].Style.BackColor = Color.Red;

                 if (cur_persone == num_persones - 1)
                     cur_persone = 0;
                 else
                     cur_persone++;
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
    }
}
