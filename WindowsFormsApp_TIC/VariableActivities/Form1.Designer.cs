namespace VariableActivities
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
            this.lblIntegerDisplay = new System.Windows.Forms.Label();
            this.lblStringDisplay = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSumResult = new System.Windows.Forms.Label();
            this.txtInputString = new System.Windows.Forms.TextBox();
            this.btnToUpper = new System.Windows.Forms.Button();
            this.btnToLower = new System.Windows.Forms.Button();
            this.lblStringOutput = new System.Windows.Forms.Label();
            this.txtSentence = new System.Windows.Forms.TextBox();
            this.btnProcessString = new System.Windows.Forms.Button();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblSubstring = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIntegerDisplay
            // 
            this.lblIntegerDisplay.AutoSize = true;
            this.lblIntegerDisplay.Location = new System.Drawing.Point(105, 43);
            this.lblIntegerDisplay.Name = "lblIntegerDisplay";
            this.lblIntegerDisplay.Size = new System.Drawing.Size(108, 16);
            this.lblIntegerDisplay.TabIndex = 0;
            this.lblIntegerDisplay.Text = "lblIntegerDisplay";
            this.lblIntegerDisplay.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblStringDisplay
            // 
            this.lblStringDisplay.AutoSize = true;
            this.lblStringDisplay.Location = new System.Drawing.Point(291, 43);
            this.lblStringDisplay.Name = "lblStringDisplay";
            this.lblStringDisplay.Size = new System.Drawing.Size(101, 16);
            this.lblStringDisplay.TabIndex = 1;
            this.lblStringDisplay.Text = "lblStringDisplay";
            this.lblStringDisplay.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(37, 100);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(125, 22);
            this.txtNum1.TabIndex = 2;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(188, 97);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(120, 22);
            this.txtNum2.TabIndex = 3;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(340, 98);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 24);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSumResult
            // 
            this.lblSumResult.AutoSize = true;
            this.lblSumResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSumResult.Location = new System.Drawing.Point(561, 100);
            this.lblSumResult.MinimumSize = new System.Drawing.Size(150, 15);
            this.lblSumResult.Name = "lblSumResult";
            this.lblSumResult.Size = new System.Drawing.Size(150, 18);
            this.lblSumResult.TabIndex = 5;
            // 
            // txtInputString
            // 
            this.txtInputString.Location = new System.Drawing.Point(37, 165);
            this.txtInputString.Multiline = true;
            this.txtInputString.Name = "txtInputString";
            this.txtInputString.Size = new System.Drawing.Size(152, 37);
            this.txtInputString.TabIndex = 6;
            // 
            // btnToUpper
            // 
            this.btnToUpper.Location = new System.Drawing.Point(205, 171);
            this.btnToUpper.Name = "btnToUpper";
            this.btnToUpper.Size = new System.Drawing.Size(103, 31);
            this.btnToUpper.TabIndex = 7;
            this.btnToUpper.Text = "To Upper";
            this.btnToUpper.UseVisualStyleBackColor = true;
            this.btnToUpper.Click += new System.EventHandler(this.btnToUpper_Click);
            // 
            // btnToLower
            // 
            this.btnToLower.Location = new System.Drawing.Point(364, 171);
            this.btnToLower.Name = "btnToLower";
            this.btnToLower.Size = new System.Drawing.Size(107, 31);
            this.btnToLower.TabIndex = 8;
            this.btnToLower.Text = "To Lower";
            this.btnToLower.UseVisualStyleBackColor = true;
            this.btnToLower.Click += new System.EventHandler(this.btnToLower_Click);
            // 
            // lblStringOutput
            // 
            this.lblStringOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStringOutput.Location = new System.Drawing.Point(573, 177);
            this.lblStringOutput.Name = "lblStringOutput";
            this.lblStringOutput.Size = new System.Drawing.Size(150, 20);
            this.lblStringOutput.TabIndex = 9;
            // 
            // txtSentence
            // 
            this.txtSentence.Location = new System.Drawing.Point(37, 234);
            this.txtSentence.Multiline = true;
            this.txtSentence.Name = "txtSentence";
            this.txtSentence.Size = new System.Drawing.Size(271, 38);
            this.txtSentence.TabIndex = 10;
            // 
            // btnProcessString
            // 
            this.btnProcessString.Location = new System.Drawing.Point(364, 249);
            this.btnProcessString.Name = "btnProcessString";
            this.btnProcessString.Size = new System.Drawing.Size(75, 23);
            this.btnProcessString.TabIndex = 11;
            this.btnProcessString.Text = "Process String";
            this.btnProcessString.UseVisualStyleBackColor = true;
            this.btnProcessString.Click += new System.EventHandler(this.btnProcessString_Click);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(542, 252);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(0, 16);
            this.lblLength.TabIndex = 12;
            this.lblLength.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSubstring
            // 
            this.lblSubstring.AutoSize = true;
            this.lblSubstring.Location = new System.Drawing.Point(667, 252);
            this.lblSubstring.Name = "lblSubstring";
            this.lblSubstring.Size = new System.Drawing.Size(0, 16);
            this.lblSubstring.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSubstring);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.btnProcessString);
            this.Controls.Add(this.txtSentence);
            this.Controls.Add(this.lblStringOutput);
            this.Controls.Add(this.btnToLower);
            this.Controls.Add(this.btnToUpper);
            this.Controls.Add(this.txtInputString);
            this.Controls.Add(this.lblSumResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblStringDisplay);
            this.Controls.Add(this.lblIntegerDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntegerDisplay;
        private System.Windows.Forms.Label lblStringDisplay;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSumResult;
        private System.Windows.Forms.TextBox txtInputString;
        private System.Windows.Forms.Button btnToUpper;
        private System.Windows.Forms.Button btnToLower;
        private System.Windows.Forms.Label lblStringOutput;
        private System.Windows.Forms.TextBox txtSentence;
        private System.Windows.Forms.Button btnProcessString;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblSubstring;
    }
}

