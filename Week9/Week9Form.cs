using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week9 {
    public partial class Week9Form : Form {
        private DateTime _startDateTime;
        private DateTime startDateTime => _startDateTime;

        public Week9Form() {
            InitializeComponent();

            _startDateTime = DateTime.Now;
        }

        private void TestButtonClick(object sender, EventArgs e) {
            MessageBox.Show(startDateTime.ToString());
        }
    }
}
