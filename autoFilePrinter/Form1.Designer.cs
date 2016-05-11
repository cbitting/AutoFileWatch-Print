namespace autoFilePrinter
{
    partial class frmFilePrinter
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
            this.txtDirToWatch = new System.Windows.Forms.TextBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblExt = new System.Windows.Forms.Label();
            this.txtWatchExt = new System.Windows.Forms.TextBox();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkPrintOnce = new System.Windows.Forms.CheckBox();
            this.lblPrintOnce = new System.Windows.Forms.Label();
            this.btnWatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDirToWatch
            // 
            this.txtDirToWatch.Location = new System.Drawing.Point(11, 28);
            this.txtDirToWatch.Name = "txtDirToWatch";
            this.txtDirToWatch.Size = new System.Drawing.Size(426, 20);
            this.txtDirToWatch.TabIndex = 0;
            this.txtDirToWatch.Text = "E:\\cbitting\\testprint";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(12, 9);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(151, 13);
            this.lblDir.TabIndex = 1;
            this.lblDir.Text = "Folder To Watch (ie: C:\\folder)";
            // 
            // lblExt
            // 
            this.lblExt.AutoSize = true;
            this.lblExt.Location = new System.Drawing.Point(12, 61);
            this.lblExt.Name = "lblExt";
            this.lblExt.Size = new System.Drawing.Size(152, 13);
            this.lblExt.TabIndex = 3;
            this.lblExt.Text = "Extension To Look For (ie: pdf)";
            // 
            // txtWatchExt
            // 
            this.txtWatchExt.Location = new System.Drawing.Point(11, 80);
            this.txtWatchExt.Name = "txtWatchExt";
            this.txtWatchExt.Size = new System.Drawing.Size(230, 20);
            this.txtWatchExt.TabIndex = 2;
            this.txtWatchExt.Text = "txt";
            // 
            // lstHistory
            // 
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.Location = new System.Drawing.Point(15, 141);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(422, 173);
            this.lstHistory.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "History";
            // 
            // chkPrintOnce
            // 
            this.chkPrintOnce.AutoSize = true;
            this.chkPrintOnce.Location = new System.Drawing.Point(265, 80);
            this.chkPrintOnce.Name = "chkPrintOnce";
            this.chkPrintOnce.Size = new System.Drawing.Size(141, 17);
            this.chkPrintOnce.TabIndex = 6;
            this.chkPrintOnce.Text = "Print Filename One Time";
            this.chkPrintOnce.UseVisualStyleBackColor = true;
            // 
            // lblPrintOnce
            // 
            this.lblPrintOnce.AutoSize = true;
            this.lblPrintOnce.Location = new System.Drawing.Point(250, 64);
            this.lblPrintOnce.Name = "lblPrintOnce";
            this.lblPrintOnce.Size = new System.Drawing.Size(187, 13);
            this.lblPrintOnce.TabIndex = 7;
            this.lblPrintOnce.Text = "Print Files Once (uses filename history)";
            // 
            // btnWatch
            // 
            this.btnWatch.Location = new System.Drawing.Point(314, 324);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(123, 33);
            this.btnWatch.TabIndex = 8;
            this.btnWatch.Text = "Watch";
            this.btnWatch.UseVisualStyleBackColor = true;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
            // 
            // frmFilePrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 369);
            this.Controls.Add(this.btnWatch);
            this.Controls.Add(this.lblPrintOnce);
            this.Controls.Add(this.chkPrintOnce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.lblExt);
            this.Controls.Add(this.txtWatchExt);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.txtDirToWatch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmFilePrinter";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Auto File Print";
            this.Load += new System.EventHandler(this.frmFilePrinter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDirToWatch;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblExt;
        private System.Windows.Forms.TextBox txtWatchExt;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkPrintOnce;
        private System.Windows.Forms.Label lblPrintOnce;
        private System.Windows.Forms.Button btnWatch;
    }
}

