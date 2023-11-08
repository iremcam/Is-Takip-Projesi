using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Formlar
{
    public partial class XtraForm7 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm7()
        {
            InitializeComponent();
        }

        string currentInput = "";
        double result = 0;
        char currentOperator = ' ';



        private void NumberButton_Click(object sender, EventArgs e)
        {
            SimpleButton button = (SimpleButton)sender;
            currentInput += button.Text;
            richTextBox1.Text = currentInput;
        }



        private void OperatorButton_Click(object sender, EventArgs e)
        {
            SimpleButton button = (SimpleButton)sender;
            currentOperator = button.Text[0];
            result = double.Parse(currentInput);
            currentInput = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            currentInput = "";
            result = 0;
            currentOperator = ' ';
            richTextBox1.Text = "0";
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {

            if (currentOperator != ' ')
            {
                double operand = double.Parse(currentInput);
                switch (currentOperator)
                {
                    case '+':
                        result += operand;
                        break;
                    case '-':
                        result -= operand;
                        break;
                    case '*':
                        result *= operand;
                        break;
                    case '%':
                        if (operand != 0)
                        {
                            result %= operand;
                        }
                        else
                        {
                            result = 0;
                        }
                        break;
                    case '/':
                        if (operand != 0)
                            result /= operand;
                        else
                            result = double.NaN;
                        break;
                }
                richTextBox1.Text = result.ToString();
                currentOperator = ' ';
                currentInput = "";
            }

        }


    }
}