using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Pms
{
   public class BaseForm:Form
    {
       protected int FormId { get; set; }
       public bool IsPay { get; set; }

       protected static Dictionary<int, bool> HotKeySets = new Dictionary<int, bool>();
      
       HotKey h = new HotKey();
        public void CallBack()
        {
         
            /*
            bool isMin = this.WindowState == FormWindowState.Minimized;
            if (isMin)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                
            }
            */
            System.Environment.Exit(0);

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

        protected void UnRigisterKey()
       {
           h.UnRegist(this.Handle, CallBack);
         
       }

        protected void F11Exit(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11) //如果输入的是回车键
            {
                System.Environment.Exit(0);
            }
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F11:
                    MessageBox.Show("F11");
                    break;
            }
            base.OnKeyDown(e);
        }
    }
}
