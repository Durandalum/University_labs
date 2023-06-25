namespace ATSF_Lab_3_2
{
    partial class Form1
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
            this.Distribution = new System.Windows.Forms.Button();
            this.InstallFolder = new System.Windows.Forms.Button();
            this.Installing = new System.Windows.Forms.Button();
            this.Deleting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Distribution
            // 
            this.Distribution.Location = new System.Drawing.Point(30, 27);
            this.Distribution.Name = "Distribution";
            this.Distribution.Size = new System.Drawing.Size(103, 23);
            this.Distribution.TabIndex = 0;
            this.Distribution.Text = "Дистрибутив";
            this.Distribution.UseVisualStyleBackColor = true;
            this.Distribution.Click += new System.EventHandler(this.Distribution_Click_1);
            // 
            // InstallFolder
            // 
            this.InstallFolder.Location = new System.Drawing.Point(30, 56);
            this.InstallFolder.Name = "InstallFolder";
            this.InstallFolder.Size = new System.Drawing.Size(103, 23);
            this.InstallFolder.TabIndex = 1;
            this.InstallFolder.Text = "Папка установки";
            this.InstallFolder.UseVisualStyleBackColor = true;
            this.InstallFolder.Click += new System.EventHandler(this.InstallFolder_Click_1);
            // 
            // Installing
            // 
            this.Installing.Location = new System.Drawing.Point(30, 85);
            this.Installing.Name = "Installing";
            this.Installing.Size = new System.Drawing.Size(103, 23);
            this.Installing.TabIndex = 2;
            this.Installing.Text = "Установка";
            this.Installing.UseVisualStyleBackColor = true;
            this.Installing.Click += new System.EventHandler(this.Installing_Click_1);
            // 
            // Deleting
            // 
            this.Deleting.Location = new System.Drawing.Point(30, 114);
            this.Deleting.Name = "Deleting";
            this.Deleting.Size = new System.Drawing.Size(103, 23);
            this.Deleting.TabIndex = 3;
            this.Deleting.Text = "Удаление";
            this.Deleting.UseVisualStyleBackColor = true;
            this.Deleting.Click += new System.EventHandler(this.Deleting_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 149);
            this.Controls.Add(this.Deleting);
            this.Controls.Add(this.Installing);
            this.Controls.Add(this.InstallFolder);
            this.Controls.Add(this.Distribution);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Distribution;
        private System.Windows.Forms.Button InstallFolder;
        private System.Windows.Forms.Button Installing;
        private System.Windows.Forms.Button Deleting;
    }
}

