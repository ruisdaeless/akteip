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
    public partial class add_form : Form
    {
        public add_form()
        {
            InitializeComponent();
        }

        public int Section { get; private set; }

        private void add_Click(object sender, EventArgs e)
        {
            add_form dlg = new add_form();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                switch (dlg.Section)
                {
                    // case 1: addto_section1.Items.Add(dlg.input_filed); break;
                    // case 2: addto_section2.Items.Add(dlg.input_filed); break;
                    default: break;
                }
            }
        }
    }
}
