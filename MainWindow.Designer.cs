namespace Sonic3Din2D_Helper
{
    partial class MainWindow
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkGameComplete = new System.Windows.Forms.CheckBox();
            this.chkDD1JumpCheckPoint = new System.Windows.Forms.CheckBox();
            this.chkBossCheckPoint = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkDefaultShield = new System.Windows.Forms.RadioButton();
            this.chkHomingShield = new System.Windows.Forms.RadioButton();
            this.chkBubbleShield = new System.Windows.Forms.RadioButton();
            this.chkLightningShield = new System.Windows.Forms.RadioButton();
            this.chkFireShield = new System.Windows.Forms.RadioButton();
            this.chkBlueShield = new System.Windows.Forms.RadioButton();
            this.chkSetNiceLives = new System.Windows.Forms.CheckBox();
            this.label_status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkGameComplete);
            this.groupBox1.Controls.Add(this.chkDD1JumpCheckPoint);
            this.groupBox1.Controls.Add(this.chkBossCheckPoint);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.chkSetNiceLives);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cheats";
            // 
            // chkGameComplete
            // 
            this.chkGameComplete.AutoSize = true;
            this.chkGameComplete.Location = new System.Drawing.Point(7, 89);
            this.chkGameComplete.Name = "chkGameComplete";
            this.chkGameComplete.Size = new System.Drawing.Size(216, 17);
            this.chkGameComplete.TabIndex = 4;
            this.chkGameComplete.Text = "Upgrade game clear (for Act 2 selection)";
            this.chkGameComplete.UseVisualStyleBackColor = true;
            // 
            // chkDD1JumpCheckPoint
            // 
            this.chkDD1JumpCheckPoint.AutoSize = true;
            this.chkDD1JumpCheckPoint.Location = new System.Drawing.Point(7, 66);
            this.chkDD1JumpCheckPoint.Name = "chkDD1JumpCheckPoint";
            this.chkDD1JumpCheckPoint.Size = new System.Drawing.Size(133, 17);
            this.chkDD1JumpCheckPoint.TabIndex = 3;
            this.chkDD1JumpCheckPoint.Text = "DD1 Jump Checkpoint";
            this.chkDD1JumpCheckPoint.UseVisualStyleBackColor = true;
            // 
            // chkBossCheckPoint
            // 
            this.chkBossCheckPoint.AutoSize = true;
            this.chkBossCheckPoint.Location = new System.Drawing.Point(7, 43);
            this.chkBossCheckPoint.Name = "chkBossCheckPoint";
            this.chkBossCheckPoint.Size = new System.Drawing.Size(148, 17);
            this.chkBossCheckPoint.TabIndex = 2;
            this.chkBossCheckPoint.Text = "Activate Boss Checkpoint";
            this.chkBossCheckPoint.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.chkDefaultShield);
            this.groupBox2.Controls.Add(this.chkHomingShield);
            this.groupBox2.Controls.Add(this.chkBubbleShield);
            this.groupBox2.Controls.Add(this.chkLightningShield);
            this.groupBox2.Controls.Add(this.chkFireShield);
            this.groupBox2.Controls.Add(this.chkBlueShield);
            this.groupBox2.Location = new System.Drawing.Point(6, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(284, 135);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stage Load Shield";
            // 
            // chkDefaultShield
            // 
            this.chkDefaultShield.AutoSize = true;
            this.chkDefaultShield.Checked = true;
            this.chkDefaultShield.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkDefaultShield.Location = new System.Drawing.Point(10, 108);
            this.chkDefaultShield.Name = "chkDefaultShield";
            this.chkDefaultShield.Size = new System.Drawing.Size(264, 17);
            this.chkDefaultShield.TabIndex = 6;
            this.chkDefaultShield.TabStop = true;
            this.chkDefaultShield.Text = "Disable";
            this.chkDefaultShield.UseVisualStyleBackColor = true;
            // 
            // chkHomingShield
            // 
            this.chkHomingShield.AutoSize = true;
            this.chkHomingShield.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkHomingShield.Location = new System.Drawing.Point(10, 91);
            this.chkHomingShield.Name = "chkHomingShield";
            this.chkHomingShield.Size = new System.Drawing.Size(264, 17);
            this.chkHomingShield.TabIndex = 4;
            this.chkHomingShield.Text = "Homing Shield";
            this.chkHomingShield.UseVisualStyleBackColor = true;
            // 
            // chkBubbleShield
            // 
            this.chkBubbleShield.AutoSize = true;
            this.chkBubbleShield.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkBubbleShield.Location = new System.Drawing.Point(10, 74);
            this.chkBubbleShield.Name = "chkBubbleShield";
            this.chkBubbleShield.Size = new System.Drawing.Size(264, 17);
            this.chkBubbleShield.TabIndex = 3;
            this.chkBubbleShield.Text = "Bubble Shield";
            this.chkBubbleShield.UseVisualStyleBackColor = true;
            // 
            // chkLightningShield
            // 
            this.chkLightningShield.AutoSize = true;
            this.chkLightningShield.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkLightningShield.Location = new System.Drawing.Point(10, 57);
            this.chkLightningShield.Name = "chkLightningShield";
            this.chkLightningShield.Size = new System.Drawing.Size(264, 17);
            this.chkLightningShield.TabIndex = 2;
            this.chkLightningShield.Text = "Lightning Shield";
            this.chkLightningShield.UseVisualStyleBackColor = true;
            // 
            // chkFireShield
            // 
            this.chkFireShield.AutoSize = true;
            this.chkFireShield.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkFireShield.Location = new System.Drawing.Point(10, 40);
            this.chkFireShield.Name = "chkFireShield";
            this.chkFireShield.Size = new System.Drawing.Size(264, 17);
            this.chkFireShield.TabIndex = 1;
            this.chkFireShield.Text = "Fire Shield";
            this.chkFireShield.UseVisualStyleBackColor = true;
            // 
            // chkBlueShield
            // 
            this.chkBlueShield.AutoSize = true;
            this.chkBlueShield.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkBlueShield.Location = new System.Drawing.Point(10, 23);
            this.chkBlueShield.Name = "chkBlueShield";
            this.chkBlueShield.Size = new System.Drawing.Size(264, 17);
            this.chkBlueShield.TabIndex = 0;
            this.chkBlueShield.Text = "Basic Blue Shield";
            this.chkBlueShield.UseVisualStyleBackColor = true;
            // 
            // chkSetNiceLives
            // 
            this.chkSetNiceLives.AutoSize = true;
            this.chkSetNiceLives.Location = new System.Drawing.Point(7, 20);
            this.chkSetNiceLives.Name = "chkSetNiceLives";
            this.chkSetNiceLives.Size = new System.Drawing.Size(91, 17);
            this.chkSetNiceLives.TabIndex = 0;
            this.chkSetNiceLives.Text = "Set Nice lives";
            this.chkSetNiceLives.UseVisualStyleBackColor = true;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(121, 284);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(58, 13);
            this.label_status.TabIndex = 6;
            this.label_status.Text = "status_text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current status:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 309);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Sonic 3D in 2D - Helper Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkGameComplete;
        private System.Windows.Forms.CheckBox chkDD1JumpCheckPoint;
        private System.Windows.Forms.CheckBox chkBossCheckPoint;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton chkDefaultShield;
        private System.Windows.Forms.RadioButton chkHomingShield;
        private System.Windows.Forms.RadioButton chkBubbleShield;
        private System.Windows.Forms.RadioButton chkLightningShield;
        private System.Windows.Forms.RadioButton chkFireShield;
        private System.Windows.Forms.RadioButton chkBlueShield;
        private System.Windows.Forms.CheckBox chkSetNiceLives;
    }
}

