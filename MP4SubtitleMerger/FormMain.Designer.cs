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
            toolStripContainer1 = new ToolStripContainer();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            textBoxFFMPEGPath = new TextBox();
            label3 = new Label();
            textBoxVideoPath = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            radioButtonRepalceVideo = new RadioButton();
            radioButtonExtractFiles = new RadioButton();
            checkBoxSetAsDefault = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            textBoxTopRowLanguage = new TextBox();
            textBoxBottomRowLanguage = new TextBox();
            label6 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButtonStart = new ToolStripButton();
            toolStripButtonStop = new ToolStripButton();
            toolStripButtonDetectLanguages = new ToolStripButton();
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            toolStripContainer1.BottomToolStripPanel.Controls.Add(statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(tableLayoutPanel1);
            toolStripContainer1.ContentPanel.Size = new Size(1192, 338);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(1192, 404);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1192, 32);
            statusStrip1.TabIndex = 0;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(60, 25);
            toolStripStatusLabel1.Text = "Ready";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 24);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxFFMPEGPath, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxVideoPath, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 5);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(textBoxTopRowLanguage, 1, 3);
            tableLayoutPanel1.Controls.Add(textBoxBottomRowLanguage, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1192, 338);
            tableLayoutPanel1.TabIndex = 0;
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(radioButtonRepalceVideo, 0, 0);
            tableLayoutPanel2.Controls.Add(radioButtonExtractFiles, 1, 0);
            tableLayoutPanel2.Controls.Add(checkBoxSetAsDefault, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(202, 176);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(1026, 117);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // radioButtonRepalceVideo
            // 
            radioButtonRepalceVideo.AutoSize = true;
            radioButtonRepalceVideo.Checked = true;
            radioButtonRepalceVideo.Location = new Point(3, 3);
            radioButtonRepalceVideo.Name = "radioButtonRepalceVideo";
            radioButtonRepalceVideo.Size = new Size(212, 29);
            radioButtonRepalceVideo.TabIndex = 0;
            radioButtonRepalceVideo.TabStop = true;
            radioButtonRepalceVideo.Text = "Modify Original Video";
            radioButtonRepalceVideo.UseVisualStyleBackColor = true;
            // 
            // radioButtonExtractFiles
            // 
            radioButtonExtractFiles.AutoSize = true;
            radioButtonExtractFiles.Location = new Point(516, 3);
            radioButtonExtractFiles.Name = "radioButtonExtractFiles";
            radioButtonExtractFiles.Size = new Size(200, 29);
            radioButtonExtractFiles.TabIndex = 1;
            radioButtonExtractFiles.Text = "Create Separate Files";
            radioButtonExtractFiles.UseVisualStyleBackColor = true;
            // 
            // checkBoxSetAsDefault
            // 
            checkBoxSetAsDefault.AutoSize = true;
            checkBoxSetAsDefault.Location = new Point(3, 38);
            checkBoxSetAsDefault.Name = "checkBoxSetAsDefault";
            checkBoxSetAsDefault.Size = new Size(147, 29);
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
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonStart, toolStripButtonStop, toolStripButtonDetectLanguages });
            toolStrip1.Location = new Point(4, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(326, 34);
            toolStrip1.TabIndex = 0;
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
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 404);
            Controls.Add(toolStripContainer1);
            Name = "FormMain";
            Text = "MP4 Subtitle Merger";
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox textBoxFFMPEGPath;
        private Label label2;
        private Label label3;
        private TextBox textBoxVideoPath;
        private Label label4;
        private TextBox textBoxTopRowLanguage;
        private CheckBox checkBoxSetAsDefault;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel2;
        private RadioButton radioButtonRepalceVideo;
        private RadioButton radioButtonExtractFiles;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonStart;
        private ToolStripButton toolStripButtonStop;
        private ToolStripProgressBar toolStripProgressBar1;
        private Label label5;
        private TextBox textBoxBottomRowLanguage;
        private ToolStripButton toolStripButtonDetectLanguages;
    }
}
