using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void flatButton_Click(object sender, EventArgs e) {
            label.Text = FlatStyle.Flat.ToString();
        }

        private void popupButton_Click(object sender, EventArgs e) {
            label.Text = FlatStyle.Popup.ToString();
        }

        private void standardButton_Click(object sender, EventArgs e) {
            label.Text = FlatStyle.Standard.ToString();
        }

        private void systemButton_Click(object sender, EventArgs e) {
            label.Text = FlatStyle.System.ToString();
        }

        private void naverLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // 단순히 이렇게 실행도 가능하나, 최신 브라우저에서는 보안상 실행이 불가능
            //Process.Start(naverLink.Text);

            string url = naverLink.Text;

            var psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = url;

            // 기본 익스플로러가 제대로 설정 되지 않으면, Process Start을 실행 못 시킬 수 있음
            Process.Start(psi);
        }

        private void youtubeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // 단순히 이렇게 실행도 가능하나, 최신 브라우저에서는 보안상 실행이 불가능
            //Process.Start(youtubeLink.Text);

            string url = youtubeLink.Text;

            var psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = url;

            // 기본 익스플로러가 제대로 설정 되지 않으면, Process Start을 실행 못 시킬 수 있음
            Process.Start(psi);
        }
    }
}
