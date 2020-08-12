namespace CardMethod
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
            this.queenPictureBox = new System.Windows.Forms.PictureBox();
            this.threePictureBox = new System.Windows.Forms.PictureBox();
            this.acePictureBox = new System.Windows.Forms.PictureBox();
            this.chooseListBox = new System.Windows.Forms.ListBox();
            this.revealButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.queenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // queenPictureBox
            // 
            this.queenPictureBox.Image = global::CardMethod.Properties.Resources.poker_playing_card_queen_diamond_miroslav_nemecek_transparent;
            this.queenPictureBox.Location = new System.Drawing.Point(35, 44);
            this.queenPictureBox.Name = "queenPictureBox";
            this.queenPictureBox.Size = new System.Drawing.Size(198, 255);
            this.queenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.queenPictureBox.TabIndex = 0;
            this.queenPictureBox.TabStop = false;
            this.queenPictureBox.Visible = false;
            // 
            // threePictureBox
            // 
            this.threePictureBox.Image = global::CardMethod.Properties.Resources.poker_playing_card_3;
            this.threePictureBox.Location = new System.Drawing.Point(289, 44);
            this.threePictureBox.Name = "threePictureBox";
            this.threePictureBox.Size = new System.Drawing.Size(198, 255);
            this.threePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.threePictureBox.TabIndex = 1;
            this.threePictureBox.TabStop = false;
            this.threePictureBox.Visible = false;
            // 
            // acePictureBox
            // 
            this.acePictureBox.Image = global::CardMethod.Properties.Resources.poker_playing_card_ace_spade_miroslav_nemecek_transparent;
            this.acePictureBox.Location = new System.Drawing.Point(549, 44);
            this.acePictureBox.Name = "acePictureBox";
            this.acePictureBox.Size = new System.Drawing.Size(198, 255);
            this.acePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.acePictureBox.TabIndex = 2;
            this.acePictureBox.TabStop = false;
            this.acePictureBox.Visible = false;
            // 
            // chooseListBox
            // 
            this.chooseListBox.FormattingEnabled = true;
            this.chooseListBox.ItemHeight = 25;
            this.chooseListBox.Items.AddRange(new object[] {
            "Queen Card",
            "Three Card",
            "Ace Card"});
            this.chooseListBox.Location = new System.Drawing.Point(234, 344);
            this.chooseListBox.Name = "chooseListBox";
            this.chooseListBox.Size = new System.Drawing.Size(322, 129);
            this.chooseListBox.TabIndex = 3;
            // 
            // revealButton
            // 
            this.revealButton.Location = new System.Drawing.Point(160, 506);
            this.revealButton.Name = "revealButton";
            this.revealButton.Size = new System.Drawing.Size(177, 80);
            this.revealButton.TabIndex = 4;
            this.revealButton.Text = "Reveal Card";
            this.revealButton.UseVisualStyleBackColor = true;
            this.revealButton.Click += new System.EventHandler(this.revealButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(425, 506);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(177, 80);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.revealButton);
            this.Controls.Add(this.chooseListBox);
            this.Controls.Add(this.acePictureBox);
            this.Controls.Add(this.threePictureBox);
            this.Controls.Add(this.queenPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.queenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox queenPictureBox;
        private System.Windows.Forms.PictureBox threePictureBox;
        private System.Windows.Forms.PictureBox acePictureBox;
        private System.Windows.Forms.ListBox chooseListBox;
        private System.Windows.Forms.Button revealButton;
        private System.Windows.Forms.Button exitButton;
    }
}

