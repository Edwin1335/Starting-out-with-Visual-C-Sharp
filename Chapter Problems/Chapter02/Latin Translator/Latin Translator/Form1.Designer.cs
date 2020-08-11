namespace Latin_Translator
{
    partial class latinTranslatorForm
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
            this.latinLabel = new System.Windows.Forms.Label();
            this.englishLabel = new System.Windows.Forms.Label();
            this.sinisterButton = new System.Windows.Forms.Button();
            this.englishAnwer = new System.Windows.Forms.Label();
            this.dexterButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // latinLabel
            // 
            this.latinLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.latinLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latinLabel.Location = new System.Drawing.Point(106, 50);
            this.latinLabel.Name = "latinLabel";
            this.latinLabel.Size = new System.Drawing.Size(120, 38);
            this.latinLabel.TabIndex = 0;
            this.latinLabel.Text = "Latin";
            this.latinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // englishLabel
            // 
            this.englishLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.englishLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishLabel.Location = new System.Drawing.Point(537, 50);
            this.englishLabel.Name = "englishLabel";
            this.englishLabel.Size = new System.Drawing.Size(120, 38);
            this.englishLabel.TabIndex = 1;
            this.englishLabel.Text = "English";
            this.englishLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sinisterButton
            // 
            this.sinisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sinisterButton.Location = new System.Drawing.Point(111, 143);
            this.sinisterButton.Name = "sinisterButton";
            this.sinisterButton.Size = new System.Drawing.Size(115, 52);
            this.sinisterButton.TabIndex = 2;
            this.sinisterButton.Text = "Sinister";
            this.sinisterButton.UseVisualStyleBackColor = true;
            this.sinisterButton.Click += new System.EventHandler(this.sinisterButton_Click);
            // 
            // englishAnwer
            // 
            this.englishAnwer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.englishAnwer.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishAnwer.Location = new System.Drawing.Point(537, 233);
            this.englishAnwer.Name = "englishAnwer";
            this.englishAnwer.Size = new System.Drawing.Size(120, 38);
            this.englishAnwer.TabIndex = 3;
            this.englishAnwer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.englishAnwer.Visible = false;
            // 
            // dexterButton
            // 
            this.dexterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dexterButton.Location = new System.Drawing.Point(111, 233);
            this.dexterButton.Name = "dexterButton";
            this.dexterButton.Size = new System.Drawing.Size(115, 52);
            this.dexterButton.TabIndex = 4;
            this.dexterButton.Text = "Dexter";
            this.dexterButton.UseVisualStyleBackColor = true;
            this.dexterButton.Click += new System.EventHandler(this.dexterButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mediumButton.Location = new System.Drawing.Point(111, 326);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(115, 52);
            this.mediumButton.TabIndex = 5;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Location = new System.Drawing.Point(542, 326);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(115, 52);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Close";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // latinTranslatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.dexterButton);
            this.Controls.Add(this.englishAnwer);
            this.Controls.Add(this.sinisterButton);
            this.Controls.Add(this.englishLabel);
            this.Controls.Add(this.latinLabel);
            this.Name = "latinTranslatorForm";
            this.Text = "Latin Translator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label latinLabel;
        private System.Windows.Forms.Label englishLabel;
        private System.Windows.Forms.Button sinisterButton;
        private System.Windows.Forms.Label englishAnwer;
        private System.Windows.Forms.Button dexterButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button exitButton;
    }
}

