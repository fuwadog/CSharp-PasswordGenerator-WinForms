using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void upperCHK_CheckedChanged(object sender, EventArgs e) { }
        private void lowerCHK_CheckedChanged(object sender, EventArgs e) { }
        private void numberCHK_CheckedChanged(object sender, EventArgs e) { }
        private void symbolCHK_CheckedChanged(object sender, EventArgs e) { }

        private void generateBTN_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(lengthTXT.Text, out int length) || length < 1)
            {
                MessageBox.Show("Enter a valid password length.", "Invalid Length");
                return;
            }

            string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lower = "abcdefghijklmnopqrstuvwxyz";
            string numbers = "0123456789";
            string symbols = "!@#$%^&*()_-+=<>?/{}[]|";

            StringBuilder pool = new StringBuilder();
            StringBuilder password = new StringBuilder();

            if (upperCHK.Checked)
            {
                pool.Append(upper);
                password.Append(upper[rnd.Next(upper.Length)]);
            }

            if (lowerCHK.Checked)
            {
                pool.Append(lower);
                password.Append(lower[rnd.Next(lower.Length)]);
            }

            if (numberCHK.Checked)
            {
                pool.Append(numbers);
                password.Append(numbers[rnd.Next(numbers.Length)]);
            }

            if (symbolCHK.Checked)
            {
                pool.Append(symbols);
                password.Append(symbols[rnd.Next(symbols.Length)]);
            }

            if (pool.Length == 0)
            {
                MessageBox.Show("Select at least one character type.", "Nothing Selected");
                return;
            }

            while (password.Length < length)
            {
                password.Append(pool[rnd.Next(pool.Length)]);
            }

            string finalPassword = Shuffle(password.ToString());
            outputTXT.Text = finalPassword;

            UpdateStrength(finalPassword);
        }

        private void copyBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(outputTXT.Text))
                return;

            Clipboard.SetText(outputTXT.Text);

            notifyLBL.Text = "Copied!";
            notifyLBL.Visible = true;

            copyTMR.Start();
        }

        private void strengthBar_Click(object sender, EventArgs e) { }

        private string Shuffle(string input)
        {
            return new string(input.OrderBy(x => rnd.Next()).ToArray());
        }

        private void UpdateStrength(string password)
        {
            int score = 0;

            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasNumber = password.Any(char.IsDigit);
            bool hasSymbol = password.Any(ch => !char.IsLetterOrDigit(ch));

            int length = password.Length;

            if (hasUpper) score += 20;
            if (hasLower) score += 20;
            if (hasNumber) score += 20;
            if (hasSymbol) score += 20;
            if (length >= 12) score += 20;
            else if (length >= 8) score += 10;

            if (score > 100) score = 100;

            strengthBar.Value = score;

            strLBL.Text = $"Strength: {score}%";
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            lengthTXT.Text = "";

            upperCHK.Checked = false;
            lowerCHK.Checked = false;
            numberCHK.Checked = false;
            symbolCHK.Checked = false;

            outputTXT.Text = "";
            strengthBar.Value = 0;

            strLBL.Text = "Strength: 0%";
        }

        private void copyTMR_Tick(object sender, EventArgs e)
        {
            notifyLBL.Visible = false;
            copyTMR.Stop();
        }
    }
}
