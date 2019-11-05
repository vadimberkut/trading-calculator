namespace TradeCalculator
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
            this.textBoxEquity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStopLossPercent = new System.Windows.Forms.TextBox();
            this.textBoxRiskPercent = new System.Windows.Forms.TextBox();
            this.textBoxFeePercent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPositionSize = new System.Windows.Forms.TextBox();
            this.textBoxPositionSize2 = new System.Windows.Forms.TextBox();
            this.textBoxInitialMargin = new System.Windows.Forms.TextBox();
            this.buttonCalculatePositionSize = new System.Windows.Forms.Button();
            this.buttonCalculateLeverage = new System.Windows.Forms.Button();
            this.textBoxLeverage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxP2StopLossPrice = new System.Windows.Forms.TextBox();
            this.textBoxP1EnterPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonCalcPositionSize2 = new System.Windows.Forms.Button();
            this.textBoxPositionSize3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEquity
            // 
            this.textBoxEquity.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEquity.Location = new System.Drawing.Point(26, 36);
            this.textBoxEquity.Name = "textBoxEquity";
            this.textBoxEquity.Size = new System.Drawing.Size(100, 23);
            this.textBoxEquity.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Equity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "SL%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Risk%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fee%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(240, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Position size";
            // 
            // textBoxStopLossPercent
            // 
            this.textBoxStopLossPercent.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStopLossPercent.Location = new System.Drawing.Point(25, 122);
            this.textBoxStopLossPercent.Name = "textBoxStopLossPercent";
            this.textBoxStopLossPercent.Size = new System.Drawing.Size(100, 23);
            this.textBoxStopLossPercent.TabIndex = 6;
            // 
            // textBoxRiskPercent
            // 
            this.textBoxRiskPercent.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRiskPercent.Location = new System.Drawing.Point(26, 76);
            this.textBoxRiskPercent.Name = "textBoxRiskPercent";
            this.textBoxRiskPercent.Size = new System.Drawing.Size(100, 23);
            this.textBoxRiskPercent.TabIndex = 7;
            // 
            // textBoxFeePercent
            // 
            this.textBoxFeePercent.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFeePercent.Location = new System.Drawing.Point(26, 161);
            this.textBoxFeePercent.Name = "textBoxFeePercent";
            this.textBoxFeePercent.Size = new System.Drawing.Size(100, 23);
            this.textBoxFeePercent.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(240, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Initial margin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(23, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Position size";
            // 
            // textBoxPositionSize
            // 
            this.textBoxPositionSize.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxPositionSize.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPositionSize.Location = new System.Drawing.Point(26, 217);
            this.textBoxPositionSize.Name = "textBoxPositionSize";
            this.textBoxPositionSize.ReadOnly = true;
            this.textBoxPositionSize.Size = new System.Drawing.Size(100, 23);
            this.textBoxPositionSize.TabIndex = 11;
            // 
            // textBoxPositionSize2
            // 
            this.textBoxPositionSize2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPositionSize2.Location = new System.Drawing.Point(243, 122);
            this.textBoxPositionSize2.Name = "textBoxPositionSize2";
            this.textBoxPositionSize2.Size = new System.Drawing.Size(100, 23);
            this.textBoxPositionSize2.TabIndex = 12;
            // 
            // textBoxInitialMargin
            // 
            this.textBoxInitialMargin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInitialMargin.Location = new System.Drawing.Point(243, 161);
            this.textBoxInitialMargin.Name = "textBoxInitialMargin";
            this.textBoxInitialMargin.Size = new System.Drawing.Size(100, 23);
            this.textBoxInitialMargin.TabIndex = 13;
            // 
            // buttonCalculatePositionSize
            // 
            this.buttonCalculatePositionSize.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonCalculatePositionSize.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonCalculatePositionSize.FlatAppearance.BorderSize = 5;
            this.buttonCalculatePositionSize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCalculatePositionSize.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculatePositionSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCalculatePositionSize.Location = new System.Drawing.Point(25, 243);
            this.buttonCalculatePositionSize.Name = "buttonCalculatePositionSize";
            this.buttonCalculatePositionSize.Size = new System.Drawing.Size(101, 23);
            this.buttonCalculatePositionSize.TabIndex = 14;
            this.buttonCalculatePositionSize.Text = "Calc position size";
            this.buttonCalculatePositionSize.UseVisualStyleBackColor = false;
            this.buttonCalculatePositionSize.Click += new System.EventHandler(this.buttonCalculatePositionSize_Click);
            // 
            // buttonCalculateLeverage
            // 
            this.buttonCalculateLeverage.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonCalculateLeverage.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonCalculateLeverage.FlatAppearance.BorderSize = 5;
            this.buttonCalculateLeverage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCalculateLeverage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculateLeverage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCalculateLeverage.Location = new System.Drawing.Point(242, 243);
            this.buttonCalculateLeverage.Name = "buttonCalculateLeverage";
            this.buttonCalculateLeverage.Size = new System.Drawing.Size(101, 23);
            this.buttonCalculateLeverage.TabIndex = 15;
            this.buttonCalculateLeverage.Text = "Calc leverage";
            this.buttonCalculateLeverage.UseVisualStyleBackColor = false;
            this.buttonCalculateLeverage.Click += new System.EventHandler(this.buttonCalculateLeverage_Click);
            // 
            // textBoxLeverage
            // 
            this.textBoxLeverage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxLeverage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLeverage.Location = new System.Drawing.Point(243, 217);
            this.textBoxLeverage.Name = "textBoxLeverage";
            this.textBoxLeverage.ReadOnly = true;
            this.textBoxLeverage.Size = new System.Drawing.Size(100, 23);
            this.textBoxLeverage.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(240, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Leverage";
            // 
            // textBoxP2StopLossPrice
            // 
            this.textBoxP2StopLossPrice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxP2StopLossPrice.Location = new System.Drawing.Point(132, 162);
            this.textBoxP2StopLossPrice.Name = "textBoxP2StopLossPrice";
            this.textBoxP2StopLossPrice.Size = new System.Drawing.Size(100, 23);
            this.textBoxP2StopLossPrice.TabIndex = 21;
            // 
            // textBoxP1EnterPrice
            // 
            this.textBoxP1EnterPrice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxP1EnterPrice.Location = new System.Drawing.Point(131, 123);
            this.textBoxP1EnterPrice.Name = "textBoxP1EnterPrice";
            this.textBoxP1EnterPrice.Size = new System.Drawing.Size(100, 23);
            this.textBoxP1EnterPrice.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(129, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "P2 - SL price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(128, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "P1 - Enter price";
            // 
            // buttonCalcPositionSize2
            // 
            this.buttonCalcPositionSize2.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonCalcPositionSize2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonCalcPositionSize2.FlatAppearance.BorderSize = 5;
            this.buttonCalcPositionSize2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCalcPositionSize2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalcPositionSize2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCalcPositionSize2.Location = new System.Drawing.Point(132, 243);
            this.buttonCalcPositionSize2.Name = "buttonCalcPositionSize2";
            this.buttonCalcPositionSize2.Size = new System.Drawing.Size(101, 23);
            this.buttonCalcPositionSize2.TabIndex = 24;
            this.buttonCalcPositionSize2.Text = "Calc position size";
            this.buttonCalcPositionSize2.UseVisualStyleBackColor = false;
            this.buttonCalcPositionSize2.Click += new System.EventHandler(this.buttonCalcPositionSize2_Click);
            // 
            // textBoxPositionSize3
            // 
            this.textBoxPositionSize3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxPositionSize3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPositionSize3.Location = new System.Drawing.Point(133, 217);
            this.textBoxPositionSize3.Name = "textBoxPositionSize3";
            this.textBoxPositionSize3.ReadOnly = true;
            this.textBoxPositionSize3.Size = new System.Drawing.Size(100, 23);
            this.textBoxPositionSize3.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(130, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Position size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(369, 278);
            this.Controls.Add(this.buttonCalcPositionSize2);
            this.Controls.Add(this.textBoxPositionSize3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxP2StopLossPrice);
            this.Controls.Add(this.textBoxP1EnterPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxLeverage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonCalculateLeverage);
            this.Controls.Add(this.buttonCalculatePositionSize);
            this.Controls.Add(this.textBoxInitialMargin);
            this.Controls.Add(this.textBoxPositionSize2);
            this.Controls.Add(this.textBoxPositionSize);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxFeePercent);
            this.Controls.Add(this.textBoxRiskPercent);
            this.Controls.Add(this.textBoxStopLossPercent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEquity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEquity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxStopLossPercent;
        private System.Windows.Forms.TextBox textBoxRiskPercent;
        private System.Windows.Forms.TextBox textBoxFeePercent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPositionSize;
        private System.Windows.Forms.TextBox textBoxPositionSize2;
        private System.Windows.Forms.TextBox textBoxInitialMargin;
        private System.Windows.Forms.Button buttonCalculatePositionSize;
        private System.Windows.Forms.Button buttonCalculateLeverage;
        private System.Windows.Forms.TextBox textBoxLeverage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxP2StopLossPrice;
        private System.Windows.Forms.TextBox textBoxP1EnterPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonCalcPositionSize2;
        private System.Windows.Forms.TextBox textBoxPositionSize3;
        private System.Windows.Forms.Label label11;
    }
}

