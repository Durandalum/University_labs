namespace APOS
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.управлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addHeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SSetText = new System.Windows.Forms.TextBox();
            this.SSetTextP = new System.Windows.Forms.Button();
            this.SSetTextM = new System.Windows.Forms.Button();
            this.StartI = new System.Windows.Forms.Button();
            this.Stats = new System.Windows.Forms.RichTextBox();
            this.KillProc = new System.Windows.Forms.Button();
            this.PiD = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(648, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // управлениеToolStripMenuItem
            // 
            this.управлениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addHeliToolStripMenuItem,
            this.addFireToolStripMenuItem});
            this.управлениеToolStripMenuItem.Name = "управлениеToolStripMenuItem";
            this.управлениеToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.управлениеToolStripMenuItem.Text = "Управление процессами";
            // 
            // addHeliToolStripMenuItem
            // 
            this.addHeliToolStripMenuItem.Name = "addHeliToolStripMenuItem";
            this.addHeliToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addHeliToolStripMenuItem.Text = "Добавить вертолёт";
            this.addHeliToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // addFireToolStripMenuItem
            // 
            this.addFireToolStripMenuItem.Name = "addFireToolStripMenuItem";
            this.addFireToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addFireToolStripMenuItem.Text = "Добавить огонь";
            this.addFireToolStripMenuItem.Click += new System.EventHandler(this.addFireToolStripMenuItem_Click);
            // 
            // SSetText
            // 
            this.SSetText.Enabled = false;
            this.SSetText.Location = new System.Drawing.Point(532, 27);
            this.SSetText.Name = "SSetText";
            this.SSetText.Size = new System.Drawing.Size(90, 20);
            this.SSetText.TabIndex = 1;
            // 
            // SSetTextP
            // 
            this.SSetTextP.Location = new System.Drawing.Point(628, 24);
            this.SSetTextP.Name = "SSetTextP";
            this.SSetTextP.Size = new System.Drawing.Size(20, 23);
            this.SSetTextP.TabIndex = 2;
            this.SSetTextP.Text = ">";
            this.SSetTextP.UseVisualStyleBackColor = true;
            this.SSetTextP.Click += new System.EventHandler(this.SSetTextP_Click);
            // 
            // SSetTextM
            // 
            this.SSetTextM.Location = new System.Drawing.Point(506, 24);
            this.SSetTextM.Name = "SSetTextM";
            this.SSetTextM.Size = new System.Drawing.Size(20, 23);
            this.SSetTextM.TabIndex = 3;
            this.SSetTextM.Text = "<";
            this.SSetTextM.UseVisualStyleBackColor = true;
            this.SSetTextM.Click += new System.EventHandler(this.SSetTextM_Click);
            // 
            // StartI
            // 
            this.StartI.Location = new System.Drawing.Point(532, 53);
            this.StartI.Name = "StartI";
            this.StartI.Size = new System.Drawing.Size(75, 23);
            this.StartI.TabIndex = 4;
            this.StartI.Text = "Start";
            this.StartI.UseVisualStyleBackColor = true;
            this.StartI.Click += new System.EventHandler(this.StartI_Click);
            // 
            // Stats
            // 
            this.Stats.Location = new System.Drawing.Point(532, 108);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(100, 150);
            this.Stats.TabIndex = 6;
            this.Stats.Text = "";
            // 
            // KillProc
            // 
            this.KillProc.Location = new System.Drawing.Point(532, 281);
            this.KillProc.Name = "KillProc";
            this.KillProc.Size = new System.Drawing.Size(49, 23);
            this.KillProc.TabIndex = 7;
            this.KillProc.Text = "Del";
            this.KillProc.UseVisualStyleBackColor = true;
            this.KillProc.Click += new System.EventHandler(this.KillProc_Click);
            // 
            // PiD
            // 
            this.PiD.Location = new System.Drawing.Point(587, 283);
            this.PiD.Name = "PiD";
            this.PiD.Size = new System.Drawing.Size(45, 20);
            this.PiD.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(648, 478);
            this.Controls.Add(this.PiD);
            this.Controls.Add(this.KillProc);
            this.Controls.Add(this.Stats);
            this.Controls.Add(this.StartI);
            this.Controls.Add(this.SSetTextM);
            this.Controls.Add(this.SSetTextP);
            this.Controls.Add(this.SSetText);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Wildfire Project";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem управлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addHeliToolStripMenuItem;
        private System.Windows.Forms.TextBox SSetText;
        private System.Windows.Forms.Button SSetTextP;
        private System.Windows.Forms.Button SSetTextM;
        private System.Windows.Forms.Button StartI;
        private System.Windows.Forms.RichTextBox Stats;
        private System.Windows.Forms.Button KillProc;
        private System.Windows.Forms.TextBox PiD;
        private System.Windows.Forms.ToolStripMenuItem addFireToolStripMenuItem;
    }
}

