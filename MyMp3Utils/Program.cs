using System.IO;
using TagLib;

namespace MyMp3Utils
{
    class Program
    {
        static void Main(string[] args)
        {
            var mp3Paths = Directory.GetFiles(args[0], "*.mp3", SearchOption.AllDirectories);
            foreach (var mp3 in mp3Paths)
            {
                var file = TagLib.File.Create(mp3);
                file.Tag.Pictures = new IPicture[0];
                file.Tag.Track = 0;
                file.Tag.TrackCount = 0;
                file.Tag.Year = 0;
                file.Save();
            }
        }
    }
}
