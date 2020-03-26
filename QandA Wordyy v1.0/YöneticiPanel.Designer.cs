namespace QandA_Wordyy_v1._0
{
    partial class YöneticiPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YöneticiPanel));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PicKapat = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kelimeSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışmaSayısıBelirleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.GroupKelime = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CheckedTekrar = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RadioÇalışma = new System.Windows.Forms.RadioButton();
            this.RadioKelime = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PicKapat)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.GroupKelime.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PicKapat
            // 
            this.PicKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicKapat.BackColor = System.Drawing.Color.Transparent;
            this.PicKapat.Image = ((System.Drawing.Image)(resources.GetObject("PicKapat.Image")));
            this.PicKapat.Location = new System.Drawing.Point(412, 1);
            this.PicKapat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PicKapat.Name = "PicKapat";
            this.PicKapat.Size = new System.Drawing.Size(29, 26);
            this.PicKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicKapat.TabIndex = 5;
            this.PicKapat.TabStop = false;
            this.PicKapat.Click += new System.EventHandler(this.PicKapat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 32);
            this.panel1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(402, 32);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kelimeSeçToolStripMenuItem,
            this.çalışmaSayısıBelirleToolStripMenuItem});
            this.menüToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.menüToolStripMenuItem.Image = global::QandA_Wordyy_v1._0.Properties.Resources._18_Menü;
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(83, 28);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // kelimeSeçToolStripMenuItem
            // 
            this.kelimeSeçToolStripMenuItem.Name = "kelimeSeçToolStripMenuItem";
            this.kelimeSeçToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.kelimeSeçToolStripMenuItem.Text = "Kelime Seç";
            this.kelimeSeçToolStripMenuItem.Click += new System.EventHandler(this.kelimeSeçToolStripMenuItem_Click);
            // 
            // çalışmaSayısıBelirleToolStripMenuItem
            // 
            this.çalışmaSayısıBelirleToolStripMenuItem.Name = "çalışmaSayısıBelirleToolStripMenuItem";
            this.çalışmaSayısıBelirleToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.çalışmaSayısıBelirleToolStripMenuItem.Text = "Çalışma Sayısı Belirle";
            this.çalışmaSayısıBelirleToolStripMenuItem.Click += new System.EventHandler(this.çalışmaSayısıBelirleToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Enabled = false;
            this.ayarlarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ayarlarToolStripMenuItem.Image = global::QandA_Wordyy_v1._0.Properties.Resources._8_İşlemler;
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Enabled = false;
            this.hakkındaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.hakkındaToolStripMenuItem.Image = global::QandA_Wordyy_v1._0.Properties.Resources._5_Bilgi;
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(111, 28);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.çıkışToolStripMenuItem.Image = global::QandA_Wordyy_v1._0.Properties.Resources._13_Çıkış;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(71, 28);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::QandA_Wordyy_v1._0.Properties.Resources._20;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(7, 76);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(426, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Başlat";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GroupKelime
            // 
            this.GroupKelime.BackColor = System.Drawing.Color.Transparent;
            this.GroupKelime.Controls.Add(this.panel3);
            this.GroupKelime.Controls.Add(this.button2);
            this.GroupKelime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GroupKelime.ForeColor = System.Drawing.Color.White;
            this.GroupKelime.Location = new System.Drawing.Point(1, 83);
            this.GroupKelime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GroupKelime.Name = "GroupKelime";
            this.GroupKelime.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GroupKelime.Size = new System.Drawing.Size(440, 121);
            this.GroupKelime.TabIndex = 8;
            this.GroupKelime.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CheckedTekrar);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(11, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(422, 42);
            this.panel3.TabIndex = 8;
            // 
            // CheckedTekrar
            // 
            this.CheckedTekrar.AutoSize = true;
            this.CheckedTekrar.Location = new System.Drawing.Point(239, 9);
            this.CheckedTekrar.Name = "CheckedTekrar";
            this.CheckedTekrar.Size = new System.Drawing.Size(156, 25);
            this.CheckedTekrar.TabIndex = 11;
            this.CheckedTekrar.Text = "Tekrar Edilsin Mi?";
            this.CheckedTekrar.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(134, 8);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(92, 27);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kelime Sayısı";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.RadioÇalışma);
            this.panel2.Controls.Add(this.RadioKelime);
            this.panel2.Location = new System.Drawing.Point(1, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 39);
            this.panel2.TabIndex = 9;
            // 
            // RadioÇalışma
            // 
            this.RadioÇalışma.AutoSize = true;
            this.RadioÇalışma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RadioÇalışma.ForeColor = System.Drawing.Color.White;
            this.RadioÇalışma.Location = new System.Drawing.Point(238, 6);
            this.RadioÇalışma.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RadioÇalışma.Name = "RadioÇalışma";
            this.RadioÇalışma.Size = new System.Drawing.Size(133, 25);
            this.RadioÇalışma.TabIndex = 1;
            this.RadioÇalışma.TabStop = true;
            this.RadioÇalışma.Text = "Tüm Kelimeler";
            this.RadioÇalışma.UseVisualStyleBackColor = true;
            // 
            // RadioKelime
            // 
            this.RadioKelime.AutoSize = true;
            this.RadioKelime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RadioKelime.ForeColor = System.Drawing.Color.White;
            this.RadioKelime.Location = new System.Drawing.Point(68, 6);
            this.RadioKelime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RadioKelime.Name = "RadioKelime";
            this.RadioKelime.Size = new System.Drawing.Size(110, 25);
            this.RadioKelime.TabIndex = 0;
            this.RadioKelime.TabStop = true;
            this.RadioKelime.Text = "Kelime Seç";
            this.RadioKelime.UseVisualStyleBackColor = true;
            this.RadioKelime.CheckedChanged += new System.EventHandler(this.RadioKelime_CheckedChanged);
            // 
            // YöneticiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QandA_Wordyy_v1._0.Properties.Resources._55;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(442, 207);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GroupKelime);
            this.Controls.Add(this.PicKapat);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "YöneticiPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.YöneticiPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicKapat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GroupKelime.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicKapat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox GroupKelime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RadioKelime;
        private System.Windows.Forms.RadioButton RadioÇalışma;
        private System.Windows.Forms.ToolStripMenuItem kelimeSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışmaSayısıBelirleToolStripMenuItem;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox CheckedTekrar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}

