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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.taskSelectionLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.consolePanel.SuspendLayout();
            this.consoleInputPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.treeView.SuspendLayout();
            this.taskControl.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.listPanel.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.fileTree.Size = new System.Drawing.Size(277, 338);
            this.fileTree.TabIndex = 1;
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
            this.toolTip1.SetToolTip(this.refreshBtn, "Refresh and rediscover Autmation Scripts in master directory.");
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // imageDetailListView
            // 
            this.imageDetailListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageDetailListView.HideSelection = false;
            this.imageDetailListView.Location = new System.Drawing.Point(0, 0);
            this.imageDetailListView.Name = "imageDetailListView";
            this.imageDetailListView.Size = new System.Drawing.Size(274, 338);
            this.imageDetailListView.TabIndex = 9;
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
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Detected Files";
            this.toolTip1.SetToolTip(this.label1, "Displays a file tree of detected files in master directory.");
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
            this.leftPanel.Size = new System.Drawing.Size(419, 406);
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
            this.consolePanel.Size = new System.Drawing.Size(413, 387);
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
            this.consoleOutputTextBox.Size = new System.Drawing.Size(413, 331);
            this.consoleOutputTextBox.TabIndex = 8;
            // 
            // consoleInputPanel
            // 
            this.consoleInputPanel.Controls.Add(this.cmdInputSubmitButton);
            this.consoleInputPanel.Controls.Add(this.cmdInputField);
            this.consoleInputPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.consoleInputPanel.Location = new System.Drawing.Point(0, 331);
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
            this.cmdInputSubmitButton.TabIndex = 3;
            this.cmdInputSubmitButton.Text = "SEND";
            this.toolTip1.SetToolTip(this.cmdInputSubmitButton, "Sends user input back to the console process. Commands will not work here.");
            this.cmdInputSubmitButton.UseVisualStyleBackColor = true;
            this.cmdInputSubmitButton.Click += new System.EventHandler(this.cmdInputSubmitButton_Click);
            // 
            // cmdInputField
            // 
            this.cmdInputField.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdInputField.Location = new System.Drawing.Point(0, 3);
            this.cmdInputField.Name = "cmdInputField";
            this.cmdInputField.Size = new System.Drawing.Size(339, 20);
            this.cmdInputField.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.consoleClearButton);
            this.panel2.Controls.Add(this.abortCMD);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 357);
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
            this.consoleClearButton.TabIndex = 6;
            this.consoleClearButton.Text = "CLEAR";
            this.toolTip1.SetToolTip(this.consoleClearButton, "Clear console log.");
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
            this.toolTip1.SetToolTip(this.abortCMD, "Attempts to Abort the current command, may not always work.");
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
            this.toolTip1.SetToolTip(this.label2, "Outputs any Console results");
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.White;
            this.startButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.startButton.Location = new System.Drawing.Point(181, 0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(96, 30);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "START";
            this.toolTip1.SetToolTip(this.startButton, "Starts selected Automation Script.");
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
            this.centerPanel.Size = new System.Drawing.Size(283, 406);
            this.centerPanel.TabIndex = 20;
            // 
            // treeView
            // 
            this.treeView.Controls.Add(this.taskControl);
            this.treeView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.treeView.Location = new System.Drawing.Point(3, 354);
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
            this.rightPanel.Size = new System.Drawing.Size(280, 406);
            this.rightPanel.TabIndex = 10;
            // 
            // listPanel
            // 
            this.listPanel.Controls.Add(this.imageDetailListView);
            this.listPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPanel.Location = new System.Drawing.Point(3, 16);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(274, 338);
            this.listPanel.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.taskSelectionLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 49);
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
            this.toolTip1.SetToolTip(this.tasksLabel, "Displays tasks and their status.");
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
            this.mainPanel.Size = new System.Drawing.Size(984, 412);
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
            this.masterPathLabel.Size = new System.Drawing.Size(62, 13);
            this.masterPathLabel.TabIndex = 21;
            this.masterPathLabel.Text = "Script Path:";
            this.toolTip1.SetToolTip(this.masterPathLabel, "Path for the selected Automation Script");
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.masterPathLabel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 436);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(984, 25);
            this.bottomPanel.TabIndex = 22;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(984, 24);
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
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 6);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.aboutToolStripMenuItem1.Text = "&About...";
            // 
            // taskSelectionLabel
            // 
            this.taskSelectionLabel.AutoSize = true;
            this.taskSelectionLabel.Location = new System.Drawing.Point(4, 3);
            this.taskSelectionLabel.Name = "taskSelectionLabel";
            this.taskSelectionLabel.Size = new System.Drawing.Size(76, 13);
            this.taskSelectionLabel.TabIndex = 0;
            this.taskSelectionLabel.Text = "Selected Task";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1000, 400);
            this.Name = "Form1";
            this.Text = "Macadamia -Batch Automation Utility";
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label taskSelectionLabel;
    }

    
}

