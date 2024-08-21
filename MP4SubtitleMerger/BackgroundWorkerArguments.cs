namespace MP4SubtitleMerger;
public class BackgroundWorkerArguments {
    public BackgroundWorkerArguments(string fFMPEGPath, string videoPath, string topRowLanguage, string bottomRowLanguage, string outputFolder, BackgroundWorkerWorkMode workMode
        ,bool setAsDefault)
    {
        FFMPEGPath = fFMPEGPath;
        VideoPath = videoPath;
        TopRowLanguage = topRowLanguage;
        BottomRowLanguage = bottomRowLanguage;
        OutputFolder = outputFolder;
        WorkMode = workMode;
        SetAsDefault = setAsDefault;
    }

    public string FFMPEGPath { get; set; }
    public string VideoPath { get; set; }
    public string TopRowLanguage { get; set; }
    public string BottomRowLanguage { get; set; }
    public string OutputFolder { get; set; }
    public BackgroundWorkerWorkMode WorkMode { get; set; }
    public bool SetAsDefault { get; }

}

