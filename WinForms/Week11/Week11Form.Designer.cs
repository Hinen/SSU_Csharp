namespace WinForms.Week11 {
    partial class Week11Form {
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBoxLabel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButtonLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.multiLineBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.listBoxAddButton = new System.Windows.Forms.Button();
            this.listBoxRemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 34);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(86, 16);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 56);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(86, 16);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBoxLabel
            // 
            this.checkBoxLabel.AutoSize = true;
            this.checkBoxLabel.Location = new System.Drawing.Point(10, 85);
            this.checkBoxLabel.Name = "checkBoxLabel";
            this.checkBoxLabel.Size = new System.Drawing.Size(92, 12);
            this.checkBoxLabel.TabIndex = 3;
            this.checkBoxLabel.Text = "checkBoxLabel";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(201, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 16);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(201, 33);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 16);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(201, 55);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(92, 16);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButtonLabel
            // 
            this.radioButtonLabel.AutoSize = true;
            this.radioButtonLabel.Location = new System.Drawing.Point(199, 85);
            this.radioButtonLabel.Name = "radioButtonLabel";
            this.radioButtonLabel.Size = new System.Drawing.Size(99, 12);
            this.radioButtonLabel.TabIndex = 7;
            this.radioButtonLabel.Text = "radioButtonLabel";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 209);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(238, 21);
            this.textBox.TabIndex = 8;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(12, 236);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(238, 21);
            this.passwordBox.TabIndex = 9;
            // 
            // multiLineBox
            // 
            this.multiLineBox.Location = new System.Drawing.Point(12, 263);
            this.multiLineBox.Multiline = true;
            this.multiLineBox.Name = "multiLineBox";
            this.multiLineBox.Size = new System.Drawing.Size(238, 100);
            this.multiLineBox.TabIndex = 10;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(289, 209);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(108, 112);
            this.listBox.TabIndex = 11;
            // 
            // listBoxAddButton
            // 
            this.listBoxAddButton.Location = new System.Drawing.Point(403, 209);
            this.listBoxAddButton.Name = "listBoxAddButton";
            this.listBoxAddButton.Size = new System.Drawing.Size(92, 47);
            this.listBoxAddButton.TabIndex = 12;
            this.listBoxAddButton.Text = "Add";
            this.listBoxAddButton.UseVisualStyleBackColor = true;
            this.listBoxAddButton.Click += new System.EventHandler(this.listBoxAddButton_Click);
            // 
            // listBoxRemoveButton
            // 
            this.listBoxRemoveButton.Location = new System.Drawing.Point(403, 263);
            this.listBoxRemoveButton.Name = "listBoxRemoveButton";
            this.listBoxRemoveButton.Size = new System.Drawing.Size(92, 47);
            this.listBoxRemoveButton.TabIndex = 13;
            this.listBoxRemoveButton.Text = "Remove";
            this.listBoxRemoveButton.UseVisualStyleBackColor = true;
            this.listBoxRemoveButton.Click += new System.EventHandler(this.listBoxRemoveButton_Click);
            // 
            // Week11Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 538);
            this.Controls.Add(this.listBoxRemoveButton);
            this.Controls.Add(this.listBoxAddButton);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.multiLineBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.radioButtonLabel);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBoxLabel);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Week11Form";
            this.Text = "Week11Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label checkBoxLabel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label radioButtonLabel;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox multiLineBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button listBoxAddButton;
        private System.Windows.Forms.Button listBoxRemoveButton;
    }
}