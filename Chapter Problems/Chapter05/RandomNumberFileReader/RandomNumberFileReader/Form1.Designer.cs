namespace RandomNumberFileReader
{
    partial class randomForm
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
            this.numberPromptLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.runNumbersButton = new System.Windows.Forms.Button();
            this.getNumbersButton = new System.Windows.Forms.Button();
            this.numbersListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // numberPromptLabel
            // 
            this.numberPromptLabel.Location = new System.Drawing.Point(12, 25);
            this.numberPromptLabel.Name = "numberPromptLabel";
            this.numberPromptLabel.Size = new System.Drawing.Size(146, 18);
            this.numberPromptLabel.TabIndex = 0;
            this.numberPromptLabel.Text = "How many random number : ";
            this.numberPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(164, 25);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(108, 20);
            this.numberTextBox.TabIndex = 1;
            // 
            // runNumbersButton
            // 
            this.runNumbersButton.Location = new System.Drawing.Point(70, 63);
            this.runNumbersButton.Name = "runNumbersButton";
            this.runNumbersButton.Size = new System.Drawing.Size(134, 59);
            this.runNumbersButton.TabIndex = 2;
            this.runNumbersButton.Text = "Genereate Random Number to File";
            this.runNumbersButton.UseVisualStyleBackColor = true;
            this.runNumbersButton.Click += new System.EventHandler(this.runNumbersButton_Click);
            // 
            // getNumbersButton
            // 
            this.getNumbersButton.Location = new System.Drawing.Point(70, 144);
            this.getNumbersButton.Name = "getNumbersButton";
            this.getNumbersButton.Size = new System.Drawing.Size(134, 59);
            this.getNumbersButton.TabIndex = 3;
            this.getNumbersButton.Text = "Return Number from File";
            this.getNumbersButton.UseVisualStyleBackColor = true;
            this.getNumbersButton.Click += new System.EventHandler(this.getNumbersButton_Click);
            // 
            // numbersListBox
            // 
            this.numbersListBox.FormattingEnabled = true;
            this.numbersListBox.Location = new System.Drawing.Point(60, 222);
            this.numbersListBox.Name = "numbersListBox";
            this.numbersListBox.Size = new System.Drawing.Size(164, 121);
            this.numbersListBox.TabIndex = 4;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(70, 380);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(134, 59);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // randomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 451);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.numbersListBox);
            this.Controls.Add(this.getNumbersButton);
            this.Controls.Add(this.runNumbersButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.numberPromptLabel);
            this.Name = "randomForm";
            this.Text = "Random Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberPromptLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button runNumbersButton;
        private System.Windows.Forms.Button getNumbersButton;
        private System.Windows.Forms.ListBox numbersListBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

