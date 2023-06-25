namespace WindowsFormsApplication1
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
            this.ProgramNameLabel = new System.Windows.Forms.Label();
            this.DecoderTextBox = new System.Windows.Forms.RichTextBox();
            this.CoderTBLabel = new System.Windows.Forms.Label();
            this.DecoderTBLabel = new System.Windows.Forms.Label();
            this.CoderTextBox = new System.Windows.Forms.RichTextBox();
            this.SaveTextButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.CipherButton = new System.Windows.Forms.Button();
            this.DecipherButton = new System.Windows.Forms.Button();
            this.isCyrillicRButton = new System.Windows.Forms.RadioButton();
            this.isLatinRButton = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.CheckHashButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProgramNameLabel
            // 
            this.ProgramNameLabel.AutoSize = true;
            this.ProgramNameLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProgramNameLabel.Location = new System.Drawing.Point(212, 9);
            this.ProgramNameLabel.Name = "ProgramNameLabel";
            this.ProgramNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProgramNameLabel.Size = new System.Drawing.Size(222, 26);
            this.ProgramNameLabel.TabIndex = 1;
            this.ProgramNameLabel.Text = "Электронный сейф";
            this.ProgramNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProgramNameLabel.Click += new System.EventHandler(this.ProgramNameLabel_Click);
            // 
            // DecoderTextBox
            // 
            this.DecoderTextBox.Location = new System.Drawing.Point(40, 82);
            this.DecoderTextBox.Name = "DecoderTextBox";
            this.DecoderTextBox.Size = new System.Drawing.Size(200, 200);
            this.DecoderTextBox.TabIndex = 5;
            this.DecoderTextBox.Text = "";
            this.DecoderTextBox.TextChanged += new System.EventHandler(this.CoderTextBox_TextChanged);
            // 
            // CoderTBLabel
            // 
            this.CoderTBLabel.AutoSize = true;
            this.CoderTBLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoderTBLabel.Location = new System.Drawing.Point(25, 49);
            this.CoderTBLabel.Name = "CoderTBLabel";
            this.CoderTBLabel.Size = new System.Drawing.Size(232, 19);
            this.CoderTBLabel.TabIndex = 7;
            this.CoderTBLabel.Text = "Поле для ввода текста шифровки";
            // 
            // DecoderTBLabel
            // 
            this.DecoderTBLabel.AutoSize = true;
            this.DecoderTBLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecoderTBLabel.Location = new System.Drawing.Point(391, 49);
            this.DecoderTBLabel.Name = "DecoderTBLabel";
            this.DecoderTBLabel.Size = new System.Drawing.Size(243, 19);
            this.DecoderTBLabel.TabIndex = 10;
            this.DecoderTBLabel.Text = "Поле для вывода текста шифровки";
            // 
            // CoderTextBox
            // 
            this.CoderTextBox.Location = new System.Drawing.Point(414, 82);
            this.CoderTextBox.Name = "CoderTextBox";
            this.CoderTextBox.Size = new System.Drawing.Size(200, 200);
            this.CoderTextBox.TabIndex = 9;
            this.CoderTextBox.Text = "";
            // 
            // SaveTextButton
            // 
            this.SaveTextButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveTextButton.Location = new System.Drawing.Point(261, 60);
            this.SaveTextButton.Name = "SaveTextButton";
            this.SaveTextButton.Size = new System.Drawing.Size(124, 34);
            this.SaveTextButton.TabIndex = 18;
            this.SaveTextButton.Text = "Сохранить";
            this.SaveTextButton.UseVisualStyleBackColor = true;
            this.SaveTextButton.Click += new System.EventHandler(this.SaveTextButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadButton.Location = new System.Drawing.Point(261, 100);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(124, 34);
            this.LoadButton.TabIndex = 21;
            this.LoadButton.Text = "Загрузить";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // CipherButton
            // 
            this.CipherButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CipherButton.Location = new System.Drawing.Point(261, 140);
            this.CipherButton.Name = "CipherButton";
            this.CipherButton.Size = new System.Drawing.Size(124, 34);
            this.CipherButton.TabIndex = 22;
            this.CipherButton.Text = "Шифровать";
            this.CipherButton.UseVisualStyleBackColor = true;
            this.CipherButton.Click += new System.EventHandler(this.CipherButton_Click);
            // 
            // DecipherButton
            // 
            this.DecipherButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecipherButton.Location = new System.Drawing.Point(261, 180);
            this.DecipherButton.Name = "DecipherButton";
            this.DecipherButton.Size = new System.Drawing.Size(124, 34);
            this.DecipherButton.TabIndex = 23;
            this.DecipherButton.Text = "Дешифровать";
            this.DecipherButton.UseVisualStyleBackColor = true;
            this.DecipherButton.Click += new System.EventHandler(this.DecipherButton_Click);
            // 
            // isCyrillicRButton
            // 
            this.isCyrillicRButton.AutoSize = true;
            this.isCyrillicRButton.Location = new System.Drawing.Point(275, 251);
            this.isCyrillicRButton.Name = "isCyrillicRButton";
            this.isCyrillicRButton.Size = new System.Drawing.Size(80, 17);
            this.isCyrillicRButton.TabIndex = 24;
            this.isCyrillicRButton.Text = "Кириллица";
            this.isCyrillicRButton.UseVisualStyleBackColor = true;
            // 
            // isLatinRButton
            // 
            this.isLatinRButton.AutoSize = true;
            this.isLatinRButton.Checked = true;
            this.isLatinRButton.Location = new System.Drawing.Point(275, 275);
            this.isLatinRButton.Name = "isLatinRButton";
            this.isLatinRButton.Size = new System.Drawing.Size(74, 17);
            this.isLatinRButton.TabIndex = 25;
            this.isLatinRButton.TabStop = true;
            this.isLatinRButton.Text = "Латиница";
            this.isLatinRButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CheckHashButton
            // 
            this.CheckHashButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckHashButton.Location = new System.Drawing.Point(261, 220);
            this.CheckHashButton.Name = "CheckHashButton";
            this.CheckHashButton.Size = new System.Drawing.Size(124, 34);
            this.CheckHashButton.TabIndex = 26;
            this.CheckHashButton.Text = "Проверка целостности данных";
            this.CheckHashButton.UseVisualStyleBackColor = true;
            this.CheckHashButton.Click += new System.EventHandler(this.CheckHashButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 304);
            this.Controls.Add(this.CheckHashButton);
            this.Controls.Add(this.isLatinRButton);
            this.Controls.Add(this.isCyrillicRButton);
            this.Controls.Add(this.DecipherButton);
            this.Controls.Add(this.CipherButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveTextButton);
            this.Controls.Add(this.DecoderTBLabel);
            this.Controls.Add(this.CoderTextBox);
            this.Controls.Add(this.CoderTBLabel);
            this.Controls.Add(this.DecoderTextBox);
            this.Controls.Add(this.ProgramNameLabel);
            this.Name = "Form1";
            this.Text = "TTSafe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProgramNameLabel;
        private System.Windows.Forms.RichTextBox DecoderTextBox;
        private System.Windows.Forms.Label CoderTBLabel;
        private System.Windows.Forms.Label DecoderTBLabel;
        private System.Windows.Forms.RichTextBox CoderTextBox;
        private System.Windows.Forms.Button SaveTextButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button CipherButton;
        private System.Windows.Forms.Button DecipherButton;
        private System.Windows.Forms.RadioButton isCyrillicRButton;
        private System.Windows.Forms.RadioButton isLatinRButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button CheckHashButton;
    }
}

