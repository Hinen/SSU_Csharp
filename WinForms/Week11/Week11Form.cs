using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Week11 {
    public partial class Week11Form : Form {
        public Week11Form() {
            InitializeComponent();
        }

        private void RefreshCheckBoxLabel(CheckBox checkBox) {
            var text = checkBox.Text;

            if (checkBox.Checked)
                checkBoxLabel.Text += " " + text;
            else {
                var idx = checkBoxLabel.Text.IndexOf(text) - 1;

                checkBoxLabel.Text = checkBoxLabel.Text.Remove(idx, text.Length + 1);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            RefreshCheckBoxLabel(checkBox1);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            RefreshCheckBoxLabel(checkBox2);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) {
            RefreshCheckBoxLabel(checkBox3);
        }
    }
}
