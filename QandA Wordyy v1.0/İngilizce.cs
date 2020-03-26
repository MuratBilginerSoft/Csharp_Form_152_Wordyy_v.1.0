using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QandA_Wordyy_v1._0
{
    public partial class İngilizce : Form
    {
       
        public İngilizce()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            YöneticiPanel YPForm = new YöneticiPanel();
           

            
            this.Close();
            
            YPForm.Show();
            YPForm.timer1.Stop();
        }
    }
}
