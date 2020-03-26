namespace QandA_Wordyy_v1._0
{
    partial class İngilizce
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
            this.Textİngilizce = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextTürkçe = new System.Windows.Forms.TextBox();
            this.LabelDurum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Textİngilizce
            // 
            this.Textİngilizce.BackColor = System.Drawing.Color.White;
            this.Textİngilizce.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Textİngilizce.Enabled = false;
            this.Textİngilizce.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Textİngilizce.ForeColor = System.Drawing.Color.Black;
            this.Textİngilizce.Location = new System.Drawing.Point(1, 38);
            this.Textİngilizce.Multiline = true;
            this.Textİngilizce.Name = "Textİngilizce";
            this.Textİngilizce.ReadOnly = true;
            this.Textİngilizce.Size = new System.Drawing.Size(267, 80);
            this.Textİngilizce.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QandA_Wordyy_v1._0.Properties.Resources._27_SolOk;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TextTürkçe
            // 
            this.TextTürkçe.BackColor = System.Drawing.Color.White;
            this.TextTürkçe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextTürkçe.Enabled = false;
            this.TextTürkçe.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextTürkçe.ForeColor = System.Drawing.Color.Black;
            this.TextTürkçe.Location = new System.Drawing.Point(274, 38);
            this.TextTürkçe.Multiline = true;
            this.TextTürkçe.Name = "TextTürkçe";
            this.TextTürkçe.ReadOnly = true;
            this.TextTürkçe.Size = new System.Drawing.Size(267, 80);
            this.TextTürkçe.TabIndex = 6;
            // 
            // LabelDurum
            // 
            this.LabelDurum.AutoSize = true;
            this.LabelDurum.BackColor = System.Drawing.Color.Transparent;
            this.LabelDurum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelDurum.ForeColor = System.Drawing.Color.White;
            this.LabelDurum.Location = new System.Drawing.Point(47, 9);
            this.LabelDurum.Name = "LabelDurum";
            this.LabelDurum.Size = new System.Drawing.Size(57, 21);
            this.LabelDurum.TabIndex = 7;
            this.LabelDurum.Text = "label1";
            this.LabelDurum.Visible = false;
            // 
            // İngilizce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QandA_Wordyy_v1._0.Properties.Resources.artleo_com_8156;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(543, 120);
            this.Controls.Add(this.LabelDurum);
            this.Controls.Add(this.TextTürkçe);
            this.Controls.Add(this.Textİngilizce);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "İngilizce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "İngilizce";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Textİngilizce;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox TextTürkçe;
        public System.Windows.Forms.Label LabelDurum;


    }
}