﻿namespace otel_otomasyon
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.menuler = new System.Windows.Forms.MenuStrip();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniMüşteriGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mevcutOlanMüşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriAramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boşOdalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doluOdalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuler.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuler
            // 
            this.menuler.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuler.ImageScalingSize = new System.Drawing.Size(16, 32);
            this.menuler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriToolStripMenuItem,
            this.odalarToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuler.Location = new System.Drawing.Point(0, 0);
            this.menuler.Name = "menuler";
            this.menuler.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuler.Size = new System.Drawing.Size(1350, 40);
            this.menuler.TabIndex = 1;
            this.menuler.Text = "menuStrip1";
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniMüşteriGirişiToolStripMenuItem,
            this.mevcutOlanMüşterilerToolStripMenuItem,
            this.müşteriAramaToolStripMenuItem});
            this.müşteriToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.müşteriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("müşteriToolStripMenuItem.Image")));
            this.müşteriToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(124, 36);
            this.müşteriToolStripMenuItem.Text = "Müşteri İşlemleri";
            // 
            // yeniMüşteriGirişiToolStripMenuItem
            // 
            this.yeniMüşteriGirişiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yeniMüşteriGirişiToolStripMenuItem.Image")));
            this.yeniMüşteriGirişiToolStripMenuItem.Name = "yeniMüşteriGirişiToolStripMenuItem";
            this.yeniMüşteriGirişiToolStripMenuItem.Size = new System.Drawing.Size(202, 38);
            this.yeniMüşteriGirişiToolStripMenuItem.Text = "Yeni Müşteri Girişi";
            this.yeniMüşteriGirişiToolStripMenuItem.Click += new System.EventHandler(this.yeniMüşteriGirişiToolStripMenuItem_Click);
            // 
            // mevcutOlanMüşterilerToolStripMenuItem
            // 
            this.mevcutOlanMüşterilerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mevcutOlanMüşterilerToolStripMenuItem.Image")));
            this.mevcutOlanMüşterilerToolStripMenuItem.Name = "mevcutOlanMüşterilerToolStripMenuItem";
            this.mevcutOlanMüşterilerToolStripMenuItem.Size = new System.Drawing.Size(202, 38);
            this.mevcutOlanMüşterilerToolStripMenuItem.Text = "Mevcut Olan Müşteriler";
            this.mevcutOlanMüşterilerToolStripMenuItem.Click += new System.EventHandler(this.mevcutOlanMüşterilerToolStripMenuItem_Click);
            // 
            // müşteriAramaToolStripMenuItem
            // 
            this.müşteriAramaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("müşteriAramaToolStripMenuItem.Image")));
            this.müşteriAramaToolStripMenuItem.Name = "müşteriAramaToolStripMenuItem";
            this.müşteriAramaToolStripMenuItem.Size = new System.Drawing.Size(202, 38);
            this.müşteriAramaToolStripMenuItem.Text = "Müşteri Arama";
            this.müşteriAramaToolStripMenuItem.Click += new System.EventHandler(this.müşteriAramaToolStripMenuItem_Click);
            // 
            // odalarToolStripMenuItem
            // 
            this.odalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doluOdalarToolStripMenuItem,
            this.boşOdalarToolStripMenuItem});
            this.odalarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("odalarToolStripMenuItem.Image")));
            this.odalarToolStripMenuItem.Name = "odalarToolStripMenuItem";
            this.odalarToolStripMenuItem.Size = new System.Drawing.Size(104, 36);
            this.odalarToolStripMenuItem.Text = "Oda İşlemleri";
            this.odalarToolStripMenuItem.Click += new System.EventHandler(this.odalarToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışToolStripMenuItem.Image")));
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(95, 36);
            this.çıkışToolStripMenuItem.Text = "Çıkış İşlemi";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // boşOdalarToolStripMenuItem
            // 
            this.boşOdalarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("boşOdalarToolStripMenuItem.Image")));
            this.boşOdalarToolStripMenuItem.Name = "boşOdalarToolStripMenuItem";
            this.boşOdalarToolStripMenuItem.Size = new System.Drawing.Size(152, 38);
            this.boşOdalarToolStripMenuItem.Text = "Boş Odalar";
            this.boşOdalarToolStripMenuItem.Click += new System.EventHandler(this.boşOdalarToolStripMenuItem_Click);
            // 
            // doluOdalarToolStripMenuItem
            // 
            this.doluOdalarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("doluOdalarToolStripMenuItem.Image")));
            this.doluOdalarToolStripMenuItem.Name = "doluOdalarToolStripMenuItem";
            this.doluOdalarToolStripMenuItem.Size = new System.Drawing.Size(152, 38);
            this.doluOdalarToolStripMenuItem.Text = "Dolu Odalar";
            this.doluOdalarToolStripMenuItem.Click += new System.EventHandler(this.doluOdalarToolStripMenuItem_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.menuler);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuler;
            this.Name = "anasayfa";
            this.Text = "Otel Otomasyon Version1.1";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.menuler.ResumeLayout(false);
            this.menuler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuler;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniMüşteriGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mevcutOlanMüşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriAramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doluOdalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boşOdalarToolStripMenuItem;
    }
}

