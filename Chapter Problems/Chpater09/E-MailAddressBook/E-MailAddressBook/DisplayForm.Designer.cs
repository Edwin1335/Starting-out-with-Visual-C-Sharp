namespace E_MailAddressBook
{
    partial class DisplayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameDisplayLabel = new System.Windows.Forms.Label();
            this.emailDisplayLabel = new System.Windows.Forms.Label();
            this.numberDisplayLabel = new System.Windows.Forms.Label();
            this.lastNameDisplayLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameDisplayLabel
            // 
            this.nameDisplayLabel.Location = new System.Drawing.Point(12, 25);
            this.nameDisplayLabel.Name = "nameDisplayLabel";
            this.nameDisplayLabel.Size = new System.Drawing.Size(83, 30);
            this.nameDisplayLabel.TabIndex = 0;
            this.nameDisplayLabel.Text = "Name : ";
            this.nameDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailDisplayLabel
            // 
            this.emailDisplayLabel.Location = new System.Drawing.Point(12, 81);
            this.emailDisplayLabel.Name = "emailDisplayLabel";
            this.emailDisplayLabel.Size = new System.Drawing.Size(83, 30);
            this.emailDisplayLabel.TabIndex = 1;
            this.emailDisplayLabel.Text = "Email : ";
            this.emailDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numberDisplayLabel
            // 
            this.numberDisplayLabel.Location = new System.Drawing.Point(12, 111);
            this.numberDisplayLabel.Name = "numberDisplayLabel";
            this.numberDisplayLabel.Size = new System.Drawing.Size(83, 30);
            this.numberDisplayLabel.TabIndex = 2;
            this.numberDisplayLabel.Text = "Phone Number";
            this.numberDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastNameDisplayLabel
            // 
            this.lastNameDisplayLabel.Location = new System.Drawing.Point(12, 51);
            this.lastNameDisplayLabel.Name = "lastNameDisplayLabel";
            this.lastNameDisplayLabel.Size = new System.Drawing.Size(83, 30);
            this.lastNameDisplayLabel.TabIndex = 3;
            this.lastNameDisplayLabel.Text = "Last Name :";
            this.lastNameDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel.Location = new System.Drawing.Point(101, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(171, 21);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lastNameLabel.Location = new System.Drawing.Point(101, 56);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(171, 21);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            this.emailLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emailLabel.Location = new System.Drawing.Point(101, 86);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(171, 21);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberLabel
            // 
            this.numberLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numberLabel.Location = new System.Drawing.Point(101, 116);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(171, 21);
            this.numberLabel.TabIndex = 7;
            this.numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(88, 178);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(97, 26);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 231);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.lastNameDisplayLabel);
            this.Controls.Add(this.numberDisplayLabel);
            this.Controls.Add(this.emailDisplayLabel);
            this.Controls.Add(this.nameDisplayLabel);
            this.Name = "DisplayForm";
            this.Text = "DisplayForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameDisplayLabel;
        private System.Windows.Forms.Label emailDisplayLabel;
        private System.Windows.Forms.Label numberDisplayLabel;
        private System.Windows.Forms.Label lastNameDisplayLabel;
        public System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.Label lastNameLabel;
        public System.Windows.Forms.Label emailLabel;
        public System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Button okButton;
    }
}