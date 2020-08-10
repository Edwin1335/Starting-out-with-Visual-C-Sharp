namespace Language_Translator
{
    partial class Form1
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.translationLabel = new System.Windows.Forms.Label();
            this.italianButton = new System.Windows.Forms.Button();
            this.germanButton = new System.Windows.Forms.Button();
            this.spanishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(100, 31);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(607, 48);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Select a langiage and I will say Good Morning.";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // translationLabel
            // 
            this.translationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translationLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translationLabel.Location = new System.Drawing.Point(100, 130);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(607, 45);
            this.translationLabel.TabIndex = 1;
            this.translationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // italianButton
            // 
            this.italianButton.BackColor = System.Drawing.Color.MistyRose;
            this.italianButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italianButton.Location = new System.Drawing.Point(100, 229);
            this.italianButton.Name = "italianButton";
            this.italianButton.Size = new System.Drawing.Size(141, 47);
            this.italianButton.TabIndex = 2;
            this.italianButton.Text = "Italian";
            this.italianButton.UseVisualStyleBackColor = false;
            this.italianButton.Click += new System.EventHandler(this.italianButton_Click);
            // 
            // germanButton
            // 
            this.germanButton.BackColor = System.Drawing.Color.Bisque;
            this.germanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.germanButton.Location = new System.Drawing.Point(566, 229);
            this.germanButton.Name = "germanButton";
            this.germanButton.Size = new System.Drawing.Size(141, 47);
            this.germanButton.TabIndex = 3;
            this.germanButton.Text = "German";
            this.germanButton.UseVisualStyleBackColor = false;
            this.germanButton.Click += new System.EventHandler(this.germanButton_Click);
            // 
            // spanishButton
            // 
            this.spanishButton.BackColor = System.Drawing.Color.Coral;
            this.spanishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spanishButton.Location = new System.Drawing.Point(332, 229);
            this.spanishButton.Name = "spanishButton";
            this.spanishButton.Size = new System.Drawing.Size(141, 47);
            this.spanishButton.TabIndex = 4;
            this.spanishButton.Text = "Spanish";
            this.spanishButton.UseVisualStyleBackColor = false;
            this.spanishButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spanishButton);
            this.Controls.Add(this.germanButton);
            this.Controls.Add(this.italianButton);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.instructionLabel);
            this.Name = "Form1";
            this.Text = "Language Translator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label translationLabel;
        private System.Windows.Forms.Button italianButton;
        private System.Windows.Forms.Button germanButton;
        private System.Windows.Forms.Button spanishButton;
    }
}

