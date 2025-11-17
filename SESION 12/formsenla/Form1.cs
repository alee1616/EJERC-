using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace formsenla
{
    public partial class Form1 : Form
    {
        private Label lblResultado;
        private TextBox txtA;
        private TextBox txtB;

        public Form1()
        {
            InitializeComponent();

            lblResultado = new Label();
            lblResultado.Location = new Point(10, 100);
            lblResultado.Size = new Size(100, 23);
            lblResultado.Name = "lblResultado";
            this.Controls.Add(lblResultado);

            txtA = new TextBox();
            txtA.Location = new Point(10, 20);
            txtA.Size = new Size(100, 23);
            txtA.Name = "txtA";
            this.Controls.Add(txtA);

            txtB = new TextBox();
            txtB.Location = new Point(10, 50);
            txtB.Size = new Size(100, 23);
            txtB.Name = "txtB";
            this.Controls.Add(txtB);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void otrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ejemplo de menu, menu en c#");
        }

        // Normalize input and try multiple parsing strategies to avoid false "empty" or culture issues.
        private bool TryGetInputs(out double a, out double b)
        {
            a = 0;
            b = 0;

            // Raw texts as entered
            string rawA = txtA.Text ?? string.Empty;
            string rawB = txtB.Text ?? string.Empty;

            // Remove common invisible whitespace (non-breaking space etc.) and trim
            rawA = NormalizeWhitespace(rawA);
            rawB = NormalizeWhitespace(rawB);

            if (string.IsNullOrWhiteSpace(rawA))
            {
                MessageBox.Show("Ingrese un valor para A.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtA.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(rawB))
            {
                MessageBox.Show("Ingrese un valor para B.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtB.Focus();
                return false;
            }

            // Try parsing using several strategies:
            // 1) Current culture
            // 2) Invariant culture
            // 3) Swap common decimal separators (useful if user typed '.' but culture expects ',')
            var culture = CultureInfo.CurrentCulture;
            var styles = NumberStyles.Float | NumberStyles.AllowThousands;

            if (double.TryParse(rawA, styles, culture, out a) &&
                double.TryParse(rawB, styles, culture, out b))
            {
                return true;
            }

            // Try invariant (accepts '.' decimal)
            if (double.TryParse(rawA, styles, CultureInfo.InvariantCulture, out a) &&
                double.TryParse(rawB, styles, CultureInfo.InvariantCulture, out b))
            {
                return true;
            }

            // Try swapping separators heuristically
            string swappedA = SwapDecimalSeparators(rawA, culture);
            string swappedB = SwapDecimalSeparators(rawB, culture);

            if (double.TryParse(swappedA, styles, culture, out a) &&
                double.TryParse(swappedB, styles, culture, out b))
            {
                return true;
            }

            // If any parse failed, show a clear message mentioning the raw values and culture
            string message = string.Format("Valores inválidos para la cultura {0}.\nA: '{1}'\nB: '{2}'", culture.Name, rawA, rawB);
            MessageBox.Show(message, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // Focus the first invalid control
            if (!double.TryParse(rawA, styles, culture, out _))
                txtA.Focus();
            else
                txtB.Focus();

            return false;
        }

        // Replace NBSP and other non-standard spaces, then trim
        private static string NormalizeWhitespace(string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            // Replace common non-breaking spaces with normal space
            s = s.Replace('\u00A0', ' ');
            s = s.Replace('\u2007', ' ');
            s = s.Replace('\u202F', ' ');
            // Remove other control chars except digits, signs, separators, E/e
            // Keep it simple: trim and collapse inner control chars
            var sb = new StringBuilder(s.Length);
            foreach (char c in s)
            {
                if (!char.IsControl(c))
                    sb.Append(c);
            }
            return sb.ToString().Trim();
        }

        // If culture decimal is ',' and text contains '.', swap '.' -> ',' (and viceversa).
        private static string SwapDecimalSeparators(string input, CultureInfo culture)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            string dec = culture.NumberFormat.NumberDecimalSeparator;
            string other = dec == "," ? "." : ",";

            // If input already uses culture decimal, return as-is
            if (input.Contains(dec) && !input.Contains(other))
                return input;

            // If input contains the other separator, replace it with culture separator.
            // Also remove thousands separators that conflict.
            string thousandSep = culture.NumberFormat.NumberGroupSeparator;
            string otherThousand = thousandSep == "," ? "." : ",";

            string temp = input.Replace(other, dec);

            // If both separators are present (ambiguous), remove group separators (both varieties)
            temp = temp.Replace(thousandSep, string.Empty).Replace(otherThousand, string.Empty);

            return temp;
        }

        private void sumarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b))
                return;

            double suma = a + b;
            lblResultado.Text = suma.ToString(CultureInfo.CurrentCulture);
        }

        private void restarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b))
                return;

            double resta = a - b;
            lblResultado.Text = resta.ToString(CultureInfo.CurrentCulture);
        }

        private void multiplicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b))
                return;

            double multi = a * b;
            lblResultado.Text = multi.ToString(CultureInfo.CurrentCulture);
        }

        private void divisiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b))
                return;

            if (b == 0)
            {
                MessageBox.Show("No se puede dividir entre cero.");
                return;
            }

            double division = a / b;
            lblResultado.Text = division.ToString(CultureInfo.CurrentCulture);
        }
    }
}
