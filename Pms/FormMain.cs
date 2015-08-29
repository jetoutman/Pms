using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frmQuery=new Form1();
            
            frmQuery.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           /* Form2 frmPay=new Form2();
            frmPay.Show();*/
            FrmPay frmPay=new FrmPay();
            
            frmPay.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frmNavPay=new Form3();
            frmNavPay.Show();
        }
    }
}
