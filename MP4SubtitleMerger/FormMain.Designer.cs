namespace MP4SubtitleMerger
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            toolStripContainerMain = new ToolStripContainer();
            statusStripBottom = new StatusStrip();
            toolStripProgressBarStatus = new ToolStripProgressBar();
            toolStripStatusLabel = new ToolStripStatusLabel();
            tableLayoutPanelMain = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            textBoxFFMPEGPath = new TextBox();
            label3 = new Label();
            textBoxVideoPath = new TextBox();
            tableLayoutPanelWorkMode = new TableLayoutPanel();
            radioButtonInjectToVideo = new RadioButton();
            radioButtonExtractFiles = new RadioButton();
            checkBoxSetAsDefault = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            textBoxTopRowLanguage = new TextBox();
            textBoxBottomRowLanguage = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBoxOutputFolder = new TextBox();
            toolStripTop = new ToolStrip();
            toolStripButtonStart = new ToolStripButton();
            toolStripButtonStop = new ToolStripButton();
            toolStripButtonDetectLanguages = new ToolStripButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            toolStripContainerMain.BottomToolStripPanel.SuspendLayout();
            toolStripContainerMain.ContentPanel.SuspendLayout();
            toolStripContainerMain.TopToolStripPanel.SuspendLayout();
            toolStripContainerMain.SuspendLayout();
            statusStripBottom.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelWorkMode.SuspendLayout();
            toolStripTop.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainerMain
            // 
            // 
            // toolStripContainerMain.BottomToolStripPanel
            // 
            toolStripContainerMain.BottomToolStripPanel.Controls.Add(statusStripBottom);
            // 
            // toolStripContainerMain.ContentPanel
            // 
            toolStripContainerMain.ContentPanel.Controls.Add(tableLayoutPanelMain);
            toolStripContainerMain.ContentPanel.Size = new Size(1192, 338);
            toolStripContainerMain.Dock = DockStyle.Fill;
            toolStripContainerMain.Location = new Point(0, 0);
            toolStripContainerMain.Name = "toolStripContainerMain";
            toolStripContainerMain.Size = new Size(1192, 404);
            toolStripContainerMain.TabIndex = 0;
            toolStripContainerMain.Text = "toolStripContainer1";
            // 
            // toolStripContainerMain.TopToolStripPanel
            // 
            toolStripContainerMain.TopToolStripPanel.Controls.Add(toolStripTop);
            // 
            // statusStripBottom
            // 
            statusStripBottom.Dock = DockStyle.None;
            statusStripBottom.ImageScalingSize = new Size(24, 24);
            statusStripBottom.Items.AddRange(new ToolStripItem[] { toolStripProgressBarStatus, toolStripStatusLabel });
            statusStripBottom.Location = new Point(0, 0);
            statusStripBottom.Name = "statusStripBottom";
            statusStripBottom.Size = new Size(1192, 32);
            statusStripBottom.TabIndex = 0;
            // 
            // toolStripProgressBarStatus
            // 
            toolStripProgressBarStatus.Name = "toolStripProgressBarStatus";
            toolStripProgressBarStatus.Size = new Size(200, 24);
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(60, 25);
            toolStripStatusLabel.Text = "Ready";
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelMain.Controls.Add(label2, 0, 2);
            tableLayoutPanelMain.Controls.Add(label1, 0, 1);
            tableLayoutPanelMain.Controls.Add(textBoxFFMPEGPath, 1, 1);
            tableLayoutPanelMain.Controls.Add(label3, 1, 0);
            tableLayoutPanelMain.Controls.Add(textBoxVideoPath, 1, 2);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelWorkMode, 1, 5);
            tableLayoutPanelMain.Controls.Add(label4, 0, 3);
            tableLayoutPanelMain.Controls.Add(label5, 0, 4);
            tableLayoutPanelMain.Controls.Add(textBoxTopRowLanguage, 1, 3);
            tableLayoutPanelMain.Controls.Add(textBoxBottomRowLanguage, 1, 4);
            tableLayoutPanelMain.Controls.Add(label6, 0, 5);
            tableLayoutPanelMain.Controls.Add(label7, 0, 6);
            tableLayoutPanelMain.Controls.Add(textBoxOutputFolder, 1, 6);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 7;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.Size = new Size(1192, 338);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 62);
            label2.Name = "label2";
            label2.Size = new Size(193, 37);
            label2.TabIndex = 2;
            label2.Text = "Video Path";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 25);
            label1.Name = "label1";
            label1.Size = new Size(193, 37);
            label1.TabIndex = 0;
            label1.Text = "FFMPEG Path";
            // 
            // textBoxFFMPEGPath
            // 
            textBoxFFMPEGPath.Dock = DockStyle.Fill;
            textBoxFFMPEGPath.Location = new Point(202, 28);
            textBoxFFMPEGPath.Name = "textBoxFFMPEGPath";
            textBoxFFMPEGPath.Size = new Size(1026, 31);
            textBoxFFMPEGPath.TabIndex = 1;
            textBoxFFMPEGPath.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(202, 0);
            label3.Name = "label3";
            label3.Size = new Size(634, 25);
            label3.TabIndex = 3;
            label3.Text = "This tool merges two subtitles in the video files under the input folder into one";
            // 
            // textBoxVideoPath
            // 
            textBoxVideoPath.Dock = DockStyle.Fill;
            textBoxVideoPath.Location = new Point(202, 65);
            textBoxVideoPath.Name = "textBoxVideoPath";
            textBoxVideoPath.Size = new Size(1026, 31);
            textBoxVideoPath.TabIndex = 4;
            // 
            // tableLayoutPanelWorkMode
            // 
            tableLayoutPanelWorkMode.ColumnCount = 2;
            tableLayoutPanelWorkMode.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelWorkMode.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelWorkMode.Controls.Add(radioButtonInjectToVideo, 0, 0);
            tableLayoutPanelWorkMode.Controls.Add(radioButtonExtractFiles, 1, 0);
            tableLayoutPanelWorkMode.Controls.Add(checkBoxSetAsDefault, 0, 1);
            tableLayoutPanelWorkMode.Dock = DockStyle.Fill;
            tableLayoutPanelWorkMode.Location = new Point(202, 176);
            tableLayoutPanelWorkMode.Name = "tableLayoutPanelWorkMode";
            tableLayoutPanelWorkMode.RowCount = 3;
            tableLayoutPanelWorkMode.RowStyles.Add(new RowStyle());
            tableLayoutPanelWorkMode.RowStyles.Add(new RowStyle());
            tableLayoutPanelWorkMode.RowStyles.Add(new RowStyle());
            tableLayoutPanelWorkMode.Size = new Size(1026, 117);
            tableLayoutPanelWorkMode.TabIndex = 10;
            // 
            // radioButtonInjectToVideo
            // 
            radioButtonInjectToVideo.AutoSize = true;
            radioButtonInjectToVideo.Checked = true;
            radioButtonInjectToVideo.Location = new Point(3, 3);
            radioButtonInjectToVideo.Name = "radioButtonInjectToVideo";
            radioButtonInjectToVideo.Size = new Size(152, 29);
            radioButtonInjectToVideo.TabIndex = 0;
            radioButtonInjectToVideo.TabStop = true;
            radioButtonInjectToVideo.Text = "Inject to Video";
            radioButtonInjectToVideo.UseVisualStyleBackColor = true;
            // 
            // radioButtonExtractFiles
            // 
            radioButtonExtractFiles.AutoSize = true;
            radioButtonExtractFiles.Location = new Point(161, 3);
            radioButtonExtractFiles.Name = "radioButtonExtractFiles";
            radioButtonExtractFiles.Size = new Size(200, 29);
            radioButtonExtractFiles.TabIndex = 1;
            radioButtonExtractFiles.Text = "Create Separate Files";
            radioButtonExtractFiles.UseVisualStyleBackColor = true;
            // 
            // checkBoxSetAsDefault
            // 
            checkBoxSetAsDefault.AutoSize = true;
            checkBoxSetAsDefault.Dock = DockStyle.Fill;
            checkBoxSetAsDefault.Location = new Point(3, 38);
            checkBoxSetAsDefault.Name = "checkBoxSetAsDefault";
            checkBoxSetAsDefault.Size = new Size(152, 29);
            checkBoxSetAsDefault.TabIndex = 8;
            checkBoxSetAsDefault.Text = "Set as Default";
            checkBoxSetAsDefault.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 99);
            label4.Name = "label4";
            label4.Size = new Size(154, 25);
            label4.TabIndex = 5;
            label4.Text = "Top row language";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 136);
            label5.Name = "label5";
            label5.Size = new Size(193, 37);
            label5.TabIndex = 11;
            label5.Text = "Bottom Row Language";
            // 
            // textBoxTopRowLanguage
            // 
            textBoxTopRowLanguage.Dock = DockStyle.Fill;
            textBoxTopRowLanguage.Location = new Point(202, 102);
            textBoxTopRowLanguage.Name = "textBoxTopRowLanguage";
            textBoxTopRowLanguage.Size = new Size(1026, 31);
            textBoxTopRowLanguage.TabIndex = 6;
            // 
            // textBoxBottomRowLanguage
            // 
            textBoxBottomRowLanguage.Dock = DockStyle.Fill;
            textBoxBottomRowLanguage.Location = new Point(202, 139);
            textBoxBottomRowLanguage.Name = "textBoxBottomRowLanguage";
            textBoxBottomRowLanguage.Size = new Size(1026, 31);
            textBoxBottomRowLanguage.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 173);
            label6.Name = "label6";
            label6.Size = new Size(193, 123);
            label6.TabIndex = 9;
            label6.Text = "Work Mode";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 296);
            label7.Name = "label7";
            label7.Size = new Size(124, 25);
            label7.TabIndex = 13;
            label7.Text = "Output Folder";
            // 
            // textBoxOutputFolder
            // 
            textBoxOutputFolder.Dock = DockStyle.Fill;
            textBoxOutputFolder.Location = new Point(202, 299);
            textBoxOutputFolder.Name = "textBoxOutputFolder";
            textBoxOutputFolder.Size = new Size(1026, 31);
            textBoxOutputFolder.TabIndex = 14;
            // 
            // toolStripTop
            // 
            toolStripTop.Dock = DockStyle.None;
            toolStripTop.ImageScalingSize = new Size(24, 24);
            toolStripTop.Items.AddRange(new ToolStripItem[] { toolStripButtonStart, toolStripButtonStop, toolStripButtonDetectLanguages });
            toolStripTop.Location = new Point(4, 0);
            toolStripTop.Name = "toolStripTop";
            toolStripTop.Size = new Size(280, 34);
            toolStripTop.TabIndex = 0;
            // 
            // toolStripButtonStart
            // 
            toolStripButtonStart.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonStart.Image = (Image)resources.GetObject("toolStripButtonStart.Image");
            toolStripButtonStart.ImageTransparentColor = Color.Magenta;
            toolStripButtonStart.Name = "toolStripButtonStart";
            toolStripButtonStart.Size = new Size(52, 29);
            toolStripButtonStart.Text = "Start";
            toolStripButtonStart.Click += toolStripButtonStart_Click;
            // 
            // toolStripButtonStop
            // 
            toolStripButtonStop.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonStop.Image = (Image)resources.GetObject("toolStripButtonStop.Image");
            toolStripButtonStop.ImageTransparentColor = Color.Magenta;
            toolStripButtonStop.Name = "toolStripButtonStop";
            toolStripButtonStop.Size = new Size(53, 29);
            toolStripButtonStop.Text = "Stop";
            toolStripButtonStop.Click += toolStripButtonStop_Click;
            // 
            // toolStripButtonDetectLanguages
            // 
            toolStripButtonDetectLanguages.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonDetectLanguages.ImageTransparentColor = Color.Magenta;
            toolStripButtonDetectLanguages.Name = "toolStripButtonDetectLanguages";
            toolStripButtonDetectLanguages.Size = new Size(157, 29);
            toolStripButtonDetectLanguages.Text = "Detect Languages";
            toolStripButtonDetectLanguages.Click += toolStripButtonDetectLanguages_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 404);
            Controls.Add(toolStripContainerMain);
            Name = "FormMain";
            Text = "MP4 Subtitle Merger";
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            toolStripContainerMain.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainerMain.BottomToolStripPanel.PerformLayout();
            toolStripContainerMain.ContentPanel.ResumeLayout(false);
            toolStripContainerMain.TopToolStripPanel.ResumeLayout(false);
            toolStripContainerMain.TopToolStripPanel.PerformLayout();
            toolStripContainerMain.ResumeLayout(false);
            toolStripContainerMain.PerformLayout();
            statusStripBottom.ResumeLayout(false);
            statusStripBottom.PerformLayout();
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            tableLayoutPanelWorkMode.ResumeLayout(false);
            tableLayoutPanelWorkMode.PerformLayout();
            toolStripTop.ResumeLayout(false);
            toolStripTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainerMain;
        private TableLayoutPanel tableLayoutPanelMain;
        private Label label1;
        private TextBox textBoxFFMPEGPath;
        private Label label2;
        private Label label3;
        private TextBox textBoxVideoPath;
        private Label label4;
        private TextBox textBoxTopRowLanguage;
        private CheckBox checkBoxSetAsDefault;
        private Label label6;
        private TableLayoutPanel tableLayoutPanelWorkMode;
        private RadioButton radioButtonInjectToVideo;
        private RadioButton radioButtonExtractFiles;
        private StatusStrip statusStripBottom;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStrip toolStripTop;
        private ToolStripButton toolStripButtonStart;
        private ToolStripButton toolStripButtonStop;
        private ToolStripProgressBar toolStripProgressBarStatus;
        private Label label5;
        private TextBox textBoxBottomRowLanguage;
        private ToolStripButton toolStripButtonDetectLanguages;
        private Label label7;
        private TextBox textBoxOutputFolder;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
