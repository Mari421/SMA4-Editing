using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Permissions;

namespace Solar_Magic_Advance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton_Load_Click(object sender, EventArgs e)
        {
            openFileDialog_Level.ShowDialog();
        }

        private void openFileDialog_Level_FileOk(object sender, CancelEventArgs e)
        {
            Program.LoadLevel(this, openFileDialog_Level.FileName, openFileDialog_Level.OpenFile());
        }

        private void eCoinEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eCoinEditor window = new eCoinEditor();
            window.ShowDialog();
            Program.InitTreeView(this);
            Program.UpdateTreeView(this);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Program.SaveLevel(this, saveFileDialog1.FileName, new FileStream(saveFileDialog1.FileName, FileMode.Create));   
        }

        private void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
    }
}