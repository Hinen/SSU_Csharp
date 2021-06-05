namespace WinForms.Week10 {
    partial class Week10Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.TestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestButton
            // 
            this.TestButton.ForeColor = System.Drawing.Color.Coral;
            this.TestButton.Location = new System.Drawing.Point(199, 170);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(218, 88);
            this.TestButton.TabIndex = 0;
            this.TestButton.Text = "Test Button Text";
            this.TestButton.UseVisualStyleBackColor = true;
            // 
            // Week10Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 551);
            this.Controls.Add(this.TestButton);
            this.Name = "Week10Form";
            this.Text = "Week10Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Week10Form_FormClosed);
            this.Load += new System.EventHandler(this.Week10Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TestButton;
    }
}