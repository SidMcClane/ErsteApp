using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF_7_Aufgabe_4_Forms {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }


        // Berechnungen
        static double Multiplizieren(double zahl01, double zahl02) {
            return zahl01 * zahl02;
        }
        static double Dividieren(double zahl01, double zahl02) {
            return zahl01 / zahl02;
        }
        static ulong Fakultaet(ulong fak) {
            ulong fakSum = 1;
            for (ulong i = 1; i <= fak; i++) {
                fakSum *= i;
            }
            return fakSum;
        }

        private void btnMul_Click(object sender, EventArgs e) {
            double zahl01 = Convert.ToDouble(tbMulDiv1.Text);
            double zahl02 = Convert.ToDouble(tbMulDiv2.Text);
            lblOutputMulDiv.Text = "= " + Convert.ToString(Multiplizieren(zahl01, zahl02));
        }

        private void btnDiv_Click(object sender, EventArgs e) {
            double zahl01 = Convert.ToDouble(tbMulDiv1.Text);
            double zahl02 = Convert.ToDouble(tbMulDiv2.Text);
            lblOutputMulDiv.Text = "= " + Convert.ToString(Dividieren(zahl01, zahl02));
        }

        private void btnFak_Click(object sender, EventArgs e) {
            ushort zahl03 = Convert.ToUInt16(tbFak.Text);
            lblOutputFak.Text = "= " + Convert.ToString(Fakultaet(zahl03));
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
