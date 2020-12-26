namespace SfxPlayer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.pathAddButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            this.splitContainer.Panel1.Controls.Add(this.pathAddButton);
            this.splitContainer.Size = new System.Drawing.Size(2186, 1378);
            this.splitContainer.SplitterDistance = 728;
            this.splitContainer.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 50);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(728, 1328);
            this.treeView.TabIndex = 3;
            // 
            // pathAddButton
            // 
            this.pathAddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pathAddButton.Location = new System.Drawing.Point(0, 0);
            this.pathAddButton.Name = "pathAddButton";
            this.pathAddButton.Size = new System.Drawing.Size(728, 50);
            this.pathAddButton.TabIndex = 1;
            this.pathAddButton.Text = "관리 경로 추가";
            this.pathAddButton.UseVisualStyleBackColor = true;
            this.pathAddButton.Click += new System.EventHandler(this.pathAddButton_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "사운드 파일들이 있는 폴더를 선택해 주세요";
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2186, 1378);
            this.Controls.Add(this.splitContainer);
            this.Name = "MainForm";
            this.Text = "SfxPlayer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button pathAddButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

