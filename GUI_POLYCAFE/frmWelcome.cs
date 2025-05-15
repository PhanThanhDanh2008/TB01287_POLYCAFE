using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_POLYCAFE
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 30;
            Task.Delay(3000).ContinueWith(t =>
            {
                this.Invoke(new Action(() =>
                {
                    progressBar.Style = ProgressBarStyle.Blocks;
                    progressBar.MarqueeAnimationSpeed = 0;
                    this.Hide();
                    frmLogin loginForm = new frmLogin();
                    loginForm.ShowDialog();
                    this.Close();
                }));
            });
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void frmWelcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Prevent the form from closing
            }
        }
    }
}
