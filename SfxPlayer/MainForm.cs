using System;
using System.Windows.Forms;

namespace SfxPlayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pathAddButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var form = new CacheBuilderForm(folderBrowserDialog.SelectedPath);
                if (form.ShowDialog() == DialogResult.OK)
                    treeView.Nodes.AddRange(CreateTreeNodes(Cache.SelectAllDirties()));
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            treeView.Nodes.AddRange(CreateTreeNodes(Cache.SelectAll()));
        }
    }
}
