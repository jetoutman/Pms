using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pms
{
   
    public partial class FrmLogin :BaseForm
    {
        private static string UserName = ConfigeHelper.GetConfigString("LoginName");

        private static string UserPwd = ConfigeHelper.GetConfigString("LoginPwd");
        public FrmLogin()
        {
            InitializeComponent();
            RigisterKey();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //如果输入的是回车键
            {
                Login();
            }
         
        }

        private void Login()
        {
            string userName = txtLoginName.Text.Trim();
            string pwd = txtPwd.Text.Trim();
            if (userName == UserName && pwd == UserPwd)
            {

                this.DialogResult = DialogResult.OK;
                this.Close();
              
            }
            else
            {
                MessageBox.Show("用户名或密码错误，请重新输入！");
                txtPwd.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Activated(object sender, EventArgs e)
        {
          
        }

      

        private void FrmLogin_Load(object sender, EventArgs e)
        {
           
        }
    }
}
