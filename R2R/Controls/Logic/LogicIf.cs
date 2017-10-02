using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R2R.Controls.Logic
{
    public partial class LogicIf : UserControl
    {

        private string sValue1;
        private int nOperator;
        private string sValue2;

        //public enum LogicOperator { Equal, NotEqual, GreaterThan, LessThan, GreaterThanEqual, LessThanEqual };

        public LogicIf()
        {
            InitializeComponent();
            txtTitle.Text = this.Name;

            //this.BackColor = Color.Transparent;
            //this.BackColor = Color.LimeGreen;

        }

        private void txtTitle_Leave(object sender, EventArgs e)
        {
            pnlFirst.BackColor = pnlHeader.BackColor = txtTitle.BackColor = SystemColors.ControlDark;
            line01.BackColor = line02.BackColor = line03.BackColor = line04.BackColor = SystemColors.ControlDark;
            pnlTrue.BackColor = pnlFalse.BackColor = SystemColors.ControlDark;
        }

        private void txtTitle_Enter(object sender, EventArgs e)
        {
            pnlFirst.BackColor = pnlHeader.BackColor = txtTitle.BackColor = Color.FromArgb(255, 128, 0);
            line01.BackColor = line02.BackColor = line03.BackColor = line04.BackColor = Color.FromArgb(255, 128, 0);
            pnlTrue.BackColor = pnlFalse.BackColor = Color.FromArgb(255, 128, 0);

        }

        private void pnlMain_Click(object sender, EventArgs e)
        {
            txtTitle.Focus();
            this.OnClick(new EventArgs());
        }

        private void pnlMain_MouseDown(object sender, MouseEventArgs e)
        {
            txtTitle.Focus();
            this.OnMouseDown(e);
        }

        private void pnlMain_MouseMove(object sender, MouseEventArgs e)
        {
            txtTitle.Focus();
            this.OnMouseMove(e);
        }

        private void pnlMain_MouseUp(object sender, MouseEventArgs e)
        {
            txtTitle.Focus();
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
        public string Value1
        {
            get
            {
                return sValue1;
            }
            set
            {
                sValue1 = value;

                lblVal1.Text = "Value 1: " + sValue1;

                Invalidate();
            }
        }

        public string Value2
        {
            get
            {
                return sValue2;
            }
            set
            {
                sValue2 = value;

                lblVal2.Text = "Value 2: " + sValue2;

                Invalidate();
            }
        }

        public int Operator
        {
            get
            {
                return nOperator;
            }
            set
            {
                nOperator = value;

                if (nOperator == 0)
                {
                    lblOpt.Text = "Operator: Equal [ = ]";
                }
                else if (nOperator == 1)
                {
                    lblOpt.Text = "Operator: NotEqual [ != ]";
                }
                else if (nOperator == 2)
                {
                    lblOpt.Text = "Operator: GreaterThan [ > ]";
                }
                else if (nOperator == 3)
                {
                    lblOpt.Text = "Operator: LessThan [ < ]";
                }
                else if (nOperator == 4)
                {
                    lblOpt.Text = "Operator: GreaterThanEqual [ >= ]";
                }
                else if (nOperator == 5)
                {
                    lblOpt.Text = "Operator: LessThanEqual [ <= ]";
                }

                Invalidate();
            }
        }

        //control events
        public event KeyEventHandler DeleteControl;
    }
}
