namespace MP4SubtitleMerger;
public class BackgroundWorkerArguments {
    public BackgroundWorkerArguments(string fFMPEGPath, string videoPath, string topRowLanguage, 
        string bottomRowLanguage, string outputFolder, BackgroundWorkerWorkMode workMode
        ,bool setAsDefault,bool clearFormating,bool replaceLastTopRowLanguageTrackIfNotFirst
        , string topRowFontSize
        , string bottomRowFontSize,
        string replaceTrackLanguage)
    {
        FFMPEGPath = fFMPEGPath;
        VideoPath = videoPath;
        TopRowLanguage = topRowLanguage;
        BottomRowLanguage = bottomRowLanguage;
        OutputFolder = outputFolder;
        WorkMode = workMode;
        SetAsDefault = setAsDefault;
        ClearFormating = clearFormating;
        ReplaceLastTopRowLanguageTrackIfNotFirst = replaceLastTopRowLanguageTrackIfNotFirst;
        TopRowFontSize = topRowFontSize;
        BottomRowFontSize = bottomRowFontSize;
        ReplaceTrackLanguage = replaceTrackLanguage;
    }

    public string FFMPEGPath { get; set; }
    public string VideoPath { get; set; }
    public string TopRowLanguage { get; set; }
    public string BottomRowLanguage { get; set; }
    public string OutputFolder { get; set; }
    public BackgroundWorkerWorkMode WorkMode { get; set; }
    public bool SetAsDefault { get; }
    public bool ClearFormating { get; set; }
    public bool ReplaceLastTopRowLanguageTrackIfNotFirst { get; set; }

    public string TopRowFontSize { get; set; }
    public string BottomRowFontSize { get; set; }
    public string ReplaceTrackLanguage { get; set; }

}

