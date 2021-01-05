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

        Form2 view;
        public Form1() {
            InitializeComponent();
            view = new Form2(this);
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
            // double zahl01 = Convert.ToDouble(tbMulDiv1.Text);
            // double zahl02 = Convert.ToDouble(tbMulDiv2.Text);
            // lblOutputMulDiv.Text = "= " + Convert.ToString(Multiplizieren(zahl01, zahl02));
            lblOutputMulDiv.Text = "= " + (Multiplizieren(double.Parse(tbMulDiv1.Text), double.Parse(tbMulDiv2.Text))).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e) {
            // double zahl01 = Convert.ToDouble(tbMulDiv1.Text);
            // double zahl02 = Convert.ToDouble(tbMulDiv2.Text);
            // lblOutputMulDiv.Text = "= " + Convert.ToString(Dividieren(zahl01, zahl02));
            lblOutputMulDiv.Text = "= " + (Dividieren(double.Parse(tbMulDiv1.Text), double.Parse(tbMulDiv2.Text))).ToString();
        }

        private void btnFak_Click(object sender, EventArgs e) {
            // ushort zahl03 = Convert.ToUInt16(tbFak.Text);
            // lblOutputFak.Text = "= " + Convert.ToString(Fakultaet(zahl03));
            lblOutputFak.Text = "= " + (Fakultaet(ushort.Parse(tbFak.Text))).ToString();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Hide();
            view.Show();
        }
    }
}
