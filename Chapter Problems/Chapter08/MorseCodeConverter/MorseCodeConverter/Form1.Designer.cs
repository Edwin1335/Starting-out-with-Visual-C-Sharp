namespace MorseCodeConverter
{
    partial class MorseConverterFrom
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
            this.stringPromptLabel = new System.Windows.Forms.Label();
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.morseOutputLabel = new System.Windows.Forms.Label();
            this.morseLabel = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stringPromptLabel
            // 
            this.stringPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringPromptLabel.Location = new System.Drawing.Point(12, 24);
            this.stringPromptLabel.Name = "stringPromptLabel";
            this.stringPromptLabel.Size = new System.Drawing.Size(140, 37);
            this.stringPromptLabel.TabIndex = 0;
            this.stringPromptLabel.Text = "Enter String";
            this.stringPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stringTextBox
            // 
            this.stringTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringTextBox.Location = new System.Drawing.Point(176, 33);
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(202, 21);
            this.stringTextBox.TabIndex = 1;
            // 
            // morseOutputLabel
            // 
            this.morseOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morseOutputLabel.Location = new System.Drawing.Point(12, 61);
            this.morseOutputLabel.Name = "morseOutputLabel";
            this.morseOutputLabel.Size = new System.Drawing.Size(140, 37);
            this.morseOutputLabel.TabIndex = 2;
            this.morseOutputLabel.Text = "Morse Code";
            this.morseOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // morseLabel
            // 
            this.morseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.morseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morseLabel.Location = new System.Drawing.Point(176, 68);
            this.morseLabel.Name = "morseLabel";
            this.morseLabel.Size = new System.Drawing.Size(202, 22);
            this.morseLabel.TabIndex = 3;
            this.morseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(121, 108);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(95, 31);
            this.ConvertButton.TabIndex = 4;
            this.ConvertButton.Text = "Convert ";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(262, 108);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(95, 31);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MorseConverterFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 151);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.morseLabel);
            this.Controls.Add(this.morseOutputLabel);
            this.Controls.Add(this.stringTextBox);
            this.Controls.Add(this.stringPromptLabel);
            this.Name = "MorseConverterFrom";
            this.Text = "Morse Code Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stringPromptLabel;
        private System.Windows.Forms.TextBox stringTextBox;
        private System.Windows.Forms.Label morseOutputLabel;
        private System.Windows.Forms.Label morseLabel;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

