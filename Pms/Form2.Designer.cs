namespace Pms
{
    partial class Form2
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
            this.txtCashierId = new System.Windows.Forms.TextBox();
            this.txtPosId = new System.Windows.Forms.TextBox();
            this.txtShopId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtPayValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCdseq = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCdseq);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtOwner);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPayValue);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCashierId);
            this.groupBox1.Controls.Add(this.txtPosId);
            this.groupBox1.Controls.Add(this.txtShopId);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCardNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(9, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 209);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "储值卡支付";
            // 
            // txtCashierId
            // 
            this.txtCashierId.Location = new System.Drawing.Point(171, 98);
            this.txtCashierId.MaxLength = 5;
            this.txtCashierId.Name = "txtCashierId";
            this.txtCashierId.Size = new System.Drawing.Size(164, 21);
            this.txtCashierId.TabIndex = 11;
            // 
            // txtPosId
            // 
            this.txtPosId.Location = new System.Drawing.Point(427, 56);
            this.txtPosId.MaxLength = 5;
            this.txtPosId.Name = "txtPosId";
            this.txtPosId.Size = new System.Drawing.Size(164, 21);
            this.txtPosId.TabIndex = 10;
            // 
            // txtShopId
            // 
            this.txtShopId.Location = new System.Drawing.Point(171, 56);
            this.txtShopId.MaxLength = 5;
            this.txtShopId.Name = "txtShopId";
            this.txtShopId.Size = new System.Drawing.Size(164, 21);
            this.txtShopId.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(429, 17);
            this.txtPassword.MaxLength = 9;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(164, 21);
            this.txtPassword.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码：";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(171, 17);
            this.txtCardNo.MaxLength = 20;
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(164, 21);
            this.txtCardNo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "卡号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "收银员ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "店号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "POS机号";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 299);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(617, 106);
            this.textBox1.TabIndex = 10;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(180, 260);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(189, 23);
            this.btnPay.TabIndex = 9;
            this.btnPay.Text = "支付";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPayValue
            // 
            this.txtPayValue.Location = new System.Drawing.Point(428, 94);
            this.txtPayValue.MaxLength = 5;
            this.txtPayValue.Name = "txtPayValue";
            this.txtPayValue.Size = new System.Drawing.Size(164, 21);
            this.txtPayValue.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "支付金额:";
            // 
            // txtCdseq
            // 
            this.txtCdseq.Location = new System.Drawing.Point(171, 171);
            this.txtCdseq.MaxLength = 5;
            this.txtCdseq.Name = "txtCdseq";
            this.txtCdseq.Size = new System.Drawing.Size(164, 21);
            this.txtCdseq.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "储值卡支付流水号（数字）:";
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(171, 129);
            this.txtOwner.MaxLength = 5;
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(164, 21);
            this.txtOwner.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "交易流水号(数字):";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 472);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPay);
            this.Name = "Form2";
            this.Text = "储值卡支付";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCashierId;
        private System.Windows.Forms.TextBox txtPosId;
        private System.Windows.Forms.TextBox txtShopId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtCdseq;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPayValue;
        private System.Windows.Forms.Label label6;
    }
}