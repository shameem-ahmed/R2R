using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace R2R
{
    public partial class rfMain : Telerik.WinControls.UI.RadForm
    {
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

            RadLabel lbl1 = new RadLabel();
            lbl1.BackColor = Color.FromArgb(255, 255, 192);
            lbl1.BorderVisible = true;


            lbl1.Location = new Point(e.X-75, e.Y-25);

            lbl1.AutoSize = false;
            lbl1.Size = new Size(150, 50);
            lbl1.Text= crNode.Text;
            lbl1.TextAlignment = ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(lbl1.GetChildAt(0).GetChildAt(1))).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(lbl1.GetChildAt(0).GetChildAt(1))).BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(lbl1.GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            lbl1.Click += new EventHandler(lbl1_Click);

            //twNew.MouseClick += new MouseEventHandler(twNew_MouseClick);

            //Label lbl1 = new Label();
            //lbl1.Text = crNode.Text;
            //lbl1.Location = new Point(e.X, e.Y);
            //lbl1.AutoSize = true;

            //HPWebLogin log1 = new HPWebLogin();
            //hwl1.Location = new Point(e.X, e.Y);

            crWindow.Controls.Add(lbl1);

        }

        private void rtvComponents_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {
            crNode = e.Node;
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hi");

            rpgComponent.SelectedObject = sender;
        }
    }
}
