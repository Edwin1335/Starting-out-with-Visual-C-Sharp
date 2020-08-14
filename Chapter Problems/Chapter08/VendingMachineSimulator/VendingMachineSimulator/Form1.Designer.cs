namespace VendingMachineSimulator
{
    partial class VendingMachineForm
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
            this.CocaColaGroupBox = new System.Windows.Forms.GroupBox();
            this.colaItemsLabel = new System.Windows.Forms.Label();
            this.colaItemsTitleLabel = new System.Windows.Forms.Label();
            this.colaPriceLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.FantaGroupBox = new System.Windows.Forms.GroupBox();
            this.fantaItemsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RootGroupBox = new System.Windows.Forms.GroupBox();
            this.rootItemsLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SpriteGroupBox = new System.Windows.Forms.GroupBox();
            this.spriteItemsLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.WaterGroupBox = new System.Windows.Forms.GroupBox();
            this.waterItemsLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.TotalGroupBox = new System.Windows.Forms.GroupBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalDisplaylabel = new System.Windows.Forms.Label();
            this.PurchaseButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CocaColaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.FantaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.RootGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SpriteGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.WaterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.TotalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CocaColaGroupBox
            // 
            this.CocaColaGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.CocaColaGroupBox.Controls.Add(this.colaItemsLabel);
            this.CocaColaGroupBox.Controls.Add(this.colaItemsTitleLabel);
            this.CocaColaGroupBox.Controls.Add(this.colaPriceLabel);
            this.CocaColaGroupBox.Controls.Add(this.pictureBox1);
            this.CocaColaGroupBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CocaColaGroupBox.Location = new System.Drawing.Point(26, 66);
            this.CocaColaGroupBox.Name = "CocaColaGroupBox";
            this.CocaColaGroupBox.Size = new System.Drawing.Size(144, 127);
            this.CocaColaGroupBox.TabIndex = 0;
            this.CocaColaGroupBox.TabStop = false;
            this.CocaColaGroupBox.Text = "Coca Cola";
            this.CocaColaGroupBox.Enter += new System.EventHandler(this.CocaColaGroupBox_Enter);
            // 
            // colaItemsLabel
            // 
            this.colaItemsLabel.BackColor = System.Drawing.Color.White;
            this.colaItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colaItemsLabel.Location = new System.Drawing.Point(68, 71);
            this.colaItemsLabel.Name = "colaItemsLabel";
            this.colaItemsLabel.Size = new System.Drawing.Size(70, 28);
            this.colaItemsLabel.TabIndex = 3;
            this.colaItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colaItemsTitleLabel
            // 
            this.colaItemsTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colaItemsTitleLabel.Location = new System.Drawing.Point(68, 43);
            this.colaItemsTitleLabel.Name = "colaItemsTitleLabel";
            this.colaItemsTitleLabel.Size = new System.Drawing.Size(70, 28);
            this.colaItemsTitleLabel.TabIndex = 2;
            this.colaItemsTitleLabel.Text = "Drinks Left";
            this.colaItemsTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colaPriceLabel
            // 
            this.colaPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colaPriceLabel.Location = new System.Drawing.Point(81, 16);
            this.colaPriceLabel.Name = "colaPriceLabel";
            this.colaPriceLabel.Size = new System.Drawing.Size(57, 17);
            this.colaPriceLabel.TabIndex = 1;
            this.colaPriceLabel.Text = "$1.00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VendingMachineSimulator.Properties.Resources.coke_original_12oz_mobile;
            this.pictureBox1.Location = new System.Drawing.Point(9, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(135, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(112, 29);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Select a Drink";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FantaGroupBox
            // 
            this.FantaGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(134)))), ((int)(((byte)(82)))));
            this.FantaGroupBox.Controls.Add(this.fantaItemsLabel);
            this.FantaGroupBox.Controls.Add(this.label2);
            this.FantaGroupBox.Controls.Add(this.label3);
            this.FantaGroupBox.Controls.Add(this.pictureBox2);
            this.FantaGroupBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FantaGroupBox.Location = new System.Drawing.Point(210, 66);
            this.FantaGroupBox.Name = "FantaGroupBox";
            this.FantaGroupBox.Size = new System.Drawing.Size(144, 127);
            this.FantaGroupBox.TabIndex = 2;
            this.FantaGroupBox.TabStop = false;
            this.FantaGroupBox.Text = "Fanta";
            this.FantaGroupBox.Enter += new System.EventHandler(this.FantaGroupBox_Enter);
            // 
            // fantaItemsLabel
            // 
            this.fantaItemsLabel.BackColor = System.Drawing.Color.White;
            this.fantaItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fantaItemsLabel.Location = new System.Drawing.Point(68, 71);
            this.fantaItemsLabel.Name = "fantaItemsLabel";
            this.fantaItemsLabel.Size = new System.Drawing.Size(70, 28);
            this.fantaItemsLabel.TabIndex = 3;
            this.fantaItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Drinks Left";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "$1.00";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VendingMachineSimulator.Properties.Resources.orange_fanta_soda;
            this.pictureBox2.Location = new System.Drawing.Point(9, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // RootGroupBox
            // 
            this.RootGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(123)))), ((int)(((byte)(71)))));
            this.RootGroupBox.Controls.Add(this.rootItemsLabel);
            this.RootGroupBox.Controls.Add(this.label5);
            this.RootGroupBox.Controls.Add(this.label6);
            this.RootGroupBox.Controls.Add(this.pictureBox3);
            this.RootGroupBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RootGroupBox.Location = new System.Drawing.Point(26, 225);
            this.RootGroupBox.Name = "RootGroupBox";
            this.RootGroupBox.Size = new System.Drawing.Size(144, 127);
            this.RootGroupBox.TabIndex = 3;
            this.RootGroupBox.TabStop = false;
            this.RootGroupBox.Text = "Root Beer";
            this.RootGroupBox.Enter += new System.EventHandler(this.RootGroupBox_Enter);
            // 
            // rootItemsLabel
            // 
            this.rootItemsLabel.BackColor = System.Drawing.Color.White;
            this.rootItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rootItemsLabel.Location = new System.Drawing.Point(68, 71);
            this.rootItemsLabel.Name = "rootItemsLabel";
            this.rootItemsLabel.Size = new System.Drawing.Size(70, 28);
            this.rootItemsLabel.TabIndex = 3;
            this.rootItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Drinks Left";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "$1.00";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::VendingMachineSimulator.Properties.Resources.rooteBeer;
            this.pictureBox3.Location = new System.Drawing.Point(9, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // SpriteGroupBox
            // 
            this.SpriteGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(199)))), ((int)(((byte)(160)))));
            this.SpriteGroupBox.Controls.Add(this.spriteItemsLabel);
            this.SpriteGroupBox.Controls.Add(this.label8);
            this.SpriteGroupBox.Controls.Add(this.label9);
            this.SpriteGroupBox.Controls.Add(this.pictureBox4);
            this.SpriteGroupBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpriteGroupBox.Location = new System.Drawing.Point(210, 225);
            this.SpriteGroupBox.Name = "SpriteGroupBox";
            this.SpriteGroupBox.Size = new System.Drawing.Size(144, 127);
            this.SpriteGroupBox.TabIndex = 4;
            this.SpriteGroupBox.TabStop = false;
            this.SpriteGroupBox.Text = "Sprite";
            this.SpriteGroupBox.Enter += new System.EventHandler(this.SpriteGroupBox_Enter);
            // 
            // spriteItemsLabel
            // 
            this.spriteItemsLabel.BackColor = System.Drawing.Color.White;
            this.spriteItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spriteItemsLabel.Location = new System.Drawing.Point(68, 71);
            this.spriteItemsLabel.Name = "spriteItemsLabel";
            this.spriteItemsLabel.Size = new System.Drawing.Size(70, 28);
            this.spriteItemsLabel.TabIndex = 3;
            this.spriteItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Drinks Left";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(81, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "$1.00";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::VendingMachineSimulator.Properties.Resources.Sprite_1024x1024_cdd75869_30f6_42f3_b7d8_a36974ac3f89_1024x;
            this.pictureBox4.Location = new System.Drawing.Point(9, 26);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 83);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // WaterGroupBox
            // 
            this.WaterGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(187)))), ((int)(((byte)(199)))));
            this.WaterGroupBox.Controls.Add(this.waterItemsLabel);
            this.WaterGroupBox.Controls.Add(this.label11);
            this.WaterGroupBox.Controls.Add(this.label12);
            this.WaterGroupBox.Controls.Add(this.pictureBox5);
            this.WaterGroupBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WaterGroupBox.Location = new System.Drawing.Point(26, 387);
            this.WaterGroupBox.Name = "WaterGroupBox";
            this.WaterGroupBox.Size = new System.Drawing.Size(144, 127);
            this.WaterGroupBox.TabIndex = 5;
            this.WaterGroupBox.TabStop = false;
            this.WaterGroupBox.Text = "Water";
            this.WaterGroupBox.Enter += new System.EventHandler(this.WaterGroupBox_Enter);
            // 
            // waterItemsLabel
            // 
            this.waterItemsLabel.BackColor = System.Drawing.Color.White;
            this.waterItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterItemsLabel.Location = new System.Drawing.Point(68, 71);
            this.waterItemsLabel.Name = "waterItemsLabel";
            this.waterItemsLabel.Size = new System.Drawing.Size(70, 28);
            this.waterItemsLabel.TabIndex = 3;
            this.waterItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(68, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 28);
            this.label11.TabIndex = 2;
            this.label11.Text = "Drinks Left";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(81, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "$0.95";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::VendingMachineSimulator.Properties.Resources.water;
            this.pictureBox5.Location = new System.Drawing.Point(9, 26);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(53, 83);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // TotalGroupBox
            // 
            this.TotalGroupBox.BackColor = System.Drawing.Color.Silver;
            this.TotalGroupBox.Controls.Add(this.totalLabel);
            this.TotalGroupBox.Controls.Add(this.totalDisplaylabel);
            this.TotalGroupBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TotalGroupBox.Location = new System.Drawing.Point(210, 387);
            this.TotalGroupBox.Name = "TotalGroupBox";
            this.TotalGroupBox.Size = new System.Drawing.Size(144, 127);
            this.TotalGroupBox.TabIndex = 6;
            this.TotalGroupBox.TabStop = false;
            this.TotalGroupBox.Text = "Total";
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.White;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(22, 61);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(106, 28);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalDisplaylabel
            // 
            this.totalDisplaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDisplaylabel.Location = new System.Drawing.Point(22, 33);
            this.totalDisplaylabel.Name = "totalDisplaylabel";
            this.totalDisplaylabel.Size = new System.Drawing.Size(70, 28);
            this.totalDisplaylabel.TabIndex = 2;
            this.totalDisplaylabel.Text = "Total";
            this.totalDisplaylabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PurchaseButton.Location = new System.Drawing.Point(55, 539);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Size = new System.Drawing.Size(115, 56);
            this.PurchaseButton.TabIndex = 7;
            this.PurchaseButton.Text = "Purchase";
            this.PurchaseButton.UseVisualStyleBackColor = true;
            this.PurchaseButton.Click += new System.EventHandler(this.PurchaseButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.Location = new System.Drawing.Point(210, 539);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(115, 56);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // VendingMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 651);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PurchaseButton);
            this.Controls.Add(this.TotalGroupBox);
            this.Controls.Add(this.WaterGroupBox);
            this.Controls.Add(this.SpriteGroupBox);
            this.Controls.Add(this.RootGroupBox);
            this.Controls.Add(this.FantaGroupBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.CocaColaGroupBox);
            this.Name = "VendingMachineForm";
            this.Text = "Vending Machine";
            this.Load += new System.EventHandler(this.VendingMachineForm_Load);
            this.CocaColaGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.FantaGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.RootGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.SpriteGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.WaterGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.TotalGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CocaColaGroupBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label colaPriceLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label colaItemsLabel;
        private System.Windows.Forms.Label colaItemsTitleLabel;
        private System.Windows.Forms.GroupBox FantaGroupBox;
        private System.Windows.Forms.Label fantaItemsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox RootGroupBox;
        private System.Windows.Forms.Label rootItemsLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox SpriteGroupBox;
        private System.Windows.Forms.Label spriteItemsLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox WaterGroupBox;
        private System.Windows.Forms.Label waterItemsLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox TotalGroupBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalDisplaylabel;
        private System.Windows.Forms.Button PurchaseButton;
        private System.Windows.Forms.Button CancelButton;
    }
}

