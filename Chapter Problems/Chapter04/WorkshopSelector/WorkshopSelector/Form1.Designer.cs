namespace WorkshopSelector
{
    partial class worskopForm
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
            this.registrationGroupBox = new System.Windows.Forms.GroupBox();
            this.registrationFeesListBox = new System.Windows.Forms.ListBox();
            this.registrationPromptLabel = new System.Windows.Forms.Label();
            this.workshopTitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lodgingGroupBox = new System.Windows.Forms.GroupBox();
            this.lodginFeesLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.lodgingTitleLabel = new System.Windows.Forms.Label();
            this.lodgingFeesListBox = new System.Windows.Forms.ListBox();
            this.calcualteButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalAnswerLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.registrationGroupBox.SuspendLayout();
            this.lodgingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrationGroupBox
            // 
            this.registrationGroupBox.Controls.Add(this.label2);
            this.registrationGroupBox.Controls.Add(this.label1);
            this.registrationGroupBox.Controls.Add(this.workshopTitleLabel);
            this.registrationGroupBox.Controls.Add(this.registrationPromptLabel);
            this.registrationGroupBox.Controls.Add(this.registrationFeesListBox);
            this.registrationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationGroupBox.Location = new System.Drawing.Point(43, 49);
            this.registrationGroupBox.Name = "registrationGroupBox";
            this.registrationGroupBox.Size = new System.Drawing.Size(457, 228);
            this.registrationGroupBox.TabIndex = 0;
            this.registrationGroupBox.TabStop = false;
            this.registrationGroupBox.Text = "Registration Fees";
            // 
            // registrationFeesListBox
            // 
            this.registrationFeesListBox.FormattingEnabled = true;
            this.registrationFeesListBox.ItemHeight = 16;
            this.registrationFeesListBox.Items.AddRange(new object[] {
            "Handling Stress\t\t3\t\t$1,000",
            "Time Management\t\t3\t\t$800",
            "Supervision Skills\t\t3\t\t$1,500",
            "Negotiation\t\t5\t\t$1,300",
            "How to Interview\t\t1\t\t$500"});
            this.registrationFeesListBox.Location = new System.Drawing.Point(24, 90);
            this.registrationFeesListBox.Name = "registrationFeesListBox";
            this.registrationFeesListBox.Size = new System.Drawing.Size(405, 84);
            this.registrationFeesListBox.TabIndex = 0;
            // 
            // registrationPromptLabel
            // 
            this.registrationPromptLabel.AutoSize = true;
            this.registrationPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationPromptLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.registrationPromptLabel.Location = new System.Drawing.Point(137, 33);
            this.registrationPromptLabel.Name = "registrationPromptLabel";
            this.registrationPromptLabel.Size = new System.Drawing.Size(199, 20);
            this.registrationPromptLabel.TabIndex = 1;
            this.registrationPromptLabel.Text = "Select Registration Fee";
            // 
            // workshopTitleLabel
            // 
            this.workshopTitleLabel.AutoSize = true;
            this.workshopTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workshopTitleLabel.Location = new System.Drawing.Point(21, 71);
            this.workshopTitleLabel.Name = "workshopTitleLabel";
            this.workshopTitleLabel.Size = new System.Drawing.Size(70, 16);
            this.workshopTitleLabel.TabIndex = 2;
            this.workshopTitleLabel.Text = "Workhop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of Days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Workhop";
            // 
            // lodgingGroupBox
            // 
            this.lodgingGroupBox.Controls.Add(this.lodginFeesLabel);
            this.lodgingGroupBox.Controls.Add(this.locationLabel);
            this.lodgingGroupBox.Controls.Add(this.lodgingTitleLabel);
            this.lodgingGroupBox.Controls.Add(this.lodgingFeesListBox);
            this.lodgingGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lodgingGroupBox.Location = new System.Drawing.Point(506, 49);
            this.lodgingGroupBox.Name = "lodgingGroupBox";
            this.lodgingGroupBox.Size = new System.Drawing.Size(340, 228);
            this.lodgingGroupBox.TabIndex = 1;
            this.lodgingGroupBox.TabStop = false;
            this.lodgingGroupBox.Text = "Lodging Fees";
            // 
            // lodginFeesLabel
            // 
            this.lodginFeesLabel.AutoSize = true;
            this.lodginFeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lodginFeesLabel.Location = new System.Drawing.Point(106, 71);
            this.lodginFeesLabel.Name = "lodginFeesLabel";
            this.lodginFeesLabel.Size = new System.Drawing.Size(162, 16);
            this.lodginFeesLabel.TabIndex = 3;
            this.lodginFeesLabel.Text = "Lodging Fees per Day";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(21, 71);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(67, 16);
            this.locationLabel.TabIndex = 2;
            this.locationLabel.Text = "Location";
            // 
            // lodgingTitleLabel
            // 
            this.lodgingTitleLabel.AutoSize = true;
            this.lodgingTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lodgingTitleLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lodgingTitleLabel.Location = new System.Drawing.Point(137, 33);
            this.lodgingTitleLabel.Name = "lodgingTitleLabel";
            this.lodgingTitleLabel.Size = new System.Drawing.Size(165, 20);
            this.lodgingTitleLabel.TabIndex = 1;
            this.lodgingTitleLabel.Text = "Select Lodging Fee";
            // 
            // lodgingFeesListBox
            // 
            this.lodgingFeesListBox.FormattingEnabled = true;
            this.lodgingFeesListBox.ItemHeight = 16;
            this.lodgingFeesListBox.Items.AddRange(new object[] {
            "Austin\t\t$150",
            "Chicago\t\t$225",
            "Dallas\t\t$175",
            "Orlando\t\t$300",
            "Phoenix\t\t$175",
            "Raleigh\t\t$150"});
            this.lodgingFeesListBox.Location = new System.Drawing.Point(24, 90);
            this.lodgingFeesListBox.Name = "lodgingFeesListBox";
            this.lodgingFeesListBox.Size = new System.Drawing.Size(278, 84);
            this.lodgingFeesListBox.TabIndex = 0;
            // 
            // calcualteButton
            // 
            this.calcualteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcualteButton.Location = new System.Drawing.Point(215, 364);
            this.calcualteButton.Name = "calcualteButton";
            this.calcualteButton.Size = new System.Drawing.Size(164, 55);
            this.calcualteButton.TabIndex = 2;
            this.calcualteButton.Text = "Calculate Total Cost";
            this.calcualteButton.UseVisualStyleBackColor = true;
            this.calcualteButton.Click += new System.EventHandler(this.calcualteButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(165, 305);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(214, 37);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "Total :";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalAnswerLabel
            // 
            this.totalAnswerLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalAnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAnswerLabel.Location = new System.Drawing.Point(403, 305);
            this.totalAnswerLabel.Name = "totalAnswerLabel";
            this.totalAnswerLabel.Size = new System.Drawing.Size(214, 37);
            this.totalAnswerLabel.TabIndex = 4;
            this.totalAnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(530, 364);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(164, 55);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // worskopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.totalAnswerLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.calcualteButton);
            this.Controls.Add(this.lodgingGroupBox);
            this.Controls.Add(this.registrationGroupBox);
            this.Name = "worskopForm";
            this.Text = "Workshop Selector";
            this.registrationGroupBox.ResumeLayout(false);
            this.registrationGroupBox.PerformLayout();
            this.lodgingGroupBox.ResumeLayout(false);
            this.lodgingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox registrationGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label workshopTitleLabel;
        private System.Windows.Forms.Label registrationPromptLabel;
        private System.Windows.Forms.ListBox registrationFeesListBox;
        private System.Windows.Forms.GroupBox lodgingGroupBox;
        private System.Windows.Forms.Label lodginFeesLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label lodgingTitleLabel;
        private System.Windows.Forms.ListBox lodgingFeesListBox;
        private System.Windows.Forms.Button calcualteButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalAnswerLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

