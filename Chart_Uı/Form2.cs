using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Chart_Uı
{
    public partial class Form2 : Form
    {
        Random random = new Random();
        int timeleft = 30;

        public Form2()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Tick += btnStart_Click;
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timeleft--;
            lblTime.Text = "Süre: " + timeleft + " saniye";

            aProgress.Value = Math.Min(aProgress.Value + random.Next(1, 5), 100);
            bProgress.Value = Math.Min(bProgress.Value + random.Next(1, 5), 100);
            cProgress.Value = Math.Min(cProgress.Value + random.Next(1, 5), 100);

            if (timeleft <= 0)
            {
                timer1.Stop();
                DetermineWinner();
            }
            timer1.Start();
        }

        private void DetermineWinner()
        {
            int aScore = aProgress.Value;
            int bScore = bProgress.Value;
            int cScore = cProgress.Value;

            string winner;
            if (aScore > bScore && aScore > cScore)
                winner = "A Takımı Kazandı!";
            else if (bScore > aScore && bScore > cScore)
                winner = "B Takımı Kazandı!";
            else if (cScore > aScore && cScore > bScore)
                winner = "C Takımı Kazandı!";
            else
                winner = "Berabere!";

            MessageBox.Show(winner, "Yarışma Sonucu");
        }
    }
}
