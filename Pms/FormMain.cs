﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pms
{
    public partial class FormMain : BaseForm
    {
     
      
        public FormMain()
        {
            InitializeComponent();
            RigisterKey();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            FrmQuery frmQuery = new FrmQuery();
            frmQuery.IsPay = false;
            frmQuery.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           /* Form2 frmPay=new Form2();
            frmPay.Show();*/
       
            HotKeySets[FormId] = true;
            FrmPay frmPay=new FrmPay();
            
            frmPay.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frmNavPay=new Form3();
            frmNavPay.Show();
        }

      

       

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            UnRigisterKey();
        }
       

       
      
    }
}
