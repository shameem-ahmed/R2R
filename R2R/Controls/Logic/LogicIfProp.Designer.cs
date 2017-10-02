namespace R2R.Controls.Logic
{
    partial class LogicIfProp
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.txtVal1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOpt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Value 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Operator";
            // 
            // txtVal2
            // 
            this.txtVal2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVal2.Location = new System.Drawing.Point(66, 55);
            this.txtVal2.MinimumSize = new System.Drawing.Size(50, 4);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.PasswordChar = '*';
            this.txtVal2.Size = new System.Drawing.Size(139, 20);
            this.txtVal2.TabIndex = 9;
            this.txtVal2.TextChanged += new System.EventHandler(this.txtVal2_TextChanged);
            // 
            // txtVal1
            // 
            this.txtVal1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVal1.Location = new System.Drawing.Point(66, 3);
            this.txtVal1.MinimumSize = new System.Drawing.Size(50, 4);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(139, 20);
            this.txtVal1.TabIndex = 7;
            this.txtVal1.TextChanged += new System.EventHandler(this.txtVal1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Value 1";
            // 
            // cbOpt
            // 
            this.cbOpt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOpt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpt.FormattingEnabled = true;
            this.cbOpt.Items.AddRange(new object[] {
            "Equal [ = ]",
            "Not Equal [ != ]",
            "Greater Than [ > ]",
            "Less Than [ < ]",
            "Greater Than Equal [ >= ]",
            "Less Than Equal [ <= ]"});
            this.cbOpt.Location = new System.Drawing.Point(66, 29);
            this.cbOpt.Name = "cbOpt";
            this.cbOpt.Size = new System.Drawing.Size(139, 21);
            this.cbOpt.TabIndex = 12;
            this.cbOpt.SelectedIndexChanged += new System.EventHandler(this.cbOpt_SelectedIndexChanged);
            // 
            // LogicIfProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbOpt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVal2);
            this.Controls.Add(this.txtVal1);
            this.Controls.Add(this.label1);
            this.Name = "LogicIfProp";
            this.Size = new System.Drawing.Size(208, 144);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVal2;
        private System.Windows.Forms.TextBox txtVal1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOpt;
    }
}
