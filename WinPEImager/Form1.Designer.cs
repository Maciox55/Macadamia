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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.tasksLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.masterPathLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientSel
            // 
            this.clientSel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientSel.FormattingEnabled = true;
            this.clientSel.Location = new System.Drawing.Point(6, 22);
            this.clientSel.Name = "clientSel";
            this.clientSel.Size = new System.Drawing.Size(192, 21);
            this.clientSel.TabIndex = 0;
            this.clientSel.SelectedIndexChanged += new System.EventHandler(this.clientSel_SelectedIndexChanged);
            // 
            // clientSelLabel
            // 
            this.clientSelLabel.AutoSize = true;
            this.clientSelLabel.Location = new System.Drawing.Point(3, 6);
            this.clientSelLabel.Name = "clientSelLabel";
            this.clientSelLabel.Size = new System.Drawing.Size(33, 13);
            this.clientSelLabel.TabIndex = 1;
            this.clientSelLabel.Text = "Client";
            // 
            // fileTree
            // 
            this.fileTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileTree.Location = new System.Drawing.Point(3, 22);
            this.fileTree.Name = "fileTree";
            this.fileTree.Size = new System.Drawing.Size(209, 413);
            this.fileTree.TabIndex = 2;
            this.fileTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.fileTree_NodeMouseClick);
            this.fileTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.fileTree_NodeMouseDoubleClick);
            // 
            // pnSelLabel
            // 
            this.pnSelLabel.AutoSize = true;
            this.pnSelLabel.Location = new System.Drawing.Point(3, 58);
            this.pnSelLabel.Name = "pnSelLabel";
            this.pnSelLabel.Size = new System.Drawing.Size(66, 13);
            this.pnSelLabel.TabIndex = 3;
            this.pnSelLabel.Text = "Part Number";
            // 
            // pnSel
            // 
            this.pnSel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSel.FormattingEnabled = true;
            this.pnSel.Location = new System.Drawing.Point(6, 76);
            this.pnSel.Name = "pnSel";
            this.pnSel.Size = new System.Drawing.Size(192, 21);
            this.pnSel.TabIndex = 4;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.White;
            this.refreshBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.refreshBtn.Location = new System.Drawing.Point(0, 347);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(201, 45);
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // imageDetailListView
            // 
            this.imageDetailListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageDetailListView.HideSelection = false;
            this.imageDetailListView.Location = new System.Drawing.Point(3, 22);
            this.imageDetailListView.Name = "imageDetailListView";
            this.imageDetailListView.Size = new System.Drawing.Size(631, 413);
            this.imageDetailListView.TabIndex = 6;
            this.imageDetailListView.UseCompatibleStateImageBehavior = false;
            this.imageDetailListView.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Images";
            // 
            // leftPanel
            // 
            this.leftPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.leftPanel.Controls.Add(this.refreshBtn);
            this.leftPanel.Controls.Add(this.startButton);
            this.leftPanel.Controls.Add(this.clientSel);
            this.leftPanel.Controls.Add(this.clientSelLabel);
            this.leftPanel.Controls.Add(this.pnSelLabel);
            this.leftPanel.Controls.Add(this.pnSel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(201, 438);
            this.leftPanel.TabIndex = 9;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.White;
            this.startButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.startButton.Location = new System.Drawing.Point(0, 392);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(201, 46);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // centerPanel
            // 
            this.centerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.centerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.centerPanel.Controls.Add(this.fileTree);
            this.centerPanel.Controls.Add(this.label1);
            this.centerPanel.Location = new System.Drawing.Point(201, 0);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(215, 438);
            this.centerPanel.TabIndex = 20;
            // 
            // rightPanel
            // 
            this.rightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPanel.Controls.Add(this.imageDetailListView);
            this.rightPanel.Controls.Add(this.tasksLabel);
            this.rightPanel.Location = new System.Drawing.Point(416, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(637, 438);
            this.rightPanel.TabIndex = 10;
            // 
            // tasksLabel
            // 
            this.tasksLabel.AutoSize = true;
            this.tasksLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tasksLabel.Location = new System.Drawing.Point(0, 0);
            this.tasksLabel.Name = "tasksLabel";
            this.tasksLabel.Size = new System.Drawing.Size(36, 13);
            this.tasksLabel.TabIndex = 7;
            this.tasksLabel.Text = "Tasks";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.centerPanel);
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.Controls.Add(this.leftPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1053, 438);
            this.mainPanel.TabIndex = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.masterPathLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 438);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 25);
            this.panel1.TabIndex = 6;
            // 
            // masterPathLabel
            // 
            this.masterPathLabel.AutoSize = true;
            this.masterPathLabel.Location = new System.Drawing.Point(3, 6);
            this.masterPathLabel.Name = "masterPathLabel";
            this.masterPathLabel.Size = new System.Drawing.Size(35, 13);
            this.masterPathLabel.TabIndex = 0;
            this.masterPathLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1053, 463);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "WinPE Imager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.centerPanel.ResumeLayout(false);
            this.centerPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label tasksLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label masterPathLabel;
        private System.Windows.Forms.Button startButton;
    }

    
}

