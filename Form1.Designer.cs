namespace Build4Performance
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pradžiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varotojoVadovasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kompiuterioRinkimasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagalPrioritetusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kompiuterioParinkimasVienuSpustelėjimuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.išeitiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pradžiaToolStripMenuItem,
            this.varotojoVadovasToolStripMenuItem,
            this.kompiuterioRinkimasToolStripMenuItem,
            this.išeitiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pradžiaToolStripMenuItem
            // 
            this.pradžiaToolStripMenuItem.Name = "pradžiaToolStripMenuItem";
            this.pradžiaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pradžiaToolStripMenuItem.Text = "Pradžia";
            this.pradžiaToolStripMenuItem.Click += new System.EventHandler(this.pradžiaToolStripMenuItem_Click);
            // 
            // varotojoVadovasToolStripMenuItem
            // 
            this.varotojoVadovasToolStripMenuItem.Name = "varotojoVadovasToolStripMenuItem";
            this.varotojoVadovasToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.varotojoVadovasToolStripMenuItem.Text = "Varotojo vadovas";
            // 
            // kompiuterioRinkimasToolStripMenuItem
            // 
            this.kompiuterioRinkimasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagalPrioritetusToolStripMenuItem,
            this.kompiuterioParinkimasVienuSpustelėjimuToolStripMenuItem});
            this.kompiuterioRinkimasToolStripMenuItem.Name = "kompiuterioRinkimasToolStripMenuItem";
            this.kompiuterioRinkimasToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.kompiuterioRinkimasToolStripMenuItem.Text = "Kompiuterio rinkimas";
            this.kompiuterioRinkimasToolStripMenuItem.Click += new System.EventHandler(this.kompiuterioRinkimasToolStripMenuItem_Click);
            // 
            // pagalPrioritetusToolStripMenuItem
            // 
            this.pagalPrioritetusToolStripMenuItem.Name = "pagalPrioritetusToolStripMenuItem";
            this.pagalPrioritetusToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.pagalPrioritetusToolStripMenuItem.Text = "Pagal prioritetus";
            this.pagalPrioritetusToolStripMenuItem.Click += new System.EventHandler(this.pagalPrioritetusToolStripMenuItem_Click);
            // 
            // kompiuterioParinkimasVienuSpustelėjimuToolStripMenuItem
            // 
            this.kompiuterioParinkimasVienuSpustelėjimuToolStripMenuItem.Name = "kompiuterioParinkimasVienuSpustelėjimuToolStripMenuItem";
            this.kompiuterioParinkimasVienuSpustelėjimuToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.kompiuterioParinkimasVienuSpustelėjimuToolStripMenuItem.Text = "Kompiuterio parinkimas vienu spustelėjimu";
            this.kompiuterioParinkimasVienuSpustelėjimuToolStripMenuItem.Click += new System.EventHandler(this.kompiuterioParinkimasVienuSpustelėjimuToolStripMenuItem_Click);
            // 
            // išeitiToolStripMenuItem
            // 
            this.išeitiToolStripMenuItem.Name = "išeitiToolStripMenuItem";
            this.išeitiToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.išeitiToolStripMenuItem.Text = "Išeiti";
            this.išeitiToolStripMenuItem.Click += new System.EventHandler(this.išeitiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(563, 291);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Build4Performance";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pradžiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varotojoVadovasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kompiuterioRinkimasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagalPrioritetusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kompiuterioParinkimasVienuSpustelėjimuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem išeitiToolStripMenuItem;
    }
}

