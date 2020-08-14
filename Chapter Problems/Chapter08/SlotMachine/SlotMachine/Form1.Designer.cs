namespace SlotMachine
{
    partial class SlotMachineForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlotMachineForm));
            this.insertPromptLabel = new System.Windows.Forms.Label();
            this.display1PictureBox = new System.Windows.Forms.PictureBox();
            this.display2PictureBox = new System.Windows.Forms.PictureBox();
            this.display3PictureBox = new System.Windows.Forms.PictureBox();
            this.insertLabel = new System.Windows.Forms.TextBox();
            this.totalPromptLabel = new System.Windows.Forms.Label();
            this.SpinButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.AddMoneyButton = new System.Windows.Forms.Button();
            this.amountLeftLabel = new System.Windows.Forms.Label();
            this.TicketButton = new System.Windows.Forms.Button();
            this.moneyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.display1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display3PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // insertPromptLabel
            // 
            this.insertPromptLabel.BackColor = System.Drawing.Color.White;
            this.insertPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertPromptLabel.Location = new System.Drawing.Point(196, 285);
            this.insertPromptLabel.Name = "insertPromptLabel";
            this.insertPromptLabel.Size = new System.Drawing.Size(153, 20);
            this.insertPromptLabel.TabIndex = 1;
            this.insertPromptLabel.Text = "Insert Money :";
            this.insertPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // display1PictureBox
            // 
            this.display1PictureBox.ErrorImage = global::SlotMachine.Properties.Resources._1_2_mango_png_800x800;
            this.display1PictureBox.Image = global::SlotMachine.Properties.Resources._1_strawberry_png_images;
            this.display1PictureBox.Location = new System.Drawing.Point(33, 36);
            this.display1PictureBox.Name = "display1PictureBox";
            this.display1PictureBox.Size = new System.Drawing.Size(188, 207);
            this.display1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.display1PictureBox.TabIndex = 2;
            this.display1PictureBox.TabStop = false;
            // 
            // display2PictureBox
            // 
            this.display2PictureBox.Image = global::SlotMachine.Properties.Resources._1_2_mango_png_800x800;
            this.display2PictureBox.Location = new System.Drawing.Point(248, 36);
            this.display2PictureBox.Name = "display2PictureBox";
            this.display2PictureBox.Size = new System.Drawing.Size(188, 207);
            this.display2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.display2PictureBox.TabIndex = 3;
            this.display2PictureBox.TabStop = false;
            // 
            // display3PictureBox
            // 
            this.display3PictureBox.Image = global::SlotMachine.Properties.Resources._4_grape_png_image_download_picture;
            this.display3PictureBox.Location = new System.Drawing.Point(462, 36);
            this.display3PictureBox.Name = "display3PictureBox";
            this.display3PictureBox.Size = new System.Drawing.Size(188, 207);
            this.display3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.display3PictureBox.TabIndex = 4;
            this.display3PictureBox.TabStop = false;
            // 
            // insertLabel
            // 
            this.insertLabel.Location = new System.Drawing.Point(355, 285);
            this.insertLabel.Name = "insertLabel";
            this.insertLabel.Size = new System.Drawing.Size(165, 20);
            this.insertLabel.TabIndex = 5;
            // 
            // totalPromptLabel
            // 
            this.totalPromptLabel.BackColor = System.Drawing.Color.White;
            this.totalPromptLabel.Enabled = false;
            this.totalPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPromptLabel.Location = new System.Drawing.Point(196, 308);
            this.totalPromptLabel.Name = "totalPromptLabel";
            this.totalPromptLabel.Size = new System.Drawing.Size(153, 20);
            this.totalPromptLabel.TabIndex = 6;
            this.totalPromptLabel.Text = "Amount Inserted : ";
            this.totalPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalPromptLabel.Visible = false;
            // 
            // SpinButton
            // 
            this.SpinButton.Enabled = false;
            this.SpinButton.Location = new System.Drawing.Point(101, 343);
            this.SpinButton.Name = "SpinButton";
            this.SpinButton.Size = new System.Drawing.Size(160, 38);
            this.SpinButton.TabIndex = 8;
            this.SpinButton.Text = "Spin $1.00";
            this.SpinButton.UseVisualStyleBackColor = true;
            this.SpinButton.Visible = false;
            this.SpinButton.Click += new System.EventHandler(this.SpinButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(477, 343);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(160, 38);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "4-grape-png-image-download-picture.png");
            this.imageList1.Images.SetKeyName(1, "1-2-mango-png_800x800.png");
            this.imageList1.Images.SetKeyName(2, "1-strawberry-png-images.png");
            // 
            // AddMoneyButton
            // 
            this.AddMoneyButton.Location = new System.Drawing.Point(526, 283);
            this.AddMoneyButton.Name = "AddMoneyButton";
            this.AddMoneyButton.Size = new System.Drawing.Size(111, 26);
            this.AddMoneyButton.TabIndex = 10;
            this.AddMoneyButton.Text = "Add";
            this.AddMoneyButton.UseVisualStyleBackColor = true;
            this.AddMoneyButton.Click += new System.EventHandler(this.AddMoneyButton_Click);
            // 
            // amountLeftLabel
            // 
            this.amountLeftLabel.BackColor = System.Drawing.Color.White;
            this.amountLeftLabel.Enabled = false;
            this.amountLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLeftLabel.Location = new System.Drawing.Point(355, 308);
            this.amountLeftLabel.Name = "amountLeftLabel";
            this.amountLeftLabel.Size = new System.Drawing.Size(165, 20);
            this.amountLeftLabel.TabIndex = 11;
            this.amountLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.amountLeftLabel.Visible = false;
            // 
            // TicketButton
            // 
            this.TicketButton.Enabled = false;
            this.TicketButton.Location = new System.Drawing.Point(287, 343);
            this.TicketButton.Name = "TicketButton";
            this.TicketButton.Size = new System.Drawing.Size(160, 38);
            this.TicketButton.TabIndex = 12;
            this.TicketButton.Text = "Ticket";
            this.TicketButton.UseVisualStyleBackColor = true;
            this.TicketButton.Visible = false;
            this.TicketButton.Click += new System.EventHandler(this.TicketButton_Click);
            // 
            // moneyLabel
            // 
            this.moneyLabel.BackColor = System.Drawing.Color.Black;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.moneyLabel.Location = new System.Drawing.Point(23, 259);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(143, 69);
            this.moneyLabel.TabIndex = 13;
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SlotMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(681, 405);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.TicketButton);
            this.Controls.Add(this.amountLeftLabel);
            this.Controls.Add(this.AddMoneyButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SpinButton);
            this.Controls.Add(this.totalPromptLabel);
            this.Controls.Add(this.insertLabel);
            this.Controls.Add(this.display3PictureBox);
            this.Controls.Add(this.display2PictureBox);
            this.Controls.Add(this.display1PictureBox);
            this.Controls.Add(this.insertPromptLabel);
            this.Name = "SlotMachineForm";
            this.Text = "Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.display1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display3PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label insertPromptLabel;
        private System.Windows.Forms.PictureBox display1PictureBox;
        private System.Windows.Forms.PictureBox display2PictureBox;
        private System.Windows.Forms.PictureBox display3PictureBox;
        private System.Windows.Forms.TextBox insertLabel;
        private System.Windows.Forms.Label totalPromptLabel;
        private System.Windows.Forms.Button SpinButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button AddMoneyButton;
        private System.Windows.Forms.Label amountLeftLabel;
        private System.Windows.Forms.Button TicketButton;
        private System.Windows.Forms.Label moneyLabel;
    }
}

