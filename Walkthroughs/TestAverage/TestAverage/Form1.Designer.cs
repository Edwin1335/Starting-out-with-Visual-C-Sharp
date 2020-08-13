namespace TestAverage
{
    partial class averageFrom
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
            this.testScoresPromptLabel = new System.Windows.Forms.Label();
            this.testScoreListBox = new System.Windows.Forms.ListBox();
            this.highScorePromptLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.highestScoreLabel = new System.Windows.Forms.Label();
            this.lowestScoreLabel = new System.Windows.Forms.Label();
            this.averageScoreLabel = new System.Windows.Forms.Label();
            this.getScoreButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // testScoresPromptLabel
            // 
            this.testScoresPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testScoresPromptLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.testScoresPromptLabel.Location = new System.Drawing.Point(12, 9);
            this.testScoresPromptLabel.Name = "testScoresPromptLabel";
            this.testScoresPromptLabel.Size = new System.Drawing.Size(85, 25);
            this.testScoresPromptLabel.TabIndex = 0;
            this.testScoresPromptLabel.Text = "Test Scores";
            this.testScoresPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testScoreListBox
            // 
            this.testScoreListBox.FormattingEnabled = true;
            this.testScoreListBox.Location = new System.Drawing.Point(15, 37);
            this.testScoreListBox.Name = "testScoreListBox";
            this.testScoreListBox.Size = new System.Drawing.Size(142, 95);
            this.testScoreListBox.TabIndex = 1;
            // 
            // highScorePromptLabel
            // 
            this.highScorePromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScorePromptLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.highScorePromptLabel.Location = new System.Drawing.Point(163, 37);
            this.highScorePromptLabel.Name = "highScorePromptLabel";
            this.highScorePromptLabel.Size = new System.Drawing.Size(109, 25);
            this.highScorePromptLabel.TabIndex = 2;
            this.highScorePromptLabel.Text = "Highest Score :";
            this.highScorePromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(163, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lowest Score :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(163, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Average Score :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // highestScoreLabel
            // 
            this.highestScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highestScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestScoreLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.highestScoreLabel.Location = new System.Drawing.Point(278, 37);
            this.highestScoreLabel.Name = "highestScoreLabel";
            this.highestScoreLabel.Size = new System.Drawing.Size(109, 25);
            this.highestScoreLabel.TabIndex = 5;
            this.highestScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lowestScoreLabel
            // 
            this.lowestScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowestScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowestScoreLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lowestScoreLabel.Location = new System.Drawing.Point(278, 72);
            this.lowestScoreLabel.Name = "lowestScoreLabel";
            this.lowestScoreLabel.Size = new System.Drawing.Size(109, 25);
            this.lowestScoreLabel.TabIndex = 6;
            this.lowestScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageScoreLabel
            // 
            this.averageScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageScoreLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.averageScoreLabel.Location = new System.Drawing.Point(278, 107);
            this.averageScoreLabel.Name = "averageScoreLabel";
            this.averageScoreLabel.Size = new System.Drawing.Size(109, 25);
            this.averageScoreLabel.TabIndex = 7;
            this.averageScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getScoreButton
            // 
            this.getScoreButton.Location = new System.Drawing.Point(91, 155);
            this.getScoreButton.Name = "getScoreButton";
            this.getScoreButton.Size = new System.Drawing.Size(102, 24);
            this.getScoreButton.TabIndex = 8;
            this.getScoreButton.Text = "Get Score";
            this.getScoreButton.UseVisualStyleBackColor = true;
            this.getScoreButton.Click += new System.EventHandler(this.getScoreButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(215, 155);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 24);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // averageFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 201);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getScoreButton);
            this.Controls.Add(this.averageScoreLabel);
            this.Controls.Add(this.lowestScoreLabel);
            this.Controls.Add(this.highestScoreLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.highScorePromptLabel);
            this.Controls.Add(this.testScoreListBox);
            this.Controls.Add(this.testScoresPromptLabel);
            this.Name = "averageFrom";
            this.Text = "Test Average";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label testScoresPromptLabel;
        private System.Windows.Forms.ListBox testScoreListBox;
        private System.Windows.Forms.Label highScorePromptLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label highestScoreLabel;
        private System.Windows.Forms.Label lowestScoreLabel;
        private System.Windows.Forms.Label averageScoreLabel;
        private System.Windows.Forms.Button getScoreButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

