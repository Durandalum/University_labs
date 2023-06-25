namespace FSR_Lab_15
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.drone_picture_box = new System.Windows.Forms.PictureBox();
            this.bottle_picture_box = new System.Windows.Forms.PictureBox();
            this.building_picture_box = new System.Windows.Forms.PictureBox();
            this.fire_picture_box = new System.Windows.Forms.PictureBox();
            this.message_label = new System.Windows.Forms.Label();
            this.right_button = new System.Windows.Forms.Button();
            this.left_button = new System.Windows.Forms.Button();
            this.down_button = new System.Windows.Forms.Button();
            this.up_button = new System.Windows.Forms.Button();
            this.info_button = new System.Windows.Forms.Button();
            this.extinguish_button = new System.Windows.Forms.Button();
            this.restart_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drone_picture_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottle_picture_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.building_picture_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire_picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // drone_picture_box
            // 
            this.drone_picture_box.Image = ((System.Drawing.Image)(resources.GetObject("drone_picture_box.Image")));
            this.drone_picture_box.Location = new System.Drawing.Point(12, 559);
            this.drone_picture_box.Name = "drone_picture_box";
            this.drone_picture_box.Size = new System.Drawing.Size(49, 23);
            this.drone_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.drone_picture_box.TabIndex = 6;
            this.drone_picture_box.TabStop = false;
            // 
            // bottle_picture_box
            // 
            this.bottle_picture_box.Image = ((System.Drawing.Image)(resources.GetObject("bottle_picture_box.Image")));
            this.bottle_picture_box.Location = new System.Drawing.Point(21, 578);
            this.bottle_picture_box.Name = "bottle_picture_box";
            this.bottle_picture_box.Size = new System.Drawing.Size(30, 33);
            this.bottle_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottle_picture_box.TabIndex = 7;
            this.bottle_picture_box.TabStop = false;
            // 
            // building_picture_box
            // 
            this.building_picture_box.Image = ((System.Drawing.Image)(resources.GetObject("building_picture_box.Image")));
            this.building_picture_box.Location = new System.Drawing.Point(621, -9);
            this.building_picture_box.Name = "building_picture_box";
            this.building_picture_box.Size = new System.Drawing.Size(347, 634);
            this.building_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.building_picture_box.TabIndex = 8;
            this.building_picture_box.TabStop = false;
            // 
            // fire_picture_box
            // 
            this.fire_picture_box.Image = ((System.Drawing.Image)(resources.GetObject("fire_picture_box.Image")));
            this.fire_picture_box.Location = new System.Drawing.Point(668, 100);
            this.fire_picture_box.Name = "fire_picture_box";
            this.fire_picture_box.Size = new System.Drawing.Size(55, 20);
            this.fire_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fire_picture_box.TabIndex = 9;
            this.fire_picture_box.TabStop = false;
            // 
            // message_label
            // 
            this.message_label.AutoSize = true;
            this.message_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.message_label.ForeColor = System.Drawing.Color.Red;
            this.message_label.Location = new System.Drawing.Point(317, 61);
            this.message_label.Name = "message_label";
            this.message_label.Size = new System.Drawing.Size(113, 21);
            this.message_label.TabIndex = 10;
            this.message_label.Text = "Цель далеко!";
            // 
            // right_button
            // 
            this.right_button.Location = new System.Drawing.Point(102, 155);
            this.right_button.Name = "right_button";
            this.right_button.Size = new System.Drawing.Size(33, 33);
            this.right_button.TabIndex = 13;
            this.right_button.Text = "→";
            this.right_button.UseVisualStyleBackColor = true;
            this.right_button.Click += new System.EventHandler(this.right_button_Click);
            // 
            // left_button
            // 
            this.left_button.Location = new System.Drawing.Point(24, 155);
            this.left_button.Name = "left_button";
            this.left_button.Size = new System.Drawing.Size(33, 33);
            this.left_button.TabIndex = 14;
            this.left_button.Text = "←";
            this.left_button.UseVisualStyleBackColor = true;
            this.left_button.Click += new System.EventHandler(this.left_button_Click);
            // 
            // down_button
            // 
            this.down_button.Location = new System.Drawing.Point(63, 194);
            this.down_button.Name = "down_button";
            this.down_button.Size = new System.Drawing.Size(33, 33);
            this.down_button.TabIndex = 15;
            this.down_button.Text = "↓";
            this.down_button.UseVisualStyleBackColor = true;
            this.down_button.Click += new System.EventHandler(this.down_button_Click);
            // 
            // up_button
            // 
            this.up_button.Location = new System.Drawing.Point(63, 116);
            this.up_button.Name = "up_button";
            this.up_button.Size = new System.Drawing.Size(33, 33);
            this.up_button.TabIndex = 16;
            this.up_button.Text = "↑";
            this.up_button.UseVisualStyleBackColor = true;
            this.up_button.Click += new System.EventHandler(this.up_button_Click);
            // 
            // info_button
            // 
            this.info_button.Location = new System.Drawing.Point(63, 155);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(33, 33);
            this.info_button.TabIndex = 17;
            this.info_button.Text = "Info";
            this.info_button.UseVisualStyleBackColor = true;
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            // 
            // extinguish_button
            // 
            this.extinguish_button.Location = new System.Drawing.Point(21, 41);
            this.extinguish_button.Name = "extinguish_button";
            this.extinguish_button.Size = new System.Drawing.Size(75, 23);
            this.extinguish_button.TabIndex = 18;
            this.extinguish_button.Text = "Потушить";
            this.extinguish_button.UseVisualStyleBackColor = true;
            this.extinguish_button.Click += new System.EventHandler(this.extinguish_button_Click);
            // 
            // restart_button
            // 
            this.restart_button.Location = new System.Drawing.Point(21, 70);
            this.restart_button.Name = "restart_button";
            this.restart_button.Size = new System.Drawing.Size(75, 23);
            this.restart_button.TabIndex = 19;
            this.restart_button.Text = "Рестарт";
            this.restart_button.UseVisualStyleBackColor = true;
            this.restart_button.Click += new System.EventHandler(this.restart_button_Click);
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(21, 12);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 20;
            this.start_button.Text = "Старт";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(967, 624);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.restart_button);
            this.Controls.Add(this.extinguish_button);
            this.Controls.Add(this.info_button);
            this.Controls.Add(this.up_button);
            this.Controls.Add(this.down_button);
            this.Controls.Add(this.left_button);
            this.Controls.Add(this.right_button);
            this.Controls.Add(this.message_label);
            this.Controls.Add(this.fire_picture_box);
            this.Controls.Add(this.building_picture_box);
            this.Controls.Add(this.bottle_picture_box);
            this.Controls.Add(this.drone_picture_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Управление дроном";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.drone_picture_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottle_picture_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.building_picture_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire_picture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drone_picture_box;
        private System.Windows.Forms.PictureBox bottle_picture_box;
        private System.Windows.Forms.PictureBox building_picture_box;
        private System.Windows.Forms.PictureBox fire_picture_box;
        private System.Windows.Forms.Label message_label;
        private System.Windows.Forms.Button right_button;
        private System.Windows.Forms.Button left_button;
        private System.Windows.Forms.Button down_button;
        private System.Windows.Forms.Button up_button;
        private System.Windows.Forms.Button info_button;
        private System.Windows.Forms.Button extinguish_button;
        private System.Windows.Forms.Button restart_button;
        private System.Windows.Forms.Button start_button;
    }
}

