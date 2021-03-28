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

// Copyright by Bolotin Maxim CCA-30


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

        private void close_Click(object sender, EventArgs e) // Закрыть
        {
            Application.Exit();
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
            add_form AddRec = new add_form
            {
                Owner = this
            };
            AddRec.ShowDialog();
        }

        private void clear_left_Click(object sender, EventArgs e) // Clear left list
        {
            listbox_left.Items.Clear();
        }

        private void sorgt_right_Click(object sender, EventArgs e) // Clear right list
        {
            listbox_right.Items.Clear();
        }

        private void del_Click(object sender, EventArgs e)  // Удалить button
        {
            if (listbox_left.Items.Count >= 1 | listbox_right.Items.Count >= 1) // If in some list there are items
            {
                listbox_left.Items.Remove(listbox_left.SelectedItem); // Remove selected item from left list
                listbox_right.Items.Remove(listbox_right.SelectedItem); // Remove selected item from right list
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Списки пусты");
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            for (int i = listbox_right.Items.Count - 1; i >= 0; i--)
            {
                if (listbox_right.GetSelected(i)) listbox_right.Items.RemoveAt(i);
            }
            for (int i = listbox_insearch.Items.Count - 1; i >= 0; i--)
            {
                if (listbox_insearch.GetSelected(i)) listbox_insearch.Items.RemoveAt(i);
            }

        }

        private void choose_all_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MoveListBoxItems(ListBox source, ListBox destination) // Move items per lists func
        {
            ListBox.SelectedObjectCollection sourceItems = source.SelectedItems;
            listbox_left.SelectionMode = SelectionMode.MultiExtended; // Multi selecting
            listbox_right.SelectionMode = SelectionMode.MultiExtended; // Multi selecting
            foreach (var item in sourceItems)
            {
                destination.Items.Add(item);
            }
            while (source.SelectedItems.Count > 0)
            {
                source.Items.Remove(source.SelectedItems[0]);
            }
        }

        private void to_right_Click(object sender, EventArgs e) // Move selected item to right
        {
            MoveListBoxItems(listbox_left, listbox_right);
        }

        private void to_left_Click(object sender, EventArgs e) // Move selected item to left
        {
            MoveListBoxItems(listbox_right, listbox_left);
        }

        private void to_right_all_Click(object sender, EventArgs e) // Move all items to right
        {
            for (int i = 0; i < listbox_left.Items.Count; i++)
            {
                listbox_right.Items.Add(listbox_left.Items[i].ToString());
            }
            listbox_left.Items.Clear();
        }

        private void to_left_all_Click(object sender, EventArgs e) // Move all items to left
        {
            for (int i = 0; i < listbox_right.Items.Count; i++)
            {
                listbox_left.Items.Add(listbox_right.Items[i].ToString());
            }
            listbox_right.Items.Clear();
        }

        private void listbox_left_SelectedIndexChanged(object sender, EventArgs e)
        {
            listbox_left.SelectionMode = SelectionMode.MultiExtended; // Multi selecting
        }

        private void listbox_right_SelectedIndexChanged(object sender, EventArgs e)
        {
            listbox_right.SelectionMode = SelectionMode.MultiExtended; // Multi selecting
        }

        private void Sorting(object sender, EventArgs e, ListBox source, ListBox destination)
        {
            if combobox_left.('По алфавиту'){
                ArrayList list = new ArrayList();


                foreach (object o in source.Items)
                {
                    list.Add(o);
                }
                list.Reverse();
                list.Sort();
                source.Items.Clear();
                foreach (object o in list)
                {
                    source.Items.Add(o);
                }
            }
        }

        private void sort_left_Click(object sender, EventArgs e) // Sort in left list
        {
        }
    }
}
