namespace WinPEImager
{
    partial class Form1
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
            this.clientSel = new System.Windows.Forms.ComboBox();
            this.clientSelLabel = new System.Windows.Forms.Label();
            this.fileTree = new System.Windows.Forms.TreeView();
            this.pnSelLabel = new System.Windows.Forms.Label();
            this.pnSel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // clientSel
            // 
            this.clientSel.FormattingEnabled = true;
            this.clientSel.Location = new System.Drawing.Point(15, 25);
            this.clientSel.Name = "clientSel";
            this.clientSel.Size = new System.Drawing.Size(121, 21);
            this.clientSel.TabIndex = 0;
            this.clientSel.SelectedIndexChanged += new System.EventHandler(this.clientSel_SelectedIndexChanged);
            // 
            // clientSelLabel
            // 
            this.clientSelLabel.AutoSize = true;
            this.clientSelLabel.Location = new System.Drawing.Point(12, 9);
            this.clientSelLabel.Name = "clientSelLabel";
            this.clientSelLabel.Size = new System.Drawing.Size(33, 13);
            this.clientSelLabel.TabIndex = 1;
            this.clientSelLabel.Text = "Client";
            // 
            // fileTree
            // 
            this.fileTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fileTree.Location = new System.Drawing.Point(420, 9);
            this.fileTree.Name = "fileTree";
            this.fileTree.Size = new System.Drawing.Size(368, 429);
            this.fileTree.TabIndex = 2;
            // 
            // pnSelLabel
            // 
            this.pnSelLabel.AutoSize = true;
            this.pnSelLabel.Location = new System.Drawing.Point(12, 73);
            this.pnSelLabel.Name = "pnSelLabel";
            this.pnSelLabel.Size = new System.Drawing.Size(66, 13);
            this.pnSelLabel.TabIndex = 3;
            this.pnSelLabel.Text = "Part Number";
            // 
            // pnSel
            // 
            this.pnSel.FormattingEnabled = true;
            this.pnSel.Location = new System.Drawing.Point(12, 89);
            this.pnSel.Name = "pnSel";
            this.pnSel.Size = new System.Drawing.Size(121, 21);
            this.pnSel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnSel);
            this.Controls.Add(this.pnSelLabel);
            this.Controls.Add(this.fileTree);
            this.Controls.Add(this.clientSelLabel);
            this.Controls.Add(this.clientSel);
            this.Name = "Form1";
            this.Text = "WinPE Imager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox clientSel;
        private System.Windows.Forms.Label clientSelLabel;
        private System.Windows.Forms.TreeView fileTree;
        private System.Windows.Forms.Label pnSelLabel;
        private System.Windows.Forms.ComboBox pnSel;


       
    }

    
}

