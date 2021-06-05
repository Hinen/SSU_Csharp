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
    public partial class PopupOneBtn : Form {
        public PopupOneBtn() {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
