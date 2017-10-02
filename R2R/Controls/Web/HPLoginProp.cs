using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R2R.Controls.Web
{
    public partial class HPLoginProp : UserControl
    {
        private string sUrl;
        private string sUser;
        private string sPwd;

        private HPLogin hpLogin;

        public HPLoginProp()
        {
            InitializeComponent();
        }

        public string Url
        {
            get
            {
                return sUrl;
            }
            set
            {
                sUrl = value;
                Invalidate();
            }
        }

        public string User
        {
            get
            {
                return sUser;
            }
            set
            {
                sUser = value;
                Invalidate();
            }
        }

        public string Password
        {
            get
            {
                return sPwd;
            }
            set
            {
                sPwd = value;
                Invalidate();
            }
        }

        public HPLogin HPLogin
        {
            get
            {
                return hpLogin;
            }
            set
            {
                hpLogin = value;

                txtUrl.Text = sUrl = value.Url;
                txtUser.Text = sUser = value.User;
                txtPwd.Text = sPwd = value.Password;

                Invalidate();
            }
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            HPLogin.Url = sUrl = txtUrl.Text;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            HPLogin.User = sUser = txtUser.Text;
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            HPLogin.Password = sPwd = txtPwd.Text;
        }
    }
}
