﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Week12 {
    public partial class Week12Form : Form {
        public Week12Form() {
            InitializeComponent();
        }

        private void checkedListShowBtn_Click(object sender, EventArgs e) {
            if (checkedListBox.CheckedItems.Count == 0) {
                MessageBox.Show("no item checked!");
                return;
            }

            var str = "checked item : ";
            foreach (var item in checkedListBox.CheckedItems) {
                str += item.ToString() + " ";
            }

            MessageBox.Show(str);
        }
    }
}
