using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevDeneme
{
    public partial class welcomeWindow : Form
    {

        int second = 0; 

        public welcomeWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            sayacForumAcilis.Interval = 1000;
            sayacForumAcilis.Start();

        }

        private void sporcuPenWindow()
        {
            sporcuPenWindow sporcuPen = new sporcuPenWindow();
            sporcuPen.Show();

        }

        private void sayacForumAcilis_Tick(object sender, EventArgs e)
        {
            try
            {
                second = second + 1;
                if (second > 3)
                {
                    sayacForumAcilis.Stop();
                    sporcuPenWindow();
                    Hide();
                }
            }

            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
    }
}
