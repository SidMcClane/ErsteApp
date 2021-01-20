using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PDF7_3__Nimm_Spiel_ {
    public partial class NimMKK : Form {
        public NimMKK() {
            InitializeComponent();
        }
        

        public void BtnTorchSelfUnVisible(object sender, EventArgs e) {
            ((Button)sender).Visible = false;
        }

        private void BtnStartGame(object sender, EventArgs e) {
            Torch1.Visible = true;
            Torch2.Visible = true;
            Torch3.Visible = true;
            Torch4.Visible = true;
            Torch5.Visible = true;
            Torch6.Visible = true;
            Torch7.Visible = true;
            Torch8.Visible = true;
            Torch9.Visible = true;
            Torch10.Visible = true;
            Torch11.Visible = true;
            Torch12.Visible = true;
            Torch13.Visible = true;
            Torch14.Visible = true;
            Torch15.Visible = true;
            Torch24.Visible = true;
            Torch25.Visible = true;
            Torch26.Visible = true;
            Torch27.Visible = true;
            Torch28.Visible = true;
            Torch29.Visible = true;
            Torch30.Visible = true;
            Torch31.Visible = true;
            Torch32.Visible = true;
            Torch33.Visible = true;
            Torch34.Visible = true;
            Torch35.Visible = true;
            Torch36.Visible = true;
            Torch37.Visible = true;
            Torch38.Visible = true;
            Torch39.Visible = true;
            Torch40.Visible = true;
            Torch41.Visible = true;
            Torch42.Visible = true;
            Torch43.Visible = true;
            Torch44.Visible = true;
            Torch45.Visible = true;
            Torch47.Visible = true;
            Torch48.Visible = true;
            Torch49.Visible = true;
            Torch50.Visible = true;
            Torch51.Visible = true;

        }



        /*private void BtnStartGame(object sender, EventArgs e) {
            Button torch = new Torch();
        }*/

        private void button23_Click(object sender, EventArgs e) {
            BtnPlayer2.Visible = true;
            BtnNPCez.Visible = false;
            BtnNPChard.Visible = false;

        }
        private void button22_Click(object sender, EventArgs e) {
            BtnPlayer2.Visible = false;
            BtnNPCez.Visible = true;
            BtnNPChard.Visible = false;

        }
        private void button21_Click(object sender, EventArgs e) {
            BtnPlayer2.Visible = false;
            BtnNPCez.Visible = false;
            BtnNPChard.Visible = true;

        }
        List<Button> buttons = new List<Button>();
    }
}
