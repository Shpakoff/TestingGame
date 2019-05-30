namespace Игра
{
    partial class MenuChangeGame2
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuChangeGame2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bunifuiOSSwitch1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuiOSSwitch2 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuiOSSwitch3 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuiOSSwitch4 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Koryaka Free Rounded", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Правила";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Koryaka Free Rounded", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(746, 76);
            this.label2.TabIndex = 20;
            this.label2.Text = "Вы должны найти ошибку в частях кода и написать номер строки в которой она \r\nнахо" +
    "дится.\r\n\r\nДля начала выберите язык программирования на котором будут написаны ча" +
    "сти кода:\r\n";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox1.Font = new System.Drawing.Font("Koryaka Free Rounded", 15.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Без времени",
            "1 мин",
            "5 мин",
            "10 мин",
            "15 мин",
            "20 мин"});
            this.comboBox1.Location = new System.Drawing.Point(506, 187);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(276, 33);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.Text = "Выбор времени";
            // 
            // bunifuiOSSwitch1
            // 
            this.bunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch1.BackgroundImage")));
            this.bunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch1.Location = new System.Drawing.Point(40, 227);
            this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
            this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.bunifuiOSSwitch1.Size = new System.Drawing.Size(43, 25);
            this.bunifuiOSSwitch1.TabIndex = 22;
            this.bunifuiOSSwitch1.Value = false;
            this.bunifuiOSSwitch1.Click += new System.EventHandler(this.BunifuiOSSwitch1_Click);
            // 
            // bunifuiOSSwitch2
            // 
            this.bunifuiOSSwitch2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch2.BackgroundImage")));
            this.bunifuiOSSwitch2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch2.Location = new System.Drawing.Point(334, 227);
            this.bunifuiOSSwitch2.Name = "bunifuiOSSwitch2";
            this.bunifuiOSSwitch2.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch2.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.bunifuiOSSwitch2.Size = new System.Drawing.Size(43, 25);
            this.bunifuiOSSwitch2.TabIndex = 23;
            this.bunifuiOSSwitch2.Value = false;
            this.bunifuiOSSwitch2.Click += new System.EventHandler(this.BunifuiOSSwitch2_Click);
            // 
            // bunifuiOSSwitch3
            // 
            this.bunifuiOSSwitch3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch3.BackgroundImage")));
            this.bunifuiOSSwitch3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch3.Location = new System.Drawing.Point(40, 314);
            this.bunifuiOSSwitch3.Name = "bunifuiOSSwitch3";
            this.bunifuiOSSwitch3.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch3.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.bunifuiOSSwitch3.Size = new System.Drawing.Size(43, 25);
            this.bunifuiOSSwitch3.TabIndex = 24;
            this.bunifuiOSSwitch3.Value = false;
            this.bunifuiOSSwitch3.Click += new System.EventHandler(this.BunifuiOSSwitch3_Click);
            // 
            // bunifuiOSSwitch4
            // 
            this.bunifuiOSSwitch4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch4.BackgroundImage")));
            this.bunifuiOSSwitch4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch4.Location = new System.Drawing.Point(334, 314);
            this.bunifuiOSSwitch4.Name = "bunifuiOSSwitch4";
            this.bunifuiOSSwitch4.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch4.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.bunifuiOSSwitch4.Size = new System.Drawing.Size(43, 25);
            this.bunifuiOSSwitch4.TabIndex = 25;
            this.bunifuiOSSwitch4.Value = false;
            this.bunifuiOSSwitch4.Click += new System.EventHandler(this.BunifuiOSSwitch4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Koryaka Free Rounded", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "А также уровень сложности:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Koryaka Free Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(89, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Pascal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Koryaka Free Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(383, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "C#";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Koryaka Free Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(89, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Простой";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Koryaka Free Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(383, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Сложный";
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 50;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(89)))), ((int)(((byte)(245)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(89)))), ((int)(((byte)(245)))));
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(78)))), ((int)(((byte)(222)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Ok";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Koryaka Free Rounded", 18F);
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 50;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(37)))), ((int)(((byte)(149)))));
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(37)))), ((int)(((byte)(149)))));
            this.bunifuThinButton22.Location = new System.Drawing.Point(590, 383);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(192, 67);
            this.bunifuThinButton22.TabIndex = 31;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.BunifuThinButton22_Click);
            // 
            // MenuChangeGame2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(78)))), ((int)(((byte)(222)))));
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuiOSSwitch4);
            this.Controls.Add(this.bunifuiOSSwitch3);
            this.Controls.Add(this.bunifuiOSSwitch2);
            this.Controls.Add(this.bunifuiOSSwitch1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MenuChangeGame2";
            this.Size = new System.Drawing.Size(801, 455);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch1;
        public Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch2;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        public Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch3;
        public Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch4;
    }
}
