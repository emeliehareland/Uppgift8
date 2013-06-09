namespace Uppgift8
{
    partial class Huvudfönster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.medlemshanteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medlemsregisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.läggTillNySpelareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tävlingsverksamhetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registeraTävlingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anmälDeltagareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registreraResultatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medlemshanteringToolStripMenuItem,
            this.tävlingsverksamhetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(256, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // medlemshanteringToolStripMenuItem
            // 
            this.medlemshanteringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medlemsregisterToolStripMenuItem,
            this.läggTillNySpelareToolStripMenuItem});
            this.medlemshanteringToolStripMenuItem.Name = "medlemshanteringToolStripMenuItem";
            this.medlemshanteringToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.medlemshanteringToolStripMenuItem.Text = "Medlemshantering";
            this.medlemshanteringToolStripMenuItem.Click += new System.EventHandler(this.medlemshanteringToolStripMenuItem_Click);
            // 
            // medlemsregisterToolStripMenuItem
            // 
            this.medlemsregisterToolStripMenuItem.Name = "medlemsregisterToolStripMenuItem";
            this.medlemsregisterToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.medlemsregisterToolStripMenuItem.Text = "Medlemsregister";
            this.medlemsregisterToolStripMenuItem.Click += new System.EventHandler(this.medlemsregisterToolStripMenuItem_Click);
            // 
            // läggTillNySpelareToolStripMenuItem
            // 
            this.läggTillNySpelareToolStripMenuItem.Name = "läggTillNySpelareToolStripMenuItem";
            this.läggTillNySpelareToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.läggTillNySpelareToolStripMenuItem.Text = "Lägg till ny spelare";
            this.läggTillNySpelareToolStripMenuItem.Click += new System.EventHandler(this.läggTillNySpelareToolStripMenuItem_Click);
            // 
            // tävlingsverksamhetToolStripMenuItem
            // 
            this.tävlingsverksamhetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registeraTävlingToolStripMenuItem,
            this.anmälDeltagareToolStripMenuItem,
            this.registreraResultatToolStripMenuItem});
            this.tävlingsverksamhetToolStripMenuItem.Name = "tävlingsverksamhetToolStripMenuItem";
            this.tävlingsverksamhetToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.tävlingsverksamhetToolStripMenuItem.Text = "Tävlingsverksamhet";
            // 
            // registeraTävlingToolStripMenuItem
            // 
            this.registeraTävlingToolStripMenuItem.Name = "registeraTävlingToolStripMenuItem";
            this.registeraTävlingToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.registeraTävlingToolStripMenuItem.Text = "Registrera tävling";
            this.registeraTävlingToolStripMenuItem.Click += new System.EventHandler(this.registeraTävlingToolStripMenuItem_Click);
            // 
            // anmälDeltagareToolStripMenuItem
            // 
            this.anmälDeltagareToolStripMenuItem.Name = "anmälDeltagareToolStripMenuItem";
            this.anmälDeltagareToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.anmälDeltagareToolStripMenuItem.Text = "Anmäl deltagare";
            this.anmälDeltagareToolStripMenuItem.Click += new System.EventHandler(this.anmälDeltagareToolStripMenuItem_Click);
            // 
            // registreraResultatToolStripMenuItem
            // 
            this.registreraResultatToolStripMenuItem.Name = "registreraResultatToolStripMenuItem";
            this.registreraResultatToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.registreraResultatToolStripMenuItem.Text = "Registrera resultat";
            this.registreraResultatToolStripMenuItem.Click += new System.EventHandler(this.registreraResultatToolStripMenuItem_Click);
            // 
            // Huvudfönster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 186);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Huvudfönster";
            this.Text = "Uppgift 8";
            this.Load += new System.EventHandler(this.Huvudfönster_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem medlemshanteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tävlingsverksamhetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registeraTävlingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anmälDeltagareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registreraResultatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem läggTillNySpelareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medlemsregisterToolStripMenuItem;
    }
}

