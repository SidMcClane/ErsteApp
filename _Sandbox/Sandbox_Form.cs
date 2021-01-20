using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sandbox {
    public partial class Sandbox : Form {
        public Sandbox() {
            InitializeComponent();
        }

        int torchCount = 0;
        int x = 160; //+60
        int y = 40; //+140
        int count = 30;


        private void button1_Click(object sender, EventArgs e) {
            /*
            Button torchy = new Torch();
            torchy.Location = new Point(160, 40);
            this.Controls.Add(torchy);
*/
            /*if (Torch.GetType() == typeof(Torch)) {
                torchCount++;
            }*/



            lblAusgabe.Text = torchCount.ToString();




        }


        

        private void button2_Click(object sender, EventArgs e) {
            /*
            List<Torch> torchList = new List<Torch>();
            for (int i = 0; i < count; i++) {
                torchList.Add(new Torch());
            }
            for (int i = 0; i < torchList.Count; i++) {

            }
            */

            for (int i = 0; i < count; i++) {
                Torch torchy = new Torch();
                torchy.Location = new Point(x, y);
                torchy.Click += new System.EventHandler(torchy.BtnTorchSelfUnVisible);

                if (x < 760) {
                    x += 60;
                } else {
                    x = 160;
                    y += 140;
                }
                Controls.Add(torchy);
            }
            x = 160;
            y = 40;

            /*
            List<Torch> torchys = new List<Torch>();
            torchys.Add(new Torch());
            lblAusgabe.Text = (torchys.Count).ToString();
            this.Controls.Add(torchys[0]);
            */
        }
    }
}
