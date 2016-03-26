using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Google.Authenticator;
using System.Net;
using System.IO;

namespace GoogleTwoFactorAuthenticator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnValidatePIN_Click(object sender, EventArgs e)
        {
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            //google 30 S 
            //不设置 默认5分钟
            //PIN多少时间内有效
            tfa.DefaultClockDriftTolerance = TimeSpan.FromSeconds(40);

            var value1 = tfa.ValidateTwoFactorPIN(txtSecretKey.Text, txtPINValue.Text, tfa.DefaultClockDriftTolerance);

            var value = tfa.ValidateTwoFactorPIN(txtSecretKey.Text, txtPINValue.Text);

            MessageBox.Show(value ? "Success" : "Fail");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();

            string secreKey = Guid.NewGuid().ToString("N");

            var setupCode = tfa.GenerateSetupCode(txtAppName.Text.Trim(), txtAccount.Text.Trim(), secreKey, 128, 128);

            if (setupCode != null)
            {
                txtSecretKey.Text = setupCode.AccountSecretKey;
                txtManualEntryKey.Text = setupCode.ManualEntryKey;
                txtQRUrl.Text = setupCode.QrCodeSetupImageUrl;

                WebClient wc = new WebClient();
                MemoryStream ms = new MemoryStream(wc.DownloadData(setupCode.QrCodeSetupImageUrl));
                this.pbQR.Image = Image.FromStream(ms);
                txtCorrectPIN.Text = tfa.GetCurrentPIN(setupCode.AccountSecretKey);
            }
        }
    }
}
