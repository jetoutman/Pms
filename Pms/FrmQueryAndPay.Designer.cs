﻿namespace Pms
{
    partial class FrmQueryAndPay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPayValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_MonthBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_msg = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.lbl_cardNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPayValue);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(28, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "储值卡支付";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "提示：输入消费金额后按回车";
            // 
            // txtPayValue
            // 
            this.txtPayValue.AcceptsTab = true;
            this.txtPayValue.Location = new System.Drawing.Point(119, 20);
            this.txtPayValue.MaxLength = 13;
            this.txtPayValue.Name = "txtPayValue";
            this.txtPayValue.Size = new System.Drawing.Size(164, 21);
            this.txtPayValue.TabIndex = 0;
            this.txtPayValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPayValue_KeyDown);
            this.txtPayValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayValue_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "消费金额:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtCardNo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(30, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 231);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "储值卡查询";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_MonthBalance);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Lbl_msg);
            this.groupBox3.Controls.Add(this.lbl_Amount);
            this.groupBox3.Controls.Add(this.lbl_cardNo);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(31, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 144);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "卡信息";
            // 
            // lbl_MonthBalance
            // 
            this.lbl_MonthBalance.AutoSize = true;
            this.lbl_MonthBalance.Location = new System.Drawing.Point(97, 115);
            this.lbl_MonthBalance.Name = "lbl_MonthBalance";
            this.lbl_MonthBalance.Size = new System.Drawing.Size(0, 12);
            this.lbl_MonthBalance.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "月度余额：";
            // 
            // Lbl_msg
            // 
            this.Lbl_msg.AutoSize = true;
            this.Lbl_msg.Location = new System.Drawing.Point(97, 31);
            this.Lbl_msg.Name = "Lbl_msg";
            this.Lbl_msg.Size = new System.Drawing.Size(0, 12);
            this.Lbl_msg.TabIndex = 9;
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(97, 89);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(0, 12);
            this.lbl_Amount.TabIndex = 12;
            // 
            // lbl_cardNo
            // 
            this.lbl_cardNo.AutoSize = true;
            this.lbl_cardNo.Location = new System.Drawing.Point(97, 60);
            this.lbl_cardNo.Name = "lbl_cardNo";
            this.lbl_cardNo.Size = new System.Drawing.Size(0, 12);
            this.lbl_cardNo.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "余额：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "卡号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "查询结果：";
            // 
            // txtCardNo
            // 
            this.txtCardNo.AcceptsTab = true;
            this.txtCardNo.Location = new System.Drawing.Point(113, 17);
            this.txtCardNo.MaxLength = 100;
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.PasswordChar = '*';
            this.txtCardNo.Size = new System.Drawing.Size(200, 21);
            this.txtCardNo.TabIndex = 0;
            this.txtCardNo.UseSystemPasswordChar = true;
            this.txtCardNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardNo_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "卡号：";
            // 
            // FrmQueryAndPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 417);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmQueryAndPay";
            this.Text = "储值卡支付";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPayValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_MonthBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lbl_msg;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Label lbl_cardNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label label7;
    }
}