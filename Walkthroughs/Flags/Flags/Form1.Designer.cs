namespace Flags
{
    partial class catsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.memePictureBox = new System.Windows.Forms.PictureBox();
            this.catPictureBox = new System.Windows.Forms.PictureBox();
            this.batmanPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.memePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batmanPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click the image to display message";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memePictureBox
            // 
            this.memePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memePictureBox.Image = global::Flags.Properties.Resources.aKVdR9Rb_700w_0;
            this.memePictureBox.Location = new System.Drawing.Point(552, 131);
            this.memePictureBox.Name = "memePictureBox";
            this.memePictureBox.Size = new System.Drawing.Size(176, 159);
            this.memePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.memePictureBox.TabIndex = 3;
            this.memePictureBox.TabStop = false;
            this.memePictureBox.Click += new System.EventHandler(this.memePictureBox_Click);
            // 
            // catPictureBox
            // 
            this.catPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.catPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catPictureBox.Image = global::Flags.Properties.Resources.brown_tabby_cat_sitting_on_brown_wooden_stool_3885948;
            this.catPictureBox.Location = new System.Drawing.Point(329, 131);
            this.catPictureBox.Name = "catPictureBox";
            this.catPictureBox.Size = new System.Drawing.Size(176, 159);
            this.catPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.catPictureBox.TabIndex = 2;
            this.catPictureBox.TabStop = false;
            this.catPictureBox.Click += new System.EventHandler(this.catPictureBox_Click);
            // 
            // batmanPictureBox
            // 
            this.batmanPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.batmanPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.batmanPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.batmanPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.batmanPictureBox.Image = global::Flags.Properties.Resources.Batman;
            this.batmanPictureBox.Location = new System.Drawing.Point(104, 131);
            this.batmanPictureBox.Name = "batmanPictureBox";
            this.batmanPictureBox.Size = new System.Drawing.Size(176, 159);
            this.batmanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.batmanPictureBox.TabIndex = 1;
            this.batmanPictureBox.TabStop = false;
            this.batmanPictureBox.Click += new System.EventHandler(this.batmanPictureBox_Click);
            // 
            // catsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.memePictureBox);
            this.Controls.Add(this.catPictureBox);
            this.Controls.Add(this.batmanPictureBox);
            this.Controls.Add(this.label1);
            this.Name = "catsForm";
            this.Text = "Cats ";
            ((System.ComponentModel.ISupportInitialize)(this.memePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batmanPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox batmanPictureBox;
        private System.Windows.Forms.PictureBox catPictureBox;
        private System.Windows.Forms.PictureBox memePictureBox;
    }
}

