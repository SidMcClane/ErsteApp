
namespace PDF_7_Aufgabe_4_Forms {
    partial class Form1 {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbMulDiv1 = new System.Windows.Forms.TextBox();
            this.tbMulDiv2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbFak = new System.Windows.Forms.TextBox();
            this.lblMulDiv = new System.Windows.Forms.Label();
            this.lblOutputMulDiv = new System.Windows.Forms.Label();
            this.lblFak = new System.Windows.Forms.Label();
            this.lblOutputFak = new System.Windows.Forms.Label();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnFak = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMulDiv1
            // 
            this.tbMulDiv1.Location = new System.Drawing.Point(94, 26);
            this.tbMulDiv1.Name = "tbMulDiv1";
            this.tbMulDiv1.Size = new System.Drawing.Size(78, 20);
            this.tbMulDiv1.TabIndex = 0;
            // 
            // tbMulDiv2
            // 
            this.tbMulDiv2.Location = new System.Drawing.Point(178, 26);
            this.tbMulDiv2.Name = "tbMulDiv2";
            this.tbMulDiv2.Size = new System.Drawing.Size(78, 20);
            this.tbMulDiv2.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbFak
            // 
            this.tbFak.Location = new System.Drawing.Point(94, 96);
            this.tbFak.Name = "tbFak";
            this.tbFak.Size = new System.Drawing.Size(78, 20);
            this.tbFak.TabIndex = 4;
            // 
            // lblMulDiv
            // 
            this.lblMulDiv.AutoSize = true;
            this.lblMulDiv.Location = new System.Drawing.Point(91, 10);
            this.lblMulDiv.Name = "lblMulDiv";
            this.lblMulDiv.Size = new System.Drawing.Size(125, 13);
            this.lblMulDiv.TabIndex = 8;
            this.lblMulDiv.Text = "Multiplizieren / Dividieren";
            // 
            // lblOutputMulDiv
            // 
            this.lblOutputMulDiv.AutoSize = true;
            this.lblOutputMulDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputMulDiv.Location = new System.Drawing.Point(262, 29);
            this.lblOutputMulDiv.Name = "lblOutputMulDiv";
            this.lblOutputMulDiv.Size = new System.Drawing.Size(22, 17);
            this.lblOutputMulDiv.TabIndex = 9;
            this.lblOutputMulDiv.Text = "= ";
            // 
            // lblFak
            // 
            this.lblFak.AutoSize = true;
            this.lblFak.Location = new System.Drawing.Point(91, 80);
            this.lblFak.Name = "lblFak";
            this.lblFak.Size = new System.Drawing.Size(45, 13);
            this.lblFak.TabIndex = 10;
            this.lblFak.Text = "Fakultät";
            // 
            // lblOutputFak
            // 
            this.lblOutputFak.AutoSize = true;
            this.lblOutputFak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputFak.Location = new System.Drawing.Point(262, 99);
            this.lblOutputFak.Name = "lblOutputFak";
            this.lblOutputFak.Size = new System.Drawing.Size(22, 17);
            this.lblOutputFak.TabIndex = 11;
            this.lblOutputFak.Text = "= ";
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(13, 24);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(75, 23);
            this.btnMul.TabIndex = 2;
            this.btnMul.Text = "Multiplizieren";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnFak
            // 
            this.btnFak.Location = new System.Drawing.Point(13, 94);
            this.btnFak.Name = "btnFak";
            this.btnFak.Size = new System.Drawing.Size(75, 23);
            this.btnFak.TabIndex = 5;
            this.btnFak.Text = "Fakultät";
            this.btnFak.UseVisualStyleBackColor = true;
            this.btnFak.Click += new System.EventHandler(this.btnFak_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(13, 53);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 3;
            this.btnDiv.Text = "Dividieren";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 136);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnFak);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.lblOutputFak);
            this.Controls.Add(this.lblFak);
            this.Controls.Add(this.lblOutputMulDiv);
            this.Controls.Add(this.lblMulDiv);
            this.Controls.Add(this.tbFak);
            this.Controls.Add(this.tbMulDiv2);
            this.Controls.Add(this.tbMulDiv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(490, 175);
            this.MinimumSize = new System.Drawing.Size(490, 175);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MulDivFak-Rechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMulDiv1;
        private System.Windows.Forms.TextBox tbMulDiv2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbFak;
        private System.Windows.Forms.Label lblMulDiv;
        private System.Windows.Forms.Label lblOutputMulDiv;
        private System.Windows.Forms.Label lblFak;
        private System.Windows.Forms.Label lblOutputFak;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnFak;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button button1;
    }
}
