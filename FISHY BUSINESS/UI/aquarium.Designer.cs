
namespace FISHY_BUSINESS
{
    partial class aquarium
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aquariumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1460, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aquariumToolStripMenuItem,
            this.fishToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.creditsToolStripMenuItem.Text = "Credits and Citations";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsAndCitations);
            // 
            // aquariumToolStripMenuItem
            // 
            this.aquariumToolStripMenuItem.Name = "aquariumToolStripMenuItem";
            this.aquariumToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aquariumToolStripMenuItem.Text = "Aquarium";
            // 
            // fishToolStripMenuItem
            // 
            this.fishToolStripMenuItem.Name = "fishToolStripMenuItem";
            this.fishToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fishToolStripMenuItem.Text = "Fish";
            // 
            // aquarium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 745);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "aquarium";
            this.Text = "aquarium";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aquariumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fishToolStripMenuItem;
    }
}

