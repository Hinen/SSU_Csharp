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
            this.focusButton1 = new System.Windows.Forms.Button();
            this.focusButton2 = new System.Windows.Forms.Button();
            this.keyCodeLabel = new System.Windows.Forms.Label();
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
            // focusButton1
            // 
            this.focusButton1.Location = new System.Drawing.Point(170, 12);
            this.focusButton1.Name = "focusButton1";
            this.focusButton1.Size = new System.Drawing.Size(128, 41);
            this.focusButton1.TabIndex = 2;
            this.focusButton1.Text = "focus1";
            this.focusButton1.UseVisualStyleBackColor = true;
            this.focusButton1.Click += new System.EventHandler(this.focusButton1_Click);
            // 
            // focusButton2
            // 
            this.focusButton2.Location = new System.Drawing.Point(304, 12);
            this.focusButton2.Name = "focusButton2";
            this.focusButton2.Size = new System.Drawing.Size(128, 41);
            this.focusButton2.TabIndex = 3;
            this.focusButton2.Text = "focus2";
            this.focusButton2.UseVisualStyleBackColor = true;
            this.focusButton2.Click += new System.EventHandler(this.focusButton2_Click);
            // 
            // keyCodeLabel
            // 
            this.keyCodeLabel.AutoSize = true;
            this.keyCodeLabel.Location = new System.Drawing.Point(249, 253);
            this.keyCodeLabel.Name = "keyCodeLabel";
            this.keyCodeLabel.Size = new System.Drawing.Size(94, 12);
            this.keyCodeLabel.TabIndex = 4;
            this.keyCodeLabel.Text = "key Code Label";
            // 
            // Week13Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 557);
            this.Controls.Add(this.keyCodeLabel);
            this.Controls.Add(this.focusButton2);
            this.Controls.Add(this.focusButton1);
            this.Controls.Add(this.posLabel);
            this.Controls.Add(this.clientPosLabel);
            this.Name = "Week13Form";
            this.Text = "Week13Form";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Week13Form_KeyDown);
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
        private System.Windows.Forms.Button focusButton1;
        private System.Windows.Forms.Button focusButton2;
        private System.Windows.Forms.Label keyCodeLabel;
    }
}