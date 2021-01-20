using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PDF7_3__Nimm_Spiel_ {
    class Torch : Button {
        public Torch() {
            BackColor = System.Drawing.Color.Transparent;
            //BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Torch3.BackgroundImage")));
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Cursor = System.Windows.Forms.Cursors.Hand;
            FlatAppearance.BorderSize = 0;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Location = new System.Drawing.Point(160, 40);
            Name = "Torch";
            Size = new System.Drawing.Size(21, 111);
            TabIndex = 0;
            UseVisualStyleBackColor = true;
            Visible = true;
            //Click += new EventHandler(this.);
        }


    }
}
