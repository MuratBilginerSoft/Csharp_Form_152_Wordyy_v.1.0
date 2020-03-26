namespace QandA_Wordyy_v1._0
{
    partial class Başlangıç
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
            this.TimerSüre = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimerSüre
            // 
            this.TimerSüre.Interval = 300;
            this.TimerSüre.Tick += new System.EventHandler(this.TimerSüre_Tick);
            // 
            // Başlangıç
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QandA_Wordyy_v1._0.Properties.Resources.Başlıksız_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 342);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Başlangıç";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Başlangıç";
            this.Load += new System.EventHandler(this.Başlangıç_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TimerSüre;
    }
}