namespace AssaultCubeCheats
{
    partial class AssaultCubeCheatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssaultCubeCheatForm));
            this.exit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.health = new System.Windows.Forms.CheckBox();
            this.armour = new System.Windows.Forms.CheckBox();
            this.granades = new System.Windows.Forms.CheckBox();
            this.ammo = new System.Windows.Forms.CheckBox();
            this.enable = new System.Windows.Forms.Button();
            this.disable = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.statusValue = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(161, 125);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 0;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(258, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // health
            // 
            this.health.AutoSize = true;
            this.health.Location = new System.Drawing.Point(11, 36);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(103, 17);
            this.health.TabIndex = 7;
            this.health.Text = "Unlimited Health";
            this.health.UseVisualStyleBackColor = true;
            this.health.CheckedChanged += new System.EventHandler(this.health_CheckedChanged);
            // 
            // armour
            // 
            this.armour.AutoSize = true;
            this.armour.Location = new System.Drawing.Point(11, 59);
            this.armour.Name = "armour";
            this.armour.Size = new System.Drawing.Size(105, 17);
            this.armour.TabIndex = 8;
            this.armour.Text = "Unlimited Armour";
            this.armour.UseVisualStyleBackColor = true;
            this.armour.CheckedChanged += new System.EventHandler(this.armour_CheckedChanged);
            // 
            // granades
            // 
            this.granades.AutoSize = true;
            this.granades.Location = new System.Drawing.Point(11, 83);
            this.granades.Name = "granades";
            this.granades.Size = new System.Drawing.Size(106, 17);
            this.granades.TabIndex = 9;
            this.granades.Text = "Infinite Granades";
            this.granades.UseVisualStyleBackColor = true;
            this.granades.CheckedChanged += new System.EventHandler(this.granades_CheckedChanged);
            // 
            // ammo
            // 
            this.ammo.AutoSize = true;
            this.ammo.Location = new System.Drawing.Point(11, 107);
            this.ammo.Name = "ammo";
            this.ammo.Size = new System.Drawing.Size(89, 17);
            this.ammo.TabIndex = 10;
            this.ammo.Text = "Infinite Ammo";
            this.ammo.UseVisualStyleBackColor = true;
            this.ammo.CheckedChanged += new System.EventHandler(this.ammo_CheckedChanged);
            // 
            // enable
            // 
            this.enable.Location = new System.Drawing.Point(161, 36);
            this.enable.Name = "enable";
            this.enable.Size = new System.Drawing.Size(75, 23);
            this.enable.TabIndex = 11;
            this.enable.Text = "Enable";
            this.enable.UseVisualStyleBackColor = true;
            this.enable.Click += new System.EventHandler(this.enable_Click);
            // 
            // disable
            // 
            this.disable.Location = new System.Drawing.Point(161, 65);
            this.disable.Name = "disable";
            this.disable.Size = new System.Drawing.Size(75, 23);
            this.disable.TabIndex = 12;
            this.disable.Text = "Disable";
            this.disable.UseVisualStyleBackColor = true;
            this.disable.Click += new System.EventHandler(this.disable_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(11, 135);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(40, 13);
            this.status.TabIndex = 13;
            this.status.Text = "Status:";
            // 
            // statusValue
            // 
            this.statusValue.AutoSize = true;
            this.statusValue.ForeColor = System.Drawing.Color.Red;
            this.statusValue.Location = new System.Drawing.Point(58, 135);
            this.statusValue.Name = "statusValue";
            this.statusValue.Size = new System.Drawing.Size(46, 13);
            this.statusValue.TabIndex = 14;
            this.statusValue.Text = "disabled";
            // 
            // AssaultCubeCheatForm
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(258, 160);
            this.Controls.Add(this.statusValue);
            this.Controls.Add(this.status);
            this.Controls.Add(this.disable);
            this.Controls.Add(this.enable);
            this.Controls.Add(this.ammo);
            this.Controls.Add(this.granades);
            this.Controls.Add(this.armour);
            this.Controls.Add(this.health);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AssaultCubeCheatForm";
            this.Text = "AssaultCube Cheats by _sectasy";
            this.Load += new System.EventHandler(this.AssaultCubeCheat_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.CheckBox health;
        private System.Windows.Forms.CheckBox armour;
        private System.Windows.Forms.CheckBox granades;
        private System.Windows.Forms.CheckBox ammo;
        private System.Windows.Forms.Button enable;
        private System.Windows.Forms.Button disable;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label statusValue;
    }
}

