This Windows program extracts subtitles tracks from video files and optionaly adds a dual language subtitle created from combining subtitle tracks of two selected languages back to the original file or replaces an existing subtitle track with the dual language subtitle. Only text subtitles are supported. 

The input:

Folder path where the videos are located. Only mp4 files are supported.

Folder path where FFMPEG files are located.

Folder path where the output will be generated. Cannnot be the same as video path.

Three-letter language code of the top tow of the merged subtitle. Can be detected. Will be used for the language code for the merged track. For reference check https://en.wikipedia.org/wiki/List_of_ISO_639-2_codes.

Three-letter language code of the buttom tow of the merged subtitle. Can be detected.

Font size for each language in the merged subtitle. Can be in a number (e.g. 14) or in pixels (e.g. 14px). Technically unofficial and no guaranteed support from players/trancoders. Can be empty and leave the font choice to video players. Use Clear Formating if the original subtitles contain font tags. 

Known players supporting font size tags in subtitle: VLC for Windows.
Known players not supporting: VLC for Android. 

Work mode:

Create Separate file: extract subtitle tracks in subrip format, if possible. Graphics subtitles are not supported. 

Inject to Video: add the merged title as an additional track or replace an existing track. Will skip if video contains only one language for textual subtitles and no dual language subtitle can be created.

Set as default: Set the merged title as the default subtitle track. No guaranteed support from players/trancoders. 

Known players supporting default subtitle track: VLC for Windows.
Known players not supporting: VLC for Android. 

Clear formating: remove rich formatting when writing subtitles. If leave unchecked, font size setting may not function as expected.  

Requirements:

FFMPEG. can be downloaded from https://www.ffmpeg.org/.

.Net Desktop Runtime. can be downloaded from https://dotnet.microsoft.com/en-us/download/dotnet/8.0

Although this theoretically can run on 32 bit and arm CPU, only 64 bit CPU is tested.

