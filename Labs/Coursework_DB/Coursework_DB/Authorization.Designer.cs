namespace Coursework_DB
{
    partial class Authorization
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
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.AuthorizationLabel = new System.Windows.Forms.Label();
            this.MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.RegistrationLabel = new System.Windows.Forms.LinkLabel();
            this.AuthorizationButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginTBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyNameLabel.Location = new System.Drawing.Point(83, 20);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(489, 19);
            this.CompanyNameLabel.TabIndex = 0;
            this.CompanyNameLabel.Text = "Добро пожаловать! Вас приветствует компания \"Fly Away Now\"!";
            this.CompanyNameLabel.Click += new System.EventHandler(this.CompanyNameLabel_Click);
            // 
            // AuthorizationLabel
            // 
            this.AuthorizationLabel.AutoSize = true;
            this.AuthorizationLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizationLabel.Location = new System.Drawing.Point(12, 53);
            this.AuthorizationLabel.Name = "AuthorizationLabel";
            this.AuthorizationLabel.Size = new System.Drawing.Size(611, 19);
            this.AuthorizationLabel.TabIndex = 1;
            this.AuthorizationLabel.Text = "Для начала вам необходимо пройти авторизацию. Введите логин и пароль, пожалуйста:" +
                "";
            this.AuthorizationLabel.Click += new System.EventHandler(this.AuthorizationLabel_Click);
            // 
            // MaskedTextBox
            // 
            this.MaskedTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.MaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaskedTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaskedTextBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.MaskedTextBox.Location = new System.Drawing.Point(332, 97);
            this.MaskedTextBox.Name = "MaskedTextBox";
            this.MaskedTextBox.ReadOnly = true;
            this.MaskedTextBox.Size = new System.Drawing.Size(138, 19);
            this.MaskedTextBox.TabIndex = 26;
            this.MaskedTextBox.Text = "Login: HappyBomber";
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.AutoSize = true;
            this.RegistrationLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RegistrationLabel.Location = new System.Drawing.Point(221, 239);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(163, 19);
            this.RegistrationLabel.TabIndex = 25;
            this.RegistrationLabel.TabStop = true;
            this.RegistrationLabel.Text = "Не зарегистрированы?";
            this.RegistrationLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            // 
            // AuthorizationButton
            // 
            this.AuthorizationButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizationButton.Location = new System.Drawing.Point(240, 166);
            this.AuthorizationButton.Name = "AuthorizationButton";
            this.AuthorizationButton.Size = new System.Drawing.Size(124, 61);
            this.AuthorizationButton.TabIndex = 24;
            this.AuthorizationButton.Text = "Авторизация";
            this.AuthorizationButton.UseVisualStyleBackColor = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(153, 120);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(61, 19);
            this.PasswordLabel.TabIndex = 23;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // PasswordTBox
            // 
            this.PasswordTBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTBox.Location = new System.Drawing.Point(226, 121);
            this.PasswordTBox.Name = "PasswordTBox";
            this.PasswordTBox.Size = new System.Drawing.Size(100, 26);
            this.PasswordTBox.TabIndex = 22;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(153, 89);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(55, 19);
            this.LoginLabel.TabIndex = 21;
            this.LoginLabel.Text = "Логин:";
            // 
            // LoginTBox
            // 
            this.LoginTBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTBox.Location = new System.Drawing.Point(226, 90);
            this.LoginTBox.Name = "LoginTBox";
            this.LoginTBox.Size = new System.Drawing.Size(100, 26);
            this.LoginTBox.TabIndex = 20;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 281);
            this.Controls.Add(this.MaskedTextBox);
            this.Controls.Add(this.RegistrationLabel);
            this.Controls.Add(this.AuthorizationButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTBox);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LoginTBox);
            this.Controls.Add(this.AuthorizationLabel);
            this.Controls.Add(this.CompanyNameLabel);
            this.Name = "Authorization";
            this.Text = "Fly Away Now";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.Label AuthorizationLabel;
        private System.Windows.Forms.MaskedTextBox MaskedTextBox;
        private System.Windows.Forms.LinkLabel RegistrationLabel;
        private System.Windows.Forms.Button AuthorizationButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox LoginTBox;
    }
}

