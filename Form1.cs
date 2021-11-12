using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        string selectedOperator;
        int acumulatedValue;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumberAction_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int buttonValue = int.Parse(button.Text);
            int currentValue = int.Parse(txtValores.Text);
            currentValue = currentValue * 10 + buttonValue;
            txtValores.Text = currentValue.ToString();
        }

        private void OperatorAction_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            selectedOperator = button.Text;
            acumulatedValue = int.Parse(txtValores.Text);
            txtValores.Text = "0";

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtValores.Text="0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            int secondAcumulatedValue = int.Parse(txtValores.Text);
            int result = 0;

            if (selectedOperator == "+")
            {
                result = acumulatedValue + secondAcumulatedValue;
            }
            else if (selectedOperator == "*")
            {
                result = acumulatedValue * secondAcumulatedValue;
            }
            else if (selectedOperator=="-") 
            {
                result = acumulatedValue - secondAcumulatedValue;
            }
            else if (selectedOperator == "/")
            {
                result = acumulatedValue / secondAcumulatedValue;
            }
            txtValores.Text = result.ToString();
        }
    }
}
