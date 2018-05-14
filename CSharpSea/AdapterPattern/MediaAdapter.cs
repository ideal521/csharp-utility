using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class MediaAdapter : MediaPlayer
    {
        AdvancedMediaPlayer advancedMediaPlayer;

        public MediaAdapter(string audioType)
        {
            if(audioType == "vlc")
            {
                advancedMediaPlayer = new VlcPlayer();
            }else if(audioType == "mp4")
            {
                advancedMediaPlayer = new Mp4Player();
            }
        }

        public void play(string audioType, string fileName)
        {
            if (audioType == "vlc")
            {
                advancedMediaPlayer.playVlc(fileName);
            }
            else if (audioType == "mp4")
            {
                advancedMediaPlayer.playMp4(fileName);
            }
        }
    }
}
