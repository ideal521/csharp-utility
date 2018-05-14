using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Mp4Player : AdvancedMediaPlayer
    {
        public void playMp4(string fileName)
        {            
            Console.WriteLine("Playing mp4 file. Name: " + fileName);
        }

        public void playVlc(string fileName)
        {
            //什么也不做
        }
    }
}
