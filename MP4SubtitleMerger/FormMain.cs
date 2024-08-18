using FFMpegCore;
using System.IO;
using System.IO.Enumeration;

namespace MP4SubtitleMerger
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripButtonDetectLanguages_Click(object sender, EventArgs e)
        {
            try
            {
                var files = Directory.EnumerateFiles(textBoxVideoPath.Text, "*.mp4");
                if (files.Count() == 0)
                    throw new FileNotFoundException("No mp4 file under specified folder");
                foreach (var file in files)
                {
                    FFOptions options = new FFOptions();
                    options.TemporaryFilesFolder = Path.GetTempPath();
                    options.BinaryFolder = textBoxFFMPEGPath.Text;
                    var mediaInfo = FFProbe.Analyse(file, options);
                    if (mediaInfo != null && mediaInfo.SubtitleStreams != null)
                    {
                        if (mediaInfo.SubtitleStreams.Count < 2)
                        {
                            continue;
                        }
                        textBoxTopRowLanguage.Text = mediaInfo.SubtitleStreams[0].Language;
                        textBoxBottomRowLanguage.Text = mediaInfo.SubtitleStreams[1].Language;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            textBoxFFMPEGPath.Text = Properties.Settings.Default.FFMPEGPath;
            textBoxVideoPath.Text = Properties.Settings.Default.InputPath;
            textBoxTopRowLanguage.Text = Properties.Settings.Default.TopRowLanguage;
            textBoxBottomRowLanguage.Text = Properties.Settings.Default.ButtonRowLanguage;
            checkBoxSetAsDefault.Checked = Properties.Settings.Default.SetCombinedSubtitleAsDefault;
            radioButtonExtractFiles.Checked = Properties.Settings.Default.CreateSeparateFilesChecked;
            radioButtonRepalceVideo.Checked = Properties.Settings.Default.ModifyOriginalVideoChecked;

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.FFMPEGPath = textBoxFFMPEGPath.Text;
            Properties.Settings.Default.InputPath = textBoxVideoPath.Text;
            Properties.Settings.Default.TopRowLanguage = textBoxTopRowLanguage.Text;
            Properties.Settings.Default.ButtonRowLanguage = textBoxBottomRowLanguage.Text;

            Properties.Settings.Default.SetCombinedSubtitleAsDefault = checkBoxSetAsDefault.Checked;
            Properties.Settings.Default.CreateSeparateFilesChecked = radioButtonExtractFiles.Checked;
            Properties.Settings.Default.ModifyOriginalVideoChecked = radioButtonRepalceVideo.Checked;
            Properties.Settings.Default.Save();
        }

        private void toolStripButtonStart_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists(textBoxFFMPEGPath.Text))
            {
                MessageBox.Show("Specified video folder does not exist");
                return;
            }
            if (!File.Exists(Path.Combine(textBoxFFMPEGPath.Text, "ffmpeg.exe")))
            {
                MessageBox.Show("ffmpeg.exe not found in specified folder");
                return;
            }
       
            GlobalFFOptions.Configure(new FFOptions { BinaryFolder = textBoxFFMPEGPath.Text, TemporaryFilesFolder = Path.GetTempPath() });
            try
            {
                var files = Directory.EnumerateFiles(textBoxVideoPath.Text, "*.mp4");
                if (files.Count() == 0)
                    throw new FileNotFoundException("No mp4 file under specified folder");
                foreach (var file in files)
                {                    
                    var mediaInfo = FFProbe.Analyse(file);
                    if (mediaInfo != null && mediaInfo.SubtitleStreams != null)
                    {
                        if (mediaInfo.SubtitleStreams.Count < 2)
                        {
                            continue;
                        }
                        var topRowSubtitleStream = mediaInfo.SubtitleStreams.Where(
                            s => s.Language == textBoxTopRowLanguage.Text).FirstOrDefault();
                        var buttonRowSubtitleStream = mediaInfo.SubtitleStreams.Where(
                            s => s.Language == textBoxBottomRowLanguage.Text).FirstOrDefault();
                        SubtitleInfo? higherSubtitle= GetSubtitle(file,topRowSubtitleStream);
                        SubtitleInfo? lowerSubtitle = GetSubtitle(file, buttonRowSubtitleStream);
                        var mergedSubtitle= SubtitleInfo.Merge(higherSubtitle, lowerSubtitle);
                        if (radioButtonExtractFiles.Checked)
                        {
                            if (topRowSubtitleStream != null && higherSubtitle!=null)
                            {
                                var higherSubtitleFileName =
                                    string.Format("{0}.{1}.srt", file, topRowSubtitleStream.Language);
                                File.WriteAllText(higherSubtitleFileName, higherSubtitle.ToText());
                            }
                            if (buttonRowSubtitleStream != null && lowerSubtitle != null)
                            {
                                var lowerSubtitleFileName =
                                    string.Format("{0}.{1}.srt", file, buttonRowSubtitleStream.Language);
                                File.WriteAllText(lowerSubtitleFileName, lowerSubtitle.ToText());
                            }
                            if (mergedSubtitle != null && topRowSubtitleStream!=null && buttonRowSubtitleStream!=null)
                            {
                                var mergeSubtitleFileName =
                                   string.Format("{0}.{1}.{2}.srt", file, topRowSubtitleStream.Language,
                                   buttonRowSubtitleStream.Language);
                                var mergedSubtitleInfo = new SubtitleInfo(mergedSubtitle);
                                File.WriteAllText(mergeSubtitleFileName, mergedSubtitleInfo.ToText());
                            }
                        }
                        else if (radioButtonRepalceVideo.Checked)
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        SubtitleInfo? GetSubtitle(string file, SubtitleStream? subtitleStream)
        {
            if (subtitleStream == null) return null;
            try
            {
                FFOptions options = new FFOptions();
                options.TemporaryFilesFolder = Path.GetTempPath();
                options.BinaryFolder = textBoxFFMPEGPath.Text;

                var tempFolder=Path.GetTempPath();
                var tempSubtitleFile = Path.Combine(tempFolder,
string.Format("{0}.{1}.srt", Path.GetFileName(file), subtitleStream.Language));
                //ffmpeg -y -i file -map 0:streamIndex -c subrip tempSubtitleFile 
                var argument = FFMpegArguments.FromFileInput(file)
                .OutputToFile(tempSubtitleFile, true/*-y*/, opt => opt.SelectStream(subtitleStream.Index)
                .WithCustomArgument("-c subrip")
                );
                var result= argument.ProcessSynchronously(true);
                var text=File.ReadAllText(tempSubtitleFile);
                return SubtitleInfo.FromText(text);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
