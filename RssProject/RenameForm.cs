using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RssProject
{
    public partial class RenameForm : Form
    {
        private MainFrame mf;
        private string _newName;

        public RenameForm()
        {
            InitializeComponent();
        }

        public RenameForm(MainFrame mf)
        {
            InitializeComponent();
            this.mf = mf;
            textBox1.MaxLength = 20;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 20 || textBox1.Text.Length <= 0)
            {
                MessageBox.Show("채널 이름을 20자 이하로 입력해주세요.");
                textBox1.Text = "";
                textBox1.Focus();
                return;
            }
            _newName = textBox1.Text;
            mf.setNewName(_newName);
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                button1_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.Escape)
                button2_Click(sender, e);
        }
    }
}
