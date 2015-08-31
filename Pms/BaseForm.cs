using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Pms
{
   public class BaseForm:Form
    {
       public bool IsPay { get; set; }
       HotKey h = new HotKey();
        public void CallBack()
        {
            bool isMax = this.WindowState == FormWindowState.Maximized;
            if (isMax)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }


        }
        protected override void WndProc(ref Message m)
        {
            //窗口消息处理函数
            h.ProcessHotKey(m);
            base.WndProc(ref m);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "BaseForm";
            this.ResumeLayout(false);

        }

       protected void RigisterKey()
       {
            h.Regist(this.Handle, 0, Keys.F11, CallBack);
       }
       
      
    }
}
