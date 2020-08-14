namespace E_MailAddressBook
{
    partial class RosterForm
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
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.GetNamesButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameListBox
            // 
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.Location = new System.Drawing.Point(39, 25);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(195, 82);
            this.nameListBox.TabIndex = 0;
            // 
            // GetNamesButton
            // 
            this.GetNamesButton.Location = new System.Drawing.Point(79, 138);
            this.GetNamesButton.Name = "GetNamesButton";
            this.GetNamesButton.Size = new System.Drawing.Size(112, 36);
            this.GetNamesButton.TabIndex = 1;
            this.GetNamesButton.Text = "Get Names";
            this.GetNamesButton.UseVisualStyleBackColor = true;
            this.GetNamesButton.Click += new System.EventHandler(this.GetNamesButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(79, 222);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(112, 36);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(79, 180);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(112, 36);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // RosterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 270);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.GetNamesButton);
            this.Controls.Add(this.nameListBox);
            this.Name = "RosterForm";
            this.Text = "Roster ";
            this.Load += new System.EventHandler(this.RosterForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button GetNamesButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.Button OkButton;
    }
}

