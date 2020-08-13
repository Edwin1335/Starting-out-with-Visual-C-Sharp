namespace TestAverageDelimeter
{
    partial class testAverageForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.averagesListBox = new System.Windows.Forms.ListBox();
            this.GetScoresButton = new System.Windows.Forms.Button();
            this.scoresListBox = new System.Windows.Forms.ListBox();
            this.scoresDisplayLabel = new System.Windows.Forms.Label();
            this.averageDisplayLabel = new System.Windows.Forms.Label();
            this.GetAveragerButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // averagesListBox
            // 
            this.averagesListBox.FormattingEnabled = true;
            this.averagesListBox.ItemHeight = 25;
            this.averagesListBox.Location = new System.Drawing.Point(71, 386);
            this.averagesListBox.Name = "averagesListBox";
            this.averagesListBox.Size = new System.Drawing.Size(671, 204);
            this.averagesListBox.TabIndex = 0;
            // 
            // GetScoresButton
            // 
            this.GetScoresButton.Location = new System.Drawing.Point(71, 614);
            this.GetScoresButton.Name = "GetScoresButton";
            this.GetScoresButton.Size = new System.Drawing.Size(173, 72);
            this.GetScoresButton.TabIndex = 1;
            this.GetScoresButton.Text = "Get Scores";
            this.GetScoresButton.UseVisualStyleBackColor = true;
            this.GetScoresButton.Click += new System.EventHandler(this.GetScoresButton_Click);
            // 
            // scoresListBox
            // 
            this.scoresListBox.FormattingEnabled = true;
            this.scoresListBox.ItemHeight = 25;
            this.scoresListBox.Location = new System.Drawing.Point(71, 86);
            this.scoresListBox.Name = "scoresListBox";
            this.scoresListBox.Size = new System.Drawing.Size(671, 204);
            this.scoresListBox.TabIndex = 2;
            // 
            // scoresDisplayLabel
            // 
            this.scoresDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoresDisplayLabel.Location = new System.Drawing.Point(321, 27);
            this.scoresDisplayLabel.Name = "scoresDisplayLabel";
            this.scoresDisplayLabel.Size = new System.Drawing.Size(141, 47);
            this.scoresDisplayLabel.TabIndex = 3;
            this.scoresDisplayLabel.Text = "Scores";
            this.scoresDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageDisplayLabel
            // 
            this.averageDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageDisplayLabel.Location = new System.Drawing.Point(321, 336);
            this.averageDisplayLabel.Name = "averageDisplayLabel";
            this.averageDisplayLabel.Size = new System.Drawing.Size(141, 47);
            this.averageDisplayLabel.TabIndex = 4;
            this.averageDisplayLabel.Text = "Averages";
            this.averageDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GetAveragerButton
            // 
            this.GetAveragerButton.Location = new System.Drawing.Point(309, 614);
            this.GetAveragerButton.Name = "GetAveragerButton";
            this.GetAveragerButton.Size = new System.Drawing.Size(184, 72);
            this.GetAveragerButton.TabIndex = 5;
            this.GetAveragerButton.Text = "Get Average";
            this.GetAveragerButton.UseVisualStyleBackColor = true;
            this.GetAveragerButton.Click += new System.EventHandler(this.GetAveragerButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(553, 614);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(189, 72);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // testAverageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 715);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.GetAveragerButton);
            this.Controls.Add(this.averageDisplayLabel);
            this.Controls.Add(this.scoresDisplayLabel);
            this.Controls.Add(this.scoresListBox);
            this.Controls.Add(this.GetScoresButton);
            this.Controls.Add(this.averagesListBox);
            this.Name = "testAverageForm";
            this.Text = "TestAverage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox averagesListBox;
        private System.Windows.Forms.Button GetScoresButton;
        private System.Windows.Forms.ListBox scoresListBox;
        private System.Windows.Forms.Label scoresDisplayLabel;
        private System.Windows.Forms.Label averageDisplayLabel;
        private System.Windows.Forms.Button GetAveragerButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

