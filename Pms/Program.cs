﻿using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace Pms
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*
            FrmLogin frmLogin=new FrmLogin();
            frmLogin.ShowDialog();
            if (frmLogin.DialogResult == DialogResult.OK)
            {
               
            }
             * */
            Application.Run(new FormMain());
        }
    }
}
