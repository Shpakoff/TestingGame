﻿namespace Игра
{
    partial class MenuForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuGame21 = new Игра.MenuGame2();
            this.menuChangeGame21 = new Игра.MenuChangeGame2();
            this.menuGame11 = new Игра.MenuGame1();
            this.menuChangeGames1 = new Игра.MenuChangeGames();
            this.menuTheory1 = new Игра.MenuTheory();
            this.menuSettings1 = new Игра.MenuSettings();
            this.menuRecords1 = new Игра.UserControls.MenuRecords();
            this.menuWeb1 = new Игра.UserControls.MenuWeb();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 519);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Koryaka Free Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(-9, 367);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(214, 69);
            this.button4.TabIndex = 5;
            this.button4.Text = "Records";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Koryaka Free Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(-10, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 69);
            this.button3.TabIndex = 4;
            this.button3.Text = "Setting";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Koryaka Free Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(-13, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 69);
            this.button2.TabIndex = 3;
            this.button2.Text = "Theory";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Koryaka Free Rounded", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(-13, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 69);
            this.button1.TabIndex = 2;
            this.button1.Text = "Games";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.PictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.PictureBox1_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(78)))), ((int)(((byte)(222)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(172, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 21);
            this.panel2.TabIndex = 1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(172, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 36);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(82, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 36);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(39, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 36);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(759, 0);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(39, 35);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Dock = System.Windows.Forms.DockStyle.Left;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button7.Size = new System.Drawing.Size(39, 36);
            this.button7.TabIndex = 5;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(714, 0);
            this.button6.Name = "button6";
            this.button6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button6.Size = new System.Drawing.Size(39, 35);
            this.button6.TabIndex = 2;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.menuGame21);
            this.panel4.Controls.Add(this.menuChangeGame21);
            this.panel4.Controls.Add(this.menuGame11);
            this.panel4.Controls.Add(this.menuChangeGames1);
            this.panel4.Controls.Add(this.menuTheory1);
            this.panel4.Controls.Add(this.menuSettings1);
            this.panel4.Controls.Add(this.menuRecords1);
            this.panel4.Controls.Add(this.menuWeb1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(172, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(801, 462);
            this.panel4.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // menuGame21
            // 
            this.menuGame21.AutoSize = true;
            this.menuGame21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(78)))), ((int)(((byte)(222)))));
            this.menuGame21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuGame21.Location = new System.Drawing.Point(0, 0);
            this.menuGame21.Name = "menuGame21";
            this.menuGame21.Size = new System.Drawing.Size(801, 462);
            this.menuGame21.TabIndex = 7;
            this.menuGame21.Click_Next_Game2 += new System.EventHandler(this.MenuGame21_Click_Next_Game2);
            // 
            // menuChangeGame21
            // 
            this.menuChangeGame21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(78)))), ((int)(((byte)(222)))));
            this.menuChangeGame21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuChangeGame21.Location = new System.Drawing.Point(0, 0);
            this.menuChangeGame21.Name = "menuChangeGame21";
            this.menuChangeGame21.Size = new System.Drawing.Size(801, 462);
            this.menuChangeGame21.TabIndex = 6;
            this.menuChangeGame21.Click_Ok_ChangeGame2 += new System.EventHandler(this.MenuChangeGame21_Click_Ok_ChangeGame2);
            // 
            // menuGame11
            // 
            this.menuGame11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(78)))), ((int)(((byte)(222)))));
            this.menuGame11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuGame11.Location = new System.Drawing.Point(0, 0);
            this.menuGame11.Name = "menuGame11";
            this.menuGame11.Size = new System.Drawing.Size(801, 462);
            this.menuGame11.TabIndex = 5;
            this.menuGame11.CLickOk += new System.EventHandler(this.MenuGame11_CLickOk);
            this.menuGame11.CLickNext += new System.EventHandler(this.MenuGame11_CLickNext);
            // 
            // menuChangeGames1
            // 
            this.menuChangeGames1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(78)))), ((int)(((byte)(222)))));
            this.menuChangeGames1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuChangeGames1.Location = new System.Drawing.Point(0, 0);
            this.menuChangeGames1.Name = "menuChangeGames1";
            this.menuChangeGames1.Size = new System.Drawing.Size(801, 462);
            this.menuChangeGames1.TabIndex = 4;
            this.menuChangeGames1.ClickFirstGame += new System.EventHandler(this.MenuChangeGames1_ClickFirstGame);
            this.menuChangeGames1.ClickSecondGame += new System.EventHandler(this.MenuChangeGames1_ClickSecondGame);
            // 
            // menuTheory1
            // 
            this.menuTheory1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(78)))), ((int)(((byte)(222)))));
            this.menuTheory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuTheory1.Location = new System.Drawing.Point(0, 0);
            this.menuTheory1.Name = "menuTheory1";
            this.menuTheory1.Size = new System.Drawing.Size(801, 462);
            this.menuTheory1.TabIndex = 3;
            this.menuTheory1.TreeViewAfterSelect += new System.EventHandler(this.MenuTheory1_TreeViewAfterSelect);
            // 
            // menuSettings1
            // 
            this.menuSettings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(37)))), ((int)(((byte)(149)))));
            this.menuSettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuSettings1.Location = new System.Drawing.Point(0, 0);
            this.menuSettings1.Name = "menuSettings1";
            this.menuSettings1.Size = new System.Drawing.Size(801, 462);
            this.menuSettings1.TabIndex = 2;
            this.menuSettings1.ClickDownload += new System.EventHandler(this.MenuSettings1_ClickDownload);
            this.menuSettings1.ClickToChange += new System.EventHandler(this.MenuSettings1_ClickToChange);
            // 
            // menuRecords1
            // 
            this.menuRecords1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuRecords1.Location = new System.Drawing.Point(0, 0);
            this.menuRecords1.Name = "menuRecords1";
            this.menuRecords1.Size = new System.Drawing.Size(801, 462);
            this.menuRecords1.TabIndex = 1;
            // 
            // menuWeb1
            // 
            this.menuWeb1.AutoSize = true;
            this.menuWeb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuWeb1.Location = new System.Drawing.Point(0, 0);
            this.menuWeb1.Name = "menuWeb1";
            this.menuWeb1.Size = new System.Drawing.Size(801, 462);
            this.menuWeb1.TabIndex = 0;
            // 
            // MenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(973, 519);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private UserControls.MenuWeb menuWeb1;
        private UserControls.MenuRecords menuRecords1;
        private MenuSettings menuSettings1;
        public System.Windows.Forms.PictureBox pictureBox2;
        private MenuTheory menuTheory1;
        private MenuChangeGames menuChangeGames1;
        public System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private MenuGame1 menuGame11;
        private MenuChangeGame2 menuChangeGame21;
        private MenuGame2 menuGame21;
    }
}