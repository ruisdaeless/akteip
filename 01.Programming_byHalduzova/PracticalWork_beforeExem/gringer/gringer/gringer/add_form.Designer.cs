
namespace gringer
{
    partial class add_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.titile = new System.Windows.Forms.Label();
            this.groupbox_addto = new System.Windows.Forms.GroupBox();
            this.addto_section2 = new System.Windows.Forms.RadioButton();
            this.addto_section1 = new System.Windows.Forms.RadioButton();
            this.write_text = new System.Windows.Forms.Label();
            this.input_filed = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupbox_addto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(91)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.titile);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 35);
            this.panel1.TabIndex = 0;
            // 
            // titile
            // 
            this.titile.AutoSize = true;
            this.titile.Location = new System.Drawing.Point(69, 9);
            this.titile.Name = "titile";
            this.titile.Size = new System.Drawing.Size(115, 15);
            this.titile.TabIndex = 0;
            this.titile.Text = "Добавление записи";
            // 
            // groupbox_addto
            // 
            this.groupbox_addto.Controls.Add(this.addto_section2);
            this.groupbox_addto.Controls.Add(this.addto_section1);
            this.groupbox_addto.Location = new System.Drawing.Point(13, 42);
            this.groupbox_addto.Name = "groupbox_addto";
            this.groupbox_addto.Size = new System.Drawing.Size(228, 84);
            this.groupbox_addto.TabIndex = 1;
            this.groupbox_addto.TabStop = false;
            this.groupbox_addto.Text = "Добавить в";
            // 
            // addto_section2
            // 
            this.addto_section2.AutoSize = true;
            this.addto_section2.Location = new System.Drawing.Point(7, 49);
            this.addto_section2.Name = "addto_section2";
            this.addto_section2.Size = new System.Drawing.Size(71, 19);
            this.addto_section2.TabIndex = 1;
            this.addto_section2.TabStop = true;
            this.addto_section2.Text = "Раздел 2";
            this.addto_section2.UseVisualStyleBackColor = true;
            // 
            // addto_section1
            // 
            this.addto_section1.AutoSize = true;
            this.addto_section1.Location = new System.Drawing.Point(7, 23);
            this.addto_section1.Name = "addto_section1";
            this.addto_section1.Size = new System.Drawing.Size(71, 19);
            this.addto_section1.TabIndex = 0;
            this.addto_section1.TabStop = true;
            this.addto_section1.Text = "Раздел 1";
            this.addto_section1.UseVisualStyleBackColor = true;
            // 
            // write_text
            // 
            this.write_text.AutoSize = true;
            this.write_text.Location = new System.Drawing.Point(13, 136);
            this.write_text.Name = "write_text";
            this.write_text.Size = new System.Drawing.Size(81, 15);
            this.write_text.TabIndex = 2;
            this.write_text.Text = "Введите текст";
            // 
            // input_filed
            // 
            this.input_filed.Location = new System.Drawing.Point(13, 155);
            this.input_filed.Name = "input_filed";
            this.input_filed.Size = new System.Drawing.Size(228, 23);
            this.input_filed.TabIndex = 3;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(13, 184);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 25);
            this.add.TabIndex = 4;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(141, 184);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 25);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // add_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(195)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(253, 225);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.add);
            this.Controls.Add(this.input_filed);
            this.Controls.Add(this.write_text);
            this.Controls.Add(this.groupbox_addto);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupbox_addto.ResumeLayout(false);
            this.groupbox_addto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titile;
        private System.Windows.Forms.GroupBox groupbox_addto;
        private System.Windows.Forms.RadioButton addto_section2;
        private System.Windows.Forms.RadioButton addto_section1;
        private System.Windows.Forms.Label write_text;
        private System.Windows.Forms.TextBox input_filed;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button cancel;
    }
}