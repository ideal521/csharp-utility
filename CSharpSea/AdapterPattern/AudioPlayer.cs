using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class AudioPlayer : MediaPlayer
    {
        MediaAdapter mediaAdapter;

        public void play(string audioType, string fileName)
        {
            //播放 mp3 音乐文件的内置支持
            if (audioType == "mp3")
            {
                Console.WriteLine("Playing mp3 file. Name: " + fileName);
            }

            else if (audioType == "vlc" || audioType == "mp4")
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.play(audioType, fileName);
            }
            else
            {
                Console.WriteLine("Invalid media. " +
            audioType + " format not supported");
            }
        }
    }
}
