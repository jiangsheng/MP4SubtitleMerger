This program extracts language subtitles from video files and optionaly add a dual language subtitle created from combining two selected languages back to the original file. Only text subtitles are supported. 

The input:

Folder path where the videos are located. Only mp4 files supported.
Folder path where FFMPEG files located
Folder path where the output will be generated. cannnot be the same as video path.

Language code of the top tow of the merged subtitle. Can be detected. Will be used for the language code for the merged title.
Language of the buttom tow of the merged subtitle. Can be detected.

Work mode.
Create Separate file: extract subtitle tracks in subrip format, if possible.
Inject to Video: add the merged title as an additional track. Will skip if video contains only one language for textual subtitles.
Set as default: Set the merged title as the default subtitle track. 
Font size: specify font size for each language. Can be in a number (e.g. 14) or in pixels (e.g. 14px). Technically unofficial and no guaranteed support from players/trancoders. 
Clear formating: remove rich formatting when writing subtitles. 

Requirements:

FFMPEG. can be downloaded from https://www.ffmpeg.org/.

.Net Desktop Runtime. can be downloaded from https://dotnet.microsoft.com/en-us/download/dotnet/8.0

Although this theoretically can run on 32 bit and arm CPU, only 64 bit CPU is tested.

