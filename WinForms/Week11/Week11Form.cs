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

        //
        private void RefreshRadioButtonLabel(RadioButton radioButton) {
            var text = radioButton.Text;

            if (radioButton.Checked)
                radioButtonLabel.Text += " " + text;
            else {
                var idx = radioButtonLabel.Text.IndexOf(text) - 1;

                radioButtonLabel.Text = radioButtonLabel.Text.Remove(idx, text.Length + 1);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            RefreshRadioButtonLabel(radioButton1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            RefreshRadioButtonLabel(radioButton2);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) {
            RefreshRadioButtonLabel(radioButton3);
        }

        //
        private void listBoxAddButton_Click(object sender, EventArgs e) {
            listBox.Items.Add("Item" + (listBox.Items.Count + 1));
        }

        private void listBoxRemoveButton_Click(object sender, EventArgs e) {
            if (listBox.SelectedIndex == -1)
                return;

            if (listBox.SelectedIndex >= listBox.Items.Count)
                return;

            listBox.Items.RemoveAt(listBox.SelectedIndex);
        }

        //
        private void comboToListBtn_Click(object sender, EventArgs e) {
            if (comboBox.SelectedItem == null)
                return;

            listBox2.Items.Add(comboBox.SelectedItem);
            comboBox.Items.Remove(comboBox.SelectedItem);
            comboBox.Text = "";
        }

        private void listToComboBtn_Click(object sender, EventArgs e) {
            if (listBox2.SelectedIndex == -1)
                return;

            if (listBox2.SelectedIndex >= listBox2.Items.Count)
                return;

            var item = listBox2.Items[listBox2.SelectedIndex];

            comboBox.Items.Add(item);
            listBox2.Items.Remove(item);
        }
    }
}
