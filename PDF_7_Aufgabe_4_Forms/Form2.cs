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
    public partial class Form2 : Form {

        Form1 mainView;
        public Form2(Form1 view) {
            InitializeComponent();
            this.mainView = view;
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Hide();
            mainView.Show();
        }
    }
}
