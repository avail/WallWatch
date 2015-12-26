using System;

namespace WallWatch
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.watchListDirectories = new System.Windows.Forms.CheckedListBox();
            this.addToWatchlist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.ignoreAspectRatio = new System.Windows.Forms.CheckBox();
            this.allowSameWall = new System.Windows.Forms.CheckBox();
            this.fetchFromSubdirectories = new System.Windows.Forms.CheckBox();
            this.minimizeToTray = new System.Windows.Forms.CheckBox();
            this.timeSpanBox = new System.Windows.Forms.ComboBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.detectScreens = new System.Windows.Forms.Button();
            this.consoleBox = new System.Windows.Forms.GroupBox();
            this.consoleTextBox = new System.Windows.Forms.TextBox();
            this.fetchImages = new System.Windows.Forms.Button();
            this.letsBegin = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.settingsGroupBox.SuspendLayout();
            this.consoleBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "WallWatch 0.1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // checkedListBox1
            // 
            this.watchListDirectories.FormattingEnabled = true;
            this.watchListDirectories.Location = new System.Drawing.Point(13, 13);
            this.watchListDirectories.Name = "Watch list directories";
            this.watchListDirectories.Size = new System.Drawing.Size(280, 94);
            this.watchListDirectories.TabIndex = 0;
            // 
            // addToWatchlist
            // 
            this.addToWatchlist.Location = new System.Drawing.Point(12, 113);
            this.addToWatchlist.Name = "addToWatchlist";
            this.addToWatchlist.Size = new System.Drawing.Size(138, 23);
            this.addToWatchlist.TabIndex = 1;
            this.addToWatchlist.Text = "Add to watch list";
            this.addToWatchlist.UseVisualStyleBackColor = true;
            this.addToWatchlist.Click += new System.EventHandler(this.addToWatchlist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wallpaper change every";
            // 
            // groupBox1
            // 
            this.settingsGroupBox.Controls.Add(this.ignoreAspectRatio);
            this.settingsGroupBox.Controls.Add(this.allowSameWall);
            this.settingsGroupBox.Controls.Add(this.fetchFromSubdirectories);
            this.settingsGroupBox.Controls.Add(this.minimizeToTray);
            this.settingsGroupBox.Controls.Add(this.timeSpanBox);
            this.settingsGroupBox.Controls.Add(this.timeBox);
            this.settingsGroupBox.Controls.Add(this.label1);
            this.settingsGroupBox.Location = new System.Drawing.Point(12, 171);
            this.settingsGroupBox.Name = "groupBox1";
            this.settingsGroupBox.Size = new System.Drawing.Size(281, 140);
            this.settingsGroupBox.TabIndex = 3;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings";
            // 
            // ignoreAspectRatio
            // 
            this.ignoreAspectRatio.AutoSize = true;
            this.ignoreAspectRatio.Location = new System.Drawing.Point(9, 115);
            this.ignoreAspectRatio.Name = "ignoreAspectRatio";
            this.ignoreAspectRatio.Size = new System.Drawing.Size(114, 17);
            this.ignoreAspectRatio.TabIndex = 8;
            this.ignoreAspectRatio.Text = "Ignore aspect ratio";
            this.ignoreAspectRatio.UseVisualStyleBackColor = true;
            this.ignoreAspectRatio.CheckedChanged += new System.EventHandler(this.ignoreAspectRatio_CheckedChanged);
            // 
            // allowSameWall
            // 
            this.allowSameWall.AutoSize = true;
            this.allowSameWall.Location = new System.Drawing.Point(9, 92);
            this.allowSameWall.Name = "allowSameWall";
            this.allowSameWall.Size = new System.Drawing.Size(197, 17);
            this.allowSameWall.TabIndex = 7;
            this.allowSameWall.Text = "Allow same wallpaper on all monitors";
            this.allowSameWall.UseVisualStyleBackColor = true;
            this.allowSameWall.CheckedChanged += new System.EventHandler(this.allowSameWall_CheckedChanged);
            // 
            // checkBox2
            // 
            this.fetchFromSubdirectories.AutoSize = true;
            this.fetchFromSubdirectories.Location = new System.Drawing.Point(9, 69);
            this.fetchFromSubdirectories.Name = "checkBox2";
            this.fetchFromSubdirectories.Size = new System.Drawing.Size(144, 17);
            this.fetchFromSubdirectories.TabIndex = 6;
            this.fetchFromSubdirectories.Text = "Fetch from subdirectories";
            this.fetchFromSubdirectories.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.minimizeToTray.AutoSize = true;
            this.minimizeToTray.Enabled = false;
            this.minimizeToTray.Location = new System.Drawing.Point(9, 45);
            this.minimizeToTray.Name = "checkBox1";
            this.minimizeToTray.Size = new System.Drawing.Size(156, 17);
            this.minimizeToTray.TabIndex = 5;
            this.minimizeToTray.Text = "Close minimizes to tray (wip)";
            this.minimizeToTray.UseVisualStyleBackColor = true;
            this.minimizeToTray.CheckedChanged += new System.EventHandler(this.minimizeToTray_CheckedChanged);
            // 
            // timeSpanBox
            // 
            this.timeSpanBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeSpanBox.FormattingEnabled = true;
            this.timeSpanBox.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours"});
            this.timeSpanBox.Location = new System.Drawing.Point(171, 18);
            this.timeSpanBox.Name = "timeSpanBox";
            this.timeSpanBox.Size = new System.Drawing.Size(102, 21);
            this.timeSpanBox.TabIndex = 4;
            this.timeSpanBox.SelectedIndexChanged += new System.EventHandler(this.timeSpanBox_SelectedIndexChanged);
            // 
            // timeBox
            // 
            this.timeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.timeBox.Location = new System.Drawing.Point(132, 18);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(33, 21);
            this.timeBox.TabIndex = 3;
            this.timeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeBox.TextChanged += new System.EventHandler(this.timeBox_TextChanged);
            // 
            // detectScreens
            // 
            this.detectScreens.Location = new System.Drawing.Point(13, 142);
            this.detectScreens.Name = "detectScreens";
            this.detectScreens.Size = new System.Drawing.Size(137, 23);
            this.detectScreens.TabIndex = 6;
            this.detectScreens.Text = "Detect screens";
            this.detectScreens.UseVisualStyleBackColor = true;
            this.detectScreens.Click += new System.EventHandler(this.detectScreens_Click);
            // 
            // groupBox2
            // 
            this.consoleBox.Controls.Add(this.consoleTextBox);
            this.consoleBox.Location = new System.Drawing.Point(12, 317);
            this.consoleBox.Name = "groupBox2";
            this.consoleBox.Size = new System.Drawing.Size(281, 191);
            this.consoleBox.TabIndex = 8;
            this.consoleBox.TabStop = false;
            this.consoleBox.Text = "Console";
            // 
            // consoleBox
            // 
            this.consoleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleTextBox.Enabled = false;
            this.consoleTextBox.Location = new System.Drawing.Point(9, 20);
            this.consoleTextBox.Multiline = true;
            this.consoleTextBox.Name = "consoleBox";
            this.consoleTextBox.ReadOnly = true;
            this.consoleTextBox.Size = new System.Drawing.Size(266, 165);
            this.consoleTextBox.TabIndex = 0;
            // 
            // fetchImages
            // 
            this.fetchImages.Location = new System.Drawing.Point(156, 113);
            this.fetchImages.Name = "fetchImages";
            this.fetchImages.Size = new System.Drawing.Size(137, 23);
            this.fetchImages.TabIndex = 9;
            this.fetchImages.Text = "Fetch images";
            this.fetchImages.UseVisualStyleBackColor = true;
            this.fetchImages.Click += new System.EventHandler(this.fetchImages_Click);
            // 
            // letsBegin
            // 
            this.letsBegin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letsBegin.Location = new System.Drawing.Point(156, 142);
            this.letsBegin.Name = "letsBegin";
            this.letsBegin.Size = new System.Drawing.Size(137, 23);
            this.letsBegin.TabIndex = 10;
            this.letsBegin.Text = "LET\'S BEGIN";
            this.letsBegin.UseVisualStyleBackColor = true;
            this.letsBegin.Click += new System.EventHandler(this.letsBegin_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 520);
            this.Controls.Add(this.letsBegin);
            this.Controls.Add(this.fetchImages);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.detectScreens);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.addToWatchlist);
            this.Controls.Add(this.watchListDirectories);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WallWatch";
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            this.consoleBox.ResumeLayout(false);
            this.consoleBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckedListBox watchListDirectories;
        private System.Windows.Forms.Button addToWatchlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox timeSpanBox;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.CheckBox minimizeToTray;
        private System.Windows.Forms.Button detectScreens;
        private System.Windows.Forms.GroupBox consoleBox;
        private System.Windows.Forms.TextBox consoleTextBox;
        private System.Windows.Forms.Button fetchImages;
        private System.Windows.Forms.CheckBox fetchFromSubdirectories;
        private System.Windows.Forms.Button letsBegin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox ignoreAspectRatio;
        private System.Windows.Forms.CheckBox allowSameWall;
    }
}

