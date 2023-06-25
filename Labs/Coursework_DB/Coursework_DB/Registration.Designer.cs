namespace Coursework_DB
{
    partial class Registration
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
            this.PasswordRepeatLabel = new System.Windows.Forms.Label();
            this.PasswordRepeatTBox = new System.Windows.Forms.TextBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginTBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PasswordRepeatLabel
            // 
            this.PasswordRepeatLabel.AutoSize = true;
            this.PasswordRepeatLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordRepeatLabel.Location = new System.Drawing.Point(19, 107);
            this.PasswordRepeatLabel.Name = "PasswordRepeatLabel";
            this.PasswordRepeatLabel.Size = new System.Drawing.Size(151, 19);
            this.PasswordRepeatLabel.TabIndex = 31;
            this.PasswordRepeatLabel.Text = "Подтвердите пароль:";
            // 
            // PasswordRepeatTBox
            // 
            this.PasswordRepeatTBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordRepeatTBox.Location = new System.Drawing.Point(174, 110);
            this.PasswordRepeatTBox.Name = "PasswordRepeatTBox";
            this.PasswordRepeatTBox.Size = new System.Drawing.Size(100, 26);
            this.PasswordRepeatTBox.TabIndex = 30;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationButton.Location = new System.Drawing.Point(78, 160);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(124, 61);
            this.RegistrationButton.TabIndex = 29;
            this.RegistrationButton.Text = "Регистрация";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(19, 77);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(61, 19);
            this.PasswordLabel.TabIndex = 28;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // PasswordTBox
            // 
            this.PasswordTBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTBox.Location = new System.Drawing.Point(174, 79);
            this.PasswordTBox.Name = "PasswordTBox";
            this.PasswordTBox.Size = new System.Drawing.Size(100, 26);
            this.PasswordTBox.TabIndex = 27;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(19, 46);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(55, 19);
            this.LoginLabel.TabIndex = 26;
            this.LoginLabel.Text = "Логин:";
            // 
            // LoginTBox
            // 
            this.LoginTBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTBox.Location = new System.Drawing.Point(174, 47);
            this.LoginTBox.Name = "LoginTBox";
            this.LoginTBox.Size = new System.Drawing.Size(100, 26);
            this.LoginTBox.TabIndex = 25;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 267);
            this.Controls.Add(this.PasswordRepeatLabel);
            this.Controls.Add(this.PasswordRepeatTBox);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTBox);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LoginTBox);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PasswordRepeatLabel;
        private System.Windows.Forms.TextBox PasswordRepeatTBox;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox LoginTBox;

    }
}