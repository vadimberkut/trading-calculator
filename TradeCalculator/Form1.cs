using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set default params
            this.textBoxRiskPercent.Text = "1";
        }

        private void buttonCalculatePositionSize_Click(object sender, EventArgs e)
        {
            try
            {
                double equity = System.Convert.ToDouble(this.textBoxEquity.Text);
                double riskPercent = System.Convert.ToDouble(this.textBoxRiskPercent.Text);
                double stopLossPercent = System.Convert.ToDouble(this.textBoxStopLossPercent.Text);
                double feePercent = System.Convert.ToDouble(this.textBoxFeePercent.Text);
                double positionSize = (equity * riskPercent) / (stopLossPercent + feePercent);

                positionSize = Math.Round(positionSize, 2);

                this.textBoxPositionSize.Text = positionSize.ToString();
                this.textBoxPositionSize2.Text = positionSize.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ensure you filled in correct data! ({ex.Message})");
            }
        }

        private void buttonCalculateLeverage_Click(object sender, EventArgs e)
        {
            try
            {
                double positionSize = System.Convert.ToDouble(this.textBoxPositionSize2.Text);
                double initialMargin = System.Convert.ToDouble(this.textBoxInitialMargin.Text);
                double leverage = positionSize / initialMargin;

                leverage = Math.Round(leverage, 2);

                this.textBoxLeverage.Text = leverage.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ensure you filled in correct data! ({ex.Message})");
            }
        }

        private void buttonCalcPositionSize2_Click(object sender, EventArgs e)
        {
            try
            {
                double equity = System.Convert.ToDouble(this.textBoxEquity.Text);
                double riskPercent = System.Convert.ToDouble(this.textBoxRiskPercent.Text);
                double P1 = System.Convert.ToDouble(this.textBoxP1EnterPrice.Text);
                double P2 = System.Convert.ToDouble(this.textBoxP2StopLossPrice.Text);
                int T = P1 > P2 ? 1 : -1;
                double positionSize = (equity * (riskPercent / 100)) / (T * (P1 - P2));

                positionSize = Math.Round(positionSize, 2);

                this.textBoxPositionSize3.Text = positionSize.ToString();
                this.textBoxPositionSize2.Text = positionSize.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ensure you filled in correct data! ({ex.Message})");
            }
        }
    }
}
