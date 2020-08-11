namespace Stadium_Seating
{
    partial class stadiumSeatingForm
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
            this.ticketsSoldGroupBox = new System.Windows.Forms.GroupBox();
            this.revenueGroupBox = new System.Windows.Forms.GroupBox();
            this.enterUserPromptLabel = new System.Windows.Forms.Label();
            this.classALabel = new System.Windows.Forms.Label();
            this.classBLabel = new System.Windows.Forms.Label();
            this.classCLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.classATextBox = new System.Windows.Forms.TextBox();
            this.classBTextBox = new System.Windows.Forms.TextBox();
            this.classCTextBox = new System.Windows.Forms.TextBox();
            this.classARevenueLabel = new System.Windows.Forms.Label();
            this.classBRevenueLabel = new System.Windows.Forms.Label();
            this.classCRevenueLabel = new System.Windows.Forms.Label();
            this.totalAnswerLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.ticketsSoldGroupBox.SuspendLayout();
            this.revenueGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticketsSoldGroupBox
            // 
            this.ticketsSoldGroupBox.Controls.Add(this.classCTextBox);
            this.ticketsSoldGroupBox.Controls.Add(this.classBTextBox);
            this.ticketsSoldGroupBox.Controls.Add(this.classATextBox);
            this.ticketsSoldGroupBox.Controls.Add(this.classCLabel);
            this.ticketsSoldGroupBox.Controls.Add(this.classBLabel);
            this.ticketsSoldGroupBox.Controls.Add(this.classALabel);
            this.ticketsSoldGroupBox.Controls.Add(this.enterUserPromptLabel);
            this.ticketsSoldGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketsSoldGroupBox.Location = new System.Drawing.Point(38, 48);
            this.ticketsSoldGroupBox.Name = "ticketsSoldGroupBox";
            this.ticketsSoldGroupBox.Size = new System.Drawing.Size(317, 329);
            this.ticketsSoldGroupBox.TabIndex = 0;
            this.ticketsSoldGroupBox.TabStop = false;
            this.ticketsSoldGroupBox.Text = "Tickets Sold";
            // 
            // revenueGroupBox
            // 
            this.revenueGroupBox.Controls.Add(this.totalLabel);
            this.revenueGroupBox.Controls.Add(this.totalAnswerLabel);
            this.revenueGroupBox.Controls.Add(this.classCRevenueLabel);
            this.revenueGroupBox.Controls.Add(this.classBRevenueLabel);
            this.revenueGroupBox.Controls.Add(this.classARevenueLabel);
            this.revenueGroupBox.Controls.Add(this.label3);
            this.revenueGroupBox.Controls.Add(this.label2);
            this.revenueGroupBox.Controls.Add(this.label1);
            this.revenueGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueGroupBox.Location = new System.Drawing.Point(441, 48);
            this.revenueGroupBox.Name = "revenueGroupBox";
            this.revenueGroupBox.Size = new System.Drawing.Size(317, 329);
            this.revenueGroupBox.TabIndex = 1;
            this.revenueGroupBox.TabStop = false;
            this.revenueGroupBox.Text = "Revenue Generated";
            // 
            // enterUserPromptLabel
            // 
            this.enterUserPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterUserPromptLabel.Location = new System.Drawing.Point(22, 32);
            this.enterUserPromptLabel.Name = "enterUserPromptLabel";
            this.enterUserPromptLabel.Size = new System.Drawing.Size(257, 70);
            this.enterUserPromptLabel.TabIndex = 0;
            this.enterUserPromptLabel.Text = "Enter the numbe of tickets sold for each class set:";
            this.enterUserPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classALabel
            // 
            this.classALabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classALabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.classALabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.classALabel.Location = new System.Drawing.Point(22, 138);
            this.classALabel.Name = "classALabel";
            this.classALabel.Size = new System.Drawing.Size(89, 35);
            this.classALabel.TabIndex = 1;
            this.classALabel.Text = "Class A :";
            this.classALabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // classBLabel
            // 
            this.classBLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classBLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.classBLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.classBLabel.Location = new System.Drawing.Point(22, 182);
            this.classBLabel.Name = "classBLabel";
            this.classBLabel.Size = new System.Drawing.Size(89, 35);
            this.classBLabel.TabIndex = 2;
            this.classBLabel.Text = "Class B :";
            this.classBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // classCLabel
            // 
            this.classCLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classCLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.classCLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.classCLabel.Location = new System.Drawing.Point(22, 228);
            this.classCLabel.Name = "classCLabel";
            this.classCLabel.Size = new System.Drawing.Size(89, 35);
            this.classCLabel.TabIndex = 3;
            this.classCLabel.Text = "Class C :";
            this.classCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class A :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(6, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Class B :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(6, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Class C :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // classATextBox
            // 
            this.classATextBox.Location = new System.Drawing.Point(121, 147);
            this.classATextBox.Name = "classATextBox";
            this.classATextBox.Size = new System.Drawing.Size(158, 22);
            this.classATextBox.TabIndex = 4;
            // 
            // classBTextBox
            // 
            this.classBTextBox.Location = new System.Drawing.Point(121, 191);
            this.classBTextBox.Name = "classBTextBox";
            this.classBTextBox.Size = new System.Drawing.Size(158, 22);
            this.classBTextBox.TabIndex = 5;
            // 
            // classCTextBox
            // 
            this.classCTextBox.Location = new System.Drawing.Point(121, 237);
            this.classCTextBox.Name = "classCTextBox";
            this.classCTextBox.Size = new System.Drawing.Size(158, 22);
            this.classCTextBox.TabIndex = 6;
            // 
            // classARevenueLabel
            // 
            this.classARevenueLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.classARevenueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classARevenueLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classARevenueLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.classARevenueLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.classARevenueLabel.Location = new System.Drawing.Point(112, 67);
            this.classARevenueLabel.Name = "classARevenueLabel";
            this.classARevenueLabel.Size = new System.Drawing.Size(185, 35);
            this.classARevenueLabel.TabIndex = 5;
            this.classARevenueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // classBRevenueLabel
            // 
            this.classBRevenueLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.classBRevenueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classBRevenueLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classBRevenueLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.classBRevenueLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.classBRevenueLabel.Location = new System.Drawing.Point(112, 128);
            this.classBRevenueLabel.Name = "classBRevenueLabel";
            this.classBRevenueLabel.Size = new System.Drawing.Size(185, 35);
            this.classBRevenueLabel.TabIndex = 6;
            this.classBRevenueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // classCRevenueLabel
            // 
            this.classCRevenueLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.classCRevenueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classCRevenueLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classCRevenueLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.classCRevenueLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.classCRevenueLabel.Location = new System.Drawing.Point(112, 182);
            this.classCRevenueLabel.Name = "classCRevenueLabel";
            this.classCRevenueLabel.Size = new System.Drawing.Size(185, 35);
            this.classCRevenueLabel.TabIndex = 7;
            this.classCRevenueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalAnswerLabel
            // 
            this.totalAnswerLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totalAnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalAnswerLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAnswerLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.totalAnswerLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalAnswerLabel.Location = new System.Drawing.Point(112, 237);
            this.totalAnswerLabel.Name = "totalAnswerLabel";
            this.totalAnswerLabel.Size = new System.Drawing.Size(185, 35);
            this.totalAnswerLabel.TabIndex = 8;
            this.totalAnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.totalLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalLabel.Location = new System.Drawing.Point(6, 237);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(89, 35);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total :";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(122, 403);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(154, 67);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate Revenue";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(320, 403);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(154, 67);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(509, 403);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(154, 67);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // stadiumSeatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.revenueGroupBox);
            this.Controls.Add(this.ticketsSoldGroupBox);
            this.Name = "stadiumSeatingForm";
            this.Text = "Stadium Seating";
            this.ticketsSoldGroupBox.ResumeLayout(false);
            this.ticketsSoldGroupBox.PerformLayout();
            this.revenueGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ticketsSoldGroupBox;
        private System.Windows.Forms.GroupBox revenueGroupBox;
        private System.Windows.Forms.Label enterUserPromptLabel;
        private System.Windows.Forms.Label classCLabel;
        private System.Windows.Forms.Label classBLabel;
        private System.Windows.Forms.Label classALabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox classCTextBox;
        private System.Windows.Forms.TextBox classBTextBox;
        private System.Windows.Forms.TextBox classATextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalAnswerLabel;
        private System.Windows.Forms.Label classCRevenueLabel;
        private System.Windows.Forms.Label classBRevenueLabel;
        private System.Windows.Forms.Label classARevenueLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

