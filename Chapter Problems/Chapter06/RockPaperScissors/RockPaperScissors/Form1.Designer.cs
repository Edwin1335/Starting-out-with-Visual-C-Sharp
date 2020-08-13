namespace RockPaperScissors
{
    partial class rockPaperScissorForm
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
            this.playerChooseLabel = new System.Windows.Forms.Label();
            this.playerRockPictureBox = new System.Windows.Forms.PictureBox();
            this.playerpaperPictureBox = new System.Windows.Forms.PictureBox();
            this.playerScissorPictureBox = new System.Windows.Forms.PictureBox();
            this.computerRockPictureBox = new System.Windows.Forms.PictureBox();
            this.computerPaperPictureBox = new System.Windows.Forms.PictureBox();
            this.computerScissorPictureBox = new System.Windows.Forms.PictureBox();
            this.computerChoiceLabel = new System.Windows.Forms.Label();
            this.rockradoButton = new System.Windows.Forms.RadioButton();
            this.paperRadioButton = new System.Windows.Forms.RadioButton();
            this.scissorRadioButton = new System.Windows.Forms.RadioButton();
            this.playButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerRockPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerpaperPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerScissorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerRockPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPaperPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerScissorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playerChooseLabel
            // 
            this.playerChooseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerChooseLabel.Location = new System.Drawing.Point(79, 24);
            this.playerChooseLabel.Name = "playerChooseLabel";
            this.playerChooseLabel.Size = new System.Drawing.Size(187, 29);
            this.playerChooseLabel.TabIndex = 0;
            this.playerChooseLabel.Text = "Choose Rock Paper or Scissors";
            // 
            // playerRockPictureBox
            // 
            this.playerRockPictureBox.Image = global::RockPaperScissors.Properties.Resources.Rock_Hand;
            this.playerRockPictureBox.Location = new System.Drawing.Point(25, 82);
            this.playerRockPictureBox.Name = "playerRockPictureBox";
            this.playerRockPictureBox.Size = new System.Drawing.Size(81, 81);
            this.playerRockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerRockPictureBox.TabIndex = 1;
            this.playerRockPictureBox.TabStop = false;
            // 
            // playerpaperPictureBox
            // 
            this.playerpaperPictureBox.Image = global::RockPaperScissors.Properties.Resources.Paper_Hand;
            this.playerpaperPictureBox.Location = new System.Drawing.Point(128, 82);
            this.playerpaperPictureBox.Name = "playerpaperPictureBox";
            this.playerpaperPictureBox.Size = new System.Drawing.Size(85, 81);
            this.playerpaperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerpaperPictureBox.TabIndex = 2;
            this.playerpaperPictureBox.TabStop = false;
            // 
            // playerScissorPictureBox
            // 
            this.playerScissorPictureBox.Image = global::RockPaperScissors.Properties.Resources.Sissors_Hand;
            this.playerScissorPictureBox.Location = new System.Drawing.Point(240, 82);
            this.playerScissorPictureBox.Name = "playerScissorPictureBox";
            this.playerScissorPictureBox.Size = new System.Drawing.Size(81, 81);
            this.playerScissorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerScissorPictureBox.TabIndex = 3;
            this.playerScissorPictureBox.TabStop = false;
            // 
            // computerRockPictureBox
            // 
            this.computerRockPictureBox.Image = global::RockPaperScissors.Properties.Resources.Rock_Hand;
            this.computerRockPictureBox.Location = new System.Drawing.Point(25, 227);
            this.computerRockPictureBox.Name = "computerRockPictureBox";
            this.computerRockPictureBox.Size = new System.Drawing.Size(81, 81);
            this.computerRockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.computerRockPictureBox.TabIndex = 4;
            this.computerRockPictureBox.TabStop = false;
            this.computerRockPictureBox.Visible = false;
            // 
            // computerPaperPictureBox
            // 
            this.computerPaperPictureBox.Image = global::RockPaperScissors.Properties.Resources.Paper_Hand;
            this.computerPaperPictureBox.Location = new System.Drawing.Point(128, 227);
            this.computerPaperPictureBox.Name = "computerPaperPictureBox";
            this.computerPaperPictureBox.Size = new System.Drawing.Size(85, 81);
            this.computerPaperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.computerPaperPictureBox.TabIndex = 5;
            this.computerPaperPictureBox.TabStop = false;
            this.computerPaperPictureBox.Visible = false;
            // 
            // computerScissorPictureBox
            // 
            this.computerScissorPictureBox.Image = global::RockPaperScissors.Properties.Resources.Sissors_Hand;
            this.computerScissorPictureBox.Location = new System.Drawing.Point(240, 227);
            this.computerScissorPictureBox.Name = "computerScissorPictureBox";
            this.computerScissorPictureBox.Size = new System.Drawing.Size(81, 81);
            this.computerScissorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.computerScissorPictureBox.TabIndex = 6;
            this.computerScissorPictureBox.TabStop = false;
            this.computerScissorPictureBox.Visible = false;
            // 
            // computerChoiceLabel
            // 
            this.computerChoiceLabel.AutoSize = true;
            this.computerChoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerChoiceLabel.Location = new System.Drawing.Point(116, 198);
            this.computerChoiceLabel.Name = "computerChoiceLabel";
            this.computerChoiceLabel.Size = new System.Drawing.Size(115, 15);
            this.computerChoiceLabel.TabIndex = 7;
            this.computerChoiceLabel.Text = "Computer Choose : ";
            this.computerChoiceLabel.Visible = false;
            // 
            // rockradoButton
            // 
            this.rockradoButton.AutoSize = true;
            this.rockradoButton.Checked = true;
            this.rockradoButton.Location = new System.Drawing.Point(25, 59);
            this.rockradoButton.Name = "rockradoButton";
            this.rockradoButton.Size = new System.Drawing.Size(51, 17);
            this.rockradoButton.TabIndex = 8;
            this.rockradoButton.TabStop = true;
            this.rockradoButton.Text = "Rock";
            this.rockradoButton.UseVisualStyleBackColor = true;
            // 
            // paperRadioButton
            // 
            this.paperRadioButton.AutoSize = true;
            this.paperRadioButton.Location = new System.Drawing.Point(128, 59);
            this.paperRadioButton.Name = "paperRadioButton";
            this.paperRadioButton.Size = new System.Drawing.Size(53, 17);
            this.paperRadioButton.TabIndex = 9;
            this.paperRadioButton.Text = "Paper";
            this.paperRadioButton.UseVisualStyleBackColor = true;
            // 
            // scissorRadioButton
            // 
            this.scissorRadioButton.AutoSize = true;
            this.scissorRadioButton.Location = new System.Drawing.Point(242, 59);
            this.scissorRadioButton.Name = "scissorRadioButton";
            this.scissorRadioButton.Size = new System.Drawing.Size(64, 17);
            this.scissorRadioButton.TabIndex = 10;
            this.scissorRadioButton.Text = "Scissors";
            this.scissorRadioButton.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(64, 374);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(88, 39);
            this.playButton.TabIndex = 11;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(178, 374);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(88, 39);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // rockPaperScissorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.scissorRadioButton);
            this.Controls.Add(this.paperRadioButton);
            this.Controls.Add(this.rockradoButton);
            this.Controls.Add(this.computerChoiceLabel);
            this.Controls.Add(this.computerScissorPictureBox);
            this.Controls.Add(this.computerPaperPictureBox);
            this.Controls.Add(this.computerRockPictureBox);
            this.Controls.Add(this.playerScissorPictureBox);
            this.Controls.Add(this.playerpaperPictureBox);
            this.Controls.Add(this.playerRockPictureBox);
            this.Controls.Add(this.playerChooseLabel);
            this.Name = "rockPaperScissorForm";
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.playerRockPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerpaperPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerScissorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerRockPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPaperPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerScissorPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerChooseLabel;
        private System.Windows.Forms.PictureBox playerRockPictureBox;
        private System.Windows.Forms.PictureBox playerpaperPictureBox;
        private System.Windows.Forms.PictureBox playerScissorPictureBox;
        private System.Windows.Forms.PictureBox computerRockPictureBox;
        private System.Windows.Forms.PictureBox computerPaperPictureBox;
        private System.Windows.Forms.PictureBox computerScissorPictureBox;
        private System.Windows.Forms.Label computerChoiceLabel;
        private System.Windows.Forms.RadioButton rockradoButton;
        private System.Windows.Forms.RadioButton paperRadioButton;
        private System.Windows.Forms.RadioButton scissorRadioButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
    }
}

