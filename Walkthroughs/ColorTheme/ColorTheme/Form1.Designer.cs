namespace ColorTheme
{
    partial class colorThemeForm
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
            this.geenRadioButton = new System.Windows.Forms.RadioButton();
            this.yellowRadioButton = new System.Windows.Forms.RadioButton();
            this.grayRadioButton = new System.Windows.Forms.RadioButton();
            this.redradioButton = new System.Windows.Forms.RadioButton();
            this.blueRadioButton = new System.Windows.Forms.RadioButton();
            this.prmptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // geenRadioButton
            // 
            this.geenRadioButton.Checked = true;
            this.geenRadioButton.Location = new System.Drawing.Point(67, 72);
            this.geenRadioButton.Name = "geenRadioButton";
            this.geenRadioButton.Size = new System.Drawing.Size(104, 24);
            this.geenRadioButton.TabIndex = 0;
            this.geenRadioButton.Text = "Green";
            this.geenRadioButton.UseVisualStyleBackColor = true;
            this.geenRadioButton.CheckedChanged += new System.EventHandler(this.geenRadioButton_CheckedChanged);
            // 
            // yellowRadioButton
            // 
            this.yellowRadioButton.Location = new System.Drawing.Point(67, 102);
            this.yellowRadioButton.Name = "yellowRadioButton";
            this.yellowRadioButton.Size = new System.Drawing.Size(104, 24);
            this.yellowRadioButton.TabIndex = 1;
            this.yellowRadioButton.Text = "Yellow";
            this.yellowRadioButton.UseVisualStyleBackColor = true;
            this.yellowRadioButton.CheckedChanged += new System.EventHandler(this.yellowRadioButton_CheckedChanged);
            // 
            // grayRadioButton
            // 
            this.grayRadioButton.Location = new System.Drawing.Point(67, 132);
            this.grayRadioButton.Name = "grayRadioButton";
            this.grayRadioButton.Size = new System.Drawing.Size(104, 24);
            this.grayRadioButton.TabIndex = 2;
            this.grayRadioButton.Text = "Gray";
            this.grayRadioButton.UseVisualStyleBackColor = true;
            this.grayRadioButton.CheckedChanged += new System.EventHandler(this.grayRadioButton_CheckedChanged);
            // 
            // redradioButton
            // 
            this.redradioButton.Location = new System.Drawing.Point(67, 162);
            this.redradioButton.Name = "redradioButton";
            this.redradioButton.Size = new System.Drawing.Size(104, 24);
            this.redradioButton.TabIndex = 3;
            this.redradioButton.Text = "Red";
            this.redradioButton.UseVisualStyleBackColor = true;
            this.redradioButton.CheckedChanged += new System.EventHandler(this.redradioButton_CheckedChanged);
            // 
            // blueRadioButton
            // 
            this.blueRadioButton.Location = new System.Drawing.Point(67, 192);
            this.blueRadioButton.Name = "blueRadioButton";
            this.blueRadioButton.Size = new System.Drawing.Size(104, 24);
            this.blueRadioButton.TabIndex = 4;
            this.blueRadioButton.Text = "Blue";
            this.blueRadioButton.UseVisualStyleBackColor = true;
            this.blueRadioButton.CheckedChanged += new System.EventHandler(this.blueRadioButton_CheckedChanged);
            // 
            // prmptLabel
            // 
            this.prmptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prmptLabel.Location = new System.Drawing.Point(30, 9);
            this.prmptLabel.Name = "prmptLabel";
            this.prmptLabel.Size = new System.Drawing.Size(141, 42);
            this.prmptLabel.TabIndex = 5;
            this.prmptLabel.Text = "Choose a background color";
            this.prmptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorThemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 322);
            this.Controls.Add(this.prmptLabel);
            this.Controls.Add(this.blueRadioButton);
            this.Controls.Add(this.redradioButton);
            this.Controls.Add(this.grayRadioButton);
            this.Controls.Add(this.yellowRadioButton);
            this.Controls.Add(this.geenRadioButton);
            this.Name = "colorThemeForm";
            this.Text = "Color Theme ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton geenRadioButton;
        private System.Windows.Forms.RadioButton yellowRadioButton;
        private System.Windows.Forms.RadioButton grayRadioButton;
        private System.Windows.Forms.RadioButton redradioButton;
        private System.Windows.Forms.RadioButton blueRadioButton;
        private System.Windows.Forms.Label prmptLabel;
    }
}

