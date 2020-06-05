using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Week2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtOperand1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers in operand ");
                //Variable Defined and value assigned

                String Operator_cal = txtOperator.Text;
                decimal Input_Operand1 = Convert.ToDecimal(txtOperand1.Text);


                decimal Input_Operand2 = Convert.ToDecimal(txtOperand2.Text);
                decimal result = 0;


                //If else conditions for operator input
                //this is test

                if (Operator_cal == "+")
                {
                    result = Input_Operand1 + Input_Operand2;
                }

                else if (Operator_cal == "-")
                {
                    result = Input_Operand1 - Input_Operand2;
                }
                else if (Operator_cal == "/")
                {
                    result = Input_Operand1 / Input_Operand2;
                }
                else if (Operator_cal == "*")
                {
                    result = Input_Operand1 * Input_Operand2;
                }
                else if (Operator_cal == "^")
                {
                    result = 1;
                    //2


                    for (int i = 0; i <= Input_Operand2 - 1; i++)
                    {
                        result = result * Input_Operand1;

                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Input for Operator ");
                }

                // for result text in Resut textinput
                txtResult.Text = result.ToString();
                result = 0;



            }
        }
        // For Window form exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}