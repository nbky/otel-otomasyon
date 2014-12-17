namespace otel_otomasyon
{
    partial class kullanicigirisi
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
            this.girisbutonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // girisbutonu
            // 
            this.girisbutonu.Location = new System.Drawing.Point(36, 94);
            this.girisbutonu.Name = "girisbutonu";
            this.girisbutonu.Size = new System.Drawing.Size(212, 121);
            this.girisbutonu.TabIndex = 0;
            this.girisbutonu.Text = "Giriş";
            this.girisbutonu.UseVisualStyleBackColor = true;
            this.girisbutonu.Click += new System.EventHandler(this.girisbutonu_Click);
            // 
            // kullanicigirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.girisbutonu);
            this.Name = "kullanicigirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button girisbutonu;
    }
}