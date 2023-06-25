namespace Computer_Networks_Lab_5
{
    partial class ClientServerChat
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
            this.ServerLabel = new System.Windows.Forms.Label();
            this.ClientLabel = new System.Windows.Forms.Label();
            this.ServerIPLabel = new System.Windows.Forms.Label();
            this.ClientIPLabel = new System.Windows.Forms.Label();
            this.ServerPortLabel = new System.Windows.Forms.Label();
            this.ClientPortLabel = new System.Windows.Forms.Label();
            this.StartServerButton = new System.Windows.Forms.Button();
            this.ConnectClientButton = new System.Windows.Forms.Button();
            this.ServerIPTextBox = new System.Windows.Forms.TextBox();
            this.ServerPortTextBox = new System.Windows.Forms.TextBox();
            this.ClientPortTextBox = new System.Windows.Forms.TextBox();
            this.ClientIPTextBox = new System.Windows.Forms.TextBox();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.MessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ChatRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AdditionalStream1 = new System.ComponentModel.BackgroundWorker();
            this.AdditionalStream2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Location = new System.Drawing.Point(264, 30);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(44, 13);
            this.ServerLabel.TabIndex = 0;
            this.ServerLabel.Text = "Сервер";
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Location = new System.Drawing.Point(264, 94);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(43, 13);
            this.ClientLabel.TabIndex = 1;
            this.ClientLabel.Text = "Клиент";
            // 
            // ServerIPLabel
            // 
            this.ServerIPLabel.AutoSize = true;
            this.ServerIPLabel.Location = new System.Drawing.Point(56, 58);
            this.ServerIPLabel.Name = "ServerIPLabel";
            this.ServerIPLabel.Size = new System.Drawing.Size(17, 13);
            this.ServerIPLabel.TabIndex = 2;
            this.ServerIPLabel.Text = "IP";
            // 
            // ClientIPLabel
            // 
            this.ClientIPLabel.AutoSize = true;
            this.ClientIPLabel.Location = new System.Drawing.Point(56, 113);
            this.ClientIPLabel.Name = "ClientIPLabel";
            this.ClientIPLabel.Size = new System.Drawing.Size(17, 13);
            this.ClientIPLabel.TabIndex = 3;
            this.ClientIPLabel.Text = "IP";
            // 
            // ServerPortLabel
            // 
            this.ServerPortLabel.AutoSize = true;
            this.ServerPortLabel.Location = new System.Drawing.Point(394, 58);
            this.ServerPortLabel.Name = "ServerPortLabel";
            this.ServerPortLabel.Size = new System.Drawing.Size(32, 13);
            this.ServerPortLabel.TabIndex = 4;
            this.ServerPortLabel.Text = "Порт";
            // 
            // ClientPortLabel
            // 
            this.ClientPortLabel.AutoSize = true;
            this.ClientPortLabel.Location = new System.Drawing.Point(394, 113);
            this.ClientPortLabel.Name = "ClientPortLabel";
            this.ClientPortLabel.Size = new System.Drawing.Size(32, 13);
            this.ClientPortLabel.TabIndex = 5;
            this.ClientPortLabel.Text = "Порт";
            // 
            // StartServerButton
            // 
            this.StartServerButton.Location = new System.Drawing.Point(583, 45);
            this.StartServerButton.Name = "StartServerButton";
            this.StartServerButton.Size = new System.Drawing.Size(131, 31);
            this.StartServerButton.TabIndex = 6;
            this.StartServerButton.Text = "Запуск сервера";
            this.StartServerButton.UseVisualStyleBackColor = true;
            this.StartServerButton.Click += new System.EventHandler(this.StartServerButton_Click);
            // 
            // ConnectClientButton
            // 
            this.ConnectClientButton.Location = new System.Drawing.Point(583, 104);
            this.ConnectClientButton.Name = "ConnectClientButton";
            this.ConnectClientButton.Size = new System.Drawing.Size(131, 31);
            this.ConnectClientButton.TabIndex = 7;
            this.ConnectClientButton.Text = "Подключиться";
            this.ConnectClientButton.UseVisualStyleBackColor = true;
            this.ConnectClientButton.Click += new System.EventHandler(this.ConnectClientButton_Click);
            // 
            // ServerIPTextBox
            // 
            this.ServerIPTextBox.Location = new System.Drawing.Point(96, 51);
            this.ServerIPTextBox.Name = "ServerIPTextBox";
            this.ServerIPTextBox.Size = new System.Drawing.Size(100, 20);
            this.ServerIPTextBox.TabIndex = 8;
            // 
            // ServerPortTextBox
            // 
            this.ServerPortTextBox.Location = new System.Drawing.Point(432, 51);
            this.ServerPortTextBox.Name = "ServerPortTextBox";
            this.ServerPortTextBox.Size = new System.Drawing.Size(100, 20);
            this.ServerPortTextBox.TabIndex = 9;
            // 
            // ClientPortTextBox
            // 
            this.ClientPortTextBox.Location = new System.Drawing.Point(432, 110);
            this.ClientPortTextBox.Name = "ClientPortTextBox";
            this.ClientPortTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientPortTextBox.TabIndex = 10;
            // 
            // ClientIPTextBox
            // 
            this.ClientIPTextBox.Location = new System.Drawing.Point(96, 110);
            this.ClientIPTextBox.Name = "ClientIPTextBox";
            this.ClientIPTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientIPTextBox.TabIndex = 11;
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Location = new System.Drawing.Point(583, 411);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(131, 69);
            this.SendMessageButton.TabIndex = 12;
            this.SendMessageButton.Text = "Отправить сообщение";
            this.SendMessageButton.UseVisualStyleBackColor = true;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // MessageRichTextBox
            // 
            this.MessageRichTextBox.Location = new System.Drawing.Point(12, 411);
            this.MessageRichTextBox.Name = "MessageRichTextBox";
            this.MessageRichTextBox.Size = new System.Drawing.Size(553, 69);
            this.MessageRichTextBox.TabIndex = 13;
            this.MessageRichTextBox.Text = "";
            // 
            // ChatRichTextBox
            // 
            this.ChatRichTextBox.Location = new System.Drawing.Point(12, 194);
            this.ChatRichTextBox.Name = "ChatRichTextBox";
            this.ChatRichTextBox.Size = new System.Drawing.Size(702, 198);
            this.ChatRichTextBox.TabIndex = 14;
            this.ChatRichTextBox.Text = "";
            // 
            // AdditionalStream1
            // 
            this.AdditionalStream1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AdditionalStream1_DoWork);
            // 
            // AdditionalStream2
            // 
            this.AdditionalStream2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AdditionalStream2_DoWork);
            // 
            // ClientServerChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 503);
            this.Controls.Add(this.ChatRichTextBox);
            this.Controls.Add(this.MessageRichTextBox);
            this.Controls.Add(this.SendMessageButton);
            this.Controls.Add(this.ClientIPTextBox);
            this.Controls.Add(this.ClientPortTextBox);
            this.Controls.Add(this.ServerPortTextBox);
            this.Controls.Add(this.ServerIPTextBox);
            this.Controls.Add(this.ConnectClientButton);
            this.Controls.Add(this.StartServerButton);
            this.Controls.Add(this.ClientPortLabel);
            this.Controls.Add(this.ServerPortLabel);
            this.Controls.Add(this.ClientIPLabel);
            this.Controls.Add(this.ServerIPLabel);
            this.Controls.Add(this.ClientLabel);
            this.Controls.Add(this.ServerLabel);
            this.Name = "ClientServerChat";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.Label ServerIPLabel;
        private System.Windows.Forms.Label ClientIPLabel;
        private System.Windows.Forms.Label ServerPortLabel;
        private System.Windows.Forms.Label ClientPortLabel;
        private System.Windows.Forms.Button StartServerButton;
        private System.Windows.Forms.Button ConnectClientButton;
        private System.Windows.Forms.TextBox ServerIPTextBox;
        private System.Windows.Forms.TextBox ServerPortTextBox;
        private System.Windows.Forms.TextBox ClientPortTextBox;
        private System.Windows.Forms.TextBox ClientIPTextBox;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.RichTextBox MessageRichTextBox;
        private System.Windows.Forms.RichTextBox ChatRichTextBox;
        private System.ComponentModel.BackgroundWorker AdditionalStream1;
        private System.ComponentModel.BackgroundWorker AdditionalStream2;
    }
}

