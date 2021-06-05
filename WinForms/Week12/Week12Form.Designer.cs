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
            this.modalButton = new System.Windows.Forms.Button();
            this.modalessButton = new System.Windows.Forms.Button();
            this.messageBoxBtn1 = new System.Windows.Forms.Button();
            this.messageBoxBtn2 = new System.Windows.Forms.Button();
            this.messageBoxBtn3 = new System.Windows.Forms.Button();
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
            // modalButton
            // 
            this.modalButton.Location = new System.Drawing.Point(168, 22);
            this.modalButton.Name = "modalButton";
            this.modalButton.Size = new System.Drawing.Size(161, 48);
            this.modalButton.TabIndex = 2;
            this.modalButton.Text = "Modal";
            this.modalButton.UseVisualStyleBackColor = true;
            this.modalButton.Click += new System.EventHandler(this.modalButton_Click);
            // 
            // modalessButton
            // 
            this.modalessButton.Location = new System.Drawing.Point(168, 80);
            this.modalessButton.Name = "modalessButton";
            this.modalessButton.Size = new System.Drawing.Size(161, 48);
            this.modalessButton.TabIndex = 3;
            this.modalessButton.Text = "Modaless";
            this.modalessButton.UseVisualStyleBackColor = true;
            this.modalessButton.Click += new System.EventHandler(this.modalessButton_Click);
            // 
            // messageBoxBtn1
            // 
            this.messageBoxBtn1.Location = new System.Drawing.Point(17, 197);
            this.messageBoxBtn1.Name = "messageBoxBtn1";
            this.messageBoxBtn1.Size = new System.Drawing.Size(171, 39);
            this.messageBoxBtn1.TabIndex = 4;
            this.messageBoxBtn1.Text = "Message Box 1";
            this.messageBoxBtn1.UseVisualStyleBackColor = true;
            this.messageBoxBtn1.Click += new System.EventHandler(this.messageBoxBtn1_Click);
            // 
            // messageBoxBtn2
            // 
            this.messageBoxBtn2.Location = new System.Drawing.Point(17, 242);
            this.messageBoxBtn2.Name = "messageBoxBtn2";
            this.messageBoxBtn2.Size = new System.Drawing.Size(171, 39);
            this.messageBoxBtn2.TabIndex = 5;
            this.messageBoxBtn2.Text = "Message Box 2";
            this.messageBoxBtn2.UseVisualStyleBackColor = true;
            this.messageBoxBtn2.Click += new System.EventHandler(this.messageBoxBtn2_Click);
            // 
            // messageBoxBtn3
            // 
            this.messageBoxBtn3.Location = new System.Drawing.Point(17, 287);
            this.messageBoxBtn3.Name = "messageBoxBtn3";
            this.messageBoxBtn3.Size = new System.Drawing.Size(171, 39);
            this.messageBoxBtn3.TabIndex = 6;
            this.messageBoxBtn3.Text = "Message Box 3";
            this.messageBoxBtn3.UseVisualStyleBackColor = true;
            this.messageBoxBtn3.Click += new System.EventHandler(this.messageBoxBtn3_Click);
            // 
            // Week12Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 657);
            this.Controls.Add(this.messageBoxBtn3);
            this.Controls.Add(this.messageBoxBtn2);
            this.Controls.Add(this.messageBoxBtn1);
            this.Controls.Add(this.modalessButton);
            this.Controls.Add(this.modalButton);
            this.Controls.Add(this.checkedListShowBtn);
            this.Controls.Add(this.checkedListBox);
            this.Name = "Week12Form";
            this.Text = "Week12Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button checkedListShowBtn;
        private System.Windows.Forms.Button modalButton;
        private System.Windows.Forms.Button modalessButton;
        private System.Windows.Forms.Button messageBoxBtn1;
        private System.Windows.Forms.Button messageBoxBtn2;
        private System.Windows.Forms.Button messageBoxBtn3;
    }
}