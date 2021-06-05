using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Week10 {
    public partial class Week10Form : Form {
        public Week10Form() {
            InitializeComponent();
        }

        private void Week10Form_Load(object sender, EventArgs e) {
            MessageBox.Show("Form Loaded!");

            TestButton.Text = "Form Loaded!";
            TestButton.Enabled = false;
        }

        private void Week10Form_FormClosed(object sender, FormClosedEventArgs e) {
            MessageBox.Show("Form Closed!");
        }
    }
}
