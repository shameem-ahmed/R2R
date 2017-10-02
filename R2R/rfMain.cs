using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

using R2R.Controls.Web;
using R2R.Controls.Logic;

namespace R2R
{
    public partial class rfMain : Telerik.WinControls.UI.RadForm
    {
        bool isDragStart = false;
        Point mouseLoc;

        RadTreeNode crNode;

        public rfMain()
        {
            InitializeComponent();
        }

        private void rbeNw_Click(object sender, EventArgs e)
        {
            int count = rdMain.DockWindows.Count;
            count++;
            Telerik.WinControls.UI.Docking.ToolWindow twNew = new Telerik.WinControls.UI.Docking.ToolWindow("Untitled - " + count);
            twNew.MouseClick += new MouseEventHandler(twNew_MouseClick);

            twNew.BackColor = Color.White;
            twNew.AutoScroll = true;

            rdMain.AddDocument(twNew);

            rdMain.ActiveWindow = twNew;

        }

        private void twNew_MouseClick(object sender, MouseEventArgs e)
        {
            if (crNode == null)
            {
                return;
            }

            Telerik.WinControls.UI.Docking.DockWindow crWindow = rdMain.ActiveWindow;

            if (crNode.Tag.ToString() == "Web.HPLogin")
            {
                HPLogin c1 = new HPLogin();

                c1.Location = new Point(e.X - (c1.Width / 2), e.Y - (c1.Height / 2));

                c1.Click += new EventHandler(Web_HPLogin_Click);

                c1.MouseDown += new MouseEventHandler(Control_MouseDown);
                c1.MouseMove += new MouseEventHandler(Control_MouseMove);
                c1.MouseUp += new MouseEventHandler(Control_MouseUp);

                c1.DeleteControl += new KeyEventHandler(Control_DeleteControl);

                crWindow.Controls.Add(c1);

            }
            else if (crNode.Tag.ToString() == "Logic.If")
            {
                LogicIf if1 = new LogicIf();

                if1.Location = new Point(e.X - (if1.Width / 2), e.Y - (if1.Height / 2));

                if1.Click += new EventHandler(Logic_If_Click);

                if1.MouseDown += new MouseEventHandler(Control_MouseDown);
                if1.MouseMove += new MouseEventHandler(Control_MouseMove);
                if1.MouseUp += new MouseEventHandler(Control_MouseUp);

                if1.DeleteControl += new KeyEventHandler(Control_DeleteControl);

                crWindow.Controls.Add(if1);
            }
        }

        private void rtvComponents_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {
            crNode = e.Node;
        }

        private void Web_HPLogin_Click(object sender, EventArgs e)
        {
            HPLoginProp p1 = new HPLoginProp();
            p1.HPLogin = (HPLogin)sender;
            p1.Dock = DockStyle.Fill;
            dwProp.Controls.Clear();
            dwProp.Controls.Add(p1);
        }

        
        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            isDragStart = true;
            mouseLoc = e.Location;
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragStart)
            {
                Control ctrl = (Control)sender;
                ctrl.Left = e.X + ctrl.Left - mouseLoc.X;
                ctrl.Top = e.Y + ctrl.Top - mouseLoc.Y;
            }
        }

        private void Control_MouseUp(object sender, MouseEventArgs e)
        {
            isDragStart = false;
        }

        private void Control_DeleteControl(object sender, KeyEventArgs e)
        {
            Control ctrl = (Control)sender;
            Control parent = (Control)ctrl.Parent;

            bool endless = true;

            while(endless)
            {

                if (parent.GetType().ToString() == "Telerik.WinControls.UI.Docking.ToolWindow")
                {
                    parent.Controls.Remove(ctrl);
                    endless = false;
                }
                else
                {
                    ctrl = parent;
                    parent = parent.Parent;
                }
            }
        }

        private void Logic_If_Click(object sender, EventArgs e)
        {
            LogicIfProp p1 = new LogicIfProp();
            p1.LogicIf = (LogicIf)sender;
            p1.Dock = DockStyle.Fill;
            dwProp.Controls.Clear();
            dwProp.Controls.Add(p1);
        }


    }
}
