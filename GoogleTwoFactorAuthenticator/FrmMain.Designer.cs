namespace GoogleTwoFactorAuthenticator
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPINValue = new System.Windows.Forms.TextBox();
            this.btnValidatePIN = new System.Windows.Forms.Button();
            this.pbQR = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtManualEntryKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorrectPIN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQRUrl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(103, 223);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "创建";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "应用程序名称：";
            // 
            // txtAppName
            // 
            this.txtAppName.Location = new System.Drawing.Point(103, 9);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(260, 21);
            this.txtAppName.TabIndex = 2;
            this.txtAppName.Text = "程序名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名：";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(103, 39);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(260, 21);
            this.txtAccount.TabIndex = 2;
            this.txtAccount.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "密钥：";
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.Location = new System.Drawing.Point(103, 66);
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.ReadOnly = true;
            this.txtSecretKey.Size = new System.Drawing.Size(260, 21);
            this.txtSecretKey.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "PIN";
            // 
            // txtPINValue
            // 
            this.txtPINValue.Location = new System.Drawing.Point(103, 252);
            this.txtPINValue.Name = "txtPINValue";
            this.txtPINValue.Size = new System.Drawing.Size(260, 21);
            this.txtPINValue.TabIndex = 2;
            // 
            // btnValidatePIN
            // 
            this.btnValidatePIN.Location = new System.Drawing.Point(118, 279);
            this.btnValidatePIN.Name = "btnValidatePIN";
            this.btnValidatePIN.Size = new System.Drawing.Size(75, 23);
            this.btnValidatePIN.TabIndex = 0;
            this.btnValidatePIN.Text = "验证";
            this.btnValidatePIN.UseVisualStyleBackColor = true;
            this.btnValidatePIN.Click += new System.EventHandler(this.btnValidatePIN_Click);
            // 
            // pbQR
            // 
            this.pbQR.Location = new System.Drawing.Point(369, 9);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(128, 128);
            this.pbQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbQR.TabIndex = 3;
            this.pbQR.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "验证KEY：";
            // 
            // txtManualEntryKey
            // 
            this.txtManualEntryKey.Location = new System.Drawing.Point(103, 95);
            this.txtManualEntryKey.Multiline = true;
            this.txtManualEntryKey.Name = "txtManualEntryKey";
            this.txtManualEntryKey.ReadOnly = true;
            this.txtManualEntryKey.Size = new System.Drawing.Size(260, 42);
            this.txtManualEntryKey.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "验证PIN：";
            // 
            // txtCorrectPIN
            // 
            this.txtCorrectPIN.Location = new System.Drawing.Point(103, 150);
            this.txtCorrectPIN.Name = "txtCorrectPIN";
            this.txtCorrectPIN.ReadOnly = true;
            this.txtCorrectPIN.Size = new System.Drawing.Size(394, 21);
            this.txtCorrectPIN.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "QRURL：";
            // 
            // txtQRUrl
            // 
            this.txtQRUrl.Location = new System.Drawing.Point(103, 177);
            this.txtQRUrl.Multiline = true;
            this.txtQRUrl.Name = "txtQRUrl";
            this.txtQRUrl.ReadOnly = true;
            this.txtQRUrl.Size = new System.Drawing.Size(394, 40);
            this.txtQRUrl.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 309);
            this.Controls.Add(this.pbQR);
            this.Controls.Add(this.txtPINValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtManualEntryKey);
            this.Controls.Add(this.txtQRUrl);
            this.Controls.Add(this.txtCorrectPIN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSecretKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAppName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValidatePIN);
            this.Controls.Add(this.btnCreate);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google二次验证";
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAppName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecretKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPINValue;
        private System.Windows.Forms.Button btnValidatePIN;
        private System.Windows.Forms.PictureBox pbQR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtManualEntryKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorrectPIN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQRUrl;
    }
}

