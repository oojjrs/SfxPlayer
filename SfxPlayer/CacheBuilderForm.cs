using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace SfxPlayer
{
    public partial class CacheBuilderForm : Form
    {
        private readonly string _path;

        private int _count;

        public CacheBuilderForm(string path)
        {
            _path = path;

            InitializeComponent();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;

            foreach (var path in Directory.EnumerateFiles(_path, "*", SearchOption.AllDirectories))
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    Cache.Upsert(path);

                    worker.ReportProgress(Math.Min(++_count / 10, 99));
                }
            }

            worker.ReportProgress(100);
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                DialogResult = DialogResult.Cancel;
            else
                DialogResult = DialogResult.OK;

            Close();
        }

        private void CacheBuilderForm_Load(object sender, EventArgs e)
        {
            Cache.ClearDirties();
            Cache.Upsert(_path);

            backgroundWorker.RunWorkerAsync();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
        }
    }
}
