namespace WinFormÜbung
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menueTop = new System.Windows.Forms.MenuStrip();
            this.dateiMBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenMBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.schriftMBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.FarbeBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeMBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.exitBtn = new System.Windows.Forms.Button();
            this.menueTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // menueTop
            // 
            this.menueTop.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menueTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiMBtn,
            this.bearbeitenMBtn,
            this.hilfeMBtn});
            this.menueTop.Location = new System.Drawing.Point(0, 0);
            this.menueTop.Name = "menueTop";
            this.menueTop.Size = new System.Drawing.Size(800, 24);
            this.menueTop.TabIndex = 0;
            this.menueTop.Text = "menuTop";
            this.menueTop.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dateiMBtn
            // 
            this.dateiMBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMBtn});
            this.dateiMBtn.Name = "dateiMBtn";
            this.dateiMBtn.Size = new System.Drawing.Size(46, 20);
            this.dateiMBtn.Text = "Datei";
            // 
            // exitMBtn
            // 
            this.exitMBtn.Name = "exitMBtn";
            this.exitMBtn.Size = new System.Drawing.Size(93, 22);
            this.exitMBtn.Text = "Exit";
            // 
            // bearbeitenMBtn
            // 
            this.bearbeitenMBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schriftMBtn,
            this.FarbeBtn});
            this.bearbeitenMBtn.Name = "bearbeitenMBtn";
            this.bearbeitenMBtn.Size = new System.Drawing.Size(75, 20);
            this.bearbeitenMBtn.Text = "Bearbeiten";
            // 
            // schriftMBtn
            // 
            this.schriftMBtn.Name = "schriftMBtn";
            this.schriftMBtn.Size = new System.Drawing.Size(108, 22);
            this.schriftMBtn.Text = "Schrift";
            // 
            // FarbeBtn
            // 
            this.FarbeBtn.Name = "FarbeBtn";
            this.FarbeBtn.Size = new System.Drawing.Size(108, 22);
            this.FarbeBtn.Text = "Farbe";
            // 
            // hilfeMBtn
            // 
            this.hilfeMBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMBtn});
            this.hilfeMBtn.Name = "hilfeMBtn";
            this.hilfeMBtn.Size = new System.Drawing.Size(44, 20);
            this.hilfeMBtn.Text = "Hilfe";
            // 
            // aboutMBtn
            // 
            this.aboutMBtn.Name = "aboutMBtn";
            this.aboutMBtn.Size = new System.Drawing.Size(107, 22);
            this.aboutMBtn.Text = "About";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(479, 320);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.menueTop);
            this.MainMenuStrip = this.menueTop;
            this.Name = "Form1";
            this.Text = "WinFormÜbung";
            this.menueTop.ResumeLayout(false);
            this.menueTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menueTop;
        private System.Windows.Forms.ToolStripMenuItem dateiMBtn;
        private System.Windows.Forms.ToolStripMenuItem exitMBtn;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenMBtn;
        private System.Windows.Forms.ToolStripMenuItem schriftMBtn;
        private System.Windows.Forms.ToolStripMenuItem FarbeBtn;
        private System.Windows.Forms.ToolStripMenuItem hilfeMBtn;
        private System.Windows.Forms.ToolStripMenuItem aboutMBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

