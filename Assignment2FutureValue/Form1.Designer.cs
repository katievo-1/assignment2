namespace Assignment2FutureValue
{
    partial class FrmFutureValue
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
            this.lblMonthly = new System.Windows.Forms.Label();
            this.lblYearlyRate = new System.Windows.Forms.Label();
            this.lblNumberYears = new System.Windows.Forms.Label();
            this.lblFutureValue = new System.Windows.Forms.Label();
            this.txtMonthly = new System.Windows.Forms.TextBox();
            this.txtYearlyInterest = new System.Windows.Forms.TextBox();
            this.txtNumberOfYears = new System.Windows.Forms.TextBox();
            this.txtFutureValue = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMonthly
            // 
            this.lblMonthly.AutoSize = true;
            this.lblMonthly.Location = new System.Drawing.Point(49, 99);
            this.lblMonthly.Name = "lblMonthly";
            this.lblMonthly.Size = new System.Drawing.Size(133, 17);
            this.lblMonthly.TabIndex = 0;
            this.lblMonthly.Text = "Monthly Investment:";
            // 
            // lblYearlyRate
            // 
            this.lblYearlyRate.AutoSize = true;
            this.lblYearlyRate.Location = new System.Drawing.Point(49, 151);
            this.lblYearlyRate.Name = "lblYearlyRate";
            this.lblYearlyRate.Size = new System.Drawing.Size(137, 17);
            this.lblYearlyRate.TabIndex = 1;
            this.lblYearlyRate.Text = "Yearly Interest Rate:";
            // 
            // lblNumberYears
            // 
            this.lblNumberYears.AutoSize = true;
            this.lblNumberYears.Location = new System.Drawing.Point(49, 208);
            this.lblNumberYears.Name = "lblNumberYears";
            this.lblNumberYears.Size = new System.Drawing.Size(119, 17);
            this.lblNumberYears.TabIndex = 2;
            this.lblNumberYears.Text = "Number of Years:";
            // 
            // lblFutureValue
            // 
            this.lblFutureValue.AutoSize = true;
            this.lblFutureValue.Location = new System.Drawing.Point(49, 270);
            this.lblFutureValue.Name = "lblFutureValue";
            this.lblFutureValue.Size = new System.Drawing.Size(93, 17);
            this.lblFutureValue.TabIndex = 3;
            this.lblFutureValue.Text = "Future Value:";
            // 
            // txtMonthly
            // 
            this.txtMonthly.Location = new System.Drawing.Point(275, 99);
            this.txtMonthly.Name = "txtMonthly";
            this.txtMonthly.Size = new System.Drawing.Size(100, 22);
            this.txtMonthly.TabIndex = 4;
            // 
            // txtYearlyInterest
            // 
            this.txtYearlyInterest.Location = new System.Drawing.Point(275, 151);
            this.txtYearlyInterest.Name = "txtYearlyInterest";
            this.txtYearlyInterest.Size = new System.Drawing.Size(100, 22);
            this.txtYearlyInterest.TabIndex = 5;
            // 
            // txtNumberOfYears
            // 
            this.txtNumberOfYears.Location = new System.Drawing.Point(275, 208);
            this.txtNumberOfYears.Name = "txtNumberOfYears";
            this.txtNumberOfYears.Size = new System.Drawing.Size(100, 22);
            this.txtNumberOfYears.TabIndex = 6;
            // 
            // txtFutureValue
            // 
            this.txtFutureValue.Location = new System.Drawing.Point(275, 270);
            this.txtFutureValue.Name = "txtFutureValue";
            this.txtFutureValue.ReadOnly = true;
            this.txtFutureValue.Size = new System.Drawing.Size(100, 22);
            this.txtFutureValue.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(90, 353);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(116, 32);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(230, 353);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 32);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmFutureValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(426, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtFutureValue);
            this.Controls.Add(this.txtNumberOfYears);
            this.Controls.Add(this.txtYearlyInterest);
            this.Controls.Add(this.txtMonthly);
            this.Controls.Add(this.lblFutureValue);
            this.Controls.Add(this.lblNumberYears);
            this.Controls.Add(this.lblYearlyRate);
            this.Controls.Add(this.lblMonthly);
            this.Name = "FrmFutureValue";
            this.Text = "Future Value";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonthly;
        private System.Windows.Forms.Label lblYearlyRate;
        private System.Windows.Forms.Label lblNumberYears;
        private System.Windows.Forms.Label lblFutureValue;
        private System.Windows.Forms.TextBox txtMonthly;
        private System.Windows.Forms.TextBox txtYearlyInterest;
        private System.Windows.Forms.TextBox txtNumberOfYears;
        private System.Windows.Forms.TextBox txtFutureValue;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

