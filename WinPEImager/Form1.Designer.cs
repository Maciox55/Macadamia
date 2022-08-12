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
            this.fileTree = new System.Windows.Forms.TreeView();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.imageDetailListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.tasksLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.consoleOutputTextBox = new System.Windows.Forms.TextBox();
            this.masterPathLabel = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.consoleClearButton = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileTree
            // 
            this.fileTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileTree.Location = new System.Drawing.Point(0, 13);
            this.fileTree.Name = "fileTree";
            this.fileTree.Size = new System.Drawing.Size(283, 425);
            this.fileTree.TabIndex = 2;
            this.fileTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.fileTree_NodeMouseClick);
            this.fileTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.fileTree_NodeMouseDoubleClick);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.White;
            this.refreshBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.refreshBtn.Location = new System.Drawing.Point(0, 347);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(413, 45);
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // imageDetailListView
            // 
            this.imageDetailListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageDetailListView.HideSelection = false;
            this.imageDetailListView.Location = new System.Drawing.Point(0, 13);
            this.imageDetailListView.Name = "imageDetailListView";
            this.imageDetailListView.Size = new System.Drawing.Size(342, 425);
            this.imageDetailListView.TabIndex = 6;
            this.imageDetailListView.UseCompatibleStateImageBehavior = false;
            this.imageDetailListView.View = System.Windows.Forms.View.List;
            this.imageDetailListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.imageDetailListView_MouseDoubleClick);
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
            this.leftPanel.Controls.Add(this.consoleClearButton);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.consoleOutputTextBox);
            this.leftPanel.Controls.Add(this.refreshBtn);
            this.leftPanel.Controls.Add(this.startButton);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(413, 438);
            this.leftPanel.TabIndex = 9;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.White;
            this.startButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.startButton.Location = new System.Drawing.Point(0, 392);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(413, 46);
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
            this.centerPanel.Location = new System.Drawing.Point(419, 0);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(283, 438);
            this.centerPanel.TabIndex = 20;
            // 
            // rightPanel
            // 
            this.rightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPanel.Controls.Add(this.imageDetailListView);
            this.rightPanel.Controls.Add(this.tasksLabel);
            this.rightPanel.Location = new System.Drawing.Point(708, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(342, 438);
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
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.Controls.Add(this.centerPanel);
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.Controls.Add(this.leftPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1053, 438);
            this.mainPanel.TabIndex = 150;
            // 
            // consoleOutputTextBox
            // 
            this.consoleOutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleOutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consoleOutputTextBox.Location = new System.Drawing.Point(6, 22);
            this.consoleOutputTextBox.MaxLength = 2147483647;
            this.consoleOutputTextBox.Multiline = true;
            this.consoleOutputTextBox.Name = "consoleOutputTextBox";
            this.consoleOutputTextBox.ReadOnly = true;
            this.consoleOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleOutputTextBox.Size = new System.Drawing.Size(404, 296);
            this.consoleOutputTextBox.TabIndex = 7;
            // 
            // masterPathLabel
            // 
            this.masterPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.masterPathLabel.AutoSize = true;
            this.masterPathLabel.Location = new System.Drawing.Point(3, 3);
            this.masterPathLabel.Name = "masterPathLabel";
            this.masterPathLabel.Size = new System.Drawing.Size(64, 13);
            this.masterPathLabel.TabIndex = 21;
            this.masterPathLabel.Text = "Image Path:";
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.masterPathLabel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 438);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1053, 25);
            this.bottomPanel.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Console Output";
            // 
            // consoleClearButton
            // 
            this.consoleClearButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.consoleClearButton.Location = new System.Drawing.Point(0, 324);
            this.consoleClearButton.Name = "consoleClearButton";
            this.consoleClearButton.Size = new System.Drawing.Size(413, 23);
            this.consoleClearButton.TabIndex = 9;
            this.consoleClearButton.Text = "Clear";
            this.consoleClearButton.UseVisualStyleBackColor = true;
            this.consoleClearButton.Click += new System.EventHandler(this.consoleClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1053, 463);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.bottomPanel);
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
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView fileTree;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.ListView imageDetailListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label tasksLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label masterPathLabel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button consoleClearButton;
        public System.Windows.Forms.TextBox consoleOutputTextBox;
    }

    
}

