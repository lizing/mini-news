namespace RssProject
{
    partial class MainFrame
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.구독추가NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.원문기사보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기사스크랩SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.인쇄PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ViewChannel = new System.Windows.Forms.TreeView();
            this.ChannelMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rename = new System.Windows.Forms.ToolStripMenuItem();
            this.del = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PanelText = new System.Windows.Forms.Panel();
            this.contentBrowser = new System.Windows.Forms.WebBrowser();
            this.btnAdd = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.readall_button = new System.Windows.Forms.Button();
            this.fontIncButton = new System.Windows.Forms.Button();
            this.fontDecButton = new System.Windows.Forms.Button();
            this.gulimButton = new System.Windows.Forms.Button();
            this.batangButton = new System.Windows.Forms.Button();
            this.malgungothicButton = new System.Windows.Forms.Button();
            this.arialButton = new System.Windows.Forms.Button();
            this.verdanaButton = new System.Windows.Forms.Button();
            this.rowIncButton = new System.Windows.Forms.Button();
            this.rowDecButton = new System.Windows.Forms.Button();
            this.marginIncButton = new System.Windows.Forms.Button();
            this.marginDecButton = new System.Windows.Forms.Button();
            this.fontSizeLabel = new System.Windows.Forms.Label();
            this.fontLabel = new System.Windows.Forms.Label();
            this.rowLabel = new System.Windows.Forms.Label();
            this.marginLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ChannelMenuStrip.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            this.PanelText.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.구독추가NToolStripMenuItem,
            this.원문기사보기ToolStripMenuItem,
            this.기사스크랩SToolStripMenuItem,
            this.인쇄PToolStripMenuItem,
            this.종료XToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // 구독추가NToolStripMenuItem
            // 
            this.구독추가NToolStripMenuItem.Name = "구독추가NToolStripMenuItem";
            this.구독추가NToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.구독추가NToolStripMenuItem.Text = "구독 추가(&N)";
            this.구독추가NToolStripMenuItem.Click += new System.EventHandler(this.구독추가NToolStripMenuItem_Click);
            // 
            // 원문기사보기ToolStripMenuItem
            // 
            this.원문기사보기ToolStripMenuItem.Name = "원문기사보기ToolStripMenuItem";
            this.원문기사보기ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.원문기사보기ToolStripMenuItem.Text = "원문 기사 보기(&O)";
            this.원문기사보기ToolStripMenuItem.Click += new System.EventHandler(this.원문기사보기ToolStripMenuItem_Click);
            // 
            // 기사스크랩SToolStripMenuItem
            // 
            this.기사스크랩SToolStripMenuItem.Name = "기사스크랩SToolStripMenuItem";
            this.기사스크랩SToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.기사스크랩SToolStripMenuItem.Text = "현재 기사 스크랩(&S)";
            this.기사스크랩SToolStripMenuItem.Click += new System.EventHandler(this.기사스크랩SToolStripMenuItem_Click);
            // 
            // 인쇄PToolStripMenuItem
            // 
            this.인쇄PToolStripMenuItem.Name = "인쇄PToolStripMenuItem";
            this.인쇄PToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.인쇄PToolStripMenuItem.Text = "인쇄(&P)";
            this.인쇄PToolStripMenuItem.Click += new System.EventHandler(this.인쇄PToolStripMenuItem_Click);
            // 
            // 종료XToolStripMenuItem
            // 
            this.종료XToolStripMenuItem.Name = "종료XToolStripMenuItem";
            this.종료XToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.종료XToolStripMenuItem.Text = "종료(&X)";
            this.종료XToolStripMenuItem.Click += new System.EventHandler(this.종료XToolStripMenuItem_Click);
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.프로그램정보ToolStripMenuItem});
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.도움말HToolStripMenuItem.Text = "도움말(&H)";
            // 
            // 프로그램정보ToolStripMenuItem
            // 
            this.프로그램정보ToolStripMenuItem.Name = "프로그램정보ToolStripMenuItem";
            this.프로그램정보ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.프로그램정보ToolStripMenuItem.Text = "프로그램 정보";
            this.프로그램정보ToolStripMenuItem.Click += new System.EventHandler(this.프로그램정보ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ViewChannel);
            this.panel1.Location = new System.Drawing.Point(11, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 578);
            this.panel1.TabIndex = 1;
            // 
            // ViewChannel
            // 
            this.ViewChannel.ContextMenuStrip = this.ChannelMenuStrip;
            this.ViewChannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewChannel.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ViewChannel.Location = new System.Drawing.Point(0, 0);
            this.ViewChannel.Name = "ViewChannel";
            this.ViewChannel.Size = new System.Drawing.Size(222, 576);
            this.ViewChannel.TabIndex = 0;
            this.ViewChannel.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ViewChannel_AfterSelect);
            // 
            // ChannelMenuStrip
            // 
            this.ChannelMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rename,
            this.del});
            this.ChannelMenuStrip.Name = "contextMenuStrip1";
            this.ChannelMenuStrip.Size = new System.Drawing.Size(155, 48);
            // 
            // rename
            // 
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(154, 22);
            this.rename.Text = "구독 이름 변경";
            this.rename.Click += new System.EventHandler(this.rename_Click);
            // 
            // del
            // 
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(154, 22);
            this.del.Text = "구독 삭제";
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // PanelTitle
            // 
            this.PanelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelTitle.Controls.Add(this.listView1);
            this.PanelTitle.Location = new System.Drawing.Point(241, 68);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(731, 164);
            this.PanelTitle.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.title,
            this.date});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(729, 162);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // title
            // 
            this.title.Text = "제목";
            this.title.Width = 549;
            // 
            // date
            // 
            this.date.Text = "발행일자";
            this.date.Width = 215;
            // 
            // PanelText
            // 
            this.PanelText.BackColor = System.Drawing.Color.White;
            this.PanelText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelText.Controls.Add(this.contentBrowser);
            this.PanelText.Location = new System.Drawing.Point(241, 238);
            this.PanelText.Name = "PanelText";
            this.PanelText.Size = new System.Drawing.Size(731, 407);
            this.PanelText.TabIndex = 3;
            // 
            // contentBrowser
            // 
            this.contentBrowser.Location = new System.Drawing.Point(0, 0);
            this.contentBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.contentBrowser.Name = "contentBrowser";
            this.contentBrowser.Size = new System.Drawing.Size(726, 405);
            this.contentBrowser.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 652);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "구독 추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(905, 27);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(67, 33);
            this.refresh_button.TabIndex = 5;
            this.refresh_button.Text = "새로고침";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // readall_button
            // 
            this.readall_button.Location = new System.Drawing.Point(832, 27);
            this.readall_button.Name = "readall_button";
            this.readall_button.Size = new System.Drawing.Size(67, 33);
            this.readall_button.TabIndex = 6;
            this.readall_button.Text = "모두 읽음";
            this.readall_button.UseVisualStyleBackColor = true;
            this.readall_button.Click += new System.EventHandler(this.readall_button_Click);
            // 
            // fontIncButton
            // 
            this.fontIncButton.Location = new System.Drawing.Point(62, 27);
            this.fontIncButton.Name = "fontIncButton";
            this.fontIncButton.Size = new System.Drawing.Size(38, 33);
            this.fontIncButton.TabIndex = 7;
            this.fontIncButton.Text = "A+";
            this.fontIncButton.UseVisualStyleBackColor = true;
            this.fontIncButton.Click += new System.EventHandler(this.fontIncButton_Click);
            // 
            // fontDecButton
            // 
            this.fontDecButton.Location = new System.Drawing.Point(106, 27);
            this.fontDecButton.Name = "fontDecButton";
            this.fontDecButton.Size = new System.Drawing.Size(38, 33);
            this.fontDecButton.TabIndex = 8;
            this.fontDecButton.Text = "A-";
            this.fontDecButton.UseVisualStyleBackColor = true;
            this.fontDecButton.Click += new System.EventHandler(this.fontDecButton_Click);
            // 
            // gulimButton
            // 
            this.gulimButton.Location = new System.Drawing.Point(205, 27);
            this.gulimButton.Name = "gulimButton";
            this.gulimButton.Size = new System.Drawing.Size(62, 33);
            this.gulimButton.TabIndex = 9;
            this.gulimButton.Text = "굴림";
            this.gulimButton.UseVisualStyleBackColor = true;
            this.gulimButton.Click += new System.EventHandler(this.gulimButton_Click);
            // 
            // batangButton
            // 
            this.batangButton.Location = new System.Drawing.Point(273, 27);
            this.batangButton.Name = "batangButton";
            this.batangButton.Size = new System.Drawing.Size(62, 33);
            this.batangButton.TabIndex = 10;
            this.batangButton.Text = "바탕";
            this.batangButton.UseVisualStyleBackColor = true;
            this.batangButton.Click += new System.EventHandler(this.batangButton_Click);
            // 
            // malgungothicButton
            // 
            this.malgungothicButton.Location = new System.Drawing.Point(341, 27);
            this.malgungothicButton.Name = "malgungothicButton";
            this.malgungothicButton.Size = new System.Drawing.Size(62, 33);
            this.malgungothicButton.TabIndex = 10;
            this.malgungothicButton.Text = "맑은고딕";
            this.malgungothicButton.UseVisualStyleBackColor = true;
            this.malgungothicButton.Click += new System.EventHandler(this.malgungothicButton_Click);
            // 
            // arialButton
            // 
            this.arialButton.Location = new System.Drawing.Point(409, 27);
            this.arialButton.Name = "arialButton";
            this.arialButton.Size = new System.Drawing.Size(62, 33);
            this.arialButton.TabIndex = 10;
            this.arialButton.Text = "Arial";
            this.arialButton.UseVisualStyleBackColor = true;
            this.arialButton.Click += new System.EventHandler(this.arialButton_Click);
            // 
            // verdanaButton
            // 
            this.verdanaButton.Location = new System.Drawing.Point(477, 27);
            this.verdanaButton.Name = "verdanaButton";
            this.verdanaButton.Size = new System.Drawing.Size(62, 33);
            this.verdanaButton.TabIndex = 10;
            this.verdanaButton.Text = "Verdana";
            this.verdanaButton.UseVisualStyleBackColor = true;
            this.verdanaButton.Click += new System.EventHandler(this.verdanaButton_Click);
            // 
            // rowIncButton
            // 
            this.rowIncButton.Location = new System.Drawing.Point(598, 27);
            this.rowIncButton.Name = "rowIncButton";
            this.rowIncButton.Size = new System.Drawing.Size(36, 33);
            this.rowIncButton.TabIndex = 7;
            this.rowIncButton.Text = "=+";
            this.rowIncButton.UseVisualStyleBackColor = true;
            this.rowIncButton.Click += new System.EventHandler(this.rowIncButton_Click);
            // 
            // rowDecButton
            // 
            this.rowDecButton.Location = new System.Drawing.Point(640, 27);
            this.rowDecButton.Name = "rowDecButton";
            this.rowDecButton.Size = new System.Drawing.Size(36, 33);
            this.rowDecButton.TabIndex = 8;
            this.rowDecButton.Text = "=-";
            this.rowDecButton.UseVisualStyleBackColor = true;
            this.rowDecButton.Click += new System.EventHandler(this.rowDecButton_Click);
            // 
            // marginIncButton
            // 
            this.marginIncButton.Location = new System.Drawing.Point(738, 27);
            this.marginIncButton.Name = "marginIncButton";
            this.marginIncButton.Size = new System.Drawing.Size(36, 33);
            this.marginIncButton.TabIndex = 8;
            this.marginIncButton.Text = "][+";
            this.marginIncButton.UseVisualStyleBackColor = true;
            this.marginIncButton.Click += new System.EventHandler(this.marginIncButton_Click);
            // 
            // marginDecButton
            // 
            this.marginDecButton.Location = new System.Drawing.Point(780, 27);
            this.marginDecButton.Name = "marginDecButton";
            this.marginDecButton.Size = new System.Drawing.Size(36, 33);
            this.marginDecButton.TabIndex = 8;
            this.marginDecButton.Text = "][-";
            this.marginDecButton.UseVisualStyleBackColor = true;
            this.marginDecButton.Click += new System.EventHandler(this.marginDecButton_Click);
            // 
            // fontSizeLabel
            // 
            this.fontSizeLabel.AutoSize = true;
            this.fontSizeLabel.Location = new System.Drawing.Point(9, 37);
            this.fontSizeLabel.Name = "fontSizeLabel";
            this.fontSizeLabel.Size = new System.Drawing.Size(53, 12);
            this.fontSizeLabel.TabIndex = 11;
            this.fontSizeLabel.Text = "글씨크기";
            // 
            // fontLabel
            // 
            this.fontLabel.AutoSize = true;
            this.fontLabel.Location = new System.Drawing.Point(158, 37);
            this.fontLabel.Name = "fontLabel";
            this.fontLabel.Size = new System.Drawing.Size(41, 12);
            this.fontLabel.TabIndex = 12;
            this.fontLabel.Text = "글씨체";
            // 
            // rowLabel
            // 
            this.rowLabel.AutoSize = true;
            this.rowLabel.Location = new System.Drawing.Point(545, 37);
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new System.Drawing.Size(53, 12);
            this.rowLabel.TabIndex = 12;
            this.rowLabel.Text = "행간조절";
            // 
            // marginLabel
            // 
            this.marginLabel.AutoSize = true;
            this.marginLabel.Location = new System.Drawing.Point(682, 37);
            this.marginLabel.Name = "marginLabel";
            this.marginLabel.Size = new System.Drawing.Size(53, 12);
            this.marginLabel.TabIndex = 13;
            this.marginLabel.Text = "여백조절";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 696);
            this.Controls.Add(this.marginLabel);
            this.Controls.Add(this.rowLabel);
            this.Controls.Add(this.fontLabel);
            this.Controls.Add(this.fontSizeLabel);
            this.Controls.Add(this.marginDecButton);
            this.Controls.Add(this.marginIncButton);
            this.Controls.Add(this.rowDecButton);
            this.Controls.Add(this.rowIncButton);
            this.Controls.Add(this.verdanaButton);
            this.Controls.Add(this.arialButton);
            this.Controls.Add(this.malgungothicButton);
            this.Controls.Add(this.batangButton);
            this.Controls.Add(this.gulimButton);
            this.Controls.Add(this.fontDecButton);
            this.Controls.Add(this.fontIncButton);
            this.Controls.Add(this.readall_button);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.PanelText);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.PanelTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "miniNews";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrame_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrame_FormClosed);
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ChannelMenuStrip.ResumeLayout(false);
            this.PanelTitle.ResumeLayout(false);
            this.PanelText.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 구독추가NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 인쇄PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Panel PanelText;
        private System.Windows.Forms.TreeView ViewChannel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ContextMenuStrip ChannelMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem rename;
        private System.Windows.Forms.ToolStripMenuItem del;
        private System.Windows.Forms.WebBrowser contentBrowser;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Button readall_button;
        private System.Windows.Forms.Button fontIncButton;
        private System.Windows.Forms.Button fontDecButton;
        private System.Windows.Forms.Button gulimButton;
        private System.Windows.Forms.Button batangButton;
        private System.Windows.Forms.Button malgungothicButton;
        private System.Windows.Forms.Button arialButton;
        private System.Windows.Forms.Button verdanaButton;
        private System.Windows.Forms.Button rowIncButton;
        private System.Windows.Forms.Button rowDecButton;
        private System.Windows.Forms.Button marginIncButton;
        private System.Windows.Forms.Button marginDecButton;
        private System.Windows.Forms.Label fontSizeLabel;
        private System.Windows.Forms.Label fontLabel;
        private System.Windows.Forms.Label rowLabel;
        private System.Windows.Forms.Label marginLabel;
        private System.Windows.Forms.ToolStripMenuItem 기사스크랩SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그램정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 원문기사보기ToolStripMenuItem;
    }
}

