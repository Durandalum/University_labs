namespace ATSF_Lab_3
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.LoadPicture = new System.Windows.Forms.Button();
            this.LoadText = new System.Windows.Forms.Button();
            this.LoadTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 238);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(200, 200);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 200);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(242, 180);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(449, 239);
            this.dataGridView.TabIndex = 2;
            // 
            // LoadPicture
            // 
            this.LoadPicture.Location = new System.Drawing.Point(258, 26);
            this.LoadPicture.Name = "LoadPicture";
            this.LoadPicture.Size = new System.Drawing.Size(148, 23);
            this.LoadPicture.TabIndex = 3;
            this.LoadPicture.Text = "Загрузить изображение";
            this.LoadPicture.UseVisualStyleBackColor = true;
            this.LoadPicture.Click += new System.EventHandler(this.LoadPicture_Click);
            // 
            // LoadText
            // 
            this.LoadText.Location = new System.Drawing.Point(258, 55);
            this.LoadText.Name = "LoadText";
            this.LoadText.Size = new System.Drawing.Size(148, 23);
            this.LoadText.TabIndex = 4;
            this.LoadText.Text = "Загрузить текст";
            this.LoadText.UseVisualStyleBackColor = true;
            this.LoadText.Click += new System.EventHandler(this.LoadText_Click_1);
            // 
            // LoadTable
            // 
            this.LoadTable.Location = new System.Drawing.Point(258, 84);
            this.LoadTable.Name = "LoadTable";
            this.LoadTable.Size = new System.Drawing.Size(148, 23);
            this.LoadTable.TabIndex = 5;
            this.LoadTable.Text = "Загрузить таблицу";
            this.LoadTable.UseVisualStyleBackColor = true;
            this.LoadTable.Click += new System.EventHandler(this.LoadTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 455);
            this.Controls.Add(this.LoadTable);
            this.Controls.Add(this.LoadText);
            this.Controls.Add(this.LoadPicture);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.richTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button LoadPicture;
        private System.Windows.Forms.Button LoadText;
        private System.Windows.Forms.Button LoadTable;
    }
}

