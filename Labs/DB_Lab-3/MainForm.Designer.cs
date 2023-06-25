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
            this.SaveToTheFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteSelectedDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDatabasePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelQuery = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FieldLabel = new System.Windows.Forms.Label();
            this.TableLabel = new System.Windows.Forms.Label();
            this.RequestLabel = new System.Windows.Forms.Label();
            this.RequestTextBox = new System.Windows.Forms.RichTextBox();
            this.FieldComboBox = new System.Windows.Forms.ComboBox();
            this.TableComboBox = new System.Windows.Forms.ComboBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.RequestComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(1, 27);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(644, 390);
            this.dataGridView.TabIndex = 1;
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
            this.menuStrip.Size = new System.Drawing.Size(645, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bdConnectToolStripMenuItem,
            this.bdDisconnectToolStripMenuItem,
            this.SaveToTheFileToolStripMenuItem,
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
            // SaveToTheFileToolStripMenuItem
            // 
            this.SaveToTheFileToolStripMenuItem.Name = "SaveToTheFileToolStripMenuItem";
            this.SaveToTheFileToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.SaveToTheFileToolStripMenuItem.Text = "Сохранить в файл";
            this.SaveToTheFileToolStripMenuItem.Click += new System.EventHandler(this.SaveToTheFileToolStripMenuItem_Click);
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
            this.GenerateQueryToolStripMenuItem,
            this.selectQueryToolStripMenuItem,
            this.updateQueryToolStripMenuItem,
            this.deleteQueryToolStripMenuItem,
            this.insertQueryToolStripMenuItem,
            this.DeleteSelectedDataToolStripMenuItem});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.данныеToolStripMenuItem.Text = "Данные";
            // 
            // GenerateQueryToolStripMenuItem
            // 
            this.GenerateQueryToolStripMenuItem.Name = "GenerateQueryToolStripMenuItem";
            this.GenerateQueryToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.GenerateQueryToolStripMenuItem.Text = "Сформировать запрос";
            this.GenerateQueryToolStripMenuItem.Click += new System.EventHandler(this.GenerateQueryToolStripMenuItem_Click);
            // 
            // selectQueryToolStripMenuItem
            // 
            this.selectQueryToolStripMenuItem.Name = "selectQueryToolStripMenuItem";
            this.selectQueryToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.selectQueryToolStripMenuItem.Text = "Применить запрос на выборку";
            this.selectQueryToolStripMenuItem.Click += new System.EventHandler(this.selectQueryToolStripMenuItem_Click);
            // 
            // updateQueryToolStripMenuItem
            // 
            this.updateQueryToolStripMenuItem.Name = "updateQueryToolStripMenuItem";
            this.updateQueryToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.updateQueryToolStripMenuItem.Text = "Применить запрос на модификацию";
            this.updateQueryToolStripMenuItem.Click += new System.EventHandler(this.updateQueryToolStripMenuItem_Click);
            // 
            // deleteQueryToolStripMenuItem
            // 
            this.deleteQueryToolStripMenuItem.Name = "deleteQueryToolStripMenuItem";
            this.deleteQueryToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.deleteQueryToolStripMenuItem.Text = "Применить запрос на удаление";
            this.deleteQueryToolStripMenuItem.Click += new System.EventHandler(this.deleteQueryToolStripMenuItem_Click);
            // 
            // insertQueryToolStripMenuItem
            // 
            this.insertQueryToolStripMenuItem.Name = "insertQueryToolStripMenuItem";
            this.insertQueryToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.insertQueryToolStripMenuItem.Text = "Применить запрос на добавление";
            this.insertQueryToolStripMenuItem.Click += new System.EventHandler(this.insertQueryToolStripMenuItem_Click);
            // 
            // DeleteSelectedDataToolStripMenuItem
            // 
            this.DeleteSelectedDataToolStripMenuItem.Name = "DeleteSelectedDataToolStripMenuItem";
            this.DeleteSelectedDataToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.DeleteSelectedDataToolStripMenuItem.Text = "Удалить данные из выделенной ячейки";
            this.DeleteSelectedDataToolStripMenuItem.Click += new System.EventHandler(this.DeleteSelectedDataToolStripMenuItem_Click);
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
            // LabelQuery
            // 
            this.LabelQuery.AutoSize = true;
            this.LabelQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelQuery.Location = new System.Drawing.Point(-2, 517);
            this.LabelQuery.Name = "LabelQuery";
            this.LabelQuery.Size = new System.Drawing.Size(59, 15);
            this.LabelQuery.TabIndex = 4;
            this.LabelQuery.Text = "Запрос:";
            this.LabelQuery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FieldLabel
            // 
            this.FieldLabel.AutoSize = true;
            this.FieldLabel.Location = new System.Drawing.Point(34, 679);
            this.FieldLabel.Name = "FieldLabel";
            this.FieldLabel.Size = new System.Drawing.Size(67, 13);
            this.FieldLabel.TabIndex = 13;
            this.FieldLabel.Text = "Выбор поля";
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Location = new System.Drawing.Point(28, 631);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(86, 13);
            this.TableLabel.TabIndex = 12;
            this.TableLabel.Text = "Выбор таблицы";
            // 
            // RequestLabel
            // 
            this.RequestLabel.AutoSize = true;
            this.RequestLabel.Location = new System.Drawing.Point(21, 585);
            this.RequestLabel.Name = "RequestLabel";
            this.RequestLabel.Size = new System.Drawing.Size(85, 13);
            this.RequestLabel.TabIndex = 11;
            this.RequestLabel.Text = "Выбор запроса";
            // 
            // RequestTextBox
            // 
            this.RequestTextBox.Location = new System.Drawing.Point(137, 517);
            this.RequestTextBox.Name = "RequestTextBox";
            this.RequestTextBox.Size = new System.Drawing.Size(483, 170);
            this.RequestTextBox.TabIndex = 10;
            this.RequestTextBox.Text = "";
            this.RequestTextBox.Visible = false;
            // 
            // FieldComboBox
            // 
            this.FieldComboBox.FormattingEnabled = true;
            this.FieldComboBox.Location = new System.Drawing.Point(12, 695);
            this.FieldComboBox.Name = "FieldComboBox";
            this.FieldComboBox.Size = new System.Drawing.Size(121, 21);
            this.FieldComboBox.TabIndex = 9;
            // 
            // TableComboBox
            // 
            this.TableComboBox.FormattingEnabled = true;
            this.TableComboBox.Items.AddRange(new object[] {
            "Films",
            "Cinema",
            "Reviews",
            "Specifications"});
            this.TableComboBox.Location = new System.Drawing.Point(12, 647);
            this.TableComboBox.Name = "TableComboBox";
            this.TableComboBox.Size = new System.Drawing.Size(121, 21);
            this.TableComboBox.TabIndex = 8;
            this.TableComboBox.SelectedIndexChanged += new System.EventHandler(this.TableComboBox_SelectedIndexChanged);
            // 
            // RequestComboBox
            // 
            this.RequestComboBox.FormattingEnabled = true;
            this.RequestComboBox.Items.AddRange(new object[] {
            "SELECT",
            "UPDATE",
            "INSERT INTO",
            "DELETE FROM"});
            this.RequestComboBox.Location = new System.Drawing.Point(12, 601);
            this.RequestComboBox.Name = "RequestComboBox";
            this.RequestComboBox.Size = new System.Drawing.Size(121, 21);
            this.RequestComboBox.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 740);
            this.Controls.Add(this.RequestComboBox);
            this.Controls.Add(this.FieldLabel);
            this.Controls.Add(this.TableLabel);
            this.Controls.Add(this.RequestLabel);
            this.Controls.Add(this.RequestTextBox);
            this.Controls.Add(this.FieldComboBox);
            this.Controls.Add(this.TableComboBox);
            this.Controls.Add(this.LabelQuery);
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
        private System.Windows.Forms.Label LabelQuery;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem SaveToTheFileToolStripMenuItem;
        private System.Windows.Forms.Label FieldLabel;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.Label RequestLabel;
        private System.Windows.Forms.RichTextBox RequestTextBox;
        private System.Windows.Forms.ComboBox FieldComboBox;
        private System.Windows.Forms.ComboBox TableComboBox;
        private System.Windows.Forms.ToolStripMenuItem GenerateQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteSelectedDataToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ComboBox RequestComboBox;
    }
}

