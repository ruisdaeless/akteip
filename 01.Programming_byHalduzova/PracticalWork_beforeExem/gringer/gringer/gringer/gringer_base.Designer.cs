
namespace gringer
{
    partial class gringer_base
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Panel up_panel;
            this.close = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.left_panel = new System.Windows.Forms.Panel();
            this.clear_right = new System.Windows.Forms.Button();
            this.sort_right = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.clear_left = new System.Windows.Forms.Button();
            this.sort_left = new System.Windows.Forms.Button();
            this.section_2 = new System.Windows.Forms.Label();
            this.section_1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.choose_emails = new System.Windows.Forms.RadioButton();
            this.choose_numbers = new System.Windows.Forms.RadioButton();
            this.choose_all = new System.Windows.Forms.RadioButton();
            this.search = new System.Windows.Forms.GroupBox();
            this.checkbox_insection2 = new System.Windows.Forms.CheckBox();
            this.checkbox_insection1 = new System.Windows.Forms.CheckBox();
            this.button_search = new System.Windows.Forms.Button();
            this.listbox_insearch = new System.Windows.Forms.ListBox();
            this.write_looking_word = new System.Windows.Forms.Label();
            this.textboxt_insearch = new System.Windows.Forms.TextBox();
            this.listbox_right = new System.Windows.Forms.ListBox();
            this.listbox_left = new System.Windows.Forms.ListBox();
            this.panel_center = new System.Windows.Forms.Panel();
            this.del = new System.Windows.Forms.Button();
            this.to_left_all = new System.Windows.Forms.Button();
            this.to_left = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.to_right_all = new System.Windows.Forms.Button();
            this.to_right = new System.Windows.Forms.Button();
            this.combobox_right = new System.Windows.Forms.ComboBox();
            this.combobox_left = new System.Windows.Forms.ComboBox();
            this.right_text_panel = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            up_panel = new System.Windows.Forms.Panel();
            up_panel.SuspendLayout();
            this.left_panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.search.SuspendLayout();
            this.panel_center.SuspendLayout();
            this.SuspendLayout();
            // 
            // up_panel
            // 
            up_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(91)))), ((int)(((byte)(123)))));
            up_panel.Controls.Add(this.close);
            up_panel.Controls.Add(this.help);
            up_panel.Controls.Add(this.save);
            up_panel.Controls.Add(this.open);
            up_panel.Location = new System.Drawing.Point(0, 0);
            up_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            up_panel.Name = "up_panel";
            up_panel.Size = new System.Drawing.Size(1000, 35);
            up_panel.TabIndex = 0;
            // 
            // close
            // 
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Location = new System.Drawing.Point(913, 7);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 1;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // help
            // 
            this.help.Cursor = System.Windows.Forms.Cursors.Default;
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help.Location = new System.Drawing.Point(174, 7);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(75, 23);
            this.help.TabIndex = 0;
            this.help.Text = "Справка";
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(91)))), ((int)(((byte)(123)))));
            this.save.Cursor = System.Windows.Forms.Cursors.Default;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Location = new System.Drawing.Point(93, 7);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 0;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // open
            // 
            this.open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(91)))), ((int)(((byte)(123)))));
            this.open.Cursor = System.Windows.Forms.Cursors.Default;
            this.open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open.Location = new System.Drawing.Point(12, 7);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 0;
            this.open.Text = "Открыть";
            this.open.UseVisualStyleBackColor = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // left_panel
            // 
            this.left_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.left_panel.Controls.Add(this.clear_right);
            this.left_panel.Controls.Add(this.sort_right);
            this.left_panel.Controls.Add(this.start);
            this.left_panel.Controls.Add(this.clear);
            this.left_panel.Controls.Add(this.clear_left);
            this.left_panel.Controls.Add(this.sort_left);
            this.left_panel.Controls.Add(this.section_2);
            this.left_panel.Controls.Add(this.section_1);
            this.left_panel.Controls.Add(this.groupBox1);
            this.left_panel.Controls.Add(this.search);
            this.left_panel.Controls.Add(this.listbox_right);
            this.left_panel.Controls.Add(this.listbox_left);
            this.left_panel.Controls.Add(this.panel_center);
            this.left_panel.Controls.Add(this.combobox_right);
            this.left_panel.Controls.Add(this.combobox_left);
            this.left_panel.Location = new System.Drawing.Point(10, 50);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(675, 680);
            this.left_panel.TabIndex = 1;
            // 
            // clear_right
            // 
            this.clear_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.clear_right.Location = new System.Drawing.Point(550, 345);
            this.clear_right.Name = "clear_right";
            this.clear_right.Size = new System.Drawing.Size(110, 30);
            this.clear_right.TabIndex = 0;
            this.clear_right.Text = "Очистить";
            this.clear_right.UseVisualStyleBackColor = false;
            this.clear_right.Click += new System.EventHandler(this.sorgt_right_Click);
            // 
            // sort_right
            // 
            this.sort_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.sort_right.Location = new System.Drawing.Point(430, 345);
            this.sort_right.Name = "sort_right";
            this.sort_right.Size = new System.Drawing.Size(110, 30);
            this.sort_right.TabIndex = 0;
            this.sort_right.Text = "Сортировать";
            this.sort_right.UseVisualStyleBackColor = false;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.start.Location = new System.Drawing.Point(381, 516);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(272, 69);
            this.start.TabIndex = 0;
            this.start.Text = "Начать";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.clear.Location = new System.Drawing.Point(381, 591);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(272, 45);
            this.clear.TabIndex = 0;
            this.clear.Text = "Сброс";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // clear_left
            // 
            this.clear_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.clear_left.Location = new System.Drawing.Point(135, 345);
            this.clear_left.Name = "clear_left";
            this.clear_left.Size = new System.Drawing.Size(110, 30);
            this.clear_left.TabIndex = 0;
            this.clear_left.Text = "Очистить";
            this.clear_left.UseVisualStyleBackColor = false;
            this.clear_left.Click += new System.EventHandler(this.clear_left_Click);
            // 
            // sort_left
            // 
            this.sort_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.sort_left.Location = new System.Drawing.Point(14, 345);
            this.sort_left.Name = "sort_left";
            this.sort_left.Size = new System.Drawing.Size(110, 30);
            this.sort_left.TabIndex = 0;
            this.sort_left.Text = "Сортировать";
            this.sort_left.UseVisualStyleBackColor = false;
            this.sort_left.Click += new System.EventHandler(this.sort_left_Click);
            // 
            // section_2
            // 
            this.section_2.AutoSize = true;
            this.section_2.Location = new System.Drawing.Point(430, 27);
            this.section_2.Name = "section_2";
            this.section_2.Size = new System.Drawing.Size(53, 15);
            this.section_2.TabIndex = 5;
            this.section_2.Text = "Раздел 2";
            // 
            // section_1
            // 
            this.section_1.AutoSize = true;
            this.section_1.Location = new System.Drawing.Point(15, 27);
            this.section_1.Name = "section_1";
            this.section_1.Size = new System.Drawing.Size(53, 15);
            this.section_1.TabIndex = 5;
            this.section_1.Text = "Раздел 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.choose_emails);
            this.groupBox1.Controls.Add(this.choose_numbers);
            this.groupBox1.Controls.Add(this.choose_all);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(375, 399);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 263);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор слов";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // choose_emails
            // 
            this.choose_emails.AutoSize = true;
            this.choose_emails.Location = new System.Drawing.Point(6, 80);
            this.choose_emails.Name = "choose_emails";
            this.choose_emails.Size = new System.Drawing.Size(135, 19);
            this.choose_emails.TabIndex = 0;
            this.choose_emails.TabStop = true;
            this.choose_emails.Text = "Содержащие e-mail";
            this.choose_emails.UseVisualStyleBackColor = true;
            // 
            // choose_numbers
            // 
            this.choose_numbers.AutoSize = true;
            this.choose_numbers.Location = new System.Drawing.Point(6, 55);
            this.choose_numbers.Name = "choose_numbers";
            this.choose_numbers.Size = new System.Drawing.Size(140, 19);
            this.choose_numbers.TabIndex = 0;
            this.choose_numbers.TabStop = true;
            this.choose_numbers.Text = "Содержащие цифры";
            this.choose_numbers.UseVisualStyleBackColor = true;
            // 
            // choose_all
            // 
            this.choose_all.AutoSize = true;
            this.choose_all.Location = new System.Drawing.Point(6, 30);
            this.choose_all.Name = "choose_all";
            this.choose_all.Size = new System.Drawing.Size(44, 19);
            this.choose_all.TabIndex = 0;
            this.choose_all.TabStop = true;
            this.choose_all.Text = "Все";
            this.choose_all.UseVisualStyleBackColor = true;
            this.choose_all.CheckedChanged += new System.EventHandler(this.choose_all_CheckedChanged);
            // 
            // search
            // 
            this.search.Controls.Add(this.checkbox_insection2);
            this.search.Controls.Add(this.checkbox_insection1);
            this.search.Controls.Add(this.button_search);
            this.search.Controls.Add(this.listbox_insearch);
            this.search.Controls.Add(this.write_looking_word);
            this.search.Controls.Add(this.textboxt_insearch);
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Location = new System.Drawing.Point(15, 399);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(284, 263);
            this.search.TabIndex = 4;
            this.search.TabStop = false;
            this.search.Text = "Поиск";
            this.search.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkbox_insection2
            // 
            this.checkbox_insection2.AutoSize = true;
            this.checkbox_insection2.Location = new System.Drawing.Point(16, 218);
            this.checkbox_insection2.Name = "checkbox_insection2";
            this.checkbox_insection2.Size = new System.Drawing.Size(72, 19);
            this.checkbox_insection2.TabIndex = 3;
            this.checkbox_insection2.Text = "Раздел 2";
            this.checkbox_insection2.UseVisualStyleBackColor = true;
            // 
            // checkbox_insection1
            // 
            this.checkbox_insection1.AutoSize = true;
            this.checkbox_insection1.Location = new System.Drawing.Point(16, 193);
            this.checkbox_insection1.Name = "checkbox_insection1";
            this.checkbox_insection1.Size = new System.Drawing.Size(72, 19);
            this.checkbox_insection1.TabIndex = 3;
            this.checkbox_insection1.Text = "Раздел 1";
            this.checkbox_insection1.UseVisualStyleBackColor = true;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.button_search.Location = new System.Drawing.Point(156, 192);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(110, 45);
            this.button_search.TabIndex = 0;
            this.button_search.Text = "Поиск";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // listbox_insearch
            // 
            this.listbox_insearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.listbox_insearch.FormattingEnabled = true;
            this.listbox_insearch.ItemHeight = 15;
            this.listbox_insearch.Location = new System.Drawing.Point(16, 77);
            this.listbox_insearch.Name = "listbox_insearch";
            this.listbox_insearch.Size = new System.Drawing.Size(250, 109);
            this.listbox_insearch.TabIndex = 2;
            // 
            // write_looking_word
            // 
            this.write_looking_word.AutoSize = true;
            this.write_looking_word.Location = new System.Drawing.Point(16, 30);
            this.write_looking_word.Name = "write_looking_word";
            this.write_looking_word.Size = new System.Drawing.Size(137, 15);
            this.write_looking_word.TabIndex = 1;
            this.write_looking_word.Text = "Введите искомое слово";
            // 
            // textboxt_insearch
            // 
            this.textboxt_insearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.textboxt_insearch.Location = new System.Drawing.Point(16, 48);
            this.textboxt_insearch.Name = "textboxt_insearch";
            this.textboxt_insearch.Size = new System.Drawing.Size(250, 23);
            this.textboxt_insearch.TabIndex = 0;
            // 
            // listbox_right
            // 
            this.listbox_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.listbox_right.FormattingEnabled = true;
            this.listbox_right.ItemHeight = 15;
            this.listbox_right.Location = new System.Drawing.Point(430, 80);
            this.listbox_right.Name = "listbox_right";
            this.listbox_right.Size = new System.Drawing.Size(230, 259);
            this.listbox_right.TabIndex = 3;
            this.listbox_right.SelectedIndexChanged += new System.EventHandler(this.listbox_right_SelectedIndexChanged);
            // 
            // listbox_left
            // 
            this.listbox_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.listbox_left.FormattingEnabled = true;
            this.listbox_left.ItemHeight = 15;
            this.listbox_left.Location = new System.Drawing.Point(15, 80);
            this.listbox_left.Name = "listbox_left";
            this.listbox_left.Size = new System.Drawing.Size(230, 259);
            this.listbox_left.TabIndex = 2;
            this.listbox_left.SelectedIndexChanged += new System.EventHandler(this.listbox_left_SelectedIndexChanged);
            // 
            // panel_center
            // 
            this.panel_center.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_center.Controls.Add(this.del);
            this.panel_center.Controls.Add(this.to_left_all);
            this.panel_center.Controls.Add(this.to_left);
            this.panel_center.Controls.Add(this.add);
            this.panel_center.Controls.Add(this.to_right_all);
            this.panel_center.Controls.Add(this.to_right);
            this.panel_center.Location = new System.Drawing.Point(261, 48);
            this.panel_center.Name = "panel_center";
            this.panel_center.Size = new System.Drawing.Size(147, 291);
            this.panel_center.TabIndex = 1;
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.del.Location = new System.Drawing.Point(9, 253);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(125, 30);
            this.del.TabIndex = 0;
            this.del.Text = "Удалить";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // to_left_all
            // 
            this.to_left_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.to_left_all.Location = new System.Drawing.Point(9, 118);
            this.to_left_all.Name = "to_left_all";
            this.to_left_all.Size = new System.Drawing.Size(125, 30);
            this.to_left_all.TabIndex = 0;
            this.to_left_all.Text = "<<";
            this.to_left_all.UseVisualStyleBackColor = false;
            this.to_left_all.Click += new System.EventHandler(this.to_left_all_Click);
            // 
            // to_left
            // 
            this.to_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.to_left.Location = new System.Drawing.Point(9, 46);
            this.to_left.Name = "to_left";
            this.to_left.Size = new System.Drawing.Size(125, 30);
            this.to_left.TabIndex = 0;
            this.to_left.Text = "<";
            this.to_left.UseVisualStyleBackColor = false;
            this.to_left.Click += new System.EventHandler(this.to_left_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.add.Location = new System.Drawing.Point(9, 217);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(125, 30);
            this.add.TabIndex = 0;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // to_right_all
            // 
            this.to_right_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.to_right_all.Location = new System.Drawing.Point(9, 82);
            this.to_right_all.Name = "to_right_all";
            this.to_right_all.Size = new System.Drawing.Size(125, 30);
            this.to_right_all.TabIndex = 0;
            this.to_right_all.Text = ">>";
            this.to_right_all.UseVisualStyleBackColor = false;
            this.to_right_all.Click += new System.EventHandler(this.to_right_all_Click);
            // 
            // to_right
            // 
            this.to_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.to_right.Location = new System.Drawing.Point(9, 10);
            this.to_right.Name = "to_right";
            this.to_right.Size = new System.Drawing.Size(125, 30);
            this.to_right.TabIndex = 0;
            this.to_right.Text = ">";
            this.to_right.UseVisualStyleBackColor = false;
            this.to_right.Click += new System.EventHandler(this.to_right_Click);
            // 
            // combobox_right
            // 
            this.combobox_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.combobox_right.FormattingEnabled = true;
            this.combobox_right.Items.AddRange(new object[] {
            "Алфавиту (по возрастанию)",
            "Алфавиту (по убыванию)",
            "Количеству букв (по возрастанию)",
            "Количеству букв (по убыванию)"});
            this.combobox_right.Location = new System.Drawing.Point(430, 48);
            this.combobox_right.Name = "combobox_right";
            this.combobox_right.Size = new System.Drawing.Size(230, 23);
            this.combobox_right.TabIndex = 0;
            this.combobox_right.Text = "Сортировать по...";
            // 
            // combobox_left
            // 
            this.combobox_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.combobox_left.FormattingEnabled = true;
            this.combobox_left.Items.AddRange(new object[] {
            "Алфавиту (по возрастанию)",
            "Алфавиту (по убыванию)",
            "Количеству букв (по возрастанию)",
            "Количеству букв (по убыванию)"});
            this.combobox_left.Location = new System.Drawing.Point(14, 48);
            this.combobox_left.Name = "combobox_left";
            this.combobox_left.Size = new System.Drawing.Size(231, 23);
            this.combobox_left.TabIndex = 0;
            this.combobox_left.Text = "Сортировать по...";
            // 
            // right_text_panel
            // 
            this.right_text_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.right_text_panel.Location = new System.Drawing.Point(705, 50);
            this.right_text_panel.Multiline = true;
            this.right_text_panel.Name = "right_text_panel";
            this.right_text_panel.Size = new System.Drawing.Size(283, 680);
            this.right_text_panel.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gringer_base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(195)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1000, 740);
            this.Controls.Add(this.right_text_panel);
            this.Controls.Add(this.left_panel);
            this.Controls.Add(up_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "gringer_base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мясорубка";
            this.Load += new System.EventHandler(this.gringer_base_Load_1);
            up_panel.ResumeLayout(false);
            this.left_panel.ResumeLayout(false);
            this.left_panel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.search.ResumeLayout(false);
            this.search.PerformLayout();
            this.panel_center.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel up_panel;
        private System.Windows.Forms.Panel left_panel;
        private System.Windows.Forms.GroupBox search;
        private System.Windows.Forms.ListBox listbox_right;
        private System.Windows.Forms.ListBox listbox_left;
        private System.Windows.Forms.Panel panel_center;
        private System.Windows.Forms.ComboBox combobox_right;
        private System.Windows.Forms.ComboBox combobox_left;
        private System.Windows.Forms.TextBox right_text_panel;
        private System.Windows.Forms.Label section_2;
        private System.Windows.Forms.Label section_1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button to_left_all;
        private System.Windows.Forms.Button to_left;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button to_right_all;
        private System.Windows.Forms.Button to_right;
        private System.Windows.Forms.Button clear_right;
        private System.Windows.Forms.Button sort_right;
        private System.Windows.Forms.Button clear_left;
        private System.Windows.Forms.Button sort_left;
        private System.Windows.Forms.CheckBox checkbox_insection1;
        private System.Windows.Forms.ListBox listbox_insearch;
        private System.Windows.Forms.Label write_looking_word;
        private System.Windows.Forms.TextBox textboxt_insearch;
        private System.Windows.Forms.RadioButton choose_emails;
        private System.Windows.Forms.RadioButton choose_numbers;
        private System.Windows.Forms.RadioButton choose_all;
        private System.Windows.Forms.CheckBox checkbox_insection2;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button close;
    }
}

