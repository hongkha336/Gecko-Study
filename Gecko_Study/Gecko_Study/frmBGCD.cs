
using System.Threading;
using System.Windows.Forms;
using Gecko;
namespace Gecko_Study
{
    public partial class frmBGCD : Form
    {
        private string strLink;
        
        public frmBGCD(string link)
        {
            InitializeComponent();
            Gecko.Xpcom.Initialize(Application.StartupPath + "\\xulrunner");
            geckoWeb.NoDefaultContextMenu = true ;
            strLink = link;
            geckoWeb.Hide();

            
        }

        private void frmBGCD_Load(object sender, System.EventArgs e)
        {
            label1.Left = this.Width / 2 - label1.Width / 2;
            label1.Top = this.Height / 2 - label1.Height / 2;
            pictureBox1.Left = this.Width / 2 - pictureBox1.Width / 2;
            pictureBox1.Top = this.Height / 2 - label1.Height - pictureBox1.Height;
            timer1.Start();
            geckoWeb.Navigate(strLink);
     
          
        }
        int x = 0;
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            x++;
            if (x == 22)

            {
                timer1.Stop();
                geckoWeb.Show();
            }
             
        }
    }
}
