namespace Pms
{
    partial class FrmQuery
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.lbl_CustormName = new System.Windows.Forms.Label();
            this.lbl_cardNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "卡号：";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(130, 17);
            this.txtCardNo.MaxLength = 20;
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.PasswordChar = '*';
            this.txtCardNo.Size = new System.Drawing.Size(164, 21);
            this.txtCardNo.TabIndex = 0;
            this.txtCardNo.UseSystemPasswordChar = true;
            this.txtCardNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardNo_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtCardNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "储值卡查询";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Amount);
            this.groupBox2.Controls.Add(this.lbl_CustormName);
            this.groupBox2.Controls.Add(this.lbl_cardNo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(31, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 112);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "卡信息";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(97, 89);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(0, 12);
            this.lbl_Amount.TabIndex = 12;
            // 
            // lbl_CustormName
            // 
            this.lbl_CustormName.AutoSize = true;
            this.lbl_CustormName.Location = new System.Drawing.Point(99, 60);
            this.lbl_CustormName.Name = "lbl_CustormName";
            this.lbl_CustormName.Size = new System.Drawing.Size(0, 12);
            this.lbl_CustormName.TabIndex = 14;
            // 
            // lbl_cardNo
            // 
            this.lbl_cardNo.AutoSize = true;
            this.lbl_cardNo.Location = new System.Drawing.Point(99, 31);
            this.lbl_cardNo.Name = "lbl_cardNo";
            this.lbl_cardNo.Size = new System.Drawing.Size(0, 12);
            this.lbl_cardNo.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "余额:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "持卡人：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "卡号：";
            // 
            // FrmQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 280);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "FrmQuery";
            this.Text = "储值卡查询";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Label lbl_CustormName;
        private System.Windows.Forms.Label lbl_cardNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}