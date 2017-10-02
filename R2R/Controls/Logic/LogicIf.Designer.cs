namespace R2R.Controls.Logic
{
    partial class LogicIf
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblVal2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOpt = new System.Windows.Forms.Label();
            this.lblVal1 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlFirst = new System.Windows.Forms.Panel();
            this.pnlFalse = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlTrue = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.line01 = new System.Windows.Forms.Label();
            this.line03 = new System.Windows.Forms.Label();
            this.line02 = new System.Windows.Forms.Label();
            this.line04 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlFirst.SuspendLayout();
            this.pnlFalse.SuspendLayout();
            this.pnlTrue.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.lblVal2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.lblOpt);
            this.pnlMain.Controls.Add(this.lblVal1);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(1, 1);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(198, 102);
            this.pnlMain.TabIndex = 3;
            this.pnlMain.Click += new System.EventHandler(this.pnlMain_Click);
            this.pnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseDown);
            this.pnlMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseMove);
            this.pnlMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseUp);
            // 
            // lblVal2
            // 
            this.lblVal2.AutoSize = true;
            this.lblVal2.ForeColor = System.Drawing.Color.Blue;
            this.lblVal2.Location = new System.Drawing.Point(14, 77);
            this.lblVal2.Name = "lblVal2";
            this.lblVal2.Size = new System.Drawing.Size(46, 13);
            this.lblVal2.TabIndex = 7;
            this.lblVal2.Text = "Value 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Condition";
            // 
            // lblOpt
            // 
            this.lblOpt.AutoSize = true;
            this.lblOpt.ForeColor = System.Drawing.Color.Blue;
            this.lblOpt.Location = new System.Drawing.Point(14, 61);
            this.lblOpt.Name = "lblOpt";
            this.lblOpt.Size = new System.Drawing.Size(51, 13);
            this.lblOpt.TabIndex = 5;
            this.lblOpt.Text = "Operator:";
            // 
            // lblVal1
            // 
            this.lblVal1.AutoSize = true;
            this.lblVal1.ForeColor = System.Drawing.Color.Blue;
            this.lblVal1.Location = new System.Drawing.Point(14, 45);
            this.lblVal1.Name = "lblVal1";
            this.lblVal1.Size = new System.Drawing.Size(46, 13);
            this.lblVal1.TabIndex = 4;
            this.lblVal1.Text = "Value 1:";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlHeader.Controls.Add(this.txtTitle);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(5);
            this.pnlHeader.Size = new System.Drawing.Size(198, 26);
            this.pnlHeader.TabIndex = 3;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTitle.Location = new System.Drawing.Point(21, 5);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(172, 16);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.Text = "If";
            this.txtTitle.Enter += new System.EventHandler(this.txtTitle_Enter);
            this.txtTitle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTitle_KeyUp);
            this.txtTitle.Leave += new System.EventHandler(this.txtTitle_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::R2R.Properties.Resources.if01;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlFirst
            // 
            this.pnlFirst.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlFirst.Controls.Add(this.pnlMain);
            this.pnlFirst.Location = new System.Drawing.Point(52, 3);
            this.pnlFirst.Name = "pnlFirst";
            this.pnlFirst.Padding = new System.Windows.Forms.Padding(1);
            this.pnlFirst.Size = new System.Drawing.Size(200, 104);
            this.pnlFirst.TabIndex = 5;
            // 
            // pnlFalse
            // 
            this.pnlFalse.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlFalse.Controls.Add(this.label12);
            this.pnlFalse.Location = new System.Drawing.Point(202, 158);
            this.pnlFalse.Name = "pnlFalse";
            this.pnlFalse.Padding = new System.Windows.Forms.Padding(1);
            this.pnlFalse.Size = new System.Drawing.Size(100, 28);
            this.pnlFalse.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 26);
            this.label12.TabIndex = 7;
            this.label12.Text = "False";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTrue
            // 
            this.pnlTrue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlTrue.Controls.Add(this.label3);
            this.pnlTrue.Location = new System.Drawing.Point(2, 158);
            this.pnlTrue.Name = "pnlTrue";
            this.pnlTrue.Padding = new System.Windows.Forms.Padding(1);
            this.pnlTrue.Size = new System.Drawing.Size(100, 28);
            this.pnlTrue.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "True";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // line01
            // 
            this.line01.BackColor = System.Drawing.SystemColors.ControlDark;
            this.line01.ForeColor = System.Drawing.Color.Blue;
            this.line01.Location = new System.Drawing.Point(151, 99);
            this.line01.Name = "line01";
            this.line01.Size = new System.Drawing.Size(2, 30);
            this.line01.TabIndex = 10;
            // 
            // line03
            // 
            this.line03.BackColor = System.Drawing.SystemColors.ControlDark;
            this.line03.ForeColor = System.Drawing.Color.Blue;
            this.line03.Location = new System.Drawing.Point(52, 128);
            this.line03.Name = "line03";
            this.line03.Size = new System.Drawing.Size(200, 2);
            this.line03.TabIndex = 11;
            // 
            // line02
            // 
            this.line02.BackColor = System.Drawing.SystemColors.ControlDark;
            this.line02.ForeColor = System.Drawing.Color.Blue;
            this.line02.Location = new System.Drawing.Point(50, 128);
            this.line02.Name = "line02";
            this.line02.Size = new System.Drawing.Size(2, 30);
            this.line02.TabIndex = 12;
            // 
            // line04
            // 
            this.line04.BackColor = System.Drawing.SystemColors.ControlDark;
            this.line04.ForeColor = System.Drawing.Color.Blue;
            this.line04.Location = new System.Drawing.Point(250, 130);
            this.line04.Name = "line04";
            this.line04.Size = new System.Drawing.Size(2, 30);
            this.line04.TabIndex = 13;
            // 
            // LogicIf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlTrue);
            this.Controls.Add(this.pnlFalse);
            this.Controls.Add(this.pnlFirst);
            this.Controls.Add(this.line04);
            this.Controls.Add(this.line02);
            this.Controls.Add(this.line01);
            this.Controls.Add(this.line03);
            this.Name = "LogicIf";
            this.Size = new System.Drawing.Size(306, 192);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlFirst.ResumeLayout(false);
            this.pnlFalse.ResumeLayout(false);
            this.pnlTrue.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOpt;
        private System.Windows.Forms.Label lblVal1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlFirst;
        private System.Windows.Forms.Label lblVal2;
        private System.Windows.Forms.Panel pnlFalse;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlTrue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label line01;
        private System.Windows.Forms.Label line03;
        private System.Windows.Forms.Label line02;
        private System.Windows.Forms.Label line04;
    }
}
