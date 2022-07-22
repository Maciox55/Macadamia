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
            this.refreshBtn = new System.Windows.Forms.Button();
            this.imageDetailListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.fileTree.Location = new System.Drawing.Point(197, 25);
            this.fileTree.Name = "fileTree";
            this.fileTree.Size = new System.Drawing.Size(368, 392);
            this.fileTree.TabIndex = 2;
            this.fileTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.fileTree_NodeMouseDoubleClick);
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
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(490, 428);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // imageDetailListView
            // 
            this.imageDetailListView.HideSelection = false;
            this.imageDetailListView.Location = new System.Drawing.Point(655, 25);
            this.imageDetailListView.Name = "imageDetailListView";
            this.imageDetailListView.Size = new System.Drawing.Size(332, 392);
            this.imageDetailListView.TabIndex = 6;
            this.imageDetailListView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Images";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(652, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tasks";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 463);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageDetailListView);
            this.Controls.Add(this.refreshBtn);
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
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.ListView imageDetailListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }

    
}

