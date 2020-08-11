namespace TestAverageExeptionHandling
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
            this.test1PromptLabel = new System.Windows.Forms.Label();
            this.test2PromptLabel = new System.Windows.Forms.Label();
            this.test3PromptLabel = new System.Windows.Forms.Label();
            this.averageTestScoreLabel = new System.Windows.Forms.Label();
            this.averageAnswerLabel = new System.Windows.Forms.Label();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // test1PromptLabel
            // 
            this.test1PromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test1PromptLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.test1PromptLabel.Location = new System.Drawing.Point(12, 42);
            this.test1PromptLabel.Name = "test1PromptLabel";
            this.test1PromptLabel.Size = new System.Drawing.Size(144, 40);
            this.test1PromptLabel.TabIndex = 0;
            this.test1PromptLabel.Text = "Test 1:";
            this.test1PromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // test2PromptLabel
            // 
            this.test2PromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test2PromptLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.test2PromptLabel.Location = new System.Drawing.Point(12, 82);
            this.test2PromptLabel.Name = "test2PromptLabel";
            this.test2PromptLabel.Size = new System.Drawing.Size(144, 40);
            this.test2PromptLabel.TabIndex = 1;
            this.test2PromptLabel.Text = "Test 2:";
            this.test2PromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // test3PromptLabel
            // 
            this.test3PromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test3PromptLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.test3PromptLabel.Location = new System.Drawing.Point(12, 122);
            this.test3PromptLabel.Name = "test3PromptLabel";
            this.test3PromptLabel.Size = new System.Drawing.Size(144, 40);
            this.test3PromptLabel.TabIndex = 2;
            this.test3PromptLabel.Text = "Test 3:";
            this.test3PromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // averageTestScoreLabel
            // 
            this.averageTestScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageTestScoreLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.averageTestScoreLabel.Location = new System.Drawing.Point(12, 253);
            this.averageTestScoreLabel.Name = "averageTestScoreLabel";
            this.averageTestScoreLabel.Size = new System.Drawing.Size(171, 40);
            this.averageTestScoreLabel.TabIndex = 3;
            this.averageTestScoreLabel.Text = "Average Test Score";
            this.averageTestScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // averageAnswerLabel
            // 
            this.averageAnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageAnswerLabel.Location = new System.Drawing.Point(208, 253);
            this.averageAnswerLabel.Name = "averageAnswerLabel";
            this.averageAnswerLabel.Size = new System.Drawing.Size(186, 40);
            this.averageAnswerLabel.TabIndex = 4;
            this.averageAnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // test1TextBox
            // 
            this.test1TextBox.Location = new System.Drawing.Point(208, 54);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(185, 20);
            this.test1TextBox.TabIndex = 5;
            // 
            // test2TextBox
            // 
            this.test2TextBox.Location = new System.Drawing.Point(209, 94);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(185, 20);
            this.test2TextBox.TabIndex = 6;
            // 
            // test3TextBox
            // 
            this.test3TextBox.Location = new System.Drawing.Point(208, 134);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(185, 20);
            this.test3TextBox.TabIndex = 7;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(26, 334);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(122, 77);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate Average";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(154, 334);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(122, 77);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(282, 334);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(122, 77);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // testAverageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(866, 900);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.test3TextBox);
            this.Controls.Add(this.test2TextBox);
            this.Controls.Add(this.test1TextBox);
            this.Controls.Add(this.averageAnswerLabel);
            this.Controls.Add(this.averageTestScoreLabel);
            this.Controls.Add(this.test3PromptLabel);
            this.Controls.Add(this.test2PromptLabel);
            this.Controls.Add(this.test1PromptLabel);
            this.Name = "testAverageForm";
            this.Text = "Test Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label test1PromptLabel;
        private System.Windows.Forms.Label test2PromptLabel;
        private System.Windows.Forms.Label test3PromptLabel;
        private System.Windows.Forms.Label averageTestScoreLabel;
        private System.Windows.Forms.Label averageAnswerLabel;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.TextBox test3TextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

