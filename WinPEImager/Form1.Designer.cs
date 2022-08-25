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
            this.consolePanel = new System.Windows.Forms.Panel();
            this.consoleOutputTextBox = new System.Windows.Forms.TextBox();
            this.consoleInputPanel = new System.Windows.Forms.Panel();
            this.cmdInputSubmitButton = new System.Windows.Forms.Button();
            this.cmdInputField = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.consoleClearButton = new System.Windows.Forms.Button();
            this.abortCMD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.treeView = new System.Windows.Forms.Panel();
            this.taskControl = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.listPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tasksLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.masterPathLabel = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftPanel.SuspendLayout();
            this.consolePanel.SuspendLayout();
            this.consoleInputPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.treeView.SuspendLayout();
            this.taskControl.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.listPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileTree
            // 
            this.fileTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileTree.Location = new System.Drawing.Point(3, 16);
            this.fileTree.Name = "fileTree";
            this.fileTree.Size = new System.Drawing.Size(277, 377);
            this.fileTree.TabIndex = 2;
            this.fileTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.fileTree_NodeMouseClick);
            this.fileTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.fileTree_NodeMouseDoubleClick);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.White;
            this.refreshBtn.BackgroundImage = global::WinPEImager.Properties.Resources.refresh;
            this.refreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.refreshBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.refreshBtn.Location = new System.Drawing.Point(0, 0);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(30, 30);
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // imageDetailListView
            // 
            this.imageDetailListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageDetailListView.HideSelection = false;
            this.imageDetailListView.Location = new System.Drawing.Point(0, 0);
            this.imageDetailListView.Name = "imageDetailListView";
            this.imageDetailListView.Size = new System.Drawing.Size(360, 377);
            this.imageDetailListView.TabIndex = 6;
            this.imageDetailListView.UseCompatibleStateImageBehavior = false;
            this.imageDetailListView.View = System.Windows.Forms.View.List;
            this.imageDetailListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imageDetailListView_MouseClick);
            this.imageDetailListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.imageDetailListView_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Images";
            // 
            // leftPanel
            // 
            this.leftPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.leftPanel.Controls.Add(this.consolePanel);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(3, 3);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Padding = new System.Windows.Forms.Padding(3);
            this.leftPanel.Size = new System.Drawing.Size(419, 445);
            this.leftPanel.TabIndex = 9;
            // 
            // consolePanel
            // 
            this.consolePanel.Controls.Add(this.consoleOutputTextBox);
            this.consolePanel.Controls.Add(this.consoleInputPanel);
            this.consolePanel.Controls.Add(this.panel2);
            this.consolePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consolePanel.Location = new System.Drawing.Point(3, 16);
            this.consolePanel.Name = "consolePanel";
            this.consolePanel.Size = new System.Drawing.Size(413, 426);
            this.consolePanel.TabIndex = 12;
            // 
            // consoleOutputTextBox
            // 
            this.consoleOutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consoleOutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleOutputTextBox.Location = new System.Drawing.Point(0, 0);
            this.consoleOutputTextBox.MaxLength = 2147483647;
            this.consoleOutputTextBox.Multiline = true;
            this.consoleOutputTextBox.Name = "consoleOutputTextBox";
            this.consoleOutputTextBox.ReadOnly = true;
            this.consoleOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleOutputTextBox.Size = new System.Drawing.Size(413, 370);
            this.consoleOutputTextBox.TabIndex = 7;
            // 
            // consoleInputPanel
            // 
            this.consoleInputPanel.Controls.Add(this.cmdInputSubmitButton);
            this.consoleInputPanel.Controls.Add(this.cmdInputField);
            this.consoleInputPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.consoleInputPanel.Location = new System.Drawing.Point(0, 370);
            this.consoleInputPanel.Name = "consoleInputPanel";
            this.consoleInputPanel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.consoleInputPanel.Size = new System.Drawing.Size(413, 26);
            this.consoleInputPanel.TabIndex = 12;
            // 
            // cmdInputSubmitButton
            // 
            this.cmdInputSubmitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdInputSubmitButton.Location = new System.Drawing.Point(342, 3);
            this.cmdInputSubmitButton.Margin = new System.Windows.Forms.Padding(0);
            this.cmdInputSubmitButton.Name = "cmdInputSubmitButton";
            this.cmdInputSubmitButton.Size = new System.Drawing.Size(71, 23);
            this.cmdInputSubmitButton.TabIndex = 11;
            this.cmdInputSubmitButton.Text = "SEND";
            this.cmdInputSubmitButton.UseVisualStyleBackColor = true;
            this.cmdInputSubmitButton.Click += new System.EventHandler(this.cmdInputSubmitButton_Click);
            // 
            // cmdInputField
            // 
            this.cmdInputField.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdInputField.Location = new System.Drawing.Point(0, 3);
            this.cmdInputField.Name = "cmdInputField";
            this.cmdInputField.Size = new System.Drawing.Size(339, 20);
            this.cmdInputField.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.consoleClearButton);
            this.panel2.Controls.Add(this.abortCMD);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 396);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 30);
            this.panel2.TabIndex = 8;
            // 
            // consoleClearButton
            // 
            this.consoleClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleClearButton.Location = new System.Drawing.Point(61, 0);
            this.consoleClearButton.Margin = new System.Windows.Forms.Padding(0);
            this.consoleClearButton.Name = "consoleClearButton";
            this.consoleClearButton.Size = new System.Drawing.Size(352, 30);
            this.consoleClearButton.TabIndex = 9;
            this.consoleClearButton.Text = "CLEAR";
            this.consoleClearButton.UseVisualStyleBackColor = true;
            this.consoleClearButton.Click += new System.EventHandler(this.consoleClearButton_Click);
            // 
            // abortCMD
            // 
            this.abortCMD.BackColor = System.Drawing.Color.IndianRed;
            this.abortCMD.Dock = System.Windows.Forms.DockStyle.Left;
            this.abortCMD.ForeColor = System.Drawing.SystemColors.MenuText;
            this.abortCMD.Location = new System.Drawing.Point(0, 0);
            this.abortCMD.Margin = new System.Windows.Forms.Padding(0);
            this.abortCMD.Name = "abortCMD";
            this.abortCMD.Size = new System.Drawing.Size(61, 30);
            this.abortCMD.TabIndex = 7;
            this.abortCMD.Text = "ABORT";
            this.abortCMD.UseVisualStyleBackColor = false;
            this.abortCMD.Click += new System.EventHandler(this.abortCMD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Console Output";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.White;
            this.startButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.startButton.Location = new System.Drawing.Point(181, 0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(96, 30);
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
            this.centerPanel.Controls.Add(this.treeView);
            this.centerPanel.Location = new System.Drawing.Point(422, 3);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Padding = new System.Windows.Forms.Padding(3);
            this.centerPanel.Size = new System.Drawing.Size(283, 445);
            this.centerPanel.TabIndex = 20;
            // 
            // treeView
            // 
            this.treeView.Controls.Add(this.taskControl);
            this.treeView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.treeView.Location = new System.Drawing.Point(3, 393);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(277, 49);
            this.treeView.TabIndex = 13;
            // 
            // taskControl
            // 
            this.taskControl.Controls.Add(this.refreshBtn);
            this.taskControl.Controls.Add(this.startButton);
            this.taskControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.taskControl.Location = new System.Drawing.Point(0, 19);
            this.taskControl.Name = "taskControl";
            this.taskControl.Size = new System.Drawing.Size(277, 30);
            this.taskControl.TabIndex = 10;
            // 
            // rightPanel
            // 
            this.rightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPanel.Controls.Add(this.listPanel);
            this.rightPanel.Controls.Add(this.panel1);
            this.rightPanel.Controls.Add(this.tasksLabel);
            this.rightPanel.Location = new System.Drawing.Point(704, 3);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Padding = new System.Windows.Forms.Padding(3);
            this.rightPanel.Size = new System.Drawing.Size(366, 445);
            this.rightPanel.TabIndex = 10;
            // 
            // listPanel
            // 
            this.listPanel.Controls.Add(this.imageDetailListView);
            this.listPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPanel.Location = new System.Drawing.Point(3, 16);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(360, 377);
            this.listPanel.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 49);
            this.panel1.TabIndex = 9;
            // 
            // tasksLabel
            // 
            this.tasksLabel.AutoSize = true;
            this.tasksLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tasksLabel.Location = new System.Drawing.Point(3, 3);
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
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(3);
            this.mainPanel.Size = new System.Drawing.Size(1070, 451);
            this.mainPanel.TabIndex = 150;
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
            this.bottomPanel.Location = new System.Drawing.Point(0, 475);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1070, 25);
            this.bottomPanel.TabIndex = 22;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1070, 24);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consoleToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // consoleToolStripMenuItem
            // 
            this.consoleToolStripMenuItem.Name = "consoleToolStripMenuItem";
            this.consoleToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.consoleToolStripMenuItem.Text = "Console";
            this.consoleToolStripMenuItem.Click += new System.EventHandler(this.consoleToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1070, 500);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1070, 500);
            this.Name = "Form1";
            this.Text = "WinPE Imager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.consolePanel.ResumeLayout(false);
            this.consolePanel.PerformLayout();
            this.consoleInputPanel.ResumeLayout(false);
            this.consoleInputPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.centerPanel.ResumeLayout(false);
            this.centerPanel.PerformLayout();
            this.treeView.ResumeLayout(false);
            this.taskControl.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.listPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Button cmdInputSubmitButton;
        private System.Windows.Forms.TextBox cmdInputField;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel consolePanel;
        private System.Windows.Forms.Panel consoleInputPanel;
        private System.Windows.Forms.Panel treeView;
        private System.Windows.Forms.Panel taskControl;
        private System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button abortCMD;
    }

    
}

