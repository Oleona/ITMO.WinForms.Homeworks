using MyClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblWorm
{
    public partial class Form1 : Form
    {
        List<Item> its = new List<Item>();
        List<Item> itsm = new List<Item>();


        public string Author // автор
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Title // Название книги
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

        public string TitleM // Название журнала
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }

        public string PublishHouse // Издательство
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }

        public string Volume//том
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }



        public int Page // Количество страниц
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year // Год издания
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }

        public int YearM // Год издания
        {
            get { return (int)numericUpDown7.Value; }
            set { numericUpDown7.Value = value; }
        }

        public int Number      // номер журнала
        {
            get { return (int)numericUpDown6.Value; }
            set { numericUpDown6.Value = value; }
        }

        public int InvNumber// Инвентарный номер
        {
            get
            {
                int indexOfTab = tabControl1.TabPages.IndexOf(tabControl1.SelectedTab);
                if (indexOfTab == 0)
                    return (int)numericUpDown3.Value;
                else return (int)numericUpDown8.Value;
            }
            set
            {
                int indexOfTab = tabControl1.TabPages.IndexOf(tabControl1.SelectedTab);
                if (indexOfTab == 0)
                    numericUpDown3.Value = value;
                else
                    numericUpDown8.Value = value;
            }
        }

        public bool Existence // Наличие
        {
            get
            {
                int indexOfTab = tabControl1.TabPages.IndexOf(tabControl1.SelectedTab);
                if (indexOfTab == 0)
                    return checkBox1.Checked;
                else return checkBox4.Checked;
            }
            set
            {
                int indexOfTab = tabControl1.TabPages.IndexOf(tabControl1.SelectedTab);
                if (indexOfTab == 0)
                    checkBox1.Checked = value;
                else checkBox4.Checked = value;
            }
        }
        public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }
        public bool ReturnTime // Возвращение в срок
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }
        public int PeriodUse // срок пользования
        {
            get { return (int)numericUpDown4.Value; }

            set { numericUpDown4.Value = value; }
        }

        public bool IfSubs// подписка на журнал
        {
            get { return checkBox5.Checked; }
            set { checkBox5.Checked = value; }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Добавить_Click(object sender, EventArgs e)
        {
            int indexOfTab = tabControl1.TabPages.IndexOf(tabControl1.SelectedTab);
            if (indexOfTab == 0)
            {
                Book b = new Book(Author, Title, PublishHouse, Page, Year, InvNumber, Existence);
                if (ReturnTime)
                    b.ReturnSrok();
                b.PriceBook(PeriodUse);
                its.Add(b);
                Author = Title = PublishHouse = "";
                Page = InvNumber = PeriodUse = 0;
                Year = 2000;
                Existence = ReturnTime = false;
            }
            else
            {
                Magazine m = new Magazine(Volume, Number, TitleM, YearM, InvNumber, Existence);
                if (IfSubs)
                    m.Subs();
                itsm.Add(m);
                Volume = TitleM = "";
                Number = 1;
                InvNumber = 0;
                YearM = 2000;
                Existence = IfSubs = false;
            }


        }

        private void Просмотреть_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
            {
                its.Sort();
                itsm.Sort();
            }
            StringBuilder sb = new StringBuilder();
            StringBuilder sm = new StringBuilder();

            int indexOfTab = tabControl1.TabPages.IndexOf(tabControl1.SelectedTab);
            if (indexOfTab == 0)
            {
                foreach (Item item in its)
                {
                    sb.Append("\n" + item.ToString());
                }
                richTextBox1.Text = sb.ToString();
            }
            else if (indexOfTab == 1)
            {
                foreach (Item item in itsm)
                {
                    sm.Append("\n" + item.ToString());
                }
                richTextBox1.Text = sm.ToString();
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
