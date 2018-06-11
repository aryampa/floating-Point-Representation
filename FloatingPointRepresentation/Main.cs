using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloatingPointRepresentation
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxDecInput.BackColor == Color.Red) throw new Exception("Invalid Decimal Input");
                else {
                    double y = double.Parse(tbxDecInput.Text);

                    int s = 0;

                    if (y < 0) s = 1;
                    else s = 0;

                    double z = Math.Abs(y);

                    double p = Math.Floor((Math.Log10(z)) / (Math.Log10(2)));

                    double twoPowerTwentyThreeMinusP = Math.Pow(2,(23-p));

                    long j = (long) Math.Round(z * twoPowerTwentyThreeMinusP);

                    HexEngine dec2Hex = new HexEngine(j.ToString(), Bases.bases.DEC);

                    string dec2HexString = dec2Hex.ConvertFromDec();

                    BinaryEngine hex2Bin = new BinaryEngine(dec2HexString, Bases.bases.HEX);

                    string hex2BinString = hex2Bin.ConvertFromHex();

                    string significandString = hex2BinString.Substring(1);

                    BinaryEngine dec2Bin_for_Exponent = new BinaryEngine((127 + p).ToString(), Bases.bases.DEC);
                    string exponentString = dec2Bin_for_Exponent.ConvertFromDecimal();

                    lblSign.Text = s.ToString();
                    lblExponent.Text = exponentString;
                    lblSignificand.Text = significandString;
                    lblHEX.Text = new HexEngine(lblSign.Text + lblExponent.Text + lblSignificand.Text, Bases.bases.BIN).convertFromBinary();

                    lblAnsHEX.Text = dec2HexString;
                    lblAnsBin.Text = hex2BinString;

                }
                
                
            }

            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }

         
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void tbxDecInput_TextChanged(object sender, EventArgs e)
        {
            string allowedCharacters = "-+.";
            Boolean hasNonDigit = false;
            foreach (char tbxChar in tbxDecInput.Text) {
                if (!char.IsDigit(tbxChar)) {
                    if (allowedCharacters.Contains(tbxChar)) { }
                    else hasNonDigit = true;
                }
            }

            if (hasNonDigit) tbxDecInput.BackColor = Color.Red;
            else tbxDecInput.BackColor = Color.White;
        }

        
    }
}
