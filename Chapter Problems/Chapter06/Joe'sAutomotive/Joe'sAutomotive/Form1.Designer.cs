namespace Joe_sAutomotive
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
            this.oilGroupBox = new System.Windows.Forms.GroupBox();
            this.oilChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.lubeJobCheckBox = new System.Windows.Forms.CheckBox();
            this.flushesGroupBox = new System.Windows.Forms.GroupBox();
            this.transmissionFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.radiationFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.miscGroupBox = new System.Windows.Forms.GroupBox();
            this.replaceMufflerCheckBox = new System.Windows.Forms.CheckBox();
            this.inspectionCheckBox = new System.Windows.Forms.CheckBox();
            this.tireRotationCheckBox = new System.Windows.Forms.CheckBox();
            this.partsGroupBox = new System.Windows.Forms.GroupBox();
            this.partsPromptLabel = new System.Windows.Forms.Label();
            this.hoursPromptLabel = new System.Windows.Forms.Label();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.summeryGroupBox = new System.Windows.Forms.GroupBox();
            this.serviceOutputLabel = new System.Windows.Forms.Label();
            this.partsOutputLabel = new System.Windows.Forms.Label();
            this.taxOuputLabel = new System.Windows.Forms.Label();
            this.feesOutputLabel = new System.Windows.Forms.Label();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.oilGroupBox.SuspendLayout();
            this.flushesGroupBox.SuspendLayout();
            this.miscGroupBox.SuspendLayout();
            this.partsGroupBox.SuspendLayout();
            this.summeryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // oilGroupBox
            // 
            this.oilGroupBox.Controls.Add(this.lubeJobCheckBox);
            this.oilGroupBox.Controls.Add(this.oilChangeCheckBox);
            this.oilGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oilGroupBox.Location = new System.Drawing.Point(22, 36);
            this.oilGroupBox.Name = "oilGroupBox";
            this.oilGroupBox.Size = new System.Drawing.Size(180, 87);
            this.oilGroupBox.TabIndex = 0;
            this.oilGroupBox.TabStop = false;
            this.oilGroupBox.Text = "Oil and Lube";
            // 
            // oilChangeCheckBox
            // 
            this.oilChangeCheckBox.AutoSize = true;
            this.oilChangeCheckBox.Location = new System.Drawing.Point(6, 28);
            this.oilChangeCheckBox.Name = "oilChangeCheckBox";
            this.oilChangeCheckBox.Size = new System.Drawing.Size(136, 19);
            this.oilChangeCheckBox.TabIndex = 0;
            this.oilChangeCheckBox.Text = "Oil Change ($26.00)";
            this.oilChangeCheckBox.UseVisualStyleBackColor = true;
            // 
            // lubeJobCheckBox
            // 
            this.lubeJobCheckBox.AutoSize = true;
            this.lubeJobCheckBox.Location = new System.Drawing.Point(6, 51);
            this.lubeJobCheckBox.Name = "lubeJobCheckBox";
            this.lubeJobCheckBox.Size = new System.Drawing.Size(126, 19);
            this.lubeJobCheckBox.TabIndex = 1;
            this.lubeJobCheckBox.Text = "Lube Job ($18.00)";
            this.lubeJobCheckBox.UseVisualStyleBackColor = true;
            // 
            // flushesGroupBox
            // 
            this.flushesGroupBox.Controls.Add(this.transmissionFlushCheckBox);
            this.flushesGroupBox.Controls.Add(this.radiationFlushCheckBox);
            this.flushesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flushesGroupBox.Location = new System.Drawing.Point(218, 36);
            this.flushesGroupBox.Name = "flushesGroupBox";
            this.flushesGroupBox.Size = new System.Drawing.Size(191, 87);
            this.flushesGroupBox.TabIndex = 1;
            this.flushesGroupBox.TabStop = false;
            this.flushesGroupBox.Text = "Flushes";
            // 
            // transmissionFlushCheckBox
            // 
            this.transmissionFlushCheckBox.AutoSize = true;
            this.transmissionFlushCheckBox.Location = new System.Drawing.Point(6, 51);
            this.transmissionFlushCheckBox.Name = "transmissionFlushCheckBox";
            this.transmissionFlushCheckBox.Size = new System.Drawing.Size(182, 19);
            this.transmissionFlushCheckBox.TabIndex = 1;
            this.transmissionFlushCheckBox.Text = "Transmission Flush ($80.00)";
            this.transmissionFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // radiationFlushCheckBox
            // 
            this.radiationFlushCheckBox.AutoSize = true;
            this.radiationFlushCheckBox.Location = new System.Drawing.Point(6, 28);
            this.radiationFlushCheckBox.Name = "radiationFlushCheckBox";
            this.radiationFlushCheckBox.Size = new System.Drawing.Size(161, 19);
            this.radiationFlushCheckBox.TabIndex = 0;
            this.radiationFlushCheckBox.Text = "Radiation Flush ($30.00)";
            this.radiationFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // miscGroupBox
            // 
            this.miscGroupBox.Controls.Add(this.tireRotationCheckBox);
            this.miscGroupBox.Controls.Add(this.replaceMufflerCheckBox);
            this.miscGroupBox.Controls.Add(this.inspectionCheckBox);
            this.miscGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscGroupBox.Location = new System.Drawing.Point(22, 149);
            this.miscGroupBox.Name = "miscGroupBox";
            this.miscGroupBox.Size = new System.Drawing.Size(180, 105);
            this.miscGroupBox.TabIndex = 2;
            this.miscGroupBox.TabStop = false;
            this.miscGroupBox.Text = "Misc";
            // 
            // replaceMufflerCheckBox
            // 
            this.replaceMufflerCheckBox.AutoSize = true;
            this.replaceMufflerCheckBox.Location = new System.Drawing.Point(6, 51);
            this.replaceMufflerCheckBox.Name = "replaceMufflerCheckBox";
            this.replaceMufflerCheckBox.Size = new System.Drawing.Size(169, 19);
            this.replaceMufflerCheckBox.TabIndex = 1;
            this.replaceMufflerCheckBox.Text = "Replace Muffler ($100.00)";
            this.replaceMufflerCheckBox.UseVisualStyleBackColor = true;
            // 
            // inspectionCheckBox
            // 
            this.inspectionCheckBox.AutoSize = true;
            this.inspectionCheckBox.Location = new System.Drawing.Point(6, 28);
            this.inspectionCheckBox.Name = "inspectionCheckBox";
            this.inspectionCheckBox.Size = new System.Drawing.Size(131, 19);
            this.inspectionCheckBox.TabIndex = 0;
            this.inspectionCheckBox.Text = "Inspection ($15.00)";
            this.inspectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // tireRotationCheckBox
            // 
            this.tireRotationCheckBox.AutoSize = true;
            this.tireRotationCheckBox.Location = new System.Drawing.Point(6, 74);
            this.tireRotationCheckBox.Name = "tireRotationCheckBox";
            this.tireRotationCheckBox.Size = new System.Drawing.Size(145, 19);
            this.tireRotationCheckBox.TabIndex = 2;
            this.tireRotationCheckBox.Text = "Tire Rotation ($20.00)";
            this.tireRotationCheckBox.UseVisualStyleBackColor = true;
            // 
            // partsGroupBox
            // 
            this.partsGroupBox.Controls.Add(this.hoursTextBox);
            this.partsGroupBox.Controls.Add(this.partsTextBox);
            this.partsGroupBox.Controls.Add(this.hoursPromptLabel);
            this.partsGroupBox.Controls.Add(this.partsPromptLabel);
            this.partsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsGroupBox.Location = new System.Drawing.Point(218, 149);
            this.partsGroupBox.Name = "partsGroupBox";
            this.partsGroupBox.Size = new System.Drawing.Size(188, 105);
            this.partsGroupBox.TabIndex = 3;
            this.partsGroupBox.TabStop = false;
            this.partsGroupBox.Text = "Parts and Labor";
            // 
            // partsPromptLabel
            // 
            this.partsPromptLabel.Location = new System.Drawing.Point(13, 29);
            this.partsPromptLabel.Name = "partsPromptLabel";
            this.partsPromptLabel.Size = new System.Drawing.Size(58, 15);
            this.partsPromptLabel.TabIndex = 0;
            this.partsPromptLabel.Text = "Parts :";
            this.partsPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hoursPromptLabel
            // 
            this.hoursPromptLabel.Location = new System.Drawing.Point(13, 53);
            this.hoursPromptLabel.Name = "hoursPromptLabel";
            this.hoursPromptLabel.Size = new System.Drawing.Size(58, 15);
            this.hoursPromptLabel.TabIndex = 1;
            this.hoursPromptLabel.Text = "Hours  :";
            this.hoursPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(77, 24);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(82, 21);
            this.partsTextBox.TabIndex = 2;
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(77, 49);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(82, 21);
            this.hoursTextBox.TabIndex = 3;
            // 
            // summeryGroupBox
            // 
            this.summeryGroupBox.Controls.Add(this.totalLabel);
            this.summeryGroupBox.Controls.Add(this.taxLabel);
            this.summeryGroupBox.Controls.Add(this.partsLabel);
            this.summeryGroupBox.Controls.Add(this.serviceLabel);
            this.summeryGroupBox.Controls.Add(this.feesOutputLabel);
            this.summeryGroupBox.Controls.Add(this.taxOuputLabel);
            this.summeryGroupBox.Controls.Add(this.partsOutputLabel);
            this.summeryGroupBox.Controls.Add(this.serviceOutputLabel);
            this.summeryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summeryGroupBox.Location = new System.Drawing.Point(22, 271);
            this.summeryGroupBox.Name = "summeryGroupBox";
            this.summeryGroupBox.Size = new System.Drawing.Size(384, 151);
            this.summeryGroupBox.TabIndex = 4;
            this.summeryGroupBox.TabStop = false;
            this.summeryGroupBox.Text = "Summary";
            // 
            // serviceOutputLabel
            // 
            this.serviceOutputLabel.Location = new System.Drawing.Point(6, 32);
            this.serviceOutputLabel.Name = "serviceOutputLabel";
            this.serviceOutputLabel.Size = new System.Drawing.Size(136, 19);
            this.serviceOutputLabel.TabIndex = 1;
            this.serviceOutputLabel.Text = "Service and Labor";
            this.serviceOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // partsOutputLabel
            // 
            this.partsOutputLabel.Location = new System.Drawing.Point(6, 60);
            this.partsOutputLabel.Name = "partsOutputLabel";
            this.partsOutputLabel.Size = new System.Drawing.Size(136, 19);
            this.partsOutputLabel.TabIndex = 2;
            this.partsOutputLabel.Text = "Parts";
            this.partsOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxOuputLabel
            // 
            this.taxOuputLabel.Location = new System.Drawing.Point(6, 88);
            this.taxOuputLabel.Name = "taxOuputLabel";
            this.taxOuputLabel.Size = new System.Drawing.Size(136, 19);
            this.taxOuputLabel.TabIndex = 3;
            this.taxOuputLabel.Text = "Tax (on parts)";
            this.taxOuputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // feesOutputLabel
            // 
            this.feesOutputLabel.Location = new System.Drawing.Point(6, 116);
            this.feesOutputLabel.Name = "feesOutputLabel";
            this.feesOutputLabel.Size = new System.Drawing.Size(136, 19);
            this.feesOutputLabel.TabIndex = 4;
            this.feesOutputLabel.Text = "Total Fees";
            this.feesOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // serviceLabel
            // 
            this.serviceLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.serviceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serviceLabel.Location = new System.Drawing.Point(158, 32);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(136, 19);
            this.serviceLabel.TabIndex = 5;
            this.serviceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // partsLabel
            // 
            this.partsLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.partsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.partsLabel.Location = new System.Drawing.Point(158, 60);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(136, 19);
            this.partsLabel.TabIndex = 6;
            this.partsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxLabel
            // 
            this.taxLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taxLabel.Location = new System.Drawing.Point(158, 88);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(136, 19);
            this.taxLabel.TabIndex = 7;
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalLabel.Location = new System.Drawing.Point(158, 116);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(136, 19);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(54, 439);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(167, 439);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(278, 439);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 485);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.summeryGroupBox);
            this.Controls.Add(this.partsGroupBox);
            this.Controls.Add(this.miscGroupBox);
            this.Controls.Add(this.flushesGroupBox);
            this.Controls.Add(this.oilGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.oilGroupBox.ResumeLayout(false);
            this.oilGroupBox.PerformLayout();
            this.flushesGroupBox.ResumeLayout(false);
            this.flushesGroupBox.PerformLayout();
            this.miscGroupBox.ResumeLayout(false);
            this.miscGroupBox.PerformLayout();
            this.partsGroupBox.ResumeLayout(false);
            this.partsGroupBox.PerformLayout();
            this.summeryGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox oilGroupBox;
        private System.Windows.Forms.CheckBox lubeJobCheckBox;
        private System.Windows.Forms.CheckBox oilChangeCheckBox;
        private System.Windows.Forms.GroupBox flushesGroupBox;
        private System.Windows.Forms.CheckBox transmissionFlushCheckBox;
        private System.Windows.Forms.CheckBox radiationFlushCheckBox;
        private System.Windows.Forms.GroupBox miscGroupBox;
        private System.Windows.Forms.CheckBox replaceMufflerCheckBox;
        private System.Windows.Forms.CheckBox inspectionCheckBox;
        private System.Windows.Forms.CheckBox tireRotationCheckBox;
        private System.Windows.Forms.GroupBox partsGroupBox;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.Label hoursPromptLabel;
        private System.Windows.Forms.Label partsPromptLabel;
        private System.Windows.Forms.GroupBox summeryGroupBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.Label feesOutputLabel;
        private System.Windows.Forms.Label taxOuputLabel;
        private System.Windows.Forms.Label partsOutputLabel;
        private System.Windows.Forms.Label serviceOutputLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

