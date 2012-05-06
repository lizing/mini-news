using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Collections.ObjectModel;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Diagnostics;

namespace RssProject
{
    [Serializable]
    public partial class MainFrame : Form
    {
        //private static const int MAX_FEED = 60;
        Collection<Rss> feedList;
        [NonSerialized()] private string url;
        [NonSerialized()] private string newName;
        [NonSerialized()] private string currrentDocument;
        [NonSerialized()] private Uri currentDocumentLink;

        public MainFrame()
        {
            InitializeComponent();
            url = null;
            newName = null;
            currrentDocument = "";
            currentDocumentLink = null;
        }

        public void setUrl(string url)
        {
            this.url = url;
        }

        public void setNewName(string newName)
        {
            this.newName = newName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addSubscription();
        }

        private void addSubscription()
        {
            AddForm add_form = new AddForm(this);
            add_form.ShowDialog();

            if (url != null)
            {
                Rss newChannel = new Rss(url);

                if (newChannel.Title == null)
                {
                    MessageBox.Show("유효하지 않는 주소입니다.");
                    return;
                }
                feedList.Add(newChannel);
                FillViewChannel();
                url = null;
            }
        }

        private void FillViewChannel()
        {
            ViewChannel.BeginUpdate();
            ViewChannel.Nodes.Clear();
            foreach (Rss channel in feedList)
            {
                ViewChannel.Nodes.Add(new TreeNode(channel.Title));
            }
            ViewChannel.EndUpdate();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Collection<Item> list = feedList[ViewChannel.SelectedNode.Index].Items;
            if (listView1.SelectedItems.Count == 1)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Title == listView1.SelectedItems[0].Text)
                    {
                        contentBrowser.DocumentText = "<html><head><style type=\"text/css\">"
                                + "body{font-size:" + ContentSetting.FontSize.ToString() + ";"
                                + "font-family:" + ContentSetting.Font + ";"
                                + "line-height:" + ContentSetting.RowWidth.ToString() + "%; }"
                                + "</style></head><body style=\"width: " + ContentSetting.MarginWidth.ToString() + "px; \">"
                                + list[i].Description
                                + "</body></html>";
                        listView1.SelectedItems[0].Font = new Font(this.Font, FontStyle.Strikeout);
                        list[i].Read = true;
                        setContent(list[i].Description);
                        currentDocumentLink = list[i].Link;
                    }
                }
            }
        }

        private void ViewChannel_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string chName = ViewChannel.SelectedNode.Text;
            //listView1.Items.Clear();
            for (int i = 0; i < feedList.Count; i++)
            {
                if (chName == feedList[i].Title)
                    setListView(i);
            }
        }


        private void setListView(int index)
        {
            listView1.Items.Clear();
            foreach(Item item in feedList[index].Items.OrderByDescending(x => x.PubDate))
            {
                ListViewItem lvItem = new ListViewItem(item.Title);
                if (item.Read == true)
                    lvItem.Font = new Font(this.Font, FontStyle.Strikeout);
                lvItem.SubItems.Add(item.PubDate.ToString());
                //listView1.Sorting = SortOrder.Descending;
                listView1.Items.Add(lvItem);
            }
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            try
            {
                Stream stream = File.Open("feedinfo.ser", FileMode.Open);
                BinaryFormatter bformatter = new BinaryFormatter();
                this.feedList = (Collection<Rss>)bformatter.Deserialize(stream);
                FillViewChannel();
                stream.Close();
            }
            catch
            {
                this.feedList = new Collection<Rss>();
            }
        }

        private void MainFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("정말 종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void 구독추가NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addSubscription();
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rename_Click(object sender, EventArgs e)
        {
            string chName = ViewChannel.SelectedNode.Text;
            foreach (Rss ch in feedList)
            {
                if (chName == ch.Title)
                {
                    DialogResult dr = new DialogResult();
                    RenameForm rename_form = new RenameForm(this);
                    dr = rename_form.ShowDialog();

                    if (dr == DialogResult.OK)
                    {
                        if (newName != null)
                        {
                            ch.Title = newName;
                            newName = null;
                        }
                        FillViewChannel();
                    }
                }
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (ViewChannel.SelectedNode == null)
            {
                MessageBox.Show("삭제할 채널을 선택해 주세요.");
                return;
            }
            string chName = ViewChannel.SelectedNode.Text;
            for (int i = 0; i < feedList.Count; i++)
            {
                if (feedList[i].Title == chName)
                    feedList.RemoveAt(i);
            }
            FillViewChannel();
            listView1.Items.Clear();
        }

        private void MainFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stream stream = File.Open("feedinfo.ser", FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();

            bformatter.Serialize(stream, feedList);
            stream.Close();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            string chName;

            for (int i = 0; i < feedList.Count; i++)
            {
                feedList[i].delReadItems();
                feedList[i].updateItems();
            }

            for (int j = 0; j < feedList.Count; j++)
            {
                if (ViewChannel.SelectedNode != null)
                {
                    chName = ViewChannel.SelectedNode.Text;
                    if (feedList[j].Title == chName)
                        setListView(j);
                }
            }
            
        }

        private void readall_button_Click(object sender, EventArgs e)
        {
            if (ViewChannel.SelectedNode == null)
            {
                MessageBox.Show("모두 읽음을 선택 할 채널을 선택해주세요.");
                return;
            }

            string chName = ViewChannel.SelectedNode.Text;

            for (int i = 0; i < feedList.Count; i++)
            {
                if (chName == feedList[i].Title)
                {
                    feedList[i].Items.Clear();
                    setListView(i);
                }
            }
        }

        private void fontIncButton_Click(object sender, EventArgs e)
        {
            if (ContentSetting.FontSize < 25)
            {
                ContentSetting.FontSize++;
                contentBrowser.DocumentText = "<html><head><style type=\"text/css\">"
                        + "body{font-size:" + ContentSetting.FontSize.ToString() + ";"
                        + "font-family:" + ContentSetting.Font + ";"
                        + "line-height:" + ContentSetting.RowWidth.ToString() + "%; }"
                        + "</style></head><body style=\"width: " + ContentSetting.MarginWidth.ToString() + "px; \">"
                                + currrentDocument
                                + "</body></html>";
            }
        }

        private void setContent(string content)
        {
            this.currrentDocument = content;
        }

        private void fontDecButton_Click(object sender, EventArgs e)
        {
            if (ContentSetting.FontSize > 10)
            {
                ContentSetting.FontSize--;
                contentBrowser.DocumentText = "<html><head><style type=\"text/css\">"
                        + "body{font-size:" + ContentSetting.FontSize.ToString() + ";"
                        + "font-family:" + ContentSetting.Font + ";"
                        + "line-height:" + ContentSetting.RowWidth.ToString() + "%; }"
                        + "</style></head><body style=\"width: " + ContentSetting.MarginWidth.ToString() + "px; \">"
                                + currrentDocument
                                + "</body></html>";
            }
        }

        private void gulimButton_Click(object sender, EventArgs e)
        {
            ContentSetting.Font = ContentSetting.FONT_GULIM;
            contentBrowser.DocumentText = "<html><head><style type=\"text/css\">"
                        + "body{font-size:" + ContentSetting.FontSize.ToString() + ";"
                        + "font-family:" + ContentSetting.Font + ";"
                        + "line-height:" + ContentSetting.RowWidth.ToString() + "%; }"
                        + "</style></head><body style=\"width: " + ContentSetting.MarginWidth.ToString() + "px; \">"
                                + currrentDocument
                                + "</body></html>";
        }

        private void batangButton_Click(object sender, EventArgs e)
        {
            ContentSetting.Font = ContentSetting.FONT_BATANG;
            contentBrowser.DocumentText = "<html><head><style type=\"text/css\">"
                        + "body{font-size:" + ContentSetting.FontSize.ToString() + ";"
                        + "font-family:" + ContentSetting.Font + ";"
                        + "line-height:" + ContentSetting.RowWidth.ToString() + "%; }"
                        + "</style></head><body style=\"width: " + ContentSetting.MarginWidth.ToString() + "px; \">"
                                + currrentDocument
                                + "</body></html>";
        }

        private void malgungothicButton_Click(object sender, EventArgs e)
        {
            ContentSetting.Font = ContentSetting.FONT_MALGUNGOTHIC;
            contentBrowser.DocumentText = "<html><head><style type=\"text/css\">"
                        + "body{font-size:" + ContentSetting.FontSize.ToString() + ";"
                        + "font-family:" + ContentSetting.Font + ";"
                        + "line-height:" + ContentSetting.RowWidth.ToString() + "%; }"
                        + "</style></head><body style=\"width: " + ContentSetting.MarginWidth.ToString() + "px; \">"
                                + currrentDocument
                                + "</body></html>";
        }

        private void arialButton_Click(object sender, EventArgs e)
        {
            ContentSetting.Font = ContentSetting.FONT_ARIAL;
            contentBrowser.DocumentText = "<html><head><style type=\"text/css\">"
                        + "body{font-size:" + ContentSetting.FontSize.ToString() + ";"
                        + "font-family:" + ContentSetting.Font + ";"
                        + "line-height:" + ContentSetting.RowWidth.ToString() + "%; }"
                        + "</style></head><body style=\"width: " + ContentSetting.MarginWidth.ToString() + "px; \">"
                                + currrentDocument
                                + "</body></html>";
        }

        private void verdanaButton_Click(object sender, EventArgs e)
        {
            ContentSetting.Font = ContentSetting.FONT_VERDANA;
            contentBrowser.DocumentText = "<html><head><style type=\"text/css\">"
                        + "body{font-size:" + ContentSetting.FontSize.ToString() + ";"
                        + "font-family:" + ContentSetting.Font + ";"
                        + "line-height:" + ContentSetting.RowWidth.ToString() + "%; }"
                        + "</style></head><body style=\"width: " + ContentSetting.MarginWidth.ToString() + "px; \">"
                                + currrentDocument
                                + "</body></html>";
        }

        private void rowIncButton_Click(object sender, EventArgs e)
        {
            if (ContentSetting.RowWidth < 300)
            {
                ContentSetting.RowWidth += 10;
                contentBrowser.DocumentText = "<html><head><style type=\"text/css\">"
                        + "body{font-size:" + ContentSetting.FontSize.ToString() + ";"
                        + "font-family:" + ContentSetting.Font + ";"
                        + "line-height:" + ContentSetting.RowWidth.ToString() + "%; }"
                        + "</style></head><body style=\"width: " + ContentSetting.MarginWidth.ToString() + "px; \">"
                                + currrentDocument
                                + "</body></html>";
            }
        }

        private void rowDecButton_Click(object sender, EventArgs e)
        {
            if (ContentSetting.RowWidth > 100)
            {
                ContentSetting.RowWidth -= 10;
                contentBrowser.DocumentText = "<html><head><style type=\"text/css\">"
                        + "body{font-size:" + ContentSetting.FontSize.ToString() + ";"
                        + "font-family:" + ContentSetting.Font + ";"
                        + "line-height:" + ContentSetting.RowWidth.ToString() + "%; }"
                        + "</style></head><body style=\"width: " + ContentSetting.MarginWidth.ToString() + "px; \">"
                                + currrentDocument
                                + "</body></html>";
            }
        }

        private void marginIncButton_Click(object sender, EventArgs e)
        {
            if (contentBrowser.Width <= 709)
            {
                contentBrowser.Location = new Point(contentBrowser.Location.X - 10, 0);
                contentBrowser.Width += 20;
                contentBrowser.DocumentText = "<html><head><style type=\"text/css\">"
                        + "body{font-size:" + ContentSetting.FontSize.ToString() + "; "
                        + "font-family:" + ContentSetting.Font + ";"
                        + "line-height:" + ContentSetting.RowWidth.ToString() + "%; }"
                        + "</style></head><body>"
                                + currrentDocument
                                + "</body></html>";
            }
        }

        private void marginDecButton_Click(object sender, EventArgs e)
        {
            if (contentBrowser.Width > 400)
            {
                contentBrowser.Location = new Point(contentBrowser.Location.X + 10, 0);
                contentBrowser.Width -= 20;
                contentBrowser.DocumentText = "<html><head><style type=\"text/css\">"
                        + "body{font-size:" + ContentSetting.FontSize.ToString() + ";"
                        + "font-family:" + ContentSetting.Font + ";"
                        + "line-height:" + ContentSetting.RowWidth.ToString() + "%; }"
                        + "</style></head><body>"
                                + currrentDocument
                                + "</body></html>";
            }
        }

        private void 기사스크랩SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contentBrowser.DocumentText == "")
            {
                MessageBox.Show("저장할 기사를 선택해 주세요.");
                return;
            }
            contentBrowser.ShowSaveAsDialog();
        }

        private void 인쇄PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contentBrowser.DocumentText == "")
            {
                MessageBox.Show("인쇄할 기사를 선택해 주세요.");
                return;
            }

            contentBrowser.ShowPrintDialog();
        }

        private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramInfo info = new ProgramInfo();
            info.ShowDialog();
        }

        private void 원문기사보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contentBrowser.DocumentText == "")
            {
                MessageBox.Show("기사를 선택해 주세요");
                return;
            }

            if (currentDocumentLink == null)
                return;
            
            Process.Start(currentDocumentLink.ToString());
        }
    }
}