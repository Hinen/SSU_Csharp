namespace WinForms.Week12 {
    partial class Week12Form {
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
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.checkedListShowBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "item1",
            "item2",
            "item3",
            "item4",
            "item5",
            "item6"});
            this.checkedListBox.Location = new System.Drawing.Point(17, 22);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(108, 52);
            this.checkedListBox.TabIndex = 0;
            // 
            // checkedListShowBtn
            // 
            this.checkedListShowBtn.Location = new System.Drawing.Point(17, 80);
            this.checkedListShowBtn.Name = "checkedListShowBtn";
            this.checkedListShowBtn.Size = new System.Drawing.Size(108, 41);
            this.checkedListShowBtn.TabIndex = 1;
            this.checkedListShowBtn.Text = "Show";
            this.checkedListShowBtn.UseVisualStyleBackColor = true;
            this.checkedListShowBtn.Click += new System.EventHandler(this.checkedListShowBtn_Click);
            // 
            // Week12Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 657);
            this.Controls.Add(this.checkedListShowBtn);
            this.Controls.Add(this.checkedListBox);
            this.Name = "Week12Form";
            this.Text = "Week12Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button checkedListShowBtn;
    }
}