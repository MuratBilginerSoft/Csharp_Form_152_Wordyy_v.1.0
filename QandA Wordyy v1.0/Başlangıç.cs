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
    public partial class Başlangıç : Form
    {
        int zaman1 = 0;
        YöneticiPanel YPForm = new YöneticiPanel();

        public Başlangıç()
        {
            InitializeComponent();
        }

        private void TimerSüre_Tick(object sender, EventArgs e)
        {
            if (zaman1 < 10)
            {
                zaman1++;
                
            }

            else
            {
                TimerSüre.Stop();
                this.Close();

            }
        }

        private void Başlangıç_Load(object sender, EventArgs e)
        {
            TimerSüre.Start();
        }
    }
}
