namespace AccountSumilatorClass
{
    partial class BankAccountForm
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
            this.balanceDisplayLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.depositGroupBox = new System.Windows.Forms.GroupBox();
            this.depositAmountLabel = new System.Windows.Forms.Label();
            this.depositeButton = new System.Windows.Forms.Button();
            this.withdrawlGroupBox = new System.Windows.Forms.GroupBox();
            this.withdrawlButton = new System.Windows.Forms.Button();
            this.withdrawlAmountLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.depositLabel = new System.Windows.Forms.TextBox();
            this.withdrawlLabel = new System.Windows.Forms.TextBox();
            this.depositGroupBox.SuspendLayout();
            this.withdrawlGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // balanceDisplayLabel
            // 
            this.balanceDisplayLabel.Location = new System.Drawing.Point(92, 39);
            this.balanceDisplayLabel.Name = "balanceDisplayLabel";
            this.balanceDisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.balanceDisplayLabel.TabIndex = 0;
            this.balanceDisplayLabel.Text = "Balance :";
            this.balanceDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // balanceLabel
            // 
            this.balanceLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.balanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceLabel.Location = new System.Drawing.Point(199, 39);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(100, 23);
            this.balanceLabel.TabIndex = 1;
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // depositGroupBox
            // 
            this.depositGroupBox.Controls.Add(this.depositLabel);
            this.depositGroupBox.Controls.Add(this.depositeButton);
            this.depositGroupBox.Controls.Add(this.depositAmountLabel);
            this.depositGroupBox.Location = new System.Drawing.Point(19, 101);
            this.depositGroupBox.Name = "depositGroupBox";
            this.depositGroupBox.Size = new System.Drawing.Size(175, 100);
            this.depositGroupBox.TabIndex = 2;
            this.depositGroupBox.TabStop = false;
            this.depositGroupBox.Text = "Make a Deposit";
            // 
            // depositAmountLabel
            // 
            this.depositAmountLabel.Location = new System.Drawing.Point(6, 29);
            this.depositAmountLabel.Name = "depositAmountLabel";
            this.depositAmountLabel.Size = new System.Drawing.Size(64, 23);
            this.depositAmountLabel.TabIndex = 4;
            this.depositAmountLabel.Text = "Amount :";
            this.depositAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // depositeButton
            // 
            this.depositeButton.Location = new System.Drawing.Point(49, 70);
            this.depositeButton.Name = "depositeButton";
            this.depositeButton.Size = new System.Drawing.Size(70, 20);
            this.depositeButton.TabIndex = 5;
            this.depositeButton.Text = "Deposit";
            this.depositeButton.UseVisualStyleBackColor = true;
            this.depositeButton.Click += new System.EventHandler(this.depositeButton_Click);
            // 
            // withdrawlGroupBox
            // 
            this.withdrawlGroupBox.Controls.Add(this.withdrawlLabel);
            this.withdrawlGroupBox.Controls.Add(this.withdrawlButton);
            this.withdrawlGroupBox.Controls.Add(this.withdrawlAmountLabel);
            this.withdrawlGroupBox.Location = new System.Drawing.Point(220, 101);
            this.withdrawlGroupBox.Name = "withdrawlGroupBox";
            this.withdrawlGroupBox.Size = new System.Drawing.Size(175, 100);
            this.withdrawlGroupBox.TabIndex = 3;
            this.withdrawlGroupBox.TabStop = false;
            this.withdrawlGroupBox.Text = "Make a Withdrawl";
            // 
            // withdrawlButton
            // 
            this.withdrawlButton.Location = new System.Drawing.Point(46, 70);
            this.withdrawlButton.Name = "withdrawlButton";
            this.withdrawlButton.Size = new System.Drawing.Size(70, 20);
            this.withdrawlButton.TabIndex = 5;
            this.withdrawlButton.Text = "Withdrawl";
            this.withdrawlButton.UseVisualStyleBackColor = true;
            this.withdrawlButton.Click += new System.EventHandler(this.withdrawlButton_Click);
            // 
            // withdrawlAmountLabel
            // 
            this.withdrawlAmountLabel.Location = new System.Drawing.Point(6, 29);
            this.withdrawlAmountLabel.Name = "withdrawlAmountLabel";
            this.withdrawlAmountLabel.Size = new System.Drawing.Size(64, 23);
            this.withdrawlAmountLabel.TabIndex = 4;
            this.withdrawlAmountLabel.Text = "Amount :";
            this.withdrawlAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(165, 221);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(84, 24);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // depositLabel
            // 
            this.depositLabel.Location = new System.Drawing.Point(76, 32);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(93, 20);
            this.depositLabel.TabIndex = 6;
            // 
            // withdrawlLabel
            // 
            this.withdrawlLabel.Location = new System.Drawing.Point(76, 32);
            this.withdrawlLabel.Name = "withdrawlLabel";
            this.withdrawlLabel.Size = new System.Drawing.Size(93, 20);
            this.withdrawlLabel.TabIndex = 7;
            // 
            // BankAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 257);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.withdrawlGroupBox);
            this.Controls.Add(this.depositGroupBox);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.balanceDisplayLabel);
            this.Name = "BankAccountForm";
            this.Text = "Account Simulator";
            this.Load += new System.EventHandler(this.BankAccountForm_Load);
            this.depositGroupBox.ResumeLayout(false);
            this.depositGroupBox.PerformLayout();
            this.withdrawlGroupBox.ResumeLayout(false);
            this.withdrawlGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label balanceDisplayLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.GroupBox depositGroupBox;
        private System.Windows.Forms.Button depositeButton;
        private System.Windows.Forms.Label depositAmountLabel;
        private System.Windows.Forms.GroupBox withdrawlGroupBox;
        private System.Windows.Forms.Button withdrawlButton;
        private System.Windows.Forms.Label withdrawlAmountLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox depositLabel;
        private System.Windows.Forms.TextBox withdrawlLabel;
    }
}

