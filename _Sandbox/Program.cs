using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sandbox {
    static class Program {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Sandbox());
        }
    }



    public class Torch : Button {
        // Object
        public Torch() {
            Size = new System.Drawing.Size(21, 111);
            Visible = true;
            Name = "Heurika";
            Text = "Heurika";
        }


        // Methods
        public void BtnTorchSelfUnVisible(object sender, EventArgs e) {
            ((Button)sender).Visible = false;
            
            //((Button)sender).Controls.Remove((Button)sender);
        }
        /*public void BtnTorchSelfRemove(object sender, EventArgs e) {
            ((Button)sender).Click += new System.EventHandler(Controls.Remove((Control)sender));
            ((Button)sender).Click += ;
        }*/

    }
}
