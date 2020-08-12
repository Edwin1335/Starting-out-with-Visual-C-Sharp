namespace FriendFile
{
    partial class friendForm
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
            this.enterNamePromptLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterNamePromptLabel
            // 
            this.enterNamePromptLabel.Location = new System.Drawing.Point(12, 20);
            this.enterNamePromptLabel.Name = "enterNamePromptLabel";
            this.enterNamePromptLabel.Size = new System.Drawing.Size(136, 33);
            this.enterNamePromptLabel.TabIndex = 0;
            this.enterNamePromptLabel.Text = "Enter friend\'s name :";
            this.enterNamePromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(164, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(143, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(45, 83);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(102, 35);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(190, 83);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 35);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // friendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 131);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.enterNamePromptLabel);
            this.Name = "friendForm";
            this.Text = "Friend File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterNamePromptLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button exitButton;
    }
}

