Enter file contents here

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication4
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
           MessageBox.Show("记住我 我是16班周准")
            InitializeComponent();
        }


        private void btBegin_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\windows\\system32\\shutdown.exe", "-s -t 500");
            timer1.Enabled = true;
            txtSec.Enabled = false;
            txtMin.Enabled = false;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int iMin,iSec;
            if (txtSec.Text == "0")
            {
                if (txtMin.Text == "0")
                {
                    timer1.Enabled = false;
                    MessageBox.Show("时间到！");
                    
                    txtMin.Enabled = true;
                    txtSec.Enabled = true;
                }
                else
                {
                    iMin = int.Parse(txtMin.Text);
                    iMin--;
                    txtMin.Text = iMin.ToString();
                    iSec = 59;
                    txtSec.Text = iSec.ToString();
                }
            }
            else
            {
                iSec = int.Parse(txtSec.Text);
                iSec--;
                txtSec.Text = iSec.ToString();
            }
        }

        private void btButton_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\windows\\system32\\shutdown.exe", "-s -t 0");
        }



        
    }
}
