using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTF___Capture_the_File
{
    public partial class ManFrame : Form
    {
        public ManFrame()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fbd = new FolderBrowserDialog() {Description="Select your path" })
            {
                if(fbd.ShowDialog()==DialogResult.OK)
                {
                    browser.Url = new Uri(fbd.SelectedPath);
                    txt_path.Text = fbd.SelectedPath;
                    //txt_path.ForeColor = System.Drawing.Color.FromArgb(18, 45, 86);

                }
                    
                
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (browser.CanGoBack)
                browser.GoBack();
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            if (browser.CanGoForward)
                browser.GoForward();
        }
    }
}
