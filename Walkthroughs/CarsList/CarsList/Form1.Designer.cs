namespace CarsList
{
    partial class carListForm
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
            this.carInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.makePromptLabel = new System.Windows.Forms.Label();
            this.yearPromptLabel = new System.Windows.Forms.Label();
            this.milePromptLabel = new System.Windows.Forms.Label();
            this.mileTextBox = new System.Windows.Forms.TextBox();
            this.yearTexBox = new System.Windows.Forms.TextBox();
            this.mileageTextBox = new System.Windows.Forms.TextBox();
            this.AddCarButton = new System.Windows.Forms.Button();
            this.carListBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.carInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // carInfoGroupBox
            // 
            this.carInfoGroupBox.Controls.Add(this.mileageTextBox);
            this.carInfoGroupBox.Controls.Add(this.yearTexBox);
            this.carInfoGroupBox.Controls.Add(this.mileTextBox);
            this.carInfoGroupBox.Controls.Add(this.milePromptLabel);
            this.carInfoGroupBox.Controls.Add(this.yearPromptLabel);
            this.carInfoGroupBox.Controls.Add(this.makePromptLabel);
            this.carInfoGroupBox.Location = new System.Drawing.Point(45, 44);
            this.carInfoGroupBox.Name = "carInfoGroupBox";
            this.carInfoGroupBox.Size = new System.Drawing.Size(368, 229);
            this.carInfoGroupBox.TabIndex = 0;
            this.carInfoGroupBox.TabStop = false;
            this.carInfoGroupBox.Text = "Car Infomation";
            // 
            // makePromptLabel
            // 
            this.makePromptLabel.Location = new System.Drawing.Point(6, 52);
            this.makePromptLabel.Name = "makePromptLabel";
            this.makePromptLabel.Size = new System.Drawing.Size(111, 49);
            this.makePromptLabel.TabIndex = 0;
            this.makePromptLabel.Text = "Make";
            this.makePromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // yearPromptLabel
            // 
            this.yearPromptLabel.Location = new System.Drawing.Point(6, 101);
            this.yearPromptLabel.Name = "yearPromptLabel";
            this.yearPromptLabel.Size = new System.Drawing.Size(111, 49);
            this.yearPromptLabel.TabIndex = 1;
            this.yearPromptLabel.Text = "Year";
            this.yearPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // milePromptLabel
            // 
            this.milePromptLabel.Location = new System.Drawing.Point(6, 150);
            this.milePromptLabel.Name = "milePromptLabel";
            this.milePromptLabel.Size = new System.Drawing.Size(111, 49);
            this.milePromptLabel.TabIndex = 2;
            this.milePromptLabel.Text = "Mileage";
            this.milePromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mileTextBox
            // 
            this.mileTextBox.Location = new System.Drawing.Point(151, 64);
            this.mileTextBox.Name = "mileTextBox";
            this.mileTextBox.Size = new System.Drawing.Size(192, 31);
            this.mileTextBox.TabIndex = 3;
            // 
            // yearTexBox
            // 
            this.yearTexBox.Location = new System.Drawing.Point(151, 110);
            this.yearTexBox.Name = "yearTexBox";
            this.yearTexBox.Size = new System.Drawing.Size(192, 31);
            this.yearTexBox.TabIndex = 4;
            // 
            // mileageTextBox
            // 
            this.mileageTextBox.Location = new System.Drawing.Point(151, 159);
            this.mileageTextBox.Name = "mileageTextBox";
            this.mileageTextBox.Size = new System.Drawing.Size(192, 31);
            this.mileageTextBox.TabIndex = 5;
            // 
            // AddCarButton
            // 
            this.AddCarButton.Location = new System.Drawing.Point(126, 308);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(157, 65);
            this.AddCarButton.TabIndex = 1;
            this.AddCarButton.Text = "Add Car to List";
            this.AddCarButton.UseVisualStyleBackColor = true;
            this.AddCarButton.Click += new System.EventHandler(this.AddCarButton_Click);
            // 
            // carListBox1
            // 
            this.carListBox1.FormattingEnabled = true;
            this.carListBox1.ItemHeight = 25;
            this.carListBox1.Location = new System.Drawing.Point(439, 44);
            this.carListBox1.Name = "carListBox1";
            this.carListBox1.Size = new System.Drawing.Size(325, 229);
            this.carListBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "Display Car List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // carListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.carListBox1);
            this.Controls.Add(this.AddCarButton);
            this.Controls.Add(this.carInfoGroupBox);
            this.Name = "carListForm";
            this.Text = "Car List";
            this.carInfoGroupBox.ResumeLayout(false);
            this.carInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox carInfoGroupBox;
        private System.Windows.Forms.TextBox mileageTextBox;
        private System.Windows.Forms.TextBox yearTexBox;
        private System.Windows.Forms.TextBox mileTextBox;
        private System.Windows.Forms.Label milePromptLabel;
        private System.Windows.Forms.Label yearPromptLabel;
        private System.Windows.Forms.Label makePromptLabel;
        private System.Windows.Forms.Button AddCarButton;
        private System.Windows.Forms.ListBox carListBox1;
        private System.Windows.Forms.Button button1;
    }
}

