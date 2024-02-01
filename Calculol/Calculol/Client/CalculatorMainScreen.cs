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
            viewModel.addToEq('1');
            InputTextBox.Text = viewModel.Equation;
        }

        private void Number2Button_Click(object sender, EventArgs e)
        {
            viewModel.addToEq('2');
            InputTextBox.Text = viewModel.Equation;
        }

        private void Number3Button_Click(object sender, EventArgs e)
        {
            viewModel.addToEq('3');
            InputTextBox.Text = viewModel.Equation;
        }

        private void Number4Button_Click(object sender, EventArgs e)
        {
            viewModel.addToEq('4');
            InputTextBox.Text = viewModel.Equation;
        }

        private void Number5Button_Click(object sender, EventArgs e)
        {
            viewModel.addToEq('5');
            InputTextBox.Text = viewModel.Equation;
        }

        private void Number6Button_Click(object sender, EventArgs e)
        {
            viewModel.addToEq('6');
            InputTextBox.Text = viewModel.Equation;
        }

        private void Number7Button_Click(object sender, EventArgs e)
        {
            viewModel.addToEq('7');
            InputTextBox.Text = viewModel.Equation;
        }

        private void Number8Button_Click(object sender, EventArgs e)
        {
            viewModel.addToEq('8');
            InputTextBox.Text = viewModel.Equation;
        }

        private void Number9Button_Click(object sender, EventArgs e)
        {
            viewModel.addToEq('9');
            InputTextBox.Text = viewModel.Equation;
        }

        private void Number0Button_Click(object sender, EventArgs e)
        {
            viewModel.addToEq('0');
            InputTextBox.Text = viewModel.Equation;
        }
    }
}
