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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.tasksLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.consoleOutputTextBox = new System.Windows.Forms.TextBox();
            this.masterPathLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileTree
            // 
            this.fileTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileTree.Location = new System.Drawing.Point(3, 22);
            this.fileTree.Name = "fileTree";
            this.fileTree.Size = new System.Drawing.Size(242, 413);
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
            this.imageDetailListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageDetailListView.HideSelection = false;
            this.imageDetailListView.Location = new System.Drawing.Point(3, 22);
            this.imageDetailListView.Name = "imageDetailListView";
            this.imageDetailListView.Size = new System.Drawing.Size(377, 413);
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
            this.leftPanel.Controls.Add(this.consoleOutputTextBox);
            this.leftPanel.Controls.Add(this.refreshBtn);
            this.leftPanel.Controls.Add(this.startButton);
            this.leftPanel.Controls.Add(this.progressBar);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(413, 463);
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
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 438);
            this.progressBar.Margin = new System.Windows.Forms.Padding(30);
            this.progressBar.MaximumSize = new System.Drawing.Size(0, 25);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(413, 25);
            this.progressBar.TabIndex = 1;
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
            this.centerPanel.Size = new System.Drawing.Size(248, 438);
            this.centerPanel.TabIndex = 20;
            // 
            // rightPanel
            // 
            this.rightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPanel.Controls.Add(this.imageDetailListView);
            this.rightPanel.Controls.Add(this.tasksLabel);
            this.rightPanel.Location = new System.Drawing.Point(670, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(383, 438);
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
            this.mainPanel.Controls.Add(this.masterPathLabel);
            this.mainPanel.Controls.Add(this.centerPanel);
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.Controls.Add(this.leftPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1053, 463);
            this.mainPanel.TabIndex = 150;
            // 
            // consoleOutputTextBox
            // 
            this.consoleOutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consoleOutputTextBox.Location = new System.Drawing.Point(3, 3);
            this.consoleOutputTextBox.MaxLength = 2147483647;
            this.consoleOutputTextBox.Multiline = true;
            this.consoleOutputTextBox.Name = "consoleOutputTextBox";
            this.consoleOutputTextBox.ReadOnly = true;
            this.consoleOutputTextBox.Size = new System.Drawing.Size(407, 338);
            this.consoleOutputTextBox.TabIndex = 7;
            // 
            // masterPathLabel
            // 
            this.masterPathLabel.AutoSize = true;
            this.masterPathLabel.Location = new System.Drawing.Point(419, 441);
            this.masterPathLabel.Name = "masterPathLabel";
            this.masterPathLabel.Size = new System.Drawing.Size(64, 13);
            this.masterPathLabel.TabIndex = 21;
            this.masterPathLabel.Text = "Image Path:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1053, 463);
            this.Controls.Add(this.mainPanel);
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
            this.mainPanel.PerformLayout();
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
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox consoleOutputTextBox;
        private System.Windows.Forms.Label masterPathLabel;
    }

    
}

