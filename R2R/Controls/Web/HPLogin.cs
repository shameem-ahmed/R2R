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
    public partial class HPLogin : UserControl
    {

        private string sUrl;
        private string sUser;
        private string sPwd;

        public HPLogin()
        {
            InitializeComponent();
            txtTitle.Text = this.Name;
        }

        private void txtTitle_Leave(object sender, EventArgs e)
        {
            pnlFirst.BackColor = pnlHeader.BackColor = txtTitle.BackColor = SystemColors.ControlDark;
        }

        private void txtTitle_Enter(object sender, EventArgs e)
        {
            pnlFirst.BackColor = pnlHeader.BackColor = txtTitle.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void pnlMain_Click(object sender, EventArgs e)
        {
            txtTitle.Focus();
            this.OnClick(new EventArgs());
        }

        private void pnlMain_MouseDown(object sender, MouseEventArgs e)
        {
            //txtTitle.Focus();
            this.OnMouseDown(e);
        }

        private void pnlMain_MouseMove(object sender, MouseEventArgs e)
        {
            //txtTitle.Focus();
            this.OnMouseMove(e);
        }

        private void pnlMain_MouseUp(object sender, MouseEventArgs e)
        {
            //txtTitle.Focus();
            this.OnMouseUp(e);
        }

        private void txtTitle_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.DeleteControl(sender, e);
            }
        }

        //control properties
        //
        public string Url
        {
            get
            {
                return sUrl;
            }
            set
            {
                sUrl = value;

                lblUrl.Text = "Url: " + sUrl;

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

                lblUser.Text = "User: " + sUser;

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

        //control events
        public event KeyEventHandler DeleteControl;

      
    }
}
