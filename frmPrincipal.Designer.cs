namespace capaPresentacion
{
    partial class frmPrincipal
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
            this.iNGRESODEDATOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mASCOTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tIPOSDEENFERMEDADESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNGRESODEDATOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(938, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iNGRESODEDATOSToolStripMenuItem
            // 
            this.iNGRESODEDATOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTESToolStripMenuItem,
            this.mASCOTASToolStripMenuItem,
            this.tIPOSDEENFERMEDADESToolStripMenuItem});
            this.iNGRESODEDATOSToolStripMenuItem.Name = "iNGRESODEDATOSToolStripMenuItem";
            this.iNGRESODEDATOSToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.iNGRESODEDATOSToolStripMenuItem.Text = "INGRESO DE DATOS";
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            this.cLIENTESToolStripMenuItem.Click += new System.EventHandler(this.cLIENTESToolStripMenuItem_Click);
            // 
            // mASCOTASToolStripMenuItem
            // 
            this.mASCOTASToolStripMenuItem.Name = "mASCOTASToolStripMenuItem";
            this.mASCOTASToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.mASCOTASToolStripMenuItem.Text = "MASCOTAS";
            this.mASCOTASToolStripMenuItem.Click += new System.EventHandler(this.mASCOTASToolStripMenuItem_Click);
            // 
            // tIPOSDEENFERMEDADESToolStripMenuItem
            // 
            this.tIPOSDEENFERMEDADESToolStripMenuItem.Name = "tIPOSDEENFERMEDADESToolStripMenuItem";
            this.tIPOSDEENFERMEDADESToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.tIPOSDEENFERMEDADESToolStripMenuItem.Text = "TIPOS DE ENFERMEDADES";
            this.tIPOSDEENFERMEDADESToolStripMenuItem.Click += new System.EventHandler(this.tIPOSDEENFERMEDADESToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 425);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iNGRESODEDATOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mASCOTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tIPOSDEENFERMEDADESToolStripMenuItem;
    }
}