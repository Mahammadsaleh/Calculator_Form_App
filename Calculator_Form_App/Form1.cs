using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Form_App
{
    public partial class Form1 : Form
    {
        double result =0; // for find result and save it
        String operation = ""; // for saving
        public Form1()
        {
            InitializeComponent();
        }

        private void numberClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBoxResult.Text == "0")
            {
                textBoxResult.Clear();
            }
            if (button.Text == ",")
            {
                if (!textBoxResult.Text.Contains(","))
                {
                    textBoxResult.Text = textBoxResult.Text + button.Text;
                }
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + button.Text;
            }
            
        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = Convert.ToDouble(textBoxResult.Text);
            operationSaverText.Text = result + operation;
            textBoxResult.Clear();
        }

        private void equalClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (operation)
            {
                case "+":
                    textBoxResult.Text = (result + Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (result - Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (result * Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (result / Double.Parse(textBoxResult.Text)).ToString();
                    break;
            }
            result = Double.Parse(textBoxResult.Text);
            operationSaverText.Text = "";
        }

        private void difOperatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
           
            switch (button.Text)
            {
                case "%":
                    textBoxResult.Text = (Double.Parse(textBoxResult.Text)/100).ToString();
                    break;
                case "1/x":
                    textBoxResult.Text = (1/Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "√":
                    textBoxResult.Text = Math.Sqrt(Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "±":
                    textBoxResult.Text = (-Double.Parse(textBoxResult.Text)).ToString();
                    break;
            }
           
        }
        private void clearAllClick(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            operationSaverText.Text = "";
            result = 0;
        }

        private void clearLastOperationClick(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void clearClick(object sender, EventArgs e)
        {
            if (textBoxResult.TextLength>0)
            {
                textBoxResult.Text = textBoxResult.Text.Remove(textBoxResult.TextLength - 1);
            }
        }

        private void clearMemory(object sender, EventArgs e)
        {
            result = 0;
            operationSaverText.Text = "";
        }
    }
}
