namespace WinForms.Week13 {
    partial class Week13Form {
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
            this.clientPosLabel = new System.Windows.Forms.Label();
            this.posLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clientPosLabel
            // 
            this.clientPosLabel.AutoSize = true;
            this.clientPosLabel.Location = new System.Drawing.Point(12, 58);
            this.clientPosLabel.Name = "clientPosLabel";
            this.clientPosLabel.Size = new System.Drawing.Size(91, 12);
            this.clientPosLabel.TabIndex = 0;
            this.clientPosLabel.Text = "client pos label";
            // 
            // posLabel
            // 
            this.posLabel.AutoSize = true;
            this.posLabel.Location = new System.Drawing.Point(12, 21);
            this.posLabel.Name = "posLabel";
            this.posLabel.Size = new System.Drawing.Size(57, 12);
            this.posLabel.TabIndex = 1;
            this.posLabel.Text = "pos label";
            // 
            // Week13Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 557);
            this.Controls.Add(this.posLabel);
            this.Controls.Add(this.clientPosLabel);
            this.Name = "Week13Form";
            this.Text = "Week13Form";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Week13Form_MouseClick);
            this.MouseEnter += new System.EventHandler(this.Week13Form_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Week13Form_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Week13Form_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientPosLabel;
        private System.Windows.Forms.Label posLabel;
    }
}