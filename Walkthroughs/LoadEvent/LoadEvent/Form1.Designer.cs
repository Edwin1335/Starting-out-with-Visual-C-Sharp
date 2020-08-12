namespace LoadEvent
{
    partial class southAmericaForm
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
            this.countriesLabel = new System.Windows.Forms.Label();
            this.countriesListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countriesLabel
            // 
            this.countriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countriesLabel.Location = new System.Drawing.Point(27, 9);
            this.countriesLabel.Name = "countriesLabel";
            this.countriesLabel.Size = new System.Drawing.Size(218, 21);
            this.countriesLabel.TabIndex = 0;
            this.countriesLabel.Text = "The Countries of South America";
            this.countriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countriesListBox
            // 
            this.countriesListBox.FormattingEnabled = true;
            this.countriesListBox.Location = new System.Drawing.Point(51, 48);
            this.countriesListBox.Name = "countriesListBox";
            this.countriesListBox.Size = new System.Drawing.Size(179, 108);
            this.countriesListBox.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(76, 177);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 40);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // southAmericaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 243);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.countriesListBox);
            this.Controls.Add(this.countriesLabel);
            this.Name = "southAmericaForm";
            this.Text = "South America";
            this.Load += new System.EventHandler(this.southAmericaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label countriesLabel;
        private System.Windows.Forms.ListBox countriesListBox;
        private System.Windows.Forms.Button exitButton;
    }
}

