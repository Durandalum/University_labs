namespace DBProject
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bdConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bdDisconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDatabasePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbQuery = new System.Windows.Forms.TextBox();
            this.lbQuery = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 27);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(608, 390);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.данныеToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(608, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bdConnectToolStripMenuItem,
            this.bdDisconnectToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // bdConnectToolStripMenuItem
            // 
            this.bdConnectToolStripMenuItem.Name = "bdConnectToolStripMenuItem";
            this.bdConnectToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.bdConnectToolStripMenuItem.Text = "Подключить базу данных";
            this.bdConnectToolStripMenuItem.Click += new System.EventHandler(this.bdConnectToolStripMenuItem_Click);
            // 
            // bdDisconnectToolStripMenuItem
            // 
            this.bdDisconnectToolStripMenuItem.Name = "bdDisconnectToolStripMenuItem";
            this.bdDisconnectToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.bdDisconnectToolStripMenuItem.Text = "Отсоединить базу данных";
            this.bdDisconnectToolStripMenuItem.Click += new System.EventHandler(this.bdDisconnectToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.exitToolStripMenuItem.Text = "Завершить работу";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectQueryToolStripMenuItem,
            this.updateQueryToolStripMenuItem,
            this.deleteQueryToolStripMenuItem,
            this.insertQueryToolStripMenuItem});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.данныеToolStripMenuItem.Text = "Данные";
            // 
            // selectQueryToolStripMenuItem
            // 
            this.selectQueryToolStripMenuItem.Name = "selectQueryToolStripMenuItem";
            this.selectQueryToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.selectQueryToolStripMenuItem.Text = "Применить запрос на выборку";
            this.selectQueryToolStripMenuItem.Click += new System.EventHandler(this.selectQueryToolStripMenuItem_Click);
            // 
            // updateQueryToolStripMenuItem
            // 
            this.updateQueryToolStripMenuItem.Name = "updateQueryToolStripMenuItem";
            this.updateQueryToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.updateQueryToolStripMenuItem.Text = "Применить запрос на модификацию";
            this.updateQueryToolStripMenuItem.Click += new System.EventHandler(this.updateQueryToolStripMenuItem_Click);
            // 
            // deleteQueryToolStripMenuItem
            // 
            this.deleteQueryToolStripMenuItem.Name = "deleteQueryToolStripMenuItem";
            this.deleteQueryToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.deleteQueryToolStripMenuItem.Text = "Применить запрос на удаление";
            this.deleteQueryToolStripMenuItem.Click += new System.EventHandler(this.deleteQueryToolStripMenuItem_Click);
            // 
            // insertQueryToolStripMenuItem
            // 
            this.insertQueryToolStripMenuItem.Name = "insertQueryToolStripMenuItem";
            this.insertQueryToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.insertQueryToolStripMenuItem.Text = "Применить запрос на добавление";
            this.insertQueryToolStripMenuItem.Click += new System.EventHandler(this.insertQueryToolStripMenuItem_Click);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setDatabasePathToolStripMenuItem});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.serviceToolStripMenuItem.Text = "Сервис";
            // 
            // setDatabasePathToolStripMenuItem
            // 
            this.setDatabasePathToolStripMenuItem.Name = "setDatabasePathToolStripMenuItem";
            this.setDatabasePathToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.setDatabasePathToolStripMenuItem.Text = "Установить путь к базе данных";
            this.setDatabasePathToolStripMenuItem.Click += new System.EventHandler(this.setDatabasePathToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tbQuery
            // 
            this.tbQuery.Location = new System.Drawing.Point(65, 433);
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.Size = new System.Drawing.Size(447, 20);
            this.tbQuery.TabIndex = 3;
            // 
            // lbQuery
            // 
            this.lbQuery.AutoSize = true;
            this.lbQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbQuery.Location = new System.Drawing.Point(0, 434);
            this.lbQuery.Name = "lbQuery";
            this.lbQuery.Size = new System.Drawing.Size(59, 15);
            this.lbQuery.TabIndex = 4;
            this.lbQuery.Text = "Запрос:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 454);
            this.Controls.Add(this.lbQuery);
            this.Controls.Add(this.tbQuery);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bdConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bdDisconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDatabasePathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox tbQuery;
        private System.Windows.Forms.Label lbQuery;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

