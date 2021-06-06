using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Week13 {
    public partial class Week13Form : Form {
        public Week13Form() {
            InitializeComponent();
        }

        //
        private void Week13Form_MouseEnter(object sender, EventArgs e) {
            posLabel.Visible = true;
            clientPosLabel.Visible = true;
        }

        private void Week13Form_MouseLeave(object sender, EventArgs e) {
            posLabel.Visible = false;
            clientPosLabel.Visible = false;
        }

        private void Week13Form_MouseMove(object sender, MouseEventArgs e) {
            var pos = new Point(e.X, e.Y);
            var clientPos = PointToClient(pos);

            posLabel.Text = pos.ToString();
            clientPosLabel.Text = clientPos.ToString();
        }

        private void Week13Form_MouseClick(object sender, MouseEventArgs e) {
            //MessageBox.Show("Mouse Clicked!");
            focusButton1.Enabled = !focusButton1.Enabled;
            focusButton2.Enabled = !focusButton2.Enabled;
        }

        //
        private void focusButton1_Click(object sender, EventArgs e) {
            focusButton2.Focus();
        }

        private void focusButton2_Click(object sender, EventArgs e) {
            focusButton1.Focus();
        }

        //
        private void Week13Form_KeyDown(object sender, KeyEventArgs e) {
            var speed = 5;

            if (e.KeyCode == Keys.Up)
                keyCodeLabel.Location = new Point(keyCodeLabel.Location.X, keyCodeLabel.Location.Y - speed);

            if (e.KeyCode == Keys.Down)
                keyCodeLabel.Location = new Point(keyCodeLabel.Location.X, keyCodeLabel.Location.Y + speed);

            if (e.KeyCode == Keys.Left)
                keyCodeLabel.Location = new Point(keyCodeLabel.Location.X - speed, keyCodeLabel.Location.Y);

            if (e.KeyCode == Keys.Right)
                keyCodeLabel.Location = new Point(keyCodeLabel.Location.X + speed, keyCodeLabel.Location.Y);
        }
    }
}
