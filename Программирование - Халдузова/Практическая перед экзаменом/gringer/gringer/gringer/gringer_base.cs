using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace gringer
{
    public partial class gringer_base : Form
    {
        public gringer_base()
        {
            InitializeComponent();
        }

        private void gringer_base_Load(object sender, EventArgs e)
        {

        }

        private void gringer_base_Load_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void open_Click(object sender, EventArgs e) // Открыть
        {
			OpenFileDialog dlg = new OpenFileDialog();

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				StreamReader reader = new StreamReader(dlg.FileName, Encoding.Default);
				open.Text = reader.ReadToEnd();
				reader.Close();
			}

			dlg.Dispose();
		}

        private void save_Click(object sender, EventArgs e) // Сохранить
        {
            SaveFileDialog dlg = new SaveFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);
                for (int i = 0; i < listbox_right.Items.Count; i++)
                {
                    writer.WriteLine((string)listbox_right.Items[i]);
                }
                writer.Close();
            }

            dlg.Dispose();

        }

        private void help_Click(object sender, EventArgs e) // Справка
        {
            MessageBox.Show("Над данной формой потел Болотин Максим. Если проверка производится у другого студента - знайте, что работа скопипасчена. Хоть бы дизайн сменил с:");
        }

        private void clear_Click(object sender, EventArgs e)
        {
            listbox_left.Items.Clear(); // Clear section 1
            listbox_right.Items.Clear(); // Clear section 2
            listbox_insearch.Items.Clear(); // Clear search list
            right_text_panel.Clear(); // Clear text panel right
            textboxt_insearch.Clear(); // Clear search box
            checkbox_insection1.Checked = true; // Default arrow on section 1
            checkbox_insection2.Checked = false; // // Default arrow off section 2
            choose_all.Checked = true; // // Default arrow in all
        }

        private void start_Click(object sender, EventArgs e) // Начать button
        {
            listbox_left.Items.Clear();
            listbox_right.Items.Clear();

            listbox_left.BeginUpdate();
            string[] strings = right_text_panel.Text.Split(new char[] { '\n', '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in strings)
            {
                string str = s.Trim();
                if (str == String.Empty)
                    continue;
                if (choose_all.Checked)
                {
                    listbox_left.Items.Add(str);
                }
                if (choose_numbers.Checked)
                {
                    if (Regex.IsMatch(str, @"\d"))
                        listbox_left.Items.Add(str);
                }
                if (choose_emails.Checked)
                {
                    if (Regex.IsMatch(str, @"\w+@\w+\.\w+"))
                        listbox_left.Items.Add(str);
                }

            }
            listbox_left.EndUpdate();
        }

        private void add_Click(object sender, EventArgs e)
        {
            listbox_left.Items.Clear();
            //string Find = textBox1.Text;
            if (listbox_left.Checked)
            {
                listbox_left.Items.Clear();
                string Find = listbox_left.Text;
                foreach (string String in listBox2.Items)
                {
                    if (String.Contains(Find)) listbox_left.Items.Add(String);
                }
            }

            if (checkBox2.Checked)
            {
                listbox_left.Items.Clear();
                string Find = textBox1.Text;
                foreach (string String in listBox3.Items)
                {
                    if (String.Contains(Find)) listbox_left.Items.Add(String);
                }
            }

        }
    }
}
