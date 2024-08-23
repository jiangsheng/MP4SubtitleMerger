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
            textBoxVideoPath = new TextBox();
            tableLayoutPanelWorkMode = new TableLayoutPanel();
            radioButtonInjectToVideo = new RadioButton();
            radioButtonExtractFiles = new RadioButton();
            checkBoxSetAsDefault = new CheckBox();
            checkBoxClearFormating = new CheckBox();
            checkBoxReplaceLastTopRowLanguageTrackIfNotFirst = new CheckBox();
            textBoxReplaceTrackLanguage = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxFFMPEGPath = new TextBox();
            buttonFFMPEGPath = new Button();
            buttonVideoPath = new Button();
            textBoxOutputFolder = new TextBox();
            buttonOutputFolder = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBoxTopRowLanguage = new TextBox();
            label1 = new Label();
            textBoxTopRowFontSize = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            textBoxBottomRowLanguage = new TextBox();
            label2 = new Label();
            textBoxButtomRowFontSize = new TextBox();
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
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
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
            toolStripContainerMain.ContentPanel.Size = new Size(1163, 652);
            toolStripContainerMain.Dock = DockStyle.Fill;
            toolStripContainerMain.LeftToolStripPanelVisible = false;
            toolStripContainerMain.Location = new Point(0, 0);
            toolStripContainerMain.Name = "toolStripContainerMain";
            toolStripContainerMain.RightToolStripPanelVisible = false;
            toolStripContainerMain.Size = new Size(1163, 718);
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
            statusStripBottom.Size = new Size(1163, 32);
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
            tableLayoutPanelMain.AutoSize = true;
            tableLayoutPanelMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanelMain.Controls.Add(textBoxVideoPath, 1, 1);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelWorkMode, 1, 5);
            tableLayoutPanelMain.Controls.Add(label4, 0, 3);
            tableLayoutPanelMain.Controls.Add(label5, 0, 4);
            tableLayoutPanelMain.Controls.Add(label6, 0, 5);
            tableLayoutPanelMain.Controls.Add(textBoxFFMPEGPath, 1, 0);
            tableLayoutPanelMain.Controls.Add(buttonFFMPEGPath, 0, 0);
            tableLayoutPanelMain.Controls.Add(buttonVideoPath, 0, 1);
            tableLayoutPanelMain.Controls.Add(textBoxOutputFolder, 1, 2);
            tableLayoutPanelMain.Controls.Add(buttonOutputFolder, 0, 2);
            tableLayoutPanelMain.Controls.Add(flowLayoutPanel1, 1, 3);
            tableLayoutPanelMain.Controls.Add(flowLayoutPanel2, 1, 4);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 6;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelMain.Size = new Size(1163, 652);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // textBoxVideoPath
            // 
            textBoxVideoPath.Dock = DockStyle.Fill;
            textBoxVideoPath.Location = new Point(177, 68);
            textBoxVideoPath.Name = "textBoxVideoPath";
            textBoxVideoPath.Size = new Size(983, 31);
            textBoxVideoPath.TabIndex = 4;
            // 
            // tableLayoutPanelWorkMode
            // 
            tableLayoutPanelWorkMode.AutoSize = true;
            tableLayoutPanelWorkMode.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelWorkMode.ColumnCount = 2;
            tableLayoutPanelWorkMode.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelWorkMode.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelWorkMode.Controls.Add(radioButtonInjectToVideo, 0, 0);
            tableLayoutPanelWorkMode.Controls.Add(radioButtonExtractFiles, 1, 0);
            tableLayoutPanelWorkMode.Controls.Add(checkBoxSetAsDefault, 0, 1);
            tableLayoutPanelWorkMode.Controls.Add(checkBoxClearFormating, 0, 2);
            tableLayoutPanelWorkMode.Controls.Add(checkBoxReplaceLastTopRowLanguageTrackIfNotFirst, 0, 3);
            tableLayoutPanelWorkMode.Controls.Add(textBoxReplaceTrackLanguage, 1, 3);
            tableLayoutPanelWorkMode.Dock = DockStyle.Fill;
            tableLayoutPanelWorkMode.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanelWorkMode.Location = new Point(177, 328);
            tableLayoutPanelWorkMode.Name = "tableLayoutPanelWorkMode";
            tableLayoutPanelWorkMode.RowCount = 4;
            tableLayoutPanelWorkMode.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelWorkMode.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelWorkMode.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelWorkMode.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelWorkMode.Size = new Size(983, 321);
            tableLayoutPanelWorkMode.TabIndex = 10;
            // 
            // radioButtonInjectToVideo
            // 
            radioButtonInjectToVideo.AutoSize = true;
            radioButtonInjectToVideo.Checked = true;
            radioButtonInjectToVideo.Dock = DockStyle.Fill;
            radioButtonInjectToVideo.Location = new Point(3, 3);
            radioButtonInjectToVideo.Name = "radioButtonInjectToVideo";
            radioButtonInjectToVideo.Size = new Size(485, 74);
            radioButtonInjectToVideo.TabIndex = 0;
            radioButtonInjectToVideo.TabStop = true;
            radioButtonInjectToVideo.Text = "Inject to Video";
            radioButtonInjectToVideo.UseVisualStyleBackColor = true;
            // 
            // radioButtonExtractFiles
            // 
            radioButtonExtractFiles.AutoSize = true;
            radioButtonExtractFiles.Dock = DockStyle.Fill;
            radioButtonExtractFiles.Location = new Point(494, 3);
            radioButtonExtractFiles.Name = "radioButtonExtractFiles";
            radioButtonExtractFiles.Size = new Size(486, 74);
            radioButtonExtractFiles.TabIndex = 1;
            radioButtonExtractFiles.Text = "Create Separate Files";
            radioButtonExtractFiles.UseVisualStyleBackColor = true;
            // 
            // checkBoxSetAsDefault
            // 
            checkBoxSetAsDefault.AutoSize = true;
            checkBoxSetAsDefault.Checked = true;
            checkBoxSetAsDefault.CheckState = CheckState.Checked;
            checkBoxSetAsDefault.Dock = DockStyle.Fill;
            checkBoxSetAsDefault.Location = new Point(3, 83);
            checkBoxSetAsDefault.Name = "checkBoxSetAsDefault";
            checkBoxSetAsDefault.Size = new Size(485, 74);
            checkBoxSetAsDefault.TabIndex = 8;
            checkBoxSetAsDefault.Text = "Set as Default";
            checkBoxSetAsDefault.UseVisualStyleBackColor = true;
            // 
            // checkBoxClearFormating
            // 
            checkBoxClearFormating.AutoSize = true;
            checkBoxClearFormating.Checked = true;
            checkBoxClearFormating.CheckState = CheckState.Checked;
            checkBoxClearFormating.Dock = DockStyle.Fill;
            checkBoxClearFormating.Location = new Point(3, 163);
            checkBoxClearFormating.Name = "checkBoxClearFormating";
            checkBoxClearFormating.Size = new Size(485, 74);
            checkBoxClearFormating.TabIndex = 9;
            checkBoxClearFormating.Text = "Clear Formating";
            checkBoxClearFormating.UseVisualStyleBackColor = true;
            // 
            // checkBoxReplaceLastTopRowLanguageTrackIfNotFirst
            // 
            checkBoxReplaceLastTopRowLanguageTrackIfNotFirst.AutoSize = true;
            checkBoxReplaceLastTopRowLanguageTrackIfNotFirst.Dock = DockStyle.Fill;
            checkBoxReplaceLastTopRowLanguageTrackIfNotFirst.Location = new Point(3, 243);
            checkBoxReplaceLastTopRowLanguageTrackIfNotFirst.Name = "checkBoxReplaceLastTopRowLanguageTrackIfNotFirst";
            checkBoxReplaceLastTopRowLanguageTrackIfNotFirst.Size = new Size(485, 75);
            checkBoxReplaceLastTopRowLanguageTrackIfNotFirst.TabIndex = 10;
            checkBoxReplaceLastTopRowLanguageTrackIfNotFirst.Text = "Replace the last track if its not the first of languae";
            checkBoxReplaceLastTopRowLanguageTrackIfNotFirst.UseVisualStyleBackColor = true;
            // 
            // textBoxReplaceTrackLanguage
            // 
            textBoxReplaceTrackLanguage.Dock = DockStyle.Fill;
            textBoxReplaceTrackLanguage.Location = new Point(494, 243);
            textBoxReplaceTrackLanguage.Name = "textBoxReplaceTrackLanguage";
            textBoxReplaceTrackLanguage.Size = new Size(486, 31);
            textBoxReplaceTrackLanguage.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 195);
            label4.Name = "label4";
            label4.Size = new Size(168, 65);
            label4.TabIndex = 5;
            label4.Text = "Top row language";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 260);
            label5.Name = "label5";
            label5.Size = new Size(168, 65);
            label5.TabIndex = 11;
            label5.Text = "Bottom Row Language";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 325);
            label6.Name = "label6";
            label6.Size = new Size(168, 327);
            label6.TabIndex = 9;
            label6.Text = "Work Mode";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxFFMPEGPath
            // 
            textBoxFFMPEGPath.Dock = DockStyle.Fill;
            textBoxFFMPEGPath.Location = new Point(177, 3);
            textBoxFFMPEGPath.Name = "textBoxFFMPEGPath";
            textBoxFFMPEGPath.Size = new Size(983, 31);
            textBoxFFMPEGPath.TabIndex = 1;
            textBoxFFMPEGPath.UseWaitCursor = true;
            // 
            // buttonFFMPEGPath
            // 
            buttonFFMPEGPath.Dock = DockStyle.Fill;
            buttonFFMPEGPath.Location = new Point(3, 3);
            buttonFFMPEGPath.Name = "buttonFFMPEGPath";
            buttonFFMPEGPath.Size = new Size(168, 59);
            buttonFFMPEGPath.TabIndex = 15;
            buttonFFMPEGPath.Text = "FFMPEG Path";
            buttonFFMPEGPath.TextAlign = ContentAlignment.MiddleRight;
            buttonFFMPEGPath.UseVisualStyleBackColor = true;
            buttonFFMPEGPath.Click += buttonFFMPEGPath_Click;
            // 
            // buttonVideoPath
            // 
            buttonVideoPath.Dock = DockStyle.Fill;
            buttonVideoPath.Location = new Point(3, 68);
            buttonVideoPath.Name = "buttonVideoPath";
            buttonVideoPath.Size = new Size(168, 59);
            buttonVideoPath.TabIndex = 16;
            buttonVideoPath.Text = "Video Path";
            buttonVideoPath.TextAlign = ContentAlignment.MiddleRight;
            buttonVideoPath.UseVisualStyleBackColor = true;
            buttonVideoPath.Click += buttonVideoPath_Click;
            // 
            // textBoxOutputFolder
            // 
            textBoxOutputFolder.Dock = DockStyle.Fill;
            textBoxOutputFolder.Location = new Point(177, 133);
            textBoxOutputFolder.Name = "textBoxOutputFolder";
            textBoxOutputFolder.Size = new Size(983, 31);
            textBoxOutputFolder.TabIndex = 14;
            // 
            // buttonOutputFolder
            // 
            buttonOutputFolder.Dock = DockStyle.Fill;
            buttonOutputFolder.Location = new Point(3, 133);
            buttonOutputFolder.Name = "buttonOutputFolder";
            buttonOutputFolder.Size = new Size(168, 59);
            buttonOutputFolder.TabIndex = 17;
            buttonOutputFolder.Text = "Output Folder";
            buttonOutputFolder.TextAlign = ContentAlignment.MiddleRight;
            buttonOutputFolder.UseVisualStyleBackColor = true;
            buttonOutputFolder.Click += buttonOutputFolder_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(textBoxTopRowLanguage);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(textBoxTopRowFontSize);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(177, 198);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(983, 59);
            flowLayoutPanel1.TabIndex = 18;
            // 
            // textBoxTopRowLanguage
            // 
            textBoxTopRowLanguage.Location = new Point(3, 3);
            textBoxTopRowLanguage.Name = "textBoxTopRowLanguage";
            textBoxTopRowLanguage.Size = new Size(186, 31);
            textBoxTopRowLanguage.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 7;
            label1.Text = "Font Size";
            // 
            // textBoxTopRowFontSize
            // 
            textBoxTopRowFontSize.Location = new Point(285, 3);
            textBoxTopRowFontSize.Name = "textBoxTopRowFontSize";
            textBoxTopRowFontSize.Size = new Size(150, 31);
            textBoxTopRowFontSize.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(textBoxBottomRowLanguage);
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(textBoxButtomRowFontSize);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(177, 263);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(983, 59);
            flowLayoutPanel2.TabIndex = 19;
            // 
            // textBoxBottomRowLanguage
            // 
            textBoxBottomRowLanguage.Location = new Point(3, 3);
            textBoxBottomRowLanguage.Name = "textBoxBottomRowLanguage";
            textBoxBottomRowLanguage.Size = new Size(189, 31);
            textBoxBottomRowLanguage.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 13;
            label2.Text = "Font Size";
            // 
            // textBoxButtomRowFontSize
            // 
            textBoxButtomRowFontSize.Location = new Point(288, 3);
            textBoxButtomRowFontSize.Name = "textBoxButtomRowFontSize";
            textBoxButtomRowFontSize.Size = new Size(150, 31);
            textBoxButtomRowFontSize.TabIndex = 14;
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
            ClientSize = new Size(1163, 718);
            Controls.Add(toolStripContainerMain);
            Name = "FormMain";
            Text = "MP4 Subtitle Merger, merges two subtitles in the video files under the input folder into one";
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            toolStripContainerMain.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainerMain.BottomToolStripPanel.PerformLayout();
            toolStripContainerMain.ContentPanel.ResumeLayout(false);
            toolStripContainerMain.ContentPanel.PerformLayout();
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
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            toolStripTop.ResumeLayout(false);
            toolStripTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainerMain;
        private TableLayoutPanel tableLayoutPanelMain;
        private TextBox textBoxFFMPEGPath;
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
        private TextBox textBoxOutputFolder;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CheckBox checkBoxClearFormating;
        private CheckBox checkBoxReplaceLastTopRowLanguageTrackIfNotFirst;
        private Button buttonFFMPEGPath;
        private Button buttonVideoPath;
        private Button buttonOutputFolder;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox textBoxTopRowFontSize;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label2;
        private TextBox textBoxButtomRowFontSize;
        private TextBox textBoxReplaceTrackLanguage;
    }
}
