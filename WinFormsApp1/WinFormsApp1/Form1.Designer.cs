﻿namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            畫筆色彩ToolStripMenuItem = new ToolStripMenuItem();
            藍色ToolStripMenuItem = new ToolStripMenuItem();
            紅色ToolStripMenuItem = new ToolStripMenuItem();
            綠色ToolStripMenuItem = new ToolStripMenuItem();
            黑色ToolStripMenuItem = new ToolStripMenuItem();
            橡皮擦ToolStripMenuItem = new ToolStripMenuItem();
            線條粗細ToolStripMenuItem = new ToolStripMenuItem();
            細ToolStripMenuItem = new ToolStripMenuItem();
            中ToolStripMenuItem = new ToolStripMenuItem();
            粗ToolStripMenuItem = new ToolStripMenuItem();
            超級粗ToolStripMenuItem = new ToolStripMenuItem();
            線條樣式ToolStripMenuItem = new ToolStripMenuItem();
            直線ToolStripMenuItem = new ToolStripMenuItem();
            虛線ToolStripMenuItem = new ToolStripMenuItem();
            長短虛線ToolStripMenuItem = new ToolStripMenuItem();
            檔案儲存ToolStripMenuItem = new ToolStripMenuItem();
            儲存檔案ToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 畫筆色彩ToolStripMenuItem, 線條粗細ToolStripMenuItem, 線條樣式ToolStripMenuItem, 檔案儲存ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(462, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 畫筆色彩ToolStripMenuItem
            // 
            畫筆色彩ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 藍色ToolStripMenuItem, 紅色ToolStripMenuItem, 綠色ToolStripMenuItem, 黑色ToolStripMenuItem, 橡皮擦ToolStripMenuItem });
            畫筆色彩ToolStripMenuItem.Name = "畫筆色彩ToolStripMenuItem";
            畫筆色彩ToolStripMenuItem.Size = new Size(67, 20);
            畫筆色彩ToolStripMenuItem.Text = "畫筆色彩";
            // 
            // 藍色ToolStripMenuItem
            // 
            藍色ToolStripMenuItem.Name = "藍色ToolStripMenuItem";
            藍色ToolStripMenuItem.Size = new Size(110, 22);
            藍色ToolStripMenuItem.Text = "藍色";
            藍色ToolStripMenuItem.Click += 藍色ToolStripMenuItem_Click;
            藍色ToolStripMenuItem.MouseMove += 藍色ToolStripMenuItem_MouseMove;
            // 
            // 紅色ToolStripMenuItem
            // 
            紅色ToolStripMenuItem.Name = "紅色ToolStripMenuItem";
            紅色ToolStripMenuItem.Size = new Size(110, 22);
            紅色ToolStripMenuItem.Text = "紅色";
            紅色ToolStripMenuItem.Click += 紅色ToolStripMenuItem_Click;
            // 
            // 綠色ToolStripMenuItem
            // 
            綠色ToolStripMenuItem.Name = "綠色ToolStripMenuItem";
            綠色ToolStripMenuItem.Size = new Size(110, 22);
            綠色ToolStripMenuItem.Text = "綠色";
            綠色ToolStripMenuItem.Click += 綠色ToolStripMenuItem_Click;
            // 
            // 黑色ToolStripMenuItem
            // 
            黑色ToolStripMenuItem.Name = "黑色ToolStripMenuItem";
            黑色ToolStripMenuItem.Size = new Size(110, 22);
            黑色ToolStripMenuItem.Text = "黑色";
            黑色ToolStripMenuItem.Click += 黑色ToolStripMenuItem_Click;
            // 
            // 橡皮擦ToolStripMenuItem
            // 
            橡皮擦ToolStripMenuItem.Name = "橡皮擦ToolStripMenuItem";
            橡皮擦ToolStripMenuItem.Size = new Size(110, 22);
            橡皮擦ToolStripMenuItem.Text = "橡皮擦";
            橡皮擦ToolStripMenuItem.Click += 橡皮擦ToolStripMenuItem_Click;
            // 
            // 線條粗細ToolStripMenuItem
            // 
            線條粗細ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 細ToolStripMenuItem, 中ToolStripMenuItem, 粗ToolStripMenuItem, 超級粗ToolStripMenuItem });
            線條粗細ToolStripMenuItem.Name = "線條粗細ToolStripMenuItem";
            線條粗細ToolStripMenuItem.Size = new Size(67, 20);
            線條粗細ToolStripMenuItem.Text = "線條粗細";
            // 
            // 細ToolStripMenuItem
            // 
            細ToolStripMenuItem.Name = "細ToolStripMenuItem";
            細ToolStripMenuItem.Size = new Size(110, 22);
            細ToolStripMenuItem.Text = "細";
            細ToolStripMenuItem.Click += 細ToolStripMenuItem_Click;
            // 
            // 中ToolStripMenuItem
            // 
            中ToolStripMenuItem.Name = "中ToolStripMenuItem";
            中ToolStripMenuItem.Size = new Size(110, 22);
            中ToolStripMenuItem.Text = "中";
            中ToolStripMenuItem.Click += 中ToolStripMenuItem_Click;
            // 
            // 粗ToolStripMenuItem
            // 
            粗ToolStripMenuItem.Name = "粗ToolStripMenuItem";
            粗ToolStripMenuItem.Size = new Size(110, 22);
            粗ToolStripMenuItem.Text = "粗";
            粗ToolStripMenuItem.Click += 粗ToolStripMenuItem_Click;
            // 
            // 超級粗ToolStripMenuItem
            // 
            超級粗ToolStripMenuItem.Name = "超級粗ToolStripMenuItem";
            超級粗ToolStripMenuItem.Size = new Size(110, 22);
            超級粗ToolStripMenuItem.Text = "超級粗";
            超級粗ToolStripMenuItem.Click += 超級粗ToolStripMenuItem_Click;
            // 
            // 線條樣式ToolStripMenuItem
            // 
            線條樣式ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 直線ToolStripMenuItem, 虛線ToolStripMenuItem, 長短虛線ToolStripMenuItem });
            線條樣式ToolStripMenuItem.Name = "線條樣式ToolStripMenuItem";
            線條樣式ToolStripMenuItem.Size = new Size(67, 20);
            線條樣式ToolStripMenuItem.Text = "線條樣式";
            // 
            // 直線ToolStripMenuItem
            // 
            直線ToolStripMenuItem.Name = "直線ToolStripMenuItem";
            直線ToolStripMenuItem.Size = new Size(122, 22);
            直線ToolStripMenuItem.Text = "直線";
            直線ToolStripMenuItem.Click += 直線ToolStripMenuItem_Click;
            // 
            // 虛線ToolStripMenuItem
            // 
            虛線ToolStripMenuItem.Name = "虛線ToolStripMenuItem";
            虛線ToolStripMenuItem.Size = new Size(122, 22);
            虛線ToolStripMenuItem.Text = "點虛線";
            虛線ToolStripMenuItem.Click += 虛線ToolStripMenuItem_Click;
            // 
            // 長短虛線ToolStripMenuItem
            // 
            長短虛線ToolStripMenuItem.Name = "長短虛線ToolStripMenuItem";
            長短虛線ToolStripMenuItem.Size = new Size(122, 22);
            長短虛線ToolStripMenuItem.Text = "長短虛線";
            長短虛線ToolStripMenuItem.Click += 長短虛線ToolStripMenuItem_Click;
            // 
            // 檔案儲存ToolStripMenuItem
            // 
            檔案儲存ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 儲存檔案ToolStripMenuItem });
            檔案儲存ToolStripMenuItem.Name = "檔案儲存ToolStripMenuItem";
            檔案儲存ToolStripMenuItem.Size = new Size(67, 20);
            檔案儲存ToolStripMenuItem.Text = "檔案儲存";
            // 
            // 儲存檔案ToolStripMenuItem
            // 
            儲存檔案ToolStripMenuItem.Name = "儲存檔案ToolStripMenuItem";
            儲存檔案ToolStripMenuItem.Size = new Size(122, 22);
            儲存檔案ToolStripMenuItem.Text = "儲存檔案";
            儲存檔案ToolStripMenuItem.Click += 儲存檔案ToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(378, 264);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // button1
            // 
            button1.Location = new Point(396, 241);
            button1.Name = "button1";
            button1.Size = new Size(60, 38);
            button1.TabIndex = 2;
            button1.Text = "清除";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 291);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 畫筆色彩ToolStripMenuItem;
        private ToolStripMenuItem 藍色ToolStripMenuItem;
        private ToolStripMenuItem 紅色ToolStripMenuItem;
        private ToolStripMenuItem 綠色ToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem 線條粗細ToolStripMenuItem;
        private ToolStripMenuItem 線條樣式ToolStripMenuItem;
        private ToolStripMenuItem 檔案儲存ToolStripMenuItem;
        private ToolStripMenuItem 黑色ToolStripMenuItem;
        private ToolStripMenuItem 細ToolStripMenuItem;
        private ToolStripMenuItem 中ToolStripMenuItem;
        private ToolStripMenuItem 粗ToolStripMenuItem;
        private ToolStripMenuItem 超級粗ToolStripMenuItem;
        private ToolStripMenuItem 直線ToolStripMenuItem;
        private ToolStripMenuItem 虛線ToolStripMenuItem;
        private ToolStripMenuItem 儲存檔案ToolStripMenuItem;
        private ToolStripMenuItem 長短虛線ToolStripMenuItem;
        private Button button1;
        private ToolStripMenuItem 橡皮擦ToolStripMenuItem;
    }
}