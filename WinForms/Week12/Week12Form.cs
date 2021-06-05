using System;
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

        //
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

        //
        private void modalButton_Click(object sender, EventArgs e) {
            var popup = new PopupOneBtn();
            popup.ShowDialog();
        }

        private void modalessButton_Click(object sender, EventArgs e) {
            var popup = new PopupOneBtn();
            popup.Show();
        }

        //
        private void messageBoxBtn1_Click(object sender, EventArgs e) {
            var result = MessageBox.Show(
                "test1 desc", 
                "test1 title",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);

            if (result == DialogResult.OK)
                MessageBox.Show("OK!");
        }

        private void messageBoxBtn2_Click(object sender, EventArgs e) {
            var result = MessageBox.Show(
                "test1 desc",
                "test1 title",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Error);

            if (result == DialogResult.Retry)
                MessageBox.Show("Retry!");
        }

        private void messageBoxBtn3_Click(object sender, EventArgs e) {
            var result = MessageBox.Show(
                "test1 desc",
                "test1 title",
                MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Abort)
                MessageBox.Show("Abort!");
            else if (result == DialogResult.Retry)
                MessageBox.Show("Retry!");
        }

        //
        private void findFileButton_Click(object sender, EventArgs e) {
            openFileDialog.FileName = "";
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Multiselect = false;
            openFileDialog.ShowDialog();

            fileNameLabel.Text = string.IsNullOrEmpty(openFileDialog.SafeFileName) 
                ? "not select file" 
                : openFileDialog.SafeFileName;
        }

        //
        private void fontBtn_Click(object sender, EventArgs e) {
            fontDialog.ShowDialog();

            fontLabel.Font = fontDialog.Font;
            fontLabel.ForeColor = fontDialog.Color;
        }

        //
        private void colorBtn_Click(object sender, EventArgs e) {
            colorDialog.ShowDialog();

            colorLabel.ForeColor = colorDialog.Color;
        }
    }
}
