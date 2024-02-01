using Calculol.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculol
{
    public partial class CalculatorMainScreen : Form
    {
        ViewModel viewModel;

        public CalculatorMainScreen()
        {
            InitializeComponent();
            viewModel = new ViewModel();
        }

        private void Number1Button_Click(object sender, EventArgs e)
        {
            viewModel.AddToEq('1');
            InputTextBox.Text = viewModel.Equation;
        }

        private void Number2Button_Click(object sender, EventArgs e)
        {
            viewModel.AddToEq('2');
            InputTextBox.Text = viewModel.Equation;
        }

        private void Number3Button_Click(object sender, EventArgs e)
        {
            viewModel.AddToEq('3');
            InputTextBox.Text = viewModel.Equation;
        }

        private void Number4Button_Click(object sender, EventArgs e)
        {
            viewModel.AddToEq('4');
            InputTextBox.Text = viewModel.Equation;
        }

        private void Number5Button_Click(object sender, EventArgs e)
        {
            viewModel.AddToEq('5');
            InputTextBox.Text = viewModel.Equation;
        }

        private void Number6Button_Click(object sender, EventArgs e)
        {
            viewModel.AddToEq('6');
            InputTextBox.Text = viewModel.Equation;
        }

        private void Number7Button_Click(object sender, EventArgs e)
        {
            viewModel.AddToEq('7');
            InputTextBox.Text = viewModel.Equation;
        }

        private void Number8Button_Click(object sender, EventArgs e)
        {
            viewModel.AddToEq('8');
            InputTextBox.Text = viewModel.Equation;
        }

        private void Number9Button_Click(object sender, EventArgs e)
        {
            viewModel.AddToEq('9');
            InputTextBox.Text = viewModel.Equation;
        }

        private void Number0Button_Click(object sender, EventArgs e)
        {
            viewModel.AddToEq('0');
            InputTextBox.Text = viewModel.Equation;
        }

        private void OperatorPlusButton_Click(object sender, EventArgs e)
        {
            viewModel.AddToEq('+');
            InputTextBox.Text = viewModel.Equation;
        }

        private void OperatorMinusButton_Click(object sender, EventArgs e)
        {
            viewModel.AddToEq('-');
            InputTextBox.Text = viewModel.Equation;
        }

        private void OperatorMultButton_Click(object sender, EventArgs e)
        {
            viewModel.AddToEq('*');
            InputTextBox.Text = viewModel.Equation;
        }

        private void OperatorDivButton_Click(object sender, EventArgs e)
        {
            viewModel.AddToEq('/');
            InputTextBox.Text = viewModel.Equation;
        }

        private void OperatorBracketStartButton_Click(object sender, EventArgs e)
        {
            viewModel.AddToEq('(');
            InputTextBox.Text = viewModel.Equation;
        }

        private void OperatorBracketEndButton_Click(object sender, EventArgs e)
        {
            viewModel.AddToEq(')');
            InputTextBox.Text = viewModel.Equation;
        }

        private void EraseCharButton_Click(object sender, EventArgs e)
        {
            viewModel.EraseFromEq();
            InputTextBox.Text = viewModel.Equation;
        }

        private void OperatorEqButton_Click(object sender, EventArgs e)
        {
            viewModel.Parse();
            label1.Text = viewModel.EquationOut;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewModel.Evaluate();
        }
    }
}
