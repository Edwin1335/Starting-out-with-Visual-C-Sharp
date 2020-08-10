namespace Card_Flip
{
    partial class cardFlipForm
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
            this.frontCardPictureBox = new System.Windows.Forms.PictureBox();
            this.backCardPictureBox = new System.Windows.Forms.PictureBox();
            this.backCardButton = new System.Windows.Forms.Button();
            this.frontCardButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.frontCardPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backCardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // frontCardPictureBox
            // 
            this.frontCardPictureBox.Image = global::Card_Flip.Properties.Resources.poker_playing_card_ace_spade_miroslav_nemecek_transparent;
            this.frontCardPictureBox.Location = new System.Drawing.Point(344, 37);
            this.frontCardPictureBox.Name = "frontCardPictureBox";
            this.frontCardPictureBox.Size = new System.Drawing.Size(259, 373);
            this.frontCardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frontCardPictureBox.TabIndex = 1;
            this.frontCardPictureBox.TabStop = false;
            // 
            // backCardPictureBox
            // 
            this.backCardPictureBox.Image = global::Card_Flip.Properties.Resources._9a2c89aa92f44afcb61962708c95cfa4_front;
            this.backCardPictureBox.Location = new System.Drawing.Point(50, 37);
            this.backCardPictureBox.Name = "backCardPictureBox";
            this.backCardPictureBox.Size = new System.Drawing.Size(259, 373);
            this.backCardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backCardPictureBox.TabIndex = 0;
            this.backCardPictureBox.TabStop = false;
            // 
            // backCardButton
            // 
            this.backCardButton.Location = new System.Drawing.Point(104, 450);
            this.backCardButton.Name = "backCardButton";
            this.backCardButton.Size = new System.Drawing.Size(151, 50);
            this.backCardButton.TabIndex = 2;
            this.backCardButton.Text = "Show the Card Back";
            this.backCardButton.UseVisualStyleBackColor = true;
            this.backCardButton.Click += new System.EventHandler(this.backCardButton_Click);
            // 
            // frontCardButton
            // 
            this.frontCardButton.Location = new System.Drawing.Point(397, 450);
            this.frontCardButton.Name = "frontCardButton";
            this.frontCardButton.Size = new System.Drawing.Size(151, 50);
            this.frontCardButton.TabIndex = 3;
            this.frontCardButton.Text = "Show the Card Front";
            this.frontCardButton.UseVisualStyleBackColor = true;
            this.frontCardButton.Click += new System.EventHandler(this.frontCardButton_Click);
            // 
            // cardFlipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 579);
            this.Controls.Add(this.frontCardButton);
            this.Controls.Add(this.backCardButton);
            this.Controls.Add(this.frontCardPictureBox);
            this.Controls.Add(this.backCardPictureBox);
            this.Name = "cardFlipForm";
            this.Text = "Card Flip";
            ((System.ComponentModel.ISupportInitialize)(this.frontCardPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backCardPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox backCardPictureBox;
        private System.Windows.Forms.PictureBox frontCardPictureBox;
        private System.Windows.Forms.Button backCardButton;
        private System.Windows.Forms.Button frontCardButton;
    }
}

