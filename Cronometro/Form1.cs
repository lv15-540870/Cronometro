using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronometro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Horas = 0;
        int Min = 0;
        int Seg = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerCronometro.Enabled = true;
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            timerCronometro.Enabled = false;
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            timerCronometro.Enabled = false;
            lblCronometro.Text = "00:00:00";
        }

        private void timerCronometro_Tick(object sender, EventArgs e)
        {
            Seg++;
            if (Seg >= 60)
            {
                Seg = 0;
                Min++;

                if (Min >= 60) 
                {
                    Min = 0;
                    Horas++;
                }
            }
            DateTime cronometro = new DateTime(2025, 1, 1, Horas, Min, Seg);
            lblCronometro.Text = cronometro.ToString("HH:mm:ss");
        }
    }
}
