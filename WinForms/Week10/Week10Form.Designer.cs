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
            this.flatButton = new System.Windows.Forms.Button();
            this.popupButton = new System.Windows.Forms.Button();
            this.standardButton = new System.Windows.Forms.Button();
            this.systemButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.naverLink = new System.Windows.Forms.LinkLabel();
            this.youtubeLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // TestButton
            // 
            this.TestButton.ForeColor = System.Drawing.Color.Coral;
            this.TestButton.Location = new System.Drawing.Point(359, 451);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(218, 88);
            this.TestButton.TabIndex = 0;
            this.TestButton.Text = "Test Button Text";
            this.TestButton.UseVisualStyleBackColor = true;
            // 
            // flatButton
            // 
            this.flatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton.Location = new System.Drawing.Point(77, 79);
            this.flatButton.Name = "flatButton";
            this.flatButton.Size = new System.Drawing.Size(157, 63);
            this.flatButton.TabIndex = 1;
            this.flatButton.Text = "Flat";
            this.flatButton.UseVisualStyleBackColor = true;
            this.flatButton.Click += new System.EventHandler(this.flatButton_Click);
            // 
            // popupButton
            // 
            this.popupButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.popupButton.Location = new System.Drawing.Point(281, 79);
            this.popupButton.Name = "popupButton";
            this.popupButton.Size = new System.Drawing.Size(157, 63);
            this.popupButton.TabIndex = 2;
            this.popupButton.Text = "Popup";
            this.popupButton.UseVisualStyleBackColor = true;
            this.popupButton.Click += new System.EventHandler(this.popupButton_Click);
            // 
            // standardButton
            // 
            this.standardButton.Location = new System.Drawing.Point(77, 183);
            this.standardButton.Name = "standardButton";
            this.standardButton.Size = new System.Drawing.Size(157, 63);
            this.standardButton.TabIndex = 3;
            this.standardButton.Text = "Standard";
            this.standardButton.UseVisualStyleBackColor = true;
            this.standardButton.Click += new System.EventHandler(this.standardButton_Click);
            // 
            // systemButton
            // 
            this.systemButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.systemButton.Location = new System.Drawing.Point(281, 183);
            this.systemButton.Name = "systemButton";
            this.systemButton.Size = new System.Drawing.Size(157, 63);
            this.systemButton.TabIndex = 4;
            this.systemButton.Text = "System";
            this.systemButton.UseVisualStyleBackColor = true;
            this.systemButton.Click += new System.EventHandler(this.systemButton_Click);
            // 
            // label
            // 
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label.Location = new System.Drawing.Point(77, 276);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(150, 20);
            this.label.TabIndex = 5;
            this.label.Text = "label1";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // naverLink
            // 
            this.naverLink.AutoSize = true;
            this.naverLink.Location = new System.Drawing.Point(75, 317);
            this.naverLink.Name = "naverLink";
            this.naverLink.Size = new System.Drawing.Size(99, 12);
            this.naverLink.TabIndex = 6;
            this.naverLink.TabStop = true;
            this.naverLink.Text = "www.naver.com";
            this.naverLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.naverLink_LinkClicked);
            // 
            // youtubeLink
            // 
            this.youtubeLink.AutoSize = true;
            this.youtubeLink.Location = new System.Drawing.Point(75, 349);
            this.youtubeLink.Name = "youtubeLink";
            this.youtubeLink.Size = new System.Drawing.Size(113, 12);
            this.youtubeLink.TabIndex = 7;
            this.youtubeLink.TabStop = true;
            this.youtubeLink.Text = "www.youtube.com";
            this.youtubeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.youtubeLink_LinkClicked);
            // 
            // Week10Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 551);
            this.Controls.Add(this.youtubeLink);
            this.Controls.Add(this.naverLink);
            this.Controls.Add(this.label);
            this.Controls.Add(this.systemButton);
            this.Controls.Add(this.standardButton);
            this.Controls.Add(this.popupButton);
            this.Controls.Add(this.flatButton);
            this.Controls.Add(this.TestButton);
            this.Name = "Week10Form";
            this.Text = "Week10Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Week10Form_FormClosed);
            this.Load += new System.EventHandler(this.Week10Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Button flatButton;
        private System.Windows.Forms.Button popupButton;
        private System.Windows.Forms.Button standardButton;
        private System.Windows.Forms.Button systemButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.LinkLabel naverLink;
        private System.Windows.Forms.LinkLabel youtubeLink;
    }
}