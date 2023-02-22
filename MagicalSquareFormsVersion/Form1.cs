using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicalSquareFormsVersion
{
    public partial class Form1 : Form
    {
        Logic logic = new Logic();
        public Form1()
        {
            InitializeComponent();
        }

        private void b_Rules_Click(object sender, EventArgs e)
        {
            if (bGuess.Enabled)
                bGuess.Enabled = false;
            tGuess.Visible = false;
            tGenerate.Visible = false;
            tRules.Visible = !tRules.Visible;
            b_Generate.Enabled = !tRules.Visible;

            if (tRules.Visible)
                tRules.Text = "Game rules: guess any two-digit number, subtract its components from it (For example, 99 = 99 - 9 - 9 = 81), look at the selected symbol for 5 seconds and click guess.\nTo close this window, click Rules again.";
        }

        private void b_Generate_Click(object sender, EventArgs e)
        {
            b_Generate.Enabled = false;
            bGuess.Enabled = true;
            tGenerate.Text = "";
            tGuess.Visible = false;
            if (!tGenerate.Visible)
                tGenerate.Visible = true;

            var mas = logic.GenerateMas();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j != mas.Length - 1)
                    {
                        tGenerate.Text += $"{i}{j} {mas[i, j]}\t";
                    }
                    else
                    {
                        tGenerate.Text += $"{i}{j} {mas[i, j]}\n";
                    }
                }
            }
        }

        private void bGuess_Click(object sender, EventArgs e)
        {
            b_Generate.Enabled = true;
            bGuess.Enabled = false;
            tGuess.Text = "";
            tGuess.Visible = true;
            tGuess.Text = $"You guessed:\n{logic.diagonalSymb}";
        }

    }
}
