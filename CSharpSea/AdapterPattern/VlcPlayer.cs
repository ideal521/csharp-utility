using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class VlcPlayer : AdvancedMediaPlayer
    {
        public void playMp4(string fileName)
        {
            // 什么也不做            
        }

        public void playVlc(string fileName)
        {
            Console.WriteLine("Playing vlc file. Name: " + fileName);
        }
    }
}
